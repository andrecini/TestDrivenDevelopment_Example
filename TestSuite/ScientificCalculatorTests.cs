using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassSuite;
using System.Collections.Generic;

namespace TestSuite
{
    [TestClass]
    public class ScientificCalculatorTests
    {
        #region Potencia

        [TestMethod, TestCategory("Potencia")]
        public void T0001_Potencia()
        {
            IScientific calculator = new ScientificCalculator();

            double resultado = calculator.Potencia(5, 2);

            Assert.AreEqual(25, resultado);
        }

        [TestMethod, TestCategory("Potencia")]
        public void T0001_PotenciaErrada()
        {
            IScientific calculator = new ScientificCalculator();

            double resultado = calculator.Potencia(5, 2);

            Assert.AreNotEqual(20, resultado);
        }

        #endregion

        #region Raiz

        [TestMethod, TestCategory("Raiz")]
        public void T0002_Raiz()
        {
            IScientific calculator = new ScientificCalculator();

            double resultado = calculator.Raiz(4, 2);

            Assert.AreEqual(2, resultado);
        }

        [TestMethod, TestCategory("Raiz")]
        public void T0002_RaizErrada()
        {
            IScientific calculator = new ScientificCalculator();

            double resultado = calculator.Raiz(16, 2);

            Assert.AreNotEqual(8, resultado);
        }

        #endregion

        #region Média

        [TestMethod, TestCategory("Média")]
        public void T0003_MediaDoisValores()
        {
            IScientific calculator = new ScientificCalculator();

            double resultado = calculator.Media(10, 6);

            Assert.AreEqual(8, resultado);
        }

        [TestMethod, TestCategory("Média")]
        public void T0003_MediaVetor()
        {
            IScientific calculator = new ScientificCalculator();

            double[] values = { 8, 2, 4, 6 };

            double resultado = calculator.Media(values);

            Assert.AreEqual(5, resultado);
        }

        [TestMethod, TestCategory("Média")]
        public void T0003_MediaLista()
        {
            IScientific calculator = new ScientificCalculator();

            List<double> values = new List<double>(){ 8, 2, 4, 6 };

            double resultado = calculator.Media(values);

            Assert.AreEqual(5, resultado);
        }

        [TestMethod, TestCategory("Média")]
        public void T0003_MediaErrada()
        {
            IScientific calculator = new ScientificCalculator();

            double resultado = calculator.Media(10, 0);

            Assert.AreNotEqual(6, resultado);
        }

        #endregion

        #region RegraX

        [TestMethod, TestCategory("Regra do X")]
        public void T0004_RegraX()
        {
            IScientific calculator = new ScientificCalculator();

            double resultado = calculator.RegraX(10, 100, 2);

            Assert.AreEqual(20, resultado);
        }

        [TestMethod, TestCategory("Regra do X")]
        public void T0004_RegraXErrada()
        {
            IScientific calculator = new ScientificCalculator();

            double resultado = calculator.RegraX(1, 100, 5);

            Assert.AreNotEqual(5, resultado);
        }

        #endregion

        #region Fatoração

        [TestMethod, TestCategory("Fatoracao")]
        public void T0005_Fatoracao()
        {
            IScientific calculator = new ScientificCalculator();

            double resultado = calculator.Fatorar(5);

            Assert.AreEqual(120, resultado);
        }

        [TestMethod, TestCategory("Fatoracao")]
        public void T0005_FatoracaoErrada()
        {
            IScientific calculator = new ScientificCalculator();

            double resultado = calculator.Fatorar(6);

            Assert.AreNotEqual(120, resultado);
        }

        #endregion

        #region Log

        [TestMethod, TestCategory("Log")]
        public void T0006_LogBase10()
        {
            IScientific calculator = new ScientificCalculator();

            double resultado = calculator.Log(2);
            
            Assert.AreEqual(0.30103, resultado, 0.00001);
        }

        [TestMethod, TestCategory("Log")]
        public void T0006_LogComBase()
        {
            IScientific calculator = new ScientificCalculator();

            double resultado = calculator.Log(2, 5);

            Assert.AreEqual(0.4307, resultado, 0.0001);
        }

        [TestMethod, TestCategory("Log")]
        public void T0006_LogErrado()
        {
            IScientific calculator = new ScientificCalculator();

            double resultado = calculator.Log(10);

            Assert.AreNotEqual(0, resultado);
        }

        #endregion
    }
}
