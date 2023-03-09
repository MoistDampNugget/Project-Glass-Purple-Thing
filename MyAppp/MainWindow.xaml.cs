using MyAppp.Label_DatabaseDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
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
using Xamarin.Forms;

namespace MyAppp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        internal object label;

        public MainWindow()
        {
            InitializeComponent();
        }


        private void Button_Click_1(object sender, RoutedEventArgs e) //update
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source = LJUBO-PC; Initial Catalog = Label_Database; Integrated Security = True"); //Open Connection to database
            try
            {
                sqlCon.Open();
                String query = "Update Artist_Info set Artist_ID = '" + this.txtID.Text + "', Artist_Name = '"+ this.txtName.Text + "', Real_Name ='" + this.txtRealname.Text + "' , Nationality = '"  + this.Nationality.Text + "' where Artist_ID = '" + this.txtID +"'";
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                sqlCmd.ExecuteNonQuery(); MessageBox.Show("Successfully updated! Please Reload!");
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    private void Button_Click(object sender, RoutedEventArgs e) //add
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source = LJUBO-PC; Initial Catalog = Label_Database; Integrated Security = True"); //Open Connection to database
            try
            {
                sqlCon.Open();
                String query = "INSERT INTO Artist_Info (Artist_ID, Artist_Name, Real_Name, Nationality) values('" + this.txtID.Text + "' ,'" + this.txtName.Text + "' ,'" + this.txtRealname.Text + "','" + this.Nationality.Text + "')";
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                sqlCmd.ExecuteNonQuery(); MessageBox.Show("Successfully added! Please Reload!");
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e) //delete
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source = LJUBO-PC; Initial Catalog = Label_Database; Integrated Security = True"); //Open Connection to database
            try
            {
                sqlCon.Open();
                String query = "Delete From Artist_Info where Artist_ID='" + this.txtID.Text + "'";
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                sqlCmd.ExecuteNonQuery(); MessageBox.Show("Successfully deleted!");
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void load_table_Click(object sender, RoutedEventArgs e)
        {
            string dbsCon = @"Data Source = LJUBO-PC; Initial Catalog = Label_Database; Integrated Security = True";
            SqlConnection sqlCon = new SqlConnection(dbsCon); //Open Connection to database
            try
            {
                sqlCon.Open();
                string query = "Select * from Artist_Info";
                SqlCommand cmd = new SqlCommand(query, sqlCon);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable(); 
                adapter.Fill(dt);
                Artist_grid.ItemsSource = dt.DefaultView; 
                adapter.Update(dt);

                string query2 = "Select * from Artist_Socials";
                SqlCommand cmd2 = new SqlCommand(query2, sqlCon);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adapter2 = new SqlDataAdapter(cmd2);
                DataTable dt2 = new DataTable();
                adapter.Fill(dt2);
                Artist_Socials_grid.ItemsSource = dt2.DefaultView;
                adapter.Update(dt2);

                string query3 = "Select * from Artist_Payout";
                SqlCommand cmd3 = new SqlCommand(query3, sqlCon);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adapter3 = new SqlDataAdapter(cmd);
                DataTable dt3 = new DataTable();
                adapter.Fill(dt3);
                Artist_Payout_grid.ItemsSource = dt3.DefaultView;
                adapter.Update(dt3);

                string query4 = "Select * from Music_Release";
                SqlCommand cmd4 = new SqlCommand(query4, sqlCon);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adapter4 = new SqlDataAdapter(cmd);
                DataTable dt4 = new DataTable();
                adapter.Fill(dt4);
                Music_Release_grid.ItemsSource = dt4.DefaultView;
                adapter.Update(dt4);

                MessageBox.Show("Successfully loaded!");
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
