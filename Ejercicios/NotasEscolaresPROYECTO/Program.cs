using System;

namespace NotasEscolaresPROYECTO
{
    class Program
    {
       static void Main(string[] args)
        {
            Notas notas = new Notas();
            string opcion = "";

            while (true)
            {
                Console.Clear();
                Console.WriteLine("===============================");
                Console.WriteLine(" ESCUELA JOSE TRINIDAD CABAÑAS ");
                Console.WriteLine("===============================");               
                Console.WriteLine("");
                Console.WriteLine("------------------------------");
                Console.WriteLine("- SISTEMA DE NOTAS ESCOLARES -");
                Console.WriteLine("------------------------------");
                Console.WriteLine("");
                Console.WriteLine("1 - Lista de Alumnos");
                Console.WriteLine("2 - Lista de Clases Disponibles");
                Console.WriteLine("3 - Ingreso de Acumulados");
                Console.WriteLine("4 - Notas Finales");
                Console.WriteLine("0 - Salir");
                Console.WriteLine("");
                
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        notas.ListarAlumno();
                        break;
                    case "2":
                       notas.ListarClasesDisponibles();
                        break;
                    case "3":
                        notas.IngresarAcumulados();
                        break;
                    case "4":
                        notas.NotasFinales();
                        break;
                    default:
                        break;
                }

                if(opcion == "0")
                {
                    break;
                }
            }
        }
    }
}