namespace Hamming
{
    partial class frmHamming
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHamming));
            this.lbl16KySoHex = new System.Windows.Forms.Label();
            this.lblSoHex = new System.Windows.Forms.Label();
            this.lblSoNhiPhan = new System.Windows.Forms.Label();
            this.lblTrongSoHamming = new System.Windows.Forms.Label();
            this.txtAHexStr = new System.Windows.Forms.TextBox();
            this.txtABinStr = new System.Windows.Forms.TextBox();
            this.txtATrongSo = new System.Windows.Forms.TextBox();
            this.lblSoThuNhat = new System.Windows.Forms.Label();
            this.lblSoThuHai = new System.Windows.Forms.Label();
            this.txtBHexStr = new System.Windows.Forms.TextBox();
            this.txtBBinStr = new System.Windows.Forms.TextBox();
            this.txtBTrongSo = new System.Windows.Forms.TextBox();
            this.lblKhoangCach = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtAxorBHexStr = new System.Windows.Forms.TextBox();
            this.txtAxorBBinStr = new System.Windows.Forms.TextBox();
            this.txtKhoangCach = new System.Windows.Forms.TextBox();
            this.btnTinhToan = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl16KySoHex
            // 
            this.lbl16KySoHex.AutoSize = true;
            this.lbl16KySoHex.Location = new System.Drawing.Point(25, 26);
            this.lbl16KySoHex.Name = "lbl16KySoHex";
            this.lbl16KySoHex.Size = new System.Drawing.Size(70, 13);
            this.lbl16KySoHex.TabIndex = 0;
            this.lbl16KySoHex.Text = "16 Ký số Hex";
            // 
            // lblSoHex
            // 
            this.lblSoHex.AutoSize = true;
            this.lblSoHex.Location = new System.Drawing.Point(123, 28);
            this.lblSoHex.Name = "lblSoHex";
            this.lblSoHex.Size = new System.Drawing.Size(84, 13);
            this.lblSoHex.TabIndex = 1;
            this.lblSoHex.Text = "Số Hexadecimal";
            // 
            // lblSoNhiPhan
            // 
            this.lblSoNhiPhan.AutoSize = true;
            this.lblSoNhiPhan.Location = new System.Drawing.Point(271, 26);
            this.lblSoNhiPhan.Name = "lblSoNhiPhan";
            this.lblSoNhiPhan.Size = new System.Drawing.Size(64, 13);
            this.lblSoNhiPhan.TabIndex = 2;
            this.lblSoNhiPhan.Text = "Số nhị phân";
            // 
            // lblTrongSoHamming
            // 
            this.lblTrongSoHamming.AutoSize = true;
            this.lblTrongSoHamming.Location = new System.Drawing.Point(651, 26);
            this.lblTrongSoHamming.Name = "lblTrongSoHamming";
            this.lblTrongSoHamming.Size = new System.Drawing.Size(96, 13);
            this.lblTrongSoHamming.TabIndex = 3;
            this.lblTrongSoHamming.Text = "Trọng số Hamming";
            // 
            // txtAHexStr
            // 
            this.txtAHexStr.Location = new System.Drawing.Point(126, 54);
            this.txtAHexStr.Name = "txtAHexStr";
            this.txtAHexStr.Size = new System.Drawing.Size(100, 20);
            this.txtAHexStr.TabIndex = 5;
            this.txtAHexStr.TextChanged += new System.EventHandler(this.txtHexStr_TextChanged);
            // 
            // txtABinStr
            // 
            this.txtABinStr.Location = new System.Drawing.Point(274, 54);
            this.txtABinStr.Name = "txtABinStr";
            this.txtABinStr.ReadOnly = true;
            this.txtABinStr.Size = new System.Drawing.Size(363, 20);
            this.txtABinStr.TabIndex = 6;
            // 
            // txtATrongSo
            // 
            this.txtATrongSo.Location = new System.Drawing.Point(654, 54);
            this.txtATrongSo.Name = "txtATrongSo";
            this.txtATrongSo.ReadOnly = true;
            this.txtATrongSo.Size = new System.Drawing.Size(100, 20);
            this.txtATrongSo.TabIndex = 7;
            // 
            // lblSoThuNhat
            // 
            this.lblSoThuNhat.AutoSize = true;
            this.lblSoThuNhat.Location = new System.Drawing.Point(31, 57);
            this.lblSoThuNhat.Name = "lblSoThuNhat";
            this.lblSoThuNhat.Size = new System.Drawing.Size(14, 13);
            this.lblSoThuNhat.TabIndex = 8;
            this.lblSoThuNhat.Text = "A";
            // 
            // lblSoThuHai
            // 
            this.lblSoThuHai.AutoSize = true;
            this.lblSoThuHai.Location = new System.Drawing.Point(31, 87);
            this.lblSoThuHai.Name = "lblSoThuHai";
            this.lblSoThuHai.Size = new System.Drawing.Size(14, 13);
            this.lblSoThuHai.TabIndex = 9;
            this.lblSoThuHai.Text = "B";
            // 
            // txtBHexStr
            // 
            this.txtBHexStr.Location = new System.Drawing.Point(126, 79);
            this.txtBHexStr.Name = "txtBHexStr";
            this.txtBHexStr.Size = new System.Drawing.Size(100, 20);
            this.txtBHexStr.TabIndex = 10;
            this.txtBHexStr.TextChanged += new System.EventHandler(this.txtHexStr_TextChanged);
            // 
            // txtBBinStr
            // 
            this.txtBBinStr.Location = new System.Drawing.Point(274, 79);
            this.txtBBinStr.Name = "txtBBinStr";
            this.txtBBinStr.ReadOnly = true;
            this.txtBBinStr.Size = new System.Drawing.Size(363, 20);
            this.txtBBinStr.TabIndex = 11;
            // 
            // txtBTrongSo
            // 
            this.txtBTrongSo.Location = new System.Drawing.Point(654, 78);
            this.txtBTrongSo.Name = "txtBTrongSo";
            this.txtBTrongSo.ReadOnly = true;
            this.txtBTrongSo.Size = new System.Drawing.Size(100, 20);
            this.txtBTrongSo.TabIndex = 12;
            // 
            // lblKhoangCach
            // 
            this.lblKhoangCach.AutoSize = true;
            this.lblKhoangCach.Location = new System.Drawing.Point(654, 105);
            this.lblKhoangCach.Name = "lblKhoangCach";
            this.lblKhoangCach.Size = new System.Drawing.Size(118, 13);
            this.lblKhoangCach.TabIndex = 13;
            this.lblKhoangCach.Text = "Khoảng cách Hamming";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 129);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 26);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // txtAxorBHexStr
            // 
            this.txtAxorBHexStr.Location = new System.Drawing.Point(126, 134);
            this.txtAxorBHexStr.Name = "txtAxorBHexStr";
            this.txtAxorBHexStr.Size = new System.Drawing.Size(100, 20);
            this.txtAxorBHexStr.TabIndex = 15;
            // 
            // txtAxorBBinStr
            // 
            this.txtAxorBBinStr.Location = new System.Drawing.Point(274, 134);
            this.txtAxorBBinStr.Name = "txtAxorBBinStr";
            this.txtAxorBBinStr.Size = new System.Drawing.Size(363, 20);
            this.txtAxorBBinStr.TabIndex = 16;
            // 
            // txtKhoangCach
            // 
            this.txtKhoangCach.Location = new System.Drawing.Point(654, 134);
            this.txtKhoangCach.Name = "txtKhoangCach";
            this.txtKhoangCach.Size = new System.Drawing.Size(100, 20);
            this.txtKhoangCach.TabIndex = 17;
            // 
            // btnTinhToan
            // 
            this.btnTinhToan.Enabled = false;
            this.btnTinhToan.Location = new System.Drawing.Point(150, 179);
            this.btnTinhToan.Name = "btnTinhToan";
            this.btnTinhToan.Size = new System.Drawing.Size(75, 23);
            this.btnTinhToan.TabIndex = 18;
            this.btnTinhToan.Text = "Tính toán";
            this.btnTinhToan.UseVisualStyleBackColor = true;
            this.btnTinhToan.Click += new System.EventHandler(this.btnTinhToan_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(274, 178);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 19;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // frmHamming
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 217);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnTinhToan);
            this.Controls.Add(this.txtKhoangCach);
            this.Controls.Add(this.txtAxorBBinStr);
            this.Controls.Add(this.txtAxorBHexStr);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblKhoangCach);
            this.Controls.Add(this.txtBTrongSo);
            this.Controls.Add(this.txtBBinStr);
            this.Controls.Add(this.txtBHexStr);
            this.Controls.Add(this.lblSoThuHai);
            this.Controls.Add(this.lblSoThuNhat);
            this.Controls.Add(this.txtATrongSo);
            this.Controls.Add(this.txtABinStr);
            this.Controls.Add(this.txtAHexStr);
            this.Controls.Add(this.lblTrongSoHamming);
            this.Controls.Add(this.lblSoNhiPhan);
            this.Controls.Add(this.lblSoHex);
            this.Controls.Add(this.lbl16KySoHex);
            this.Name = "frmHamming";
            this.Text = "Bài toán Hamming";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl16KySoHex;
        private System.Windows.Forms.Label lblSoHex;
        private System.Windows.Forms.Label lblSoNhiPhan;
        private System.Windows.Forms.Label lblTrongSoHamming;
        private System.Windows.Forms.TextBox txtAHexStr;
        private System.Windows.Forms.TextBox txtABinStr;
        private System.Windows.Forms.TextBox txtATrongSo;
        private System.Windows.Forms.Label lblSoThuNhat;
        private System.Windows.Forms.Label lblSoThuHai;
        private System.Windows.Forms.TextBox txtBHexStr;
        private System.Windows.Forms.TextBox txtBBinStr;
        private System.Windows.Forms.TextBox txtBTrongSo;
        private System.Windows.Forms.Label lblKhoangCach;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtAxorBHexStr;
        private System.Windows.Forms.TextBox txtAxorBBinStr;
        private System.Windows.Forms.TextBox txtKhoangCach;
        private System.Windows.Forms.Button btnTinhToan;
        private System.Windows.Forms.Button btnDong;
    }
}

