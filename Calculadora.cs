using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._2.TDV3DViernes
{
    internal class Calculadora
    {
        bool continuar = true;
        public void Ejecucíon()
        {
           
            while (continuar)
            {
                Console.WriteLine("Digite su primer numero");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite su segundo    numero");
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine("¿Que operación basica desea realizar? Digite uno de esto valores : +,-,*,/");
                string c = Console.ReadLine();

                switch (c)
                {
                    case "+": SumarNumeros(); break;
                    case "-": RestarNumeros(); break;
                    case "*": MultiplicarNumeros(); break;
                    case "/": DividirNumeros(); break;
                }
                Console.WriteLine("Desear continuar operando: Si/No");
                string d= Console.ReadLine();
                if (d == "No") continuar = false;

                void SumarNumeros() => Console.WriteLine($"El resultado de su operación es {a}+{b}");
                void RestarNumeros() => Console.WriteLine($"El resultado de su operación es {a}-{b}");
                void MultiplicarNumeros() => Console.WriteLine($"El resultado de su operación es {a}*{b}");
                void DividirNumeros() => Console.WriteLine($"El resultado de su operación es {a}/{b}");



            }
            


        }
    }
}
