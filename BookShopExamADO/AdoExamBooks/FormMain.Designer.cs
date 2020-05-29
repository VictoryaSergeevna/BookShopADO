namespace AdoExamBooks
{
    partial class FormMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.dataGridViewAllBooks = new System.Windows.Forms.DataGridView();
            this.buttonSerch = new System.Windows.Forms.Button();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.buttonMostPopular = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnNewBook = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnReserve = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.BurlyWood;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Image = global::AdoExamBooks.Properties.Resources.Book2;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Логин:";
            // 
            // textBoxLog
            // 
            this.textBoxLog.Location = new System.Drawing.Point(77, 12);
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.Size = new System.Drawing.Size(164, 20);
            this.textBoxLog.TabIndex = 19;
            // 
            // dataGridViewAllBooks
            // 
            this.dataGridViewAllBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllBooks.Location = new System.Drawing.Point(12, 38);
            this.dataGridViewAllBooks.Name = "dataGridViewAllBooks";
            this.dataGridViewAllBooks.Size = new System.Drawing.Size(679, 279);
            this.dataGridViewAllBooks.TabIndex = 20;
            // 
            // buttonSerch
            // 
            this.buttonSerch.BackgroundImage = global::AdoExamBooks.Properties.Resources.Book2;
            this.buttonSerch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSerch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSerch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSerch.Location = new System.Drawing.Point(697, 12);
            this.buttonSerch.Name = "buttonSerch";
            this.buttonSerch.Size = new System.Drawing.Size(91, 29);
            this.buttonSerch.TabIndex = 21;
            this.buttonSerch.Text = "Search";
            this.buttonSerch.UseVisualStyleBackColor = true;
            this.buttonSerch.Click += new System.EventHandler(this.buttonSerch_Click);
            // 
            // buttonBuy
            // 
            this.buttonBuy.BackgroundImage = global::AdoExamBooks.Properties.Resources.Book2;
            this.buttonBuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBuy.Location = new System.Drawing.Point(697, 107);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(91, 30);
            this.buttonBuy.TabIndex = 22;
            this.buttonBuy.Text = "Buy";
            this.buttonBuy.UseVisualStyleBackColor = true;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // buttonMostPopular
            // 
            this.buttonMostPopular.BackgroundImage = global::AdoExamBooks.Properties.Resources.Book2;
            this.buttonMostPopular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonMostPopular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMostPopular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMostPopular.Location = new System.Drawing.Point(697, 233);
            this.buttonMostPopular.Name = "buttonMostPopular";
            this.buttonMostPopular.Size = new System.Drawing.Size(91, 43);
            this.buttonMostPopular.TabIndex = 24;
            this.buttonMostPopular.Text = "Most popular";
            this.buttonMostPopular.UseVisualStyleBackColor = true;
            this.buttonMostPopular.Click += new System.EventHandler(this.buttonMostPopular_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackgroundImage = global::AdoExamBooks.Properties.Resources.Book2;
            this.buttonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(581, 409);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(110, 33);
            this.buttonDelete.TabIndex = 25;
            this.buttonDelete.Text = "Delete book";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackgroundImage = global::AdoExamBooks.Properties.Resources.Book2;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.Location = new System.Drawing.Point(350, 409);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(110, 31);
            this.buttonEdit.TabIndex = 26;
            this.buttonEdit.Text = "Edit book";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackgroundImage = global::AdoExamBooks.Properties.Resources.Book2;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(15, 409);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(110, 29);
            this.buttonAdd.TabIndex = 27;
            this.buttonAdd.Text = "Add book";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // btnStock
            // 
            this.btnStock.BackgroundImage = global::AdoExamBooks.Properties.Resources.Book2;
            this.btnStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStock.Location = new System.Drawing.Point(697, 60);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(91, 29);
            this.btnStock.TabIndex = 28;
            this.btnStock.Text = "Stock";
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnNewBook
            // 
            this.btnNewBook.BackgroundImage = global::AdoExamBooks.Properties.Resources.Book2;
            this.btnNewBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNewBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNewBook.Location = new System.Drawing.Point(697, 157);
            this.btnNewBook.Name = "btnNewBook";
            this.btnNewBook.Size = new System.Drawing.Size(91, 58);
            this.btnNewBook.TabIndex = 29;
            this.btnNewBook.Text = "New book and Best seller";
            this.btnNewBook.UseVisualStyleBackColor = true;
            this.btnNewBook.Click += new System.EventHandler(this.btnNewBook_Click);
            // 
            // btnShow
            // 
            this.btnShow.BackgroundImage = global::AdoExamBooks.Properties.Resources.Book2;
            this.btnShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShow.Location = new System.Drawing.Point(350, 7);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(161, 28);
            this.btnShow.TabIndex = 30;
            this.btnShow.Text = "Show all book";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnReserve
            // 
            this.btnReserve.BackgroundImage = global::AdoExamBooks.Properties.Resources.Book2;
            this.btnReserve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReserve.Location = new System.Drawing.Point(697, 295);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(91, 43);
            this.btnReserve.TabIndex = 31;
            this.btnReserve.Text = "Reserve book";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AdoExamBooks.Properties.Resources.Book2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnNewBook);
            this.Controls.Add(this.btnStock);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonMostPopular);
            this.Controls.Add(this.buttonBuy);
            this.Controls.Add(this.buttonSerch);
            this.Controls.Add(this.dataGridViewAllBooks);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.label1);
            this.Name = "FormMain";
            this.Text = "FormMain";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.DataGridView dataGridViewAllBooks;
        private System.Windows.Forms.Button buttonSerch;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.Button buttonMostPopular;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnNewBook;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnReserve;
    }
}