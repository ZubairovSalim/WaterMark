using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Drawing;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using forms = System.Windows.Forms;//для исключения конфликтов имен
using System.Drawing.Imaging;

namespace testA
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {       
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_TW_Click(object sender, RoutedEventArgs e)
        {
            watermark_Text Text_Form = new watermark_Text();
            Text_Form.Show();
        }

        private void btn_DW_Click(object sender, RoutedEventArgs e)
        {
            watermark_Image Img_Form = new watermark_Image();
            Img_Form.Show();
        }

        private void btn_text_DW_Click(object sender, RoutedEventArgs e)
        {
            watermark_Word Word_Form = new watermark_Word();
            Word_Form.Show();
        }

        private void btn_text_TW_Click(object sender, RoutedEventArgs e)
        {
            watermark_text_Word text_Word_Form = new watermark_text_Word();
            text_Word_Form.Show();
        }
    }
}
