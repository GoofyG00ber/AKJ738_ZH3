namespace AKJ738_ZH3
{
    partial class UserControl3
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
            TickerId = new DataGridViewTextBoxColumn();
            TradeDate = new DataGridViewTextBoxColumn();
            OpenPrice = new DataGridViewTextBoxColumn();
            ClosePrice = new DataGridViewTextBoxColumn();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dailyPriceBindingSource = new BindingSource(components);
            tickerBindingSource = new BindingSource(components);
            label1 = new Label();
            button1 = new Button();
            listBox1 = new ListBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dailyPriceBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tickerBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { TickerId, TradeDate, OpenPrice, ClosePrice, idDataGridViewTextBoxColumn });
            dataGridView1.DataSource = dailyPriceBindingSource;
            dataGridView1.Location = new Point(129, 124);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(442, 493);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // TickerId
            // 
            TickerId.DataPropertyName = "TickerId";
            TickerId.HeaderText = "TickerId";
            TickerId.Name = "TickerId";
            // 
            // TradeDate
            // 
            TradeDate.DataPropertyName = "TradeDate";
            TradeDate.HeaderText = "TradeDate";
            TradeDate.Name = "TradeDate";
            // 
            // OpenPrice
            // 
            OpenPrice.DataPropertyName = "OpenPrice";
            OpenPrice.HeaderText = "OpenPrice";
            OpenPrice.Name = "OpenPrice";
            // 
            // ClosePrice
            // 
            ClosePrice.DataPropertyName = "ClosePrice";
            ClosePrice.HeaderText = "ClosePrice";
            ClosePrice.Name = "ClosePrice";
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // dailyPriceBindingSource
            // 
            dailyPriceBindingSource.DataSource = typeof(Models.DailyPrice);
            // 
            // tickerBindingSource
            // 
            tickerBindingSource.DataSource = typeof(Models.Ticker);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(190, 30);
            label1.TabIndex = 1;
            label1.Text = "Árak lista nézetben";
            // 
            // button1
            // 
            button1.Location = new Point(129, 95);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Mentés";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.DataSource = tickerBindingSource;
            listBox1.DisplayMember = "TickerSymbol";
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(3, 124);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 454);
            listBox1.TabIndex = 3;
            listBox1.ValueMember = "TickerId";
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new Point(3, 95);
            button2.Name = "button2";
            button2.Size = new Size(120, 23);
            button2.TabIndex = 4;
            button2.Text = "Összes";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // UserControl3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            Controls.Add(button2);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "UserControl3";
            Size = new Size(770, 584);
            Load += UserControl3_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dailyPriceBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)tickerBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource tickerBindingSource;
        private Label label1;
        private BindingSource dailyPriceBindingSource;
        private Button button1;
        private ListBox listBox1;
        private Button button2;
        private DataGridViewTextBoxColumn TickerId;
        private DataGridViewTextBoxColumn TradeDate;
        private DataGridViewTextBoxColumn OpenPrice;
        private DataGridViewTextBoxColumn ClosePrice;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    }
}
