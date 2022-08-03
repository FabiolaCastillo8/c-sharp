using System;
using System.Collections.Generic;

namespace pilaresPoo
{
    class Program
    {
    static void Main(string[] args)
    {

        Console.Clear();
        Console.WriteLine("==================");
        Console.WriteLine("**** ANIMALES ****");
        Console.WriteLine("==================");
        Console.WriteLine("");

        Console.WriteLine("Mamiferos");
        Console.WriteLine("=========");
        Console.WriteLine("");
        Mamiferos m1 = new Mamiferos("El perro");
        Mamiferos m2 = new Mamiferos("El gato");
        Mamiferos m3 = new Mamiferos("El mono");
        Mamiferos m4 = new Mamiferos("El leon");
        Mamiferos m5 = new Mamiferos("El tigre");


        List<Animal>ListadeMamiferos= new List<Animal>();
        ListadeMamiferos.Add(m1);
        ListadeMamiferos.Add(m2);
        ListadeMamiferos.Add(m4);
        ListadeMamiferos.Add(m5);
        

        foreach (Mamiferos item in ListadeMamiferos)
        {
        m1.ladrar();
        m2.maullar();

        }

        Console.WriteLine("");
        Console.WriteLine("=====");
        Console.WriteLine("Aves");
        Console.WriteLine("=====");


        Aves a1 = new Aves("El aguila");
        Aves a2 = new Aves("El loro"); 
        Aves a3 = new Aves("El colibri");
        Aves a4 = new Aves("El pajaro carpintero");
        Aves a5 = new Aves("El tucan");

        List<Animal>ListadeAves= new List<Animal>();
        ListadeAves.Add(a1);
        ListadeAves.Add(a2);
        ListadeAves.Add(a3);
        ListadeAves.Add(a4);
        ListadeAves.Add(a5);


        foreach (Aves item in ListadeAves)
        {
        a1.volarAlto();
        a2.hablar();

        
        }
        

        Console.WriteLine("");
        Console.WriteLine("=====");
        Console.WriteLine("Peces");
        Console.WriteLine("=====");
        Console.WriteLine("");

        Peces p1 = new Peces("El pez globo");
        Peces p2 = new Peces("La pez angel");
        Peces p3 = new Peces("El pez dorado");
        Peces p4 = new Peces("El pez cebra");
        Peces p5 = new Peces("El pez guppy");
        

        List<Animal>ListadePeces= new List<Animal>();
        ListadePeces.Add(p1);
        ListadePeces.Add(p2);
        ListadePeces.Add(p3);
        ListadePeces.Add(p4);
        ListadePeces.Add(p5);


    foreach (Peces item in ListadePeces)
    {
       p1.inflarse();
       p2.nadar();
    } 
   }

  }
}

