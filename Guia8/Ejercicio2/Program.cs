
namespace Ejercicio2
{
    internal class Program
    {
        #region resolución del problema
        static int Edad0;
        static int Edad1;
        static int Edad2;
        static int Edad3;
        static double Monto;
        static double Porcentaje0;
        static double Porcentaje1;
        static double Porcentaje2;
        static double Porcentaje3;
        static double Monto0;
        static double Monto1;
        static double Monto2;
        static double Monto3;

        static void RegistrarMontoARepartir(double monto)
        {
            Monto = monto;
        }

        static void RegistrarEdad(int edad, int nroNiña)
        {
            switch (nroNiña)
            { 
                case 0: Edad0 = edad; break;
                case 1: Edad1 = edad; break;        
                case 2: Edad2 = edad; break;
                case 3: Edad3 = edad; break;
            }
        }

        static void CalcularMontosYPorcentajesARepartir()
        {
            double edadTotal=Edad0+Edad1+Edad2+Edad3;
            Porcentaje0 = 1.0 * Edad0 / edadTotal * 100;
            Porcentaje1 = 1.0 * Edad1 / edadTotal * 100;
            Porcentaje2 = 1.0 * Edad2 / edadTotal * 100;
            Porcentaje3 = 1.0 * Edad3 / edadTotal * 100;
            Monto0 = Monto * Porcentaje0/100;
            Monto1 = Monto * Porcentaje1/100;
            Monto2 = Monto * Porcentaje2/100;
            Monto3 = Monto * Porcentaje3/100;
        }

        #endregion

        #region metodos 
        static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.Clear();
            Console.WriteLine("Ingrese las siguiente opciones:\n\n");
            Console.WriteLine("1- Iniciar Monto a repartir");
            Console.WriteLine("2- Solicitar Edad Por niña");
            Console.WriteLine("3- Mostrar monto y porcentajes de las niñas");            
            Console.WriteLine("(otro)- Salir.");
            int op = Convert.ToInt32(Console.ReadLine());
            return op;
        }

        static void MostrarPantallaSolicitarMontoARepartir()
        {
            Console.Clear();
            Console.WriteLine("Monto a repartir: \n\n");

            double montoARepartir=Convert.ToDouble(Console.ReadLine());

            RegistrarMontoARepartir(montoARepartir);

            Console.WriteLine("\n\n\nPresione una tecla para continuar");
            Console.ReadKey();
        }

        static void MostrarPantallaSolicitarEdadesNiñas()
        {
            Console.Clear();
            Console.WriteLine("Edades de las niñas:\n\n");

            for (int nro = 0; nro < 4; nro++)
            {
                Console.WriteLine("Entre la edad de la niña número: "+(nro+1)+"\n");
                int edad = Convert.ToInt32(Console.ReadLine());
                RegistrarEdad(edad, nro);
            }
        }
       
        static void MostrarPantallaCalcularMostrarMontoYPorcentajePorNiña()
        {
            Console.Clear();
            Console.WriteLine("Reparto de dinero: \n\n");

            CalcularMontosYPorcentajesARepartir();

            Console.WriteLine($"Niña 1 ({Edad0}), Porcentaje: {Porcentaje0:f2}, Monto: ${Monto0:f2}");
            Console.WriteLine($"Niña 2 ({Edad1}), Porcentaje: {Porcentaje1:f2}, Monto: ${Monto1:f2}");
            Console.WriteLine($"Niña 3 ({Edad2}), Porcentaje: {Porcentaje2:f2}, Monto: ${Monto2:f2}");
            Console.WriteLine($"Niña 4 ({Edad3}), Porcentaje: {Porcentaje3:f2}, Monto: ${Monto3:f2}");

            Console.WriteLine("\n\n\nPresione una tecla para volver al menú principal");
            Console.ReadKey();
        }
        
        #endregion

        static void Main(string[] args)
        {
            MostrarPantallaSolicitarMontoARepartir();

            int op = MostrarPantallaSolicitarOpcionMenu();

            #region iterar opciones menú
            while (op != -1)
            {
                #region verificar opción
                switch (op)
                {
                    case 1:
                        MostrarPantallaSolicitarMontoARepartir();
                        break;
                    case 2:
                        MostrarPantallaSolicitarEdadesNiñas();                        
                        break;
                    case 3:
                        MostrarPantallaCalcularMostrarMontoYPorcentajePorNiña();                        
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
