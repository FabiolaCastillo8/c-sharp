using System;
public class ClasesDisponibles

{
    public string CodigoClaseDisponible { get; set; } 

    public string NombreClaseDisponible { get; set; }

    public int Nota1 { get; set; }

    public int Nota2 { get; set; }

    public int Nota3 { get; set; }

    public int Nota4 { get; set; }

    public double Notapromedio { get; set; }

    public ClasesDisponibles(string codigoclasedisponible, string nombreclasedisponible)
    {
        CodigoClaseDisponible = codigoclasedisponible;
        NombreClaseDisponible = nombreclasedisponible;
    }

    public void Resultado()
    {   
        Nota1 = 0;
        Nota2 = 0;
        Nota3 = 0;
        Nota4 = 0;

        Notapromedio = (Nota1 + Nota2 + Nota3 + Nota4)/4;
    }
}
