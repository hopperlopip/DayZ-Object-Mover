using System.Globalization;
using System.Security.Principal;
using System.Text;

string? inputFilePath;
string? outputFilePath;
string[] lines;
double numX;
double numY;
/*int allLines;
double oneLine;*/

Start:
Console.Clear();
Console.Write("Enter the file path: ");
inputFilePath = Console.ReadLine();
if (string.IsNullOrEmpty(inputFilePath))
{
    goto Start;
}
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
/*allLines = lines.Length;
oneLine = allLines / 100;*/
for (int i = 0; i < lines.Length; i++)
{
    string[] coordinates = lines[i].Split(';');
    double cDoubleX = double.Parse(coordinates[1], NumberStyles.Any, CultureInfo.InvariantCulture);
    double cDoubleY = double.Parse(coordinates[2], NumberStyles.Any, CultureInfo.InvariantCulture);
    cDoubleX += numX;
    cDoubleY += numY;
    coordinates[1] = cDoubleX.ToString().Replace(',', '.');
    coordinates[2] = cDoubleY.ToString().Replace(',', '.');
    lines[i] = String.Join(';', coordinates);
    Console.WriteLine((i + 1).ToString() + ") " + lines[i]);
    /*Console.WriteLine((oneLine * (i + 1)) + "%");*/
}
File.WriteAllLines(outputFilePath, lines, Encoding.UTF8);
Console.Write("Done!");
Console.ReadKey();
