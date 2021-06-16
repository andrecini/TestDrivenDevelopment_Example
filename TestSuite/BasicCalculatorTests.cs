using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassSuite;
using System.Collections.Generic;

namespace TestSuite
{
    [TestClass]
    public class BasicCalculatorTests
    {
        #region Soma

        [TestMethod, TestCategory("Soma")]
        public void T0001_SomaDoisValores()
        {
            ICalculator calculator = new BasicCalculator();

            double value1 = 6, value2 = 4;

            double resultado = calculator.Soma(value1, value2);

            Assert.AreEqual(10, resultado);
        }

        [TestMethod, TestCategory("Soma")]
        public void T0001_SomaVetor()
        {
            ICalculator calculator = new BasicCalculator();

            double[] values = {1, 2, 3, 4, 5};

            double resultado = calculator.Soma(values);

            Assert.AreEqual(15, resultado);
        }
        
        [TestMethod, TestCategory("Soma")]
        public void T0001_SomaLista()
        {
            ICalculator calculator = new BasicCalculator();

            List<double> values = new List<double>() {1, 2, 3, 4, 5};

            double resultado = calculator.Soma(values);

            Assert.AreEqual(15, resultado);
        }

        [TestMethod, TestCategory("Soma")]
        public void T0001_SomaErrada()
        {
            ICalculator calculator = new BasicCalculator();

            double value1 = 6, value2 = 4;

            double resultado = calculator.Soma(value1, value2);

            Assert.AreNotEqual(0, resultado);
        }

        #endregion

        #region Multiplicação

        [TestMethod, TestCategory("Multiplicação")]
        public void T0002_MultiplicaçãoDoisValores()
        {
            ICalculator calculator = new BasicCalculator();

            double resultado = calculator.Multiplicacao(2, 5);

            Assert.AreEqual(10, resultado);
        }

        [TestMethod, TestCategory("Multiplicação")]
        public void T0002_MultiplicaçãoVetor()
        {
            ICalculator calculator = new BasicCalculator();

            double[] values = {2, 5, 10};

            double resultado = calculator.Multiplicacao(values);

            Assert.AreEqual(100, resultado);
        }

        [TestMethod, TestCategory("Multiplicação")]
        public void T0002_MultiplicaçãoLista()
        {
            ICalculator calculator = new BasicCalculator();

            List<double> values = new List<double>() { 2, 5, 10 };

            double resultado = calculator.Multiplicacao(values);

            Assert.AreEqual(100, resultado);
        }

        [TestMethod, TestCategory("Multiplicação")]
        public void T0002_MultiplicaçãoErrada()
        {
            ICalculator calculator = new BasicCalculator();

            double resultado = calculator.Multiplicacao(2, 5);

            Assert.AreNotEqual(12, resultado);
        }

        #endregion

        #region Subtração

        [TestMethod, TestCategory("Subtração")]
        public void T0003_SubtraiDoisValores()
        {
            ICalculator calculator = new BasicCalculator();

            double value1 = 6, value2 = 4;

            double resultado = calculator.Subtracao(value1, value2);

            Assert.AreEqual(2, resultado);
        }

        [TestMethod, TestCategory("Subtração")]
        public void T0003_SubtraiVetor()
        {
            ICalculator calculator = new BasicCalculator();

            double[] values = { 1, 2, 3, 4 };

            double resultado = calculator.Subtracao(15, values);

            Assert.AreEqual(5, resultado);
        }

        [TestMethod, TestCategory("Subtração")]
        public void T0003_SubtraiLista()
        {
            ICalculator calculator = new BasicCalculator();

            List<double> values = new List<double>() { 1, 2, 3, 4 };

            double resultado = calculator.Subtracao(15, values);

            Assert.AreEqual(5, resultado);
        }

        [TestMethod, TestCategory("Subtração")]
        public void T0003_SubtraiErrada()
        {
            ICalculator calculator = new BasicCalculator();

            double value1 = 10, value2 = 12;

            double resultado = calculator.Subtracao(value1, value2);

            Assert.AreNotEqual(0, resultado);
        }

        #endregion

        #region Divisão

        [TestMethod, TestCategory("Divisão")]
        public void T0004_DivideDoisValores()
        {
            ICalculator calculator = new BasicCalculator();

            double value1 = 6, value2 = 2;

            double resultado = calculator.Divisao(value1, value2);

            Assert.AreEqual(3, resultado);
        }

        [TestMethod, TestCategory("Divisão")]
        public void T0004_DivideVetor()
        {
            ICalculator calculator = new BasicCalculator();

            double[] values = { 4, 5 };

            double resultado = calculator.Divisao(20, values);

            Assert.AreEqual(1, resultado);
        }

        [TestMethod, TestCategory("Divisão")]
        public void T0004_DivideLista()
        {
            ICalculator calculator = new BasicCalculator();

            List<double> values = new List<double>() { 4, 5 };

            double resultado = calculator.Divisao(20, values);

            Assert.AreEqual(1, resultado);
        }

        [TestMethod, TestCategory("Divisão")]
        public void T0004_DivideErrada()
        {
            ICalculator calculator = new BasicCalculator();

            double value1 = 10, value2 = 2;

            double resultado = calculator.Divisao(value1, value2);

            Assert.AreNotEqual(4, resultado);
        }

        #endregion
    }
}
