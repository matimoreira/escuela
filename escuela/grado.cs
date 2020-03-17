using System;
using System.Collections.Generic;
using System.Text;

namespace escuela
{
    class grado
    {
        private List<evaluacion> _evaluaciones;
        private List<asignatura> _asignaturas;
        private List<alumno> _alumnos;
        public grado(string descripcion)
        {
            this.Descripcion = descripcion;
            _evaluaciones = new List<evaluacion>();
            _asignaturas = new List<asignatura>();
            _alumnos = new List<alumno>();
        }
        public string Descripcion{ get; set; }


        public void AddAlumno(alumno alumno)
        {
            _alumnos.Add(alumno);
        }
        public List<alumno> getAllAlumnos()
        {
            return _alumnos;
        }


        public void AddAsignatura(asignatura asignatura)
        {
            _asignaturas.Add(asignatura);
        }
        public List<asignatura> getAllAsignaturas()
        {
            return _asignaturas;
        }


        public void AddEvaluacion(evaluacion evaluacion)
        {
            _evaluaciones.Add(evaluacion);
        }
        public List<evaluacion> getAllEvaluaciones()
        {
            return _evaluaciones;
        }
        public evaluacion GetEvaluacionByAlumnoAndAsignatura(alumno alumno, asignatura asignatura)
        {
            evaluacion evaluacionByAlumnoAndAsignatura = null;
            foreach (var item in _evaluaciones)
            {
                if (item.alumno == alumno && item.asignatura == asignatura)
                {
                    evaluacionByAlumnoAndAsignatura = item;
                }
            }
            return evaluacionByAlumnoAndAsignatura;
        }
        public List<evaluacion> getAllEvaluacionesByAlumno(alumno alumno)
        {
            var evaluacionesByAlumno = new List<evaluacion>();
            foreach (var item in _evaluaciones)
            {
                if (item.alumno == alumno)
                {
                    evaluacionesByAlumno.Add(item);
                }
            }
            return evaluacionesByAlumno;
        }
        public List<evaluacion> getAllEvaluacionesByAsignatura(asignatura asignatura)
        {
            var evaluacionesByAsignatura = new List<evaluacion>();
            foreach (var item in _evaluaciones)
            {
                if (item.asignatura == asignatura)
                {
                    evaluacionesByAsignatura.Add(item);
                }
            }
            return evaluacionesByAsignatura;
        }
        
        

    }
}
