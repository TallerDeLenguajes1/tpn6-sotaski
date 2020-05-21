using System;

namespace punto2
{
    class Program
    {
        static void Main(string[] args)
        {
           //_________________PUNTO 2_____________________
            float num1;
            float num2;
            char operando;
            bool resp = true;
            while (resp != false)
            {
                Console.Write("\n\nQue operacion decea realizar? (Escrina'+' si es suma, '-' si esresta, '*' si multiplicacion, '/' si es divicion): ");

                operando = char.Parse(Console.ReadLine());
                Console.Write("\n\nEscriba un numero: ");
                num1 = float.Parse(Console.ReadLine());
                Console.Write("Escriba otro numero: ");
                num2 = float.Parse(Console.ReadLine());
                switch (operando)
                {
                    case '+': Console.Write("La suma es: {0}", num1 + num2); break;
                    case '-': Console.Write("La resta es: {0}", num1 - num2); break;
                    case '*': Console.Write("La multiplicacion es: {0}", num1 * num2); break;
                    case '/': Console.Write("La divicion es: {0}", num1 / num2); break;
                    default: Console.Write("El operando no es valido"); break;
                }
                Console.Write("\nDesea realizar otra operancion? (si = 1, 0 = no)");
                resp = Convert.ToBoolean(int.Parse(Console.ReadLine()));
                if (resp == true) resp = true;
                else resp = false;
            }

            //__________ PUNTO3_______________________
            double num;
            Console.Write("\n\n\nIngrese un numero para realizar otras operaciones: ");
            num = double.Parse(Console.ReadLine());
            Console.Write("\nSu valor absoluto es:{0} ", Math.Abs(num));
            Console.Write("\nSu valor al cuadrado es: {0}", Math.Pow(num, 2));
            Console.Write("\nSu raiz cuadrada es: {0}", Math.Sqrt(num));
            Console.Write("\nEl seno es: {0}", Math.Sin(num));
            Console.Write("\nEl coseno es: {0}", Math.Cos(num));
            Console.Write("\nSu parte entera es: {0}", Math.Round(num, 6));
            int numero1;
            int numero2;
            Console.Write("\n\n\nIngrese un numero: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.Write("\nIngrese otro numero para calcuar cual de los dos es el max y el min: ");
            numero2 = int.Parse(Console.ReadLine());
            Console.Write("\nEl maximo entre los dos numeros es: {0}", Math.Max(numero1, numero2));
            Console.Write("\nEl minime entre los dos numeros es: {0}", Math.Min(numero1, numero2));


        }
    }
}
