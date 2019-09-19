using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffeeshop
{
    public partial class addButton : Form
    {

        int con = 0;
        ErrorProvider ep = new ErrorProvider();

        public addButton()
        {
            InitializeComponent();
        }
        ListView listView1 = new ListView();

        private void button_Click(object sender, EventArgs e)
        {

            if (con > 0)
            {
                for (int i = 0; i < listView1.Items.Count; i++)
                {

                    string Contact = listView1.Items[i].SubItems[2].Text;


                    if (Contact.Substring(0, 12) == customerContuctNo.Text)
                    {


                        MessageBox.Show("Number is already taken");
                        return;
                    }
                }
            }

            string price = "";
            decimal black = 120;
            decimal cold = 100;         
            decimal hot = 90;
            decimal regular = 80;
            int er = 0;

            if (orderComboBox.Text == "")
            {
                er++;
                ep.SetError(orderComboBox, "Please Select an item first");
                return;
            }
            if (quantityCoffee.Text == "")
            {
                er++;
                ep.SetError(quantityCoffee, "Please Enter quantity");

            }

            if (orderComboBox.Text == "Black")
            {
                price = (black * Decimal.Parse(quantityCoffee.Text)).ToString();
            }
            else if (orderComboBox.Text == "Cold")
            {
                price = (cold * Decimal.Parse(quantityCoffee.Text)).ToString();
            }
            else if (orderComboBox.Text == "Hot")
            {
                price = (hot * Decimal.Parse(quantityCoffee.Text)).ToString();
            }
            else if (orderComboBox.Text == "Regular")
            {
                price = (regular * Decimal.Parse(quantityCoffee.Text)).ToString();
            }
            else
            {

            }



            ListViewItem item = new ListViewItem();
            item.SubItems.Add("Name : " + customerNameBox.Text);
            item.SubItems.Add("Contact : " + customerContuctNo.Text);
            item.SubItems.Add("Addres : " + customerAddress.Text);
            item.SubItems.Add("ItemName: " + orderComboBox.Text);
            item.SubItems.Add("Qty : " + quantityCoffee.Text);
            item.SubItems.Add("Price: " + price.ToString());
            listView1.Items.Add(item);
            customerNameBox.Clear();
            customerContuctNo.Clear();
            customerAddress.Clear();
            orderComboBox.SelectedIndex = -1;
            quantityCoffee.Clear();
            price = "";
            con++;

            MessageBox.Show("Customer Information Add");



        }

        private void Clear()
        {
            customerNameBox.Text = "";
            customerContuctNo.Text = "";
            customerAddress.Text = "";
            quantityCoffee.Text = "";
            orderComboBox.SelectedIndex = -1;
            richTextBox.Text = "";
        }


        private void saveButton_Click(object sender, EventArgs e)
        {


            for (int i = 0; i < listView1.Items.Count; i++)
            {
                string Name = listView1.Items[i].SubItems[1].Text;
                string Contact = listView1.Items[i].SubItems[2].Text;
                string Addres = listView1.Items[i].SubItems[3].Text;
                string ItemName = listView1.Items[i].SubItems[4].Text;
                string Quantitty = listView1.Items[i].SubItems[5].Text;
                string Price = listView1.Items[i].SubItems[6].Text;

                richTextBox.Text += Name + "\n" + Contact + "\n" + Addres + "\n" + ItemName + "\n" + Quantitty + "\n" + Price + "\n" + "\n";

            }

        }

       
    }
}
