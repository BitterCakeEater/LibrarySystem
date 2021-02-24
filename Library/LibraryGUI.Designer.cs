namespace Library
{
    partial class LibraryGUI
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibraryGUI));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage_Register = new System.Windows.Forms.TabPage();
            this.button_Look_For_Books = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Delete_Reader = new System.Windows.Forms.Button();
            this.button_Edit_Reader = new System.Windows.Forms.Button();
            this.button_Add_Reader = new System.Windows.Forms.Button();
            this.dataGridView_Register = new System.Windows.Forms.DataGridView();
            this.Column_Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Patronymic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Card_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Issue_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage_Catalog = new System.Windows.Forms.TabPage();
            this.button_Info = new System.Windows.Forms.Button();
            this.button_Find = new System.Windows.Forms.Button();
            this.textBox_Input_To_Find = new System.Windows.Forms.TextBox();
            this.button_Delete_Section = new System.Windows.Forms.Button();
            this.button_Add_Section = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_Catalog = new System.Windows.Forms.DataGridView();
            this.Column_Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Authors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Cipher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Place = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_AllBooks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Available = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage_Additional_Info = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker_Second_Date = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_First_Date = new System.Windows.Forms.DateTimePicker();
            this.button_Find_Info = new System.Windows.Forms.Button();
            this.groupBox_Buttons = new System.Windows.Forms.GroupBox();
            this.radioButton_Returned_Books = new System.Windows.Forms.RadioButton();
            this.radioButton_Issued_Books = new System.Windows.Forms.RadioButton();
            this.dataGridView_Books_Info = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Copy_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl.SuspendLayout();
            this.tabPage_Register.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Register)).BeginInit();
            this.tabPage_Catalog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Catalog)).BeginInit();
            this.tabPage_Additional_Info.SuspendLayout();
            this.groupBox_Buttons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Books_Info)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPage_Register);
            this.tabControl.Controls.Add(this.tabPage_Catalog);
            this.tabControl.Controls.Add(this.tabPage_Additional_Info);
            this.tabControl.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl.Location = new System.Drawing.Point(4, 6);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1044, 467);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage_Register
            // 
            this.tabPage_Register.Controls.Add(this.button_Look_For_Books);
            this.tabPage_Register.Controls.Add(this.label1);
            this.tabPage_Register.Controls.Add(this.button_Delete_Reader);
            this.tabPage_Register.Controls.Add(this.button_Edit_Reader);
            this.tabPage_Register.Controls.Add(this.button_Add_Reader);
            this.tabPage_Register.Controls.Add(this.dataGridView_Register);
            this.tabPage_Register.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage_Register.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Register.Name = "tabPage_Register";
            this.tabPage_Register.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Register.Size = new System.Drawing.Size(1036, 438);
            this.tabPage_Register.TabIndex = 1;
            this.tabPage_Register.Text = "Реєстр";
            this.tabPage_Register.UseVisualStyleBackColor = true;
            // 
            // button_Look_For_Books
            // 
            this.button_Look_For_Books.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Look_For_Books.BackColor = System.Drawing.Color.Snow;
            this.button_Look_For_Books.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Look_For_Books.Location = new System.Drawing.Point(782, 397);
            this.button_Look_For_Books.Name = "button_Look_For_Books";
            this.button_Look_For_Books.Size = new System.Drawing.Size(248, 36);
            this.button_Look_For_Books.TabIndex = 5;
            this.button_Look_For_Books.Text = "Переглянути книги, наявні у читача";
            this.button_Look_For_Books.UseVisualStyleBackColor = false;
            this.button_Look_For_Books.Click += new System.EventHandler(this.button_Look_For_Books_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "Реєстраційний список";
            // 
            // button_Delete_Reader
            // 
            this.button_Delete_Reader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Delete_Reader.BackColor = System.Drawing.Color.Snow;
            this.button_Delete_Reader.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Delete_Reader.Location = new System.Drawing.Point(928, 6);
            this.button_Delete_Reader.Name = "button_Delete_Reader";
            this.button_Delete_Reader.Size = new System.Drawing.Size(102, 32);
            this.button_Delete_Reader.TabIndex = 3;
            this.button_Delete_Reader.Text = "Видалити читача";
            this.button_Delete_Reader.UseVisualStyleBackColor = false;
            this.button_Delete_Reader.Click += new System.EventHandler(this.button_Delete_Reader_Click);
            // 
            // button_Edit_Reader
            // 
            this.button_Edit_Reader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Edit_Reader.BackColor = System.Drawing.Color.Snow;
            this.button_Edit_Reader.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Edit_Reader.Location = new System.Drawing.Point(770, 6);
            this.button_Edit_Reader.Name = "button_Edit_Reader";
            this.button_Edit_Reader.Size = new System.Drawing.Size(152, 32);
            this.button_Edit_Reader.TabIndex = 2;
            this.button_Edit_Reader.Text = "Редагувати інформацію";
            this.button_Edit_Reader.UseVisualStyleBackColor = false;
            this.button_Edit_Reader.Click += new System.EventHandler(this.button_Edit_Reader_Click);
            // 
            // button_Add_Reader
            // 
            this.button_Add_Reader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Add_Reader.BackColor = System.Drawing.Color.Snow;
            this.button_Add_Reader.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Add_Reader.Location = new System.Drawing.Point(660, 6);
            this.button_Add_Reader.Name = "button_Add_Reader";
            this.button_Add_Reader.Size = new System.Drawing.Size(102, 32);
            this.button_Add_Reader.TabIndex = 1;
            this.button_Add_Reader.Text = "Додати читача";
            this.button_Add_Reader.UseVisualStyleBackColor = false;
            this.button_Add_Reader.Click += new System.EventHandler(this.button_Add_Reader_Click);
            // 
            // dataGridView_Register
            // 
            this.dataGridView_Register.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridView_Register.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Register.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Register.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Register.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView_Register.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Register.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Surname,
            this.Column_Name,
            this.Column_Patronymic,
            this.Column_Card_Number,
            this.Column_Issue_Date});
            this.dataGridView_Register.Location = new System.Drawing.Point(6, 44);
            this.dataGridView_Register.MultiSelect = false;
            this.dataGridView_Register.Name = "dataGridView_Register";
            this.dataGridView_Register.RowHeadersVisible = false;
            this.dataGridView_Register.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Register.Size = new System.Drawing.Size(1024, 346);
            this.dataGridView_Register.TabIndex = 0;
            // 
            // Column_Surname
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Column_Surname.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column_Surname.HeaderText = "Прізвище";
            this.Column_Surname.Name = "Column_Surname";
            this.Column_Surname.ReadOnly = true;
            // 
            // Column_Name
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Column_Name.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column_Name.HeaderText = "Ім\'я";
            this.Column_Name.Name = "Column_Name";
            this.Column_Name.ReadOnly = true;
            // 
            // Column_Patronymic
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Column_Patronymic.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column_Patronymic.HeaderText = "По батькові";
            this.Column_Patronymic.Name = "Column_Patronymic";
            this.Column_Patronymic.ReadOnly = true;
            // 
            // Column_Card_Number
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Column_Card_Number.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column_Card_Number.HeaderText = "Номер білета";
            this.Column_Card_Number.Name = "Column_Card_Number";
            this.Column_Card_Number.ReadOnly = true;
            // 
            // Column_Issue_Date
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Column_Issue_Date.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column_Issue_Date.HeaderText = "Дата видачі";
            this.Column_Issue_Date.Name = "Column_Issue_Date";
            this.Column_Issue_Date.ReadOnly = true;
            // 
            // tabPage_Catalog
            // 
            this.tabPage_Catalog.Controls.Add(this.button_Info);
            this.tabPage_Catalog.Controls.Add(this.button_Find);
            this.tabPage_Catalog.Controls.Add(this.textBox_Input_To_Find);
            this.tabPage_Catalog.Controls.Add(this.button_Delete_Section);
            this.tabPage_Catalog.Controls.Add(this.button_Add_Section);
            this.tabPage_Catalog.Controls.Add(this.label2);
            this.tabPage_Catalog.Controls.Add(this.dataGridView_Catalog);
            this.tabPage_Catalog.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Catalog.Name = "tabPage_Catalog";
            this.tabPage_Catalog.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Catalog.Size = new System.Drawing.Size(1036, 438);
            this.tabPage_Catalog.TabIndex = 2;
            this.tabPage_Catalog.Text = "Каталог";
            this.tabPage_Catalog.UseVisualStyleBackColor = true;
            // 
            // button_Info
            // 
            this.button_Info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_Info.BackColor = System.Drawing.Color.Snow;
            this.button_Info.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Info.Location = new System.Drawing.Point(327, 406);
            this.button_Info.Name = "button_Info";
            this.button_Info.Size = new System.Drawing.Size(170, 29);
            this.button_Info.TabIndex = 8;
            this.button_Info.Text = "Детальніше про книгу";
            this.button_Info.UseVisualStyleBackColor = false;
            this.button_Info.Click += new System.EventHandler(this.button_Info_Click);
            // 
            // button_Find
            // 
            this.button_Find.BackColor = System.Drawing.Color.Snow;
            this.button_Find.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Find.Location = new System.Drawing.Point(341, 6);
            this.button_Find.Name = "button_Find";
            this.button_Find.Size = new System.Drawing.Size(75, 31);
            this.button_Find.TabIndex = 7;
            this.button_Find.Text = "Пошук";
            this.button_Find.UseVisualStyleBackColor = false;
            this.button_Find.Click += new System.EventHandler(this.button_Find_Click);
            // 
            // textBox_Input_To_Find
            // 
            this.textBox_Input_To_Find.Location = new System.Drawing.Point(129, 14);
            this.textBox_Input_To_Find.Name = "textBox_Input_To_Find";
            this.textBox_Input_To_Find.Size = new System.Drawing.Size(206, 23);
            this.textBox_Input_To_Find.TabIndex = 6;
            // 
            // button_Delete_Section
            // 
            this.button_Delete_Section.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_Delete_Section.BackColor = System.Drawing.Color.Snow;
            this.button_Delete_Section.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Delete_Section.Location = new System.Drawing.Point(178, 406);
            this.button_Delete_Section.Name = "button_Delete_Section";
            this.button_Delete_Section.Size = new System.Drawing.Size(132, 29);
            this.button_Delete_Section.TabIndex = 4;
            this.button_Delete_Section.Text = "Видалити книгу";
            this.button_Delete_Section.UseVisualStyleBackColor = false;
            this.button_Delete_Section.Click += new System.EventHandler(this.button_Delete_Section_Click);
            // 
            // button_Add_Section
            // 
            this.button_Add_Section.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_Add_Section.BackColor = System.Drawing.Color.Snow;
            this.button_Add_Section.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Add_Section.Location = new System.Drawing.Point(1, 406);
            this.button_Add_Section.Name = "button_Add_Section";
            this.button_Add_Section.Size = new System.Drawing.Size(160, 29);
            this.button_Add_Section.TabIndex = 2;
            this.button_Add_Section.Text = "Додати нову книгу";
            this.button_Add_Section.UseVisualStyleBackColor = false;
            this.button_Add_Section.Click += new System.EventHandler(this.button_Add_Section_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Каталог";
            // 
            // dataGridView_Catalog
            // 
            this.dataGridView_Catalog.AllowUserToAddRows = false;
            this.dataGridView_Catalog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Catalog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Catalog.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView_Catalog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Catalog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Title,
            this.Column_Authors,
            this.Column_Cipher,
            this.Column_Year,
            this.Column_Place,
            this.Column_Publisher,
            this.Column_AllBooks,
            this.Column_Available});
            this.dataGridView_Catalog.Location = new System.Drawing.Point(4, 42);
            this.dataGridView_Catalog.Name = "dataGridView_Catalog";
            this.dataGridView_Catalog.RowHeadersVisible = false;
            this.dataGridView_Catalog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Catalog.Size = new System.Drawing.Size(1026, 355);
            this.dataGridView_Catalog.TabIndex = 0;
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
            // Column_AllBooks
            // 
            this.Column_AllBooks.FillWeight = 111.9404F;
            this.Column_AllBooks.HeaderText = "Загальна кількість";
            this.Column_AllBooks.Name = "Column_AllBooks";
            this.Column_AllBooks.ReadOnly = true;
            // 
            // Column_Available
            // 
            this.Column_Available.FillWeight = 111.9404F;
            this.Column_Available.HeaderText = "Доступно";
            this.Column_Available.Name = "Column_Available";
            this.Column_Available.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column_Available.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tabPage_Additional_Info
            // 
            this.tabPage_Additional_Info.Controls.Add(this.label4);
            this.tabPage_Additional_Info.Controls.Add(this.label3);
            this.tabPage_Additional_Info.Controls.Add(this.dateTimePicker_Second_Date);
            this.tabPage_Additional_Info.Controls.Add(this.dateTimePicker_First_Date);
            this.tabPage_Additional_Info.Controls.Add(this.button_Find_Info);
            this.tabPage_Additional_Info.Controls.Add(this.groupBox_Buttons);
            this.tabPage_Additional_Info.Controls.Add(this.dataGridView_Books_Info);
            this.tabPage_Additional_Info.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Additional_Info.Name = "tabPage_Additional_Info";
            this.tabPage_Additional_Info.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Additional_Info.Size = new System.Drawing.Size(1036, 438);
            this.tabPage_Additional_Info.TabIndex = 3;
            this.tabPage_Additional_Info.Text = "Довідкова Інформація";
            this.tabPage_Additional_Info.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(176, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Кінцева дата:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(176, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Початкова дата:";
            // 
            // dateTimePicker_Second_Date
            // 
            this.dateTimePicker_Second_Date.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker_Second_Date.Location = new System.Drawing.Point(306, 55);
            this.dateTimePicker_Second_Date.Name = "dateTimePicker_Second_Date";
            this.dateTimePicker_Second_Date.Size = new System.Drawing.Size(265, 27);
            this.dateTimePicker_Second_Date.TabIndex = 6;
            // 
            // dateTimePicker_First_Date
            // 
            this.dateTimePicker_First_Date.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker_First_Date.Location = new System.Drawing.Point(306, 10);
            this.dateTimePicker_First_Date.Name = "dateTimePicker_First_Date";
            this.dateTimePicker_First_Date.Size = new System.Drawing.Size(265, 27);
            this.dateTimePicker_First_Date.TabIndex = 5;
            // 
            // button_Find_Info
            // 
            this.button_Find_Info.BackColor = System.Drawing.Color.Snow;
            this.button_Find_Info.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Find_Info.Location = new System.Drawing.Point(577, 29);
            this.button_Find_Info.Name = "button_Find_Info";
            this.button_Find_Info.Size = new System.Drawing.Size(85, 36);
            this.button_Find_Info.TabIndex = 4;
            this.button_Find_Info.Text = "Пошук";
            this.button_Find_Info.UseVisualStyleBackColor = false;
            this.button_Find_Info.Click += new System.EventHandler(this.button_Find_Info_Click);
            // 
            // groupBox_Buttons
            // 
            this.groupBox_Buttons.Controls.Add(this.radioButton_Returned_Books);
            this.groupBox_Buttons.Controls.Add(this.radioButton_Issued_Books);
            this.groupBox_Buttons.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_Buttons.Location = new System.Drawing.Point(6, 6);
            this.groupBox_Buttons.Name = "groupBox_Buttons";
            this.groupBox_Buttons.Size = new System.Drawing.Size(152, 80);
            this.groupBox_Buttons.TabIndex = 3;
            this.groupBox_Buttons.TabStop = false;
            this.groupBox_Buttons.Text = "Режим пошуку";
            // 
            // radioButton_Returned_Books
            // 
            this.radioButton_Returned_Books.AutoSize = true;
            this.radioButton_Returned_Books.Location = new System.Drawing.Point(6, 51);
            this.radioButton_Returned_Books.Name = "radioButton_Returned_Books";
            this.radioButton_Returned_Books.Size = new System.Drawing.Size(121, 25);
            this.radioButton_Returned_Books.TabIndex = 1;
            this.radioButton_Returned_Books.TabStop = true;
            this.radioButton_Returned_Books.Text = "Повернені книги";
            this.radioButton_Returned_Books.UseVisualStyleBackColor = true;
            // 
            // radioButton_Issued_Books
            // 
            this.radioButton_Issued_Books.AutoSize = true;
            this.radioButton_Issued_Books.Location = new System.Drawing.Point(6, 23);
            this.radioButton_Issued_Books.Name = "radioButton_Issued_Books";
            this.radioButton_Issued_Books.Size = new System.Drawing.Size(102, 25);
            this.radioButton_Issued_Books.TabIndex = 0;
            this.radioButton_Issued_Books.TabStop = true;
            this.radioButton_Issued_Books.Text = "Видані книги";
            this.radioButton_Issued_Books.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Books_Info
            // 
            this.dataGridView_Books_Info.AllowUserToAddRows = false;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridView_Books_Info.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView_Books_Info.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Books_Info.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Books_Info.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView_Books_Info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Books_Info.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Column_Copy_Number,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridView_Books_Info.Location = new System.Drawing.Point(6, 100);
            this.dataGridView_Books_Info.Name = "dataGridView_Books_Info";
            this.dataGridView_Books_Info.RowHeadersVisible = false;
            this.dataGridView_Books_Info.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Books_Info.Size = new System.Drawing.Size(1024, 338);
            this.dataGridView_Books_Info.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn1.FillWeight = 111.9404F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Назва книги";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 111.9404F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Автор";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.FillWeight = 111.9404F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Шифр";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // Column_Copy_Number
            // 
            this.Column_Copy_Number.HeaderText = "Номер екземпляру";
            this.Column_Copy_Number.Name = "Column_Copy_Number";
            this.Column_Copy_Number.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.FillWeight = 111.9404F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Рік видання";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.FillWeight = 111.9404F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Місце видання";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.FillWeight = 111.9404F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Назва видавництва";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // LibraryGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 485);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(680, 320);
            this.Name = "LibraryGUI";
            this.Text = "Бібліотека";
            this.tabControl.ResumeLayout(false);
            this.tabPage_Register.ResumeLayout(false);
            this.tabPage_Register.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Register)).EndInit();
            this.tabPage_Catalog.ResumeLayout(false);
            this.tabPage_Catalog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Catalog)).EndInit();
            this.tabPage_Additional_Info.ResumeLayout(false);
            this.tabPage_Additional_Info.PerformLayout();
            this.groupBox_Buttons.ResumeLayout(false);
            this.groupBox_Buttons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Books_Info)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage_Register;
        private System.Windows.Forms.DataGridView dataGridView_Register;
        private System.Windows.Forms.Button button_Delete_Reader;
        private System.Windows.Forms.Button button_Edit_Reader;
        private System.Windows.Forms.Button button_Add_Reader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage_Catalog;
        private System.Windows.Forms.DataGridView dataGridView_Catalog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Add_Section;
        private System.Windows.Forms.Button button_Delete_Section;
        private System.Windows.Forms.Button button_Find;
        private System.Windows.Forms.TextBox textBox_Input_To_Find;
        private System.Windows.Forms.Button button_Info;
        private System.Windows.Forms.Button button_Look_For_Books;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Authors;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Cipher;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Place;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_AllBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Available;
        private System.Windows.Forms.TabPage tabPage_Additional_Info;
        public System.Windows.Forms.DataGridView dataGridView_Books_Info;
        private System.Windows.Forms.GroupBox groupBox_Buttons;
        private System.Windows.Forms.RadioButton radioButton_Returned_Books;
        private System.Windows.Forms.RadioButton radioButton_Issued_Books;
        private System.Windows.Forms.Button button_Find_Info;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Second_Date;
        private System.Windows.Forms.DateTimePicker dateTimePicker_First_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Patronymic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Card_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Issue_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Copy_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}

