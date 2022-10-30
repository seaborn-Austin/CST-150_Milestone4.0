using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_150_Milestone4._0
{
    public partial class inventoryFrm : Form
    {
        public inventoryFrm()
        {
            InitializeComponent();
        }
        private void inventoryFrm_Load(object sender, EventArgs e)
        {
            string[] arr = new string[3];
            ListViewItem item;
            arr[0] = itemNameTxt.Text;
            arr[1] = itemSkuTxt.Text;
            arr[2] = quantityTxt.Text;
            item = new ListViewItem(arr);
            listView1.Items.Add(item);
        }
        public class inventoryItem
        {
            public itemType n;
            public string name;
            public string sku;
            public string quantity;

        }
        public class itemType
        {
            string name;

            public itemType(string n)
            {
                this.name = n;
            }

        }
        public class inventoryManager
        {
            inventoryItem item;
            public inventoryManager(inventoryItem it)
            {
                this.item = it;

            }
        }
        private void addItemBtn_Click(object sender, EventArgs e)
        {
            listView1.GridLines = true;
            //https://www.youtube.com/watch?v=PAk31IekYj4
            //Learned more about listView from the above video

            //Creating string list of items from the text boxes
            List<inventoryItem> listItem = new List<inventoryItem>
            {
                new inventoryItem()
                {
                    name = itemNameTxt.Text,
                    sku = itemSkuTxt.Text,
                    quantity = quantityTxt.Text
                }

            };

            if (string.IsNullOrEmpty(itemNameTxt.Text) || string.IsNullOrEmpty(itemSkuTxt.Text) ||
                string.IsNullOrEmpty(quantityTxt.Text)) { return; }


            ListViewItem subItem = new ListViewItem(listItem[0].name);

            //Add items to columns

            listView1.Items.Add(subItem);
            subItem.SubItems.Add(listItem[0].sku);
            subItem.SubItems.Add(listItem[0].quantity);




            itemNameTxt.Clear();
            itemSkuTxt.Clear();
            quantityTxt.Clear();
            itemNameTxt.Focus();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
        }

        private void restockBtn_Click(object sender, EventArgs e)
        {
            //Open form 2
            reorderFrm f2 = new reorderFrm();
            f2.Show();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            var item = listView1.FindItemWithText(searchTxt.Text);

            if (item != null)
            {
                MessageBox.Show(listView1.Items.IndexOf(item).ToString() + " "
                    + searchTxt.Text + " exists");
            }
            else { MessageBox.Show("That item is not in the list."); }
        }
    }
}
     
