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

            BT = new Bitmap(image_address);
            lb_Size.Content = "Длина = " + BT.Height + " Ширина = " + BT.Width;
        }

        private void btn_Impose_Click(object sender, RoutedEventArgs e)
        {
            BT = new Bitmap(image_address);            
            Graphics original_Image = Graphics.FromImage(BT);

            StringFormat strFormatter = new StringFormat();

            SolidBrush transBrush = new SolidBrush(Color.FromArgb(Convert.ToByte(Convert.ToInt32(txb_Opacity.Text) * 255 / 100),Selected_Color.R, Selected_Color.G, Selected_Color.B));

            SizeF MySize = original_Image.MeasureString(txb_Watermark.Text, new Font((cmb_Name.SelectedItem as ComboBoxItem).Content.ToString(), Convert.ToInt32(txb_Size.Text)));

            if (rb_Single.IsChecked == true)
            {
                original_Image.TranslateTransform(Convert.ToInt32(txb_X.Text) + MySize.Width / 2, BT.Height - Convert.ToInt32(txb_Y.Text) - MySize.Height / 2);
                original_Image.RotateTransform(-Convert.ToInt32(txb_Angle.Text));
                original_Image.DrawString(txb_Watermark.Text, new Font((cmb_Name.SelectedItem as ComboBoxItem).Content.ToString(), Convert.ToInt32(txb_Size.Text)), transBrush, -MySize.Width / 2, -MySize.Height / 2);
                original_Image.RotateTransform(Convert.ToInt32(txb_Angle.Text));
                original_Image.TranslateTransform(-Convert.ToInt32(txb_X.Text) - MySize.Width / 2, -BT.Height + Convert.ToInt32(txb_Y.Text) + MySize.Height / 2);
            }
            else
            {
                int step = Convert.ToInt32(txb_Step.Text);

                if(ch_Mirror.IsChecked==true)
                {
                    for (int i = 0; i < BT.Height; i += step)
                    {
                        for (int j = 0; j < BT.Width; j += step)
                        {
                            if (i == j)
                            {                               
                                original_Image.TranslateTransform(i + MySize.Width / 2, BT.Height - j - MySize.Height / 2);
                                original_Image.RotateTransform(-Convert.ToInt32(txb_Angle.Text));
                                original_Image.DrawString(txb_Watermark.Text, new Font((cmb_Name.SelectedItem as ComboBoxItem).Content.ToString(), Convert.ToInt32(txb_Size.Text)), transBrush, -MySize.Width / 2, -MySize.Height / 2);
                                original_Image.RotateTransform(Convert.ToInt32(txb_Angle.Text));
                                original_Image.TranslateTransform(-i - MySize.Width / 2, - BT.Height + j + MySize.Height / 2);
                            }
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < BT.Height; i += step)
                    {
                        for (int j = 0; j < BT.Width; j += step)
                        {
                            if (i == j)
                            {
                                original_Image.TranslateTransform(i + MySize.Width / 2, j + MySize.Height / 2);
                                original_Image.RotateTransform(-Convert.ToInt32(txb_Angle.Text));
                                original_Image.DrawString(txb_Watermark.Text, new Font((cmb_Name.SelectedItem as ComboBoxItem).Content.ToString(), Convert.ToInt32(txb_Size.Text)), transBrush, -MySize.Width / 2, -MySize.Height / 2);
                                original_Image.RotateTransform(Convert.ToInt32(txb_Angle.Text));
                                original_Image.TranslateTransform(-i - MySize.Width / 2, -j - MySize.Height / 2);
                            }
                        }
                    }
                }
            }

            img_Result.Source = watermark_Image.BitmapToImageSource(BT);
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

        private void rb_Checked(object sender, RoutedEventArgs e)
        {
            if((sender as RadioButton).Name=="rb_Single")
            {
                st_Single.Visibility = Visibility.Visible;
            }
            else
            {
                st_Multiple.Visibility = Visibility.Visible;
            }
        }

        private void rb_Unchecked(object sender, RoutedEventArgs e)
        {
            if ((sender as RadioButton).Name == "rb_Single")
            {
                st_Single.Visibility = Visibility.Collapsed;
            }
            else
            {
                st_Multiple.Visibility = Visibility.Collapsed;
            }
        }

    }
}
