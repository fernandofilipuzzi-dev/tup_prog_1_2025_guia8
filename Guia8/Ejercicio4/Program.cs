
namespace Ejercicio4
{
    internal class Program
    {
        #region resolución del problema
        static string Jugador1;
        static int SetGanados1;
        static string Jugador2;
        static int SetGanados2;
        
        static void RegistrarJugadores(string nombre1, string nombre2)
        {
            Jugador1 = nombre1;
            Jugador2 = nombre2;
            SetGanados1 = 0;
            SetGanados2 = 0;
        }
        static void RegistrarResultadoSet(int resultado1, int resultado2)
        {
            SetGanados1 += resultado1;
            SetGanados2 += resultado2;
        }
        static string DeterminarGanador()
        {
            if (SetGanados1 > SetGanados2)
                return Jugador1;
            else if (SetGanados1 < SetGanados2)
                return Jugador2;
            return "No hay ganador";
        }
        #endregion

        #region metodos 
        static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.Clear();
            Console.WriteLine("Ingrese las siguiente opciones:\n\n");
            Console.WriteLine("1- Registrar los nombres de los dos jugadores.");
            Console.WriteLine("2- Registrar los resultados de cada set de los jugadores.");
            Console.WriteLine("3- Mostrar el ganador.");
            Console.WriteLine("(otro)- Salir.");
            int op = Convert.ToInt32(Console.ReadLine());
            return op;
        }
        static void MostrarPantallaSolicitarNombreJugadores()
        {
            Console.Clear();
            Console.WriteLine("Ingrese los nombres de los dos jugadores \n\n");

            string nombre1 = Console.ReadLine();
            string nombre2 = Console.ReadLine();

            RegistrarJugadores(nombre1, nombre2);

            Console.WriteLine("\n\n\nPresione una tecla para continuar");
            Console.ReadKey();
        }
        static void MostrarPantallaSolicitarResultadoSet()
        {
            Console.Clear();
            Console.WriteLine("Ingrese los resultados del set de cada jugador \n\n");

            int resultado1 = Convert.ToInt32(Console.ReadLine());
            int resultado2 = Convert.ToInt32(Console.ReadLine());

            RegistrarResultadoSet(resultado1, resultado2);

            Console.WriteLine("\n\n\nPresione una tecla para continuar");
            Console.ReadKey();
        }
        static void MostrarPantallaGanador()
        {
            Console.Clear();
            Console.WriteLine("Ganador: \n\n");

            string ganador = DeterminarGanador();
            Console.WriteLine($"{ganador} \n\n");

            Console.WriteLine("\n\n\nPresione una tecla para continuar");
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
                        MostrarPantallaSolicitarNombreJugadores();
                        break;
                    case 2:
                        MostrarPantallaSolicitarResultadoSet();
                        break;
                    case 3:
                        MostrarPantallaGanador();
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
