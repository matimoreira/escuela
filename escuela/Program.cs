using System;
using System.Collections.Generic;

namespace escuela
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<asignatura> asignaturas;

            var matematica = new asignatura("Matematica");
            var lengua = new asignatura("Lengua");
            var eduFisica = new asignatura("Educación Física");
            var musica = new asignatura("Música");

            asignaturas = new List<asignatura>();

            asignaturas.Add(matematica);
            asignaturas.Add(lengua);
            asignaturas.Add(eduFisica);
            asignaturas.Add(musica);

            IList<alumno> alumnos;

            var alumno1 = new alumno("Mati");
            alumno1.Asignaturas= asignaturas;

            var alumno2 = new alumno("Juan");
            alumno2.Asignaturas = asignaturas;

            var alumno3 = new alumno("Mario");
            alumno3.Asignaturas = asignaturas;

            var alumno4 = new alumno("Seba");
            alumno4.Asignaturas = asignaturas;

            var alumno5 = new alumno("Ivan");
            alumno5.Asignaturas = asignaturas;

            var alumno6 = new alumno("Adri");
            alumno6.Asignaturas = asignaturas;

            var alumno7 = new alumno("Ana");
            alumno7.Asignaturas = asignaturas;

            var alumno8 = new alumno("Martin");
            alumno8.Asignaturas = asignaturas;

            var alumno9 = new alumno("Ceci");
            alumno9.Asignaturas = asignaturas;

            var alumno10 = new alumno("Lulu");
            alumno10.Asignaturas = asignaturas;

            alumnos = new List<alumno>();

            alumnos.Add(alumno1);
            alumnos.Add(alumno2);
            alumnos.Add(alumno3);
            alumnos.Add(alumno4);
            alumnos.Add(alumno5);
            alumnos.Add(alumno6);
            alumnos.Add(alumno7);
            alumnos.Add(alumno8);
            alumnos.Add(alumno9);
            alumnos.Add(alumno10);

            IList<grado> grados;
            grados = new List<grado>();
            var grado1 = new grado("1er Grado");
            grado1.alumnos = alumnos;

            var grado2 = new grado("2do Grado");
            grado2.alumnos = alumnos;

            var grado3 = new grado("3er Grado");
            grado3.alumnos = alumnos;

            var grado4 = new grado("4to Grado");
            grado4.alumnos = alumnos;

            var grado5 = new grado("5to Grado");
            grado5.alumnos = alumnos;

            grados.Add(grado1);
            grados.Add(grado2);
            grados.Add(grado3);
            grados.Add(grado4);
            grados.Add(grado5);


            Random rnd = new Random();
            foreach (var grado in grados)
            {
                foreach (var alumno in grado.alumnos)
                {
                    foreach (var asignatura in alumno.Asignaturas)
                    {
                        IList<evaluacion> evaluaciones;
                        evaluaciones = new List<evaluacion>();
                        var evaluacion1 = new evaluacion(rnd.Next(1, 10));
                        var evaluacion2 = new evaluacion(rnd.Next(1, 10));
                        var evaluacion3 = new evaluacion(rnd.Next(1, 10));

                        evaluaciones.Add(evaluacion1);
                        evaluaciones.Add(evaluacion2);
                        evaluaciones.Add(evaluacion3);

                        asignatura.Evaluaciones = evaluaciones;
                    }
                }
            }

            foreach (var grado in grados)
            {
                foreach (var alumno in grado.alumnos)
                {
                    foreach (var asignatura in alumno.Asignaturas)
                    {
                        foreach (var evaluacion in asignatura.Evaluaciones)
                        {
                            Console.WriteLine("grado: {0} alumno: {1} asignatura: {2} evaluaciones: {3}", grado.Descripcion, alumno.Nombre, asignatura.Nombre
                                , evaluacion.Nota);
                        }
                    }
                }
            }


        }
    }
}
