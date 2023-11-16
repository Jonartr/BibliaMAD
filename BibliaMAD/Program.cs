using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliaMAD
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Inicio_sesion());
        }
    }
}


/*
 use Biblia_MAD;




create table ejemplo(
 ID_admin int identity(1,1) primary key not null,
 Nombre varchar(30) not null
);

select * from ejemplo;

insert into ejemplo(Nombre) values('Hola');
 
 */