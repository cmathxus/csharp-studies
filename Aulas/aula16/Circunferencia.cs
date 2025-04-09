using System.Globalization;

namespace aula16;

public class Circunferencia
{
    private double raio;

    public double calculoCircunferencia() {
        double resultadoCircunferencia = 2 * Math.PI * raio;
        return resultadoCircunferencia;
    }
    
    public double calculoVolume() {
        double resultadoVolume = (4.0 / 3.0) * Math.PI * Math.Pow(raio, 3);
        return resultadoVolume;
    }

    public override string ToString()
    {
        return "Circunferencia: "
        + calculoCircunferencia().ToString("F2", CultureInfo.InvariantCulture)
        + " Volume: "
        + calculoVolume().ToString("F2", CultureInfo.InvariantCulture)
        + " Valor de PI: "
        + Math.PI.ToString("F2", CultureInfo.InvariantCulture);
    }


    public double Raio
    {
        get => raio;
        set
        {
          raio = value;
        }
    }
}
