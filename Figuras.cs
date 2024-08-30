using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._2.TDV3DViernes
{
    internal class Figuras
    {
        Triangulo triangulo;
        Rectangulo rectangulo;
        Circulo circulo;
        string bx,ax;
        float baseFigura, alturaFigura;
    

        bool continuarPrograma=true;
        bool continuarOperando=true;
       public void Ejecucion()
        {
           while (continuarPrograma)
            {
              
                Console.WriteLine("Digite el numero de la figura cuya area desee calcular");
                Console.WriteLine("1.Rectangulo");
                Console.WriteLine("2.Circulo");
                Console.WriteLine("3.Triangulo");
                string digito = Console.ReadLine();

                if (int.TryParse(digito, out int valor) && (valor == 1 || valor == 2 || valor == 3))
                {
                    switch (valor)
                    {
                        case 1:
                            Console.WriteLine("Escriba la base");
                             bx =Console.ReadLine();

                            if (float.TryParse(bx, out  baseFigura))
                            {
                                Console.WriteLine("Escriba la altura");
                                 ax = Console.ReadLine();

                                if (float.TryParse(ax, out  alturaFigura))
                                {
                                    Console.WriteLine($"El area de la figura es {new Rectangulo(baseFigura,alturaFigura).RetornaArea()}");
                                }

                                else MensajeDeOpcionInvalida1(); break;
                            }

                            else MensajeDeOpcionInvalida1(); break;


                        case 2:
                                 Console.WriteLine("Escriba el radio");
                                 string r=Console.ReadLine();

                            if (float.TryParse(r, out float radio))
                            {
                                
                                Console.WriteLine($"El area de la figura es {new Circulo(radio).RetornaArea()}");
                            }

                            else MensajeDeOpcionInvalida1(); break;

                        case 3:
                        
                            Console.WriteLine("Escriba la base");
                             bx = Console.ReadLine();

                            if (float.TryParse(bx, out  baseFigura))
                            {
                                Console.WriteLine("Escriba la altura");
                                 ax = Console.ReadLine();

                                if (float.TryParse(ax, out  alturaFigura))
                                {
                                    Console.WriteLine($"El area de la figura es {new Triangulo(baseFigura,alturaFigura).RetornaArea()}");

                                }

                                else MensajeDeOpcionInvalida1(); break;
                            }

                            else MensajeDeOpcionInvalida1(); break;

                    }

                    while (continuarOperando)
                    {
                        valor = 0;
                        Console.WriteLine("¿Desea continuar operando?");
                        Console.WriteLine("1.Si");
                        Console.WriteLine("2.No");
                        digito = Console.ReadLine();

                        if (int.TryParse(digito, out valor) && (valor == 1 || valor == 2))
                        {
                            if (valor == 1)
                            {
                                valor = 0;
                                continuarOperando = false;
                            }

                            if (valor == 2)
                            {
                                continuarOperando = false;
                                continuarPrograma = false;
                                Console.WriteLine("Programa finalizado. Pulse cualquier tecla para salir...");
                                Console.ReadKey();
                            }

                        }

                        else MensajeDeOpcionInvalida1();
                    }

                }

                else MensajeDeOpcionInvalida2();


              

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
