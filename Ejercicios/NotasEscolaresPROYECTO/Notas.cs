using System;
using System.Collections.Generic;

public class Notas
{
    public List<Alumno> ListadeAlumnos { get; set; }

    public List<ClasesDisponibles> ListadeClasesDisponibles { get; set; }


    public Notas()
    {

        ListadeAlumnos = new List<Alumno>();
        CargarAlumno();

        ListadeClasesDisponibles = new List<ClasesDisponibles>();
        CargarClasesDisponibles();


    }
    private void CargarAlumno()
    {
      Alumno a1 = new Alumno(101,"Maya","Cruz");
      ListadeAlumnos.Add(a1);

      Alumno a2 = new Alumno(102,"Maria","Lagos");
      ListadeAlumnos.Add(a2);

      Alumno a3 = new Alumno(103,"Juan","Perez");
      ListadeAlumnos.Add(a3);

      Alumno a4 = new Alumno(104,"Julia","Torres");
      ListadeAlumnos.Add(a4);

      Alumno a5 = new Alumno(105,"Lisa","Castillo");
      ListadeAlumnos.Add(a5);
    }

    private void CargarClasesDisponibles()
    {
      ClasesDisponibles cd1 = new ClasesDisponibles("CD001","Matematicas");
      ListadeClasesDisponibles.Add(cd1);
      
      ClasesDisponibles cd2 = new ClasesDisponibles("CD002","Español");
      ListadeClasesDisponibles.Add(cd2);

      ClasesDisponibles cd3 = new ClasesDisponibles("CD003","Ciencias Naturales");
      ListadeClasesDisponibles.Add(cd3);

      ClasesDisponibles cd4 = new ClasesDisponibles("CD004","Estudios Sociales");
      ListadeClasesDisponibles.Add(cd4);

      ClasesDisponibles cd5 = new ClasesDisponibles("CD005","Ingles");
      ListadeClasesDisponibles.Add(cd5);

    }
     public void ListarAlumno()
    {
        Console.Clear();
        Console.WriteLine("====================");
        Console.WriteLine("Lista de Estudiantes");
        Console.WriteLine("====================");
        
        foreach (var alumno in ListadeAlumnos)
        {
          Console.WriteLine(alumno.CodigoAlumno + " | " + alumno.Nombre + " | " + alumno.Apellido);
        }
        Console.ReadLine();
    }
    public void ListarClasesDisponibles()
    {
        Console.Clear();
        Console.WriteLine("============== ");
        Console.WriteLine("Lista de Clases");
        Console.WriteLine("===============");
        
        foreach (var clasesdisponibles in ListadeClasesDisponibles)
        {
          Console.WriteLine(clasesdisponibles.CodigoClaseDisponible + " | " + clasesdisponibles.NombreClaseDisponible);
        }
        Console.ReadLine();
    }
     public void IngresarAcumulados()
    {
      Console.Clear();

      Console.WriteLine("================");
      Console.WriteLine("Notas Acumuladas");
      Console.WriteLine("================");
      Console.WriteLine("");
      Console.WriteLine("Ingrese el codigo del Alumno: ");
      string codigoAlumno = Console.ReadLine();

      Alumno alumno = ListadeAlumnos.Find(e => e.CodigoAlumno.ToString() == codigoAlumno);
      if (alumno == null)
      {
        Console.WriteLine("El Alumno no existe");
        Console.ReadLine();
        return;
      }
      else
      {
        Console.WriteLine("");
        Console.WriteLine("Alumno: " + alumno.Nombre + " | " + alumno.Apellido);
        Console.WriteLine("");
      }
      

      foreach (var clasesdisponibles in ListadeClasesDisponibles)
      {
        Console.WriteLine("==============================================================");
        Console.WriteLine("Clases Disponibles: " + clasesdisponibles.NombreClaseDisponible);
        Console.WriteLine("==============================================================");
        Console.WriteLine("");
        Console.WriteLine("Ingresa las 4 notas parciales");
        Console.WriteLine("");
        Console.WriteLine("Nota 1: ");
        clasesdisponibles.Nota1 = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Nota 2: ");
        clasesdisponibles.Nota2 = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Nota 3: ");
        clasesdisponibles.Nota3 = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Nota 4: ");
        clasesdisponibles.Nota4 = Int32.Parse(Console.ReadLine());

        clasesdisponibles.Notapromedio = (clasesdisponibles.Nota1 + clasesdisponibles.Nota2 + clasesdisponibles.Nota3 + clasesdisponibles.Nota4)/4;
      }

      foreach (var nota in ListadeClasesDisponibles)
      {
        Console.WriteLine("El promedio es de: " + nota.Notapromedio + " en la clase de " + nota.NombreClaseDisponible);
      }
      Console.ReadLine();
    }

    public void NotasFinales()
    {
      //double suma = 0;
      Console.Clear();
      Console.WriteLine("=================");
      Console.WriteLine("Total del parcial");
      Console.WriteLine("=================");
      Console.WriteLine("Ingresa el codigo del Alumno: ");
      string codigoAlumno = Console.ReadLine();

      Alumno alumno = ListadeAlumnos.Find(e => e.CodigoAlumno.ToString() == codigoAlumno);
      if (alumno == null)
      {
        Console.WriteLine("Estudiante no existe");
        Console.ReadLine();
        return;
      }
      else
      {
        Console.WriteLine("");
        Console.WriteLine("Alumno: " + alumno.Nombre + " | " + alumno.Apellido);
        Console.WriteLine("");
      }

      foreach (var nota in ListadeClasesDisponibles)
      {
        Console.WriteLine("EL Promedio final es de: " + nota.Notapromedio + " en la clase de " + nota.NombreClaseDisponible);
       // suma += nota.Notapromedio / 5;
      }
      //Console.WriteLine(""); 
      //Console.WriteLine("EL Promedio final de " + alumno.Nombre + " es de: " + suma.ToString("N2") + " %" );
      Console.ReadLine();
     }       
}