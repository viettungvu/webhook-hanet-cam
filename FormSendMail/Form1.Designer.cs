namespace FormSendMail
{
    partial class Form1
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
            splitContainer1 = new SplitContainer();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1 = new Panel();
            button1 = new Button();
            plFilter = new FlowLayoutPanel();
            groupBox1 = new GroupBox();
            cbxPhongBan = new ComboBox();
            txtTerminal = new RichTextBox();
            splitter1 = new Splitter();
            tableLayoutPanel1 = new TableLayoutPanel();
            dgvData = new DataGridView();
            panel2 = new Panel();
            lblTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            plFilter.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tableLayoutPanel2);
            splitContainer1.Panel1.Controls.Add(splitter1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel1);
            splitContainer1.Size = new Size(1128, 580);
            splitContainer1.SplitterDistance = 428;
            splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(panel1, 0, 1);
            tableLayoutPanel2.Controls.Add(plFilter, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(4, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 82.93104F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 17.0689659F));
            tableLayoutPanel2.Size = new Size(424, 580);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 484);
            panel1.Name = "panel1";
            panel1.Size = new Size(418, 93);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(91, 13);
            button1.Name = "button1";
            button1.Size = new Size(119, 60);
            button1.TabIndex = 0;
            button1.Text = "Tìm kiếm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // plFilter
            // 
            plFilter.AutoScroll = true;
            plFilter.Controls.Add(groupBox1);
            plFilter.Controls.Add(txtTerminal);
            plFilter.Dock = DockStyle.Fill;
            plFilter.Location = new Point(3, 3);
            plFilter.Name = "plFilter";
            plFilter.Size = new Size(418, 475);
            plFilter.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbxPhongBan);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(298, 73);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Phòng/ban";
            // 
            // cbxPhongBan
            // 
            cbxPhongBan.FormattingEnabled = true;
            cbxPhongBan.Location = new Point(6, 36);
            cbxPhongBan.Name = "cbxPhongBan";
            cbxPhongBan.Size = new Size(286, 28);
            cbxPhongBan.TabIndex = 0;
            // 
            // txtTerminal
            // 
            txtTerminal.Location = new Point(3, 82);
            txtTerminal.Name = "txtTerminal";
            txtTerminal.Size = new Size(403, 258);
            txtTerminal.TabIndex = 1;
            txtTerminal.Text = "";
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 580);
            splitter1.TabIndex = 0;
            splitter1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(dgvData, 0, 1);
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.827586F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90.17242F));
            tableLayoutPanel1.Size = new Size(696, 580);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Dock = DockStyle.Fill;
            dgvData.Location = new Point(3, 60);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersWidth = 51;
            dgvData.RowTemplate.Height = 29;
            dgvData.ShowRowErrors = false;
            dgvData.Size = new Size(690, 517);
            dgvData.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblTotal);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(690, 51);
            panel2.TabIndex = 1;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(3, 31);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(77, 20);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "Tổng số: 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1128, 580);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            plFilter.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Splitter splitter1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private Button button1;
        private FlowLayoutPanel plFilter;
        private GroupBox groupBox1;
        private ComboBox cbxPhongBan;
        private DataGridView dgvData;
        private Panel panel2;
        private Label lblTotal;
        private RichTextBox txtTerminal;
    }
}