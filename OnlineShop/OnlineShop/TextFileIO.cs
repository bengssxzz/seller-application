using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OnlineShop
{
    public class TextFileIO
    {
        private string file; //File name

        public TextFileIO(string fileName) //Constructor, This will run if this class has been instantiated
        {
            file = fileName;
        }
        public string[] GetInventory() //Get the lines inside of text file
        {
            try
            {
                //If text file is already existed, then read all lines and return it as string[]
                return File.ReadAllLines(file);
            }
            catch
            {
                //If text file is not exist, then create new text file and read all lines and return it as string[]
                FileStream newFile = File.Create(file); //Create new file
                newFile.Close(); //Close the text file
                return File.ReadAllLines(file); //Return it as string[]
            }
            
        }
        public void AddNew(string name, string quantity, string price) //Add new lines in text file
        {
            StreamWriter writer = new StreamWriter(file, true);

            writer.WriteLine("{0},{1},{2}",name,quantity,price);
            writer.Close();
        }
        public void ChangeStock(int index, string name, string quantity, string price) //Change the info inside of text file
        {
            List<string> itemList = File.ReadAllLines(file).ToList();

            itemList.RemoveAt(index); //Remove old item info
            string temp = string.Format("{0},{1},{2}", name, quantity, price); //New change item info
            itemList.Insert(index, temp); //Insert new item info at specific index

            //Rewrite text file
            StreamWriter writer = new StreamWriter(file);
            foreach (string item in itemList)
            {
                writer.WriteLine(item);
            }
            writer.Close();
        }
        public void ClearData() //Remove and create new text file
        {
            StreamWriter writer = new StreamWriter(file); //Create empty textfile
            writer.Close();
        }
    }
}
