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
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static MaterialDesignThemes.Wpf.Theme;

namespace Quan_ly_tai_nguyen_rung_wpf
{
    /// <summary>
    /// Interaction logic for man_hinh_menu.xaml
    /// </summary>
    public partial class man_hinh_menu : Window
    {
        public man_hinh_menu()
        {
            InitializeComponent();
        }

        public void enter(string den, string trang) 
        {

            Border button1 = this.FindName(den) as Border;
            Border button1_trang = this.FindName(trang) as Border;
            // Tạo DropShadowEffect màu đen
            var shadowEffect_black = new DropShadowEffect
            {
                Color = Colors.Black,
                Direction = -45,
                ShadowDepth = 6,
                BlurRadius = 10,
                Opacity = 0.2 // Bắt đầu với opacity nhỏ
            };

            button1.Effect = shadowEffect_black;

            // Tạo animation tăng dần opacity
            var opacityAnimation_black = new DoubleAnimation
            {
                From = 0.2,
                To = 0, // Độ trong suốt tối đa
                Duration = TimeSpan.FromSeconds(0.1),
                EasingFunction = new QuadraticEase()
            };
            shadowEffect_black.BeginAnimation(DropShadowEffect.OpacityProperty, opacityAnimation_black);

            // Tạo DropShadowEffect màu trắng
            var shadowEffect_white = new DropShadowEffect
            {
                Color = Colors.White,
                Direction = 135,
                ShadowDepth = 6,
                BlurRadius = 10,
                Opacity = 0.8 // Bắt đầu với opacity nhỏ
            };

            button1_trang.Effect = shadowEffect_white;

            // Tạo animation tăng dần opacity
            var opacityAnimation_white = new DoubleAnimation
            {
                From = 0.8,
                To = 0, // Độ trong suốt tối đa
                Duration = TimeSpan.FromSeconds(0.1),
                EasingFunction = new QuadraticEase()
            };
            shadowEffect_white.BeginAnimation(DropShadowEffect.OpacityProperty, opacityAnimation_white);

            var thicknessAnimation = new ThicknessAnimation
            {
                To = new Thickness(1),
                Duration = TimeSpan.FromSeconds(0.1), // Thời gian chuyển đổi
                EasingFunction = new QuadraticEase() // Hiệu ứng chuyển động mượt
            };
            button1.BeginAnimation(BorderThicknessProperty, thicknessAnimation);

            // Tạo hiệu ứng thay đổi BorderBrush
            var colorAnimation = new ColorAnimation
            {
                To = Color.FromArgb(0xFF, 0xB4, 0xB4, 0xB4),
                Duration = TimeSpan.FromSeconds(0.1)
            };
            var brush = new SolidColorBrush();
            brush.BeginAnimation(SolidColorBrush.ColorProperty, colorAnimation);
            button1.BorderBrush = brush;
        }
        public void leave(string den, string trang)
        {

            Border button1 = this.FindName(den) as Border;
            Border button1_trang = this.FindName(trang) as Border;
            if (button1.Effect is DropShadowEffect shadowEffect_black)
            {
                // Tạo animation giảm dần opacity
                var opacityAnimation_black = new DoubleAnimation
                {
                    From = shadowEffect_black.Opacity,
                    To = 0.2, // Mất bóng dần
                    Duration = TimeSpan.FromSeconds(0.1),
                    EasingFunction = new QuadraticEase()
                };

                // Bắt đầu animation
                shadowEffect_black.BeginAnimation(DropShadowEffect.OpacityProperty, opacityAnimation_black);

                // Xóa hiệu ứng sau khi animation kết thúc
                opacityAnimation_black.Completed += (s, a) => button1.Effect = null;
            }
            if (button1_trang.Effect is DropShadowEffect shadowEffect_white)
            {
                // Tạo animation giảm dần opacity
                var opacityAnimation_white = new DoubleAnimation
                {
                    From = shadowEffect_white.Opacity,
                    To = 0.8, // Mất bóng dần
                    Duration = TimeSpan.FromSeconds(0.1),
                    EasingFunction = new QuadraticEase()
                };

                // Bắt đầu animation
                shadowEffect_white.BeginAnimation(DropShadowEffect.OpacityProperty, opacityAnimation_white);

                // Xóa hiệu ứng sau khi animation kết thúc
                opacityAnimation_white.Completed += (s, a) => button1_trang.Effect = null;

            }
            // Tạo hiệu ứng chuyển đổi BorderThickness về 0
            var thicknessAnimation = new ThicknessAnimation
            {
                To = new Thickness(0),
                Duration = TimeSpan.FromSeconds(0.1),
                EasingFunction = new QuadraticEase()
            };
            button1.BeginAnimation(BorderThicknessProperty, thicknessAnimation);

            // Loại bỏ BorderBrush bằng hiệu ứng
            var colorAnimation = new ColorAnimation
            {
                To = Colors.Transparent,
                Duration = TimeSpan.FromSeconds(0.1)
            };
            var brush = new SolidColorBrush(Color.FromArgb(0xFF, 0xB4, 0xB4, 0xB4)); // Giá trị khởi tạo
            brush.BeginAnimation(SolidColorBrush.ColorProperty, colorAnimation);
            button1.BorderBrush = brush;
        }


        private void doi_anh(string anh_cu, string anh_moi)
        {
            // Lấy đối tượng Image từ giao diện WPF (giả sử bạn đã khai báo Image có tên là "imageControl" trong XAML)
            Image imageControl = this.FindName(anh_cu) as Image;

            if (imageControl != null)
            {
                // Tạo ImageBrush cho hình ảnh mới (ảnh pha trộn)
                var imageBrush = new ImageBrush
                {
                    ImageSource = new BitmapImage(new Uri(anh_moi, UriKind.Relative)),
                    Stretch = Stretch.UniformToFill
                };

                // Tạo một GradientBrush (pha trộn) từ ảnh cũ đến ảnh mới
                var blendMask = new LinearGradientBrush
                {
                    StartPoint = new System.Windows.Point(0, 0),
                    EndPoint = new System.Windows.Point(1, 0)
                };

                // Gradient bắt đầu từ ảnh cũ (hoàn toàn đen) đến ảnh mới (hoàn toàn trắng)
                blendMask.GradientStops.Add(new GradientStop(Colors.Black, 0));   // Ảnh cũ hoàn toàn đen
                blendMask.GradientStops.Add(new GradientStop(Colors.White, 1));   // Ảnh mới hoàn toàn trắng

                // Áp dụng GradientMask cho ảnh, tạo hiệu ứng pha trộn
                imageControl.OpacityMask = blendMask;

                // Thay đổi nguồn hình ảnh sau khi pha trộn
                imageControl.Source = new BitmapImage(new Uri(anh_moi, UriKind.Relative));
            }
        }
        private void home_enter(object sender, MouseEventArgs e)
        {
            enter("home_den", "home_trang");
            doi_anh("home_png", "png/home_2.png");
        }

        private void home_leave(object sender, MouseEventArgs e)
        {
            leave("home_den", "home_trang");
            doi_anh("home_png", "png/home_1.png");
        }

        private void home_down(object sender, MouseButtonEventArgs e)
        {
            var myctrl = new ctrl_dang_ki_thanh_cong();
            noi_dung.Content = myctrl;
            doi_anh("home_png", "png/home_3.png");
        }
        private void hanh_chinh_enter(object sender, MouseEventArgs e)
        {
            enter("hanh_chinh_den", "hanh_chinh_trang");
            doi_anh("hanh_chinh_png", "png/hanh_chinh_2.png");
        }

        private void hanh_chinh_leave(object sender, MouseEventArgs e)
        {
            leave("hanh_chinh_den", "hanh_chinh_trang");
            doi_anh("hanh_chinh_png", "png/hanh_chinh_1.png");
        }

        private void hanh_chinh_down(object sender, MouseButtonEventArgs e)
        {
            var myctrl = new ctrl_dang_ki_thanh_cong();
            noi_dung.Content = myctrl;
            doi_anh("hanh_chinh_png", "png/hanh_chinh_3.png");
        }
        private void hat_cay_enter(object sender, MouseEventArgs e)
        {
            enter("hat_cay_den", "hat_cay_trang");
            doi_anh("hat_cay_png", "png/hat_cay_2.png");
        }

        private void hat_cay_leave(object sender, MouseEventArgs e)
        {
            leave("hat_cay_den", "hat_cay_trang");
            doi_anh("hat_cay_png", "png/hat_cay_1.png");
        }

        private void hat_cay_down(object sender, MouseButtonEventArgs e)
        {
            var myctrl = new ctrl_dang_ki_thanh_cong();
            noi_dung.Content = myctrl;
            doi_anh("hat_cay_png", "png/hat_cay_3.png");
        }
        private void go_enter(object sender, MouseEventArgs e)
        {
            enter("go_den", "go_trang");
            doi_anh("go_png", "png/go_2.png");
        }

        private void go_leave(object sender, MouseEventArgs e)
        {
            leave("go_den", "go_trang");
            doi_anh("go_png", "png/go_1.png");
        }

        private void go_down(object sender, MouseButtonEventArgs e)
        {
            var myctrl = new ctrl_dang_ki_thanh_cong();
            noi_dung.Content = myctrl;
            doi_anh("go_png", "png/go_3.png");
        }
        private void dong_vat_enter(object sender, MouseEventArgs e)
        {
            enter("dong_vat_den", "dong_vat_trang");
            doi_anh("dong_vat_png", "png/dong_vat_2.png");
        }

        private void dong_vat_leave(object sender, MouseEventArgs e)
        {
            leave("dong_vat_den", "dong_vat_trang");
            doi_anh("dong_vat_png", "png/dong_vat_1.png");
        }

        private void dong_vat_down(object sender, MouseButtonEventArgs e)
        {
            var myctrl = new ctrl_dang_ki_thanh_cong();
            noi_dung.Content = myctrl;
            doi_anh("dong_vat_png", "png/dong_vat_3.png");
        }
        private void ban_do_enter(object sender, MouseEventArgs e)
        {
            enter("ban_do_den", "ban_do_trang");
            doi_anh("ban_do_png", "png/ban_do_2.png");
        }

        private void ban_do_leave(object sender, MouseEventArgs e)
        {
            leave("ban_do_den", "ban_do_trang");
            doi_anh("ban_do_png", "png/ban_do_1.png");
        }

        private void ban_do_down(object sender, MouseButtonEventArgs e)
        {
            var myctrl = new ctrl_dang_ki_thanh_cong();
            noi_dung.Content = myctrl;
            doi_anh("ban_do_png", "png/ban_do_3.png");
        }
        private void he_thong_enter(object sender, MouseEventArgs e)
        {
            enter("he_thong_den", "he_thong_trang");
            doi_anh("he_thong_png", "png/he_thong_2.png");
        }

        private void he_thong_leave(object sender, MouseEventArgs e)
        {
            leave("he_thong_den", "he_thong_trang");
            doi_anh("he_thong_png", "png/he_thong_1.png");
        }

        private void he_thong_down(object sender, MouseButtonEventArgs e)
        {
            var myctrl = new ctrl_dang_ki_thanh_cong();
            noi_dung.Content = myctrl;
            doi_anh("he_thong_png", "png/he_thong_3.png");
        }

    }
}
