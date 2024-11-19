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
using System.Windows.Shapes;

namespace Quan_ly_tai_nguyen_rung_wpf
{
    /// <summary>
    /// Interaction logic for test.xaml
    /// </summary>
    
    public partial class test : Window
    {
        public TextBlock txb_ctrl { get; set; }
        public test()
        {
            InitializeComponent();
            var myCtrl = new ctrl_test();
            myCtrl.txb_main = txb_main;
            main.Content = myCtrl;
        }

        private void btn_main_Click(object sender, RoutedEventArgs e)
        {
            txb_ctrl.Text = ("đã nhận lệnh từ btn_main");
        }
    }
}
