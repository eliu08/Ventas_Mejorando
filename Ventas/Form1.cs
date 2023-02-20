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



            using (SqlConnection conexion = new SqlConnection(Funciones_base_de_datos.DatosDeConexion))
            {
                conexion.Open();

                using (SqlCommand comand = new SqlCommand(insertSql, conexion))
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
            Funciones_base_de_datos conexion = new Funciones_base_de_datos();


            try

            {
                conexion.openConection();
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("No se pudo abrir la conexion por favor intente de nuevo");

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
            using (SqlConnection connection = new SqlConnection(Funciones_base_de_datos.DatosDeConexion))
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
            consultaTimeTabla();
        }
        private void timeFinal_ValueChanged(object sender, EventArgs e)
        {
            consultaTimeTabla();
        }


        private void consultaTimeTabla ()
        {
            using (SqlConnection conexion = new SqlConnection(Funciones_base_de_datos.DatosDeConexion))
            {
                conexion.Open();
                // Crear un nuevo comando SQL que llame al procedimiento almacenado
                using (SqlCommand command = new SqlCommand("BuscarRegistrosPorFechaYHora", conexion))
                {
                    // Especificar que el comando es un procedimiento almacenado
                    command.CommandType = System.Data.CommandType.StoredProcedure;



                    int horaInicio;
                    int minutoInicio;
                    int horaFin;
                    int minutoFin;


                    horaInicio = Convert.ToInt32(comboBoxHoraInicio.SelectedItem);
                    minutoInicio = Convert.ToInt32(comboBoxMinutoInicio.SelectedItem);
                    horaFin = Convert.ToInt32(comboBoxHoraFinal.SelectedItem);
                    minutoFin = Convert.ToInt32(comboBoxMinutoFinal.SelectedItem);
                    //horaInicio = int.Parse(comboBoxHoraInicio.Text);
                    //minutoInicio = int.Parse(comboBoxMinutoInicio.Text);
                    //horaFin = int.Parse(comboBoxHoraFinal.Text);
                    //minutoFin = int.Parse(comboBoxMinutoFinal.Text);

                    //AddHours(int.Parse(comboBoxHoraFinal.Text)).AddMinutes(int.Parse(comboBoxMinutoFinal.Text)))
                    // Agregar los parámetros al comando
                    command.Parameters.AddWithValue("@fechaInicio", timeInicio.Value);
                    command.Parameters.AddWithValue("@fechaFin", timeFinal.Value);
                    command.Parameters.AddWithValue("@horaInicio", new TimeSpan(horaInicio, minutoInicio, 0)); // Especificar la hora de inicio que deseas buscar
                    command.Parameters.AddWithValue("@horaFin", new TimeSpan(horaFin, minutoFin, 0)); // Especificar la hora final que deseas buscar

                    // Ejecutar el comando y obtener los resultados
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        // Asignar el objeto DataTable al DataSource del DataGridView
                        dataGridProductos.DataSource = table;
                    }
                }
            }

        }
       

        private void comboBoxHoraInicio_SelectedValueChanged(object sender, EventArgs e)
        {
            consultaTimeTabla();
        
        }

        private void comboBoxMinutoInicio_SelectedValueChanged(object sender, EventArgs e)
        {
            consultaTimeTabla();
        }

        private void comboBoxHoraFinal_SelectedValueChanged(object sender, EventArgs e)
        {
            consultaTimeTabla();
        }

        private void comboBoxMinutoFinal_SelectedValueChanged(object sender, EventArgs e)
        {
            consultaTimeTabla();
        }
    }
}
