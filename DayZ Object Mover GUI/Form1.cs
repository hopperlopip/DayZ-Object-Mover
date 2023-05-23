using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DayZ_Object_Mover_GUI
{
    public partial class Form1 : Form
    {
        string inputFilePath;
        string outputFilePath;
        string[] lines;
        double numX;
        double numY;
        string condition = "start";

        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            inputFilePath = textBox1.Text;
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            inputFilePath = openFileDialog1.FileName;
            textBox1.Text = inputFilePath;
        }

        private void textBox_X_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(textBox_X.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out numX);
        }

        private void textBox_Y_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(textBox_Y.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out numY);
        }

        private void StartAndSaveButton_Click(object sender, EventArgs e)
        {
            if (condition == "start")
            {
                if (string.IsNullOrEmpty(inputFilePath))
                {
                    MessageBox.Show("No file selected");
                    return;
                }
                inputFilePath = inputFilePath.Replace("\"", null);
                try
                {
                    lines = File.ReadAllLines(inputFilePath, Encoding.UTF8);
                }
                catch (System.IO.FileNotFoundException)
                {
                    MessageBox.Show("Please type the correct path");
                    return;
                }
                for (int i = 0; i < lines.Length; i++)
                {
                    double thisLine = (i + 1);
                    double ratioLines = thisLine / lines.Length;
                    int percentLines = int.Parse((ratioLines * 100).ToString("N0"));
                    progressBar1.Value = percentLines;

                    string[] coordinates = lines[i].Split(';');
                    double cDoubleX = double.Parse(coordinates[1], NumberStyles.Any, CultureInfo.InvariantCulture);
                    double cDoubleY = double.Parse(coordinates[2], NumberStyles.Any, CultureInfo.InvariantCulture);
                    cDoubleX += numX;
                    cDoubleY += numY;
                    coordinates[1] = cDoubleX.ToString().Replace(',', '.');
                    coordinates[2] = cDoubleY.ToString().Replace(',', '.');
                    lines[i] = String.Join(";", coordinates);
                }
                condition = "save";
                StartAndSaveButton.Text = "Save";
            }
            else
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }
                outputFilePath = saveFileDialog1.FileName;
                File.WriteAllLines(outputFilePath, lines, Encoding.UTF8);
                condition = "start";
                StartAndSaveButton.Text = "Start";
            }
        }
    }
}
