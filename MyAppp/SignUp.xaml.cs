using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
using System.Windows.Shapes;
using Xamarin.Forms.PlatformConfiguration;

namespace MyAppp
{
    /// <summary>
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUp : Window
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source = LJUBO-PC; Initial Catalog = Label_Database; Integrated Security = True");

            try
            {
                sqlCon.Open();

                string query = "Insert into wpfArtist_Info(Artist_Name, Real_Name, Nationality)values('"+this.txtArtName.Text+"','"+this.txtRealName.Text+"','"+this.txtNationality.Text+"')";
                SqlCommand cmd = new SqlCommand(query, sqlCon);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Successfully saved!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
                LogIn x = new LogIn();
                x.Show();
                this.Close();
            }
        }

        private void alracc_Click(object sender, RoutedEventArgs e)
        {
            LogIn x = new LogIn();
            x.Show();
            this.Close();
        }
    }
}
