using System;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;

namespace TextEditor {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            //Определяем номер страницы, с которой следует начать печать
            printDialog1.PrinterSettings.FromPage = 1;
            //Определяем максимальный номер печатаемой страницы.
            printDialog1.PrinterSettings.ToPage = printDialog1.PrinterSettings.MaximumPage;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e) {
            openFileDialog1.ShowDialog();
            var fileName = openFileDialog1.FileName;
            var filestream = File.Open(fileName, FileMode.Open, FileAccess.Read);

            if (filestream != null)
                using (var streamreader = new StreamReader(filestream))
                    rtbText.Text = streamreader.ReadToEnd();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
            saveFileDialog1.ShowDialog();
            var fileName = saveFileDialog1.FileName;
            var filestream = File.Open(fileName, FileMode.Create, FileAccess.Write);

            if (filestream != null)
                using (var streamwriter = new StreamWriter(filestream)) {
                    streamwriter.Write(rtbText.Text);
                    streamwriter.Flush();
                }
        }

        string stringPrintText;
        int startPage;
        int pagesCount;
        int pageNum;

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e) {
            var graph = e.Graphics;
            var font = rtbText.Font;
            var fontsHeight = font.GetHeight(graph);
            var stringFormat = new StringFormat();
            RectangleF rectangleFull;


            if (graph.VisibleClipBounds.X < 0)
                rectangleFull = e.MarginBounds;
            else
                rectangleFull = new RectangleF(
                    e.MarginBounds.Left - (e.PageBounds.Width - graph.VisibleClipBounds.Width) / 2,
                    e.MarginBounds.Top - (e.PageBounds.Height - graph.VisibleClipBounds.Height) / 2,
                    e.MarginBounds.Width, e.MarginBounds.Height);

            var rectText = RectangleF.Inflate(rectangleFull, 0, -2 * fontsHeight);
            var displayedLinesCount = (int)Math.Floor(rectText.Height / fontsHeight);
            rectText.Height = displayedLinesCount * fontsHeight;

            if (rtbText.WordWrap)
                stringFormat.Trimming = StringTrimming.Word;
            else {
                stringFormat.Trimming = StringTrimming.EllipsisCharacter;
                stringFormat.FormatFlags |= StringFormatFlags.NoWrap;
            }

            int symbolsCount, linesCount;
            while ((pageNum < startPage) && (stringPrintText.Length > 0)) {
                if (rtbText.WordWrap)
                    graph.MeasureString(stringPrintText, font, rectText.Size, stringFormat, out symbolsCount, out linesCount);
                else
                    symbolsCount = SymbolsInLines(stringPrintText, displayedLinesCount);
                stringPrintText = stringPrintText.Substring(symbolsCount);
                pageNum++;
            }

            if (stringPrintText.Length != 0) {
                graph.DrawString(stringPrintText, font, Brushes.Black, rectText, stringFormat);

                if (rtbText.WordWrap)
                    graph.MeasureString(stringPrintText, font, rectText.Size,
                        stringFormat, out symbolsCount, out linesCount);
                else
                    symbolsCount = SymbolsInLines(stringPrintText, displayedLinesCount);

                stringPrintText = stringPrintText.Substring(symbolsCount);
                stringFormat = new StringFormat();
                stringFormat.Alignment = StringAlignment.Far;
                graph.DrawString("Страница " + pageNum, font, Brushes.Black, rectangleFull, stringFormat);
                pageNum++;
                e.HasMorePages = (stringPrintText.Length > 0) && (pageNum < startPage + pagesCount);
                if (!e.HasMorePages) {
                    stringPrintText = rtbText.Text;
                    startPage = 1;
                    pagesCount = printDialog1.PrinterSettings.MaximumPage;
                    pageNum = 1;
                }
            } else
                e.Cancel = true;
        }

        int SymbolsInLines(string stringPrintText, int NumLines) {
            var index = 0;
            for (var i = 0; i < NumLines; i++)
                if ((index = 1 + stringPrintText.IndexOf('\n', index)) == 0)
                    return stringPrintText.Length;
            return index;
        }

        private void pageSetupToolStripMenuItem_Click(object sender, EventArgs e) => pageSetupDialog1.ShowDialog();

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e) {
            printDocument1.DocumentName = Text;
            stringPrintText = rtbText.Text;
            startPage = 1;
            pagesCount = printDialog1.PrinterSettings.MaximumPage;
            pageNum = 1;

            printPreviewDialog1.ShowDialog();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e) {
            printDialog1.AllowSelection = rtbText.SelectionLength > 0;
            if (printDialog1.ShowDialog() == DialogResult.OK) {
                printDocument1.DocumentName = Text;

                switch (printDialog1.PrinterSettings.PrintRange) {
                    //Выбраны все страницы
                    case PrintRange.AllPages:
                        stringPrintText = rtbText.Text;
                        startPage = 1;
                        pagesCount = printDialog1.PrinterSettings.MaximumPage;
                        break;
                    //Выбрана выделенная область
                    case PrintRange.Selection:
                        stringPrintText = rtbText.SelectedText;
                        startPage = 1;
                        pagesCount = printDialog1.PrinterSettings.MaximumPage;
                        break;
                    //Выбран ряд страниц
                    case PrintRange.SomePages:
                        stringPrintText = rtbText.Text;
                        startPage = printDialog1.PrinterSettings.FromPage;
                        pagesCount = printDialog1.PrinterSettings.ToPage - startPage + 1;
                        break;
                }
                pageNum = 1;
                printDocument1.Print();
            }
        }
    }
}
