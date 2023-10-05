using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int option;

        Console.WriteLine("pilih salah satu konversi dibawah ini: ");
        Console.WriteLine("1 Celcius ke fahrenheit dan  reamur");
        Console.WriteLine("2 Fahrenheit ke celcius dan  reamur");
        Console.WriteLine("3 Reamur ke celcius dan fahrenheit");
        option = (int) inputValue();
        if (option == 1)
        {
            Celciustofahrenheittoreamur();
        }
        if (option == 2)
        {
            Fahrenheittocelciustoreamur();
        }
        if (option == 3)
        {
            Reamurtocelciustofahrenheit();
        }
    }
    
    public static void Celciustofahrenheittoreamur()
    {
        Console.WriteLine("masukkan Celcius dalam  bentuk angka untuk di konversi ke Fahrenheit, dan Reamur");
        int celcius, reamur, fahrenheit;

        celcius = (int) inputValue();
        fahrenheit = (int) ((double) (celcius * 9) / 5 + 32);
        reamur = (int) (celcius * 0.8);
        Console.WriteLine("Hasil dari konversi celcius ke fahrenheit adalah");
        Console.WriteLine(fahrenheit);
        Console.WriteLine("Hasil dari konversi celcius ke reamur adalah");
        Console.WriteLine(reamur);
    }
    
    public static void Fahrenheittocelciustoreamur()
    {
        Console.WriteLine("masukkan fahrenheit dalam  bentuk angka untuk di konversi ke celcius ,dan reamur");
        int celcius, reamur, fahrenheit;

        fahrenheit = (int) inputValue();
        reamur = (int) ((fahrenheit - 32) / 2.25);
        celcius = (int) ((double) 5 / 9 * (fahrenheit - 32));
        Console.WriteLine("Hasil konversi Fahrenheit ke Celcius adalah");
        Console.WriteLine(celcius);
        Console.WriteLine("Hasil konversi dari fahrenheit ke reamur adalah");
        Console.WriteLine(reamur);
    }
    
    public static void Reamurtocelciustofahrenheit()
    {
        Console.WriteLine("masukkan reamur dalam  bentuk angka untuk di konversi ke celcius ,dan fahrenheit");
        int celcius, reamur, fahrenheit;

        reamur = (int) inputValue();
        fahrenheit = (int) ((double) (reamur * 9) / 4 + 32);
        celcius = (int) ((double) (reamur * 5) / 4);
        Console.WriteLine("Hasil konversi Reamur ke Celcius adalah");
        Console.WriteLine(celcius);
        Console.WriteLine("Hasil konversi dari reamur ke fahrenheit adalah");
        Console.WriteLine(fahrenheit);
    }
    
    // .NET can only read single characters or entire lines from the
    // console. The following function safely reads a double value.
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result));
        return result;
    }
}
