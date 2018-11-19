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
using System.Windows.Threading;

namespace 员工考勤管理系统.Pagess
{
    /// <summary>
    /// Page_Home.xaml 的交互逻辑
    /// </summary>
    /// 
    public partial class Page_Home : Page
    {
        private DispatcherTimer ShowTimer;
        public Page_Home()
        {
            InitializeComponent();
            ShowTimer = new System.Windows.Threading.DispatcherTimer();
            ShowTimer.Tick += new EventHandler(get_NOWTIME);
            ShowTimer.Interval = new TimeSpan(0, 0, 0, 1, 0);
            ShowTimer.Start();
            get_Nowtime();
        }

        private void get_NOWTIME(object sender, EventArgs e)
        {
            get_Nowtime();
        }

        public void get_Nowtime()
        {
           NowTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
