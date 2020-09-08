// Programa que calcula el promedio de un vector de valores constantes
// Carlos Castañeda Ramírez
// 8 de Septiembre 2020

using System;

namespace p08vectorpromedio
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector = {10,20,30,40,50,60,70,80,90,100, 
                            10,20,30,40,50,60,70,80,90,100,
                            10,20,30,40,50,60,70,80,90,100,
                            10,20,30,40,50,60,70,80,90,100,
                            10,20,30,40,50,60,70,80,90,100};

            int suma=0, nmp=0;
            float prom=0;

            for(int i=0; i<vector.Length; i++) {
                Console.Write($"{vector[i]} ");
                suma+=vector[i];
            }

            prom = suma / vector.Length;
            Console.WriteLine($"\nEl promedio es {prom} \n");
            
            foreach(int v in vector) {
                if(v>prom) {
                    Console.Write($"{v} ");
                    nmp++;
                }
            }
            Console.WriteLine($"\nElementos mayores al promedio {nmp}\n");

        }
    }
}
