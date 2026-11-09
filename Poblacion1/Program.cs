namespace Poblacion1
{
  internal class Program
  {
    static void Main(string[] args)
    {
      int i = 0;
      int edad = 0;
      int[] listaEdades = new int[100];

      listaEdades[0] = 10;
      listaEdades[1] = 38;
      listaEdades[2] = 0;
      listaEdades[3] = 6;
      listaEdades[4] = 15;
      listaEdades[5] = 25;
      listaEdades[6] = 80;
      listaEdades[7] = 16;
      listaEdades[8] = 43;

      int cuentaNinios = 0;
      int cuentaAdoles = 0;
      int cuentaAdultos = 0;
      int cuentaMaduros = 0;
      int cuentaAncianos = 0;
      int totalPoblacion = 0;

      float porcNinios = 0.0f;
      float porcAdoles = 0.0f;
      float porcAdultos = 0.0f;
      float porcMaduros = 0.0f;
      float porcAncianos = 0.0f;

      for (i = 0; i < 9; i++)
      {
        edad = listaEdades[i];
        if (edad >= 0 && edad <= 12)
        {
          cuentaNinios++;
        }
        if (edad >= 13 && edad <= 17)
        {
          cuentaAdoles++;
        }
        if (edad >= 18 && edad <= 39)
        {
          cuentaAdultos++;
        }
        if (edad >= 40 && edad <= 60)
        {
          cuentaMaduros++;
        }
        if (edad >= 61 && edad <= 120)
        {
          cuentaAncianos++;
        }
      }

      totalPoblacion = 9;
      porcNinios = (float)cuentaNinios / totalPoblacion * 100;
      porcAdoles = (float)cuentaAdoles / totalPoblacion * 100;
      porcAdultos = (float)cuentaAdultos / totalPoblacion * 100;
      porcMaduros = (float)cuentaMaduros / totalPoblacion * 100;
      porcAncianos = (float)cuentaAncianos / totalPoblacion * 100;

      Console.WriteLine(string.Format("{0:0.00}", porcNinios) + "% Niños");
      Console.WriteLine(string.Format("{0:0.00}", porcAdoles) + "% Adolescentes");
      Console.WriteLine(string.Format("{0:0.00}", porcAdultos) + "% Adultos Jóvenes");
      Console.WriteLine(string.Format("{0:0.00}", porcMaduros) + "% Maduros");
      Console.WriteLine(string.Format("{0:0.00}", porcAncianos) + "% Ancianos");

    }
  }
}
