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

namespace Quan_ly_tai_nguyen_rung_wpf
{
    /// <summary>
    /// Interaction logic for ctrl_test.xaml
    /// </summary>
   
    public partial class ctrl_test : UserControl
    {
        public TextBlock txb_main { get; set; }
        
        
        public ctrl_test()
        {
            InitializeComponent();
           
        }

        private void btn_ctrl_Click(object sender, RoutedEventArgs e)
        {
            txb_main.Text = "đã nhận được lệnh từ btn_ctrl";
        }
    }
}
