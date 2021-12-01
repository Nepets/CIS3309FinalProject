namespace CIS3309F21FP
{
    partial class frmMain
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
            this.gbxCustomer = new System.Windows.Forms.GroupBox();
            this.btnClearCustomer = new System.Windows.Forms.Button();
            this.btnAddNewCustomer = new System.Windows.Forms.Button();
            this.btnFindCustomerBy = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtZipcode = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblZipcode = new System.Windows.Forms.Label();
            this.gbxProducts = new System.Windows.Forms.GroupBox();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.txtQuantityToPurchase = new System.Windows.Forms.TextBox();
            this.lblQuantityToPurchase = new System.Windows.Forms.Label();
            this.lstProducts = new System.Windows.Forms.ListBox();
            this.txtOnHandQuantity = new System.Windows.Forms.TextBox();
            this.lblOnHandQuantity = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.lblProductCode = new System.Windows.Forms.Label();
            this.gbxCart = new System.Windows.Forms.GroupBox();
            this.txtSalesTax = new System.Windows.Forms.TextBox();
            this.lblSalesTax = new System.Windows.Forms.Label();
            this.txtInvoiceTotal = new System.Windows.Forms.TextBox();
            this.lblInvoiceTotal = new System.Windows.Forms.Label();
            this.txtShipping = new System.Windows.Forms.TextBox();
            this.lblShipping = new System.Windows.Forms.Label();
            this.txtProductTotal = new System.Windows.Forms.TextBox();
            this.lblProductTotal = new System.Windows.Forms.Label();
            this.btnSubmitOrder = new System.Windows.Forms.Button();
            this.btnClearCart = new System.Windows.Forms.Button();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.btnEditItem = new System.Windows.Forms.Button();
            this.lstCart = new System.Windows.Forms.ListBox();
            this.gbxCustomer.SuspendLayout();
            this.gbxProducts.SuspendLayout();
            this.gbxCart.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxCustomer
            // 
            this.gbxCustomer.Controls.Add(this.btnClearCustomer);
            this.gbxCustomer.Controls.Add(this.btnAddNewCustomer);
            this.gbxCustomer.Controls.Add(this.btnFindCustomerBy);
            this.gbxCustomer.Controls.Add(this.txtAddress);
            this.gbxCustomer.Controls.Add(this.lblCustomerID);
            this.gbxCustomer.Controls.Add(this.lblAddress);
            this.gbxCustomer.Controls.Add(this.txtCustomerID);
            this.gbxCustomer.Controls.Add(this.txtName);
            this.gbxCustomer.Controls.Add(this.txtZipcode);
            this.gbxCustomer.Controls.Add(this.lblCity);
            this.gbxCustomer.Controls.Add(this.lblName);
            this.gbxCustomer.Controls.Add(this.lblState);
            this.gbxCustomer.Controls.Add(this.txtState);
            this.gbxCustomer.Controls.Add(this.txtCity);
            this.gbxCustomer.Controls.Add(this.lblZipcode);
            this.gbxCustomer.Location = new System.Drawing.Point(12, 12);
            this.gbxCustomer.Name = "gbxCustomer";
            this.gbxCustomer.Size = new System.Drawing.Size(242, 378);
            this.gbxCustomer.TabIndex = 0;
            this.gbxCustomer.TabStop = false;
            this.gbxCustomer.Text = "Customer";
            // 
            // btnClearCustomer
            // 
            this.btnClearCustomer.Location = new System.Drawing.Point(42, 233);
            this.btnClearCustomer.Name = "btnClearCustomer";
            this.btnClearCustomer.Size = new System.Drawing.Size(149, 23);
            this.btnClearCustomer.TabIndex = 26;
            this.btnClearCustomer.Text = "Clear Customer";
            this.btnClearCustomer.UseVisualStyleBackColor = true;
            this.btnClearCustomer.Click += new System.EventHandler(this.btnClearCustomer_Click);
            // 
            // btnAddNewCustomer
            // 
            this.btnAddNewCustomer.Location = new System.Drawing.Point(42, 204);
            this.btnAddNewCustomer.Name = "btnAddNewCustomer";
            this.btnAddNewCustomer.Size = new System.Drawing.Size(149, 23);
            this.btnAddNewCustomer.TabIndex = 25;
            this.btnAddNewCustomer.Text = "Add New Customer";
            this.btnAddNewCustomer.UseVisualStyleBackColor = true;
            this.btnAddNewCustomer.Click += new System.EventHandler(this.btnAddNewCustomer_Click);
            // 
            // btnFindCustomerBy
            // 
            this.btnFindCustomerBy.Location = new System.Drawing.Point(42, 175);
            this.btnFindCustomerBy.Name = "btnFindCustomerBy";
            this.btnFindCustomerBy.Size = new System.Drawing.Size(149, 23);
            this.btnFindCustomerBy.TabIndex = 24;
            this.btnFindCustomerBy.Text = "Find Customer By ID";
            this.btnFindCustomerBy.UseVisualStyleBackColor = true;
            this.btnFindCustomerBy.Click += new System.EventHandler(this.btnFindCustomerBy_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(91, 71);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(145, 20);
            this.txtAddress.TabIndex = 17;
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(20, 22);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(65, 13);
            this.lblCustomerID.TabIndex = 12;
            this.lblCustomerID.Text = "Customer ID";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(40, 74);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 13;
            this.lblAddress.Text = "Address";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(91, 19);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerID.TabIndex = 14;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(91, 45);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 15;
            // 
            // txtZipcode
            // 
            this.txtZipcode.Location = new System.Drawing.Point(91, 149);
            this.txtZipcode.Name = "txtZipcode";
            this.txtZipcode.Size = new System.Drawing.Size(100, 20);
            this.txtZipcode.TabIndex = 23;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(61, 100);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 16;
            this.lblCity.Text = "City";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(50, 48);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 22;
            this.lblName.Text = "Name";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(53, 126);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(32, 13);
            this.lblState.TabIndex = 18;
            this.lblState.Text = "State";
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(91, 123);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(100, 20);
            this.txtState.TabIndex = 21;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(91, 97);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 19;
            // 
            // lblZipcode
            // 
            this.lblZipcode.AutoSize = true;
            this.lblZipcode.Location = new System.Drawing.Point(39, 152);
            this.lblZipcode.Name = "lblZipcode";
            this.lblZipcode.Size = new System.Drawing.Size(46, 13);
            this.lblZipcode.TabIndex = 20;
            this.lblZipcode.Text = "Zipcode";
            // 
            // gbxProducts
            // 
            this.gbxProducts.Controls.Add(this.btnAddToCart);
            this.gbxProducts.Controls.Add(this.txtQuantityToPurchase);
            this.gbxProducts.Controls.Add(this.lblQuantityToPurchase);
            this.gbxProducts.Controls.Add(this.lstProducts);
            this.gbxProducts.Controls.Add(this.txtOnHandQuantity);
            this.gbxProducts.Controls.Add(this.lblOnHandQuantity);
            this.gbxProducts.Controls.Add(this.txtUnitPrice);
            this.gbxProducts.Controls.Add(this.lblUnitPrice);
            this.gbxProducts.Controls.Add(this.txtDescription);
            this.gbxProducts.Controls.Add(this.lblDescription);
            this.gbxProducts.Controls.Add(this.txtProductCode);
            this.gbxProducts.Controls.Add(this.lblProductCode);
            this.gbxProducts.Location = new System.Drawing.Point(260, 12);
            this.gbxProducts.Name = "gbxProducts";
            this.gbxProducts.Size = new System.Drawing.Size(561, 378);
            this.gbxProducts.TabIndex = 1;
            this.gbxProducts.TabStop = false;
            this.gbxProducts.Text = "Products";
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(240, 345);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(116, 23);
            this.btnAddToCart.TabIndex = 11;
            this.btnAddToCart.Text = "Add To Cart";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // txtQuantityToPurchase
            // 
            this.txtQuantityToPurchase.Location = new System.Drawing.Point(134, 347);
            this.txtQuantityToPurchase.Name = "txtQuantityToPurchase";
            this.txtQuantityToPurchase.Size = new System.Drawing.Size(100, 20);
            this.txtQuantityToPurchase.TabIndex = 10;
            // 
            // lblQuantityToPurchase
            // 
            this.lblQuantityToPurchase.AutoSize = true;
            this.lblQuantityToPurchase.Location = new System.Drawing.Point(18, 350);
            this.lblQuantityToPurchase.Name = "lblQuantityToPurchase";
            this.lblQuantityToPurchase.Size = new System.Drawing.Size(110, 13);
            this.lblQuantityToPurchase.TabIndex = 9;
            this.lblQuantityToPurchase.Text = "Quantity To Purchase";
            // 
            // lstProducts
            // 
            this.lstProducts.FormattingEnabled = true;
            this.lstProducts.Location = new System.Drawing.Point(21, 19);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(533, 212);
            this.lstProducts.TabIndex = 8;
            this.lstProducts.SelectedIndexChanged += new System.EventHandler(this.lstProducts_SelectedIndexChanged);
            // 
            // txtOnHandQuantity
            // 
            this.txtOnHandQuantity.Location = new System.Drawing.Point(134, 321);
            this.txtOnHandQuantity.Name = "txtOnHandQuantity";
            this.txtOnHandQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtOnHandQuantity.TabIndex = 7;
            // 
            // lblOnHandQuantity
            // 
            this.lblOnHandQuantity.AutoSize = true;
            this.lblOnHandQuantity.Location = new System.Drawing.Point(36, 324);
            this.lblOnHandQuantity.Name = "lblOnHandQuantity";
            this.lblOnHandQuantity.Size = new System.Drawing.Size(92, 13);
            this.lblOnHandQuantity.TabIndex = 6;
            this.lblOnHandQuantity.Text = "On Hand Quantity";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(134, 295);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(100, 20);
            this.txtUnitPrice.TabIndex = 5;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(75, 298);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(53, 13);
            this.lblUnitPrice.TabIndex = 4;
            this.lblUnitPrice.Text = "Unit Price";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(134, 269);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(222, 20);
            this.txtDescription.TabIndex = 3;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(68, 272);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description";
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(134, 243);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(100, 20);
            this.txtProductCode.TabIndex = 1;
            // 
            // lblProductCode
            // 
            this.lblProductCode.AutoSize = true;
            this.lblProductCode.Location = new System.Drawing.Point(56, 246);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(72, 13);
            this.lblProductCode.TabIndex = 0;
            this.lblProductCode.Text = "Product Code";
            // 
            // gbxCart
            // 
            this.gbxCart.Controls.Add(this.txtSalesTax);
            this.gbxCart.Controls.Add(this.lblSalesTax);
            this.gbxCart.Controls.Add(this.txtInvoiceTotal);
            this.gbxCart.Controls.Add(this.lblInvoiceTotal);
            this.gbxCart.Controls.Add(this.txtShipping);
            this.gbxCart.Controls.Add(this.lblShipping);
            this.gbxCart.Controls.Add(this.txtProductTotal);
            this.gbxCart.Controls.Add(this.lblProductTotal);
            this.gbxCart.Controls.Add(this.btnSubmitOrder);
            this.gbxCart.Controls.Add(this.btnClearCart);
            this.gbxCart.Controls.Add(this.btnDeleteItem);
            this.gbxCart.Controls.Add(this.btnEditItem);
            this.gbxCart.Controls.Add(this.lstCart);
            this.gbxCart.Location = new System.Drawing.Point(827, 12);
            this.gbxCart.Name = "gbxCart";
            this.gbxCart.Size = new System.Drawing.Size(465, 378);
            this.gbxCart.TabIndex = 2;
            this.gbxCart.TabStop = false;
            this.gbxCart.Text = "Cart";
            // 
            // txtSalesTax
            // 
            this.txtSalesTax.Location = new System.Drawing.Point(353, 289);
            this.txtSalesTax.Name = "txtSalesTax";
            this.txtSalesTax.Size = new System.Drawing.Size(100, 20);
            this.txtSalesTax.TabIndex = 15;
            // 
            // lblSalesTax
            // 
            this.lblSalesTax.AutoSize = true;
            this.lblSalesTax.Location = new System.Drawing.Point(293, 292);
            this.lblSalesTax.Name = "lblSalesTax";
            this.lblSalesTax.Size = new System.Drawing.Size(54, 13);
            this.lblSalesTax.TabIndex = 14;
            this.lblSalesTax.Text = "Sales Tax";
            // 
            // txtInvoiceTotal
            // 
            this.txtInvoiceTotal.Location = new System.Drawing.Point(353, 315);
            this.txtInvoiceTotal.Name = "txtInvoiceTotal";
            this.txtInvoiceTotal.Size = new System.Drawing.Size(100, 20);
            this.txtInvoiceTotal.TabIndex = 13;
            // 
            // lblInvoiceTotal
            // 
            this.lblInvoiceTotal.AutoSize = true;
            this.lblInvoiceTotal.Location = new System.Drawing.Point(278, 318);
            this.lblInvoiceTotal.Name = "lblInvoiceTotal";
            this.lblInvoiceTotal.Size = new System.Drawing.Size(69, 13);
            this.lblInvoiceTotal.TabIndex = 12;
            this.lblInvoiceTotal.Text = "Invoice Total";
            // 
            // txtShipping
            // 
            this.txtShipping.Location = new System.Drawing.Point(115, 315);
            this.txtShipping.Name = "txtShipping";
            this.txtShipping.Size = new System.Drawing.Size(100, 20);
            this.txtShipping.TabIndex = 13;
            // 
            // lblShipping
            // 
            this.lblShipping.AutoSize = true;
            this.lblShipping.Location = new System.Drawing.Point(61, 318);
            this.lblShipping.Name = "lblShipping";
            this.lblShipping.Size = new System.Drawing.Size(48, 13);
            this.lblShipping.TabIndex = 12;
            this.lblShipping.Text = "Shipping";
            // 
            // txtProductTotal
            // 
            this.txtProductTotal.Location = new System.Drawing.Point(115, 289);
            this.txtProductTotal.Name = "txtProductTotal";
            this.txtProductTotal.Size = new System.Drawing.Size(100, 20);
            this.txtProductTotal.TabIndex = 4;
            // 
            // lblProductTotal
            // 
            this.lblProductTotal.AutoSize = true;
            this.lblProductTotal.Location = new System.Drawing.Point(38, 292);
            this.lblProductTotal.Name = "lblProductTotal";
            this.lblProductTotal.Size = new System.Drawing.Size(71, 13);
            this.lblProductTotal.TabIndex = 3;
            this.lblProductTotal.Text = "Product Total";
            // 
            // btnSubmitOrder
            // 
            this.btnSubmitOrder.Location = new System.Drawing.Point(353, 345);
            this.btnSubmitOrder.Name = "btnSubmitOrder";
            this.btnSubmitOrder.Size = new System.Drawing.Size(103, 23);
            this.btnSubmitOrder.TabIndex = 2;
            this.btnSubmitOrder.Text = "Submit Order";
            this.btnSubmitOrder.UseVisualStyleBackColor = true;
            this.btnSubmitOrder.Click += new System.EventHandler(this.btnSubmitOrder_Click);
            // 
            // btnClearCart
            // 
            this.btnClearCart.Location = new System.Drawing.Point(244, 345);
            this.btnClearCart.Name = "btnClearCart";
            this.btnClearCart.Size = new System.Drawing.Size(103, 23);
            this.btnClearCart.TabIndex = 2;
            this.btnClearCart.Text = "Clear Cart";
            this.btnClearCart.UseVisualStyleBackColor = true;
            this.btnClearCart.Click += new System.EventHandler(this.btnClearCart_Click);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Location = new System.Drawing.Point(115, 345);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(103, 23);
            this.btnDeleteItem.TabIndex = 2;
            this.btnDeleteItem.Text = "Delete Item";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // btnEditItem
            // 
            this.btnEditItem.Location = new System.Drawing.Point(6, 344);
            this.btnEditItem.Name = "btnEditItem";
            this.btnEditItem.Size = new System.Drawing.Size(103, 23);
            this.btnEditItem.TabIndex = 1;
            this.btnEditItem.Text = "Edit Item";
            this.btnEditItem.UseVisualStyleBackColor = true;
            this.btnEditItem.Click += new System.EventHandler(this.btnEditItem_Click);
            // 
            // lstCart
            // 
            this.lstCart.FormattingEnabled = true;
            this.lstCart.Location = new System.Drawing.Point(6, 19);
            this.lstCart.Name = "lstCart";
            this.lstCart.Size = new System.Drawing.Size(453, 264);
            this.lstCart.TabIndex = 0;
            // 
            // frmMMABooksOES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 406);
            this.Controls.Add(this.gbxCart);
            this.Controls.Add(this.gbxProducts);
            this.Controls.Add(this.gbxCustomer);
            this.Name = "frmMMABooksOES";
            this.Text = "MMA Books Order Entry System";
            this.Load += new System.EventHandler(this.frmMMABooksPOS_Load);
            this.gbxCustomer.ResumeLayout(false);
            this.gbxCustomer.PerformLayout();
            this.gbxProducts.ResumeLayout(false);
            this.gbxProducts.PerformLayout();
            this.gbxCart.ResumeLayout(false);
            this.gbxCart.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCustomer;
        private System.Windows.Forms.Button btnAddNewCustomer;
        private System.Windows.Forms.Button btnFindCustomerBy;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtZipcode;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblZipcode;
        private System.Windows.Forms.Button btnClearCustomer;
        private System.Windows.Forms.GroupBox gbxProducts;
        private System.Windows.Forms.TextBox txtOnHandQuantity;
        private System.Windows.Forms.Label lblOnHandQuantity;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.Label lblProductCode;
        private System.Windows.Forms.TextBox txtQuantityToPurchase;
        private System.Windows.Forms.Label lblQuantityToPurchase;
        private System.Windows.Forms.ListBox lstProducts;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.GroupBox gbxCart;
        private System.Windows.Forms.Button btnSubmitOrder;
        private System.Windows.Forms.Button btnClearCart;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Button btnEditItem;
        private System.Windows.Forms.ListBox lstCart;
        private System.Windows.Forms.TextBox txtProductTotal;
        private System.Windows.Forms.Label lblProductTotal;
        private System.Windows.Forms.TextBox txtSalesTax;
        private System.Windows.Forms.Label lblSalesTax;
        private System.Windows.Forms.TextBox txtInvoiceTotal;
        private System.Windows.Forms.Label lblInvoiceTotal;
        private System.Windows.Forms.TextBox txtShipping;
        private System.Windows.Forms.Label lblShipping;
    }
}