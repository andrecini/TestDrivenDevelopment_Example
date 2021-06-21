using System.Collections.Generic;

namespace ClassSuite
{
    /// <summary>
    /// Classe Calculadora com métodos de: Soma, Subtração, Multiplicação e Divisão.
    /// </summary>
    public class BasicCalculator : ICalculator
    {
        /// <summary>
        /// Soma os dois valores específicados.
        /// </summary>
        /// <param name="value1">Valor 1</param>
        /// <param name="value2">Valor 2</param>
        /// <returns>Valor 1 + Valor 2</returns>
        public double Soma(double value1, double value2)
        {
            return value1 + value2;
        }

        /// <summary>
        /// Soma todos os números da coleção específicada
        /// </summary>
        /// <param name="values">Coleção de double</param>
        /// <returns>values[0] + values[1] + values[2] + ...</returns>
        public double Soma(ICollection<double> values)
        {
            double resultado = 0;

            foreach (var v in values)
            {
                resultado += v;
            }

            return resultado;
        }

        /// <summary>
        /// Multiplica os dois valores específicados.
        /// </summary>
        /// <param name="value1">Valor 1</param>
        /// <param name="value2">Valor 2</param>
        /// <returns>Valor 1 - Valor 2</returns>
        public double Multiplicacao(double value1, double value2)
        {
            return value1 * value2;
        }

        /// <summary>
        /// Multiplica todos os números da coleção específicada
        /// </summary>
        /// <param name="values">Coleção de Double</param>
        /// <returns>values[0] * values[1] * values[2] * ...</returns>
        public double Multiplicacao(ICollection<double> values)
        {
            double resultado = 1;

            foreach (var v in values)
            {
                resultado *= v;
            }

            return resultado;
        }

        /// <summary>
        /// Subtrai o Valor 1 pelo Valor 2.
        /// </summary>
        /// <param name="value1">Valor 1</param>
        /// <param name="value2">Valor 2</param>
        /// <returns>Valor 1 - Valor 2</returns>
        public double Subtracao(double value1, double value2)
        {
            return value1 - value2;
        }

        /// <summary>
        /// Subtrai o Valor de Referência pelos valores da Coleção específicada.
        /// </summary>
        /// <param name="valueReference">Valor de Referência</param>
        /// <param name="values">Coleção de Double</param>
        /// <returns>Valor de Referência - values[0] - values[1] / ...</returns>
        public double Subtracao(double valueReference, ICollection<double> values)
        {
            foreach (var v in values)
            {
                valueReference -= v;
            }

            return valueReference;
        }

        /// <summary>
        /// Divide o Valor 1 pelo Valor 2.
        /// </summary>
        /// <param name="value1">Valor 1</param>
        /// <param name="value2">Valor 2</param>
        /// <returns>Valor 1 / Valor 2</returns>
        public double Divisao(double value1, double value2)
        {
            return value1 / value2;
        }

        /// <summary>
        /// Divide o Valor de Referência pelos valores da Coleção específicada.
        /// </summary>
        /// <param name="valueReference">Valor de Referência</param>
        /// <param name="values">Coleção de Double</param>
        /// <returns>Valor de Referência / values[0] / values[1] / ...</returns>
        public double Divisao(double valueReference, ICollection<double> values)
        {
            foreach (var v in values)
            {
                valueReference /= v;
            }

            return valueReference;
        }
    }
}
