using System;
using System.Collections.Generic;
using System.Text;

namespace escuela
{
    class asignatura
    {
        //private List<int> _notas;
        //public asignatura()
        //{
        //    this.Nombre = "";
        //    //_notas = new List<int>();
        //}
        public asignatura(string nombre)
        {
            this.Nombre = nombre;
            //_notas = new List<int>();
        }
        public string Nombre { get; set; }
        public IList<evaluacion> Evaluaciones{ get; set; }


        
        //public void addNota(int notas)
        //{
        //    if (notas <= 10 || notas >= 1)
        //    {
        //        throw new ArgumentException("La nota debe estar entre 1 y 10");
        //    }
        //    _notas.Add(notas);
        //}

        //public List<int> getAllNotas()
        //{
        //    return _notas;
        //}

    }
}
