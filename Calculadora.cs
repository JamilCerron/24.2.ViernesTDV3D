using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _24._2.TDV3DViernes
{
    internal class Calculadora
    {
        bool continuar = true;
        bool continuarCalculando=true;
        bool continuarPreguntandoOperadores=true;
        public void Ejecucíon()
        {
           
            while (continuar)
            {
                Console.WriteLine("Digite su primer numero");
                string a = Console.ReadLine();

                if (float.TryParse(a, out float valor1))
                {
                    Console.WriteLine("Digite su segundo numero");
                    string b = Console.ReadLine();

                    if (float.TryParse(b, out float valor2))
                    {
                        while (continuarPreguntandoOperadores)
                        {
                            Console.WriteLine("¿Que operación basica desea realizar? Digite uno de esto valores : +,-,*,/");
                            string c = Console.ReadLine();

                            switch (c)
                            {
                                case "+":   SumarNumeros();
                                            continuarPreguntandoOperadores = false;       
                                            break;
                                case "-":   RestarNumeros();
                                            continuarPreguntandoOperadores = false;
                                            break;
                                case "*":    MultiplicarNumeros();
                                             continuarPreguntandoOperadores = false;
                                             break;
                                case "/":   DividirNumeros();
                                            continuarPreguntandoOperadores = false;
                                            break;
                                default: MensajeDeOpcionInvalida1(); break;
                            }
                        }
                        

                        while (continuarCalculando)
                        {
                            Console.WriteLine("¿Desear continuar operando?");
                            Console.WriteLine("1.Si");
                            Console.WriteLine("2.No");
                            string entrada = Console.ReadLine();

                            if (float.TryParse(entrada, out float d) && (d == 1 || d == 2))
                            {
                                continuarCalculando = false;

                                if (d == 2)
                                {
                                    Console.WriteLine("Programa finalizado.Pulse cualquier tecla para salir...");
                                    Console.ReadKey();
                                    continuar = false;
                                }
                                    
                            }

                            else
                            {
                                MensajeDeOpcionInvalida2();
                            }
                        }
                        continuarCalculando = true;


                        void SumarNumeros() => Console.WriteLine($"El resultado de su operacion es {valor1 + valor2}");
                        void RestarNumeros() => Console.WriteLine($"El resultado de su operacion es {valor1 - valor2}");
                        void MultiplicarNumeros() => Console.WriteLine($"El resultado de su operacion es {valor1* valor2}");
                        void DividirNumeros() => Console.WriteLine($"El resultado de su operacion es {valor1/ valor2}");
                    }

                    else MensajeDeOpcionInvalida1();
                }

                else MensajeDeOpcionInvalida1();

      
            }
    
        }

        void MensajeDeOpcionInvalida1()
        {
            Console.WriteLine("Lectura invalida.Porfavor ,vuelva a digitar los valores correspondientes");
        }

        void MensajeDeOpcionInvalida2()
        {
            Console.WriteLine("Opción invalida. Porfavor vuelva a marcar una de las opciones");
        }
    }
}
