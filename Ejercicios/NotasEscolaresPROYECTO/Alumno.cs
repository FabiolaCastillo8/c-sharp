public class Alumno:Persona
{
  public int CodigoAlumno { get; set; }
  public string Apellido { get; set; }
 
  public Alumno(int codigoAlumno, string nombre, string apellido)
  {
    CodigoAlumno = codigoAlumno;
    Nombre = nombre;
    Apellido = apellido;
  }
}