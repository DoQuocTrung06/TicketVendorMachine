namespace TicketVendorMachine
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
            this.components = new System.ComponentModel.Container();
            this.cbRoutes = new System.Windows.Forms.ComboBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.picQR = new System.Windows.Forms.PictureBox();
            this.pnlBill = new System.Windows.Forms.Panel();
            this.lblBillDetails = new System.Windows.Forms.Label();
            this.lblClock = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerReset = new System.Windows.Forms.Timer(this.components);
            this.lblStatus = new System.Windows.Forms.Label();
            this.timerFakeAPI = new System.Windows.Forms.Timer(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picQR)).BeginInit();
            this.pnlBill.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbRoutes
            // 
            this.cbRoutes.FormattingEnabled = true;
            this.cbRoutes.Location = new System.Drawing.Point(103, 108);
            this.cbRoutes.Name = "cbRoutes";
            this.cbRoutes.Size = new System.Drawing.Size(139, 21);
            this.cbRoutes.TabIndex = 0;
            this.cbRoutes.SelectedIndexChanged += new System.EventHandler(this.cbRoutes_SelectedIndexChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(112, 179);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(76, 13);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "Giá vé: 0 VNĐ";
            this.lblPrice.Click += new System.EventHandler(this.lblPrice_Click);
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(103, 219);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(139, 35);
            this.btnPay.TabIndex = 2;
            this.btnPay.Text = "Thanh toán bằng QR";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // picQR
            // 
            this.picQR.Location = new System.Drawing.Point(276, 84);
            this.picQR.Name = "picQR";
            this.picQR.Size = new System.Drawing.Size(213, 150);
            this.picQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picQR.TabIndex = 3;
            this.picQR.TabStop = false;
            // 
            // pnlBill
            // 
            this.pnlBill.Controls.Add(this.lblBillDetails);
            this.pnlBill.Location = new System.Drawing.Point(255, 74);
            this.pnlBill.Name = "pnlBill";
            this.pnlBill.Size = new System.Drawing.Size(253, 160);
            this.pnlBill.TabIndex = 5;
            this.pnlBill.Visible = false;
            this.pnlBill.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBill_Paint);
            // 
            // lblBillDetails
            // 
            this.lblBillDetails.AutoSize = true;
            this.lblBillDetails.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillDetails.Location = new System.Drawing.Point(28, 8);
            this.lblBillDetails.Name = "lblBillDetails";
            this.lblBillDetails.Size = new System.Drawing.Size(49, 14);
            this.lblBillDetails.TabIndex = 0;
            this.lblBillDetails.Text = "label1";
            this.lblBillDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBillDetails.Click += new System.EventHandler(this.lblBillDetails_Click);
            // 
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.lblClock.Location = new System.Drawing.Point(43, 31);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(35, 13);
            this.lblClock.TabIndex = 6;
            this.lblClock.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerReset
            // 
            this.timerReset.Interval = 5000;
            this.timerReset.Tick += new System.EventHandler(this.timerReset_Tick);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(232, 257);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(217, 24);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Đang chờ bạn quét mã...";
            this.lblStatus.Visible = false;
            // 
            // timerFakeAPI
            // 
            this.timerFakeAPI.Interval = 5000;
            this.timerFakeAPI.Tick += new System.EventHandler(this.timerFakeAPI_Tick);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkGray;
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(545, 257);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(103, 24);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Hủy giao dịch";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblClock);
            this.Controls.Add(this.pnlBill);
            this.Controls.Add(this.picQR);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.cbRoutes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picQR)).EndInit();
            this.pnlBill.ResumeLayout(false);
            this.pnlBill.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbRoutes;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.PictureBox picQR;
        private System.Windows.Forms.Panel pnlBill;
        private System.Windows.Forms.Label lblBillDetails;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timerReset;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Timer timerFakeAPI;
        private System.Windows.Forms.Button btnCancel;
    }
}

