namespace HMS
{
    partial class FM_Rooms
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
            panel1 = new Panel();
            btn_rooms_close = new Button();
            label1 = new Label();
            label2 = new Label();
            tb_room_number = new TextBox();
            label3 = new Label();
            panel2 = new Panel();
            dg_rooms1 = new DataGridView();
            btn_rooms_back = new Button();
            btn_rooms_delete = new Button();
            btn_rooms_update = new Button();
            btn_rooms_add = new Button();
            panel3 = new Panel();
            label11 = new Label();
            cb_room_status = new ComboBox();
            dg_rooms2 = new DataGridView();
            lbl = new Label();
            label5 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dg_rooms1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dg_rooms2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Crimson;
            panel1.Controls.Add(btn_rooms_close);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, -8);
            panel1.Name = "panel1";
            panel1.Size = new Size(1126, 196);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btn_rooms_close
            // 
            btn_rooms_close.BackColor = Color.Transparent;
            btn_rooms_close.ForeColor = SystemColors.ActiveCaptionText;
            btn_rooms_close.Location = new Point(1012, 7);
            btn_rooms_close.Name = "btn_rooms_close";
            btn_rooms_close.Size = new Size(112, 34);
            btn_rooms_close.TabIndex = 3;
            btn_rooms_close.Text = "X";
            btn_rooms_close.UseVisualStyleBackColor = false;
            btn_rooms_close.Click += btn_rooms_close_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Agency FB", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(479, 51);
            label1.Name = "label1";
            label1.Size = new Size(194, 86);
            label1.TabIndex = 0;
            label1.Text = "Rooms";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Agency FB", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(79, 378);
            label2.Name = "label2";
            label2.Size = new Size(170, 44);
            label2.TabIndex = 1;
            label2.Text = "Room Number";
            label2.Click += label2_Click;
            // 
            // tb_room_number
            // 
            tb_room_number.Font = new Font("Agency FB", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_room_number.Location = new Point(277, 377);
            tb_room_number.Name = "tb_room_number";
            tb_room_number.Size = new Size(216, 45);
            tb_room_number.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Agency FB", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(96, 526);
            label3.Name = "label3";
            label3.Size = new Size(153, 44);
            label3.TabIndex = 1;
            label3.Text = "Room Status";
            label3.Click += label2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkBlue;
            panel2.Location = new Point(-4, 146);
            panel2.Name = "panel2";
            panel2.Size = new Size(1274, 42);
            panel2.TabIndex = 5;
            // 
            // dg_rooms1
            // 
            dg_rooms1.AllowUserToAddRows = false;
            dg_rooms1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Agency FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dg_rooms1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dg_rooms1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_rooms1.Location = new Point(639, 249);
            dg_rooms1.Name = "dg_rooms1";
            dg_rooms1.ReadOnly = true;
            dg_rooms1.RowHeadersWidth = 62;
            dg_rooms1.Size = new Size(364, 290);
            dg_rooms1.TabIndex = 6;
            dg_rooms1.CellContentClick += dg_rooms_CellContentClick;
            // 
            // btn_rooms_back
            // 
            btn_rooms_back.BackColor = Color.SkyBlue;
            btn_rooms_back.Font = new Font("Agency FB", 14F);
            btn_rooms_back.Location = new Point(242, 775);
            btn_rooms_back.Name = "btn_rooms_back";
            btn_rooms_back.Size = new Size(123, 60);
            btn_rooms_back.TabIndex = 8;
            btn_rooms_back.Text = "BACK";
            btn_rooms_back.UseVisualStyleBackColor = false;
            btn_rooms_back.Click += btn_stu_back_Click;
            // 
            // btn_rooms_delete
            // 
            btn_rooms_delete.BackColor = Color.Coral;
            btn_rooms_delete.Font = new Font("Agency FB", 14F);
            btn_rooms_delete.Location = new Point(386, 692);
            btn_rooms_delete.Name = "btn_rooms_delete";
            btn_rooms_delete.Size = new Size(135, 62);
            btn_rooms_delete.TabIndex = 9;
            btn_rooms_delete.Text = "DELETE";
            btn_rooms_delete.UseVisualStyleBackColor = false;
            btn_rooms_delete.Click += btn_rooms_delete_Click;
            // 
            // btn_rooms_update
            // 
            btn_rooms_update.BackColor = Color.LemonChiffon;
            btn_rooms_update.Font = new Font("Agency FB", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_rooms_update.Location = new Point(99, 692);
            btn_rooms_update.Name = "btn_rooms_update";
            btn_rooms_update.Size = new Size(123, 62);
            btn_rooms_update.TabIndex = 10;
            btn_rooms_update.Text = "UPDATE";
            btn_rooms_update.UseVisualStyleBackColor = false;
            btn_rooms_update.Click += btn_rooms_update_Click;
            // 
            // btn_rooms_add
            // 
            btn_rooms_add.BackColor = Color.Chartreuse;
            btn_rooms_add.Font = new Font("Agency FB", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_rooms_add.Location = new Point(242, 692);
            btn_rooms_add.Name = "btn_rooms_add";
            btn_rooms_add.Size = new Size(123, 62);
            btn_rooms_add.TabIndex = 11;
            btn_rooms_add.Text = "ADD";
            btn_rooms_add.UseVisualStyleBackColor = false;
            btn_rooms_add.Click += btn_stu_add_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Crimson;
            panel3.Controls.Add(label11);
            panel3.Location = new Point(2, 990);
            panel3.Name = "panel3";
            panel3.Size = new Size(1128, 51);
            panel3.TabIndex = 12;
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
            // cb_room_status
            // 
            cb_room_status.Font = new Font("Agency FB", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_room_status.FormattingEnabled = true;
            cb_room_status.Items.AddRange(new object[] { "Available", "Unavailable" });
            cb_room_status.Location = new Point(277, 522);
            cb_room_status.Name = "cb_room_status";
            cb_room_status.Size = new Size(216, 48);
            cb_room_status.TabIndex = 13;
            // 
            // dg_rooms2
            // 
            dg_rooms2.AllowUserToAddRows = false;
            dg_rooms2.AllowUserToDeleteRows = false;
            dg_rooms2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_rooms2.Location = new Point(639, 619);
            dg_rooms2.Name = "dg_rooms2";
            dg_rooms2.ReadOnly = true;
            dg_rooms2.RowHeadersWidth = 62;
            dg_rooms2.Size = new Size(364, 290);
            dg_rooms2.TabIndex = 6;
            dg_rooms2.CellContentClick += dg_rooms_CellContentClick;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Agency FB", 16F, FontStyle.Bold);
            lbl.Location = new Point(755, 577);
            lbl.Name = "lbl";
            lbl.Size = new Size(134, 39);
            lbl.TabIndex = 14;
            lbl.Text = "Unavailable";
            lbl.Click += lbl_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Agency FB", 16F, FontStyle.Bold);
            label5.Location = new Point(755, 207);
            label5.Name = "label5";
            label5.Size = new Size(109, 39);
            label5.TabIndex = 14;
            label5.Text = "Available";
            label5.Click += label5_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(-1, 183);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1131, 812);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // FM_Rooms
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1126, 1040);
            Controls.Add(label5);
            Controls.Add(lbl);
            Controls.Add(cb_room_status);
            Controls.Add(panel3);
            Controls.Add(btn_rooms_back);
            Controls.Add(btn_rooms_delete);
            Controls.Add(btn_rooms_update);
            Controls.Add(btn_rooms_add);
            Controls.Add(dg_rooms2);
            Controls.Add(dg_rooms1);
            Controls.Add(panel2);
            Controls.Add(tb_room_number);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FM_Rooms";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rooms";
            Load += Rooms_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dg_rooms1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dg_rooms2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox tb_room_number;
        private Label label3;
        private Panel panel2;
        private DataGridView dg_rooms1;
        private Button btn_rooms_back;
        private Button btn_rooms_delete;
        private Button btn_rooms_update;
        private Button btn_rooms_add;
        private Panel panel3;
        private Label label11;
        private Button btn_rooms_close;
        private ComboBox cb_room_status;
        private DataGridView dg_rooms2;
        private Label lbl;
        private Label label5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox pictureBox1;
    }
}