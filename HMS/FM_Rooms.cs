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
    public partial class FM_Rooms : Form
    {
        string ConnectionString = "Data Source=ABHI-XTHA\\SQLEXPRESS;Initial Catalog=hostel__management_system;User ID=sa;Password=abhishek;Encrypt=False;";

        public FM_Rooms()
        {
            InitializeComponent();
        }
        void FillData1()
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                string query = "SELECT * FROM Rooms WHERE BookedStatus=0";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                SqlCommandBuilder bulder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                dg_rooms1.DataSource = ds.Tables[0];
                con.Close();
            }
        }
        void FillData2()
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                string query = "SELECT * FROM Rooms WHERE BookedStatus=1";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                SqlCommandBuilder bulder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                dg_rooms2.DataSource = ds.Tables[0];
                con.Close();
            }
        }
        private void RefreshDataGridViews()
        {
            FillData1();
            FillData2();
        }
             

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Rooms_Load(object sender, EventArgs e)
        {
            FillData1();
            FillData2();
        }

        private void btn_stu_back_Click(object sender, EventArgs e)
        {
            FM_Main mf_rooms = new FM_Main();
            mf_rooms.Show();
            this.Hide();
        }

        private void btn_rooms_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_stu_add_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                try
                {
                    con.Open();

                    int cb_status = (cb_room_status.Text == "Available") ? 0 : 1;

                    if (tb_room_number.Text == "")
                    {
                        MessageBox.Show("Please Enter a Room Number!");
                    }
                    else
                    {
                        string query = "INSERT INTO Rooms(RoomNo, BookedStatus) VALUES (@RoomNo, @BookedStatus)";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@RoomNo", tb_room_number.Text);
                            cmd.Parameters.AddWithValue("@BookedStatus", cb_status);

                            cmd.ExecuteNonQuery();
                            RefreshDataGridViews();
                            MessageBox.Show("Room added successfully!");
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

        private void btn_rooms_delete_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                try
                {
                    con.Open();
                    if (tb_room_number.Text == "")
                    {
                        MessageBox.Show("Please Enter a Room Number!");
                    }
                    else
                    {
                        string query = "DELETE FROM Rooms WHERE RoomNo=@RoomNo";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@RoomNo", tb_room_number.Text);
                            cmd.ExecuteNonQuery();
                            RefreshDataGridViews();
                            MessageBox.Show("Room Deleted successfully!");

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

        private void btn_rooms_update_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                try
                {
                    con.Open();

                    int cb_status = (cb_room_status.Text == "Available") ? 0 : 1;

                    if (tb_room_number.Text == "")
                    {
                        MessageBox.Show("Please Enter a Room Number!");
                    }
                    else
                    {
                        string query = "UPDATE Rooms SET BookedStatus=@BookedStatus WHERE RoomNo=@RoomNo";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@RoomNo", tb_room_number.Text);
                            cmd.Parameters.AddWithValue("@BookedStatus", cb_status);
                            cmd.ExecuteNonQuery();
                            RefreshDataGridViews();
                            MessageBox.Show("Room Status Updated successfully!");

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

        private void dg_rooms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbl_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
