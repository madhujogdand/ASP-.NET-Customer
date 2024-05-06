using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace ASP.NET_Customer
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
            string constr = ConfigurationManager.ConnectionStrings["dbconnectioncustomer"].ConnectionString;
            con= new SqlConnection(constr); 
        }

        private void clearFields()
        {
            txtId.Clear();
            txtName.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            txtContact.Clear(); 
            txtPassword.Clear();   
            txtPanNo.Clear();
            txtAadharNo.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtName.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            txtContact.Clear();
            txtPassword.Clear();
            txtPanNo.Clear();
            txtAadharNo.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

              string qry = "Insert into customer values(@name,@address,@email,@contactno,@password,@panno,@aadharno,@role)";
                cmd = new SqlCommand(qry,con);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@contactno", txtContact.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                cmd.Parameters.AddWithValue("@panno", txtPanNo.Text);
                cmd.Parameters.AddWithValue("@aadharno", txtAadharNo.Text);
                cmd.Parameters.AddWithValue("@role", txtRole.Text);
                  con.Open();
                 int result=cmd.ExecuteNonQuery();
                if (result >=1)
                {
                    MessageBox.Show("Record Inserted");
                    clearFields();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            { 
                con.Close();
            }    
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {

            string qry = "select * from customer where id=@id";
            cmd = new SqlCommand(qry,con);
            cmd.Parameters.AddWithValue("@id", txtId.Text);
            con.Open();
            dr=cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    txtName.Text = dr["name"].ToString();
                    txtAddress.Text = dr["address"].ToString();
                    txtEmail.Text = dr["email"].ToString();
                    txtContact.Text = dr["contactno"].ToString();
                    txtPassword.Text = dr["password"].ToString();
                    txtPanNo.Text = dr["panno"].ToString();
                    txtAadharNo.Text = dr["aadharno"].ToString() ;

                }
            }
            else 
            {
                MessageBox.Show("Record not found");
            }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally 
            { 
               con.Close() ;    
            } 
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                string qry = "update customer set name=@name, address=@address, email=@email, contactno=@contactno, password=@password, panno=@panno, aadharno=@aadharno, role=@role";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@contactno", txtContact.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                cmd.Parameters.AddWithValue("@panno", txtPanNo.Text);
                cmd.Parameters.AddWithValue("@aadharno", txtAadharNo.Text);
                cmd.Parameters.AddWithValue("@role", txtRole.Text);
                cmd.Parameters.AddWithValue("@id", txtId.Text);
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result >= 1)
                {
                    MessageBox.Show("Record Updated");
                    clearFields();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                string qry = "delete from customer where id=@id";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@id", txtId.Text);
           
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result >= 1)
                {
                    MessageBox.Show("Record Deleted");
                    clearFields();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            try 
            { 
            string qry = "select * from customer";
            cmd = new SqlCommand(qry, con);
            con.Open();
            dr= cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(dr);
            dataGridView1.DataSource = table;

        }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
