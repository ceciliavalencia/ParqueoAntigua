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
    public partial class Filtro_Marca : Form
    {
        ArrayList arreglo = new ArrayList();
       
        List<Object> lista = new List<Object>();
        List<Object> listasedan = new List<Object>();
        List<Object> listacouple = new List<Object>();
        List<Object> listahatch = new List<Object>();
        List<Object> listapick = new List<Object>();
        List<Object> listacam = new List<Object>();
        List<Object> listasuv = new List<Object>();
        public Filtro_Marca()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cargar();
        }
        public ArrayList cargar()
        {
            
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
            /*   var bs = new BindingSource();
               bs.DataSource = lista;
               dataGridView1.DataSource = bs;
               lista.Add(cl);*/
            if (Marca.Equals("Coupe"))
            {
                var bscoupe = new BindingSource();
                bscoupe.DataSource = listacouple;
                dgvcouple.DataSource = bscoupe;
                listacouple.Add(cl);
            }
            if (Marca.Equals("Sedan"))
            {
                var bsedan = new BindingSource();
                bsedan.DataSource = listasedan;
                dgvsedan.DataSource = bsedan;
                listasedan.Add(cl);
            }
            if (Marca.Equals("SUV"))
            {
                var bsuv = new BindingSource();
                bsuv.DataSource = listasuv;
                dgvsuv.DataSource = bsuv;
                listasuv.Add(cl);
            }
            if (Marca.Equals("HatchBack"))
            {
                var bshash = new BindingSource();
                bshash.DataSource = listahatch;
                dgvhatch.DataSource = bshash;
                listahatch.Add(cl);
            }
            if (Marca.Equals("Pick Up"))
            {
                var bspick = new BindingSource();
                bspick.DataSource = listapick;
                dgvpickup.DataSource = bspick;
                listapick.Add(cl);
            }
            if (Marca.Equals("Camioneta"))
            {
                var bscam = new BindingSource();
                bscam.DataSource = listacam;
                dgvcamioneta.DataSource = bscam;
                listacam.Add(cl);
            }













        }
    }
}
