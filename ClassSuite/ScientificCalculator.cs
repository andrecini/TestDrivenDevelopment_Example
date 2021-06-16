using System;
using System.Collections.Generic;

namespace ClassSuite
{
    /// <summary>
    /// Classe com todos os métodos da Calculadora Básica, além dos métodos:
    /// Fatorar, Log, Média, Potência, Raiz e Regra do X.
    /// </summary>
    public class ScientificCalculator : BasicCalculator, IScientific
    {
        /// <summary>
        /// Fatora o Valor específicado
        /// </summary>
        /// <param name="value">Valor</param>
        /// <returns>Valor!</returns>
        public double Fatorar(int value)
        {
            double resultado = 1;

            for (int i = 1; i <= value; i++)
            {
                resultado *= i;
            }

            return resultado;
        }

        /// <summary>
        /// Calcula o Valor do Logarítmo a partir do Logarítmando e
        /// da base específicada.
        /// </summary>
        /// <param name="logarithmValue">Logarítmando</param>
        /// <param name="baseValue">Base</param>
        /// <returns>
        ///   Log(Logarítmando)
        ///   (base)
        /// </returns>
        public double Log(int logarithmValue, int baseValue)
        {
            return Math.Log(logarithmValue, baseValue);
        }

        /// <summary>
        /// Calcula o valor do Logarítmo na base 10 a partir do Logaritmando passado por parâmetro.
        /// </summary>
        /// <param name="logarithmValue">Logaritmando</param>
        /// <returns>
        /// Log(Logaritmando)
        ///   (10)
        /// </returns>
        public double Log(int logarithmValue)
        {
            return Math.Log10(logarithmValue);
        }

        /// <summary>
        /// Calcula a média dos dois valores específicados
        /// </summary>
        /// <param name="value1">Valor 1</param>
        /// <param name="value2">Valor 2</param>
        /// <returns> (Valor 1 + Valor 2) / 2</returns>
        public double Media(double value1, double value2)
        {
            return Divisao(Soma(value1, value2), 2);
        }

        /// <summary>
        /// Calcula a média dos valores  da Coleção específicada
        /// </summary>
        /// <param name="values">Coleção de Double</param>
        /// <returns> (Valor[0] + Valor[1] + ... + Valor[n]) / n</returns>
        public double Media(ICollection<double> values)
        {
            return Divisao(Soma(values), values.Count);
        }

        /// <summary>
        /// Calcula a Potência a partir da Base e do Expoente paasados por parâmetro.
        /// </summary>
        /// <param name="baseValue">Base</param>
        /// <param name="exponentValue">Expoente</param>
        /// <returns>Base ^ Expoente</returns>
        public double Potencia(double baseValue, int exponentValue)
        {
            return Math.Pow(baseValue, exponentValue);
        }

        /// <summary>
        /// Calcula a Raiz a partir do Radicando e do Índice passados por parâmetro
        /// </summary>
        /// <param name="rootingValue">Radicando</param>
        /// <param name="indexValue">Índice</param>
        /// <returns>(Índice)√(Radicando)</returns>
        public double Raiz(double rootingValue, int indexValue)
        {
            return Math.Pow(rootingValue, 1.00/indexValue);
        }

        /// <summary>
        /// Acha um valor a partir da Regra do X.
        /// </summary>
        /// <param name="knownValue">Valor Conhecido</param>
        /// <param name="knownResult">Resultado Conhecido</param>
        /// <param name="unknownValue">Valor Sem o Resultado</param>
        /// <returns>
        /// Valor Conhecido = Resultado Conhecido
        /// Valor Sem o Resultado = x
        /// 
        /// x = (Valor Sem o Resultado * Resultado Conhecido) / Valor Conhecido
        /// </returns>
        public double RegraX(double knownValue, double knownResult, double unknownValue)
        {
            return (unknownValue * knownResult) / knownValue;
        }
    }
}
