using System;

namespace punto4
{
    class Program
    {
        static void Main(string[] args)
        {
            //__________________PUNTO 4_______________________-
            //longitud
            string cadena = "Hola jajajaja che que onda ahre!";
            Console.WriteLine(cadena);
            int longcadena = cadena.Length;
            Console.WriteLine("\n" + longcadena);
            //concatenar
            string palabra1 = "hola";
            string palabra2 = "cele";
            string concatenado = string.Concat(palabra1 + " " + palabra2);
            //subcadena

            Console.WriteLine("\n" + concatenado);

            Console.WriteLine(cadena);
            string cadena2 = cadena.Substring(5, 8);
            //Calculadora

            float num1;
            float num2;
            char operando;
            bool resp = true;
            Console.Write("\n\n");
            while (resp != false)
            {
                Console.Write("\n\nQue operacion decea realizar? (Escrina'+' si es suma, '-' si esresta, '*' si multiplicacion, '/' si es divicion): ");

                operando = char.Parse(Console.ReadLine());
                Console.Write("\n\nEscriba un numero: ");
                num1 = float.Parse(Console.ReadLine());
                Console.Write("Escriba otro numero: ");
                num2 = float.Parse(Console.ReadLine());
                string Resultado;
                switch (operando)
                {
                    case '+':
                        Console.Write(Resultado = "La suma de " + num1 + " + " + num2 + " es: " + (num1 + num2));
                        break;
                    case '-':
                        Console.Write(Resultado = "La resta de " + num1 + " - " + num2 + " es: " + (num1 - num2));
                        break;
                    case '*':
                        Console.Write(Resultado = "La multiplicacion de " + num1 + " * " + num2 + " es: " + (num1 * num2));
                        break;
                    case '/':
                        Console.Write(Resultado = "La division de " + num1 + " / " + num2 + " es: " + (num1 / num2));
                        break;
                    default: Console.Write("El operando no es valido"); break;
                }
            }
                Console.Write("\nDesea realizar otra operancion? (si = 1, 0 = no)");
                resp = Convert.ToBoolean(int.Parse(Console.ReadLine()));
                if (resp == true) resp = true;
                else resp = false;
               //////////////////////// foreach
    
                string cadString = "Hola, esto es del punto 4";
                foreach (char cadechar in cadString)
                {
                    Console.Write(cadechar + " ");
                }
                // buscar palabra
                string c1 = "hola";
                bool b = cadString.Contains(c1);
                Console.WriteLine("\nResultado de la palabra buscada: " + b);
                //Convertir a mayuscla
                string mayuscula = cadString.ToUpper();
                Console.WriteLine("\n" + mayuscula);
                //Convertir a minusculas
                string minuscula = mayuscula.ToLower();
                Console.WriteLine("\n" + minuscula);
                //Comparar dos cadenas
                Console.WriteLine("\nLas dos cadenas anteriores son iguales?, la respuesta es: {0}", string.Equals(mayuscula, minuscula));
                // divicion Split()
                string[] separado = cadString.Split(" ");
                Console.WriteLine("mostrar la cadena dividida: ");
                foreach (string mostrar in separado)
                {
                    Console.WriteLine(mostrar);
                }

                //Ecuacion simple_____________________________________________________________________


                string ecuacion;
          
                Console.Write("\n\nEscribir la ecuacion: ");

            ecuacion = Console.ReadLine();
            int cont = 0;
            int n2;
            int n1 = 0;
            string[] dividir;
            foreach (char car in ecuacion)
            {
                switch (car)
                {
                    case '+':
                        dividir = ecuacion.Split(car);
                        n1 = int.Parse(dividir[0]);

                        n2 = int.Parse(dividir[1]);
                        Console.WriteLine("resultado: " + (n1 + n2) );
                        break;
                    case '-':
                        dividir = ecuacion.Split(car);
                        n1 = int.Parse(dividir[0]);

                        n2 = int.Parse(dividir[1]);
                        Console.WriteLine("resultado: " + (n1 - n2));
                        break;
                    case '*':
                        dividir = ecuacion.Split(car);
                        n1 = int.Parse(dividir[0]);

                        n2 = int.Parse(dividir[1]);
                        Console.WriteLine("resultado: " + (n1 * n2));
                        break;
                    case '/':
                        dividir = ecuacion.Split(car);
                        n1 = int.Parse(dividir[0]);

                        n2 = int.Parse(dividir[1]);
                        Console.WriteLine("resultado: " + (n1 / n2));
                        break;
                    default: break;
                }
                cont++;
            }


        }
    }
}
