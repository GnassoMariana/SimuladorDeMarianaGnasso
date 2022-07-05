using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorDeMarianaGnasso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Simulacro Parcial";

            int horas, minutos, segundos;
            string indicador;
            int horasFormato24;

            Console.WriteLine("Ingresar las horas:");
            horas = Convert.ToInt32(Console.ReadLine());

            if (EsHoraValida(horas))
            {
                Console.WriteLine("Ingresar minutos:");
                minutos = Convert.ToInt32(Console.ReadLine());
                if (EsMinValido(minutos))
                {
                    Console.WriteLine("Ingresar segundos");
                    segundos = Convert.ToInt32(Console.ReadLine());
                    if (EsSegValido(segundos))
                    {
                        Console.WriteLine("Ingresar el formato: AM o PM");
                        indicador = Convert.ToString(Console.ReadLine());
                        if (EsFormatoValido(indicador))
                        {
                            Console.WriteLine($"{horas}:{minutos}:{segundos}   {indicador.ToUpper()}");
                            horasFormato24 = ConvertirA24(horas, indicador);
                            Console.WriteLine("Formato 24hs:");
                            Console.WriteLine($"{horasFormato24}:{minutos}:{segundos}");
                        }
                        else
                        {
                            Console.WriteLine("El formato ingresado es invalido");
                        }


                    }
                    else
                    {
                        Console.WriteLine("El numero de segundos ingresado es invalido");
                    }
                }
                else
                {
                    Console.WriteLine("El numero de minutos ingresado es invalido");
                }
            }
            else
            {
                Console.WriteLine("El numero de horas ingresado es invalido.");
            }

            Console.ReadLine();

        }

        private static int ConvertirA24(int horas, string indicador)
        {
            int resultado;
            if (indicador.ToUpper() == "AM")
            {
                if (horas == 12)
                {
                    horas = horas - 12;
                }
                else
                {
                    horas = horas;
                }
            }
            else if (indicador.ToUpper() == "PM")
            {
                if (horas == 12)
                {
                    horas = horas;
                }
                else
                {
                    horas = horas + 12;
                }
            }
            resultado = horas;
            return resultado;
        }

        private static bool EsFormatoValido(string indicador)
        {
            bool formatoValido;
            if (indicador.ToUpper() == "AM" || indicador.ToUpper() == "PM")
            {
                formatoValido = true;
            }
            else
            {
                formatoValido = false;
            }
            return formatoValido;
        }

        private static bool EsSegValido(int segundos)
        {
            bool segValido;
            if (segundos >= 1 && segundos <= 60)
            {
                segValido = true;
            }
            else
            {
                segValido = false;
            }
            return segValido;
        }

        private static bool EsMinValido(int minutos)
        {
            bool minValido;
            if (minutos >= 0 && minutos <= 60)
            {
                minValido = true;
            }
            else
            {
                minValido = false;
            }
            return minValido;
        }

        private static bool EsHoraValida(int horas)
        {
            bool horaValida;
            if (horas >= 1 && horas <= 12)
            {
                horaValida = true;
            }
            else
            {
                horaValida = false;
            }
            return horaValida;
        }
    }
}

        
    

