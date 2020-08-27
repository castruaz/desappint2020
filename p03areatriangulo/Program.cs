using System;

namespace p03areatriangulo
{
    class Program
    {
        // Este programa permite calcular el area de un triangulo
        // Carlos Castaneda Ramirez
        static void Main(string[] args)
        {
           float labase, laaltura;
           float area;

           Console.WriteLine("Dame la base"); labase = float.Parse( Console.ReadLine() );
           Console.WriteLine("Dame la altura"); laaltura = float.Parse( Console.ReadLine() );

           area = labase * laaltura / 2;

           Console.WriteLine($"Un trinagulo de base {labase} y altura {laaltura} tiene un area de {area}");
           
        }
    }
}
