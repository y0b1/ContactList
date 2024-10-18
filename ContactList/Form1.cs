using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace ContactList
{
    public partial class Form1 : Form
    {
        Connection conn = new Connection();
        SqlConnection kon;
        SqlCommand cmd;
        SqlDataReader rd;
        private int nextContactID = 0;
        
        public Form1()
        {
            InitializeComponent();
            this.dataGridView1.CellClick += new DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.deleteButton.Click += new EventHandler(this.deleteButton_Click);
        }

        private void ClearFields()
        {
            firstNBox.Text = "";
            lastNBox.Text = "";
            mailBox.Text = "";
            phoneBox.Text = "";
            companyBox.Text = "";
            addressBox.Text = "";
        }

        private void LoadContacts()
        {
            kon = conn.getCon();
            kon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Contact", kon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int currentID = nextContactID++;
            kon = conn.getCon();
            kon.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO Contact (ContactID, FirstName, LastName, PhoneNumber, Email, CompanyName, Address) VALUES (@ContactID, @FirstName, @LastName, @PhoneNumber, @Email, @CompanyName, @Address)", kon);
            cmd.Parameters.AddWithValue("@ContactID", nextContactID);
            cmd.Parameters.AddWithValue("@FirstName", firstNBox.Text);
            cmd.Parameters.AddWithValue("@LastName", lastNBox.Text);
            cmd.Parameters.AddWithValue("@PhoneNumber", phoneBox.Text);
            cmd.Parameters.AddWithValue("@Email", mailBox.Text);
            cmd.Parameters.AddWithValue("@CompanyName", companyBox.Text);
            cmd.Parameters.AddWithValue("@Address", addressBox.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Contact added successfully!");
            ClearFields();
            LoadContacts();
            kon.Close();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (selectedContactID != 0)
            {
                kon = conn.getCon();
                kon.Open();

                SqlCommand cmd = new SqlCommand("UPDATE Contact SET FirstName = @FirstName, LastName = @LastName, PhoneNumber = @PhoneNumber, Email = @Email, CompanyName = @CompanyName, Address = @Address WHERE ContactID = @ContactID", kon);
                cmd.Parameters.AddWithValue("@ContactID", selectedContactID); 
                cmd.Parameters.AddWithValue("@FirstName", firstNBox.Text);
                cmd.Parameters.AddWithValue("@LastName", lastNBox.Text);
                cmd.Parameters.AddWithValue("@PhoneNumber", phoneBox.Text);
                cmd.Parameters.AddWithValue("@Email", mailBox.Text);
                cmd.Parameters.AddWithValue("@CompanyName", companyBox.Text);
                cmd.Parameters.AddWithValue("@Address", addressBox.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Contact updated successfully!");
                ClearFields();
                LoadContacts();
                kon.Close();
            } else
            {
                MessageBox.Show("Please select a contact to update.");
            }
        }

        private int selectedContactID;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                selectedContactID = Convert.ToInt32(row.Cells["ContactID"].Value); 

                firstNBox.Text = row.Cells["FirstName"].Value.ToString();
                lastNBox.Text = row.Cells["LastName"].Value.ToString();
                phoneBox.Text = row.Cells["PhoneNumber"].Value.ToString();
                mailBox.Text = row.Cells["Email"].Value.ToString();
                companyBox.Text = row.Cells["CompanyName"].Value.ToString();
                addressBox.Text = row.Cells["Address"].Value.ToString();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (selectedContactID != 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this contact?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    kon = conn.getCon();
                    kon.Open();

                    SqlCommand cmd = new SqlCommand("DELETE FROM Contact WHERE ContactID = @ContactID", kon);

                    cmd.Parameters.AddWithValue("@ContactID", selectedContactID);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Contact deleted successfully!");

                    ClearFields();
                    LoadContacts();

              
                    kon.Close();
                }
            }
            else
            {
                MessageBox.Show("Please select a contact to delete.");
            }
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            LoadContacts();
        }
    }
}
