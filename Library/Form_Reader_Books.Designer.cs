namespace Library
{
    partial class Form_Reader_Books
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Reader_Books));
            this.label_Card_Number = new System.Windows.Forms.Label();
            this.dataGridView_Catalog = new System.Windows.Forms.DataGridView();
            this.Column_Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Authors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Cipher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Copy_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Place = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Catalog)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Card_Number
            // 
            this.label_Card_Number.AutoSize = true;
            this.label_Card_Number.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Card_Number.Location = new System.Drawing.Point(12, 13);
            this.label_Card_Number.Name = "label_Card_Number";
            this.label_Card_Number.Size = new System.Drawing.Size(138, 23);
            this.label_Card_Number.TabIndex = 0;
            this.label_Card_Number.Text = "Номер читача: ";
            // 
            // dataGridView_Catalog
            // 
            this.dataGridView_Catalog.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridView_Catalog.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Catalog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Catalog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Catalog.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Catalog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Catalog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Catalog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Title,
            this.Column_Authors,
            this.Column_Cipher,
            this.Column_Copy_Number,
            this.Column_Year,
            this.Column_Place,
            this.Column_Publisher});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Catalog.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_Catalog.Location = new System.Drawing.Point(4, 49);
            this.dataGridView_Catalog.Name = "dataGridView_Catalog";
            this.dataGridView_Catalog.RowHeadersVisible = false;
            this.dataGridView_Catalog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Catalog.Size = new System.Drawing.Size(873, 269);
            this.dataGridView_Catalog.TabIndex = 1;
            // 
            // Column_Title
            // 
            this.Column_Title.FillWeight = 111.9404F;
            this.Column_Title.HeaderText = "Назва книги";
            this.Column_Title.Name = "Column_Title";
            this.Column_Title.ReadOnly = true;
            // 
            // Column_Authors
            // 
            this.Column_Authors.FillWeight = 111.9404F;
            this.Column_Authors.HeaderText = "Автор";
            this.Column_Authors.Name = "Column_Authors";
            this.Column_Authors.ReadOnly = true;
            // 
            // Column_Cipher
            // 
            this.Column_Cipher.FillWeight = 111.9404F;
            this.Column_Cipher.HeaderText = "Шифр";
            this.Column_Cipher.Name = "Column_Cipher";
            this.Column_Cipher.ReadOnly = true;
            // 
            // Column_Copy_Number
            // 
            this.Column_Copy_Number.HeaderText = "Номер екземпляру";
            this.Column_Copy_Number.Name = "Column_Copy_Number";
            this.Column_Copy_Number.ReadOnly = true;
            // 
            // Column_Year
            // 
            this.Column_Year.FillWeight = 111.9404F;
            this.Column_Year.HeaderText = "Рік видання";
            this.Column_Year.Name = "Column_Year";
            this.Column_Year.ReadOnly = true;
            // 
            // Column_Place
            // 
            this.Column_Place.FillWeight = 111.9404F;
            this.Column_Place.HeaderText = "Місце видання";
            this.Column_Place.Name = "Column_Place";
            this.Column_Place.ReadOnly = true;
            // 
            // Column_Publisher
            // 
            this.Column_Publisher.FillWeight = 111.9404F;
            this.Column_Publisher.HeaderText = "Назва видавництва";
            this.Column_Publisher.Name = "Column_Publisher";
            this.Column_Publisher.ReadOnly = true;
            // 
            // Form_Reader_Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 324);
            this.Controls.Add(this.dataGridView_Catalog);
            this.Controls.Add(this.label_Card_Number);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(680, 320);
            this.Name = "Form_Reader_Books";
            this.Text = "Книги читача";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Catalog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label_Card_Number;
        public System.Windows.Forms.DataGridView dataGridView_Catalog;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Authors;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Cipher;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Copy_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Place;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Publisher;
    }
}