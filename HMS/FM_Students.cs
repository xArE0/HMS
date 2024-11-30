using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS
{
    public partial class FM_Students : Form
    {
        string ConnectionString = "Data Source=ABHI-XTHA\\SQLEXPRESS;Initial Catalog=hostel__management_system;User ID=sa;Password=abhishek;Encrypt=False;";
        public FM_Students()
        {
            InitializeComponent();
        }

        void FillData1()
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                string query = "SELECT StudentID,Name,RoomNo FROM Students WHERE Status=1";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                SqlCommandBuilder bulder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                dg_student_list.DataSource = ds.Tables[0];
                con.Close();
            }
        }
        void FillData2()
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                string query = "SELECT StudentID,Name,RoomNo FROM Students WHERE Status=0";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                SqlCommandBuilder bulder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                dg_left_students.DataSource = ds.Tables[0];
                con.Close();
            }
        }
        private void RefreshDataGridViews()
        {
            FillData1();
            FillData2();
        }
        private void FM_Students_Load(object sender, EventArgs e)
        {
            FillData1();
            FillData2();
            dg_student_list.CellClick += dg_student_list_CellClick;
            dg_left_students.CellClick += dg_left_students_CellClick;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dg_student_list_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e?.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell selectedCell = dg_student_list.Rows[e.RowIndex].Cells[e.ColumnIndex];
                string studentID = selectedCell.OwningRow.Cells["StudentID"].Value?.ToString() ?? "";

                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM Students WHERE StudentID = @studentID";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@studentID", studentID);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            tb_studentid.Text = reader["StudentID"].ToString();
                            tb_name.Text = reader["Name"].ToString();
                            tb_address.Text = reader["Address"].ToString();
                            tb_fathername.Text = reader["FatherName"].ToString();
                            tb_mothername.Text = reader["MotherName"].ToString();
                            tb_contact.Text = reader["Contact"].ToString();
                            tb_room_number.Text = reader["RoomNo"].ToString();
                        }
                    }
                    con.Close();
                }
            }
        }
        private void dg_left_students_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e?.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell selectedCell = dg_left_students.Rows[e.RowIndex].Cells[e.ColumnIndex];
                string studentID = selectedCell.OwningRow.Cells["StudentID"].Value?.ToString() ?? "";

                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM Students WHERE StudentID = @studentID";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@studentID", studentID);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            tb_studentid.Text = reader["StudentID"].ToString();
                            tb_name.Text = reader["Name"].ToString();
                            tb_address.Text = reader["Address"].ToString();
                            tb_fathername.Text = reader["FatherName"].ToString();
                            tb_mothername.Text = reader["MotherName"].ToString();
                            tb_contact.Text = reader["Contact"].ToString();
                            tb_room_number.Text = reader["RoomNo"].ToString();
                        }
                    }
                    con.Close();
                }
            }
        }


        private void btn_stu_update_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                try
                {
                    con.Open();
                    if (tb_studentid.Text == "")
                    {
                        MessageBox.Show("Please Enter The Details!");
                    }
                    else
                    {
                        int roomNumber = Convert.ToInt32(tb_room_number.Text);

                        if (!IsRoomAvailable(con, roomNumber))
                        {
                            MessageBox.Show("Selected room is not available. Please choose an available room.");
                            return;
                        }
                        int currentRoom = GetCurrentRoomNumber(con, tb_studentid.Text);

                        string query = "UPDATE Students SET Name = @name, Address = @address, FatherName = @fatherName, MotherName = @motherName, Contact = @contact, RoomNo = @RoomNo, Status = @Status WHERE StudentID = @studentid;" +
                                       "UPDATE Rooms SET BookedStatus = 0 WHERE RoomNo = @CurrentRoom;" +
                                       "UPDATE Rooms SET BookedStatus = 1 WHERE RoomNo = @RoomNo;";

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@name", tb_name.Text);
                            cmd.Parameters.AddWithValue("@address", tb_address.Text);
                            cmd.Parameters.AddWithValue("@fatherName", tb_fathername.Text);
                            cmd.Parameters.AddWithValue("@motherName", tb_mothername.Text);
                            cmd.Parameters.AddWithValue("@contact", tb_contact.Text);
                            cmd.Parameters.AddWithValue("@RoomNo", roomNumber);
                            cmd.Parameters.AddWithValue("@Status", 1);
                            cmd.Parameters.AddWithValue("@studentid", tb_studentid.Text);
                            cmd.Parameters.AddWithValue("@CurrentRoom", currentRoom);
                            cmd.ExecuteNonQuery();
                            RefreshDataGridViews();
                            MessageBox.Show("Student information updated successfully!");
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

        private int GetCurrentRoomNumber(SqlConnection con, string studentId)
        {
            string query = "SELECT RoomNo FROM Students WHERE StudentID = @studentId";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@studentId", studentId);
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    return Convert.ToInt32(result);
                }
                else
                {
                    return -1;
                }
            }
        }

        private void btn_stu_back_Click(object sender, EventArgs e)
        {
            FM_Main mf = new FM_Main();
            mf.Show();
            this.Close();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_stu_add_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                try
                {
                    con.Open();
                    if (tb_studentid.Text == "")
                    {
                        MessageBox.Show("Please Enter the Details!");
                    }
                    else
                    {
                        int enteredRoom;

                        if (int.TryParse(tb_room_number.Text, out enteredRoom))
                        {
                            if (IsRoomAvailable(con, enteredRoom))
                            {                               
                                int existingStatus = GetStudentStatus(con, tb_studentid.Text);

                                if (existingStatus == 0)
                                {                                   
                                    string updateQuery = "UPDATE Students SET " +
                                                        "Name = @name, Address = @address, " +
                                                        "FatherName = @fatherName, MotherName = @motherName, " +
                                                        "Contact = @contact, RoomNo = @RoomNo, Status = @Status " +
                                                        "WHERE StudentID = @studentid";

                                    using (SqlCommand updateCmd = new SqlCommand(updateQuery, con))
                                    {
                                        updateCmd.Parameters.AddWithValue("@name", tb_name.Text);
                                        updateCmd.Parameters.AddWithValue("@address", tb_address.Text);
                                        updateCmd.Parameters.AddWithValue("@fatherName", tb_fathername.Text);
                                        updateCmd.Parameters.AddWithValue("@motherName", tb_mothername.Text);
                                        updateCmd.Parameters.AddWithValue("@contact", tb_contact.Text);
                                        updateCmd.Parameters.AddWithValue("@RoomNo", enteredRoom);
                                        updateCmd.Parameters.AddWithValue("@Status", 1);
                                        updateCmd.Parameters.AddWithValue("@studentid", tb_studentid.Text);
                                        updateCmd.ExecuteNonQuery();
                                    }
                                }
                                else
                                {                                    
                                    string insertQuery = "INSERT INTO Students(StudentID, Name, Address, FatherName, MotherName, Contact, RoomNo, Status) " +
                                                         "VALUES (@studentid, @name, @address, @fatherName, @motherName, @contact, @RoomNo, @Status)";

                                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, con))
                                    {
                                        insertCmd.Parameters.AddWithValue("@studentid", tb_studentid.Text);
                                        insertCmd.Parameters.AddWithValue("@name", tb_name.Text);
                                        insertCmd.Parameters.AddWithValue("@address", tb_address.Text);
                                        insertCmd.Parameters.AddWithValue("@fatherName", tb_fathername.Text);
                                        insertCmd.Parameters.AddWithValue("@motherName", tb_mothername.Text);
                                        insertCmd.Parameters.AddWithValue("@contact", tb_contact.Text);
                                        insertCmd.Parameters.AddWithValue("@RoomNo", enteredRoom);
                                        insertCmd.Parameters.AddWithValue("@Status", 1);
                                        insertCmd.ExecuteNonQuery();
                                    }
                                }
                                                              
                                string updateRoomQuery = "UPDATE Rooms SET BookedStatus = 1 WHERE RoomNo = @RoomNo";

                                using (SqlCommand updateRoomCmd = new SqlCommand(updateRoomQuery, con))
                                {
                                    updateRoomCmd.Parameters.AddWithValue("@RoomNo", enteredRoom);
                                    updateRoomCmd.ExecuteNonQuery();
                                }

                                RefreshDataGridViews();
                                MessageBox.Show("Student information updated successfully!");
                            }
                            else
                            {
                                MessageBox.Show("Selected room is not available.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid room number.");
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
        private int GetStudentStatus(SqlConnection con, string studentId)
        {
            string query = "SELECT Status FROM Students WHERE StudentID = @studentid";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@studentid", studentId);
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    return Convert.ToInt32(result);
                }
                else
                {
                    return -1;
                }
            }
        }    


        private bool IsRoomAvailable(SqlConnection con, int roomNumber)
        {
            string query = "SELECT BookedStatus FROM Rooms WHERE RoomNo = @RoomNo";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@RoomNo", roomNumber);
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    return Convert.ToInt32(result) == 0;
                }
                else
                {
                    return false;
                }
            }
        }


        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_studentid.Text = string.Empty;
            tb_name.Text = string.Empty;
            tb_address.Text = string.Empty;
            tb_fathername.Text = string.Empty;
            tb_mothername.Text = string.Empty;
            tb_contact.Text = string.Empty;
            tb_room_number.Text = string.Empty;
        }

        private void btn_stu_delete_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                try
                {
                    con.Open();
                    if (tb_studentid.Text == "")
                    {
                        MessageBox.Show("Please select a student to delete!");
                    }
                    else
                    {
                        int studentId = Convert.ToInt32(tb_studentid.Text);                                 
                        int currentRoom = GetCurrentRoomNumber(con, studentId.ToString());
                                              
                        string query = "UPDATE Students SET Status = 0 WHERE StudentID = @studentid;" +
                                       "UPDATE Rooms SET BookedStatus = 0 WHERE RoomNo = @CurrentRoom;";

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@studentid", studentId);
                            cmd.Parameters.AddWithValue("@CurrentRoom", currentRoom);
                            cmd.ExecuteNonQuery();
                            RefreshDataGridViews();
                            MessageBox.Show("Student deleted successfully!");
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
    }
}
