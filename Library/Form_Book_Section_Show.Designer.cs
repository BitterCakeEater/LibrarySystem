namespace Library
{
    partial class Form_Book_Section_Show
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Book_Section_Show));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox_Author = new System.Windows.Forms.RichTextBox();
            this.richTextBox_Year = new System.Windows.Forms.RichTextBox();
            this.textBox_Amount = new System.Windows.Forms.TextBox();
            this.textBox_Available = new System.Windows.Forms.TextBox();
            this.richTextBox_Title = new System.Windows.Forms.RichTextBox();
            this.richTextBox_Cipher = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView_Copies = new System.Windows.Forms.DataGridView();
            this.Column_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Issue_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Return_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Owner_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_Review = new System.Windows.Forms.Button();
            this.button_Take = new System.Windows.Forms.Button();
            this.button_Return = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Copies)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Назва:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(412, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Автор:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(14, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Рік видання:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(408, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Кількість:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(408, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Доступно:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // richTextBox_Author
            // 
            this.richTextBox_Author.Enabled = false;
            this.richTextBox_Author.Font = new System.Drawing.Font("Bahnschrift", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox_Author.Location = new System.Drawing.Point(482, 45);
            this.richTextBox_Author.Name = "richTextBox_Author";
            this.richTextBox_Author.Size = new System.Drawing.Size(309, 28);
            this.richTextBox_Author.TabIndex = 6;
            this.richTextBox_Author.Text = "";
            this.richTextBox_Author.TextChanged += new System.EventHandler(this.richTextBox_Author_TextChanged);
            // 
            // richTextBox_Year
            // 
            this.richTextBox_Year.Enabled = false;
            this.richTextBox_Year.Font = new System.Drawing.Font("Bahnschrift", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox_Year.Location = new System.Drawing.Point(136, 93);
            this.richTextBox_Year.Name = "richTextBox_Year";
            this.richTextBox_Year.Size = new System.Drawing.Size(108, 27);
            this.richTextBox_Year.TabIndex = 7;
            this.richTextBox_Year.Text = "";
            this.richTextBox_Year.TextChanged += new System.EventHandler(this.richTextBox_Year_TextChanged);
            // 
            // textBox_Amount
            // 
            this.textBox_Amount.Enabled = false;
            this.textBox_Amount.Font = new System.Drawing.Font("Bahnschrift", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Amount.Location = new System.Drawing.Point(504, 93);
            this.textBox_Amount.Name = "textBox_Amount";
            this.textBox_Amount.Size = new System.Drawing.Size(100, 28);
            this.textBox_Amount.TabIndex = 8;
            this.textBox_Amount.TextChanged += new System.EventHandler(this.textBox_Amount_TextChanged);
            // 
            // textBox_Available
            // 
            this.textBox_Available.Enabled = false;
            this.textBox_Available.Font = new System.Drawing.Font("Bahnschrift", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Available.Location = new System.Drawing.Point(504, 137);
            this.textBox_Available.Name = "textBox_Available";
            this.textBox_Available.Size = new System.Drawing.Size(100, 28);
            this.textBox_Available.TabIndex = 9;
            this.textBox_Available.TextChanged += new System.EventHandler(this.textBox_Available_TextChanged);
            // 
            // richTextBox_Title
            // 
            this.richTextBox_Title.Enabled = false;
            this.richTextBox_Title.Font = new System.Drawing.Font("Bahnschrift", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox_Title.Location = new System.Drawing.Point(87, 45);
            this.richTextBox_Title.Name = "richTextBox_Title";
            this.richTextBox_Title.Size = new System.Drawing.Size(287, 29);
            this.richTextBox_Title.TabIndex = 10;
            this.richTextBox_Title.Text = "";
            this.richTextBox_Title.TextChanged += new System.EventHandler(this.richTextBox_Title_TextChanged);
            // 
            // richTextBox_Cipher
            // 
            this.richTextBox_Cipher.Enabled = false;
            this.richTextBox_Cipher.Font = new System.Drawing.Font("Bahnschrift", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox_Cipher.Location = new System.Drawing.Point(87, 139);
            this.richTextBox_Cipher.Name = "richTextBox_Cipher";
            this.richTextBox_Cipher.Size = new System.Drawing.Size(157, 27);
            this.richTextBox_Cipher.TabIndex = 12;
            this.richTextBox_Cipher.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(17, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Шифр:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(16, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(287, 29);
            this.label7.TabIndex = 13;
            this.label7.Text = "Інформація про екземпляри книги";
            // 
            // dataGridView_Copies
            // 
            this.dataGridView_Copies.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridView_Copies.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Copies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Copies.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Copies.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Copies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Copies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Number,
            this.Column_Status,
            this.Column_Issue_Date,
            this.Column_Return_Date,
            this.Column_Owner_Id});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Copies.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_Copies.Location = new System.Drawing.Point(16, 171);
            this.dataGridView_Copies.MultiSelect = false;
            this.dataGridView_Copies.Name = "dataGridView_Copies";
            this.dataGridView_Copies.RowHeadersVisible = false;
            this.dataGridView_Copies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Copies.Size = new System.Drawing.Size(655, 280);
            this.dataGridView_Copies.TabIndex = 14;
            // 
            // Column_Number
            // 
            this.Column_Number.HeaderText = "Номер екземпляру";
            this.Column_Number.Name = "Column_Number";
            this.Column_Number.ReadOnly = true;
            // 
            // Column_Status
            // 
            this.Column_Status.HeaderText = "Статус";
            this.Column_Status.Name = "Column_Status";
            this.Column_Status.ReadOnly = true;
            // 
            // Column_Issue_Date
            // 
            this.Column_Issue_Date.HeaderText = "Дата видачі";
            this.Column_Issue_Date.Name = "Column_Issue_Date";
            this.Column_Issue_Date.ReadOnly = true;
            // 
            // Column_Return_Date
            // 
            this.Column_Return_Date.HeaderText = "Дата повернення";
            this.Column_Return_Date.Name = "Column_Return_Date";
            this.Column_Return_Date.ReadOnly = true;
            // 
            // Column_Owner_Id
            // 
            this.Column_Owner_Id.HeaderText = "Номер читача";
            this.Column_Owner_Id.Name = "Column_Owner_Id";
            this.Column_Owner_Id.ReadOnly = true;
            // 
            // button_Review
            // 
            this.button_Review.BackColor = System.Drawing.Color.Snow;
            this.button_Review.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Review.Location = new System.Drawing.Point(679, 196);
            this.button_Review.Name = "button_Review";
            this.button_Review.Size = new System.Drawing.Size(112, 28);
            this.button_Review.TabIndex = 15;
            this.button_Review.Text = "Картка";
            this.button_Review.UseVisualStyleBackColor = false;
            this.button_Review.Click += new System.EventHandler(this.button_Review_Click);
            // 
            // button_Take
            // 
            this.button_Take.BackColor = System.Drawing.Color.Snow;
            this.button_Take.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Take.Location = new System.Drawing.Point(677, 273);
            this.button_Take.Name = "button_Take";
            this.button_Take.Size = new System.Drawing.Size(112, 28);
            this.button_Take.TabIndex = 16;
            this.button_Take.Text = "Взяти";
            this.button_Take.UseVisualStyleBackColor = false;
            this.button_Take.Click += new System.EventHandler(this.button_Take_Click);
            // 
            // button_Return
            // 
            this.button_Return.BackColor = System.Drawing.Color.Snow;
            this.button_Return.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Return.Location = new System.Drawing.Point(679, 307);
            this.button_Return.Name = "button_Return";
            this.button_Return.Size = new System.Drawing.Size(114, 30);
            this.button_Return.TabIndex = 17;
            this.button_Return.Text = "Повернути";
            this.button_Return.UseVisualStyleBackColor = false;
            this.button_Return.Click += new System.EventHandler(this.button_Return_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.Color.Snow;
            this.button_Delete.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Delete.Location = new System.Drawing.Point(679, 411);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(113, 30);
            this.button_Delete.TabIndex = 18;
            this.button_Delete.Text = "Видалити";
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Add
            // 
            this.button_Add.BackColor = System.Drawing.Color.Snow;
            this.button_Add.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Add.Location = new System.Drawing.Point(679, 375);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(113, 30);
            this.button_Add.TabIndex = 19;
            this.button_Add.Text = "Додати";
            this.button_Add.UseVisualStyleBackColor = false;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // Form_Book_Section_Show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 463);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Return);
            this.Controls.Add(this.button_Take);
            this.Controls.Add(this.button_Review);
            this.Controls.Add(this.dataGridView_Copies);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.richTextBox_Cipher);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.richTextBox_Title);
            this.Controls.Add(this.textBox_Available);
            this.Controls.Add(this.textBox_Amount);
            this.Controls.Add(this.richTextBox_Year);
            this.Controls.Add(this.richTextBox_Author);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Book_Section_Show";
            this.Text = "Інформація про книгу";
            this.Load += new System.EventHandler(this.Form_Book_Section_Show_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Copies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.RichTextBox richTextBox_Author;
        public System.Windows.Forms.RichTextBox richTextBox_Year;
        public System.Windows.Forms.TextBox textBox_Amount;
        public System.Windows.Forms.TextBox textBox_Available;
        public System.Windows.Forms.RichTextBox richTextBox_Title;
        public System.Windows.Forms.RichTextBox richTextBox_Cipher;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_Review;
        private System.Windows.Forms.Button button_Take;
        private System.Windows.Forms.Button button_Return;
        public System.Windows.Forms.DataGridView dataGridView_Copies;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Issue_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Return_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Owner_Id;
    }
}