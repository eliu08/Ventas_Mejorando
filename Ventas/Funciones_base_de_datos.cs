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

namespace Ventas
{

    public class Funciones_base_de_datos
    {
        Form1 forma = new Form1();

        public static string datosDeConeccion = "server=PC001\\PRACTICA;database=Inventario_Productos;User ID=eliu;Password=0824";
        public void openConection(string comando)
        {

            using (SqlConnection coneccion = new SqlConnection(datosDeConeccion))
            {
                coneccion.Open();

                using (SqlCommand comand = new SqlCommand(comando, coneccion))
                {
                                     
                                     
                    int rowsInserted = comand.ExecuteNonQuery();
                    
                }
            }
        }
        public void openConection()
        {

            using (SqlConnection coneccion = new SqlConnection(datosDeConeccion))
            {
                coneccion.Open();
                MessageBox.Show("Conexion abierta");

               
            }
        }



        public static DataTable mostrarDatosGridView()
        {
            string consulta = "select * from Producto order by fecha Desc";
            using (SqlConnection coneccion = new SqlConnection(datosDeConeccion)) 
            {
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, coneccion);
                DataTable datos = new DataTable();
                adaptador.Fill(datos);



                return datos;
            
            
            }

             
            
        }
        //string datosDeConeccion = "Data Source=DEV\\DEVELOPER;Initial Catalog=Inventario_Productos;User ID=eliu;Password=0824";

        
    }
}
