using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Weather_System {
    public partial class Form2 : Form {
        private string _imagemPath;

        public Form2(string imagemPath) {
            InitializeComponent();
            _imagemPath = imagemPath;

            PictureBox pb = new PictureBox();
            pb.Dock = DockStyle.Fill;
            pb.SizeMode = PictureBoxSizeMode.Zoom;
            pb.Image = Image.FromFile(imagemPath);
            this.Controls.Add(pb);

            this.Text = "Previsão do Tempo";
            this.Size = new Size(850, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormClosing += Form2_FormClosing;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e) {
            foreach (Control c in this.Controls) {
                if (c is PictureBox pb && pb.Image != null) {
                    pb.Image.Dispose();
                    pb.Image = null;
                }
            }

            if (File.Exists(_imagemPath))
                File.Delete(_imagemPath);
        }
    }
}
