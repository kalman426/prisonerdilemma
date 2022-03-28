using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fogoly
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        Szimulacio alanyok = new Szimulacio();


        private void StartButton_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            
            alanyok.Initialize((int)input.Value);
            alanyok.setChance = (int)Chance.Value;
            alanyok.Start((int)Rounds.Value);
            
            Points pontok = new Points();
            pontok.Initialize((int)input.Value);
            pontok.Positions = alanyok.Positions();
            pontok.Refresh();
            pontok.Fill();

            List<string> SelectPlacement = new List<string>();
            for (int i = 0; i < (int)input.Value * 3; i++)
            {
                SelectPlacement.Add(i + 1 + ". helyezett");
            }
            helyezettLista.DataSource = SelectPlacement;


            for(int i = 0; i < (int)input.Value*3; i++)
            {
                Bitmap kep = new Bitmap(15,15);
                Graphics gr = Graphics.FromImage(kep);
                SolidBrush toll = new SolidBrush(pontok.GetColor(i));
                gr.FillEllipse(toll, new Rectangle(0, 0, 10, 10));
                PictureBox pb = new PictureBox();
                pb.Size = new Size(15, 15);
                pb.Location = new Point(pontok.GetX(i), pontok.GetY(i));
                pb.Image = kep;
                
                panel1.Controls.Add(pb);                
            }
            
        }
        private void helyezettLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            result.Text = alanyok.Result(helyezettLista.SelectedIndex);
            yearView.DataSource = alanyok.getYears(helyezettLista.SelectedIndex);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Rounds_ValueChanged(object sender, EventArgs e)
        {

        }

        private void stage_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
