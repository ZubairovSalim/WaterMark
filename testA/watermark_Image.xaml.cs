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

            const byte ALPHA = 126;

            Color clr;
            for (int py = 0; py < upgradedbmp.Height; py++)
            {
                for (int px = 0; px < upgradedbmp.Width; px++)
                {
                    clr = watermark_bm.GetPixel(px, py);
                    upgradedbmp.SetPixel(px, py, Color.FromArgb(ALPHA, clr.R, clr.G, clr.B));
                }
            }

            MessageBox.Show(upgradedbmp.GetPixel(0, 0).A.ToString());

            upgradedbmp.MakeTransparent(upgradedbmp.GetPixel(0, 0));

            //Copy onto the result image.
            using (Graphics gr = Graphics.FromImage(result_bm))
            {
                gr.DrawImage(upgradedbmp, x, y);
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

            Bitmap result = DrawWatermark(watermark, image, 0, 0);

            img_Result.Source = BitmapToImageSource(result);

            img_Result.Visibility = Visibility.Visible;

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
