using System;
using System.Windows;
using brush = System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Drawing;
using System.IO;
using forms = System.Windows.Forms;//для исключения конфликтов имен
using System.Windows.Controls;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace testA
{
    /// <summary>
    /// Логика взаимодействия для watermark_Text.xaml
    /// </summary>
    public partial class watermark_Text : Window
    {
        string image_address = String.Empty;
        Bitmap BT;
        Color Selected_Color;

        public watermark_Text()
        {
            InitializeComponent();
        }

        private void btn_AddImage_Click(object sender, RoutedEventArgs e)
        {
            forms.OpenFileDialog opn = new forms.OpenFileDialog();

            if (opn.ShowDialog() == forms.DialogResult.OK)
            {
                image_address = opn.FileName;
            }

            img_Image.Source = new BitmapImage(new Uri(image_address));
            img_Image.Visibility = Visibility.Visible;
        }

        private void btn_Impose_Click(object sender, RoutedEventArgs e)
        {
            BT = new Bitmap(image_address);
            Graphics original_Image = Graphics.FromImage(BT);

            StringFormat strFormatter = new StringFormat();

            SolidBrush transBrush = new SolidBrush(Color.FromArgb(Convert.ToByte(txb_Opacity.Text),Selected_Color.R, Selected_Color.G, Selected_Color.B));

            for(int i = -200;i< BT.Height;i+=200)
            {
                for(int j = -200;j<BT.Width;j+=200)
                {
                    if (i == j)
                    {
                        DrawDigonalString(original_Image, txb_Watermark.Text, new Font(txb_Name.Text, Convert.ToInt32(txb_Size.Text)), transBrush, new PointF(i, j), -45);
                    }
                }
            }
            

            img_Result.Source = watermark_Image.BitmapToImageSource(BT);
        }

        void DrawDigonalString(Graphics G, string S, Font F, Brush B, PointF P, int Angle)
        {
            SizeF MySize = G.MeasureString(S, F);
            G.TranslateTransform(P.X + MySize.Width / 2, P.Y + MySize.Height / 2);
            G.RotateTransform(Angle);
            G.DrawString(S, F, B, new PointF(-MySize.Width / 2, -MySize.Height / 2));
            G.RotateTransform(-Angle);
            G.TranslateTransform(-P.X - MySize.Width / 2, -P.Y - MySize.Height / 2);
        }

        private void btn_Color_Click(object sender, RoutedEventArgs e)
        {
            btn_CurrentColor.Background = (sender as Button).Background;

            var solid = (sender as Button).Background as brush.SolidColorBrush;
            if (solid != null)
            {
                var r = solid.Color.R;
                var g = solid.Color.G;
                var b = solid.Color.B;
                Selected_Color = Color.FromArgb(255, r, g, b);
            }          
        }

        private void btn_Save_Click(object sender, RoutedEventArgs e)
        {
            forms.SaveFileDialog save = new forms.SaveFileDialog();

            string result_adress;
            save.DefaultExt = ".jpg";

            if (save.ShowDialog() == forms.DialogResult.OK)
            {
                result_adress = save.FileName;
                BT.Save(result_adress);
            }
        }
    }
}
