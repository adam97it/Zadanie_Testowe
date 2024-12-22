using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        // Ścieżka do obrazu wejściowego
        string inputPath = @"C:\Users\ardki\source\repos\Obraz_1.2\Obraz_start\in.png.png";
        // Ścieżka do pliku wyjściowego
        string outputPath = @"C:\Users\ardki\source\repos\Obraz_1.2\Wynik\out.png";

        // Wczytanie obrazu 
        Mat image = CvInvoke.Imread(inputPath, ImreadModes.Color);
        if (image.IsEmpty)
        {
            Console.WriteLine("Nie udało się wczytać obrazu. Sprawdź ścieżkę i format pliku.");
            return;
        }

        // Parametry dla czerwonego okręgu
        int thickness = 2;
        Point center = new Point(image.Width / 2, image.Height / 2);
        int radius = Math.Min(image.Width, image.Height) / 5; //  Zwiększenie średnicy
        MCvScalar redColor = new MCvScalar(0, 0, 255); // Kolor czerwony w przestrzeni BGR
        CvInvoke.Circle(image, center, radius, redColor, thickness);

        // Zapisanie obrazu z okręgiem
        CvInvoke.Imwrite(outputPath, image);

        Console.WriteLine("Obraz z czerwonym okręgiem został zapisany do: " + outputPath);
    }
}
