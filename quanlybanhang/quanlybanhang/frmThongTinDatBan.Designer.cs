namespace quanlybanhang
{
    partial class frmThongTinDatBan
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
            label1 = new Label();
            txtMaDatBan = new TextBox();
            txtMaBan = new TextBox();
            txtMaKH = new TextBox();
            txtSoLuong = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            btnXem = new Button();
            dateTimePicker1 = new DateTimePicker();
            btnThemMoi = new Button();
            txtTime = new DateTimePicker();
            label7 = new Label();
            btnLoad = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 67);
            label1.Name = "label1";
            label1.Size = new Size(95, 23);
            label1.TabIndex = 0;
            label1.Text = "ID_Đặt bàn";
            // 
            // txtMaDatBan
            // 
            txtMaDatBan.Location = new Point(163, 63);
            txtMaDatBan.Name = "txtMaDatBan";
            txtMaDatBan.Size = new Size(157, 27);
            txtMaDatBan.TabIndex = 0;
            // 
            // txtMaBan
            // 
            txtMaBan.Location = new Point(163, 133);
            txtMaBan.Name = "txtMaBan";
            txtMaBan.Size = new Size(154, 27);
            txtMaBan.TabIndex = 1;
            // 
            // txtMaKH
            // 
            txtMaKH.Location = new Point(163, 192);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(154, 27);
            txtMaKH.TabIndex = 2;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(502, 193);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(153, 27);
            txtSoLuong.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 134);
            label2.Name = "label2";
            label2.Size = new Size(71, 23);
            label2.TabIndex = 12;
            label2.Text = "STT Bàn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(32, 193);
            label3.Name = "label3";
            label3.Size = new Size(125, 23);
            label3.TabIndex = 13;
            label3.Text = "ID_Khách hàng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(367, 67);
            label4.Name = "label4";
            label4.Size = new Size(111, 23);
            label4.TabIndex = 14;
            label4.Text = "Thời gian đặt";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(367, 137);
            label5.Name = "label5";
            label5.Size = new Size(81, 23);
            label5.TabIndex = 15;
            label5.Text = "Ngày đặt";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(367, 197);
            label6.Name = "label6";
            label6.Size = new Size(129, 23);
            label6.TabIndex = 16;
            label6.Text = "Số lượng người";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(45, 360);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(845, 255);
            dataGridView1.TabIndex = 17;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnXem
            // 
            btnXem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXem.ForeColor = SystemColors.Highlight;
            btnXem.Location = new Point(743, 274);
            btnXem.Name = "btnXem";
            btnXem.Size = new Size(126, 41);
            btnXem.TabIndex = 7;
            btnXem.Text = "Xem";
            btnXem.UseVisualStyleBackColor = true;
            btnXem.Click += btnXem_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(501, 134);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(242, 27);
            dateTimePicker1.TabIndex = 4;
            // 
            // btnThemMoi
            // 
            btnThemMoi.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThemMoi.ForeColor = SystemColors.Highlight;
            btnThemMoi.Location = new Point(581, 274);
            btnThemMoi.Name = "btnThemMoi";
            btnThemMoi.Size = new Size(146, 41);
            btnThemMoi.TabIndex = 6;
            btnThemMoi.Text = "Thêm mới";
            btnThemMoi.UseVisualStyleBackColor = true;
            btnThemMoi.Click += btnThemMoi_Click;
            // 
            // txtTime
            // 
            txtTime.Format = DateTimePickerFormat.Time;
            txtTime.Location = new Point(501, 67);
            txtTime.Name = "txtTime";
            txtTime.ShowUpDown = true;
            txtTime.Size = new Size(242, 27);
            txtTime.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(45, 332);
            label7.Name = "label7";
            label7.Size = new Size(246, 25);
            label7.TabIndex = 22;
            label7.Text = "Danh sách thông tin đặt bàn";
            // 
            // btnLoad
            // 
            btnLoad.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoad.ForeColor = SystemColors.Highlight;
            btnLoad.Location = new Point(823, 32);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(110, 33);
            btnLoad.TabIndex = 8;
            btnLoad.Text = "Làm mới";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // frmThongTinDatBan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(945, 627);
            Controls.Add(btnLoad);
            Controls.Add(label7);
            Controls.Add(txtTime);
            Controls.Add(btnThemMoi);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnXem);
            Controls.Add(dataGridView1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtSoLuong);
            Controls.Add(txtMaKH);
            Controls.Add(txtMaBan);
            Controls.Add(txtMaDatBan);
            Controls.Add(label1);
            Name = "frmThongTinDatBan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thông tin đặt bàn";
            FormClosing += frmThongTinDatBan_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMaDatBan;
        private TextBox txtMaBan;
        private TextBox txtMaKH;
        private TextBox txtSoLuong;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DataGridView dataGridView1;
        private Button btnXem;
        private DateTimePicker dateTimePicker1;
        private Button btnThemMoi;
        private DateTimePicker txtTime;
        private Label label7;
        private Button btnLoad;
    }
}
