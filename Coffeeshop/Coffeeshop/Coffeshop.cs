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
    public partial class Coffeshop : Form
    {
        
        List<string> names = new List<string> { };
    
        List<int> contuct = new List<int> { };
        List<string> addres = new List<string> { };
        List<string> item = new List<string> { };
        List<int> quantitty = new List<int> { };
        
       
        int index = 0;
        string message = " ";

        public Coffeshop()
        {
            InitializeComponent();
        }


        private void button_Click(object sender, EventArgs e)
        {
            double price = 0;
            for (index = 0; index < names.Count; index++)
            {
                if (item[index] == "Black")
                {
                    price = 120 * (quantitty[index]);
                }
                else if (item[index] == "Cold")
                {
                    price = 100 * (quantitty[index]);
                }
                else if (item[index] == "Hot")
                {
                    price = 90 * quantitty[index];
                }
                else if (item[index] == "Regular")

                    price = 80 * quantitty[index];


                else
                {
                    MessageBox.Show("Please Select an item first");
                }


                message += "Customer Name : " + names[index] + "\n" + "Contuct Number : " + contuct[index] + "\n" + "Address : " + addres[index] + "\n" + "Order : " + item[index] + "\n" + "Quantity : " + quantitty[index] + "\n" + "Total Price : " + price + "\n" + "\n";


            }

            richTextBox.Text = (message);
        
      

        }

       
        private void saveButton_Click(object sender, EventArgs e)
        {

           
            if (index <= names.Count)
            {
                try
                {
                    if (contuct.Contains(Convert.ToInt32(customerContuctNo.Text)))
                    {
                        MessageBox.Show("Phone Number Must be unique ");
                        return;
                    }
                    else
                        quantitty.Add(Convert.ToInt32(quantityCoffee.Text));
                }
                catch (Exception exception)
                {
                   MessageBox.Show(exception.Message);
                    return;
                }
                try
                {
                    if (String.IsNullOrEmpty(quantityCoffee.Text))
                    {
                        MessageBox.Show("Quantity Cannot be empty :");
                        return;
                    }
                    else
                        quantitty.Add(Convert.ToInt32(quantityCoffee.Text));
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                    return;
                }
                try
                {
                    if (String.IsNullOrEmpty(orderComboBox.Text))
                    {
                        MessageBox.Show("Select an item first :");
                        return;
                    }
                    else
                        item.Add(orderComboBox.Text);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                    return;
                }

               
                names.Add(customerNameBox.Text);
                contuct.Add(Convert.ToInt32(customerContuctNo.Text));
                addres.Add(customerAddress.Text);
              
                clear();


            }

        }

        private void clear()
        {
            customerNameBox.Text = " ";
            customerContuctNo.Text = " ";
            customerAddress.Text = " ";
            orderComboBox.SelectedIndex= -1;
            quantityCoffee.Text = " ";
            richTextBox.Text = " ";


        }
    }
}
