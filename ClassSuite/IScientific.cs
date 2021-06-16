using System.Collections.Generic;

namespace ClassSuite
{
    public interface IScientific
    {
        double Potencia(double baseValue, int exponentValue);

        double Raiz(double rootingValue, int indexValue);

        double Media(double value1, double value2);

        double Media(ICollection<double> values);

        double RegraX(double knownValue, double knownResult, double unknownValue);

        double Fatorar(int value);

        double Log(int logarithmValue, int baseValue);

        double Log(int logarithmValue);
    }
}
