namespace CoffeeShop
{
    partial class AdminWindow
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.productsPage = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cena = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Opis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nazwa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ilość = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.removeProductButton = new System.Windows.Forms.Button();
            this.orderProductButton = new System.Windows.Forms.Button();
            this.addProductButton = new System.Windows.Forms.Button();
            this.updateProductButton = new System.Windows.Forms.Button();
            this.SuppliesPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.addSupplierButton = new System.Windows.Forms.Button();
            this.removeSupplierButton = new System.Windows.Forms.Button();
            this.updateSupplierButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl.SuspendLayout();
            this.productsPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuppliesPage.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.productsPage);
            this.tabControl.Controls.Add(this.SuppliesPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(830, 555);
            this.tabControl.TabIndex = 0;
            // 
            // productsPage
            // 
            this.productsPage.Controls.Add(this.listView1);
            this.productsPage.Controls.Add(this.tableLayoutPanel1);
            this.productsPage.Location = new System.Drawing.Point(4, 22);
            this.productsPage.Name = "productsPage";
            this.productsPage.Padding = new System.Windows.Forms.Padding(3);
            this.productsPage.Size = new System.Drawing.Size(822, 529);
            this.productsPage.TabIndex = 1;
            this.productsPage.Text = "Produkty";
            this.productsPage.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Cena,
            this.Opis,
            this.Nazwa,
            this.Ilość});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(816, 494);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // Id
            // 
            this.Id.Text = "ID";
            this.Id.Width = 71;
            // 
            // Cena
            // 
            this.Cena.DisplayIndex = 3;
            this.Cena.Text = "Cena";
            this.Cena.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Cena.Width = 71;
            // 
            // Opis
            // 
            this.Opis.Text = "Opis";
            this.Opis.Width = 433;
            // 
            // Nazwa
            // 
            this.Nazwa.DisplayIndex = 1;
            this.Nazwa.Text = "Nazwa";
            this.Nazwa.Width = 142;
            // 
            // Ilość
            // 
            this.Ilość.Text = "Ilość na magazynie";
            this.Ilość.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Ilość.Width = 103;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.removeProductButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.orderProductButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.addProductButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.updateProductButton, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 497);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(816, 29);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // removeProductButton
            // 
            this.removeProductButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.removeProductButton.Location = new System.Drawing.Point(207, 3);
            this.removeProductButton.Name = "removeProductButton";
            this.removeProductButton.Size = new System.Drawing.Size(198, 23);
            this.removeProductButton.TabIndex = 1;
            this.removeProductButton.Text = "Usuń produkt";
            this.removeProductButton.UseVisualStyleBackColor = true;
            this.removeProductButton.Click += new System.EventHandler(this.removeProductButton_Click);
            // 
            // orderProductButton
            // 
            this.orderProductButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderProductButton.Location = new System.Drawing.Point(411, 3);
            this.orderProductButton.Name = "orderProductButton";
            this.orderProductButton.Size = new System.Drawing.Size(198, 23);
            this.orderProductButton.TabIndex = 2;
            this.orderProductButton.Text = "Zamów produkt";
            this.orderProductButton.UseVisualStyleBackColor = true;
            // 
            // addProductButton
            // 
            this.addProductButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addProductButton.Location = new System.Drawing.Point(3, 3);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(198, 23);
            this.addProductButton.TabIndex = 0;
            this.addProductButton.Text = "Dodaj produkt";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // updateProductButton
            // 
            this.updateProductButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updateProductButton.Location = new System.Drawing.Point(615, 3);
            this.updateProductButton.Name = "updateProductButton";
            this.updateProductButton.Size = new System.Drawing.Size(198, 23);
            this.updateProductButton.TabIndex = 3;
            this.updateProductButton.Text = "Zmień produkt";
            this.updateProductButton.UseVisualStyleBackColor = true;
            this.updateProductButton.Click += new System.EventHandler(this.updateProductButton_Click);
            // 
            // SuppliesPage
            // 
            this.SuppliesPage.Controls.Add(this.listView2);
            this.SuppliesPage.Controls.Add(this.tableLayoutPanel2);
            this.SuppliesPage.Location = new System.Drawing.Point(4, 22);
            this.SuppliesPage.Name = "SuppliesPage";
            this.SuppliesPage.Padding = new System.Windows.Forms.Padding(3);
            this.SuppliesPage.Size = new System.Drawing.Size(822, 529);
            this.SuppliesPage.TabIndex = 2;
            this.SuppliesPage.Text = "Dostawcy";
            this.SuppliesPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.button3, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.updateSupplierButton, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.removeSupplierButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.addSupplierButton, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 498);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(816, 28);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // addSupplierButton
            // 
            this.addSupplierButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addSupplierButton.Location = new System.Drawing.Point(3, 3);
            this.addSupplierButton.Name = "addSupplierButton";
            this.addSupplierButton.Size = new System.Drawing.Size(198, 22);
            this.addSupplierButton.TabIndex = 0;
            this.addSupplierButton.Text = "Dodaj dostawcę";
            this.addSupplierButton.UseVisualStyleBackColor = true;
            // 
            // removeSupplierButton
            // 
            this.removeSupplierButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.removeSupplierButton.Location = new System.Drawing.Point(207, 3);
            this.removeSupplierButton.Name = "removeSupplierButton";
            this.removeSupplierButton.Size = new System.Drawing.Size(198, 22);
            this.removeSupplierButton.TabIndex = 1;
            this.removeSupplierButton.Text = "Usuń dostawcę";
            this.removeSupplierButton.UseVisualStyleBackColor = true;
            // 
            // updateSupplierButton
            // 
            this.updateSupplierButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updateSupplierButton.Location = new System.Drawing.Point(411, 3);
            this.updateSupplierButton.Name = "updateSupplierButton";
            this.updateSupplierButton.Size = new System.Drawing.Size(198, 22);
            this.updateSupplierButton.TabIndex = 2;
            this.updateSupplierButton.Text = "Pokaż szczegóły";
            this.updateSupplierButton.UseVisualStyleBackColor = true;
            this.updateSupplierButton.Click += new System.EventHandler(this.updateSupplierButton_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Location = new System.Drawing.Point(615, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(198, 22);
            this.button3.TabIndex = 3;
            this.button3.Text = "Dodaj dostawcę";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.Location = new System.Drawing.Point(3, 3);
            this.listView2.MultiSelect = false;
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(816, 495);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 121;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nazwa";
            this.columnHeader2.Width = 436;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Numer konta";
            this.columnHeader3.Width = 247;
            // 
            // AdminWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 555);
            this.Controls.Add(this.tabControl);
            this.Name = "AdminWindow";
            this.Text = "AdminWindow";
            this.Load += new System.EventHandler(this.AdminWindow_Load);
            this.tabControl.ResumeLayout(false);
            this.productsPage.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.SuppliesPage.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage productsPage;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Nazwa;
        private System.Windows.Forms.ColumnHeader Opis;
        private System.Windows.Forms.ColumnHeader Cena;
        private System.Windows.Forms.ColumnHeader Ilość;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button removeProductButton;
        private System.Windows.Forms.Button orderProductButton;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Button updateProductButton;
        private System.Windows.Forms.TabPage SuppliesPage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button updateSupplierButton;
        private System.Windows.Forms.Button removeSupplierButton;
        private System.Windows.Forms.Button addSupplierButton;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}