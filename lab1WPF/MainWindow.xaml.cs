using System;
using System.Windows;
using System.Windows.Media;

namespace lab1WPF
{
    public partial class MainWindow : Window
    {
        private int[,] matrix = new int[4, 4];

        public MainWindow()
        {
            InitializeComponent();
            DisplayMatrix();
        }

        private void DisplayMatrix()
        {
            MatrixList.Items.Clear();
            FillTheMatrix(matrix);
            for (int i = 0; i < 4; i++)
            {
                string row = "";
                for (int j = 0; j < 4; j++)
                {
                    row += matrix[i, j].ToString() + " ";
                }
                MatrixList.Items.Add(row);
            }
        }

        private void FillTheMatrix(int[,] matrix)
        {
            Random random = new Random(); // Create Random object once
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matrix[i, j] = random.Next(1, 101); // Generate random number between 1 and 100 (or adjust range as needed)
                }
            }
        }

        private void FindMaxElement_Click(object sender, RoutedEventArgs e)
        {
            int maxElement = matrix[0, 0];
            for (int i = 1; i < 4; i++)
            {
                if (matrix[i, i] > maxElement)
                    maxElement = matrix[i, i];
            }
            MaxElementText.Text = maxElement.ToString();
        }
    }
}
