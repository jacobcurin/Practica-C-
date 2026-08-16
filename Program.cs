using System.Linq.Expressions;

namespace PracticaSwitchCase
{
    public class Program
    {
        public static int IngreseNumero()
        {
            while (true)
            {
                Console.WriteLine("Ingrese un número del 1 al 12:");

                string dato = Console.ReadLine();

                if (int.TryParse(dato, out int numero))
                {
                    if (numero > 0 && numero < 13)
                    {
                        return numero;
                    }
                    else
                    {
                        Console.WriteLine("dato invalido");
                    }
                }
                else
                {
                    Console.WriteLine("error inesperado vuelva a intentarlo");
                }
            }
        }

        public static void Main(string[] args)
        {
            int numero = IngreseNumero();

            switch (numero)
            {
                case 1:
                    Console.WriteLine("Enero");
                    break;
                case 2:
                    Console.WriteLine("Febrero");
                    break;
                case 3:
                    Console.WriteLine("Marzo");
                    break;
                case 4:
                    Console.WriteLine("Abril");
                    break;
                case 5:
                    Console.WriteLine("Mayo");
                    break;
                case 6:
                    Console.WriteLine("Junio");
                    break;
                case 7:
                    Console.WriteLine("Julio");
                    break;
                case 8:
                    Console.WriteLine("Agosto");
                    break;
                case 9:
                    Console.WriteLine("Septiembre");
                    break;
                case 10:
                    Console.WriteLine("Octubre");
                    break;
                case 11:
                    Console.WriteLine("Noviembre");
                    break;
                case 12:
                    Console.WriteLine("Diciembre");
                    break;
            }
        }
    }
}
