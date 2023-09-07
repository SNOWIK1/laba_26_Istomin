using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FileHelpClass
{
    public static class OpenSaver
    {
        public static string ReadFile()
        {
            string filename = string.Empty;
            var dialog = new Microsoft.Win32.OpenFileDialog();
            dialog.DefaultExt = ".txt"; // Default file extension
            dialog.Filter = "Text documents (.txt)|*.txt"; // Filter files by extension

            // Show open file dialog box
            bool? dialogResult = dialog.ShowDialog();

            // Process open file dialog box results
            if (dialogResult == true)
            {
                // Open document
                 filename = dialog.FileName;
            }
            else
            {
                MessageBox.Show("Выберите текстовый файл", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            string line = string.Empty;
            string result = string.Empty;

            try
            {
                using (StreamReader sr = new StreamReader(filename))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        result = line;
                    }
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           

            return result;
        }

        public static void WriteFile(string txt)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text file (*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == true)
            {
                File.WriteAllText(saveFileDialog.FileName, txt);
            }

        }
    }
}
