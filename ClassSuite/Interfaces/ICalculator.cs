using System.Collections.Generic;

namespace ClassSuite
{
    public interface ICalculator
    {
        double Soma(double value1, double value2);

        double Soma(ICollection<double> values);

        double Multiplicacao(double value1, double value2);

        double Multiplicacao(ICollection<double> values);

        double Subtracao(double value1, double value2);

        double Subtracao(double valueReference, ICollection<double> values);

        double Divisao(double value1, double value2);

        double Divisao(double valueReference, ICollection<double> values);
    }
}
