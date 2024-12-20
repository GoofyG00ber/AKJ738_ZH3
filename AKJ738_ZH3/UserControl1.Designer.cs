namespace AKJ738_ZH3
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            tickerIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            industryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            foundingDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            basicCompanyInfoBindingSource = new BindingSource(components);
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)basicCompanyInfoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { tickerIdDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, industryDataGridViewTextBoxColumn, foundingDateDataGridViewTextBoxColumn });
            dataGridView1.DataSource = basicCompanyInfoBindingSource;
            dataGridView1.Location = new Point(3, 96);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(644, 444);
            dataGridView1.TabIndex = 0;
            // 
            // tickerIdDataGridViewTextBoxColumn
            // 
            tickerIdDataGridViewTextBoxColumn.DataPropertyName = "TickerId";
            tickerIdDataGridViewTextBoxColumn.HeaderText = "TickerId";
            tickerIdDataGridViewTextBoxColumn.Name = "tickerIdDataGridViewTextBoxColumn";
            tickerIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            descriptionDataGridViewTextBoxColumn.Width = 300;
            // 
            // industryDataGridViewTextBoxColumn
            // 
            industryDataGridViewTextBoxColumn.DataPropertyName = "Industry";
            industryDataGridViewTextBoxColumn.HeaderText = "Industry";
            industryDataGridViewTextBoxColumn.Name = "industryDataGridViewTextBoxColumn";
            industryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // foundingDateDataGridViewTextBoxColumn
            // 
            foundingDateDataGridViewTextBoxColumn.DataPropertyName = "FoundingDate";
            foundingDateDataGridViewTextBoxColumn.HeaderText = "FoundingDate";
            foundingDateDataGridViewTextBoxColumn.Name = "foundingDateDataGridViewTextBoxColumn";
            foundingDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // basicCompanyInfoBindingSource
            // 
            basicCompanyInfoBindingSource.DataSource = typeof(Models.BasicCompanyInfo);
            // 
            // textBox1
            // 
            textBox1.Location = new Point(56, 67);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Copperplate Gothic Light", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(264, 38);
            label1.TabIndex = 2;
            label1.Text = "Tőzsde segéd";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 70);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 3;
            label2.Text = "Keresés";
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Name = "UserControl1";
            Size = new Size(647, 543);
            Load += UserControl1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)basicCompanyInfoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource basicCompanyInfoBindingSource;
        private TextBox textBox1;
        private DataGridViewTextBoxColumn tickerIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn industryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn foundingDateDataGridViewTextBoxColumn;
        private Label label1;
        private Label label2;
    }
}
