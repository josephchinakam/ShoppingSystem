namespace ShoppingCartSystem
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtItemPrice;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.ListBox lstShoppingCart;
        private System.Windows.Forms.ComboBox cboMembershipType;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblTotal;

        private void InitializeComponent()
        {
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtItemPrice = new System.Windows.Forms.TextBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.lstShoppingCart = new System.Windows.Forms.ListBox();
            this.cboMembershipType = new System.Windows.Forms.ComboBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(12, 12);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(200, 20);
            this.txtItemName.TabIndex = 0;
            this.txtItemName.PlaceholderText = "Enter Item Name";

            // 
            // txtItemPrice
            // 
            this.txtItemPrice.Location = new System.Drawing.Point(12, 38);
            this.txtItemPrice.Name = "txtItemPrice";
            this.txtItemPrice.Size = new System.Drawing.Size(200, 20);
            this.txtItemPrice.TabIndex = 1;
            this.txtItemPrice.PlaceholderText = "Enter Item Price";

            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(12, 64);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(200, 23);
            this.btnAddItem.TabIndex = 2;
            this.btnAddItem.Text = "Add Item to Cart";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);

            // 
            // lstShoppingCart
            // 
            this.lstShoppingCart.FormattingEnabled = true;
            this.lstShoppingCart.Location = new System.Drawing.Point(12, 93);
            this.lstShoppingCart.Name = "lstShoppingCart";
            this.lstShoppingCart.Size = new System.Drawing.Size(260, 95);
            this.lstShoppingCart.TabIndex = 3;

            // 
            // cboMembershipType
            // 
            this.cboMembershipType.FormattingEnabled = true
