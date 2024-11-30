namespace HMS
{
    partial class FM_Students
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btn_close = new Button();
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            dg_student_list = new DataGridView();
            label3 = new Label();
            tb_name = new TextBox();
            label6 = new Label();
            tb_studentid = new TextBox();
            label7 = new Label();
            tb_address = new TextBox();
            label8 = new Label();
            tb_contact = new TextBox();
            label9 = new Label();
            tb_room_number = new TextBox();
            panel3 = new Panel();
            label11 = new Label();
            label12 = new Label();
            btn_stu_add = new Button();
            btn_stu_delete = new Button();
            btn_stu_back = new Button();
            btn_stu_update = new Button();
            pictureBox1 = new PictureBox();
            tb_fathername = new TextBox();
            label4 = new Label();
            tb_mothername = new TextBox();
            label5 = new Label();
            btn_clear = new Button();
            dg_left_students = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dg_student_list).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dg_left_students).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Crimson;
            panel1.Controls.Add(btn_close);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1128, 171);
            panel1.TabIndex = 0;
            // 
            // btn_close
            // 
            btn_close.BackColor = Color.Transparent;
            btn_close.ForeColor = SystemColors.ActiveCaptionText;
            btn_close.Location = new Point(1013, 0);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(112, 34);
            btn_close.TabIndex = 1;
            btn_close.Text = "X";
            btn_close.UseVisualStyleBackColor = false;
            btn_close.Click += btn_close_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Agency FB", 28F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(384, 68);
            label2.Name = "label2";
            label2.Size = new Size(383, 67);
            label2.TabIndex = 0;
            label2.Text = "Student Information";
            label2.Click += label2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkBlue;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(2, 170);
            panel2.Name = "panel2";
            panel2.Size = new Size(1128, 50);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // dg_student_list
            // 
            dg_student_list.AllowUserToAddRows = false;
            dg_student_list.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Agency FB", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dg_student_list.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dg_student_list.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_student_list.Location = new Point(558, 283);
            dg_student_list.Name = "dg_student_list";
            dg_student_list.ReadOnly = true;
            dg_student_list.RowHeadersWidth = 62;
            dg_student_list.Size = new Size(515, 304);
            dg_student_list.TabIndex = 2;
            dg_student_list.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Agency FB", 14F);
            label3.Location = new Point(117, 368);
            label3.Name = "label3";
            label3.Size = new Size(62, 33);
            label3.TabIndex = 3;
            label3.Text = "Name";
            // 
            // tb_name
            // 
            tb_name.Font = new Font("Agency FB", 14F);
            tb_name.Location = new Point(195, 365);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(238, 41);
            tb_name.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Agency FB", 14F);
            label6.Location = new Point(83, 308);
            label6.Name = "label6";
            label6.Size = new Size(96, 33);
            label6.TabIndex = 3;
            label6.Text = "Student ID";
            // 
            // tb_studentid
            // 
            tb_studentid.Font = new Font("Agency FB", 14F);
            tb_studentid.Location = new Point(195, 305);
            tb_studentid.Name = "tb_studentid";
            tb_studentid.Size = new Size(238, 41);
            tb_studentid.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Agency FB", 14F);
            label7.Location = new Point(95, 554);
            label7.Name = "label7";
            label7.Size = new Size(84, 33);
            label7.TabIndex = 3;
            label7.Text = "Address";
            // 
            // tb_address
            // 
            tb_address.Font = new Font("Agency FB", 14F);
            tb_address.Location = new Point(195, 546);
            tb_address.Name = "tb_address";
            tb_address.Size = new Size(238, 41);
            tb_address.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Agency FB", 14F);
            label8.Location = new Point(100, 617);
            label8.Name = "label8";
            label8.Size = new Size(76, 33);
            label8.TabIndex = 3;
            label8.Text = "Contact";
            // 
            // tb_contact
            // 
            tb_contact.Font = new Font("Agency FB", 14F);
            tb_contact.Location = new Point(195, 609);
            tb_contact.Name = "tb_contact";
            tb_contact.Size = new Size(238, 41);
            tb_contact.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Agency FB", 14F);
            label9.Location = new Point(46, 678);
            label9.Name = "label9";
            label9.Size = new Size(133, 33);
            label9.TabIndex = 3;
            label9.Text = "Room Number";
            // 
            // tb_room_number
            // 
            tb_room_number.Font = new Font("Agency FB", 14F);
            tb_room_number.Location = new Point(195, 670);
            tb_room_number.Name = "tb_room_number";
            tb_room_number.Size = new Size(238, 41);
            tb_room_number.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Crimson;
            panel3.Controls.Add(label11);
            panel3.Location = new Point(2, 990);
            panel3.Name = "panel3";
            panel3.Size = new Size(1128, 51);
            panel3.TabIndex = 5;
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
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Agency FB", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(756, 247);
            label12.Name = "label12";
            label12.Size = new Size(108, 33);
            label12.TabIndex = 6;
            label12.Text = "Student List";
            // 
            // btn_stu_add
            // 
            btn_stu_add.BackColor = Color.Chartreuse;
            btn_stu_add.Font = new Font("Agency FB", 14F);
            btn_stu_add.Location = new Point(219, 822);
            btn_stu_add.Name = "btn_stu_add";
            btn_stu_add.Size = new Size(123, 62);
            btn_stu_add.TabIndex = 7;
            btn_stu_add.Text = "ADD";
            btn_stu_add.UseVisualStyleBackColor = false;
            btn_stu_add.Click += btn_stu_add_Click;
            // 
            // btn_stu_delete
            // 
            btn_stu_delete.BackColor = Color.Coral;
            btn_stu_delete.Font = new Font("Agency FB", 14F);
            btn_stu_delete.Location = new Point(363, 822);
            btn_stu_delete.Name = "btn_stu_delete";
            btn_stu_delete.Size = new Size(135, 62);
            btn_stu_delete.TabIndex = 7;
            btn_stu_delete.Text = "DELETE";
            btn_stu_delete.UseVisualStyleBackColor = false;
            btn_stu_delete.Click += btn_stu_delete_Click;
            // 
            // btn_stu_back
            // 
            btn_stu_back.BackColor = Color.SkyBlue;
            btn_stu_back.Font = new Font("Agency FB", 14F);
            btn_stu_back.Location = new Point(219, 905);
            btn_stu_back.Name = "btn_stu_back";
            btn_stu_back.Size = new Size(123, 60);
            btn_stu_back.TabIndex = 7;
            btn_stu_back.Text = "BACK";
            btn_stu_back.UseVisualStyleBackColor = false;
            btn_stu_back.Click += btn_stu_back_Click;
            // 
            // btn_stu_update
            // 
            btn_stu_update.BackColor = Color.LemonChiffon;
            btn_stu_update.Font = new Font("Agency FB", 14F);
            btn_stu_update.Location = new Point(76, 822);
            btn_stu_update.Name = "btn_stu_update";
            btn_stu_update.Size = new Size(123, 62);
            btn_stu_update.TabIndex = 7;
            btn_stu_update.Text = "UPDATE";
            btn_stu_update.UseVisualStyleBackColor = false;
            btn_stu_update.Click += btn_stu_update_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(2, 212);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1133, 772);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // tb_fathername
            // 
            tb_fathername.Font = new Font("Agency FB", 14F);
            tb_fathername.Location = new Point(195, 425);
            tb_fathername.Name = "tb_fathername";
            tb_fathername.Size = new Size(238, 41);
            tb_fathername.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Agency FB", 14F);
            label4.Location = new Point(46, 433);
            label4.Name = "label4";
            label4.Size = new Size(134, 33);
            label4.TabIndex = 10;
            label4.Text = "Father's Name";
            // 
            // tb_mothername
            // 
            tb_mothername.Font = new Font("Agency FB", 14F);
            tb_mothername.Location = new Point(195, 487);
            tb_mothername.Name = "tb_mothername";
            tb_mothername.Size = new Size(238, 41);
            tb_mothername.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Agency FB", 14F);
            label5.Location = new Point(40, 495);
            label5.Name = "label5";
            label5.Size = new Size(139, 33);
            label5.TabIndex = 12;
            label5.Text = "Mother's Name";
            // 
            // btn_clear
            // 
            btn_clear.BackColor = Color.Ivory;
            btn_clear.Font = new Font("Agency FB", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_clear.ForeColor = SystemColors.MenuHighlight;
            btn_clear.Location = new Point(219, 747);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(123, 42);
            btn_clear.TabIndex = 14;
            btn_clear.Text = "Clear All";
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += btn_clear_Click;
            // 
            // dg_left_students
            // 
            dg_left_students.AllowUserToAddRows = false;
            dg_left_students.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Agency FB", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dg_left_students.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dg_left_students.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_left_students.Location = new Point(558, 617);
            dg_left_students.Name = "dg_left_students";
            dg_left_students.ReadOnly = true;
            dg_left_students.RowHeadersWidth = 62;
            dg_left_students.Size = new Size(515, 304);
            dg_left_students.TabIndex = 2;
            dg_left_students.CellContentClick += dataGridView1_CellContentClick;
            // 
            // FM_Students
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1126, 1040);
            Controls.Add(btn_clear);
            Controls.Add(tb_mothername);
            Controls.Add(label5);
            Controls.Add(tb_fathername);
            Controls.Add(label4);
            Controls.Add(btn_stu_back);
            Controls.Add(btn_stu_delete);
            Controls.Add(btn_stu_update);
            Controls.Add(btn_stu_add);
            Controls.Add(label12);
            Controls.Add(panel3);
            Controls.Add(tb_room_number);
            Controls.Add(label9);
            Controls.Add(tb_contact);
            Controls.Add(label8);
            Controls.Add(tb_address);
            Controls.Add(label7);
            Controls.Add(tb_studentid);
            Controls.Add(label6);
            Controls.Add(tb_name);
            Controls.Add(label3);
            Controls.Add(dg_left_students);
            Controls.Add(dg_student_list);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FM_Students";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FM_Students";
            Load += FM_Students_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dg_student_list).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dg_left_students).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Panel panel2;
        private Label label1;
        private DataGridView dg_student_list;
        private Label label3;
        private TextBox tb_name;
        private Label label6;
        private TextBox tb_studentid;
        private Label label7;
        private TextBox tb_address;
        private Label label8;
        private TextBox tb_contact;
        private Label label9;
        private TextBox tb_room_number;
        private Panel panel3;
        private Label label11;
        private Label label12;
        private Button btn_stu_add;
        private Button btn_stu_delete;
        private Button btn_stu_back;
        private Button btn_close;
        private Button btn_stu_update;
        private PictureBox pictureBox1;
        private TextBox tb_fathername;
        private Label label4;
        private TextBox tb_mothername;
        private Label label5;
        private Button btn_clear;
        private DataGridView dg_left_students;
    }
}