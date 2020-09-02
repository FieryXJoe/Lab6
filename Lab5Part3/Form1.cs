using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MidTermProject;
using Lab5;

namespace Lab5Part3
{
    public partial class Form1 : Form
    {
        List<Person> people = new List<Person>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();
            c.FName = txtFName.Text;
            c.MName = txtMName.Text;
            c.LName = txtLName.Text;
            c.StreetOne = txtStreetOne.Text;
            c.StreetTwo = txtStreetTwo.Text;
            c.City = txtCity.Text;
            c.StateCode = txtStateCode.Text;
            c.ZipCode = txtZipCode.Text;
            c.PhoneNum = txtPhoneNum.Text;
            c.EmailAddress = txtEmailAddress.Text;
            //New
            c.CellNum = txtCellPhoneNum.Text;
            c.InstagramURL = txtInstagramURL.Text;
            //Part 3
 //           c.CustomerSince = txtDateTime.Value;
 //           c.DiscountMember = checkBoxDiscountMember.Checked;
            //Ensuring correct data types
 /*           if (BasicTools.isValidDouble(txtTotalPurchases.Text))
            {
                double temp;
                Double.TryParse(txtTotalPurchases.Text, out temp);
                c.TotalPurchases = temp;
            }
            else
            {
                c.Feedback += "\n Error: Total Purchases not double";
                c.TotalPurchases = 1;
            }
            if (BasicTools.isValidInt(txtRewardsEarned.Text))
            {
                int temp;
                Int32.TryParse(txtRewardsEarned.Text, out temp);
                c.RewardsEarned = temp;
            }
            else
            {
                c.Feedback += "\n Error: Rewards Earned not int";
                c.RewardsEarned = 0;
            }
 */
            //This code vastly shortened by moving error feedback to object
            if (c.Feedback.Contains("Error"))
            {
                lblErrorMsg.Text = c.Feedback;
                c.Feedback = "";
            }
            //Successful submission code
            else
            {
                lblErrorMsg.Text = "Input Errors: NONE";
                lblErrorMsg.Text += c.AddARecord();

                txtFName.Text = "";
                txtMName.Text = "";
                txtLName.Text = "";
                txtStreetOne.Text = "";
                txtStreetTwo.Text = "";
                txtCity.Text = "";
                txtStateCode.Text = "";
                txtZipCode.Text = "";
                txtPhoneNum.Text = "";
                txtEmailAddress.Text = "";

                txtCellPhoneNum.Text = "";
                txtInstagramURL.Text = "";

    //            checkBoxDiscountMember.Checked = false;
    //            txtRewardsEarned.Text = "";
    //            txtTotalPurchases.Text = "";

                setFeedbackV2(c);
                people.Add(c);
            }
        }

        // Takes a person object and formats the data and outputs it in GUI
        private void setFeedback(Person p)
        {
            String s = "";
            s += $"\n Name: {p.FName} {p.MName} {p.LName}";
            s += $"\n Address: {p.StreetOne} {p.StreetTwo} , {p.City} {p.StateCode} , {p.ZipCode}";
            s += $"\n Phone Number: {p.PhoneNum}";
            s += $"\n Email: {p.EmailAddress}";
            lblFeedback.Text = s;
        }
        private void setFeedbackV2(PersonV2 p)
        {
            String s = "";
            s += $"\n Name: {p.FName} {p.MName} {p.LName}";
            s += $"\n Address: {p.StreetOne} {p.StreetTwo} , {p.City} {p.StateCode} , {p.ZipCode}";
            s += $"\n Phone Number: {p.PhoneNum} ,\n Cell Number: {p.CellNum}";
            s += $"\n Email: {p.EmailAddress} , \n Instagram : {p.InstagramURL}";
            lblFeedback.Text = s;
        }
        private void setFeedbackVCust(Customer p)
        {
            String s = "";
            s += $"\n Name: {p.FName} {p.MName} {p.LName}";
            s += $"\n Address: {p.StreetOne} {p.StreetTwo} , {p.City} {p.StateCode} , {p.ZipCode}";
            s += $"\n Phone Number: {p.PhoneNum} ,\n Cell Number: {p.CellNum}";
            s += $"\n Email: {p.EmailAddress} , \n Instagram : {p.InstagramURL}";
            s += $"\n Customer Since: {p.CustomerSince} , Discount Member: {p.DiscountMember}";
            s += $"\n Total Purchases: {p.TotalPurchases} , Rewards Earned: {p.RewardsEarned}";
            lblFeedback.Text = s;
        }
    }
}
