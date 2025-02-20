using System;

namespace DesafioLoopPromedio
{
    internal class Program
    {
        static string nombre;
        static string comprobacionNota;
        static int contador = 0;
        static int notaIngresada = 0;
        static int notas = 0;
        static float promedio = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el nombre del estudiante: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Inicializando ingreso de datos, para detener escriba >fin< \n");
            Console.ReadLine();
            
            IngresoDatos();

            CalculosPromedio();

            Console.ReadLine();
            
        }
        public static void IngresoDatos() //seccion dedicada a recopilar y validar datos
        {
            do
            {
                Console.WriteLine("Ingresa una nota para agregar al promedio: ");
                comprobacionNota = Console.ReadLine();

                if (comprobacionNota.Equals("fin")){
                    break;
                }
                else
                {
                    if (int.TryParse(comprobacionNota, out notas))
                    {
                        if (notas < 1 || notas > 10)
                        {
                            Console.WriteLine("ERROR -La nota debe estar en un rango de 1 a 10");
                            Console.ReadLine();
                        }
                        else
                        {
                            notaIngresada += notas;
                            contador++;
                            Console.WriteLine("Nota ingresda correctamente \n");
                        }
                    }
                    else
                    {
                        Console.WriteLine("ERROR -Dato No valido, favor ingresar numeros enteros!");
                        Console.ReadLine();
                    }
                }
            } while (true);
        }
        
        public static void CalculosPromedio() //seccion dedicada a procesar los datos aprobados
        {
            if (contador > 0)
            {
                promedio = (float)notaIngresada / contador; //Casteo notaIngresada a float para calcular promedios
                Console.WriteLine($"El lumno ingresado: {nombre}, tiene un promedo de {promedio}");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("No se ingresaron notas validas!");
            }
        }
    }
}
