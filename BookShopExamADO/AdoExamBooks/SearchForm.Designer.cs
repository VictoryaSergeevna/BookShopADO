namespace AdoExamBooks
{
    partial class SearchForm
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
            this.cmbBoxName = new System.Windows.Forms.ComboBox();
            this.cmbBoxAuthor = new System.Windows.Forms.ComboBox();
            this.cmbBoxTheme = new System.Windows.Forms.ComboBox();
            this.dataGridViewSerchResult = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.buttonStartSerch = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSerchResult)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbBoxName
            // 
            this.cmbBoxName.FormattingEnabled = true;
            this.cmbBoxName.Location = new System.Drawing.Point(602, 68);
            this.cmbBoxName.Name = "cmbBoxName";
            this.cmbBoxName.Size = new System.Drawing.Size(155, 21);
            this.cmbBoxName.TabIndex = 10;
            // 
            // cmbBoxAuthor
            // 
            this.cmbBoxAuthor.FormattingEnabled = true;
            this.cmbBoxAuthor.Location = new System.Drawing.Point(602, 148);
            this.cmbBoxAuthor.Name = "cmbBoxAuthor";
            this.cmbBoxAuthor.Size = new System.Drawing.Size(155, 21);
            this.cmbBoxAuthor.TabIndex = 11;
            // 
            // cmbBoxTheme
            // 
            this.cmbBoxTheme.FormattingEnabled = true;
            this.cmbBoxTheme.Location = new System.Drawing.Point(602, 226);
            this.cmbBoxTheme.Name = "cmbBoxTheme";
            this.cmbBoxTheme.Size = new System.Drawing.Size(155, 21);
            this.cmbBoxTheme.TabIndex = 12;
            // 
            // dataGridViewSerchResult
            // 
            this.dataGridViewSerchResult.BackgroundColor = System.Drawing.Color.Moccasin;
            this.dataGridViewSerchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSerchResult.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewSerchResult.Name = "dataGridViewSerchResult";
            this.dataGridViewSerchResult.Size = new System.Drawing.Size(553, 284);
            this.dataGridViewSerchResult.TabIndex = 13;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.SandyBrown;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Image = global::AdoExamBooks.Properties.Resources.Book3;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnCancel.Location = new System.Drawing.Point(585, 313);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 32);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // buttonStartSerch
            // 
            this.buttonStartSerch.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonStartSerch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonStartSerch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStartSerch.Image = global::AdoExamBooks.Properties.Resources.Book3;
            this.buttonStartSerch.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buttonStartSerch.Location = new System.Drawing.Point(81, 313);
            this.buttonStartSerch.Name = "buttonStartSerch";
            this.buttonStartSerch.Size = new System.Drawing.Size(102, 32);
            this.buttonStartSerch.TabIndex = 27;
            this.buttonStartSerch.Text = "Search";
            this.buttonStartSerch.UseVisualStyleBackColor = false;
            this.buttonStartSerch.Click += new System.EventHandler(this.buttonStartSerch_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(602, 31);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(99, 17);
            this.checkBox1.TabIndex = 28;
            this.checkBox1.Text = "Name of Books";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(602, 110);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(105, 17);
            this.checkBox2.TabIndex = 29;
            this.checkBox2.Text = "Name of Authors";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(602, 190);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(107, 17);
            this.checkBox3.TabIndex = 30;
            this.checkBox3.Text = "Name of Themes";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AdoExamBooks.Properties.Resources.Book3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(769, 353);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.buttonStartSerch);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dataGridViewSerchResult);
            this.Controls.Add(this.cmbBoxTheme);
            this.Controls.Add(this.cmbBoxAuthor);
            this.Controls.Add(this.cmbBoxName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSerchResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbBoxName;
        private System.Windows.Forms.ComboBox cmbBoxAuthor;
        private System.Windows.Forms.ComboBox cmbBoxTheme;
        private System.Windows.Forms.DataGridView dataGridViewSerchResult;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button buttonStartSerch;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
    }
}