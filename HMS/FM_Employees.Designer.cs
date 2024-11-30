namespace HMS
{
    partial class FM_Employees
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
            btn_close = new Button();
            label2 = new Label();
            label11 = new Label();
            panel1 = new Panel();
            btn_emp_close = new Button();
            label1 = new Label();
            panel3 = new Panel();
            label3 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            dg_emp2 = new DataGridView();
            btn_emp_update = new Button();
            btn_emp_add = new Button();
            btn_emp_delete = new Button();
            btn_emp_back = new Button();
            label5 = new Label();
            tb_empid = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label10 = new Label();
            tb_name = new TextBox();
            tb_address = new TextBox();
            tb_status = new TextBox();
            tb_contact = new TextBox();
            dg_emp1 = new DataGridView();
            cb_past_emp = new CheckBox();
            lbl_present_emp = new Label();
            lbl_past_emp = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dg_emp2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dg_emp1).BeginInit();
            SuspendLayout();
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
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Agency FB", 28F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(384, 68);
            label2.Name = "label2";
            label2.Size = new Size(437, 67);
            label2.TabIndex = 0;
            label2.Text = "Employees Information";
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
            // panel1
            // 
            panel1.BackColor = Color.Crimson;
            panel1.Controls.Add(btn_emp_close);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1128, 171);
            panel1.TabIndex = 13;
            panel1.Paint += panel1_Paint;
            // 
            // btn_emp_close
            // 
            btn_emp_close.BackColor = Color.Transparent;
            btn_emp_close.ForeColor = SystemColors.ActiveCaptionText;
            btn_emp_close.Location = new Point(1013, 0);
            btn_emp_close.Name = "btn_emp_close";
            btn_emp_close.Size = new Size(112, 34);
            btn_emp_close.TabIndex = 1;
            btn_emp_close.Text = "X";
            btn_emp_close.UseVisualStyleBackColor = false;
            btn_emp_close.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Agency FB", 28F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(384, 68);
            label1.Name = "label1";
            label1.Size = new Size(437, 67);
            label1.TabIndex = 0;
            label1.Text = "Employees Information";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Crimson;
            panel3.Controls.Add(label3);
            panel3.Location = new Point(-1, 989);
            panel3.Name = "panel3";
            panel3.Size = new Size(1128, 51);
            panel3.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Agency FB", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(436, 8);
            label3.Name = "label3";
            label3.Size = new Size(237, 33);
            label3.TabIndex = 3;
            label3.Text = "Avishek Shrestha (021-313)";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkBlue;
            panel2.Controls.Add(label4);
            panel2.Location = new Point(-1, 169);
            panel2.Name = "panel2";
            panel2.Size = new Size(1128, 50);
            panel2.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(59, 25);
            label4.TabIndex = 0;
            label4.Text = "label1";
            // 
            // dg_emp2
            // 
            dg_emp2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_emp2.Location = new Point(529, 274);
            dg_emp2.Name = "dg_emp2";
            dg_emp2.RowHeadersWidth = 62;
            dg_emp2.Size = new Size(535, 553);
            dg_emp2.TabIndex = 17;
            dg_emp2.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btn_emp_update
            // 
            btn_emp_update.BackColor = Color.LemonChiffon;
            btn_emp_update.Font = new Font("Agency FB", 14F);
            btn_emp_update.Location = new Point(62, 804);
            btn_emp_update.Name = "btn_emp_update";
            btn_emp_update.Size = new Size(123, 62);
            btn_emp_update.TabIndex = 27;
            btn_emp_update.Text = "UPDATE";
            btn_emp_update.UseVisualStyleBackColor = false;
            btn_emp_update.Click += btn_emp_update_Click;
            // 
            // btn_emp_add
            // 
            btn_emp_add.BackColor = Color.Chartreuse;
            btn_emp_add.Font = new Font("Agency FB", 14F);
            btn_emp_add.Location = new Point(208, 804);
            btn_emp_add.Name = "btn_emp_add";
            btn_emp_add.Size = new Size(123, 62);
            btn_emp_add.TabIndex = 28;
            btn_emp_add.Text = "ADD";
            btn_emp_add.UseVisualStyleBackColor = false;
            btn_emp_add.Click += btn_emp_add_Click;
            // 
            // btn_emp_delete
            // 
            btn_emp_delete.BackColor = Color.Coral;
            btn_emp_delete.Font = new Font("Agency FB", 14F);
            btn_emp_delete.Location = new Point(355, 804);
            btn_emp_delete.Name = "btn_emp_delete";
            btn_emp_delete.Size = new Size(135, 62);
            btn_emp_delete.TabIndex = 26;
            btn_emp_delete.Text = "DELETE";
            btn_emp_delete.UseVisualStyleBackColor = false;
            btn_emp_delete.Click += btn_emp_delete_Click;
            // 
            // btn_emp_back
            // 
            btn_emp_back.BackColor = Color.SkyBlue;
            btn_emp_back.Font = new Font("Agency FB", 14F);
            btn_emp_back.Location = new Point(208, 893);
            btn_emp_back.Name = "btn_emp_back";
            btn_emp_back.Size = new Size(123, 60);
            btn_emp_back.TabIndex = 25;
            btn_emp_back.Text = "BACK";
            btn_emp_back.UseVisualStyleBackColor = false;
            btn_emp_back.Click += btn_emp_back_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Agency FB", 14F);
            label5.Location = new Point(32, 288);
            label5.Name = "label5";
            label5.Size = new Size(112, 33);
            label5.TabIndex = 29;
            label5.Text = "Employee ID";
            label5.Click += label5_Click;
            // 
            // tb_empid
            // 
            tb_empid.Font = new Font("Agency FB", 14F);
            tb_empid.Location = new Point(181, 285);
            tb_empid.Name = "tb_empid";
            tb_empid.Size = new Size(238, 41);
            tb_empid.TabIndex = 30;
            tb_empid.TextChanged += textBox1_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Agency FB", 14F);
            label6.Location = new Point(82, 367);
            label6.Name = "label6";
            label6.Size = new Size(62, 33);
            label6.TabIndex = 29;
            label6.Text = "Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Agency FB", 14F);
            label7.Location = new Point(60, 465);
            label7.Name = "label7";
            label7.Size = new Size(84, 33);
            label7.TabIndex = 29;
            label7.Text = "Address";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Agency FB", 14F);
            label8.Location = new Point(68, 553);
            label8.Name = "label8";
            label8.Size = new Size(76, 33);
            label8.TabIndex = 29;
            label8.Text = "Contact";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Agency FB", 14F);
            label10.Location = new Point(78, 652);
            label10.Name = "label10";
            label10.Size = new Size(66, 33);
            label10.TabIndex = 29;
            label10.Text = "Status";
            // 
            // tb_name
            // 
            tb_name.Font = new Font("Agency FB", 14F);
            tb_name.Location = new Point(181, 367);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(238, 41);
            tb_name.TabIndex = 30;
            // 
            // tb_address
            // 
            tb_address.Font = new Font("Agency FB", 14F);
            tb_address.Location = new Point(181, 457);
            tb_address.Name = "tb_address";
            tb_address.Size = new Size(238, 41);
            tb_address.TabIndex = 30;
            // 
            // tb_status
            // 
            tb_status.Font = new Font("Agency FB", 14F);
            tb_status.Location = new Point(181, 644);
            tb_status.Name = "tb_status";
            tb_status.Size = new Size(238, 41);
            tb_status.TabIndex = 30;
            // 
            // tb_contact
            // 
            tb_contact.Font = new Font("Agency FB", 14F);
            tb_contact.Location = new Point(181, 553);
            tb_contact.Name = "tb_contact";
            tb_contact.Size = new Size(238, 41);
            tb_contact.TabIndex = 30;
            // 
            // dg_emp1
            // 
            dg_emp1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_emp1.Location = new Point(529, 274);
            dg_emp1.Name = "dg_emp1";
            dg_emp1.RowHeadersWidth = 62;
            dg_emp1.Size = new Size(535, 553);
            dg_emp1.TabIndex = 17;
            dg_emp1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // cb_past_emp
            // 
            cb_past_emp.AutoSize = true;
            cb_past_emp.Location = new Point(672, 865);
            cb_past_emp.Name = "cb_past_emp";
            cb_past_emp.Size = new Size(212, 29);
            cb_past_emp.TabIndex = 31;
            cb_past_emp.Text = "Show past Employees";
            cb_past_emp.UseVisualStyleBackColor = true;
            cb_past_emp.CheckedChanged += cb_past_emp_CheckedChanged;
            // 
            // lbl_present_emp
            // 
            lbl_present_emp.AutoSize = true;
            lbl_present_emp.Font = new Font("Agency FB", 14F);
            lbl_present_emp.Location = new Point(688, 238);
            lbl_present_emp.Name = "lbl_present_emp";
            lbl_present_emp.Size = new Size(171, 33);
            lbl_present_emp.TabIndex = 29;
            lbl_present_emp.Text = "Current Employees";
            // 
            // lbl_past_emp
            // 
            lbl_past_emp.AutoSize = true;
            lbl_past_emp.Font = new Font("Agency FB", 14F);
            lbl_past_emp.Location = new Point(716, 238);
            lbl_past_emp.Name = "lbl_past_emp";
            lbl_past_emp.Size = new Size(143, 33);
            lbl_past_emp.TabIndex = 29;
            lbl_past_emp.Text = "Past Employees";
            // 
            // FM_Employees
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1126, 1040);
            Controls.Add(cb_past_emp);
            Controls.Add(tb_contact);
            Controls.Add(tb_status);
            Controls.Add(tb_address);
            Controls.Add(tb_name);
            Controls.Add(tb_empid);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(lbl_past_emp);
            Controls.Add(lbl_present_emp);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btn_emp_back);
            Controls.Add(btn_emp_delete);
            Controls.Add(btn_emp_update);
            Controls.Add(btn_emp_add);
            Controls.Add(dg_emp1);
            Controls.Add(dg_emp2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FM_Employees";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FM_Employees";
            Load += FM_Employees_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dg_emp2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dg_emp1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void FM_Employees_Load(object sender, EventArgs e)
        {
            FillData1();
            FillData2();
            dg_emp1.CellClick += dg_emp1_CellClick;
            dg_emp2.CellClick += dg_emp2_CellClick;
            lbl_past_emp.Hide();
        }
        #endregion
        private Button btn_close;
        private Label label2;
        private Label label11;
        private Panel panel1;
        private Button btn_emp_close;
        private Label label1;
        private Panel panel3;
        private Label label3;
        private Panel panel2;
        private Label label4;
        private DataGridView dg_emp2;
        private Button btn_emp_update;
        private Button btn_emp_add;
        private Button btn_emp_delete;
        private Button btn_emp_back;
        private Label label5;
        private TextBox tb_empid;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label10;
        private TextBox tb_name;
        private TextBox tb_address;
        private TextBox tb_status;
        private TextBox tb_contact;
        private DataGridView dg_emp1;
        private CheckBox cb_past_emp;
        private Label lbl_present_emp;
        private Label lbl_past_emp;
    }
}