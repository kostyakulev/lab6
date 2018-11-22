using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace _2 {
    public partial class Form1 : Form {
        public Form1() => InitializeComponent();

        private void mnuOpen_Click(object sender, EventArgs e) {
            var dialog = new OpenFileDialog();

            dialog.Filter = "jpg files(*.jpg)| *.jpg | All files(*.*) | *.*";
            if (dialog.ShowDialog() == DialogResult.OK) {
                pictureBox1.Image = new Bitmap(dialog.OpenFile());

                sbFile.Text = "Загрузка " + dialog.FileName;
                sbFile.Text = "Изображение " + dialog.FileName;
                sbSize.Text = string.Format("{0:#} x {1:#}", pictureBox1.Image.Width, pictureBox1.Image.Height);
            }
        }

        private void mnuSave_Click(object sender, EventArgs e) {
            var dialog = new SaveFileDialog {
                Filter = "jpg files(*.jpg)| *.jpg | All files(*.*) | *.*"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
                using (var fs = new FileStream(dialog.FileName, FileMode.Create, FileAccess.ReadWrite))
                    pictureBox1.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        private int selectedMode = 0;

        private PictureBoxSizeMode[] ArrayMenu = {
            PictureBoxSizeMode.StretchImage, PictureBoxSizeMode.Normal,
            PictureBoxSizeMode.CenterImage, PictureBoxSizeMode.AutoSize
        };

        private void mnuResize_Click(object sender, EventArgs e) {
            if (sender is ToolStripMenuItem) {
                selectedMode = menuStrip1.Items.IndexOf(sender as ToolStripMenuItem);
                pictureBox1.SizeMode = ArrayMenu[0];
                pictureBox1.Invalidate();
            }
        }

        private void mnuActualSize_Click(object sender, EventArgs e) {
            if (sender is ToolStripMenuItem) {
                selectedMode = menuStrip1.Items.IndexOf(sender as ToolStripMenuItem);
                pictureBox1.SizeMode = ArrayMenu[1];
                pictureBox1.Invalidate();
            }
        }

        private void mnuCenterImage_Click(object sender, EventArgs e) {
            if (sender is ToolStripMenuItem) {
                selectedMode = menuStrip1.Items.IndexOf(sender as ToolStripMenuItem);
                pictureBox1.SizeMode = ArrayMenu[2];
                pictureBox1.Invalidate();
            }
        }

        private void mnuAutoSize_Click(object sender, EventArgs e) {
            if (sender is ToolStripMenuItem) {
                selectedMode = menuStrip1.Items.IndexOf(sender as ToolStripMenuItem);
                pictureBox1.SizeMode = ArrayMenu[3];
                pictureBox1.Invalidate();
            }
        }

        private void mnuView_DropDownOpening(object sender, EventArgs e) {
            if (sender is ToolStripMenuItem)
                foreach (ToolStripMenuItem menuitem in (sender as ToolStripMenuItem).DropDownItems) {
                    menuitem.Enabled = pictureBox1.Image != null;
                    menuitem.Checked = selectedMode == (sender as ToolStripMenuItem).DropDownItems.IndexOf(menuitem);
                }
        }

        private void mnuPageSetup_Click(object sender, EventArgs e) {
            var dialog = new PageSetupDialog();
            dialog.Document = printDocument1;
            dialog.ShowDialog();
        }

        private void mnuPrintPreview_Click(object sender, EventArgs e) {
            var dialog = new PrintPreviewDialog();
            dialog.Document = printDocument1;
            dialog.ShowDialog();
        }

        private void mnuPrint_Click(object sender, EventArgs e) {
            var dialog = new PrintDialog();
            dialog.Document = printDocument1;
            if (dialog.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e) {
            if (pictureBox1.Image != null) {
                var leftMargin = e.MarginBounds.Left;
                var rightMargin = e.MarginBounds.Right;
                var topMargin = e.MarginBounds.Top;
                var bottomMargin = e.MarginBounds.Bottom;
                var printableWidth = e.MarginBounds.Width;
                var printableHeight = e.MarginBounds.Height;

                var graph = e.Graphics;

                var font = new Font("Comic Sans MS", 16);
                var fontHeight = font.GetHeight(graph);
                var spaceWidth = graph.MeasureString(" ", font).Width;

                float imageLength;
                var Xposition = (float)leftMargin;
                var Yposition = topMargin + fontHeight;
                if (printableWidth < printableHeight) {
                    imageLength = printableWidth * 90 / 100;
                    Yposition += imageLength;
                } else {
                    imageLength = printableHeight * 90 / 100;
                    Xposition += imageLength + spaceWidth;
                }

                var rectImage = new Rectangle(leftMargin + 1, topMargin + 1, (int)imageLength, (int)imageLength);
                graph.DrawImage(pictureBox1.Image, leftMargin + 1, topMargin + 1, (int)imageLength, (int)imageLength);

                var rectText = new RectangleF(Xposition, Yposition, rightMargin - Xposition, bottomMargin - Yposition);
                PrintText(graph, font, "Размер изображения: ", Convert.ToString(pictureBox1.Image.Size), ref rectText);
            } else
                e.Cancel = true;
        }

        protected void PrintText(Graphics graph, Font font, string name, string text, ref RectangleF rectText) {
            var leftMargin = rectText.Left;
            var rightMargin = rectText.Right;
            var topMargin = rectText.Top;
            var bottomMargin = rectText.Bottom;

            var fontHeight = font.GetHeight(graph);
            var Xposition = rectText.Left;

            var Yposition = topMargin + fontHeight;
            var spaceWidth = graph.MeasureString(" ", font).Width;
            var nameWidth = graph.MeasureString(name, font).Width;

            graph.DrawString(name, font, Brushes.Black, new PointF(Xposition, Yposition));

            leftMargin += nameWidth + spaceWidth;
            Xposition = leftMargin;

            foreach (var word in text.Split(" \r\t\n\0".ToCharArray())) {
                var wordWidth = graph.MeasureString(word, font).Width;
                if (wordWidth != 0.0)
                    if (Xposition + wordWidth > rightMargin) {
                        Xposition = leftMargin;
                        Yposition += fontHeight;
                        if (Yposition > bottomMargin)
                            break;
                        graph.DrawString(word, font, Brushes.Black, new PointF(Xposition, Yposition));
                        Xposition += wordWidth;
                    }
            }
            rectText.Y = Yposition;
            rectText.Height = bottomMargin - Yposition;
        }
    }
}
