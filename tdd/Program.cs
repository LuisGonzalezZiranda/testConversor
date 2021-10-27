using System;

namespace tdd
{
    class Program
    {
        static void Main(string[] args)
        {
            var binicial = 16;
            var bfinal = 10;
            var valor = "f";
            var convert = new tdd.Conversor();
            var result = convert.Converter(binicial, bfinal, valor);
            Console.WriteLine(result);
        }
    }
}
