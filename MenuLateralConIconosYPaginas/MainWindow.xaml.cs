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

namespace MenuLateralConIconosYPaginas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
        }
        private void botonMenu_Click(object sender, RoutedEventArgs e)
        {
            if (splitView1.IsPaneOpen == true)
                splitView1.IsPaneOpen = false;
            else
                splitView1.IsPaneOpen = true;
        }

        private void boton1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void boton2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void boton3_Click(object sender, RoutedEventArgs e)
        {

        }
    }

    internal class splitView1
    {
        public static bool IsPaneOpen { get; internal set; }
    }
}
