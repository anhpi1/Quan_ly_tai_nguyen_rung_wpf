using System.Reflection.PortableExecutable;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using MySql.Data.MySqlClient;

namespace Quan_ly_tai_nguyen_rung_wpf
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
        private void Button_OpenManhinh_Click(object sender, RoutedEventArgs e)
        {
            // Tạo đối tượng Manhinh và mở cửa sổ mới
            man_hinh_dang_nhap manhinhWindow = new man_hinh_dang_nhap();
            manhinhWindow.Show();  // Hiển thị cửa sổ Manhinh
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            man_hinh_menu main = new man_hinh_menu();
            main.Show();
        }
    }

}
