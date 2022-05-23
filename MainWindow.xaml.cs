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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using  Newtonsoft.Json;


namespace FocusToolTaskBanner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonAddName_Click(object sender, RoutedEventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(txtName.Text) && !lstNames.Items.Contains(txtName.Text))
            {
                lstNames.Items.Add(txtName.Text);
                taskName.Text = "" + txtName.Text;
                txtName.Clear();

            }

        }
        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(txtName.Text) && !lstNames.Items.Contains(txtName.Text))
            {
                List<Dane> _data = new List<Dane>();
                _data.Add(new Dane()
                {
                    Id = 1,
                    SSN = 2,
                    Message = "A Message"
                });

                // string json = JsonConvert.SerializeObject(_data.ToArray());
                string json = JsonConvert.SerializeObject(_data.ToArray(), Formatting.Indented);
                //write string to file
                System.IO.File.WriteAllText(@"D:\path.txt", json);


                // lstNames.Items.Add(txtName.Text);
                // taskName.Text = "" + txtName.Text;
                // txtName.Clear();

            }

        }

    }

    public class Dane
{
    public int Id { get; set; }
    public int SSN { get; set; }
    public string? Message { get; set;}
}

}
