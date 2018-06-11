namespace oop_part05_form
{
    partial class App
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
            this.productName = new System.Windows.Forms.TextBox();
            this.productPrice = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.productListView = new System.Windows.Forms.RichTextBox();
            this.showButton = new System.Windows.Forms.Button();
            this.categoryList = new System.Windows.Forms.ComboBox();
            this.categoryName = new System.Windows.Forms.TextBox();
            this.addCategoryButton = new System.Windows.Forms.Button();
            this.btn_category = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_nameSort = new System.Windows.Forms.Button();
            this.btn_sortId = new System.Windows.Forms.Button();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.EndDate = new System.Windows.Forms.DateTimePicker();
            this.Find_by_date = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // productName
            // 
            this.productName.Location = new System.Drawing.Point(12, 12);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(177, 20);
            this.productName.TabIndex = 0;
            // 
            // productPrice
            // 
            this.productPrice.Location = new System.Drawing.Point(12, 38);
            this.productPrice.Name = "productPrice";
            this.productPrice.Size = new System.Drawing.Size(177, 20);
            this.productPrice.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(114, 144);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add Product";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // productListView
            // 
            this.productListView.Location = new System.Drawing.Point(383, 12);
            this.productListView.Name = "productListView";
            this.productListView.Size = new System.Drawing.Size(405, 407);
            this.productListView.TabIndex = 2;
            this.productListView.Text = "";
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(302, 12);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 3;
            this.showButton.Text = "SHOW";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // categoryList
            // 
            this.categoryList.FormattingEnabled = true;
            this.categoryList.Location = new System.Drawing.Point(13, 65);
            this.categoryList.Name = "categoryList";
            this.categoryList.Size = new System.Drawing.Size(176, 21);
            this.categoryList.TabIndex = 4;
            // 
            // categoryName
            // 
            this.categoryName.Location = new System.Drawing.Point(12, 194);
            this.categoryName.Name = "categoryName";
            this.categoryName.Size = new System.Drawing.Size(176, 20);
            this.categoryName.TabIndex = 5;
            // 
            // addCategoryButton
            // 
            this.addCategoryButton.Location = new System.Drawing.Point(68, 221);
            this.addCategoryButton.Name = "addCategoryButton";
            this.addCategoryButton.Size = new System.Drawing.Size(120, 23);
            this.addCategoryButton.TabIndex = 6;
            this.addCategoryButton.Text = "Add Category";
            this.addCategoryButton.UseVisualStyleBackColor = true;
            this.addCategoryButton.Click += new System.EventHandler(this.addCategoryButton_Click);
            // 
            // btn_category
            // 
            this.btn_category.Location = new System.Drawing.Point(302, 54);
            this.btn_category.Name = "btn_category";
            this.btn_category.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_category.Size = new System.Drawing.Size(75, 23);
            this.btn_category.TabIndex = 7;
            this.btn_category.Text = "Category";
            this.btn_category.UseVisualStyleBackColor = true;
            this.btn_category.Click += new System.EventHandler(this.btn_category_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(13, 105);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(195, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // btn_nameSort
            // 
            this.btn_nameSort.Location = new System.Drawing.Point(302, 105);
            this.btn_nameSort.Name = "btn_nameSort";
            this.btn_nameSort.Size = new System.Drawing.Size(75, 23);
            this.btn_nameSort.TabIndex = 9;
            this.btn_nameSort.Text = "sort by name";
            this.btn_nameSort.UseVisualStyleBackColor = true;
            this.btn_nameSort.Click += new System.EventHandler(this.btn_nameSort_Click);
            // 
            // btn_sortId
            // 
            this.btn_sortId.Location = new System.Drawing.Point(302, 144);
            this.btn_sortId.Name = "btn_sortId";
            this.btn_sortId.Size = new System.Drawing.Size(75, 23);
            this.btn_sortId.TabIndex = 9;
            this.btn_sortId.Text = "sort by price";
            this.btn_sortId.UseVisualStyleBackColor = true;
            this.btn_sortId.Click += new System.EventHandler(this.btn_sortId_Click);
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(201, 194);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(176, 20);
            this.tb_search.TabIndex = 5;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(276, 221);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(101, 23);
            this.btn_search.TabIndex = 10;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // StartDate
            // 
            this.StartDate.Location = new System.Drawing.Point(12, 269);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(200, 20);
            this.StartDate.TabIndex = 11;
            // 
            // EndDate
            // 
            this.EndDate.Location = new System.Drawing.Point(13, 295);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(200, 20);
            this.EndDate.TabIndex = 12;
            // 
            // Find_by_date
            // 
            this.Find_by_date.Location = new System.Drawing.Point(137, 321);
            this.Find_by_date.Name = "Find_by_date";
            this.Find_by_date.Size = new System.Drawing.Size(75, 23);
            this.Find_by_date.TabIndex = 13;
            this.Find_by_date.Text = "Find by date";
            this.Find_by_date.UseVisualStyleBackColor = true;
            this.Find_by_date.Click += new System.EventHandler(this.Find_by_date_Click);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 436);
            this.Controls.Add(this.Find_by_date);
            this.Controls.Add(this.EndDate);
            this.Controls.Add(this.StartDate);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_sortId);
            this.Controls.Add(this.btn_nameSort);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btn_category);
            this.Controls.Add(this.addCategoryButton);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.categoryName);
            this.Controls.Add(this.categoryList);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.productListView);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.productPrice);
            this.Controls.Add(this.productName);
            this.Name = "App";
            this.Text = "ADD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox productName;
        private System.Windows.Forms.TextBox productPrice;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.RichTextBox productListView;
        private System.Windows.Forms.Button showButton;
        public System.Windows.Forms.ComboBox categoryList;
        private System.Windows.Forms.TextBox categoryName;
        private System.Windows.Forms.Button addCategoryButton;
        private System.Windows.Forms.Button btn_category;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_nameSort;
        private System.Windows.Forms.Button btn_sortId;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DateTimePicker StartDate;
        private System.Windows.Forms.DateTimePicker EndDate;
        private System.Windows.Forms.Button Find_by_date;
    }
}