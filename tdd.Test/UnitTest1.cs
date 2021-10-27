using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace tdd.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void binarioaDecimal()
        {
            var binicial = 2;
            var bfinal = 10;
            var valor = "100001";
            var convert = new tdd.Conversor();
            var expectedResult = "33";

            var result = convert.Converter(binicial, bfinal, valor);
            Assert.AreEqual(result, expectedResult);
        }

        [TestMethod]
        public void hexadecimalaDecimal()
        {
            var binicial = 16;
            var bfinal = 10;
            var valor = "b";
            var convert = new tdd.Conversor();
            var expectedResult = "11";

            var result = convert.Converter(binicial, bfinal, valor);
            Assert.AreEqual(result, expectedResult);
        }

        [TestMethod]
        public void decimalaBinario()
        {
            var binicial = 10;
            var bfinal = 2;
            var valor = "7";
            var convert = new tdd.Conversor();
            var expectedResult = "111";

            var result = convert.Converter(binicial, bfinal, valor);
            Assert.AreEqual(result, expectedResult);
        }

        [TestMethod]
        public void hexadecimalaBinario()
        {
            var binicial = 16;
            var bfinal = 2;
            var valor = "d";
            var convert = new tdd.Conversor();
            var expectedResult = "1101";

            var result = convert.Converter(binicial, bfinal, valor);
            Assert.AreEqual(result, expectedResult);
        }
        [TestMethod]
        public void decimalaHexadecimal()
        {
            var binicial = 10;
            var bfinal = 16;
            var valor = "11";
            var convert = new tdd.Conversor();
            var expectedResult = "b";

            var result = convert.Converter(binicial, bfinal, valor);
            Assert.AreEqual(result, expectedResult);
        }

        [TestMethod]
        public void binarioaHexadecimal()
        {
            var binicial = 2;
            var bfinal = 16;
            var valor = "1111";
            var convert = new tdd.Conversor();
            var expectedResult = "f";

            var result = convert.Converter(binicial, bfinal, valor);
            Assert.AreEqual(result, expectedResult);
        }

        [TestMethod]
        public void baseInicialNoAceptada()
        {
            var binicial = 8;
            var bfinal = 10;
            var valor = "11";
            var convert = new tdd.Conversor();
            var expectedResult = "0";

            var result = convert.Converter(binicial, bfinal, valor);
            Assert.AreEqual(result, expectedResult);
        }

        [TestMethod]
        public void baseFinalNoAceptada()
        {
            var binicial = 2;
            var bfinal = 19;
            var valor = "11";
            var convert = new tdd.Conversor();
            var expectedResult = "0";

            var result = convert.Converter(binicial, bfinal, valor);
            Assert.AreEqual(result, expectedResult);
        }
    }
}
