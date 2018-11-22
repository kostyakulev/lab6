using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5 {
    public partial class Form1 : Form {
        public Form1() => InitializeComponent();

        private void mnuOpen_Click(object sender, EventArgs e) {
            openFileDialog1.ShowDialog();
            var path = openFileDialog1.FileName;
            namePictureElement1.Izobrajenie = Image.FromFile(path);
        }

        private void mnuResize_Click(object sender, EventArgs e) {
            namePictureElement1.UserPropRejimProsmotra = PictureElement.RejimProsmotra.PodgonRazmera;
        }

        private void mnuActual_Click(object sender, EventArgs e) {
            namePictureElement1.UserPropRejimProsmotra = PictureElement.RejimProsmotra.Prokrutka;
        }
    }
}
