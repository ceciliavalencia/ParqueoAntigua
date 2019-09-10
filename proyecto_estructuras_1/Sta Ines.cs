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

namespace proyecto_estructuras_1
{
    public partial class Sta_Ines : Form
    {
        static Queue COlaPublica = new Queue();
        ArrayList arreglo = new ArrayList();
        ArrayList arreglo1 = new ArrayList();
        List<Object> lista = new List<Object>();
        public Sta_Ines()
        {
            InitializeComponent();
            dataGridView1.Enabled = false;
            dataGridView2.Enabled = false;
            textBox1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
        }
       
        public ArrayList cargar()
        {
            dataGridView1.Enabled = true;
            String linea = "";
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Cursor Files|*.txt";
            openFileDialog1.Title = "Select a Cursor File";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName);
                while (!sr.EndOfStream)
                {
                    linea = sr.ReadLine();
                    var arreglo = linea.ToString().Split(',');
                    AgregarCliente(arreglo[0].ToString(), arreglo[1].ToString(), (arreglo[2].ToString()), (arreglo[3].ToString()));
                }
                MessageBox.Show("Datos agregados correctamente");
            }
            return arreglo;

        }
        public void AgregarCliente(string Nombre, string Apellido, string Marca, string placa)
        {
            var cl = new Cliente
            {
                Nombre = Nombre,
                Apellido = Apellido,
                Marca = Marca,
                placa = placa,
            };


            var bs = new BindingSource();
            bs.DataSource = lista;
            dataGridView1.DataSource = bs;
            lista.Add(cl);

            textBox1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
        }
        private void agregardatos(string Nombre, string Apellido, string Marca, string Placa)
        {
            dataGridView2.Rows.Add(Nombre, Apellido, Marca, Placa);
        }
        ///
        private void button1_Click_1(object sender, EventArgs e)
        {
            cargar();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            serv1.Enabled = true;
            serv2.Enabled = true;
            serv5.Enabled = true;
            serv.Enabled = true;
            textBox2.Text = "";

            dataGridView2.Enabled = true;
            button5.Enabled = true;

           
            dataGridView2.Rows.Add(new string[]
            {
                Convert.ToString(dataGridView1[0, dataGridView1.CurrentRow.Index].Value),
                Convert.ToString(dataGridView1[1, dataGridView1.CurrentRow.Index].Value),
                Convert.ToString(dataGridView1[2, dataGridView1.CurrentRow.Index].Value),
                Convert.ToString(dataGridView1[3, dataGridView1.CurrentRow.Index].Value)
            });
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void serv_Click_1(object sender, EventArgs e)
        {
            txtnom.Text = "";
            txtapell.Text = "";
            txtmarca.Text = "";
            txtplaca.Text = "";

            string cadena = "";
            if (serv1.Checked)
            {
                cadena += serv1.Text + Environment.NewLine;
            }
            if (serv2.Checked)
            {
                cadena += serv2.Text + Environment.NewLine;
            }
            
            if (serv5.Checked)
            {
                cadena += serv5.Text + Environment.NewLine;
            }
            textBox2.Enabled = true;
            textBox2.Text = cadena;
            string mensaje = textBox2.Text;
            COlaPublica.Enqueue((mensaje));
            MessageBox.Show("Elementos: " + COlaPublica.Count);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            txtnom.Enabled = true;
            txtapell.Enabled = true;
            txtmarca.Enabled = true;
            txtplaca.Enabled = true;
            button4.Enabled = true;
            txtapell.Text = "";
            txtnom.Text = "";
            txtmarca.Text = "";
            txtplaca.Text = "";
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            serv.Enabled = true;
            serv1.Enabled = true;
            serv2.Enabled = true;
            serv5.Enabled = true;
            button5.Enabled = true;
            agregardatos(txtnom.Text, txtapell.Text, txtmarca.Text, txtplaca.Text);
            txtapell.Enabled = false;
            txtmarca.Enabled = false;
            txtnom.Enabled = false;
            txtplaca.Enabled = false;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            textBox2.Text = "";
            int poc;
            poc = dataGridView2.CurrentRow.Index;
            dataGridView2.Rows.RemoveAt(poc);
            COlaPublica.Dequeue();
            MessageBox.Show("Elemento: " + COlaPublica.Count);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Filtro_Marca f3 = new Filtro_Marca();
            f3.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

}

