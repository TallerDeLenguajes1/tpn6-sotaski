using System;
//using System.Math;
namespace tp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            Console.Write("ingres el numero que quiera invertir: ");
            num = int.Parse(Console.ReadLine());
            int resto = 0, cosiente = 0;
            if(num >= 0)
            {
                if(num < 10)
                {
                    Console.WriteLine("el numer invertido es: " + num);
                }
                else
                {
                    int cont = 0;
                    int num2 = num;
                    int mostrar = 0;
                    while ((num / 10) > 0)
                    {
                        num = num / 10;
                        cont++;
                        
                    }



                    while ((num2 % 10) > 0)
                    {
                        cosiente = num2 / 10;
                        
                        resto = Convert.ToInt32( num2 % 10);
                        mostrar =  mostrar + Convert.ToInt32(resto * Math.Pow(10, cont));
                        cont--;
                        num2 = cosiente;
                    }
                    Console.WriteLine("El numero invertido es: {0}", mostrar);
                }
            }
            Console.ReadKey();
        }
    }
}
