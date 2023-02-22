using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using System.Collections;
using Microsoft.SqlServer.Server;

namespace Ventas
{

    public class Funciones_base_de_datos
    {
        static Form1 forma = new Form1();

        private static string datosDeConexion = "server=DEV\\PRACTICA;database=Inventario_Productos;User ID=eliu;Password=0824";

        public static string DatosDeConexion { get => datosDeConexion; set => datosDeConexion = value; }

        public void openConection(string comando)
        {

            using (SqlConnection conexion = new SqlConnection(datosDeConexion))
            {
                conexion.Open();

                using (SqlCommand comand = new SqlCommand(comando, conexion))
                {
                                     
                                     
                    int rowsInserted = comand.ExecuteNonQuery();
                    
                }
            }
        }
        public void openConection()
        {

            using (SqlConnection conexion = new SqlConnection(datosDeConexion))
            {
                conexion.Open();
                MessageBox.Show("Conexion abierta");

               
            }
        }



        public static DataTable mostrarDatosGridView()
        {


            using (SqlConnection conexion = new SqlConnection(Funciones_base_de_datos.DatosDeConexion))
            {
                conexion.Open();
                // Crear un nuevo comando SQL que llame al procedimiento almacenado
                using (SqlCommand command = new SqlCommand("BuscarRegistrosPorFechaYHora", conexion))
                {
                    // Especificar que el comando es un procedimiento almacenado
                    command.CommandType = System.Data.CommandType.StoredProcedure;



                    int horaInicio = 00;
                    int minutoInicio = 00;
                    int horaFin = 23;
                    int minutoFin = 59;

                    DateTimePicker fechaInicio = new DateTimePicker();
                    DateTimePicker fechaFin = new DateTimePicker();
                    fechaInicio.Value = DateTime.Today.AddDays(-1).AddHours(00);// Hace una semana a las 9:00 AM
                    fechaFin.Value = DateTime.Today.AddHours(23).AddMinutes(59).AddSeconds(59); 

                    command.Parameters.AddWithValue("@fechaInicio", fechaInicio.Value);
                    command.Parameters.AddWithValue("@fechaFin", fechaFin.Value);
                    command.Parameters.AddWithValue("@horaInicio", new TimeSpan(horaInicio, minutoInicio, 0)); 
                    command.Parameters.AddWithValue("@horaFin", new TimeSpan(horaFin, minutoFin, 0)); 

                    // Ejecutar el comando y obtener los resultados
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        // Asignar el objeto DataTable al DataSource del DataGridView
                        return table;
                    }
                }
            }



        }
        //string datosDeconexion = "Data Source=DEV\\DEVELOPER;Initial Catalog=Inventario_Productos;User ID=eliu;Password=0824";

        
    }
}
