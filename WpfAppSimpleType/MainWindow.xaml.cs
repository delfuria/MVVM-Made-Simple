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

namespace WpfAppSimpleType
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnNoBinding_Click(object sender, RoutedEventArgs e)
        {
            WinNoBinding win = new WinNoBinding();

            win.Show();
        }


        //private void btnBasicBinding_Click(object sender, RoutedEventArgs e)
        //{
        //    winBasicDataBinding win = new winBasicDataBinding();

        //    win.Show();
        //}

        //private void btnOtherBinding_Click(object sender, RoutedEventArgs e)
        //{
        //    winMoreDataBinding win = new winMoreDataBinding();

        //    win.Show();
        //}

        //private void btnSimpleMVVM_Click(object sender, RoutedEventArgs e)
        //{
        //    winSimpleMVVM win = new winSimpleMVVM();

        //    win.Show();
        //}
    }
}
