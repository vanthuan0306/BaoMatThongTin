namespace Bai1
{
    partial class frmBaiToan1
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
            this.btnGiaiMa = new System.Windows.Forms.Button();
            this.btnMaHoa = new System.Windows.Forms.Button();
            this.txtBanTinDuocGiaiMa = new System.Windows.Forms.TextBox();
            this.lblBanTinDuocGiaiMa = new System.Windows.Forms.Label();
            this.txtBanTinDuocMaHoa = new System.Windows.Forms.TextBox();
            this.lblBanTinDuocMaHoa = new System.Windows.Forms.Label();
            this.txtBanTinRo = new System.Windows.Forms.TextBox();
            this.lblBanTinRo = new System.Windows.Forms.Label();
            this.nudSoViTri = new System.Windows.Forms.NumericUpDown();
            this.lblSoViTri = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoViTri)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGiaiMa
            // 
            this.btnGiaiMa.Enabled = false;
            this.btnGiaiMa.Location = new System.Drawing.Point(210, 247);
            this.btnGiaiMa.Name = "btnGiaiMa";
            this.btnGiaiMa.Size = new System.Drawing.Size(75, 23);
            this.btnGiaiMa.TabIndex = 19;
            this.btnGiaiMa.Text = "Giải mã";
            this.btnGiaiMa.UseVisualStyleBackColor = true;
            this.btnGiaiMa.Click += new System.EventHandler(this.btnGiaiMa_Click);
            // 
            // btnMaHoa
            // 
            this.btnMaHoa.Enabled = false;
            this.btnMaHoa.Location = new System.Drawing.Point(96, 247);
            this.btnMaHoa.Name = "btnMaHoa";
            this.btnMaHoa.Size = new System.Drawing.Size(75, 23);
            this.btnMaHoa.TabIndex = 18;
            this.btnMaHoa.Text = "Mã hóa";
            this.btnMaHoa.UseVisualStyleBackColor = true;
            this.btnMaHoa.Click += new System.EventHandler(this.btnMaHoa_Click);
            // 
            // txtBanTinDuocGiaiMa
            // 
            this.txtBanTinDuocGiaiMa.Location = new System.Drawing.Point(198, 171);
            this.txtBanTinDuocGiaiMa.Name = "txtBanTinDuocGiaiMa";
            this.txtBanTinDuocGiaiMa.Size = new System.Drawing.Size(208, 20);
            this.txtBanTinDuocGiaiMa.TabIndex = 17;
            // 
            // lblBanTinDuocGiaiMa
            // 
            this.lblBanTinDuocGiaiMa.AutoSize = true;
            this.lblBanTinDuocGiaiMa.Location = new System.Drawing.Point(47, 178);
            this.lblBanTinDuocGiaiMa.Name = "lblBanTinDuocGiaiMa";
            this.lblBanTinDuocGiaiMa.Size = new System.Drawing.Size(107, 13);
            this.lblBanTinDuocGiaiMa.TabIndex = 16;
            this.lblBanTinDuocGiaiMa.Text = "Bản tin được giải mã:";
            // 
            // txtBanTinDuocMaHoa
            // 
            this.txtBanTinDuocMaHoa.Location = new System.Drawing.Point(198, 138);
            this.txtBanTinDuocMaHoa.Name = "txtBanTinDuocMaHoa";
            this.txtBanTinDuocMaHoa.Size = new System.Drawing.Size(208, 20);
            this.txtBanTinDuocMaHoa.TabIndex = 15;
            this.txtBanTinDuocMaHoa.TextChanged += new System.EventHandler(this.txtBanTinDuocMaHoa_TextChanged);
            // 
            // lblBanTinDuocMaHoa
            // 
            this.lblBanTinDuocMaHoa.AutoSize = true;
            this.lblBanTinDuocMaHoa.Location = new System.Drawing.Point(47, 145);
            this.lblBanTinDuocMaHoa.Name = "lblBanTinDuocMaHoa";
            this.lblBanTinDuocMaHoa.Size = new System.Drawing.Size(109, 13);
            this.lblBanTinDuocMaHoa.TabIndex = 14;
            this.lblBanTinDuocMaHoa.Text = "Bản tin được mã hóa:";
            // 
            // txtBanTinRo
            // 
            this.txtBanTinRo.Location = new System.Drawing.Point(198, 100);
            this.txtBanTinRo.Name = "txtBanTinRo";
            this.txtBanTinRo.Size = new System.Drawing.Size(208, 20);
            this.txtBanTinRo.TabIndex = 13;
            this.txtBanTinRo.TextChanged += new System.EventHandler(this.txtBanTinRo_TextChanged);
            // 
            // lblBanTinRo
            // 
            this.lblBanTinRo.AutoSize = true;
            this.lblBanTinRo.Location = new System.Drawing.Point(47, 106);
            this.lblBanTinRo.Name = "lblBanTinRo";
            this.lblBanTinRo.Size = new System.Drawing.Size(55, 13);
            this.lblBanTinRo.TabIndex = 12;
            this.lblBanTinRo.Text = "Bản tin rõ:";
            // 
            // nudSoViTri
            // 
            this.nudSoViTri.Location = new System.Drawing.Point(198, 48);
            this.nudSoViTri.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudSoViTri.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSoViTri.Name = "nudSoViTri";
            this.nudSoViTri.Size = new System.Drawing.Size(120, 20);
            this.nudSoViTri.TabIndex = 11;
            this.nudSoViTri.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblSoViTri
            // 
            this.lblSoViTri.AutoSize = true;
            this.lblSoViTri.Location = new System.Drawing.Point(47, 55);
            this.lblSoViTri.Name = "lblSoViTri";
            this.lblSoViTri.Size = new System.Drawing.Size(47, 13);
            this.lblSoViTri.TabIndex = 10;
            this.lblSoViTri.Text = "Số vị trí:";
            // 
            // frmBaiToan1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 288);
            this.Controls.Add(this.btnGiaiMa);
            this.Controls.Add(this.btnMaHoa);
            this.Controls.Add(this.txtBanTinDuocGiaiMa);
            this.Controls.Add(this.lblBanTinDuocGiaiMa);
            this.Controls.Add(this.txtBanTinDuocMaHoa);
            this.Controls.Add(this.lblBanTinDuocMaHoa);
            this.Controls.Add(this.txtBanTinRo);
            this.Controls.Add(this.lblBanTinRo);
            this.Controls.Add(this.nudSoViTri);
            this.Controls.Add(this.lblSoViTri);
            this.Name = "frmBaiToan1";
            this.Text = "Bài toán 1";
            ((System.ComponentModel.ISupportInitialize)(this.nudSoViTri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGiaiMa;
        private System.Windows.Forms.Button btnMaHoa;
        private System.Windows.Forms.TextBox txtBanTinDuocGiaiMa;
        private System.Windows.Forms.Label lblBanTinDuocGiaiMa;
        private System.Windows.Forms.TextBox txtBanTinDuocMaHoa;
        private System.Windows.Forms.Label lblBanTinDuocMaHoa;
        private System.Windows.Forms.TextBox txtBanTinRo;
        private System.Windows.Forms.Label lblBanTinRo;
        private System.Windows.Forms.NumericUpDown nudSoViTri;
        private System.Windows.Forms.Label lblSoViTri;
    }
}

