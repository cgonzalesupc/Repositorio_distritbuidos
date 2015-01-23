using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UPC_ENTIDADES
{
    public class T_PERSONAL
    {
        public int id_trabajador { get; set; }
        public string nombre { get; set; }
        public string ape_paterno { get; set; }
        public string ape_materno { get; set; }
        public string direccion { get; set; }
        public string estado_civil { get; set; }
        public int nro_documento { get; set; }
        public string sexo { get; set; }
        public string des_nacionalidad { get; set; }
        public string departamento { get; set; }
        public string provincia { get; set; }
        public string distrito { get; set; }
        public string foto { get; set; }
    }
}
