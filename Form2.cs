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

namespace DiTecFinalProject1
{
    public partial class Frmreg : Form
    {
        public Frmreg()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frmcop cop = new Frmcop();
            cop.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
        }

        private void Frmreg_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            using(SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-MO50O91\SQLSERVER;Initial Catalog=Finalproject;Integrated Security=True")) {
                String query = "INSERT INTO Registration(regNo, fName, LName, dateOfBirth, gender,address,email,mobliePhone,homePhone,parentName,nic,contactNo) VALUES (@regNo, @firstName, @lastName, @dob, @gender,@address,@email,@mobliePhone,@homePhone,@parentName,@nic,@contactNo)";

                using (SqlCommand command = new SqlCommand(query, connection)) {
                    command.Parameters.AddWithValue("@regNo", int.Parse(textBox1.Text));
                    command.Parameters.AddWithValue("@firstName", textBox2.Text);
                    command.Parameters.AddWithValue("@lastName", textBox3.Text);
                    command.Parameters.AddWithValue("@dob", dateTimePicker1.Value);
                    command.Parameters.AddWithValue("@address", textBox4.Text);
                    command.Parameters.AddWithValue("@email", textBox5.Text);
                    command.Parameters.AddWithValue("@mobliePhone",textBox7.Text);
                    command.Parameters.AddWithValue("@homePhone",textBox6.Text);
                    command.Parameters.AddWithValue("@parentName", textBox10.Text);
                    command.Parameters.AddWithValue("@nic", textBox9.Text);
                    command.Parameters.AddWithValue("@contactNo", textBox8.Text);

                    string gender;
                    if (radioButton1.Enabled)
                    {
                        gender = "Male";
                    }
                    else if (radioButton2.Enabled)
                    {
                        gender = "Female";
                    }
                    else
                    {
                        gender = "";
                    }

                    command.Parameters.AddWithValue("@gender", gender);

                    connection.Open();
                    int res = command.ExecuteNonQuery();
                   
                    if (res < 0)
                    {
                        MessageBox.Show("Insert Failed","Data SQL NOt ADD",MessageBoxButtons.OK,MessageBoxIcon.Hand);
                    }
                    else {
                        MessageBox.Show("Insert Successful!","Data SQL ADD",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    }
                    
                }
            }
            
        }
            
       

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-MO50O91\SQLSERVER;Initial Catalog=Finalproject;Integrated Security=True")) {
                string query = "DELETE FROM Registration WHERE regNo = @regNo";
                
                using (SqlCommand command = new SqlCommand(query, connection)) {
                    command.Parameters.AddWithValue("@regNo", int.Parse(textBox1.Text));
                    connection.Open();

                    int res = command.ExecuteNonQuery();

                    if (res < 0)
                    {
                        MessageBox.Show("Failed","DELECT QURRAY FAILED");
                    }
                    else {
                        MessageBox.Show("Deleted", "DELECTED QURRAY SUCCESSFUL");
                    }
                }
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-MO50O91\SQLSERVER;Initial Catalog=Finalproject;Integrated Security=True")) {
                string query = "SELECT * FROM Registration WHERE regNo = @regNo";

                using (SqlCommand command = new SqlCommand(query, connection)) {

                    command.Parameters.AddWithValue("@regNo", int.Parse(textBox1.Text));

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            textBox2.Text = reader["fName"].ToString();
                            textBox3.Text = reader["LName"].ToString();
                            dateTimePicker1.Text=reader["dateofBrith"].ToString();
                            radioButton1.Text = reader["gender"].ToString();
                            radioButton2.Text = reader["gender"].ToString();
                            textBox4.Text = reader["address"].ToString();
                            textBox5.Text = reader["email"].ToString();
                            textBox6.Text = reader["homePhone"].ToString();
                            textBox7.Text = reader["mobliePhone"].ToString();
                            textBox10.Text = reader["parentName"].ToString();
                            textBox9.Text = reader["nic"].ToString();
                            textBox8.Text =reader["contactNo"].ToString();
                            //set form values
                        }
                    }
                }
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-MO50O91\SQLSERVER;Initial Catalog=Finalproject;Integrated Security=True"))
            {
                string query = "UPDATE Registration SET fName = @fName, LName = @LName WHERE regNo = @regNo, dateOfBrith = @dateOfBrith, gender = @gender,address = @address,email = @email, MobilePhone = @mobilePhone, HomePhone = @homePhone, ParentName =@parentName ,NIC=@nic,ContactNo=@contactNo";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@fName", textBox2.Text);
                    command.Parameters.AddWithValue("@LName", textBox3.Text);
                    command.Parameters.AddWithValue("@regNo", int.Parse(textBox1.Text));
                    command.Parameters.AddWithValue("@dateOfBrith", dateTimePicker1.Value);
                    command.Parameters.AddWithValue("@gender",radioButton1.Text);
                    command.Parameters.AddWithValue("@adders", textBox4.Text);
                    command.Parameters.AddWithValue("@email",textBox5);
                    command.Parameters.AddWithValue("@mobilePhone",int.Parse(textBox7.Text));
                    command.Parameters.AddWithValue("@homePhone",int.Parse(textBox6.Text));
                    command.Parameters.AddWithValue("@parentName",textBox10.Text);
                    command.Parameters.AddWithValue("@nic", textBox9.Text);
                    command.Parameters.AddWithValue("@contactNo",int.Parse(textBox8.Text));
                    //set update values

                    connection.Open();

                    int res = command.ExecuteNonQuery();

                    if (res < 0)
                    {
                        MessageBox.Show("Failed","UPDATE FAILED");
                    }
                    else
                    {
                        MessageBox.Show("Updated","UPDATE SUCCESSFUL");
                    }
                }
            }
        }
    }
}
