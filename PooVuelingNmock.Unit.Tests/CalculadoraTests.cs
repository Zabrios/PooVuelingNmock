using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NMock;
using NMockTests;

namespace PooVuelingNmock.Unit.Tests
{
    [TestClass]
    public class CalculadoraTests
    {
        private MockFactory mock;
        private Mock<ICalculadora> mockObject;
        //private Calculadora calc;

        [SetUp]
        public void Setup()
        {
            mock = new MockFactory();
            mockObject = mock.CreateMock<ICalculadora>();
            //calc = new Calculadora();
        }

        [TestMethod]
        public void DivisionTest()
        {
            //ICalculadora calc = new ICalculadora<Mockobj;
            var calc = new Calculadora(mockObject.MockObject);
            mockObject.Expects.One.MethodWith(x => x.Division(4,2)).WillReturn(2);
            
            var result = mockObject.Division(4,2);
            Assert.AreEqual(2, result);
        }

        [TestMethod()]
        public void MultiplicacionTest()
        {
            var calc = new Calculadora(mockObject.MockObject);
            mockObject.Expects.One.MethodWith(x => x.Multiplicacion(4, 2)).WillReturn(8);

            var result = mockObject.Multiplicacion(4, 2);
            Assert.AreEqual(8, result);
        }

        [TestMethod()]
        public void RestaTest()
        {
            var calc = new Calculadora(mockObject.MockObject);
            mockObject.Expects.One.MethodWith(x => x.Resta(4, 2)).WillReturn(2);

            var result = mockObject.Resta(4, 2);
            Assert.AreEqual(2, result);
        }

        [TestMethod()]
        public void SumaTest()
        {
            var calc = new Calculadora(mockObject.MockObject);
            mockObject.Expects.One.MethodWith(x => x.Suma(4, 2)).WillReturn(6);

            var result = mockObject.Suma(4, 2);
            Assert.AreEqual(6, result);
        }

    }
}
