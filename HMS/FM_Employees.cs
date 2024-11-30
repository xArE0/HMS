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

namespace HMS
{
    public partial class FM_Employees : Form
    {
        string ConnectionString = "Data Source=ABHI-XTHA\\SQLEXPRESS;Initial Catalog=hostel__management_system;User ID=sa;Password=abhishek;Encrypt=False;";
        public FM_Employees()
        {
            InitializeComponent();
        }
        void FillData1()
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                string query = "SELECT EmployeeID,Name,Address FROM Employees WHERE Status=1";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                SqlCommandBuilder bulder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                dg_emp1.DataSource = ds.Tables[0];
                con.Close();
            }
        }
        void FillData2()
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                string query = "SELECT EmployeeID,Name,Address FROM Employees WHERE Status=0";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                SqlCommandBuilder bulder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                dg_emp2.DataSource = ds.Tables[0];
                con.Close();
            }
        }
        private void RefreshDataGridViews()
        {
            FillData1();
            FillData2();
        }

        private void dg_emp1_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e?.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell selectedCell = dg_emp1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                string employeeID = selectedCell.OwningRow.Cells["EmployeeID"].Value?.ToString() ?? "";

                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM Employees WHERE EmployeeID= @employeeid";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@employeeid", employeeID);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            tb_empid.Text = reader["EmployeeID"].ToString();
                            tb_name.Text = reader["Name"].ToString();
                            tb_address.Text = reader["Address"].ToString();
                            tb_contact.Text = reader["Contact"].ToString();                          
                            tb_status.Text = reader["Status"].ToString();
                        }
                    }
                    con.Close();
                }
            }
        }

        private void dg_emp2_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e?.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell selectedCell = dg_emp2.Rows[e.RowIndex].Cells[e.ColumnIndex];
                string employeeID = selectedCell.OwningRow.Cells["EmployeeID"].Value?.ToString() ?? "";

                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM Employees WHERE EmployeeID= @employeeid";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@employeeid", employeeID);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            tb_empid.Text = reader["EmployeeID"].ToString();
                            tb_name.Text = reader["Name"].ToString();
                            tb_address.Text = reader["Address"].ToString();
                            tb_contact.Text = reader["Contact"].ToString();                  
                            tb_status.Text = reader["Status"].ToString();
                        }
                    }
                    con.Close();
                }
            }
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_stu_back_Click(object sender, EventArgs e)
        {
            FM_Main fm_emp = new FM_Main();
            fm_emp.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_emp_add_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                try
                {
                    con.Open();
                    if (tb_empid.Text == "")
                    {
                        MessageBox.Show("Please Enter the Details!");
                    }
                    else
                    {
                        int existingStatus = GetEmployeeStatus(con, tb_empid.Text);

                        if (existingStatus == 0)
                        {
                            string query = "UPDATE Employees SET Name = @name, Address = @address, " +
                                           "Contact = @contact, Status = @Status " +
                                           "WHERE EmployeeID = @empid";

                            using (SqlCommand cmd = new SqlCommand(query, con))
                            {
                                cmd.Parameters.AddWithValue("@name", tb_name.Text);
                                cmd.Parameters.AddWithValue("@address", tb_address.Text);
                                cmd.Parameters.AddWithValue("@contact", tb_contact.Text);                            
                                cmd.Parameters.AddWithValue("@Status", 1);
                                cmd.Parameters.AddWithValue("@empid", tb_empid.Text);
                                cmd.ExecuteNonQuery();
                                RefreshDataGridViews();
                                MessageBox.Show("Employee information Added successfully!");
                            }
                        }
                        else
                        {
                            string query = "INSERT INTO Employees(EmployeeID, Name, Address, Contact, Status) " +
                                           "VALUES (@empid, @name, @address, @contact, @Status)";

                            using (SqlCommand cmd = new SqlCommand(query, con))
                            {
                                cmd.Parameters.AddWithValue("@empid", tb_empid.Text);
                                cmd.Parameters.AddWithValue("@name", tb_name.Text);
                                cmd.Parameters.AddWithValue("@address", tb_address.Text);
                                cmd.Parameters.AddWithValue("@contact", tb_contact.Text);
                                cmd.Parameters.AddWithValue("@Status", tb_status);
                                cmd.ExecuteNonQuery();
                                RefreshDataGridViews();
                                MessageBox.Show("Employee added successfully!");
                            }
                        }
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private int GetEmployeeStatus(SqlConnection con, string employeeId)
        {
            string query = "SELECT Status FROM Employees WHERE EmployeeID = @empid";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@empid", employeeId);
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    return Convert.ToInt32(result);
                }
                else
                {
                    return -1; // Return -1 for non-existent employee
                }
            }
        }

        private void btn_emp_delete_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                try
                {
                    if (string.IsNullOrEmpty(tb_empid.Text))
                    {
                        MessageBox.Show("Please select an employee to delete.");
                        return;
                    }

                    con.Open();
                    int existingStatus = GetEmployeeStatus(con, tb_empid.Text);

                    if (existingStatus != -1)
                    {                      
                        string query = "UPDATE Employees SET Status = 0 WHERE EmployeeID = @empid";

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@empid", tb_empid.Text);
                            cmd.ExecuteNonQuery();
                            RefreshDataGridViews();
                            MessageBox.Show("Employee information deleted successfully!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Employee not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void btn_emp_update_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                try
                {   
                    con.Open();
                    string query = "UPDATE Employees SET Name = @name, Address = @address, " +
                                   "Contact = @contact, Status = @Status " +
                                   "WHERE EmployeeID = @empid";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@name", tb_name.Text);
                        cmd.Parameters.AddWithValue("@address", tb_address.Text);
                        cmd.Parameters.AddWithValue("@contact", tb_contact.Text);
                        cmd.Parameters.AddWithValue("@Status", tb_status.Text);
                        cmd.Parameters.AddWithValue("@empid", tb_empid.Text);
                        
                        cmd.ExecuteNonQuery();
                        RefreshDataGridViews();
                        MessageBox.Show("Employee information updated successfully!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                con.Close();
            }
        }

        private void btn_emp_back_Click(object sender, EventArgs e)
        {
            FM_Main fm = new FM_Main();
            fm.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cb_past_emp_CheckedChanged(object sender, EventArgs e)
        {
            if(cb_past_emp.Checked)
            {
                dg_emp1.Hide();
                lbl_present_emp.Hide();
                lbl_past_emp.Show();
            }
            else
            {
                dg_emp1.Show();
                lbl_past_emp.Hide();
                lbl_present_emp.Show();
            }

        }
    }
}
