namespace QLDatBao
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gPhieuDatBao = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDeleteDB = new System.Windows.Forms.Button();
            this.btnUpdateDB = new System.Windows.Forms.Button();
            this.btnNewDB = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.dtNgayDat = new System.Windows.Forms.DateTimePicker();
            this.cbSDT = new System.Windows.Forms.ComboBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtSoPhieu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnDeleteTC = new System.Windows.Forms.Button();
            this.btnAddTC = new System.Windows.Forms.Button();
            this.dgvCTDB = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.cbTapChi = new System.Windows.Forms.ComboBox();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.nudThangBD = new System.Windows.Forms.NumericUpDown();
            this.nudThangKT = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.gChiTietDatBao = new System.Windows.Forms.GroupBox();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTapChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThangBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThangKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gPhieuDatBao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThangBD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThangKT)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(48, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐẶT BÁO THEO THÁNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phiếu đặt báo";
            // 
            // gPhieuDatBao
            // 
            this.gPhieuDatBao.Controls.Add(this.btnExit);
            this.gPhieuDatBao.Controls.Add(this.btnCancel);
            this.gPhieuDatBao.Controls.Add(this.btnLast);
            this.gPhieuDatBao.Controls.Add(this.btnSave);
            this.gPhieuDatBao.Controls.Add(this.btnDeleteDB);
            this.gPhieuDatBao.Controls.Add(this.btnUpdateDB);
            this.gPhieuDatBao.Controls.Add(this.btnNewDB);
            this.gPhieuDatBao.Controls.Add(this.btnNext);
            this.gPhieuDatBao.Controls.Add(this.btnPrevious);
            this.gPhieuDatBao.Controls.Add(this.btnFirst);
            this.gPhieuDatBao.Controls.Add(this.dtNgayDat);
            this.gPhieuDatBao.Controls.Add(this.cbSDT);
            this.gPhieuDatBao.Controls.Add(this.label13);
            this.gPhieuDatBao.Controls.Add(this.txtDiaChi);
            this.gPhieuDatBao.Controls.Add(this.txtTenKH);
            this.gPhieuDatBao.Controls.Add(this.txtSoPhieu);
            this.gPhieuDatBao.Controls.Add(this.label7);
            this.gPhieuDatBao.Controls.Add(this.label6);
            this.gPhieuDatBao.Controls.Add(this.label4);
            this.gPhieuDatBao.Controls.Add(this.label3);
            this.gPhieuDatBao.Location = new System.Drawing.Point(35, 84);
            this.gPhieuDatBao.Name = "gPhieuDatBao";
            this.gPhieuDatBao.Size = new System.Drawing.Size(1260, 274);
            this.gPhieuDatBao.TabIndex = 2;
            this.gPhieuDatBao.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1008, 172);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 43);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1008, 123);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 43);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(322, 233);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(95, 35);
            this.btnLast.TabIndex = 4;
            this.btnLast.Text = ">|";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1008, 75);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 43);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDeleteDB
            // 
            this.btnDeleteDB.Location = new System.Drawing.Point(883, 172);
            this.btnDeleteDB.Name = "btnDeleteDB";
            this.btnDeleteDB.Size = new System.Drawing.Size(84, 43);
            this.btnDeleteDB.TabIndex = 4;
            this.btnDeleteDB.Text = "DELETE";
            this.btnDeleteDB.UseVisualStyleBackColor = true;
            // 
            // btnUpdateDB
            // 
            this.btnUpdateDB.Location = new System.Drawing.Point(883, 123);
            this.btnUpdateDB.Name = "btnUpdateDB";
            this.btnUpdateDB.Size = new System.Drawing.Size(84, 43);
            this.btnUpdateDB.TabIndex = 4;
            this.btnUpdateDB.Text = "UPDATE";
            this.btnUpdateDB.UseVisualStyleBackColor = true;
            this.btnUpdateDB.Click += new System.EventHandler(this.btnUpdateDB_Click);
            // 
            // btnNewDB
            // 
            this.btnNewDB.Location = new System.Drawing.Point(883, 75);
            this.btnNewDB.Name = "btnNewDB";
            this.btnNewDB.Size = new System.Drawing.Size(84, 43);
            this.btnNewDB.TabIndex = 4;
            this.btnNewDB.Text = "NEW";
            this.btnNewDB.UseVisualStyleBackColor = true;
            this.btnNewDB.Click += new System.EventHandler(this.btnNewDB_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(227, 233);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(95, 35);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(132, 233);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(95, 35);
            this.btnPrevious.TabIndex = 4;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(39, 233);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(95, 35);
            this.btnFirst.TabIndex = 4;
            this.btnFirst.Text = "|<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // dtNgayDat
            // 
            this.dtNgayDat.Location = new System.Drawing.Point(544, 71);
            this.dtNgayDat.Name = "dtNgayDat";
            this.dtNgayDat.Size = new System.Drawing.Size(200, 26);
            this.dtNgayDat.TabIndex = 3;
            // 
            // cbSDT
            // 
            this.cbSDT.FormattingEnabled = true;
            this.cbSDT.Location = new System.Drawing.Point(153, 110);
            this.cbSDT.Name = "cbSDT";
            this.cbSDT.Size = new System.Drawing.Size(235, 28);
            this.cbSDT.TabIndex = 2;
            this.cbSDT.SelectedIndexChanged += new System.EventHandler(this.cbSDT_SelectedIndexChanged);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(491, 134);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(289, 99);
            this.txtDiaChi.TabIndex = 1;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(178, 172);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(210, 26);
            this.txtTenKH.TabIndex = 1;
            // 
            // txtSoPhieu
            // 
            this.txtSoPhieu.Location = new System.Drawing.Point(153, 58);
            this.txtSoPhieu.Name = "txtSoPhieu";
            this.txtSoPhieu.Size = new System.Drawing.Size(235, 26);
            this.txtSoPhieu.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(421, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Địa Chỉ:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(421, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ngày đặt hàng:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tìm theo SĐT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tìm Số Phiếu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 407);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tìm tên tạp chí:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(56, 444);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tổng tiền:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(354, 407);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Số lượng:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(529, 407);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Tháng BĐ:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(713, 407);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Tháng KT:";
            // 
            // btnDeleteTC
            // 
            this.btnDeleteTC.Location = new System.Drawing.Point(1050, 404);
            this.btnDeleteTC.Name = "btnDeleteTC";
            this.btnDeleteTC.Size = new System.Drawing.Size(106, 47);
            this.btnDeleteTC.TabIndex = 3;
            this.btnDeleteTC.Text = "DELETE";
            this.btnDeleteTC.UseVisualStyleBackColor = true;
            this.btnDeleteTC.Click += new System.EventHandler(this.btnDeleteTC_Click);
            // 
            // btnAddTC
            // 
            this.btnAddTC.Location = new System.Drawing.Point(922, 404);
            this.btnAddTC.Name = "btnAddTC";
            this.btnAddTC.Size = new System.Drawing.Size(106, 47);
            this.btnAddTC.TabIndex = 3;
            this.btnAddTC.Text = "ADD";
            this.btnAddTC.UseVisualStyleBackColor = true;
            this.btnAddTC.Click += new System.EventHandler(this.btnAddTC_Click);
            // 
            // dgvCTDB
            // 
            this.dgvCTDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTDB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.TenTapChi,
            this.ThangBD,
            this.ThangKT,
            this.SoLuong,
            this.Column5,
            this.Column6});
            this.dgvCTDB.Location = new System.Drawing.Point(54, 492);
            this.dgvCTDB.Name = "dgvCTDB";
            this.dgvCTDB.RowTemplate.Height = 28;
            this.dgvCTDB.Size = new System.Drawing.Size(1158, 150);
            this.dgvCTDB.TabIndex = 4;
            this.dgvCTDB.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvCTDB_DataBindingComplete);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(49, 370);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Chi tiết Đặt Báo:";
            // 
            // cbTapChi
            // 
            this.cbTapChi.FormattingEnabled = true;
            this.cbTapChi.Location = new System.Drawing.Point(188, 402);
            this.cbTapChi.Name = "cbTapChi";
            this.cbTapChi.Size = new System.Drawing.Size(160, 28);
            this.cbTapChi.TabIndex = 2;
            // 
            // txtTong
            // 
            this.txtTong.Location = new System.Drawing.Point(167, 444);
            this.txtTong.Name = "txtTong";
            this.txtTong.Size = new System.Drawing.Size(160, 26);
            this.txtTong.TabIndex = 1;
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Location = new System.Drawing.Point(445, 402);
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(64, 26);
            this.nudSoLuong.TabIndex = 5;
            // 
            // nudThangBD
            // 
            this.nudThangBD.Location = new System.Drawing.Point(629, 405);
            this.nudThangBD.Name = "nudThangBD";
            this.nudThangBD.Size = new System.Drawing.Size(64, 26);
            this.nudThangBD.TabIndex = 5;
            // 
            // nudThangKT
            // 
            this.nudThangKT.Location = new System.Drawing.Point(809, 405);
            this.nudThangKT.Name = "nudThangKT";
            this.nudThangKT.Size = new System.Drawing.Size(64, 26);
            this.nudThangKT.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(40, 175);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(132, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "Tên Khách Hàng:";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // gChiTietDatBao
            // 
            this.gChiTietDatBao.Location = new System.Drawing.Point(35, 379);
            this.gChiTietDatBao.Name = "gChiTietDatBao";
            this.gChiTietDatBao.Size = new System.Drawing.Size(1260, 91);
            this.gChiTietDatBao.TabIndex = 6;
            this.gChiTietDatBao.TabStop = false;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // TenTapChi
            // 
            this.TenTapChi.DataPropertyName = "TenTC";
            this.TenTapChi.HeaderText = "Tên Tạp Chí";
            this.TenTapChi.Name = "TenTapChi";
            // 
            // ThangBD
            // 
            this.ThangBD.DataPropertyName = "ThangBD";
            this.ThangBD.HeaderText = "Tháng Bắt Đầu";
            this.ThangBD.Name = "ThangBD";
            // 
            // ThangKT
            // 
            this.ThangKT.DataPropertyName = "ThangKT";
            this.ThangKT.HeaderText = "Tháng Kết Thúc";
            this.ThangKT.Name = "ThangKT";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "DonGiaThang";
            this.Column5.HeaderText = "Đơn Giá Tháng";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "ThanhTien";
            this.Column6.HeaderText = "Thành Tiền";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 644);
            this.Controls.Add(this.nudThangKT);
            this.Controls.Add(this.nudThangBD);
            this.Controls.Add(this.nudSoLuong);
            this.Controls.Add(this.dgvCTDB);
            this.Controls.Add(this.btnAddTC);
            this.Controls.Add(this.btnDeleteTC);
            this.Controls.Add(this.gPhieuDatBao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbTapChi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTong);
            this.Controls.Add(this.gChiTietDatBao);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gPhieuDatBao.ResumeLayout(false);
            this.gPhieuDatBao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThangBD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThangKT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gPhieuDatBao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNewDB;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.DateTimePicker dtNgayDat;
        private System.Windows.Forms.ComboBox cbSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtSoPhieu;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDeleteDB;
        private System.Windows.Forms.Button btnUpdateDB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnDeleteTC;
        private System.Windows.Forms.Button btnAddTC;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.DataGridView dgvCTDB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbTapChi;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.NumericUpDown nudThangBD;
        private System.Windows.Forms.NumericUpDown nudThangKT;
        private System.Windows.Forms.GroupBox gChiTietDatBao;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTapChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThangBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThangKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}

