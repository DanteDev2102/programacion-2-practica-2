using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conexion_con_MySQL
{
    class Validaciones
    {
        public static int SoloDoubles(int tecla)
        {

            if (tecla >= 48 && tecla <= 57) return tecla;

            if (tecla == 08 || tecla == 13 || tecla == 46 || tecla == 127) return tecla;

            return 0;
        }

        public static int SoloLetras(int tecla)
        {
            if (tecla >= 65 && tecla <= 90) return tecla;

            if (tecla >= 97 && tecla <= 122) return tecla;

            if (tecla == 08 || tecla == 13 || tecla == 32 || tecla == 127) return tecla;

            return 0;
        }

        public static int SoloInt(int tecla)
        {

            if (tecla >= 48 && tecla <= 57) return tecla;

            if (tecla == 08 || tecla == 13 || tecla == 127) return tecla;

            return 0;
        }
    }
}
