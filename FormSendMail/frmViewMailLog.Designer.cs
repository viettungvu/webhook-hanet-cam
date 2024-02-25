namespace FormSendMail
{
    partial class frmViewMailLog
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
            btnResend = new Button();
            dgvMaiLog = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvMaiLog).BeginInit();
            SuspendLayout();
            // 
            // btnResend
            // 
            btnResend.Enabled = false;
            btnResend.Location = new Point(694, 12);
            btnResend.Name = "btnResend";
            btnResend.Size = new Size(94, 29);
            btnResend.TabIndex = 0;
            btnResend.Text = "Resend";
            btnResend.UseVisualStyleBackColor = true;
            btnResend.Click += btnResend_Click;
            // 
            // dgvMaiLog
            // 
            dgvMaiLog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaiLog.Location = new Point(12, 49);
            dgvMaiLog.Name = "dgvMaiLog";
            dgvMaiLog.RowHeadersWidth = 51;
            dgvMaiLog.RowTemplate.Height = 29;
            dgvMaiLog.Size = new Size(776, 389);
            dgvMaiLog.TabIndex = 1;
            // 
            // frmViewMailLog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvMaiLog);
            Controls.Add(btnResend);
            Name = "frmViewMailLog";
            Text = "frmViewMailLog";
            Load += frmViewMailLog_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMaiLog).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnResend;
        private DataGridView dgvMaiLog;
    }
}