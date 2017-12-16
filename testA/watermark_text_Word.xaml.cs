using Spire.Doc;
using System;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Drawing;
using System.IO;
using forms = System.Windows.Forms;//для исключения конфликтов имен
using System.Drawing.Imaging;
using Spire.Doc.Documents;
using System.Reflection;

namespace testA
{
    /// <summary>
    /// Логика взаимодействия для watermark_text_Word.xaml
    /// </summary>
    public partial class watermark_text_Word : Window
    {
        string document_address;
        Document document;

        public watermark_text_Word()
        {
            InitializeComponent();
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
            TextWatermark txtWatermark = new TextWatermark();
            txtWatermark.Text = txb_Watermark.Text;
            txtWatermark.FontSize = 90;
            txtWatermark.Layout = WatermarkLayout.Diagonal;
            document = new Document(document_address);
            document.Watermark = txtWatermark;
            MessageBox.Show("Водяной узнак успешно наложен");
        }

        private void btn_SaveDocument_Click(object sender, RoutedEventArgs e)
        {
            forms.SaveFileDialog save = new forms.SaveFileDialog();

            save.DefaultExt = ".doc";

            if (save.ShowDialog() == forms.DialogResult.OK)
            {
                document_address = save.FileName;
                document.SaveToFile(document_address, FileFormat.Docx);

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

