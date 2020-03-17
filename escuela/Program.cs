using System;
using System.Collections.Generic;

namespace escuela
{
    class Program
    {
        static void Main(string[] args)
        {
            var matematica = new asignatura("Matematica");
            var lengua = new asignatura("Lengua");

            var Mati = new alumno("Mati");
            var Juan = new alumno("Juan");

            

            var grado1 = new grado("1er Grado");
            var grado2 = new grado("2do Grado");

            grado1.AddAlumno(Mati);
            grado1.AddAlumno(Juan);
            grado1.AddAsignatura(matematica);
            grado1.AddAsignatura(lengua);

            grado2.AddAlumno(Mati);
            grado2.AddAlumno(Juan);
            grado2.AddAsignatura(matematica);
            grado2.AddAsignatura(lengua);



            var grados = new List<grado>();
            grados.Add(grado1);
            grados.Add(grado2);


            Random rnd = new Random();
            foreach (var grado in grados)
            {
                foreach (var alumno in grado.getAllAlumnos())
                {
                    foreach (var asignatura in grado.getAllAsignaturas())
                    {
                        grado.AddEvaluacion(new evaluacion(rnd.Next(1, 10), alumno, asignatura, grado));
                        grado.AddEvaluacion(new evaluacion(rnd.Next(1, 10), alumno, asignatura, grado));
                        grado.AddEvaluacion(new evaluacion(rnd.Next(1, 10), alumno, asignatura, grado));
                        Console.WriteLine("grado: {0} alumno: {1} asignatura: {2} evaluaciones: {3}", grado.Descripcion, alumno.Nombre, asignatura.Nombre
                                , grado.GetEvaluacionByAlumnoAndAsignatura(alumno, asignatura).Nota);
                    }
                }
            }
        }
    }
}
