using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NMock;
using NMockTests;

namespace PooVuelingNmock.Integration.Tests
{
    public class CalculadoraTests
    {
        ICalculadora calc = new Calculadora();

        [DataRow(4, 2, 2)]
        [DataRow(9, 3, 3)]
        [DataTestMethod()]
        public void DivisionTest(int num1, int num2, int resultado)
        {
            Assert.IsTrue(iCalculadora.Division(num1, num2) == resultado);
        }

        [DataRow(4, 2, 8)]
        [DataRow(6, 3, 18)]
        [DataTestMethod()]
        public void MultiplicacionTest(int num1, int num2, int resultado)
        {
            Assert.IsTrue(iCalculadora.Multiplicacion(num1, num2) == resultado);
        }

        [TestMethod()]
        public void RestaTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SumaTest()
        {
            Assert.Fail();
        }
    }
}
