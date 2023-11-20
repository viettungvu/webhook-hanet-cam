namespace FormSendMail
{
    partial class frmIncome
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
            tableLayoutPanel2 = new TableLayoutPanel();
            prgBar = new ProgressBar();
            groupBox1 = new GroupBox();
            btnSendMail = new Button();
            label2 = new Label();
            label1 = new Label();
            dpkDataDate = new DateTimePicker();
            cbxDepartment = new ComboBox();
            btnTimKiem = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            dgvData = new DataGridView();
            panel1 = new Panel();
            lblTotal = new Label();
            label3 = new Label();
            tableLayoutPanel2.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(prgBar, 0, 1);
            tableLayoutPanel2.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 85.6F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.4F));
            tableLayoutPanel2.Size = new Size(981, 170);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // prgBar
            // 
            prgBar.Dock = DockStyle.Fill;
            prgBar.ForeColor = Color.Lime;
            prgBar.Location = new Point(3, 148);
            prgBar.Name = "prgBar";
            prgBar.Size = new Size(975, 19);
            prgBar.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSendMail);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dpkDataDate);
            groupBox1.Controls.Add(cbxDepartment);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(975, 139);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm";
            // 
            // btnSendMail
            // 
            btnSendMail.Location = new Point(156, 91);
            btnSendMail.Name = "btnSendMail";
            btnSendMail.Size = new Size(144, 42);
            btnSendMail.TabIndex = 5;
            btnSendMail.Text = "Send mail";
            btnSendMail.UseVisualStyleBackColor = true;
            btnSendMail.Click += btnSendMail_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(352, 29);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 4;
            label2.Text = "Data date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 32);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 3;
            label1.Text = "Department";
            // 
            // dpkDataDate
            // 
            dpkDataDate.CustomFormat = "dd/MM/yyyy";
            dpkDataDate.Format = DateTimePickerFormat.Custom;
            dpkDataDate.Location = new Point(447, 27);
            dpkDataDate.Name = "dpkDataDate";
            dpkDataDate.Size = new Size(147, 27);
            dpkDataDate.TabIndex = 2;
            // 
            // cbxDepartment
            // 
            cbxDepartment.FormattingEnabled = true;
            cbxDepartment.Location = new Point(128, 26);
            cbxDepartment.Name = "cbxDepartment";
            cbxDepartment.Size = new Size(172, 28);
            cbxDepartment.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(6, 91);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(144, 42);
            btnTimKiem.TabIndex = 0;
            btnTimKiem.Text = "Search";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 26.4264259F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 73.57357F));
            tableLayoutPanel1.Size = new Size(987, 666);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(dgvData, 0, 1);
            tableLayoutPanel3.Controls.Add(panel1, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 179);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 8.677686F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 91.32231F));
            tableLayoutPanel3.Size = new Size(981, 484);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Dock = DockStyle.Fill;
            dgvData.Location = new Point(3, 45);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersWidth = 51;
            dgvData.RowTemplate.Height = 29;
            dgvData.Size = new Size(975, 436);
            dgvData.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblTotal);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(975, 36);
            panel1.TabIndex = 1;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(6, 7);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(77, 20);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "Tổng số: 0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(880, 7);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 6;
            // 
            // frmIncome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(987, 666);
            Controls.Add(tableLayoutPanel1);
            Name = "frmIncome";
            Text = "frmIncome";
            Load += frmIncome_Load;
            tableLayoutPanel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private ProgressBar prgBar;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private DateTimePicker dpkDataDate;
        private ComboBox cbxDepartment;
        private Button btnTimKiem;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel3;
        private DataGridView dgvData;
        private Panel panel1;
        private Label lblTotal;
        private Button btnSendMail;
        private Label label3;
    }
}