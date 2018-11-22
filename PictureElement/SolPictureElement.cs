using System.Drawing;
using System.Windows.Forms;

namespace PictureElement {
    public enum RejimProsmotra {
        Prokrutka,
        PodgonRazmera
    }

    public partial class NamePictureElement : UserControl {
        public Image Izobrajenie {
            get { return pictureBox1.Image; }
            set {
                pictureBox1.Image = value;
                UstanovkaRejima();
            }
        }

        public RejimProsmotra UserPropRejimProsmotra {
            get { return prosmotrperemen; }
            set {
                prosmotrperemen = value;

                AutoScroll = prosmotrperemen == RejimProsmotra.Prokrutka;
                UstanovkaRejima();
            }
        }

        public NamePictureElement() => InitializeComponent();

        private void PodgonRazmera() {
            var ProporciiElementa = (float)Width / Height;
            var ProporciiIzobrajeniya = (float)pictureBox1.Image.Width / pictureBox1.Image.Height;
            if (Width >= pictureBox1.Image.Width && Height >= pictureBox1.Image.Height) {
                pictureBox1.Width = pictureBox1.Image.Width;
                pictureBox1.Height = pictureBox1.Image.Height;
            }
            else if (Width > pictureBox1.Image.Width && Height < pictureBox1.Image.Height) {
                pictureBox1.Height = Height;
                pictureBox1.Width = (int)(Height * ProporciiIzobrajeniya);
            }
            else if (Width < pictureBox1.Image.Width && Height > pictureBox1.Image.Height) {
                pictureBox1.Width = Width;
                pictureBox1.Height = (int)(Width / ProporciiIzobrajeniya);
            }
            else if (Width < pictureBox1.Image.Width && Height < pictureBox1.Image.Height) {
                if (Width >= Height) {
                    if (pictureBox1.Image.Width >= pictureBox1.Image.Height && ProporciiIzobrajeniya >= ProporciiElementa) {
                        pictureBox1.Width = Width;
                        pictureBox1.Height = (int)(Width / ProporciiIzobrajeniya);
                    }
                    else {
                        pictureBox1.Height = Height;
                        pictureBox1.Width = (int)(Height * ProporciiIzobrajeniya);
                    }
                } else {
                    if (pictureBox1.Image.Width < pictureBox1.Image.Height && ProporciiIzobrajeniya < ProporciiElementa) {
                        pictureBox1.Height = Height;
                        pictureBox1.Width = (int)(Height * ProporciiIzobrajeniya);
                    }
                  else {
                        pictureBox1.Width = Width;
                        pictureBox1.Height = (int)(Width / ProporciiIzobrajeniya);
                    }
                }
            }
            PomeshenieIzobrajeniyavCenter();
        }

        private void Prokrutka() {
            pictureBox1.Width = pictureBox1.Image.Width;
            pictureBox1.Height = pictureBox1.Image.Height;
            PomeshenieIzobrajeniyavCenter();
        }

        private void UstanovkaRejima() {
            if (pictureBox1.Image != null) {
                if (prosmotrperemen == RejimProsmotra.PodgonRazmera)
                    PodgonRazmera();
                else {
                    Prokrutka();
                    AutoScroll = true;
                }
            }
        }

        private void PomeshenieIzobrajeniyavCenter() {
            var top = (int)((Height - pictureBox1.Height) / 2.0);
            var left = (int)((Width - pictureBox1.Width) / 2.0);

            if (top < 0)
                top = 0;
            if (left > 0)
                left = 0;
            pictureBox1.Top = top;
            pictureBox1.Left = left;
        }

        private RejimProsmotra prosmotrperemen;

        private void NamePictureElement_Resize(object sender, System.EventArgs e) => UstanovkaRejima();

        private void NamePictureElement_Load(object sender, System.EventArgs e) {
            pictureBox1.Width = 0;
            pictureBox1.Height = 0;
            UstanovkaRejima();
        }
    }
}
