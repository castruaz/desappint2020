using System;
using System.Collections.Generic;
using System.Linq;

namespace p22Linq3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Estudiante> estudiantes = new List<Estudiante>() {
                new Estudiante {Matricula=111, Nombre="Juan Perez", Domicilio="Principal 123, Zacatecas",
                Califs=new List<float>{97,92,81,60} },
                new Estudiante {Matricula=111, Nombre="Maria Lopez", Domicilio="Principal 126, Frensillo",
                Califs=new List<float>{75,84,91,39} },
                new Estudiante {Matricula=444, Nombre="Rodrigo Mata", Domicilio="Luis Moya 31, Rio Grande",
                Califs=new List<float>{88,94,65,91} },
                new Estudiante {Matricula=444, Nombre="Miguel Mejia", Domicilio="Juan de Tolosa 22, Zacatecas",
                Califs=new List<float>{70,90,60,40} }
            };

            estudiantes.Add(new Estudiante {Matricula=111, 
            Nombre="Carlos Castaneda", Domicilio="Jardin Juarez 25, Zacatecas",
                Califs=new List<float>{70,90,60,40}});
            
            // Todos los registros sin consulta ni filtro
            Console.WriteLine("\nTodos los estudiantes: {0}",estudiantes.Count());
            estudiantes.ForEach(est=>Console.WriteLine(est.ToString()));

            // Filtrar los estudiantes que son de Zacatecas
            var estzac = ( from est in estudiantes where est.Domicilio.Contains("Zacatecas") select est).ToList();
            Console.WriteLine("\nLos estudiantes de Zacatecas: {0}",estzac.Count());
            estzac.ForEach(est=>Console.WriteLine(est.ToString()));

            // Filtrar estudiantes con promedio de 70, y mostrar ordenados por nombre descendente
            var otros = (from est in estudiantes
                where est.Califs.Average()>=70
                orderby est.Nombre descending
                select est).ToList();
            
            Console.WriteLine("\nEstudiantes con promedio de 8 en orden descendente por nombre: {0}",otros.Count());
            otros.ForEach(est=>Console.WriteLine(est.ToString()));

            // Consulta con datos agrupados 
            var gpoest = from est in estudiantes group est by est.Matricula;
            
            foreach(var gpo in gpoest) {
                Console.WriteLine(gpo.Key);
                foreach(Estudiante est in gpo)
                    Console.WriteLine(est.ToString());       
            }

            // Estudiantes y sus promedios
            var proms = ( from est in estudiantes
                select $"nombre={est.Nombre}   prom={est.Califs.Average()}").ToList();
            Console.WriteLine("\nLista de Alumnos y sus promedios:");
            proms.ForEach(p=>Console.WriteLine(p));    

        }
    }
}
