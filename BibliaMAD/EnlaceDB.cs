/*
Autor: Alejandro Villarreal

LMAD

PARA EL PROYECTO ES OBLIGATORIO EL USO DE ESTA CLASE, 
EN EL SENTIDO DE QUE LOS DATOS DE CONEXION AL SERVIDOR ESTAN DEFINIDOS EN EL App.Config
Y NO TENER ESOS DATOS EN CODIGO DURO DEL PROYECTO.

LOS MÉTODOS QUE SE DEFINEN EN ESTA CLASE SON EJEMPLOS, PARA QUE SE BASEN Y USTEDES HAGAN LOS SUYOS PROPIOS
Y DEFINAN Y PROGRAMEN TODOS LOS MÉTODOS QUE SEAN NECESARIOS PARA SU PROYECTO.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;


/*
Se tiene que cambiar el namespace para el que usen en su proyecto
*/
namespace BibliaMAD
{
    public class EnlaceDB
    {
        static private string _aux { set; get; }
        static private SqlConnection _conexion;
        static private DataTable _resultadoBusqueda;
        static private SqlDataAdapter _adaptador = new SqlDataAdapter();
        static private SqlCommand _comandosql = new SqlCommand();
        static private DataTable _tabla = new DataTable();
        static private DataSet _DS = new DataSet();

        public DataTable obtenertabla
        {
            get
            {
                return _tabla;
            }
        }

        private static void conectar()
        {
            /*
			Para que funcione el ConfigurationManager
			en la sección de "Referencias" de su proyecto, en el "Solution Explorer"
			dar clic al botón derecho del mouse y dar clic a "Add Reference"
			Luego elegir la opción System.Configuration
			
			tal como lo vimos en clase.
			*/
            string cnn = ConfigurationManager.ConnectionStrings["Usuarios"].ToString(); 
			// Cambiar Grupo01 por el que ustedes hayan definido en el App.Confif
            _conexion = new SqlConnection(cnn);
            _conexion.Open();
        }
        private static void desconectar()
        {
            _conexion.Close();
        }

        public bool Autentificar(string us, string ps, int  admin = 1)
        {
            bool isValid = false;
            try
            {
                DataTable _tabla = new DataTable();
                conectar();

                string qry = "Revisar_Login";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 9000;

                var parametro1 = _comandosql.Parameters.Add("@Correo", SqlDbType.Char, 20);
                parametro1.Value = us;
                var parametro2 = _comandosql.Parameters.Add("@Contraseña", SqlDbType.Char, 20);
                parametro2.Value = ps;
                var isAdmin = _comandosql.Parameters.Add("@Opcion", SqlDbType.Int, 20);
                isAdmin.Value = admin;

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(_tabla);

                if(_tabla.Rows.Count > 0)
                {
                  
                    if(admin == 1){
                        Variables_globales.usuario = Convert.ToString(_tabla.Rows[0]["Correo"]);
                        Variables_globales.estatus = Convert.ToInt16(_tabla.Rows[0]["Estatus"]);
                        Variables_globales.intentos = Convert.ToInt16(_tabla.Rows[0]["Intentos"]);
                    }
                    else if (admin  == 2)
                    {
                        Variables_globales.usuario = Convert.ToString(_tabla.Rows[0]["Correoadmin"]);
                    }
                  
                    isValid = true;
                }

            }
            catch(SqlException e)
            {
                MessageBox.Show(e.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isValid = false;
            }
            finally
            {
                desconectar();
            }

            return isValid;
        }

        public bool Insert_Users(int Opcion = 0, string Correo = "a", string Contraseña = "b"
            ,string Nombre = "c", DateTime Cumple = default(DateTime), int Genero = 0)
        {
            bool insert_ok = false;
            try
            {

                conectar();
                string qry = "Insertar_Usuarios";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 9000;

               
                    var Opcion_SQL = _comandosql.Parameters.Add("@Opcion", SqlDbType.Int, 1);
                    Opcion_SQL.Value = Opcion;

                    var NewCorreo = _comandosql.Parameters.Add("@Correo", SqlDbType.VarChar, 100);
                    NewCorreo.Value = Correo;

                    var NewContra = _comandosql.Parameters.Add("@Contraseña", SqlDbType.VarChar, 100);
                    NewContra.Value = Contraseña;

                    var Newname = _comandosql.Parameters.Add("@Nombre", SqlDbType.VarChar, 100);
                    Newname.Value = Nombre;

                    var NewDate = _comandosql.Parameters.Add("@Fecha_nacimiento", SqlDbType.Date, 100);
                    NewDate.Value = Cumple;

                    var NewGender = _comandosql.Parameters.Add("@Genero", SqlDbType.Int, 1);
                    NewGender.Value = Genero;
              
                
        

                _adaptador.InsertCommand = _comandosql;

                _comandosql.ExecuteNonQuery();

                insert_ok = true;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                insert_ok = false;
            }
            finally
            {
              
                desconectar();
            }

       

            return insert_ok;
        }

        public DataTable ResultadoBusqueda
        {
            get { return _resultadoBusqueda; }
        }

        public bool BuscarPalabras(int Opcion = 0, string PalabraBuscada = "", int Id_Idioma = 0, int Id_Testamento = 0, int Id_Version = 0, int Id_Libro = 0, int Id_Capitulo = 0)
        {
            bool search_ok = false;
            try
            {
                conectar();
                string qry = "BuscarPalabras"; 
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 9000;

                var Opcion_SQL = _comandosql.Parameters.Add("@Opcion", SqlDbType.Int, 1);
                Opcion_SQL.Value = Opcion;

                var PalabraParam = _comandosql.Parameters.Add("@PalabraBuscada", SqlDbType.NVarChar, 100);
                PalabraParam.Value = PalabraBuscada;

                var IdIdiomaParam = _comandosql.Parameters.Add("@Id_Idioma", SqlDbType.SmallInt);
                IdIdiomaParam.Value = Id_Idioma;

                var IdTestamentoParam = _comandosql.Parameters.Add("@Id_Testamento", SqlDbType.SmallInt);
                IdTestamentoParam.Value = Id_Testamento;

                var IdVersionParam = _comandosql.Parameters.Add("@Id_Version", SqlDbType.SmallInt);
                IdVersionParam.Value = Id_Version;

                var IdLibroParam = _comandosql.Parameters.Add("@Id_Libro", SqlDbType.SmallInt);
                IdLibroParam.Value = Id_Libro;

                var IdCapituloParam = _comandosql.Parameters.Add("@Id_Capitulo", SqlDbType.SmallInt);
                IdCapituloParam.Value = Id_Capitulo;

                _adaptador.SelectCommand = _comandosql;

                _resultadoBusqueda = new DataTable();

     
                _adaptador.Fill(_resultadoBusqueda);

                search_ok = true;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                search_ok = false;
            }
            finally
            {
                desconectar();
            }

            return search_ok;
        }

        public DataTable get_Users()//SE USARA PARA TRAER USUARIOS QUE DESEN REHABILITAR SU CUENTA  
        {
         //   var msg = "Soy un mensaje";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
				// Ejemplo de cómo ejecutar un query, 
				// PERO lo correcto es siempre usar SP para cualquier consulta a la base de datos
                string qry = "Habilitar_usuario";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.Text;
                _comandosql.CommandTimeout = 1200;



                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);

                if (tabla.Rows.Count > 0)
                {
                    Variables_globales.Consultas = tabla;
                }


            }
            catch (SqlException e)
            {
            
                MessageBox.Show(e.Message, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return tabla;
        }

        public DataTable EDGetUser(string Correo)//Traera datos a la ventana de editar perfil
        {
            //   var msg = "Soy un mensaje";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                // PERO lo correcto es siempre usar SP para cualquier consulta a la base de datos
                string qry = "Consulta_Usuario";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var GetCorreo = _comandosql.Parameters.Add("@Correo", SqlDbType.VarChar, 100);
                GetCorreo.Value = Correo;

              //  _adaptador.InsertCommand = _comandosql;
                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);

                if (tabla.Rows.Count > 0)
                {
                    Variables_globales.Consultas = tabla;
                }



         
            }
            catch (SqlException e)
            {

                MessageBox.Show(e.Message, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return tabla;
        }

 



        // Ejemplo de método para recibir una consulta en forma de tabla
        // Cuando el SP ejecutará un SELECT
        public DataTable get_Deptos(string opc)
        {
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "sp_Gestiona_Deptos";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Opc", SqlDbType.Char, 1);
                parametro1.Value = opc;

          
                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);

            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return tabla;
        }
		
		// Ejemplo de método para ejecutar un SP que no se espera que regrese información, solo que ejecute
		// ya sea un INSERT, UPDATE o DELETE
        public bool Add_Deptos(string opc, string depto)
        {
            var msg = "";
            var add = true;
            try
            {
                conectar();
                string qry = "sp_Gestiona_Deptos";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Opc", SqlDbType.Char, 1);
                parametro1.Value = opc;
                var parametro2 = _comandosql.Parameters.Add("@Nombre", SqlDbType.VarChar, 20);
                parametro2.Value = depto;

                _adaptador.InsertCommand = _comandosql;
                
                _comandosql.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                add = false;
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();                
            }

            return add;
        }

    }
}
