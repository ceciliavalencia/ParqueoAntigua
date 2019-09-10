using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_estructuras_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            var x = e.X;
            var y = e.Y;
            MessageBox.Show(x + ":" + y);



            if ((x >= 120 && x <= 245) && (y > 0 && y <= 111) )
            {
                MessageBox.Show("PARQUEO CERCANO: CONCEPCIÓN");
            }
            if ((x >= 0 && x <=119) && ( y > 0 && y <= 112 ))
            {
                MessageBox.Show("PARQUEO CERCANO: ALAMEDAS");
            }
            if ((x >= 0 && x <= 116) && (y > 112 && y <= 218))
            {
                MessageBox.Show("PARQUEO CERCANO: LAS FLORES");
            }
            if ((x >= 120 && x <= 245) && (y > 112 && y <= 218))
            {
                MessageBox.Show("PARQUEO CERCANO: SANTA INÉS");
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnalamedas_Click(object sender, EventArgs e)
        {
            alamedas f2 = new alamedas();
            f2.ShowDialog();
        }

        private void btnflores_Click(object sender, EventArgs e)
        {
            Las_Flores f3 = new Las_Flores();
            f3.ShowDialog();
        }

        private void btninés_Click(object sender, EventArgs e)
        {
            Sta_Ines f4 = new Sta_Ines();
            f4.ShowDialog();
        }

        private void btnconcep_Click(object sender, EventArgs e)
        {
            Concepcion f5 = new Concepcion();
            f5.ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
