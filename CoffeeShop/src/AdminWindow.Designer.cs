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
            this.addProductButton = new System.Windows.Forms.Button();
            this.updateProductButton = new System.Windows.Forms.Button();
            this.suppliesPage = new System.Windows.Forms.TabPage();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.updateSupplierButton = new System.Windows.Forms.Button();
            this.removeSupplierButton = new System.Windows.Forms.Button();
            this.addSupplierButton = new System.Windows.Forms.Button();
            this.orders1Page = new System.Windows.Forms.TabPage();
            this.listView3 = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.addOrderButton = new System.Windows.Forms.Button();
            this.removeOrderButton = new System.Windows.Forms.Button();
            this.orderDetailsButton = new System.Windows.Forms.Button();
            this.orders2TabPage = new System.Windows.Forms.TabPage();
            this.listView4 = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl.SuspendLayout();
            this.productsPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.suppliesPage.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.orders1Page.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.orders2TabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.productsPage);
            this.tabControl.Controls.Add(this.suppliesPage);
            this.tabControl.Controls.Add(this.orders1Page);
            this.tabControl.Controls.Add(this.orders2TabPage);
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
            this.Opis.Width = 399;
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
            // suppliesPage
            // 
            this.suppliesPage.Controls.Add(this.listView2);
            this.suppliesPage.Controls.Add(this.tableLayoutPanel2);
            this.suppliesPage.Location = new System.Drawing.Point(4, 22);
            this.suppliesPage.Name = "suppliesPage";
            this.suppliesPage.Padding = new System.Windows.Forms.Padding(3);
            this.suppliesPage.Size = new System.Drawing.Size(822, 529);
            this.suppliesPage.TabIndex = 2;
            this.suppliesPage.Text = "Dostawcy";
            this.suppliesPage.UseVisualStyleBackColor = true;
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
            this.listView2.DoubleClick += new System.EventHandler(this.listView2_DoubleClick);
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
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
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
            // addSupplierButton
            // 
            this.addSupplierButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addSupplierButton.Location = new System.Drawing.Point(3, 3);
            this.addSupplierButton.Name = "addSupplierButton";
            this.addSupplierButton.Size = new System.Drawing.Size(198, 22);
            this.addSupplierButton.TabIndex = 0;
            this.addSupplierButton.Text = "Dodaj dostawcę";
            this.addSupplierButton.UseVisualStyleBackColor = true;
            this.addSupplierButton.Click += new System.EventHandler(this.addSupplierButton_Click);
            // 
            // orders1Page
            // 
            this.orders1Page.Controls.Add(this.listView3);
            this.orders1Page.Controls.Add(this.tableLayoutPanel3);
            this.orders1Page.Location = new System.Drawing.Point(4, 22);
            this.orders1Page.Name = "orders1Page";
            this.orders1Page.Padding = new System.Windows.Forms.Padding(3);
            this.orders1Page.Size = new System.Drawing.Size(822, 529);
            this.orders1Page.TabIndex = 3;
            this.orders1Page.Text = "Zamówienia dostawy";
            this.orders1Page.UseVisualStyleBackColor = true;
            // 
            // listView3
            // 
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView3.FullRowSelect = true;
            this.listView3.GridLines = true;
            this.listView3.Location = new System.Drawing.Point(3, 3);
            this.listView3.MultiSelect = false;
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(816, 490);
            this.listView3.TabIndex = 1;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            this.listView3.DoubleClick += new System.EventHandler(this.listView3_DoubleClick);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Nr zamówienia";
            this.columnHeader4.Width = 87;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ID dostawcy";
            this.columnHeader5.Width = 89;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Koszt";
            this.columnHeader6.Width = 90;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Status";
            this.columnHeader7.Width = 99;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Data";
            this.columnHeader8.Width = 103;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.addOrderButton, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.removeOrderButton, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.orderDetailsButton, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 493);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(816, 33);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // addOrderButton
            // 
            this.addOrderButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addOrderButton.Location = new System.Drawing.Point(3, 3);
            this.addOrderButton.Name = "addOrderButton";
            this.addOrderButton.Size = new System.Drawing.Size(266, 27);
            this.addOrderButton.TabIndex = 0;
            this.addOrderButton.Text = "Dodaj zamówienie";
            this.addOrderButton.UseVisualStyleBackColor = true;
            this.addOrderButton.Click += new System.EventHandler(this.addOrderButton_Click);
            // 
            // removeOrderButton
            // 
            this.removeOrderButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.removeOrderButton.Location = new System.Drawing.Point(275, 3);
            this.removeOrderButton.Name = "removeOrderButton";
            this.removeOrderButton.Size = new System.Drawing.Size(266, 27);
            this.removeOrderButton.TabIndex = 1;
            this.removeOrderButton.Text = "Usuń zamówienie";
            this.removeOrderButton.UseVisualStyleBackColor = true;
            this.removeOrderButton.Click += new System.EventHandler(this.removeOrderButton_Click);
            // 
            // orderDetailsButton
            // 
            this.orderDetailsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderDetailsButton.Location = new System.Drawing.Point(547, 3);
            this.orderDetailsButton.Name = "orderDetailsButton";
            this.orderDetailsButton.Size = new System.Drawing.Size(266, 27);
            this.orderDetailsButton.TabIndex = 2;
            this.orderDetailsButton.Text = "Szczegóły zamówienia";
            this.orderDetailsButton.UseVisualStyleBackColor = true;
            this.orderDetailsButton.Click += new System.EventHandler(this.orderDetailsButton_Click);
            // 
            // orders2TabPage
            // 
            this.orders2TabPage.Controls.Add(this.listView4);
            this.orders2TabPage.Location = new System.Drawing.Point(4, 22);
            this.orders2TabPage.Name = "orders2TabPage";
            this.orders2TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.orders2TabPage.Size = new System.Drawing.Size(822, 529);
            this.orders2TabPage.TabIndex = 4;
            this.orders2TabPage.Text = "Zamówienia klientów";
            this.orders2TabPage.UseVisualStyleBackColor = true;
            // 
            // listView4
            // 
            this.listView4.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13});
            this.listView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView4.FullRowSelect = true;
            this.listView4.GridLines = true;
            this.listView4.Location = new System.Drawing.Point(3, 3);
            this.listView4.MultiSelect = false;
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(816, 523);
            this.listView4.TabIndex = 0;
            this.listView4.UseCompatibleStateImageBehavior = false;
            this.listView4.View = System.Windows.Forms.View.Details;
            this.listView4.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView4_MouseDoubleClick);
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "ID";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Kod zamawiającego";
            this.columnHeader10.Width = 125;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Koszt";
            this.columnHeader11.Width = 111;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Status";
            this.columnHeader12.Width = 99;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Data zamówienia";
            this.columnHeader13.Width = 115;
            // 
            // AdminWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 555);
            this.Controls.Add(this.tabControl);
            this.Name = "AdminWindow";
            this.Text = "CoffeeShop";
            this.Load += new System.EventHandler(this.AdminWindow_Load);
            this.tabControl.ResumeLayout(false);
            this.productsPage.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.suppliesPage.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.orders1Page.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.orders2TabPage.ResumeLayout(false);
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
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Button updateProductButton;
        private System.Windows.Forms.TabPage suppliesPage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button updateSupplierButton;
        private System.Windows.Forms.Button removeSupplierButton;
        private System.Windows.Forms.Button addSupplierButton;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TabPage orders1Page;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button addOrderButton;
        private System.Windows.Forms.Button removeOrderButton;
        private System.Windows.Forms.Button orderDetailsButton;
        private System.Windows.Forms.TabPage orders2TabPage;
        private System.Windows.Forms.ListView listView4;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
    }
}