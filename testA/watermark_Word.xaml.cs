using Spire.Doc;
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
    /// Логика взаимодействия для watermark_Word.xaml
    /// </summary>
    public partial class watermark_Word : Window
    {
        string image_address;
        string document_address;
        Document document;

        public watermark_Word()
        {
            InitializeComponent();
        }

        private void btn_AddWatermark_Click(object sender, RoutedEventArgs e)
        {
            forms.OpenFileDialog opn = new forms.OpenFileDialog();

            if (opn.ShowDialog() == forms.DialogResult.OK)
            {
                image_address = opn.FileName;
            }

            img_Watermark.Source = new BitmapImage(new Uri(image_address));
            img_Watermark.Visibility = Visibility.Visible;
        }

        private void btn_AddDocument_Click(object sender, RoutedEventArgs e)
        {
            forms.OpenFileDialog opn = new forms.OpenFileDialog();

            if (opn.ShowDialog() == forms.DialogResult.OK)
            {
               document_address = opn.FileName;
            }

            lb_Document.Content = document_address;
        }

        private void btn_Impose_Click(object sender, RoutedEventArgs e)
        {
            PictureWatermark picture = new PictureWatermark();
            picture.Picture = Image.FromFile(image_address); 
            picture.Scaling = 250;
            document = new Document(document_address);
            document.Watermark = picture;
            MessageBox.Show("Водяной узнак успешно наложен");
        }

        private void btn_SaveDocument_Click(object sender, RoutedEventArgs e)
        {
            forms.SaveFileDialog save = new forms.SaveFileDialog();

            save.DefaultExt = ".doc";

            if (save.ShowDialog() == forms.DialogResult.OK)
            {
                document_address = save.FileName;
                document.SaveToFile(document_address);

                Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
                app.Visible = false;
                Microsoft.Office.Interop.Word.Document doc = app.Documents.Open(document_address);
                Microsoft.Office.Interop.Word.Range r = doc.Content;
                r.Find.ClearFormatting();
                r.Find.Execute(FindText: "Evaluation Warning: The document was created with Spire.Doc for .NET.", ReplaceWith: "");
                doc.SaveAs(document_address);

                doc.Close();
                app.Quit();

                MessageBox.Show("Документ успешно сохранен");
            }
        }    
    }
}
