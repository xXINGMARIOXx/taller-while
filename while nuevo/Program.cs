using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_nuevo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma = 0, i=1,i2=0, positivos=1;
            int ingresado = 0;
            
            while (i <= 6)
            {
                Console.WriteLine("Ingresar número ");
                ingresado = int.Parse(Console.ReadLine());
                if (ingresado < 0)
                {
                    suma += ingresado;
                }
                else if(ingresado > 0)
                { 
                    positivos+= ingresado;

                    i2+=1 ;


                }
                
                else
                {
                    i++; 
                    continue;
                }


                i++;

            }
            Console.WriteLine("la suma de los negativos = "+ suma +"\nPromedio "+ positivos % i2 );
            Console.ReadKey();
        }
    }
}
