using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaProject
{
    public partial class Form1 : Form
    {
        int basePrice = 0;
        int toppingPrice = 0;
        int crustPrice = 0;


        const int SMALL_PRICE = 10;
        const int MEDIUM_PRICE = 20;
        const int LARGE_PRICE = 30;
        const int TOPPING_PRICE = 5;

        public Form1()
        {
            InitializeComponent();
        }
        List<string> toppings = new List<string>();

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lbSummarySize.Text = "Small";
            if (rbSmall.Checked)
                basePrice = SMALL_PRICE;

            UpdatePrice();
        }
        private void UpdatePrice()
        {
            lbPrice.Text = (basePrice + toppingPrice + crustPrice) + " $";
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbSummaryToppings_Click(object sender, EventArgs e)
        {



        }

        private void lbSummarySize_Click(object sender, EventArgs e)
        {


        }

        private void rbMeduim_CheckedChanged(object sender, EventArgs e)
        {
            lbSummarySize.Text = "Medium";
            if (rbMeduim.Checked)
                basePrice = MEDIUM_PRICE;

            UpdatePrice();
        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            lbSummarySize.Text = "Large";
            if (rbLarge.Checked)
                basePrice = LARGE_PRICE;

            UpdatePrice();
        }

        private void chkExtraChess_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTopping("Extra Chess", chkExtraChess.Checked);

        }

        private void gbToppings_Enter(object sender, EventArgs e)
        {

        }
        private void UpdateSummary(int itemsPerLine = 3)
        {
            if (toppings.Count == 0)
            {
                lbSummaryToppings.Text = "No topping added";
                return;
            }

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < toppings.Count; i++)
            {
                sb.Append(toppings[i]);

                if ((i + 1) % itemsPerLine == 0)
                    sb.AppendLine();          // new line
                else
                    sb.Append(", ");
            }

            lbSummaryToppings.Text = sb.ToString().Trim(',', ' ', '\n');
        }

        private void UpdateTopping(string topping, bool isChecked)
        {
            if (isChecked && !toppings.Contains(topping))
            {
                toppings.Add(topping);
                toppingPrice += TOPPING_PRICE;
            }
            else if (!isChecked && toppings.Contains(topping))
            {
                toppings.Remove(topping);
                toppingPrice = Math.Max(0, toppingPrice - TOPPING_PRICE);
            }


            UpdateSummary(3); // 👈 change 3 to any number you want
            UpdatePrice();

        }


        private void chknion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTopping("Onion", chkOnion.Checked);
        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTopping("Mushrooms", chkMushrooms.Checked);
        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTopping("Tomatoees", chkTomatoes.Checked);
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTopping("Olives", chkOlives.Checked);
        }

        private void chkGreenPepperss_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTopping("Green Peperss", chkGreenPepperss.Checked);
        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            lbSummaryEat.Text = "Take Out";

        }

        private void rbEatIn_CheckedChanged_1(object sender, EventArgs e)
        {
            lbSummaryEat.Text = "Eat In";

        }

        private void rbThinCurst_CheckedChanged(object sender, EventArgs e)
        {
            if (rbThinCurst.Checked)
                crustPrice = 0;

            lbSummaryCurst.Text = "Thin Crust";
            UpdatePrice();
        }

        private void rbThinkCurst_CheckedChanged(object sender, EventArgs e)
        {
            if (rbThinkCurst.Checked)
                crustPrice = 5;

            lbSummaryCurst.Text = "Thick Crust";
            UpdatePrice();

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure To Confirm", "Confrim", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Order Placed Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gbCurstType.Enabled = false;
                gbSize.Enabled = false;
                gbToppings.Enabled = false;
                gbWhereToEat.Enabled = false;
                btnOrder.Enabled = false;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            basePrice = 0;
            toppingPrice = 0;
            crustPrice = 0;
            toppings.Clear();

            lbPrice.Text = "0 $";
            lbSummarySize.Text = "";
            lbSummaryCurst.Text = "";
            lbSummaryEat.Text = "";
            lbSummaryToppings.Text = "No topping added";

            gbCurstType.Enabled = true;
            gbSize.Enabled = true;
            gbToppings.Enabled = true;
            gbWhereToEat.Enabled = true;
            btnOrder.Enabled = true;
        }
    }
}
