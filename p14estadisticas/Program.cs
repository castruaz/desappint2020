// Leer un vector A y realizar operaciones estadísticas (may, men, media, varianza, desv)

using System;

namespace p14estadisticas
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=0; double[] A;
            double lamedia=0, lavarianza=0;
            Console.WriteLine("Cuantos elementos ?"); n = int.Parse(Console.ReadLine());
            A = new double[n];
            Console.WriteLine("\nDame los elementos del Arreglo \n"); leer(A);
            Console.WriteLine("\nEstadisitcas :\n");
            Console.WriteLine($"\nMayor   {may(A)}");   
            Console.WriteLine($"\nMenor   {men(A)}");  
            lamedia = media(A); 
            lavarianza = varianza(A,lamedia);
            Console.WriteLine($"\nVarianza   {lavarianza}");
            Console.WriteLine($"\nDesv Est.  {Math.Sqrt(lavarianza)}");
        }
        static double varianza(double[] v, double m) {
            double suma=0;
            for(int i=0; i<v.Length; i++)
                 suma += Math.Pow((v[i] - m),2);
            return suma / v.Length - 1;
        }
        static double media(double[] v) {
            double suma=0;
            for(int i=0; i<v.Length; i++)
                suma+=v[i];
            return suma / v.Length;
        }
        static double men(double[] v) {
            double m=v[0];
            for(int i=0; i<v.Length; i++)
                if(v[i]<m) m=v[i];
            return m;
        }
        static double may(double[] v) {
            double m=v[0];
            for(int i=0; i<v.Length; i++)
                if(v[i]>m) m=v[i];
            return m;
        }
        static void leer(double[] v) {
            for(int i=0; i<v.Length; i++) {
                Console.Write($"Elemento[{i}]=");
                v[i] = double.Parse(Console.ReadLine());
            }
        }
        static void imprime(double[] v) {
            for(int i=0; i<v.Length; i++) 
                Console.Write($"{v[i]} ");
            Console.WriteLine();
        }

    }
}
