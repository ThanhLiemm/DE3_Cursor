namespace Do_An_So3
{
    partial class frm1
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
            this.dgv_BGTT = new System.Windows.Forms.DataGridView();
            this.lbKQ = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbNgay = new System.Windows.Forms.Label();
            this.btLamLai = new System.Windows.Forms.Button();
            this.btMuaBan = new System.Windows.Forms.Button();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.cbLenh = new System.Windows.Forms.ComboBox();
            this.cbMuaBan = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BGTT)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_BGTT
            // 
            this.dgv_BGTT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BGTT.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_BGTT.Location = new System.Drawing.Point(12, 392);
            this.dgv_BGTT.Name = "dgv_BGTT";
            this.dgv_BGTT.RowTemplate.Height = 24;
            this.dgv_BGTT.Size = new System.Drawing.Size(1443, 324);
            this.dgv_BGTT.TabIndex = 15;
            // 
            // lbKQ
            // 
            this.lbKQ.AutoSize = true;
            this.lbKQ.Location = new System.Drawing.Point(897, 332);
            this.lbKQ.Name = "lbKQ";
            this.lbKQ.Size = new System.Drawing.Size(0, 17);
            this.lbKQ.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbNgay);
            this.panel1.Controls.Add(this.btLamLai);
            this.panel1.Controls.Add(this.btMuaBan);
            this.panel1.Controls.Add(this.txtGia);
            this.panel1.Controls.Add(this.txtSoLuong);
            this.panel1.Controls.Add(this.txtMa);
            this.panel1.Controls.Add(this.cbLenh);
            this.panel1.Controls.Add(this.cbMuaBan);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1063, 337);
            this.panel1.TabIndex = 17;
            // 
            // lbNgay
            // 
            this.lbNgay.AutoSize = true;
            this.lbNgay.Location = new System.Drawing.Point(123, 27);
            this.lbNgay.Name = "lbNgay";
            this.lbNgay.Size = new System.Drawing.Size(0, 17);
            this.lbNgay.TabIndex = 31;
            // 
            // btLamLai
            // 
            this.btLamLai.Location = new System.Drawing.Point(415, 296);
            this.btLamLai.Name = "btLamLai";
            this.btLamLai.Size = new System.Drawing.Size(121, 23);
            this.btLamLai.TabIndex = 30;
            this.btLamLai.Text = "Làm Lại";
            this.btLamLai.UseVisualStyleBackColor = true;
            this.btLamLai.Click += new System.EventHandler(this.btLamLai_Click_1);
            // 
            // btMuaBan
            // 
            this.btMuaBan.BackColor = System.Drawing.Color.Yellow;
            this.btMuaBan.Location = new System.Drawing.Point(179, 296);
            this.btMuaBan.Name = "btMuaBan";
            this.btMuaBan.Size = new System.Drawing.Size(121, 23);
            this.btMuaBan.TabIndex = 29;
            this.btMuaBan.Text = "Mua";
            this.btMuaBan.UseVisualStyleBackColor = false;
            this.btMuaBan.Click += new System.EventHandler(this.btMuaBan_Click_1);
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(527, 22);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(201, 22);
            this.txtGia.TabIndex = 28;
            this.txtGia.TextChanged += new System.EventHandler(this.txtGia_TextChanged_1);
            this.txtGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGia_KeyPress);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(126, 219);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(201, 22);
            this.txtSoLuong.TabIndex = 27;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged_1);
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(126, 119);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(201, 22);
            this.txtMa.TabIndex = 26;
            // 
            // cbLenh
            // 
            this.cbLenh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLenh.FormattingEnabled = true;
            this.cbLenh.Items.AddRange(new object[] {
            "LO: Khớp Lệnh Liên Tục"});
            this.cbLenh.Location = new System.Drawing.Point(527, 219);
            this.cbLenh.Name = "cbLenh";
            this.cbLenh.Size = new System.Drawing.Size(201, 24);
            this.cbLenh.TabIndex = 25;
            // 
            // cbMuaBan
            // 
            this.cbMuaBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMuaBan.FormattingEnabled = true;
            this.cbMuaBan.Items.AddRange(new object[] {
            "Mua",
            "Bán"});
            this.cbMuaBan.Location = new System.Drawing.Point(527, 116);
            this.cbMuaBan.Name = "cbMuaBan";
            this.cbMuaBan.Size = new System.Drawing.Size(201, 24);
            this.cbMuaBan.TabIndex = 24;
            this.cbMuaBan.SelectedIndexChanged += new System.EventHandler(this.cbMuaBan_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(429, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Giá (đ)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(429, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Lệnh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(429, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Mua/Bán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Số Lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Mã CK";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ngày Đặt";
            // 
            // frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 738);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbKQ);
            this.Controls.Add(this.dgv_BGTT);
            this.Name = "frm1";
            this.Text = "Giao Dịch Chứng Khoán";
            this.Load += new System.EventHandler(this.frm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BGTT)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_BGTT;
        private System.Windows.Forms.Label lbKQ;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbNgay;
        private System.Windows.Forms.Button btLamLai;
        private System.Windows.Forms.Button btMuaBan;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.ComboBox cbLenh;
        private System.Windows.Forms.ComboBox cbMuaBan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

