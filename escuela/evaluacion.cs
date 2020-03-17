using System;
using System.Collections.Generic;
using System.Text;

namespace escuela
{
    class evaluacion
    {
        public evaluacion(int nota, alumno alumno, asignatura asignatura, grado grado)
        {
            this.Nota = nota;
            this.alumno = alumno;
            this.asignatura = asignatura;
            this.grado = grado;
        }
        public int Nota{ get; set; }
        public alumno alumno { get; set; }

        public asignatura asignatura { get; set; }
        public grado grado { get; set; }
    
    }
}
