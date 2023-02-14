using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas
{
    //funciones
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string insertSql = "INSERT INTO Producto (Producto, Detalles, Monto) VALUES (@producto, @detalles, @monto)";



            using (SqlConnection coneccion = new SqlConnection(Funciones_base_de_datos.datosDeConeccion))
            {
                coneccion.Open();

                using (SqlCommand comand = new SqlCommand(insertSql, coneccion))
                {
                    string productos = txtPoducto.Text;
                    string detalles = txtDetalles.Text;
                    int monto = int.Parse(txtMonto.Text);
                    

                    comand.Parameters.AddWithValue("@producto", productos);
                    comand.Parameters.AddWithValue("@detalles", detalles);
                    comand.Parameters.AddWithValue("@monto", monto);

                    int rowsInserted = comand.ExecuteNonQuery();
                }

            }
                cargar();


        }
        
        private void conectar()
        {
            Funciones_base_de_datos coneccion = new Funciones_base_de_datos();


            try

            {
                coneccion.openConection();
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("No se pudo abrir la coneccion por favor intente de nuevo");

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargar();
                        
        }

        private void cargar()
        {
            dataGridProductos.DataSource = Funciones_base_de_datos.mostrarDatosGridView();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            byte textoBoton;

            textoBoton = 1;

            switch (textoBoton)
            {
                case 1:
                    textoBoton = 1;
                    {
                        btnAtras.Text = "Desde 0 a 25";
                    }
                    break;
                case 2:
                    textoBoton= 2;
                    {
                        btnAtras.Text = "Desde 26 a ";
                    }
                    break;
                    
            }
            

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            byte textoBoton;

            textoBoton = 1;

            switch (textoBoton)
            {
                case 1:
                    textoBoton = 1;
                    {
                        btnAtras.Text = "Desde 0 a 25 \n Atras";
                    }
                    break;
                case 2:
                    textoBoton = 2;
                    {
                        btnAtras.Text = "Desde 26 a ";
                    }
                    break;

            }
        }

        private void dataGridProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
            txtIDreferencia.Text = dataGridProductos.SelectedCells[0].Value.ToString();
            txtPoducto.Text = dataGridProductos.SelectedCells[1].Value.ToString();
            txtDetalles.Text = dataGridProductos.SelectedCells[2].Value.ToString();
            txtMonto.Text = dataGridProductos.SelectedCells[3].Value.ToString();
        }
    }
}
