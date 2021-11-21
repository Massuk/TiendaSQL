using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.Sql;

using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class CNElemento
    {
        private CDElemento elemento = new CDElemento();
        // Mostrar
        public DataTable mostrarTabla()
        {
            return elemento.mostrar();
        }
        // Agregar
        public void agregarDato(CEElemento element)
        {
            elemento.agregar(element);
        }
        // Modificar
        public void modificarDato(CEElemento element)
        {
            elemento.modificar(element);
        }
        // Eliminar
        public bool eliminarDato(CEElemento element)
        {
            try
            {
                elemento.eliminar(element);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        // Leer datos
        public CEElemento leerDato(string codigoalumno)
        {
            CEElemento element = new CEElemento();
            element = elemento.leerDatos(codigoalumno);
            return element;
        }
    }   
}
