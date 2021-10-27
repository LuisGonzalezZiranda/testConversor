using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd
{
    public class Conversor
    {
        public string Converter(int binicial, int bfinal, string valor)
        {
            string resultado = "";
            int value = 0;
            long dec = 0;
            switch (bfinal)
            {
                case 10:
                    if (binicial == 2)
                    {
                        //convierte directamente cualquier valor a decimal.
                        long result = Convert.ToInt64(valor, binicial);
                        return result.ToString();
                    }
                    else if (binicial == 16)
                    {
                        //convierte directamente cualquier valor a decimal.
                        long result = Convert.ToInt64(valor, binicial);
                        return result.ToString();
                    }
                    else
                    {
                        Console.WriteLine("Escribe una base valida");
                        return "0";
                    }
                   
                case 16:
                    if (binicial == 2)
                    {
                        //primero convierte a decimal.
                        dec = Convert.ToInt64(valor, binicial);
                        resultado = Convert.ToString(dec, bfinal);
                        return resultado;
                    }
                    else if (binicial == 10)
                    {
                        value = Int32.Parse(valor);
                        resultado = Convert.ToString(value, bfinal);
                        return resultado;
                    }
                    else
                    {
                        Console.WriteLine("Escribe una base valida");
                        return "0";
                    }



                case 2:
                    //revisa si se va a cambiar hexadecimal
                    if (binicial == 16)
                    {
                        dec = Convert.ToInt64(valor, binicial);
                        //luego convierte a binario
                        resultado = Convert.ToString(dec, bfinal);
                        return resultado;
                    }
                    else if (binicial == 10)
                    {
                        value = Int32.Parse(valor);
                        //convierte a binario
                        resultado = Convert.ToString(value, bfinal);
                        return resultado;
                    }
                    else
                    {
                        Console.WriteLine("Escribe una base valida");
                        return "0";
                    }
                default:
                    Console.WriteLine("Escribe una base valida");
                    return "0";

            }
        }

    }
}
