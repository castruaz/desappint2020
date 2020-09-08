using System;

// Programa que permite pedir una pizza en base a la eleccion del usuario
// Carlos Castaneda Ramirez
// 1 de Sep 2020

namespace p06pizza
{
    class Program
    {
        static int Main(string[] args)
        {
            // variables para recibir los parametros
            char tam, cub, don; 
            string[] ings;

            // variables para guardar la eleccion del usuario
            string tamaño, ingredientes="", cubierta, donde;

            Console.Clear();
            if(args.Length==0) { // revisar que existan parametros en la lienea de comando
                Menu();
                return 1;
            }

            // Elegir tamaño
            tam = char.Parse(args[0].ToUpper()); // Tomar el primer parametro
            if(tam=='P') tamaño="Pequeña"; 
            else if(tam=='M') tamaño="Mediana";
            else tamaño="Grande";

            // Elegir Ingrediente
            ings = args[1].Split("+"); //separa los ingredientes en base al signo +  
            foreach(string i in ings) {
                switch(char.Parse(i.ToUpper())) {
                    case 'E' : ingredientes+="Extraqueso "; break;
                    case 'C' : ingredientes+="Champiñones "; break;
                    case 'P' : ingredientes+="Piña "; break;
                }
            }
            
            // Tipo de cubierta
            cub = char.Parse(args[2].ToUpper());
            cubierta = cub=='D' ? "Delagada" : "Gruesa";

            // Elegir donde comer
            don = char.Parse(args[3].ToUpper());
            donde = don=='A' ? "Aqui" : "Llevar";

            Console.WriteLine("\n La pizza que pediste es la siguiente ");
            Console.WriteLine($"Tamaño: {tamaño}");
            Console.WriteLine($"Ingredientes: {ingredientes}");
            Console.WriteLine($"Cubierta: {cubierta}");
            Console.WriteLine($"Donde: {donde}");

            return 0;
        }

        static void Menu() {
            Console.Clear();
            Console.WriteLine("Elije las opciones segun deseas tu pizza ");
            Console.WriteLine("Tamaño: (P)equeña (M)ediana (G)rande");
            Console.WriteLine("Ingredientes: (E)xtra queso, (C)hampiñones, (P)iña unidos por +");
            Console.WriteLine("Cubierta: (D)elagada, (G)ruesa");
            Console.WriteLine("Donde la comes: (A)qui, (L)levar");
        }

        
    }
}
