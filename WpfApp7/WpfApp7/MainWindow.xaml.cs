using Microsoft.Win32;
using System;
using System.Collections.Generic;
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

namespace WpfApp7
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddB_Click(object sender, RoutedEventArgs e)
        {
            RegistryKey currentUserKey = Registry.CurrentUser;
            RegistryKey testKey = currentUserKey.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
            testKey.SetValue(Convert.ToString( Input1), Convert.ToString(Input2));
            TextOut.Text += $"{Input1} - {Input2}\n";
        }
    }
}
