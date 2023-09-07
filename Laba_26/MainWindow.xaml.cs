using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using FileHelpClass;

namespace Laba_26
{
    /// <summary>
    /// Логика Истомин для DimaWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ActivateSearchTextBox(object sender, RoutedEventArgs e)
        {
             (sender as FrameworkElement).Style = (Style)Resources["txt_box_dima"];              
        }

        private void DisactivateSearchTextBox(object sender, RoutedEventArgs e)
        {
             (sender as FrameworkElement).Style = (Style)Resources["txt_box_istomin"];
        }

        private void OpenFile(object sender, RoutedEventArgs e)
        {
            editor.Text = OpenSaver.ReadFile();
        }

        private void SaveFileAs(object sender, RoutedEventArgs e)
        {
            OpenSaver.WriteFile(editor.Text);
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
