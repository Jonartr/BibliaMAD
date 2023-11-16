using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliaMAD
{
  public static  class Variables_globales
    {
            
            //Variables de datos
            public static bool admin { get; set; } = false;
            public static string usuario { get; set; }


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
        
    }
}
