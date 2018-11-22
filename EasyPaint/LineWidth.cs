using System;
using System.Drawing;
using System.Windows.Forms;

namespace _3 {
    public partial class LineWidth : Form {
        public float PenWidth => decimal.ToSingle(numericUpDown1.Value);

        public LineWidth() => InitializeComponent();

        private void DrawLine() {
            var y = panel1.Bottom / 2;
            panel1.CreateGraphics().DrawLine(
                new Pen(Color.Blue, decimal.ToSingle(numericUpDown1.Value)),
                new Point(panel1.Left, y), 
                new Point(panel1.Right, y)
            );
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e) {
            trackBar1.Value = (int)numericUpDown1.Value;
            DrawLine();
        }

        private void LineWidth_Paint(object sender, PaintEventArgs e) => DrawLine();
        private void trackBar1_Scroll(object sender, EventArgs e) => numericUpDown1.Value = trackBar1.Value;
        private void btnOK_Click(object sender, EventArgs e) => DialogResult = DialogResult.OK;
    }
}
