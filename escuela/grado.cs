using System;
using System.Collections.Generic;
using System.Text;

namespace escuela
{
    class grado
    {
        public grado(string descripcion)
        {
            this.Descripcion = descripcion;
        }
        public string Descripcion{ get; set; }
        public IList<alumno> alumnos { get; set; }
    }
}
