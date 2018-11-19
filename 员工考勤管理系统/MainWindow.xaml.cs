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

namespace 员工考勤管理系统
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Myframe.NavigationService.Navigate(new Uri("Pagess/Page_Home.xaml",UriKind.Relative));
        }

        private void Homepage_Button_Click(object sender, RoutedEventArgs e)
        {
            Myframe.NavigationService.Navigate(new Uri("Pagess/Page_Home.xaml", UriKind.Relative));
        }

        private void YuangongGL_Button_Click(object sender, RoutedEventArgs e)
        {
            Myframe.NavigationService.Navigate(new Uri("Pagess/Page_GL.xaml", UriKind.Relative));

        }

        private void Qingjia_Button_Click(object sender, RoutedEventArgs e)
        {
            Myframe.NavigationService.Navigate(new Uri("Pagess/Page_QJ.xaml", UriKind.Relative));
        }

        private void XTGL_Button_Click(object sender, RoutedEventArgs e)
        {
            Myframe.NavigationService.Navigate(new Uri("Pagess/Page_XTGL.xaml", UriKind.Relative));
        }
    }
}
