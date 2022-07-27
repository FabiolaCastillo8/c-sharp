using System;
public class Producto
{
   public int Codigo { get; set; }

   public string Descripcion { get; set; }

   public int Precio { get; set; }

   public Producto(int codigo, string  descripcion, int precio)
   {
       Codigo = codigo;
       Descripcion = descripcion;
       Precio = precio;
   }

}
