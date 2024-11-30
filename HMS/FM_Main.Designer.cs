namespace HMS
{
    partial class FM_Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FM_Main));
            panel1 = new Panel();
            btn_main_close = new Button();
            lbl_hms = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            btn_rooms = new Button();
            btn_students = new Button();
            btn_teachers = new Button();
            btn_employees = new Button();
            label11 = new Label();
            panel3 = new Panel();
            lbl_tr = new Label();
            lbl_te = new Label();
            lbl_ts = new Label();
            lbl_tt = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Crimson;
            panel1.Controls.Add(btn_main_close);
            panel1.Controls.Add(lbl_hms);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1132, 210);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btn_main_close
            // 
            btn_main_close.BackColor = Color.Transparent;
            btn_main_close.ForeColor = SystemColors.ActiveCaptionText;
            btn_main_close.Location = new Point(1014, 0);
            btn_main_close.Name = "btn_main_close";
            btn_main_close.Size = new Size(112, 34);
            btn_main_close.TabIndex = 2;
            btn_main_close.Text = "X";
            btn_main_close.UseVisualStyleBackColor = false;
            btn_main_close.Click += btn_main_close_Click;
            // 
            // lbl_hms
            // 
            lbl_hms.AutoSize = true;
            lbl_hms.Font = new Font("Agency FB", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_hms.Location = new Point(151, 48);
            lbl_hms.Name = "lbl_hms";
            lbl_hms.Size = new Size(887, 116);
            lbl_hms.TabIndex = 0;
            lbl_hms.Text = "Hostel Management System";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkBlue;
            panel2.Location = new Point(-3, 198);
            panel2.Name = "panel2";
            panel2.Size = new Size(1131, 38);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, 231);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1129, 764);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btn_rooms
            // 
            btn_rooms.BackColor = Color.MediumBlue;
            btn_rooms.Font = new Font("Agency FB", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_rooms.ForeColor = Color.White;
            btn_rooms.Location = new Point(134, 269);
            btn_rooms.Name = "btn_rooms";
            btn_rooms.Size = new Size(283, 149);
            btn_rooms.TabIndex = 3;
            btn_rooms.Text = "Rooms";
            btn_rooms.UseVisualStyleBackColor = false;
            btn_rooms.Click += btn_rooms_Click;
            // 
            // btn_students
            // 
            btn_students.BackColor = Color.MediumBlue;
            btn_students.Font = new Font("Agency FB", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_students.ForeColor = Color.White;
            btn_students.Location = new Point(134, 435);
            btn_students.Name = "btn_students";
            btn_students.Size = new Size(283, 149);
            btn_students.TabIndex = 3;
            btn_students.Text = "Students";
            btn_students.UseVisualStyleBackColor = false;
            btn_students.Click += btn_students_Click;
            // 
            // btn_teachers
            // 
            btn_teachers.BackColor = Color.MediumBlue;
            btn_teachers.Font = new Font("Agency FB", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_teachers.ForeColor = Color.White;
            btn_teachers.Location = new Point(134, 604);
            btn_teachers.Name = "btn_teachers";
            btn_teachers.Size = new Size(283, 149);
            btn_teachers.TabIndex = 3;
            btn_teachers.Text = "Teachers";
            btn_teachers.UseVisualStyleBackColor = false;
            btn_teachers.Click += btn_teachers_Click;
            // 
            // btn_employees
            // 
            btn_employees.BackColor = Color.MediumBlue;
            btn_employees.Font = new Font("Agency FB", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_employees.ForeColor = Color.White;
            btn_employees.Location = new Point(134, 774);
            btn_employees.Name = "btn_employees";
            btn_employees.Size = new Size(283, 149);
            btn_employees.TabIndex = 3;
            btn_employees.Text = "Employees";
            btn_employees.UseVisualStyleBackColor = false;
            btn_employees.Click += btn_employees_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Agency FB", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(436, 8);
            label11.Name = "label11";
            label11.Size = new Size(237, 33);
            label11.TabIndex = 3;
            label11.Text = "Avishek Shrestha (021-313)";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Crimson;
            panel3.Controls.Add(label11);
            panel3.Location = new Point(2, 990);
            panel3.Name = "panel3";
            panel3.Size = new Size(1128, 51);
            panel3.TabIndex = 13;
            // 
            // lbl_tr
            // 
            lbl_tr.AutoSize = true;
            lbl_tr.BackColor = SystemColors.MenuHighlight;
            lbl_tr.Font = new Font("Agency FB", 26F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_tr.Location = new Point(423, 315);
            lbl_tr.Name = "lbl_tr";
            lbl_tr.Size = new Size(219, 62);
            lbl_tr.TabIndex = 14;
            lbl_tr.Text = "Total Rooms";
            // 
            // lbl_te
            // 
            lbl_te.AutoSize = true;
            lbl_te.BackColor = SystemColors.MenuHighlight;
            lbl_te.Font = new Font("Agency FB", 26F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_te.Location = new Point(423, 810);
            lbl_te.Name = "lbl_te";
            lbl_te.Size = new Size(277, 62);
            lbl_te.TabIndex = 14;
            lbl_te.Text = "Total Employees";
            // 
            // lbl_ts
            // 
            lbl_ts.AutoSize = true;
            lbl_ts.BackColor = SystemColors.MenuHighlight;
            lbl_ts.Font = new Font("Agency FB", 26F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_ts.Location = new Point(423, 480);
            lbl_ts.Name = "lbl_ts";
            lbl_ts.Size = new Size(248, 62);
            lbl_ts.TabIndex = 14;
            lbl_ts.Text = "Total Students";
            // 
            // lbl_tt
            // 
            lbl_tt.AutoSize = true;
            lbl_tt.BackColor = SystemColors.MenuHighlight;
            lbl_tt.Font = new Font("Agency FB", 26F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_tt.Location = new Point(423, 649);
            lbl_tt.Name = "lbl_tt";
            lbl_tt.Size = new Size(256, 62);
            lbl_tt.TabIndex = 14;
            lbl_tt.Text = "Total Teachers";
            // 
            // FM_Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1126, 1040);
            Controls.Add(lbl_tt);
            Controls.Add(lbl_ts);
            Controls.Add(lbl_te);
            Controls.Add(lbl_tr);
            Controls.Add(panel3);
            Controls.Add(btn_employees);
            Controls.Add(btn_teachers);
            Controls.Add(btn_students);
            Controls.Add(btn_rooms);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FM_Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hostel Management System";
            Load += FM_Main_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lbl_hms;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button btn_rooms;
        private Button btn_students;
        private Button btn_teachers;
        private Button btn_employees;
        private Label label11;
        private Panel panel3;
        private Button btn_main_close;
        private Label lbl_tr;
        private Label lbl_te;
        private Label lbl_ts;
        private Label lbl_tt;
    }
}
