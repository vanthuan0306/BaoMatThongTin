namespace Bai2
{
    partial class frmBai2
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
            this.lblBanTinRo = new System.Windows.Forms.Label();
            this.txtBanTinRo = new System.Windows.Forms.TextBox();
            this.lblBanTinDuocMaHoa = new System.Windows.Forms.Label();
            this.txtBanTinDuocMaHoa = new System.Windows.Forms.TextBox();
            this.lblBanTinDuocGiaiMa = new System.Windows.Forms.Label();
            this.txtBanTinDuocGiaiMa = new System.Windows.Forms.TextBox();
            this.btnMaHoa = new System.Windows.Forms.Button();
            this.btnGiaiMa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBanTinRo
            // 
            this.lblBanTinRo.AutoSize = true;
            this.lblBanTinRo.Location = new System.Drawing.Point(43, 41);
            this.lblBanTinRo.Name = "lblBanTinRo";
            this.lblBanTinRo.Size = new System.Drawing.Size(55, 13);
            this.lblBanTinRo.TabIndex = 0;
            this.lblBanTinRo.Text = "Bản tin rõ:";
            // 
            // txtBanTinRo
            // 
            this.txtBanTinRo.Location = new System.Drawing.Point(210, 33);
            this.txtBanTinRo.Name = "txtBanTinRo";
            this.txtBanTinRo.Size = new System.Drawing.Size(198, 20);
            this.txtBanTinRo.TabIndex = 1;
            this.txtBanTinRo.TextChanged += new System.EventHandler(this.txtBanTinRo_TextChanged);
            // 
            // lblBanTinDuocMaHoa
            // 
            this.lblBanTinDuocMaHoa.AutoSize = true;
            this.lblBanTinDuocMaHoa.Location = new System.Drawing.Point(43, 75);
            this.lblBanTinDuocMaHoa.Name = "lblBanTinDuocMaHoa";
            this.lblBanTinDuocMaHoa.Size = new System.Drawing.Size(109, 13);
            this.lblBanTinDuocMaHoa.TabIndex = 2;
            this.lblBanTinDuocMaHoa.Text = "Bản tin được mã hóa:";
            // 
            // txtBanTinDuocMaHoa
            // 
            this.txtBanTinDuocMaHoa.Location = new System.Drawing.Point(210, 68);
            this.txtBanTinDuocMaHoa.Name = "txtBanTinDuocMaHoa";
            this.txtBanTinDuocMaHoa.Size = new System.Drawing.Size(198, 20);
            this.txtBanTinDuocMaHoa.TabIndex = 3;
            this.txtBanTinDuocMaHoa.TextChanged += new System.EventHandler(this.txtBanTinDuocMaHoa_TextChanged);
            // 
            // lblBanTinDuocGiaiMa
            // 
            this.lblBanTinDuocGiaiMa.AutoSize = true;
            this.lblBanTinDuocGiaiMa.Location = new System.Drawing.Point(43, 109);
            this.lblBanTinDuocGiaiMa.Name = "lblBanTinDuocGiaiMa";
            this.lblBanTinDuocGiaiMa.Size = new System.Drawing.Size(107, 13);
            this.lblBanTinDuocGiaiMa.TabIndex = 4;
            this.lblBanTinDuocGiaiMa.Text = "Bản tin được giải mã:";
            // 
            // txtBanTinDuocGiaiMa
            // 
            this.txtBanTinDuocGiaiMa.Location = new System.Drawing.Point(210, 101);
            this.txtBanTinDuocGiaiMa.Name = "txtBanTinDuocGiaiMa";
            this.txtBanTinDuocGiaiMa.Size = new System.Drawing.Size(198, 20);
            this.txtBanTinDuocGiaiMa.TabIndex = 5;
            // 
            // btnMaHoa
            // 
            this.btnMaHoa.Enabled = false;
            this.btnMaHoa.Location = new System.Drawing.Point(100, 162);
            this.btnMaHoa.Name = "btnMaHoa";
            this.btnMaHoa.Size = new System.Drawing.Size(75, 23);
            this.btnMaHoa.TabIndex = 6;
            this.btnMaHoa.Text = "Mã hóa";
            this.btnMaHoa.UseVisualStyleBackColor = true;
            this.btnMaHoa.Click += new System.EventHandler(this.btnMaHoa_Click);
            // 
            // btnGiaiMa
            // 
            this.btnGiaiMa.Enabled = false;
            this.btnGiaiMa.Location = new System.Drawing.Point(230, 161);
            this.btnGiaiMa.Name = "btnGiaiMa";
            this.btnGiaiMa.Size = new System.Drawing.Size(75, 23);
            this.btnGiaiMa.TabIndex = 7;
            this.btnGiaiMa.Text = "Giải mã";
            this.btnGiaiMa.UseVisualStyleBackColor = true;
            this.btnGiaiMa.Click += new System.EventHandler(this.btnGiaiMa_Click);
            // 
            // frmBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 226);
            this.Controls.Add(this.btnGiaiMa);
            this.Controls.Add(this.btnMaHoa);
            this.Controls.Add(this.txtBanTinDuocGiaiMa);
            this.Controls.Add(this.lblBanTinDuocGiaiMa);
            this.Controls.Add(this.txtBanTinDuocMaHoa);
            this.Controls.Add(this.lblBanTinDuocMaHoa);
            this.Controls.Add(this.txtBanTinRo);
            this.Controls.Add(this.lblBanTinRo);
            this.Name = "frmBai2";
            this.Text = "Bài toán 2";
            this.Load += new System.EventHandler(this.frmBai2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBanTinRo;
        private System.Windows.Forms.TextBox txtBanTinRo;
        private System.Windows.Forms.Label lblBanTinDuocMaHoa;
        private System.Windows.Forms.TextBox txtBanTinDuocMaHoa;
        private System.Windows.Forms.Label lblBanTinDuocGiaiMa;
        private System.Windows.Forms.TextBox txtBanTinDuocGiaiMa;
        private System.Windows.Forms.Button btnMaHoa;
        private System.Windows.Forms.Button btnGiaiMa;
    }
}

