using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class CEElemento
    {
        private string _CodigoAlumno;
        private int _CodigoUniversidad;
        private string _Nombre;
        private string _Apellido;
        private string _Carrera;
        private int _Numero;

        public string CodigoAlumno { get => _CodigoAlumno; set => _CodigoAlumno = value; }
        public int CodigoUniversidad { get => _CodigoUniversidad; set => _CodigoUniversidad = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public string Carrera { get => _Carrera; set => _Carrera = value; }
        public int Numero { get => _Numero; set => _Numero = value; }
    }
}
