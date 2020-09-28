using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

/// @author Aleksi Suuronen
/// @version 28.9.2020
/// <summary>
/// Etsitään yhtälölle x = (e^-x)/2 likiarvoratkaisu neljän desimaalin tarkkuudella missä x on alkuarvaus 0.3 käyttäen kiintopistemenetelmää.
/// Tehtävässä tahdottiin siis tietää, montako iteraatiota tarvitaan, jotta saadaan desimaaliesitys tasaiseksi tietyllä tarkkuudella.
/// 31 iteraatiota alkuarvauksella 0,3.
/// 50 iteraatiota alkuarvauksella 1,0.
/// </summary>
public class Kiintopistemenetelma
{
    /// <summary>
    /// Kutsutaan Laske-funktiota pääohjelmasta. Kysytään syöte ja käsitellään poikkeukset.
    /// </summary>
    public static void Main()
    {
        double alkuarvaus = 0.0;
        Console.WriteLine("Syotä alkuarvaus muodossa, jossa desimaalierottimenia ',' : ");
        string arvaus = Console.ReadLine();
        try
        {
            alkuarvaus = Double.Parse(arvaus);
        } catch (FormatException exception)
        {
            Console.WriteLine("Vääränlainen syöte!" + exception);
        }
        Console.WriteLine("Syötä iteraatioiden määrä kokonaislukuna: ");
        int maara = 0;
        string iteraatiot = Console.ReadLine();
        try
        {
          maara = Int32.Parse(iteraatiot);
        } catch (FormatException exception)
        {
            Console.WriteLine("Vääränlainen syöte!" + exception);
        }
        double lauseke = Math.Pow(Math.E, -alkuarvaus) / 2;
        Laske(lauseke, maara, alkuarvaus);
    }


    /// <summary>
    /// Lauseke laskee iteroiden aina uuden lausekkeen ja sen arvon edellisen pohjalta.
    /// </summary>
    /// <param name="lauseke">Lauseke</param>
    /// <param name="maara">Monta kertaa halutaan iteroida funktiota</param>
    /// <param name="alkuarvaus">Alkuarvaus x0 josta aloitetaan iterointi</param>
    public static void Laske(double lauseke, int maara, double alkuarvaus)
    {
        for (int i = 0; i < maara; i++)
        {
            lauseke = Math.Pow(Math.E, -alkuarvaus) / 2;
            Console.WriteLine(lauseke);
            alkuarvaus = lauseke;
        }
    }
}
