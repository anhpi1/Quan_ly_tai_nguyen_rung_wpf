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
<<<<<<< Updated upstream
           
=======
            var myCtrl = new test1();
            main.Content = myCtrl;
>>>>>>> Stashed changes
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
<<<<<<< Updated upstream
            // Hiển thị noi_dung1 và ẩn noi_dung2
            noi_dung1.Visibility = Visibility.Visible;
            noi_dung2.Visibility = Visibility.Collapsed;
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            // Hiển thị noi_dung2 và ẩn noi_dung1
            noi_dung1.Visibility = Visibility.Collapsed;
            noi_dung2.Visibility = Visibility.Visible;
        }

 
=======
            var myCtrl = new ctrl_dong_vat();
            main.Content = myCtrl;
        }

        private void btn_main1_Click(object sender, RoutedEventArgs e)
        {
            var myCtrl = new test2();
            main.Content = myCtrl;
        }

        //private void btn_main_Click(object sender, RoutedEventArgs e)
        //{
        //    var myCtrl = ctrl_hanh_chinh;
        //    main
        //}
>>>>>>> Stashed changes
    }
}
