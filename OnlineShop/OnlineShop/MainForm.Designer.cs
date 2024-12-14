
namespace OnlineShop
{
    partial class mainForm
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
            this.controlTab = new System.Windows.Forms.TabControl();
            this.viewStockTab = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.totalPriceSold_View = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.soldItemLabel_View = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.totalPriceAvlItem_View = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.totalItemLabel_View = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addStockTab = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.itemQuantity_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.itemName_TextBox = new System.Windows.Forms.TextBox();
            this.itemPrice_TextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addStackButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.sellTab = new System.Windows.Forms.TabPage();
            this.button_Sell = new System.Windows.Forms.Button();
            this.sell_ErrorLabel = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.totalPrice_Sell = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.itemName_Sell = new System.Windows.Forms.Label();
            this.itemPerPrice_Sell = new System.Windows.Forms.Label();
            this.sellQuantity_TextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inventoryData = new System.Windows.Forms.DataGridView();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataViewer = new System.Windows.Forms.TabControl();
            this.inventoryTab = new System.Windows.Forms.TabPage();
            this.soldStockTab = new System.Windows.Forms.TabPage();
            this.soldStockData = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.controlTab.SuspendLayout();
            this.viewStockTab.SuspendLayout();
            this.addStockTab.SuspendLayout();
            this.sellTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryData)).BeginInit();
            this.dataViewer.SuspendLayout();
            this.inventoryTab.SuspendLayout();
            this.soldStockTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soldStockData)).BeginInit();
            this.SuspendLayout();
            // 
            // controlTab
            // 
            this.controlTab.Controls.Add(this.viewStockTab);
            this.controlTab.Controls.Add(this.addStockTab);
            this.controlTab.Controls.Add(this.sellTab);
            this.controlTab.Dock = System.Windows.Forms.DockStyle.Left;
            this.controlTab.Location = new System.Drawing.Point(0, 0);
            this.controlTab.Name = "controlTab";
            this.controlTab.SelectedIndex = 0;
            this.controlTab.Size = new System.Drawing.Size(269, 338);
            this.controlTab.TabIndex = 0;
            this.controlTab.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // viewStockTab
            // 
            this.viewStockTab.Controls.Add(this.button2);
            this.viewStockTab.Controls.Add(this.button1);
            this.viewStockTab.Controls.Add(this.totalPriceSold_View);
            this.viewStockTab.Controls.Add(this.label17);
            this.viewStockTab.Controls.Add(this.soldItemLabel_View);
            this.viewStockTab.Controls.Add(this.label19);
            this.viewStockTab.Controls.Add(this.totalPriceAvlItem_View);
            this.viewStockTab.Controls.Add(this.label13);
            this.viewStockTab.Controls.Add(this.totalItemLabel_View);
            this.viewStockTab.Controls.Add(this.label7);
            this.viewStockTab.Controls.Add(this.label1);
            this.viewStockTab.Location = new System.Drawing.Point(4, 22);
            this.viewStockTab.Name = "viewStockTab";
            this.viewStockTab.Size = new System.Drawing.Size(261, 312);
            this.viewStockTab.TabIndex = 2;
            this.viewStockTab.Text = "View Stock";
            this.viewStockTab.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(132, 252);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Clear Invetory Data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.InventoryClearDataButton);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(132, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Clear Sold Stock Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SoldItemsClearDataButton);
            // 
            // totalPriceSold_View
            // 
            this.totalPriceSold_View.AutoSize = true;
            this.totalPriceSold_View.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceSold_View.Location = new System.Drawing.Point(170, 179);
            this.totalPriceSold_View.Name = "totalPriceSold_View";
            this.totalPriceSold_View.Size = new System.Drawing.Size(40, 18);
            this.totalPriceSold_View.TabIndex = 8;
            this.totalPriceSold_View.Text = "0000";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(43, 179);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(121, 18);
            this.label17.TabIndex = 7;
            this.label17.Text = "Total Price(sold):";
            // 
            // soldItemLabel_View
            // 
            this.soldItemLabel_View.AutoSize = true;
            this.soldItemLabel_View.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soldItemLabel_View.Location = new System.Drawing.Point(170, 157);
            this.soldItemLabel_View.Name = "soldItemLabel_View";
            this.soldItemLabel_View.Size = new System.Drawing.Size(40, 18);
            this.soldItemLabel_View.TabIndex = 6;
            this.soldItemLabel_View.Text = "0000";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(38, 157);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(126, 18);
            this.label19.TabIndex = 5;
            this.label19.Text = "Total of Item sold:";
            // 
            // totalPriceAvlItem_View
            // 
            this.totalPriceAvlItem_View.AutoSize = true;
            this.totalPriceAvlItem_View.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceAvlItem_View.Location = new System.Drawing.Point(170, 78);
            this.totalPriceAvlItem_View.Name = "totalPriceAvlItem_View";
            this.totalPriceAvlItem_View.Size = new System.Drawing.Size(48, 18);
            this.totalPriceAvlItem_View.TabIndex = 4;
            this.totalPriceAvlItem_View.Text = "00000";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(83, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 18);
            this.label13.TabIndex = 3;
            this.label13.Text = "Total price:";
            // 
            // totalItemLabel_View
            // 
            this.totalItemLabel_View.AutoSize = true;
            this.totalItemLabel_View.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalItemLabel_View.Location = new System.Drawing.Point(170, 56);
            this.totalItemLabel_View.Name = "totalItemLabel_View";
            this.totalItemLabel_View.Size = new System.Drawing.Size(40, 18);
            this.totalItemLabel_View.TabIndex = 2;
            this.totalItemLabel_View.Text = "0000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "Total of available item:";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "INVENTORY";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addStockTab
            // 
            this.addStockTab.Controls.Add(this.label12);
            this.addStockTab.Controls.Add(this.label4);
            this.addStockTab.Controls.Add(this.label11);
            this.addStockTab.Controls.Add(this.itemQuantity_TextBox);
            this.addStockTab.Controls.Add(this.label2);
            this.addStockTab.Controls.Add(this.itemName_TextBox);
            this.addStockTab.Controls.Add(this.itemPrice_TextBox);
            this.addStockTab.Controls.Add(this.label5);
            this.addStockTab.Controls.Add(this.addStackButton);
            this.addStockTab.Controls.Add(this.label6);
            this.addStockTab.Location = new System.Drawing.Point(4, 22);
            this.addStockTab.Name = "addStockTab";
            this.addStockTab.Padding = new System.Windows.Forms.Padding(3);
            this.addStockTab.Size = new System.Drawing.Size(261, 312);
            this.addStockTab.TabIndex = 0;
            this.addStockTab.Text = "AddStock";
            this.addStockTab.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Item Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Crimson;
            this.label11.Location = new System.Drawing.Point(3, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(248, 35);
            this.label11.TabIndex = 24;
            this.label11.Text = "*To delete item: Click cell in data grid then press the delete key";
            // 
            // itemQuantity_TextBox
            // 
            this.itemQuantity_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemQuantity_TextBox.Location = new System.Drawing.Point(14, 168);
            this.itemQuantity_TextBox.Name = "itemQuantity_TextBox";
            this.itemQuantity_TextBox.Size = new System.Drawing.Size(214, 24);
            this.itemQuantity_TextBox.TabIndex = 8;
            this.itemQuantity_TextBox.TextChanged += new System.EventHandler(this.AddStockValidation);
            this.itemQuantity_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PressNumberOnly);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 42);
            this.label2.TabIndex = 2;
            this.label2.Text = "ADD STOCK";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // itemName_TextBox
            // 
            this.itemName_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemName_TextBox.Location = new System.Drawing.Point(14, 120);
            this.itemName_TextBox.Name = "itemName_TextBox";
            this.itemName_TextBox.Size = new System.Drawing.Size(214, 24);
            this.itemName_TextBox.TabIndex = 4;
            this.itemName_TextBox.TextChanged += new System.EventHandler(this.itemName_TextBox_TextChanged);
            // 
            // itemPrice_TextBox
            // 
            this.itemPrice_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemPrice_TextBox.Location = new System.Drawing.Point(14, 215);
            this.itemPrice_TextBox.Name = "itemPrice_TextBox";
            this.itemPrice_TextBox.Size = new System.Drawing.Size(214, 24);
            this.itemPrice_TextBox.TabIndex = 10;
            this.itemPrice_TextBox.TextChanged += new System.EventHandler(this.AddStockValidation);
            this.itemPrice_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PressNumberWithDotOnly);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Item Quantity";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // addStackButton
            // 
            this.addStackButton.Enabled = false;
            this.addStackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStackButton.Location = new System.Drawing.Point(75, 254);
            this.addStackButton.Name = "addStackButton";
            this.addStackButton.Size = new System.Drawing.Size(90, 40);
            this.addStackButton.TabIndex = 3;
            this.addStackButton.Text = "Add";
            this.addStackButton.UseVisualStyleBackColor = true;
            this.addStackButton.Click += new System.EventHandler(this.AddButton);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Per Price";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sellTab
            // 
            this.sellTab.Controls.Add(this.button_Sell);
            this.sellTab.Controls.Add(this.sell_ErrorLabel);
            this.sellTab.Controls.Add(this.label15);
            this.sellTab.Controls.Add(this.totalPrice_Sell);
            this.sellTab.Controls.Add(this.label14);
            this.sellTab.Controls.Add(this.itemName_Sell);
            this.sellTab.Controls.Add(this.itemPerPrice_Sell);
            this.sellTab.Controls.Add(this.sellQuantity_TextBox);
            this.sellTab.Controls.Add(this.label8);
            this.sellTab.Controls.Add(this.label9);
            this.sellTab.Controls.Add(this.label10);
            this.sellTab.Controls.Add(this.label3);
            this.sellTab.Location = new System.Drawing.Point(4, 22);
            this.sellTab.Name = "sellTab";
            this.sellTab.Padding = new System.Windows.Forms.Padding(3);
            this.sellTab.Size = new System.Drawing.Size(261, 312);
            this.sellTab.TabIndex = 1;
            this.sellTab.Text = "Sell";
            this.sellTab.UseVisualStyleBackColor = true;
            // 
            // button_Sell
            // 
            this.button_Sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Sell.ForeColor = System.Drawing.Color.Red;
            this.button_Sell.Location = new System.Drawing.Point(76, 246);
            this.button_Sell.Name = "button_Sell";
            this.button_Sell.Size = new System.Drawing.Size(100, 49);
            this.button_Sell.TabIndex = 12;
            this.button_Sell.Text = "Sell";
            this.button_Sell.UseVisualStyleBackColor = true;
            this.button_Sell.Click += new System.EventHandler(this.SellButton);
            // 
            // sell_ErrorLabel
            // 
            this.sell_ErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sell_ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.sell_ErrorLabel.Location = new System.Drawing.Point(14, 220);
            this.sell_ErrorLabel.Name = "sell_ErrorLabel";
            this.sell_ErrorLabel.Size = new System.Drawing.Size(214, 23);
            this.sell_ErrorLabel.TabIndex = 24;
            this.sell_ErrorLabel.Text = "Error";
            this.sell_ErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sell_ErrorLabel.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Crimson;
            this.label15.Location = new System.Drawing.Point(38, 43);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(178, 13);
            this.label15.TabIndex = 23;
            this.label15.Text = "*Click cell in the data grid to sell item";
            // 
            // totalPrice_Sell
            // 
            this.totalPrice_Sell.AutoEllipsis = true;
            this.totalPrice_Sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPrice_Sell.Location = new System.Drawing.Point(108, 189);
            this.totalPrice_Sell.Name = "totalPrice_Sell";
            this.totalPrice_Sell.Size = new System.Drawing.Size(131, 20);
            this.totalPrice_Sell.TabIndex = 22;
            this.totalPrice_Sell.Text = "00000";
            this.totalPrice_Sell.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(21, 189);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 20);
            this.label14.TabIndex = 21;
            this.label14.Text = "Total Price:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // itemName_Sell
            // 
            this.itemName_Sell.AutoEllipsis = true;
            this.itemName_Sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemName_Sell.Location = new System.Drawing.Point(104, 69);
            this.itemName_Sell.Name = "itemName_Sell";
            this.itemName_Sell.Size = new System.Drawing.Size(135, 20);
            this.itemName_Sell.TabIndex = 19;
            this.itemName_Sell.Text = "Item Name";
            this.itemName_Sell.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // itemPerPrice_Sell
            // 
            this.itemPerPrice_Sell.AutoEllipsis = true;
            this.itemPerPrice_Sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemPerPrice_Sell.Location = new System.Drawing.Point(108, 89);
            this.itemPerPrice_Sell.Name = "itemPerPrice_Sell";
            this.itemPerPrice_Sell.Size = new System.Drawing.Size(131, 20);
            this.itemPerPrice_Sell.TabIndex = 20;
            this.itemPerPrice_Sell.Text = "00000";
            this.itemPerPrice_Sell.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sellQuantity_TextBox
            // 
            this.sellQuantity_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellQuantity_TextBox.Location = new System.Drawing.Point(14, 153);
            this.sellQuantity_TextBox.Name = "sellQuantity_TextBox";
            this.sellQuantity_TextBox.Size = new System.Drawing.Size(214, 24);
            this.sellQuantity_TextBox.TabIndex = 15;
            this.sellQuantity_TextBox.TextChanged += new System.EventHandler(this.sellQuantity_TextBox_TextChanged);
            this.sellQuantity_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PressNumberOnly);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Quantity to sell";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Item Name:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(21, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Per Price:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 42);
            this.label3.TabIndex = 3;
            this.label3.Text = "SELLING";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inventoryData
            // 
            this.inventoryData.AllowUserToAddRows = false;
            this.inventoryData.AllowUserToResizeColumns = false;
            this.inventoryData.AllowUserToResizeRows = false;
            this.inventoryData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventoryData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemName,
            this.itemQuantity,
            this.itemPrice});
            this.inventoryData.Dock = System.Windows.Forms.DockStyle.Left;
            this.inventoryData.Location = new System.Drawing.Point(3, 3);
            this.inventoryData.MultiSelect = false;
            this.inventoryData.Name = "inventoryData";
            this.inventoryData.ReadOnly = true;
            this.inventoryData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.inventoryData.Size = new System.Drawing.Size(351, 306);
            this.inventoryData.TabIndex = 1;
            this.inventoryData.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.inventoryData_CellMouseClick);
            // 
            // itemName
            // 
            this.itemName.HeaderText = "Name";
            this.itemName.Name = "itemName";
            this.itemName.ReadOnly = true;
            // 
            // itemQuantity
            // 
            this.itemQuantity.HeaderText = "Quantity";
            this.itemQuantity.Name = "itemQuantity";
            this.itemQuantity.ReadOnly = true;
            // 
            // itemPrice
            // 
            this.itemPrice.HeaderText = "Price";
            this.itemPrice.Name = "itemPrice";
            this.itemPrice.ReadOnly = true;
            // 
            // dataViewer
            // 
            this.dataViewer.Controls.Add(this.inventoryTab);
            this.dataViewer.Controls.Add(this.soldStockTab);
            this.dataViewer.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataViewer.Location = new System.Drawing.Point(263, 0);
            this.dataViewer.Name = "dataViewer";
            this.dataViewer.SelectedIndex = 0;
            this.dataViewer.Size = new System.Drawing.Size(349, 338);
            this.dataViewer.TabIndex = 2;
            // 
            // inventoryTab
            // 
            this.inventoryTab.Controls.Add(this.inventoryData);
            this.inventoryTab.Location = new System.Drawing.Point(4, 22);
            this.inventoryTab.Name = "inventoryTab";
            this.inventoryTab.Padding = new System.Windows.Forms.Padding(3);
            this.inventoryTab.Size = new System.Drawing.Size(341, 312);
            this.inventoryTab.TabIndex = 0;
            this.inventoryTab.Text = "Inventory Stock";
            this.inventoryTab.UseVisualStyleBackColor = true;
            // 
            // soldStockTab
            // 
            this.soldStockTab.Controls.Add(this.soldStockData);
            this.soldStockTab.Location = new System.Drawing.Point(4, 22);
            this.soldStockTab.Name = "soldStockTab";
            this.soldStockTab.Padding = new System.Windows.Forms.Padding(3);
            this.soldStockTab.Size = new System.Drawing.Size(341, 312);
            this.soldStockTab.TabIndex = 1;
            this.soldStockTab.Text = "Sold Stock";
            this.soldStockTab.UseVisualStyleBackColor = true;
            // 
            // soldStockData
            // 
            this.soldStockData.AllowUserToAddRows = false;
            this.soldStockData.AllowUserToResizeColumns = false;
            this.soldStockData.AllowUserToResizeRows = false;
            this.soldStockData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.soldStockData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.soldStockData.Dock = System.Windows.Forms.DockStyle.Left;
            this.soldStockData.Location = new System.Drawing.Point(3, 3);
            this.soldStockData.MultiSelect = false;
            this.soldStockData.Name = "soldStockData";
            this.soldStockData.ReadOnly = true;
            this.soldStockData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.soldStockData.Size = new System.Drawing.Size(351, 306);
            this.soldStockData.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Price";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Green;
            this.label12.Location = new System.Drawing.Point(5, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(248, 35);
            this.label12.TabIndex = 25;
            this.label12.Text = "*To edit item: Click cell in data grid then edit and press the change button";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 338);
            this.Controls.Add(this.dataViewer);
            this.Controls.Add(this.controlTab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Text = "Seller app";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.controlTab.ResumeLayout(false);
            this.viewStockTab.ResumeLayout(false);
            this.viewStockTab.PerformLayout();
            this.addStockTab.ResumeLayout(false);
            this.addStockTab.PerformLayout();
            this.sellTab.ResumeLayout(false);
            this.sellTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryData)).EndInit();
            this.dataViewer.ResumeLayout(false);
            this.inventoryTab.ResumeLayout(false);
            this.soldStockTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.soldStockData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl controlTab;
        private System.Windows.Forms.TabPage viewStockTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage addStockTab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView inventoryData;
        private System.Windows.Forms.TabPage sellTab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox itemQuantity_TextBox;
        private System.Windows.Forms.TextBox itemName_TextBox;
        private System.Windows.Forms.TextBox itemPrice_TextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addStackButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemPrice;
        private System.Windows.Forms.TextBox sellQuantity_TextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_Sell;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label totalPrice_Sell;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label itemName_Sell;
        private System.Windows.Forms.Label itemPerPrice_Sell;
        private System.Windows.Forms.Label sell_ErrorLabel;
        private System.Windows.Forms.TabControl dataViewer;
        private System.Windows.Forms.TabPage inventoryTab;
        private System.Windows.Forms.TabPage soldStockTab;
        private System.Windows.Forms.DataGridView soldStockData;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label totalPriceSold_View;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label soldItemLabel_View;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label totalPriceAvlItem_View;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label totalItemLabel_View;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

