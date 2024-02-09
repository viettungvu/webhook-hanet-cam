namespace ToolInsertCheckin
{
    partial class frmAutoInsert
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            btnAuto = new Button();
            label1 = new Label();
            dpkAuthDate = new DateTimePicker();
            panel2 = new Panel();
            dgvAttendance = new DataGridView();
            panel3 = new Panel();
            lblLastRun = new Label();
            lblTotal = new Label();
            prgBar = new ProgressBar();
            txtTerminal = new RichTextBox();
            btnRefresh = new Button();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Controls.Add(panel3, 0, 2);
            tableLayoutPanel1.Controls.Add(txtTerminal, 0, 3);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 63F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(992, 659);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(btnAuto);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dpkAuthDate);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(986, 52);
            panel1.TabIndex = 0;
            // 
            // btnAuto
            // 
            btnAuto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAuto.BackColor = SystemColors.ButtonFace;
            btnAuto.Cursor = Cursors.Hand;
            btnAuto.Location = new Point(783, 10);
            btnAuto.Name = "btnAuto";
            btnAuto.Size = new Size(194, 29);
            btnAuto.TabIndex = 2;
            btnAuto.Text = "Auto Insert Data: ON";
            btnAuto.UseVisualStyleBackColor = false;
            btnAuto.Click += btnAuto_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 13);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 1;
            label1.Text = "Date";
            // 
            // dpkAuthDate
            // 
            dpkAuthDate.Checked = false;
            dpkAuthDate.CustomFormat = "dd/MM/yyyy";
            dpkAuthDate.Format = DateTimePickerFormat.Custom;
            dpkAuthDate.Location = new Point(73, 9);
            dpkAuthDate.Name = "dpkAuthDate";
            dpkAuthDate.Size = new Size(250, 27);
            dpkAuthDate.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvAttendance);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 61);
            panel2.Name = "panel2";
            panel2.Size = new Size(986, 261);
            panel2.TabIndex = 1;
            // 
            // dgvAttendance
            // 
            dgvAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAttendance.Dock = DockStyle.Fill;
            dgvAttendance.Location = new Point(0, 0);
            dgvAttendance.Name = "dgvAttendance";
            dgvAttendance.RowHeadersWidth = 51;
            dgvAttendance.RowTemplate.Height = 29;
            dgvAttendance.Size = new Size(986, 261);
            dgvAttendance.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(lblLastRun);
            panel3.Controls.Add(lblTotal);
            panel3.Controls.Add(prgBar);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 328);
            panel3.Name = "panel3";
            panel3.Size = new Size(986, 57);
            panel3.TabIndex = 2;
            // 
            // lblLastRun
            // 
            lblLastRun.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblLastRun.AutoSize = true;
            lblLastRun.Location = new Point(858, 21);
            lblLastRun.Name = "lblLastRun";
            lblLastRun.Size = new Size(102, 20);
            lblLastRun.TabIndex = 2;
            lblLastRun.Text = "Last run: 12:00";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(564, 18);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(88, 20);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "Inserted 0/0";
            // 
            // prgBar
            // 
            prgBar.Location = new Point(9, 14);
            prgBar.Name = "prgBar";
            prgBar.Size = new Size(549, 27);
            prgBar.TabIndex = 0;
            // 
            // txtTerminal
            // 
            txtTerminal.BackColor = SystemColors.InfoText;
            txtTerminal.Dock = DockStyle.Fill;
            txtTerminal.Enabled = false;
            txtTerminal.Location = new Point(3, 391);
            txtTerminal.Name = "txtTerminal";
            txtTerminal.Size = new Size(986, 265);
            txtTerminal.TabIndex = 3;
            txtTerminal.Text = "";
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.BackColor = SystemColors.ButtonFace;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.Location = new Point(583, 10);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(194, 29);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // frmAutoInsert
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 663);
            Controls.Add(tableLayoutPanel1);
            ForeColor = SystemColors.WindowText;
            Name = "frmAutoInsert";
            Text = "SAGS Insert Checkin Data";
            Load += frmAutoInsert_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Button btnAuto;
        private Label label1;
        private DateTimePicker dpkAuthDate;
        private Panel panel2;
        private Panel panel3;
        private Label lblTotal;
        private ProgressBar prgBar;
        private DataGridView dgvAttendance;
        private Label lblLastRun;
        private Button btnRefresh;
        private RichTextBox txtTerminal;
    }
}
