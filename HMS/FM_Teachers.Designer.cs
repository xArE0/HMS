
namespace HMS
{
    partial class FM_Teachers
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel2 = new Panel();
            panel1 = new Panel();
            btn_teachers_close = new Button();
            lbl_hms = new Label();
            label11 = new Label();
            panel3 = new Panel();
            btn_teach_back = new Button();
            btn_teach_delete = new Button();
            btn_teach_update = new Button();
            btn_teach_add = new Button();
            tb_teacherid = new TextBox();
            label7 = new Label();
            label8 = new Label();
            tb_name = new TextBox();
            label9 = new Label();
            tb_address = new TextBox();
            label10 = new Label();
            tb_contact = new TextBox();
            label12 = new Label();
            tb_position = new TextBox();
            label13 = new Label();
            tb_status = new TextBox();
            dg_teach2 = new DataGridView();
            dg_teach1 = new DataGridView();
            cb_left_teach = new CheckBox();
            lbl_ct = new Label();
            lbl_pt = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dg_teach2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dg_teach1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkBlue;
            panel2.Location = new Point(-4, 200);
            panel2.Name = "panel2";
            panel2.Size = new Size(1131, 38);
            panel2.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Crimson;
            panel1.Controls.Add(btn_teachers_close);
            panel1.Controls.Add(lbl_hms);
            panel1.Location = new Point(-5, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1132, 210);
            panel1.TabIndex = 2;
            // 
            // btn_teachers_close
            // 
            btn_teachers_close.BackColor = Color.Transparent;
            btn_teachers_close.ForeColor = SystemColors.ActiveCaptionText;
            btn_teachers_close.Location = new Point(1014, 0);
            btn_teachers_close.Name = "btn_teachers_close";
            btn_teachers_close.Size = new Size(112, 34);
            btn_teachers_close.TabIndex = 2;
            btn_teachers_close.Text = "X";
            btn_teachers_close.UseVisualStyleBackColor = false;
            btn_teachers_close.Click += btn_teachers_close_Click;
            // 
            // lbl_hms
            // 
            lbl_hms.AutoSize = true;
            lbl_hms.Font = new Font("Agency FB", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_hms.Location = new Point(237, 55);
            lbl_hms.Name = "lbl_hms";
            lbl_hms.Size = new Size(692, 116);
            lbl_hms.TabIndex = 0;
            lbl_hms.Text = "Teachers Information";
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
            panel3.TabIndex = 14;
            // 
            // btn_teach_back
            // 
            btn_teach_back.BackColor = Color.SkyBlue;
            btn_teach_back.Font = new Font("Agency FB", 14F);
            btn_teach_back.Location = new Point(281, 905);
            btn_teach_back.Name = "btn_teach_back";
            btn_teach_back.Size = new Size(123, 60);
            btn_teach_back.TabIndex = 17;
            btn_teach_back.Text = "BACK";
            btn_teach_back.UseVisualStyleBackColor = false;
            btn_teach_back.Click += btn_teach_back_Click;
            // 
            // btn_teach_delete
            // 
            btn_teach_delete.BackColor = Color.Coral;
            btn_teach_delete.Font = new Font("Agency FB", 14F);
            btn_teach_delete.Location = new Point(425, 822);
            btn_teach_delete.Name = "btn_teach_delete";
            btn_teach_delete.Size = new Size(135, 62);
            btn_teach_delete.TabIndex = 18;
            btn_teach_delete.Text = "DELETE";
            btn_teach_delete.UseVisualStyleBackColor = false;
            btn_teach_delete.Click += btn_teach_delete_Click;
            // 
            // btn_teach_update
            // 
            btn_teach_update.BackColor = Color.LemonChiffon;
            btn_teach_update.Font = new Font("Agency FB", 14F);
            btn_teach_update.Location = new Point(138, 822);
            btn_teach_update.Name = "btn_teach_update";
            btn_teach_update.Size = new Size(123, 62);
            btn_teach_update.TabIndex = 19;
            btn_teach_update.Text = "UPDATE";
            btn_teach_update.UseVisualStyleBackColor = false;
            btn_teach_update.Click += btn_teach_update_Click_1;
            // 
            // btn_teach_add
            // 
            btn_teach_add.BackColor = Color.Chartreuse;
            btn_teach_add.Font = new Font("Agency FB", 14F);
            btn_teach_add.Location = new Point(281, 822);
            btn_teach_add.Name = "btn_teach_add";
            btn_teach_add.Size = new Size(123, 62);
            btn_teach_add.TabIndex = 20;
            btn_teach_add.Text = "ADD";
            btn_teach_add.UseVisualStyleBackColor = false;
            btn_teach_add.Click += btn_teach_add_Click;
            // 
            // tb_teacherid
            // 
            tb_teacherid.Font = new Font("Agency FB", 14F);
            tb_teacherid.Location = new Point(196, 296);
            tb_teacherid.Name = "tb_teacherid";
            tb_teacherid.Size = new Size(238, 41);
            tb_teacherid.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Agency FB", 14F);
            label7.Location = new Point(61, 304);
            label7.Name = "label7";
            label7.Size = new Size(102, 33);
            label7.TabIndex = 21;
            label7.Text = "Teacher ID";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Agency FB", 14F);
            label8.Location = new Point(101, 382);
            label8.Name = "label8";
            label8.Size = new Size(62, 33);
            label8.TabIndex = 21;
            label8.Text = "Name";
            // 
            // tb_name
            // 
            tb_name.Font = new Font("Agency FB", 14F);
            tb_name.Location = new Point(196, 374);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(238, 41);
            tb_name.TabIndex = 22;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Agency FB", 14F);
            label9.Location = new Point(79, 464);
            label9.Name = "label9";
            label9.Size = new Size(84, 33);
            label9.TabIndex = 21;
            label9.Text = "Address";
            // 
            // tb_address
            // 
            tb_address.Font = new Font("Agency FB", 14F);
            tb_address.Location = new Point(196, 456);
            tb_address.Name = "tb_address";
            tb_address.Size = new Size(238, 41);
            tb_address.TabIndex = 22;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Agency FB", 14F);
            label10.Location = new Point(87, 552);
            label10.Name = "label10";
            label10.Size = new Size(76, 33);
            label10.TabIndex = 21;
            label10.Text = "Contact";
            // 
            // tb_contact
            // 
            tb_contact.Font = new Font("Agency FB", 14F);
            tb_contact.Location = new Point(196, 544);
            tb_contact.Name = "tb_contact";
            tb_contact.Size = new Size(238, 41);
            tb_contact.TabIndex = 22;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Agency FB", 14F);
            label12.Location = new Point(84, 638);
            label12.Name = "label12";
            label12.Size = new Size(79, 33);
            label12.TabIndex = 21;
            label12.Text = "Position";
            // 
            // tb_position
            // 
            tb_position.Font = new Font("Agency FB", 14F);
            tb_position.Location = new Point(196, 630);
            tb_position.Name = "tb_position";
            tb_position.Size = new Size(238, 41);
            tb_position.TabIndex = 22;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Agency FB", 14F);
            label13.Location = new Point(97, 725);
            label13.Name = "label13";
            label13.Size = new Size(66, 33);
            label13.TabIndex = 21;
            label13.Text = "Status";
            // 
            // tb_status
            // 
            tb_status.Font = new Font("Agency FB", 14F);
            tb_status.Location = new Point(196, 717);
            tb_status.Name = "tb_status";
            tb_status.Size = new Size(238, 41);
            tb_status.TabIndex = 22;
            tb_status.TextChanged += tb_status_TextChanged;
            // 
            // dg_teach2
            // 
            dg_teach2.AllowUserToAddRows = false;
            dg_teach2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Agency FB", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dg_teach2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dg_teach2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_teach2.Location = new Point(575, 327);
            dg_teach2.Name = "dg_teach2";
            dg_teach2.ReadOnly = true;
            dg_teach2.RowHeadersWidth = 62;
            dg_teach2.Size = new Size(515, 531);
            dg_teach2.TabIndex = 24;
            // 
            // dg_teach1
            // 
            dg_teach1.AllowUserToAddRows = false;
            dg_teach1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Agency FB", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dg_teach1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dg_teach1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_teach1.Location = new Point(575, 327);
            dg_teach1.Name = "dg_teach1";
            dg_teach1.ReadOnly = true;
            dg_teach1.RowHeadersWidth = 62;
            dg_teach1.Size = new Size(515, 531);
            dg_teach1.TabIndex = 24;
            dg_teach1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // cb_left_teach
            // 
            cb_left_teach.AutoSize = true;
            cb_left_teach.Location = new Point(754, 875);
            cb_left_teach.Name = "cb_left_teach";
            cb_left_teach.Size = new Size(190, 29);
            cb_left_teach.TabIndex = 25;
            cb_left_teach.Text = "Show Past Teachers";
            cb_left_teach.UseVisualStyleBackColor = true;
            cb_left_teach.CheckedChanged += cb_left_teach_CheckedChanged;
            // 
            // lbl_ct
            // 
            lbl_ct.AutoSize = true;
            lbl_ct.Font = new Font("Agency FB", 14F);
            lbl_ct.Location = new Point(736, 281);
            lbl_ct.Name = "lbl_ct";
            lbl_ct.Size = new Size(161, 33);
            lbl_ct.TabIndex = 21;
            lbl_ct.Text = "Current Teachers";
            // 
            // lbl_pt
            // 
            lbl_pt.AutoSize = true;
            lbl_pt.Font = new Font("Agency FB", 14F);
            lbl_pt.Location = new Point(754, 281);
            lbl_pt.Name = "lbl_pt";
            lbl_pt.Size = new Size(133, 33);
            lbl_pt.TabIndex = 21;
            lbl_pt.Text = "Past Teachers";
            lbl_pt.Click += lbl_pt_Click;
            // 
            // FM_Teachers
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1126, 1040);
            Controls.Add(cb_left_teach);
            Controls.Add(dg_teach1);
            Controls.Add(dg_teach2);
            Controls.Add(tb_status);
            Controls.Add(label13);
            Controls.Add(tb_position);
            Controls.Add(label12);
            Controls.Add(tb_contact);
            Controls.Add(label10);
            Controls.Add(tb_address);
            Controls.Add(label9);
            Controls.Add(tb_name);
            Controls.Add(label8);
            Controls.Add(tb_teacherid);
            Controls.Add(lbl_pt);
            Controls.Add(lbl_ct);
            Controls.Add(label7);
            Controls.Add(btn_teach_back);
            Controls.Add(btn_teach_delete);
            Controls.Add(btn_teach_update);
            Controls.Add(btn_teach_add);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FM_Teachers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FM_Teachers";
            Load += FM_Teachers_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dg_teach2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dg_teach1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void FM_Teachers_Load(object sender, EventArgs e)
        {
            FillData1();
            FillData2();
            dg_teach1.CellClick += dg_teach1_CellClick;
            dg_teach2.CellClick += dg_teach2_CellClick;
            lbl_pt.Hide();
        }


        #endregion

        private Panel panel2;
        private Panel panel1;
        private Button btn_teachers_close;
        private Label lbl_hms;
        private Label label11;
        private Panel panel3;
        private Button btn_teach_back;
        private Button btn_teach_delete;
        private Button btn_teach_update;
        private Button btn_teach_add;
        private TextBox tb_teacherid;
        private Label label7;
        private Label label8;
        private TextBox tb_name;
        private Label label9;
        private TextBox tb_address;
        private Label label10;
        private TextBox tb_contact;
        private Label label12;
        private TextBox tb_position;
        private Label label13;
        private TextBox tb_status;
        private DataGridView dg_teach2;
        private DataGridView dg_teach1;
        private CheckBox cb_left_teach;
        private Label lbl_ct;
        private Label lbl_pt;
    }
}