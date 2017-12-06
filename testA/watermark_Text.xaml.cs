using System;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Drawing;
using System.IO;
using forms = System.Windows.Forms;//для исключения конфликтов имен
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
            Bitmap BT = new Bitmap(image_address);
            Graphics original_Image = Graphics.FromImage(BT);

            StringFormat strFormatter = new StringFormat();

            SolidBrush transBrush = new SolidBrush(Color.Black);

            DrawDigonalString(original_Image, txb_Watermark.Text, new Font("Arial", 30), transBrush, new PointF(300, 300), -45);

            img_Result.Source = watermark_Image.BitmapToImageSource(BT);
        }

        void DrawDigonalString(Graphics G, string S, Font F, Brush B, PointF P, int Angle)
        {
            SizeF MySize = G.MeasureString(S, F);
            G.TranslateTransform(P.X + MySize.Width / 2, P.Y + MySize.Height / 2);
            G.RotateTransform(Angle);
            G.DrawString(S, F, B, new PointF(-MySize.Width / 2, -MySize.Height / 2));
            G.RotateTransform(-Angle); G.TranslateTransform(-P.X - MySize.Width / 2, -P.Y - MySize.Height / 2);
        }
    }
}
