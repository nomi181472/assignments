
namespace K173652_Q3_
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
            this.label1 = new System.Windows.Forms.Label();
            this.dropdownDay = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CategoriesDropdown = new System.Windows.Forms.ComboBox();
            this.Table = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Day";
            // 
            // dropdownDay
            // 
            this.dropdownDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdownDay.FormattingEnabled = true;
            this.dropdownDay.Location = new System.Drawing.Point(130, 9);
            this.dropdownDay.Name = "dropdownDay";
            this.dropdownDay.Size = new System.Drawing.Size(600, 23);
            this.dropdownDay.TabIndex = 1;
            this.dropdownDay.SelectedIndexChanged += new System.EventHandler(this.dropdownDay_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Category";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // CategoriesDropdown
            // 
            this.CategoriesDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoriesDropdown.FormattingEnabled = true;
            this.CategoriesDropdown.Location = new System.Drawing.Point(130, 53);
            this.CategoriesDropdown.Name = "CategoriesDropdown";
            this.CategoriesDropdown.Size = new System.Drawing.Size(600, 23);
            this.CategoriesDropdown.TabIndex = 3;
            this.CategoriesDropdown.SelectedIndexChanged += new System.EventHandler(this.CategoriesDropdown_SelectedIndexChanged);
            // 
            // Table
            // 
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.Table.Location = new System.Drawing.Point(130, 99);
            this.Table.Name = "Table";
            this.Table.RowTemplate.Height = 25;
            this.Table.Size = new System.Drawing.Size(600, 339);
            this.Table.TabIndex = 4;
            this.Table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Table_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "SNo.";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Script";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 430;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Price";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 80;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.CategoriesDropdown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dropdownDay);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox dropdownDay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CategoriesDropdown;
        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

