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
           

            string consulta = "select * from Producto";

            //"SELECT* FROM Producto order by Fecha BETWEEN @inicio AND @fin"; //  
            using (SqlConnection conexion = new SqlConnection(datosDeConexion)) 
            {
                using (SqlCommand command = new SqlCommand(consulta, conexion))
                {
                    // Agrega los parámetros de fecha y hora

                    

                    command.Parameters.AddWithValue("@inicio", forma.TimeInicio.Value.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@fin", forma.TimeFinal.Value.ToString("yyyy-MM-dd"));

                    //Crea una instancia del objeto SqlDataAdapter y llena el DataGridView con los resultados de la consulta
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        return table;

                        //SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                        //DataTable datos = new DataTable();
                        //adaptador.Fill(datos);



                        //return datos;

                    }
                }


            }

             
            
        }
        //string datosDeconexion = "Data Source=DEV\\DEVELOPER;Initial Catalog=Inventario_Productos;User ID=eliu;Password=0824";

        
    }
}
