using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Principal;
using System.IO;

namespace DayZ_Object_Mover_CLI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputFilePath;
            string outputFilePath;
            string[] lines;
            double numX;
            double numY;

        Start:
            Console.Clear();
            Console.Write("Enter the file path (or drag-and-drop the file): ");
            inputFilePath = Console.ReadLine();
            if (string.IsNullOrEmpty(inputFilePath))
            {
                goto Start;
            }
            inputFilePath = inputFilePath.Replace("\"", null);
            Console.Write("Enter a number that should to be added to X: ");
            double.TryParse(Console.ReadLine().Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out numX);
            Console.Write("Enter a number that should to be added to Y: ");
            double.TryParse(Console.ReadLine().Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out numY);
            Console.Write("Enter the output file path: ");
            outputFilePath = Console.ReadLine();
            if (string.IsNullOrEmpty(outputFilePath))
            {
                outputFilePath = inputFilePath.Replace(".txt", "_output.txt");
            }
            lines = File.ReadAllLines(inputFilePath, Encoding.UTF8);
            Console.CursorVisible = false;
            for (int i = 0; i < lines.Length; i++)
            {
                double thisLine = (i + 1);
                double ratioLines = thisLine / lines.Length;
                string percentLines = (ratioLines * 100).ToString("N0") + "%";
                /*Console.WriteLine("In process: " + percentLines);
                ClearLastLine(-1);*/
                Console.Title = "In process: " + percentLines;
                /*Console.WriteLine((i + 1).ToString() + ") " + lines[i]);*/

                string[] coordinates = lines[i].Split(';');
                double cDoubleX = double.Parse(coordinates[1], NumberStyles.Any, CultureInfo.InvariantCulture);
                double cDoubleY = double.Parse(coordinates[2], NumberStyles.Any, CultureInfo.InvariantCulture);
                cDoubleX += numX;
                cDoubleY += numY;
                coordinates[1] = cDoubleX.ToString().Replace(',', '.');
                coordinates[2] = cDoubleY.ToString().Replace(',', '.');
                lines[i] = String.Join(";", coordinates);
            }
            Console.CursorVisible = true;
            File.WriteAllLines(outputFilePath, lines, Encoding.UTF8);
            ClearLastLine(0);
            Console.Write("Done!");
            Console.Title = "Done!";
            Console.ReadKey();
        }

        static void ClearLastLine(int curPosTop)
        {
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.BufferWidth));
            Console.SetCursorPosition(0, Console.CursorTop + curPosTop);
        }
    }
}
