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
    public partial class FM_Teachers : Form
    {
        string ConnectionString = "Data Source=ABHI-XTHA\\SQLEXPRESS;Initial Catalog=hostel__management_system;User ID=sa;Password=abhishek;Encrypt=False;";
        public FM_Teachers()
        {
            InitializeComponent();
        }

        void FillData1()
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                string query = "SELECT TeacherID,Name,Position FROM Teachers WHERE Status=1";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                SqlCommandBuilder bulder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                dg_teach1.DataSource = ds.Tables[0];
                con.Close();
            }
        }
        void FillData2()
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                string query = "SELECT TeacherID,Name FROM Teachers WHERE Status=0";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                SqlCommandBuilder bulder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                dg_teach2.DataSource = ds.Tables[0];
                con.Close();
            }
        }
        private void RefreshDataGridViews()
        {
            FillData1();
            FillData2();
        }

        private void dg_teach1_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e?.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell selectedCell = dg_teach1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                string teacherID = selectedCell.OwningRow.Cells["TeacherID"].Value?.ToString() ?? "";

                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM Teachers WHERE TeacherID = @teacherID";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@teacherID", teacherID);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            tb_teacherid.Text = reader["TeacherID"].ToString();
                            tb_name.Text = reader["Name"].ToString();
                            tb_address.Text = reader["Address"].ToString();
                            tb_contact.Text = reader["Contact"].ToString();
                            tb_position.Text = reader["Position"].ToString();
                            tb_status.Text = reader["Status"].ToString();
                        }
                    }
                    con.Close();
                }
            }
        }

        private void dg_teach2_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e?.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell selectedCell = dg_teach2.Rows[e.RowIndex].Cells[e.ColumnIndex];
                string teacherID = selectedCell.OwningRow.Cells["TeacherID"].Value?.ToString() ?? "";

                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM Teachers WHERE TeacherID = @teacherID";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@teacherID", teacherID);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            tb_teacherid.Text = reader["TeacherID"].ToString();
                            tb_name.Text = reader["Name"].ToString();
                            tb_address.Text = reader["Address"].ToString();
                            tb_contact.Text = reader["Contact"].ToString();
                            tb_position.Text = reader["Position"].ToString();
                            tb_status.Text = reader["Status"].ToString();
                        }
                    }
                    con.Close();
                }
            }
        }

        private void btn_teachers_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_teach_back_Click(object sender, EventArgs e)
        {
            FM_Main fM = new FM_Main();
            fM.ShowDialog();
            this.Hide();
        }

        private void btn_teach_add_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                try
                {
                    con.Open();
                    if (tb_teacherid.Text == "")
                    {
                        MessageBox.Show("Please Enter the Details!");
                    }
                    else
                    {
                        int existingStatus = GetTeacherStatus(con, tb_teacherid.Text);

                        if (existingStatus == 0)
                        {
                            string query = "UPDATE Teachers SET Name = @name, Address = @address, Contact = @contact, " +
                                       "Position = @position, Status = @Status WHERE TeacherID = @teacherid";

                            using (SqlCommand cmd = new SqlCommand(query, con))
                            {
                                cmd.Parameters.AddWithValue("@name", tb_name.Text);
                                cmd.Parameters.AddWithValue("@address", tb_address.Text);
                                cmd.Parameters.AddWithValue("@contact", tb_contact.Text);
                                cmd.Parameters.AddWithValue("@position", tb_position.Text);
                                cmd.Parameters.AddWithValue("@Status", 1);
                                cmd.Parameters.AddWithValue("@teacherid", tb_teacherid.Text);
                                cmd.ExecuteNonQuery();
                                RefreshDataGridViews();
                                MessageBox.Show("Teacher information updated successfully!");
                            }
                        }
                        else
                        {
                            string query = "INSERT INTO Teachers(TeacherID, Name, Address, Contact, Position, Status) " +
                                           "VALUES (@teacherid, @name, @address, @contact, @position, @Status)";

                            using (SqlCommand cmd = new SqlCommand(query, con))
                            {
                                cmd.Parameters.AddWithValue("@teacherid", tb_teacherid.Text);
                                cmd.Parameters.AddWithValue("@name", tb_name.Text);
                                cmd.Parameters.AddWithValue("@address", tb_address.Text);
                                cmd.Parameters.AddWithValue("@contact", tb_contact.Text);
                                cmd.Parameters.AddWithValue("@position", tb_position.Text);
                                cmd.Parameters.AddWithValue("@Status", 1);
                                cmd.ExecuteNonQuery();
                                RefreshDataGridViews();
                                MessageBox.Show("Teacher added successfully!");
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



        // Helper method to get the status of a teacher with the given teacher ID
        private int GetTeacherStatus(SqlConnection con, string teacherId)
        {
            string query = "SELECT Status FROM Teachers WHERE TeacherID = @teacherid";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@teacherid", teacherId);
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    return Convert.ToInt32(result);
                }
                else
                {
                    return -1; // Return -1 for non-existent teacher
                }
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_teach_update_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                try
                {
                    con.Open();
                    if (tb_teacherid.Text == "")
                    {
                        MessageBox.Show("Please Enter The Details!");
                    }
                    else
                    {
                        string query = "UPDATE Teachers SET Name = @name, Address = @address, Contact = @contact, " +
                                       "Position = @position, Status = @Status WHERE TeacherID = @teacherid";

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@name", tb_name.Text);
                            cmd.Parameters.AddWithValue("@address", tb_address.Text);
                            cmd.Parameters.AddWithValue("@contact", tb_contact.Text);
                            cmd.Parameters.AddWithValue("@position", tb_position.Text);
                            cmd.Parameters.AddWithValue("@Status", tb_status.Text);
                            cmd.Parameters.AddWithValue("@teacherid", tb_teacherid.Text);
                            cmd.ExecuteNonQuery();
                            RefreshDataGridViews();
                            MessageBox.Show("Teacher information updated successfully!");
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

        private void btn_teach_delete_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                try
                {
                    con.Open();
                    if (tb_teacherid.Text == "")
                    {
                        MessageBox.Show("Please select a teacher to delete!");
                    }
                    else
                    {
                        int teacherId = Convert.ToInt32(tb_teacherid.Text);

                        string query = "UPDATE Teachers SET Status = 0 WHERE TeacherID = @teacherid";

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@teacherid", teacherId);
                            cmd.ExecuteNonQuery();
                            RefreshDataGridViews();
                            MessageBox.Show("Teacher deleted successfully!");
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

        private void cb_left_teach_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_left_teach.Checked)
            {
                dg_teach1.Hide();
                lbl_ct.Hide();
                lbl_pt.Show();
            }
            else
            {
                dg_teach1.Show();
                lbl_pt.Hide();
                lbl_ct.Show();

            }
        }

        private void tb_status_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_pt_Click(object sender, EventArgs e)
        {

        }
    }
}
