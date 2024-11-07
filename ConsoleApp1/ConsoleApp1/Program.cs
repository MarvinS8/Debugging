using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                int suma = SumaNumeros(list);
                Console.WriteLine($"La suma es:{suma}");
                int Sumapares = SumaPares(list);
                int Sumainpares = SumaImpares(list);
                int RandomNum = SumaRandoms();
                Console.WriteLine($"La suma Par es:{Sumapares}");
                Console.WriteLine($"La suma ImPar es:{Sumainpares}");
                Console.WriteLine($"La suma Rando del 1 al 10 es:{RandomNum}");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error:{ex.ToString()}");
            }
        }
        static int SumaNumeros(List<int> lista)
        {
            int suma = 0;
            foreach (int i in lista)
            {
                //Valor= suma (contador)
                //1=1
                //2=3
                //3=6
                //4=10
                //5=15
                //6=21
                //7=28
                //8=36
                //9=45
                //10=55

                suma += i;
            }
            return suma;
        }
        static int SumaPares(List<int> lista)
        {
            int sumaPares = 0;
            foreach (var n in lista)
            {
                if (n % 2 == 0) // Verificar si el número es par
                    //2+4+6+8+10=30
                    sumaPares += n;
            }
            return sumaPares;
        }

        static int SumaImpares(List<int> lista)
        {
            int sumaImpares = 0;
            foreach (var n in lista)
            {
                //1+3+5+7+9

                if (n % 2 != 0) // Verificar si el número es impar
                    sumaImpares += n;
            }
            return sumaImpares;
        }
        static int SumaRandoms()
        {
            Random random = new Random();
            int suma = 0;
            for (int i = 0; i < 10; i++)
            {
                suma += random.Next(1, 11);//Como va incrementando la suma
                //9+4+8
            }
            return suma;
            
        }
       
    }
}
