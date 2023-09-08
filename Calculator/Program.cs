using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Varennyk Viktoriia
             * ETML Prapp Stage
             * Programme: calculatrice
             * 07.09.2023 
             */
            


            // variable
            Console.WriteLine("Calculatrcie");

            int res;

            // des variables 
            Console.WriteLine();
            Console.WriteLine("Write the first number");           // Affichage la phrase
            int num1 = Convert.ToInt32(Console.ReadLine());       // sauvegrade nombre
           
            Console.WriteLine();                                 // faire espace 
            Console.WriteLine("Choose the operators");          // Affichage la phrase 
            string operators = Console.ReadLine();
             
            Console.WriteLine();                              // faire espace
            Console.WriteLine("Write the second number");     // Affichage la phrase
            int num2 = Convert.ToInt32(Console.ReadLine());

            int result = 0;    // null 

            // le switch c'est comme "if, else" et il est plus facile
            switch (operators)
            {
                case "+":
                    /* res = num1 +num2;
                    Console.WriteLine("Addition" + res);*/

                    result = Add(num1, num2);   // demonder le method donner le result
                    Console.WriteLine();        // espace
                    Console.WriteLine("Addition:" + result);  // Affichage la phrase et result
                    break;                                     // le break arreter le programme 
                case "-":
                     /*res = num1 -num2;
                    Console.WriteLine("Substraction" + res);*/

                    result = Sub(num1, num2);   // demonder le method donner le result
                    Console.WriteLine();        // espace
                    Console.WriteLine("Sutraction:" + result);  // Affichage la phrase et result
                    break;                                      // le break arreter le programme 
                case "*":
                     /*res num1 *num2;
                    Console.WriteLine("Multiplication" + res);*/

                    result = Mul(num1, num2);  // demonder le method donner le result
                    Console.WriteLine();       // espace
                    Console.WriteLine("Multiplacation:" + result);  // Affichage la phrase et result
                    break;                                         // le break arreter le programme 
                case "/":
                    /* res num1 / num2;
                    Console.WriteLine("Division" + res);*/

                    result = Div(num1, num2);                    // demonder le method donner le result
                    Console.WriteLine();                        // espace
                    Console.WriteLine("Division:" + result);   // Affichage la phrase et result
                    break;                                    // le break arreter le programme 
            } 

            Console.ReadLine();    // pour que le machiche pouvoir lire des lines 

        }
        // des methods ils associé avec l'objet
        private static int Add(int num1, int num2)    // Add c'est le nom de method
        {
            int result = num1 + num2;                 // pour faire le calcul
            return result;                           // retourner le reult de addition

        }

        private static int Sub(int num1, int num2)      // Sub c'est le nom de method
        {
            int result = num1 - num2;                  // pour faire le calcul
            return result;                             // retourner le reult de subtraction

        }

        private static int Mul(int num1, int num2)      // Mul c'est le nom de method
        {
            int result = num1 * num2;                    // pour faire le calcul
            return result;                               // retourner le reult de multiplication

        }

        private static int Div(int num1, int num2)      // Div c'est le nom de method
        { 
            int result = num1 /  num2;                 // pour faire le calcul
            return result;                               // retourner le reult de divivsion 
        }
    }
}
