using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BibliaMAD
{
  public static  class Variables_globales
    {
            
            //VARIABLES DE USUARIO
            public static bool admin { get; set; } = false;
            public static string usuario { get; set; }
            public static int estatus { get; set; }
            public static int intentos { get; set; }

            public static string versiculo { get; set; }

            //QUERYS 
            public static DataTable Consultas { get; set; } = new DataTable();
            public static DataTable Fav { get; set; } = new DataTable();
            public static DataTable Historial { get; set; } = new DataTable();
             public static DataTable FavInicio { get; set; } = new DataTable();





        //Variables de ventana
        public static EnlaceDB conexion = new EnlaceDB();
            public static Ayuda help = new Ayuda(); 
            public static Pagina_principal inicio = new Pagina_principal(); 
            public static Favoritos favorito = new Favoritos();  
            public static Registro registro = new Registro();
            public static Consultas consulta = new Consultas();   
            public static Historial historial = new Historial();
            public static Administrador adminis = new Administrador();
            public static Edicion_perfil editar = new Edicion_perfil();
            public static Inicio_sesion isesion = new Inicio_sesion();


    }
}
