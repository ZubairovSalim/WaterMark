using System;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Drawing;
using System.IO;
using forms = System.Windows.Forms;//для исключения конфликтов имен
using System.Drawing.Imaging;

namespace testA
{
    /// <summary>
    /// Логика взаимодействия для watermark_Image.xaml
    /// </summary>
    public partial class watermark_Image : Window
    {
        string image_address = String.Empty;
        string watermark_address = String.Empty;
        Bitmap result;

        public watermark_Image()
        {
            InitializeComponent();
        }

        private Bitmap DrawWatermark(Bitmap watermark_bm, Bitmap result_bm, int x, int y)
        {
            var bmp = new Bitmap(watermark_address);
            var rect = new Rectangle(0, 0, bmp.Width, bmp.Height);

            var upgradedbmp = bmp.Clone(rect, PixelFormat.Format32bppArgb);
            bmp.Dispose();

            byte ALPHA = Convert.ToByte(Convert.ToInt32(txb_Opacity.Text)*255/100);

            Color clr;
            for (int py = 0; py < upgradedbmp.Height; py++)
            {
                for (int px = 0; px < upgradedbmp.Width; px++)
                {
                    clr = watermark_bm.GetPixel(px, py);
                    upgradedbmp.SetPixel(px, py, Color.FromArgb(ALPHA, clr.R, clr.G, clr.B));
                }
            }

            upgradedbmp.MakeTransparent(upgradedbmp.GetPixel(0, 0));

            //Copy onto the result image.
            using (Graphics gr = Graphics.FromImage(result_bm))
            {
                gr.TranslateTransform(Convert.ToInt32(txb_X.Text) + watermark_bm.Width / 2, result_bm.Height - Convert.ToInt32(txb_Y.Text) - watermark_bm.Height / 2);
                gr.RotateTransform(-Convert.ToInt32(txb_Angle.Text));               
                gr.DrawImage(upgradedbmp, -watermark_bm.Width / 2, -watermark_bm.Height / 2);
                gr.RotateTransform(Convert.ToInt32(txb_Angle.Text));
                gr.TranslateTransform(-Convert.ToInt32(txb_X.Text) - watermark_bm.Width / 2, -result_bm.Height + Convert.ToInt32(txb_Y.Text) + watermark_bm.Height / 2);
            }

            return result_bm;
        }

        public static BitmapImage BitmapToImageSource(Bitmap bitmap)
        {
            using (MemoryStream memory = new MemoryStream())
            {
                bitmap.Save(memory, System.Drawing.Imaging.ImageFormat.Bmp);
                memory.Position = 0;
                BitmapImage bitmapimage = new BitmapImage();
                bitmapimage.BeginInit();
                bitmapimage.StreamSource = memory;
                bitmapimage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapimage.EndInit();

                return bitmapimage;
            }
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

        private void btn_AddWatermark_Click(object sender, RoutedEventArgs e)
        {
            forms.OpenFileDialog opn = new forms.OpenFileDialog();

            if (opn.ShowDialog() == forms.DialogResult.OK)
            {
                watermark_address = opn.FileName;
            }

            img_Watermark.Source = new BitmapImage(new Uri(watermark_address));
            img_Watermark.Visibility = Visibility.Visible;
        }

        private void btn_Impose_Click(object sender, RoutedEventArgs e)
        {
            Bitmap image = new Bitmap(image_address);
            Bitmap watermark = new Bitmap(watermark_address);

            result = DrawWatermark(watermark, image, Convert.ToInt32(txb_X.Text), Convert.ToInt32(txb_Y.Text));

            img_Result.Source = BitmapToImageSource(result);

            img_Result.Visibility = Visibility.Visible;           
        }

        private void btn_Save_Click(object sender, RoutedEventArgs e)
        {
            forms.SaveFileDialog save = new forms.SaveFileDialog();

            string result_adress;
            save.DefaultExt = ".jpg";

            if (save.ShowDialog() == forms.DialogResult.OK)
            {
                result_adress = save.FileName;
                result.Save(result_adress);
            }
        }
    }
}
