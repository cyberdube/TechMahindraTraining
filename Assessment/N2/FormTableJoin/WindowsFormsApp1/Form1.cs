using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void s_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-AR2IOA5\\SQLEXPRESS;Initial Catalog=shubhankdb;Integrated Security=True";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Prepare query using parameterized query to avoid SQL injection
                    string query = "INSERT INTO Members (Name, ContactInfo, MembershipID) VALUES (@Name, @ContactInfo, @MembershipID)";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Name", richTextBox1.Text);
                    cmd.Parameters.AddWithValue("@ContactInfo", richTextBox2.Text);
                    cmd.Parameters.AddWithValue("@MembershipID", richTextBox3.Text);

                    // Execute query
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Member added successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        /*
                private void s_Click(object sender, EventArgs e)
                {
                    string connectionString = "Data Source=DESKTOP-AR2IOA5\\SQLEXPRESS;Initial Catalog=shubhankdb;Integrated Security=True";

                   // string connectionString = "Data Source = DESKTOP - AR2IOA5\\SQLEXPRESS; Initial Catalog = shubhankdb; Integrated Security = True";

                    //establish connection

                    SqlConnection con = new SqlConnection(connectionString);

                    //open coonection
                    con.Open();
                    //prepare query
                   // string FirstName = tB1.Text;
                    //string LastName = tB2.Text;
                    string ID = richTextBox4.Text;
                    string Name = richTextBox1.Text;
                    string ContactInfo = richTextBox2.Text;
                    string MembershipID = richTextBox3.Text;


                    //string Query= "INSERT INTO Form (FirstName, LastName)\r\nVALUES ('"+FirstName+"', '"+LastName+"')";//

                    string Query = "INSERT INTO Members (ID,Name,ContactInfo,MembershipID)\r\nVALUES ('" + ID + "', '" + Name + "','" + ContactInfo + "','" +MembershipID + "')";

                    // execute
                    SqlCommand cmd= new SqlCommand(Query, con);
                    cmd.ExecuteNonQuery();
                    //close
                    con.Close();
                }

            */

        /*
        private void Delete_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-AR2IOA5\\SQLEXPRESS;Initial Catalog=shubhankdb;Integrated Security=True";

            // Establish connection
            SqlConnection con = new SqlConnection(connectionString);

            try
            {
                // Open connection
                con.Open();

                // Prepare query
                string FirstName = tB1.Text;
                string LastName = tB2.Text;

                string Query = "DELETE FROM Form WHERE FirstName = @FirstName AND LastName = @LastName";

                // Execute
                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.Parameters.AddWithValue("@FirstName", FirstName);
                cmd.Parameters.AddWithValue("@LastName", LastName);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Close connection
                con.Close();
            }

        }


        */

        private void Delete_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-AR2IOA5\\SQLEXPRESS;Initial Catalog=shubhankdb;Integrated Security=True";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Prepare query using parameterized query to avoid SQL injection
                    string query = "DELETE FROM Members WHERE ID = @ID";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@ID", richTextBox4.Text); // Assuming richTextBox4 contains the ID of the member to delete

                    // Execute query
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Member deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Member with specified ID not found.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tB1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

          
                string connectionString = "Data Source=DESKTOP-AR2IOA5\\SQLEXPRESS;Initial Catalog=shubhankdb;Integrated Security=True";

                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();

                        // Prepare query using parameterized query to avoid SQL injection
                        string query = @"INSERT INTO Books (Title, Author, ISBN, Genre, PublicationDate, IsAvailable) 
                             VALUES (@Title, @Author, @ISBN, @Genre, @PublicationDate, @IsAvailable)";

                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@Title", to2.Text); // Assuming textBoxTitle contains the title of the book
                        cmd.Parameters.AddWithValue("@Author", to3.Text); // Assuming textBoxAuthor contains the author of the book
                        cmd.Parameters.AddWithValue("@ISBN", to4.Text); // Assuming textBoxISBN contains the ISBN of the book
                        cmd.Parameters.AddWithValue("@Genre", to5.Text); // Assuming textBoxGenre contains the genre of the book
                        cmd.Parameters.AddWithValue("@PublicationDate", to6.Text); // Assuming dateTimePickerPublicationDate contains the publication date of the book

                        // Convert user input to int for IsAvailable
                        int isAvailableValue = int.Parse(to7.Text); // Assuming textBoxIsAvailable contains user input (1 or 0)
                        cmd.Parameters.AddWithValue("@IsAvailable", isAvailableValue);

                        // Execute query
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Book added successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to add book.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
         

        }

        private void button2_Click(object sender, EventArgs e)
        {

                string connectionString = "Data Source=DESKTOP-AR2IOA5\\SQLEXPRESS;Initial Catalog=shubhankdb;Integrated Security=True";

                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();

                        // Prepare query using parameterized query to avoid SQL injection
                        string query = "DELETE FROM Books WHERE ID = @ID";

                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@ID", int.Parse(to1.Text)); // Assuming textBoxDeleteBookID contains the ID of the book to be deleted

                        // Execute query
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Book deleted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No book found with the specified ID.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

       
    }
}
