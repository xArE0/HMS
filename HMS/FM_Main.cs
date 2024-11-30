using System.Data.SqlClient;

namespace HMS
{
    public partial class FM_Main : Form
    {
        string ConnectionString = "Data Source=ABHI-XTHA\\SQLEXPRESS;Initial Catalog=hostel__management_system;User ID=sa;Password=abhishek;Encrypt=False;";
        public FM_Main()
        {
            InitializeComponent();
        }

        private void btn_rooms_Click(object sender, EventArgs e)
        {
            FM_Rooms rf = new FM_Rooms();
            rf.Show();
            this.Hide();
        }

        private void btn_students_Click(object sender, EventArgs e)
        {
            FM_Students fs = new FM_Students();
            fs.Show();
            this.Hide();
        }
        private void btn_employees_Click(object sender, EventArgs e)
        {
            FM_Employees fe = new FM_Employees();
            fe.Show();
            this.Hide();
        }

        private void btn_main_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_teachers_Click(object sender, EventArgs e)
        {
            FM_Teachers ft = new FM_Teachers();
            ft.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FM_Main_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                try
                {
                    con.Open();

                    string query = @"
                    SELECT
                    (SELECT COUNT(*) FROM Students WHERE Status = 1) AS TotalStudents,
                    (SELECT COUNT(*) FROM Teachers WHERE Status = 1) AS TotalTeachers,
                    (SELECT COUNT(*) FROM Employees WHERE Status = 1) AS TotalEmployees,
                    (SELECT COUNT(*) FROM Rooms WHERE BookedStatus = 0) AS TotalRooms;
                    ";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            int totalStudents = Convert.ToInt32(reader["TotalStudents"]);
                            int totalTeachers = Convert.ToInt32(reader["TotalTeachers"]);
                            int totalEmployees = Convert.ToInt32(reader["TotalEmployees"]);
                            int totalRooms = Convert.ToInt32(reader["TotalRooms"]);
                            lbl_ts.Text = totalStudents.ToString();
                            lbl_tt.Text = totalTeachers.ToString();
                            lbl_te.Text = totalEmployees.ToString();
                            lbl_tr.Text = totalRooms.ToString();
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
