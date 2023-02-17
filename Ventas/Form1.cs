using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ventas
{
    //funciones
    public partial class Form1 : Form
    {
        private string fechaInicio = "";
        private string horaInicio = "";
        private string minutosInicio = "";
        private string fechaFinal = "";
        private string horaFinal = "";
        private string minutosFinal = "";
        private string combinarInicio = "";
        private string combinarFinal = "";

        public string FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public string HoraInicio { get => horaInicio; set => horaInicio = value; }
        public string MinutosInicio { get => minutosInicio; set => minutosInicio = value; }
        public string FechaFinal { get => fechaFinal; set => fechaFinal = value; }
        public string HoraFinal { get => horaFinal; set => horaFinal = value; }
        public string MinutosFinal { get => minutosFinal; set => minutosFinal = value; }
        public string CombinarInicio { get => combinarInicio; set => combinarInicio = value; }
        public string CombinarFinal { get => combinarFinal; set => combinarFinal = value; }

        public Form1()
        {
            InitializeComponent();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string insertSql = "INSERT INTO Producto (Producto, Detalles, Monto) VALUES (@producto, @detalles, @monto)";



            using (SqlConnection coneccion = new SqlConnection(Funciones_base_de_datos.DatosDeConeccion))
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


            timeInicio.Value = DateTime.Today.AddDays(-7).AddHours(00);// Hace una semana a las 9:00 AM
            timeFinal.Value = DateTime.Today.AddHours(23).AddMinutes(59).AddSeconds(59); // Hoy a las 5:00 PM;
            
            comboBoxHoraInicio.SelectedIndex = 22;
            comboBoxHoraInicio.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMinutoInicio.SelectedIndex = 58;
            comboBoxMinutoInicio.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxHoraFinal.SelectedIndex = 21;
            comboBoxHoraFinal.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMinutoFinal.SelectedIndex = 57;
            comboBoxMinutoFinal.DropDownStyle = ComboBoxStyle.DropDownList;

            fechaInicio = timeInicio.Value.ToString("yyyy-MM-dd");
            horaInicio = comboBoxHoraInicio.Text;
            minutosInicio = comboBoxMinutoInicio.Text;

            combinarInicio = $"{fechaInicio} {horaInicio}:{minutosInicio}";

            fechaFinal = timeFinal.Value.ToString("yyyy-MM-dd");
            horaFinal = comboBoxHoraFinal.Text;
            minutosFinal = comboBoxMinutoFinal.Text;

            combinarFinal = $"{fechaFinal} {horaFinal}:{minutosFinal}";

            //txtDetalles.Text = combinarFinal;

            textBox7.Text = combinarInicio;
            textBox6.Text = combinarFinal;
            //cargar();

        }

        
        private void cargar() => dataGridProductos.DataSource = Funciones_base_de_datos.mostrarDatosGridView();

        private void dataGridProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            txtIDreferencia.Text = dataGridProductos.SelectedCells[0].Value.ToString();
            txtPoducto.Text = dataGridProductos.SelectedCells[1].Value.ToString();
            txtDetalles.Text = dataGridProductos.SelectedCells[2].Value.ToString();
            txtMonto.Text = dataGridProductos.SelectedCells[3].Value.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Funciones_base_de_datos.DatosDeConeccion))
            {
                connection.Open();

                int id = int.Parse(txtIDreferencia.Text);
                string deleteSql = "DELETE FROM Producto WHERE Id = @id";

                using (SqlCommand command = new SqlCommand(deleteSql, connection))
                {
                    command.Parameters.AddWithValue("@id", id);


                    int rowsInserted = command.ExecuteNonQuery();
                    MessageBox.Show("Registro Eliminado");

                    cargar();


                }
            }
        }

        private void timeInicio_ValueChanged(object sender, EventArgs e)
        {
            fechaInicio = timeInicio.Value.ToString("yyyy-MM-dd");
            
            combinarInicio = fechaInicio + " " + horaInicio + ":" + minutosInicio;


            cargar();
        }

        private void timeFinal_ValueChanged(object sender, EventArgs e)
        {
            fechaFinal = timeFinal.Value.ToString("yyyy-MM-dd");
            
            combinarFinal = fechaFinal + " " + horaFinal + ":" + minutosFinal;


            cargar();
        }

        private void comboBoxHoraInicio_SelectedValueChanged(object sender, EventArgs e)
        {
            horaInicio = comboBoxHoraInicio.Text;

            combinarInicio = timeInicio.Value.ToString("yyyy-MM-dd") + " " + horaInicio + ":" + minutosInicio;


            cargar();
        }





       

        

    }
}
