using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;
using static MaterialDesignThemes.Wpf.Theme;

namespace Quan_ly_tai_nguyen_rung_wpf
{
    /// <summary>
    /// Interaction logic for man_hinh_dang_nhap.xaml
    /// </summary>
    public partial class man_hinh_dang_nhap : Window
    {
        public man_hinh_dang_nhap()
        {
            InitializeComponent();
            var myControl = new ctrl_dang_nhap();
            myControl.UserControlContainer = UserControlContainer;
            UserControlContainer.Content = myControl;
        }


    }
}
