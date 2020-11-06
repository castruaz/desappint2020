using System;
using System.Collections.Generic;
using System.Linq;

namespace p21Linq2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] frutas = new string[] 
                {"pera","melon","sandia","durazno","manzana","platano","kiwi","naranja"};

            var mfrutas = from f in frutas where f.StartsWith('m') select f;
            Console.WriteLine($"\nFrutas que inician con la letra m: {mfrutas.Count()}");
            foreach(var f in mfrutas) Console.WriteLine($"{f}");

            var xfrutas = (from f in frutas where f.Contains("an") select f).ToArray();
            Console.WriteLine($"\nFrutas que contienen las letras an: {xfrutas.Count()}");
            foreach(string f in xfrutas) Console.WriteLine($"{f}");

            var yfrutas = (from f in frutas where f.EndsWith("a") select f).ToList();
            Console.WriteLine($"\nFrutas que terminan con la letra a: {yfrutas.Count()}");
            yfrutas.ForEach(f=>Console.WriteLine($"{f}"));
            
        }
    }
}
