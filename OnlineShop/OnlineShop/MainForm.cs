using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineShop
{
    public partial class mainForm : Form
    {
        
        public mainForm()
        {
            InitializeComponent();
        }
        private void mainForm_Load(object sender, EventArgs e) //This will run once the program is stared or loaded
        {
            TextFileIO io = new TextFileIO("Inventory.txt"); //Text file for inventory
            TextFileIO ioSold = new TextFileIO("Sold.txt"); //Text file for sold item

            //To add all the save item in the data grid view
            string[] itemList = io.GetInventory();
            foreach (string item in itemList)
            {
                string[] splitLine = item.Split(','); //Split the line
                inventoryData.Rows.Add(splitLine[0], splitLine[1], splitLine[2]);
            }

            //To add all the save item in the data grid view
            string[] itemSold = ioSold.GetInventory();
            foreach (string sold in itemSold)
            {
                string[] splitLine = sold.Split(','); //Split the line
                soldStockData.Rows.Add(splitLine[0], splitLine[1], splitLine[2]);
            }

            ViewOverAllUpdate(io, ioSold);
        }
        
        private void ViewOverAllUpdate(TextFileIO ioStock, TextFileIO ioSold) //This method is to update the controls inside of view tab
        {
            int totalItemStock = 0;
            decimal totalAvlPrice = 0;

            int totalSoldItem = 0;
            decimal totalSoldPrice = 0;

            //To add all the save item in the data grid view
            string[] itemList = ioStock.GetInventory();
            foreach (string item in itemList)
            {
                string[] splitLine = item.Split(','); //Split the line
                if (int.Parse(splitLine[1]) > 0) //If the item has stock
                {
                    totalItemStock += 1;
                    totalAvlPrice += int.Parse(splitLine[1]) * decimal.Parse(splitLine[2]); //Total price per stock
                }
            }

            //To add all the save item in the data grid view
            string[] itemSold = ioSold.GetInventory();
            foreach (string sold in itemSold)
            {
                string[] splitLine = sold.Split(','); //Split the line
                totalSoldItem += 1; //Sold item
                totalSoldPrice += decimal.Parse(splitLine[2]); //Total price of sold item
            }

            //Change the text label
            totalItemLabel_View.Text = totalItemStock.ToString();
            totalPriceAvlItem_View.Text = totalAvlPrice.ToString();

            soldItemLabel_View.Text = totalSoldItem.ToString();
            totalPriceSold_View.Text = totalSoldPrice.ToString();
        }
        private void InventoryClearDataButton(object sender, EventArgs e) //Clear data grid of inventory data and the text file
        {
            TextFileIO ioStock = new TextFileIO("Inventory.txt"); //Text file for inventory

            ioStock.ClearData(); //Clear data

            inventoryData.Rows.Clear(); //Cleaer data grid view
            inventoryData.Refresh(); //Refresh data
        }
        private void SoldItemsClearDataButton(object sender, EventArgs e) //Clear data grid of sold data and the text file
        {
            TextFileIO ioSold = new TextFileIO("Sold.txt"); //Text file for inventory

            ioSold.ClearData(); //Clear data

            soldStockData.Rows.Clear(); //Cleaer data grid view
            soldStockData.Refresh(); //Refresh data
        }

        public bool CheckExistedItem(string itemName) //Check the existing item in the data grid
        {
            bool existedItem = false; 

            for (int i = 0; i < inventoryData.Rows.Count; i++)
            {
                if (itemName == inventoryData["itemName", i].Value.ToString()) //Check if the item name is existed in data
                {
                    existedItem = true; //If found the existed item name
                    break;  //break the loop   
                }
            }
            //If it doesn't found the existed item name it will return as false
            return existedItem;
        }
        private void AddStockValidation(object sender, EventArgs e) //Validate the textbox if the text box is empty or not
        {
            string name = itemName_TextBox.Text;
            string quantity = itemQuantity_TextBox.Text;
            string price = itemPrice_TextBox.Text;

            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(quantity) && !string.IsNullOrEmpty(price)) //If the textboxes is not empty then enabled the button
            {
                addStackButton.Enabled = true;
            }
            else //Else disabled it
            {
                addStackButton.Enabled = false;
            }
        }
        private void AddButton(object sender, EventArgs e)
        {
            TextFileIO io = new TextFileIO("Inventory.txt");

            string name = itemName_TextBox.Text;
            string quantity = itemQuantity_TextBox.Text;
            string price = itemPrice_TextBox.Text;

            if (CheckExistedItem(name))
            {
                for (int i = 0; i < inventoryData.Rows.Count; i++)
                {
                    if (itemName_TextBox.Text == inventoryData["itemName", i].Value.ToString()) //Check if the item name is existed in data
                    {
                        //If found the existed item name, break the loop
                        inventoryData["itemQuantity", i].Value = itemQuantity_TextBox.Text;
                        inventoryData["itemPrice", i].Value = itemPrice_TextBox.Text;

                        io.ChangeStock(i, name,quantity,price);
                        break;
                    }
                }
            }
            else
            {
                //If it doesn't found the existed item name, add item
                io.AddNew(name, quantity, price);
                inventoryData.Rows.Add(name, quantity, price);
            }

            //To clear the text box
            itemName_TextBox.Text = "";
            itemQuantity_TextBox.Text = "";
            itemPrice_TextBox.Text = "";

        }
        private void SellButton(object sender, EventArgs e)
        {
            TextFileIO io = new TextFileIO("Inventory.txt");
            TextFileIO ioSold = new TextFileIO("Sold.txt");

            string itemName = itemName_Sell.Text; //Selected item name
            int sellQuantity = int.Parse(sellQuantity_TextBox.Text); //Quantity to sell
            string itemPrice = itemPerPrice_Sell.Text; //Selected per item price
            decimal totalPrice = sellQuantity * decimal.Parse(itemPrice); //Total price. Formula: quantity * item per price

            if (CheckExistedItem(itemName_Sell.Text))
            {
                for (int i = 0; i < inventoryData.Rows.Count; i++)
                {
                    if (itemName_TextBox.Text == inventoryData["itemName", i].Value.ToString()) //Check if the item name is existed in data
                    {
                        //If found the existed item name, break the loop
                        int newQuantityItem = int.Parse(inventoryData["itemQuantity", i].Value.ToString()) - sellQuantity; //New quantity once the sell is success.

                        inventoryData["itemQuantity", i].Value = newQuantityItem.ToString(); //Change the quantity of the selected item in the data grid
                        io.ChangeStock(i, itemName, newQuantityItem.ToString(), itemPrice); //Change the item info in text file
                        ioSold.AddNew(itemName, sellQuantity.ToString(), totalPrice.ToString()); //Add sold item in the text file with total price
                        break;
                    }
                }
            }
            soldStockData.Rows.Add(itemName, sellQuantity, totalPrice); //add the sold item in the sold data grid view
            
            //Clear text box
            sellQuantity_TextBox.Text = "";
        }
        private void inventoryData_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) //Event for cell is clicked
        {
            int rowIndex = inventoryData.CurrentRow.Index;
            itemName_TextBox.Text = inventoryData["itemName", rowIndex].Value.ToString();
            itemQuantity_TextBox.Text = inventoryData["itemQuantity", rowIndex].Value.ToString();
            itemPrice_TextBox.Text = inventoryData["itemPrice", rowIndex].Value.ToString();

            //Sell tab
            itemName_Sell.Text = inventoryData["itemName", rowIndex].Value.ToString();
            itemPerPrice_Sell.Text = inventoryData["itemPrice", rowIndex].Value.ToString();
        }

        private void itemName_TextBox_TextChanged(object sender, EventArgs e) //If the text of the name text box in Add Stock is change
        {
            if (CheckExistedItem(itemName_TextBox.Text))
            {
                //Change button text if the item is existed
                addStackButton.Text = "Change";
            }
            else
            {
                //Change button text if the item is not exist
                addStackButton.Text = "Add";
            }
        }
        private void sellQuantity_TextBox_TextChanged(object sender, EventArgs e) //If the text of the quantity text box in Sell tab is change
        {
            try //If the text box in sell tab is not empty then this will run
            {
                int rowIndex = inventoryData.CurrentRow.Index; //Current selected row index
                int quantitySell = int.Parse((sender as TextBox).Text); //Quantity from text box in sell tab
                decimal itemPerPrice = decimal.Parse(itemPerPrice_Sell.Text); //Current seleted price per item in the data grid

                int itemQuantity = int.Parse(inventoryData["itemQuantity", rowIndex].Value.ToString()); //Quantity of the item in the stock inventory
                if (quantitySell > itemQuantity) //Check if the quantity to sell is enough
                {
                    //If it doesn't enough stock
                    sell_ErrorLabel.Show(); //Show error label in sell tab
                    sell_ErrorLabel.Text = "Not enough quantity to sell";
                    button_Sell.Enabled = false; //Disabled sell button in sell tab

                }
                else
                {
                    //If it has enough stock
                    sell_ErrorLabel.Hide(); //Hide error label in sell tab
                    button_Sell.Enabled = true; //Enabled sell button in sell tab
                    totalPrice_Sell.Text = (itemPerPrice * quantitySell).ToString(); //Total price
                }
            }
            catch //If the text box in sell tab is empty then this will run
            {
                totalPrice_Sell.Text = "0000"; //Back to default
                button_Sell.Enabled = false; //Disabled sell button in sell tab
            }
            


        }

        private void PressNumberOnly(object sender, KeyPressEventArgs e) //Validation for numbers only for text box
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void PressNumberWithDotOnly(object sender, KeyPressEventArgs e) //Validation for numbers only with decimal for text box
        {
            if ((!char.IsControl(e.KeyChar)) && (!char.IsDigit(e.KeyChar)) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) //This will run if the selection of tab is change
        {
            TextFileIO io = new TextFileIO("Inventory.txt"); //Text file for inventory
            TextFileIO ioSold = new TextFileIO("Sold.txt"); //Text file for sold item
            ViewOverAllUpdate(io, ioSold);

            if (controlTab.SelectedTab == addStockTab)
            {
                dataViewer.SelectedTab = inventoryTab;
            }else if (controlTab.SelectedTab == sellTab)
            {
                dataViewer.SelectedTab = inventoryTab;
            }
            else
            {
                dataViewer.SelectedTab = soldStockTab;
            }
        }
        
    }
}
