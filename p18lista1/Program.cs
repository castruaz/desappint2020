using System;
using System.Collections.Generic;

namespace p18lista1
{
    class Program
    {
        static void Main(string[] args)
        {
            // DEfinir la lista con algunos valores iniciales
            List<string> mats = new List<string>() {
                "Calculo I",
                "Redacción Avanzada",
                "Introducción a la Ingeniería"
            };

            // Agregar elementos a la lisa
            mats.Add("Matematicas Discretas");
            mats.Add("Compiladores e Interpretadores");
            imprime(mats);

            // Agrgar un rango de materias
            string[] mopt = {
                "Seguridad en Redes y Sistemas (op)",
                "Topicos selectos de Redes (op)",
                "Criptografia Avanzada (op)"
            };
            mats.AddRange(mopt);
            imprime(mats);

            // Ordenar la lista
            mats.Sort();
            imprime(mats);

            // Invertir los elementos de la lista
            mats.Reverse();
            imprime(mats);

            // Buscar un elemento en la lista, en base a una condicion
            Console.WriteLine("Materias que tengan la palabra Discretas");
            string mat = mats.Find(x=>x.Contains("Discretas"));
            Console.WriteLine(mat);

            // Buscar todas las materias en la lista, que son optativas
            Console.WriteLine("Materias optativas ");
            var ms = mats.FindAll(x=>x.Contains("(op)"));
            imprime(ms);

        }
        static void imprime(List<string> lista) {
            //foreach(string m in lista) {  Console.WriteLine(m); }
            lista.ForEach(m=>Console.WriteLine(m));

            Console.WriteLine();
        }

    }
}
