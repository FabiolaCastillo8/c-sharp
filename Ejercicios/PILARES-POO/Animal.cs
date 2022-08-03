using System;

namespace pilaresPoo
{
   public class Animal
   {
   
   protected string Nombre;

   public string _Nombre { get => Nombre; set => Nombre = value; }

   public void comer()
   {
   Console.WriteLine(_Nombre+ " esta comiendo");
   }
   public void dormir()
   {
   Console.WriteLine(_Nombre+ " esta durmiendo");
   }

  public void nadar()
  {
   Console.WriteLine(_Nombre+ " esta nadando");
  }

  public void volarAlto()
  {
   Console.WriteLine(_Nombre+ " esta volando");
  }
  public void ladrar()
  {
   Console.WriteLine(_Nombre+ " esta ladrando");
  }

  public void maullar()
  {
   Console.WriteLine(_Nombre+ " esta maullando");
  }
  public void hablar()
  {
   Console.WriteLine(_Nombre+ " esta hablando");
  }
  public void inflarse()
  {
   Console.WriteLine(_Nombre+ " esta inflandose");
   }
   public Animal(string nombre)
   {
    Nombre=nombre;
   }

   }
   
}