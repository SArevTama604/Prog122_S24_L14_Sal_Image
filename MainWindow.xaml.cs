using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using Microsoft.Win32;

namespace Prog_122_S24_L14_Sal
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            cmbStyles.ItemsSource = Enum.GetValues(typeof(STYLE));

            Art nighthawks = new Art("Nighthawks", STYLE.Impressionism);
            runDisplay.Text = nighthawks.ToString();
        }

        private BitmapImage LoadImage(string filePath)
        {
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(filePath);
            bitmap.EndInit();
            return bitmap;
        }

        private void SelectImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg";

            if (openFileDialog.ShowDialog() == true)
            {
                string selectedFilePath = openFileDialog.FileName;
                imgDisplay.Source = LoadImage(selectedFilePath);
            }
        }
    }
}
