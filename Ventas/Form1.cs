using System;
using System.Collections;
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
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cargar();
            restablecerDateTimePicker();
            parametrosHorayMinutos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            string productos = txtPoducto.Text;
            string detalles = txtDetalles.Text;
            int monto;
            try
            {
                monto = int.Parse(txtMonto.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor introduzca un monto válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            InsertarRegistro(productos,detalles,monto);
            //agregarRegistro();
            cargar();
            limpiar();


        }

        public static void InsertarRegistro(string producto, string detalles, decimal monto)
        {
            using (SqlConnection conexion = new SqlConnection(Funciones_base_de_datos.DatosDeConexion))
            {
                using (SqlCommand comando = new SqlCommand("InsertarRegistro", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@producto", producto);
                    comando.Parameters.AddWithValue("@detalles", detalles);
                    comando.Parameters.AddWithValue("@monto", monto);

                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

       

        private void cargar() => dataGridProductos.DataSource = Funciones_base_de_datos.mostrarDatosGridView();
        private void limpiar()
        {
            txtDetalles.Text = "";
            txtIDreferencia.Text = "";
            txtMonto.Text = "";
            txtPoducto.Text = "";
        }




















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

        

       

        

       


       

        private void restablecerDateTimePicker()
        {
            timeInicio.Value = DateTime.Today.AddDays(-1).AddHours(00);// Hace una semana a las 9:00 AM
            timeFinal.Value = DateTime.Today.AddHours(23).AddMinutes(59).AddSeconds(59); // Hoy a las 5:00 PM;


        }

        private void parametrosHorayMinutos()
        {
            comboBoxHoraInicio.SelectedIndex = 22;
            comboBoxHoraInicio.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMinutoInicio.SelectedIndex = 58;
            comboBoxMinutoInicio.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxHoraFinal.SelectedIndex = 21;
            comboBoxHoraFinal.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMinutoFinal.SelectedIndex = 57;
            comboBoxMinutoFinal.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        
        

        private void dataGridProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDreferencia.Text = dataGridProductos.SelectedCells[0].Value.ToString();
            txtPoducto.Text = dataGridProductos.SelectedCells[1].Value.ToString();
            txtDetalles.Text = dataGridProductos.SelectedCells[2].Value.ToString();
            txtMonto.Text = dataGridProductos.SelectedCells[3].Value.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArrayList listaIds = new ArrayList();

            // Recorre las filas seleccionadas del DataGridView y obtiene los ID
            foreach (DataGridViewRow fila in dataGridProductos.SelectedRows)
            {
                int id = Convert.ToInt32(fila.Cells["ID"].Value);
                listaIds.Add(id);
            }
            {
                // Mostrar un mensaje de advertencia con los IDs seleccionados
                string ids = string.Join(", ", listaIds.ToArray());
                string mensaje = "¿Está seguro que desea eliminar los siguientes IDs?\n" + ids;
                DialogResult resultado = MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                { 
                    // Si se seleccionó al menos un registro, llamar al método de eliminación de la base de datos
                    if (listaIds.Count > 0)
                    {
                        eliminarVariosRegistros(listaIds);
                        MessageBox.Show("Registros eliminados correctamente.");
                        cargar();
                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar al menos un registro para eliminar.");
                        cargar();
                    }
                }
            }
        }

        private void eliminarVariosRegistros(ArrayList listaIds)
        {
            using (SqlConnection conexion = new SqlConnection(Funciones_base_de_datos.DatosDeConexion))
            {
                conexion.Open();
                // Crear un nuevo comando SQL que llame al procedimiento almacenado
                using (SqlCommand comando = new SqlCommand("eliminarVariosRegistro", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@IDInicio", listaIds[0]);
                    comando.Parameters.AddWithValue("@IDFin", listaIds[listaIds.Count - 1]);
                    comando.ExecuteNonQuery();
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


        private void consultaTimeTabla()
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cargar();
            timeInicio.Value = DateTime.Today.AddDays(-1).AddHours(00);
            timeFinal.Value = DateTime.Today.AddHours(23).AddMinutes(59).AddSeconds(59); 

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int idReferencia; 
            string productos = txtPoducto.Text;
            string detalles = txtDetalles.Text;
            int monto;
            try
            {
                monto = int.Parse(txtMonto.Text);
                idReferencia = int.Parse(txtIDreferencia.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor introduzca un monto y ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ModificarRegistros(idReferencia,productos,detalles,monto);

        }

        private void ModificarRegistros(int id, string producto, string detalle, decimal monto)
        {
            
            using (SqlConnection conexion = new SqlConnection(Funciones_base_de_datos.DatosDeConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand("ModificarRegistro", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@Id", id);
                    comando.Parameters.AddWithValue("@NuevoProducto", producto);
                    comando.Parameters.AddWithValue("@NuevosDetalles", detalle);
                    comando.Parameters.AddWithValue("@NuevoMonto",monto);
                    comando.ExecuteNonQuery();
                }
                cargar();
                limpiar();
            }

        }
    }
}
