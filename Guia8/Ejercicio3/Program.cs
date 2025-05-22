using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicio3
{
    internal class Program
    {
        #region resolución del problema
        static string Nombre0;
        static int NumeroLibreta0;
        static string Nombre1;
        static int NumeroLibreta1;
        static string Nombre2;
        static int NumeroLibreta2;
        static int Orden = 0;
        
        static void RegistrarNombreYNumeroLibreta(string nombre, int numeroLibreta)
        {
            if (Orden == 0)
            {
                Nombre0 = nombre;
                NumeroLibreta0 = numeroLibreta;
            }
            else if (Orden == 1)
            {
                if (numeroLibreta < NumeroLibreta0)
                {
                    Nombre1 = Nombre0;
                    NumeroLibreta1 = NumeroLibreta0;
                    Nombre0 = nombre;
                    NumeroLibreta0 = numeroLibreta;
                }
                else
                {
                    Nombre1 = nombre;
                    NumeroLibreta1 = numeroLibreta;
                }
            }
            else if (Orden == 2)
            {
                if (numeroLibreta < NumeroLibreta0)
                {
                    Nombre2 = Nombre1;
                    NumeroLibreta2 = NumeroLibreta1;
                    Nombre1 = Nombre0;
                    NumeroLibreta1 = NumeroLibreta0;
                    Nombre0 = nombre;
                    NumeroLibreta0 = numeroLibreta;
                }
                if (numeroLibreta < NumeroLibreta1)
                {
                    Nombre2 = Nombre1;
                    NumeroLibreta2 = NumeroLibreta1;
                    Nombre1 = nombre;
                    NumeroLibreta1= numeroLibreta;
                }
                else
                {
                    Nombre2 = nombre;
                    NumeroLibreta2 = numeroLibreta;
                }
            }
            Orden++;
        }

        #endregion

        #region metodos 
        static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.Clear();
            Console.WriteLine("Ingrese las siguiente opciones:\n\n");
            Console.WriteLine("1- Registrar las notas de los tres alumnos");
            Console.WriteLine("2- Mostrar lista ordenada");
            Console.WriteLine("(otro)- Salir.");
            int op = Convert.ToInt32(Console.ReadLine());
            return op;
        }

        static void MostrarPantallaSolicitarAlumnos()
        {
            Console.Clear();
            Console.WriteLine("Ingrese los nombres de alumnos y el numero de libreta de cada uno \n\n");

            for (int nro = 0; nro < 3; nro++)
            {
                Console.WriteLine("Alumno: " + (nro + 1) + "\n");
                string nombre = Console.ReadLine();
                int nota = Convert.ToInt32(Console.ReadLine());

                RegistrarNombreYNumeroLibreta(nombre, nota);
            }

            Console.WriteLine("\n\n\nPresione una tecla para continuar");
            Console.ReadKey();
        }

        static void MostrarPantallaMostrarListaOrdenada()
        {
            Console.Clear();
            Console.WriteLine("Reparto de dinero: \n\n");

            Console.WriteLine($"{Nombre0,20}|{NumeroLibreta0,10}");
            Console.WriteLine($"{Nombre1,20}|{NumeroLibreta1,10}");
            Console.WriteLine($"{Nombre2,20}|{NumeroLibreta2,10}");

            Console.WriteLine("\n\n\nPresione una tecla para volver al menú principal");
            Console.ReadKey();
        }

        #endregion

        static void Main(string[] args)
        {
            int op = MostrarPantallaSolicitarOpcionMenu();

            #region iterar opciones menú
            while (op != -1)
            {
                #region verificar opción
                switch (op)
                {
                    case 1:
                        MostrarPantallaSolicitarAlumnos();
                        break;
                    case 2:
                        MostrarPantallaMostrarListaOrdenada();
                        break;
                    default:
                        op = -1;
                        break;
                }
                #endregion

                #region solicitar opción
                if (op != -1)
                    op = MostrarPantallaSolicitarOpcionMenu();
                #endregion
            }
            #endregion
        }
    }
}
