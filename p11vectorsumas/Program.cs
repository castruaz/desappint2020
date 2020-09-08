// Genera numeros aletorios en un vector, clacula pos, neg, cero y la sumas de estos

using System;

namespace p11vectorsumas
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] A = new double[30];
            int pos=0, neg=0, cer=0;
            double spos=0, sneg=0;
            Random rnd = new Random();

            for(int i=0; i<A.Length; i++) {
                A[i] = rnd.Next(-10,100);
                Console.Write($"{A[i]} ");
                if(A[i]>0) {
                    pos++;
                    spos+=A[i];
                } else if(A[i]<0) {
                    neg++;
                    sneg+=A[i];
                } else cer++;
            }
            Console.WriteLine($"\n Positivos {pos} suma {spos}");
            Console.WriteLine($"\n Negativos {neg} suma {sneg}");
            Console.WriteLine($"\n Ceros     {cer} ");
        }
    }
}
