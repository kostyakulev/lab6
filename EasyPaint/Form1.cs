using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            Cursor = new Cursor("pen_il.cur");
            mainPen = new Pen(ForeColor);
        }

        //Переменная, отвечающая за включения режима рисования.
        //Значение true — режим включен
        private bool drawMode = false;

        private ArrayList points = new ArrayList();
        private Pen mainPen;

        private void Form1_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                drawMode = true;
                points.Clear();
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e) {
            if (drawMode) {
                points.Add(new Point(e.X, e.Y));

                if (points.Count > 1) {
                    var pts = new Point[points.Count];
                    points.CopyTo(pts, 0);

                    CreateGraphics().DrawCurve(mainPen, pts);
                }
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e) {
            drawMode = false;
        }

        private void mnuColor_Click(object sender, EventArgs e) {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                mainPen = new Pen(colorDialog1.Color);
        }

        private void mnuWidth_Click(object sender, EventArgs e) {
            var dialog = new LineWidth();
            if (dialog.ShowDialog(this) == DialogResult.OK)
                mainPen = new Pen(mainPen.Color, dialog.PenWidth);
        }
    }
}
