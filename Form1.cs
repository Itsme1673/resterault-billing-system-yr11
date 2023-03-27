using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Before you go and start reading my code and comments, i used combo boxes (as you would have seen if you looked at my form) and it took me a solid 15 mins to figure out how to add options to it. :(

namespace ResterauntBillingSystem
{
    public partial class Form1 : Form
    {
        string[] Entrees = System.IO.File.ReadAllLines(@"entrees.txt");      // From here till line 19 - this reads the cost list which i made using the menu we were given and sets a variable for each of the types of items.
        string[] Salads = System.IO.File.ReadAllLines(@"salads.txt");
        string[] Mains = System.IO.File.ReadAllLines(@"main.txt");
        string[] Desserts = System.IO.File.ReadAllLines(@"desserts.txt");
        string[] Drinks = System.IO.File.ReadAllLines(@"drinks.txt");

        string[] Item = new string[100];                    // This does things. Im pretty sure it defines strings and floats for the available items and quantities and sets a variable for the cost sheet.
        string[] Quantity = new string[100];                // It also sets the cost to 0 so that the customers dont get charged any more than they have to
        float[] CostSheet = new float[100];                 // It also sets the item number to -1 for a reason i will never know
        int[] ItemValueTag = new int[100];
        float cost = 0.0f;
        int ItemNumber = -1;
        public Form1()
        {
            InitializeComponent();

            var AddItemCount = 0;       
            var TotalItemCount = 0;

            // This adds the items on the cost sheet to the item combo box so i dont have to do it manually and spend a ton of time doing it. I also have little idea of what each line does.
            while (AddItemCount < System.IO.File.ReadAllLines(@"entrees.txt").Count() / 2)        
            {
                cbxItem.Items.Add(Entrees[AddItemCount]);                                                                  
                CostSheet[TotalItemCount] = float.Parse(Entrees[AddItemCount + System.IO.File.ReadLines(@"entrees.txt").Count() / 2]);
                TotalItemCount++;
                AddItemCount++;
            }
            AddItemCount = 0;
            while (AddItemCount < System.IO.File.ReadLines(@"salads.txt").Count() / 2)
            {
                cbxItem.Items.Add(Salads[AddItemCount]);
                CostSheet[TotalItemCount] = float.Parse(Salads[AddItemCount + System.IO.File.ReadLines(@"salads.txt").Count() / 2]);
                TotalItemCount++;
                AddItemCount++;
            }
            AddItemCount = 0;
            while (AddItemCount < System.IO.File.ReadLines(@"main.txt").Count() / 2)
            {
                cbxItem.Items.Add(Mains[AddItemCount]);
                CostSheet[TotalItemCount] = float.Parse(Mains[AddItemCount + System.IO.File.ReadLines(@"main.txt").Count() / 2]);      // I accidentally misspelt the file name here so the program crashed whenever i tried to launch it until i realised.
                TotalItemCount++;                                                                                                      // Unlike the ordeal i had trying to figure out how to add options to the combo box, i figured this out quickly. Mainly because the error box told me where the error was but not what it was.
                AddItemCount++;
            }
            AddItemCount = 0;
            while (AddItemCount < System.IO.File.ReadLines(@"desserts.txt").Count() / 2)
            {
                cbxItem.Items.Add(Desserts[AddItemCount]);
                CostSheet[TotalItemCount] = float.Parse(Desserts[AddItemCount + System.IO.File.ReadLines(@"desserts.txt").Count() / 2]);
                TotalItemCount++;
                AddItemCount++;
            }
            AddItemCount = 0;
            while (AddItemCount < System.IO.File.ReadLines(@"drinks.txt").Count() / 2)
            {
                cbxItem.Items.Add(Drinks[AddItemCount]);
                CostSheet[TotalItemCount] = float.Parse(Drinks[AddItemCount + System.IO.File.ReadLines(@"drinks.txt").Count() / 2]);
                TotalItemCount++;
                AddItemCount++;
            }


        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            lblRecieptSaved.Visible = false;
            if ( ItemNumber < 100 && cbxItem.Text != "" && cbxQuantity.Text != "" )       // From here till line 104 calculates the Sub-Total, the membership discount, the GST and the total.
            {                                                                             // Each of these are displayed in a label so the person taking the order or the customer can check if it is right.
                ItemNumber++;                                                             // Again, i have little idea of what some of this does, i have a general idea but still i should probably look up what it does.
                Item[ItemNumber] = cbxItem.Text;
                Quantity[ItemNumber] = cbxQuantity.Text;
                ItemValueTag[ItemNumber] = cbxItem.SelectedIndex;
                lsbItems.Items.Add(Item[ItemNumber] + "  x" + Quantity[ItemNumber] + "  $" + (CostSheet[cbxItem.SelectedIndex] * float.Parse(Quantity[ItemNumber])));
                cost += (CostSheet[cbxItem.SelectedIndex] * float.Parse(Quantity[ItemNumber]));
                lblSubTotal.Text = cost.ToString();
                lblSubTotal.Text = "$" + cost.ToString();
                lblGST.Text = "$" + (cost * 0.1).ToString();
                if (cbxMembership.Text == "GOLD CLASS")
                {
                    lblDiscount.Text = "$" + (cost * 0.125).ToString();
                    lblTotal.Text = "$" + (cost - (cost * 0.125) * 1.1).ToString();
                }
                if (cbxMembership.Text == "REGULAR")
                {
                    lblDiscount.Text = "$" + (cost * 0.075).ToString();
                    lblTotal.Text = "$" + (cost - (cost * 0.075) * 1.1).ToString();
                }
                if (cbxMembership.Text == "N/A" || cbxMembership.Text == "")            // I had the idea of if a customer didnt have a membership, the program would probably freak out if the combo box was empty.
                {                                                                       // So i programmed that possibility in so it doesnt apply a discount or crash if the customer didnt have a membership.
                    lblDiscount.Text = "$0";                                            // Although the user has to put in the text "N/A" for it to work (i think i havent tested this at the time of writing, im making these as i go along so i sort of know what everything does).
                    lblTotal.Text = "$" + (cost * 1.1).ToString();                      // Okay so i tested it and i didnt need to put this here but im going to keep it anyway (later on i removed the possibility of having an empty combo box so it has to have something in it)
                }                                                                       // (this is a lot for one bit of code but anyway) through some experimentation i figured out that if a membership level that isnt listed in the code is entered into the combo box by typing it in, the total doesnt add up at all, it just stays at 0. interesting.
            }
        }

        private void lsbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbItems.SelectedIndex != -1 && lsbItems.Items[lsbItems.SelectedIndex] != "Removed")   //This until line 133 is pretty much the same as above but removes items instead of adding them.
            {
                int ItemValue = lsbItems.SelectedIndex;
                cost -= CostSheet[ItemValueTag[lsbItems.SelectedIndex]] * float.Parse(Quantity[lsbItems.SelectedIndex]);
                lsbItems.Items[lsbItems.SelectedIndex] = "Removed";
                lblSubTotal.Text = "$" + cost.ToString();
                lblGST.Text = "$" + (cost * 0.1).ToString();
                if (cbxMembership.Text == "GOLD CLASS")
                {
                    lblDiscount.Text = "$" + (cost * 0.125).ToString();
                    lblTotal.Text = "$" + (cost - (cost * 0.125) * 1.1).ToString();
                }
                if (cbxMembership.Text == "REGULAR")
                {
                    lblDiscount.Text = "$" + (cost * 0.075).ToString();
                    lblTotal.Text = "$" + (cost - (cost * 0.075) * 1.1).ToString();
                }
                if (cbxMembership.Text == "N/A" || cbxMembership.Text == "")
                {
                    lblDiscount.Text = "$0";
                    lblTotal.Text = "$" + (cost * 1.1).ToString();
                }
            }
        }
        string[] RecieptTimes = new string[1000];
        int OrderNumber = 0;

        private void btnSave_Click(object sender, EventArgs e)         //This saves the order info to a text file which contains the table number, items, quantity, membership and prices
        {
             if (cbxTableNumber.Text != "" && cbxMembership.Text !="")
            {
                if (lsbItems.Items.Count > 0)
                {
                    lblSubTotal.Text = cost.ToString();
                    lblSubTotal.Text = "$" + cost.ToString();
                    lblGST.Text = "$" + cost.ToString();
                    if (cbxMembership.Text == "GOLD CLASS")
                    {
                        lblDiscount.Text = "$" + (cost * 0.125).ToString();
                        lblTotal.Text = "$" + (cost - (cost * 0.125) * 1.1).ToString();
                    }
                    if (cbxMembership.Text == "REGULAR")
                    {
                        lblDiscount.Text = "$" + (cost * 0.075).ToString();
                        lblTotal.Text = "$" + (cost - (cost * 0.075) * 1.1).ToString();
                    }
                    if (cbxMembership.Text == "N/A" || cbxMembership.Text == "")
                    {
                        lblDiscount.Text = "$0";
                        lblTotal.Text = "$" + (cost * 1.1).ToString();
                    }

                    string[] Reciept = new string[400];
                    Reciept[0] = "Date: " + (DateTime.Now).ToString();
                    Reciept[1] = "Table Number:  " + cbxTableNumber.Text;
                    Reciept[2] = "Discount Level: " + cbxMembership.Text;
                    Reciept[3] = "";
                    Reciept[4] = "LIST";
                    int ItemList = 5;
                    int ItemAttempt = 0;

                    while (ItemAttempt != lsbItems.Items.Count)
                    {
                        if (lsbItems.Items[ItemAttempt] != "Removed")                  // I dont know why this is underlined in green, i would appreciate if you told me in feedback :)
                        {
                            Reciept[ItemList] = lsbItems.Items[ItemAttempt].ToString();
                            ItemList++;
                        }
                        ItemAttempt++;
                    }

                    Reciept[ItemList] = "";
                    Reciept[ItemList + 1] = lblTextSubTotal.Text + " " + lblSubTotal.Text;
                    Reciept[ItemList + 2] = lblTextDiscount.Text + " " + lblDiscount.Text;
                    Reciept[ItemList + 3] = lblTextGST.Text + " " + lblGST.Text;
                    Reciept[ItemList + 4] = lblTextTotal.Text + " " + lblTotal.Text;
                    OrderNumber++;
                    System.IO.File.WriteAllLines($"Order #{OrderNumber}.txt", Reciept);

                    lblRecieptSaved.Visible = true;
                    RecieptTimes[OrderNumber] = "Order #" + OrderNumber + " made at" + DateTime.Now;

                    
                }
            }
             else
            {
                MessageBox.Show("Please select Table Number and/or Membership Level");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lsbItems.Items.Clear();
            cost = 0f;
            lblSubTotal.Text = cost.ToString();
            lblSubTotal.Text = "$" + cost.ToString();                             // As a side note, i kept forgetting to put .Text at the end of some bits and got confused a lot.
            lblGST.Text = "$" + (cost * 0.1).ToString();
            if (cbxMembership.Text == "GOLD CLASS")
            {
                lblDiscount.Text = "$" + (cost * 0.125).ToString();
                lblTotal.Text = "$" + (cost - (cost * 0.125) * 1.1).ToString();
            }
            if (cbxMembership.Text == "REGULAR")
            {
                lblDiscount.Text = "$" + (cost * 0.075).ToString();
                lblTotal.Text = "$" + (cost - (cost * 0.075) * 1.1).ToString();
            }
            if (cbxMembership.Text == "N/A" || cbxMembership.Text == "")
            {
                lblDiscount.Text = "$0";
                lblTotal.Text = "$" + (cost * 1.1).ToString();
            }
        }

        private void btnTimeDate_Click(object sender, EventArgs e)
        {
            int RecieptTimer = 0;

            RecieptTimer++;
            MessageBox.Show(RecieptTimes[RecieptTimer].ToString()); //This shows the time and date of the order submission in a message box.

        }
    }



}


