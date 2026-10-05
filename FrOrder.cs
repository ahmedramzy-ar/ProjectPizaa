using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPizaa
{
    public partial class FrOrder : Form
    {
        FrmSummary F2;
        public FrOrder()
        {
            InitializeComponent();
            radioButton_ThickCrust.Checked = false;
            F2 = new FrmSummary(this);
        }

        private void groupBox_Size_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.AliceBlue, 2))
            {
                e.Graphics.DrawRectangle(
                    pen,
                    1,
                    10,
                    groupBox_Size.Width - 3,
                    groupBox_Size.Height - 12
                );
            }
        }

        private void groupBox_Toppins_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.AliceBlue, 2))
            {
                e.Graphics.DrawRectangle(
                    pen,
                    1,
                    10,
                    groupBox_Toppins.Width - 3,
                    groupBox_Toppins.Height - 12
                );
            }
        }

        private void groupBox_CrustType_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.AliceBlue, 2))
            {
                e.Graphics.DrawRectangle(
                    pen,
                    1,
                    10,
                   groupBox_CrustType.Width - 3,
                    groupBox_CrustType.Height - 12
                );
            }
        }

        private void groupBox_WhereToEat_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.AliceBlue, 2))
            {
                e.Graphics.DrawRectangle(
                    pen,
                    1,
                    10,
                   groupBox_WhereToEat.Width - 3,
                    groupBox_WhereToEat.Height - 12
                );
            }
        }

        private void button_GoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMain F = new FrmMain();
            F.ShowDialog();
        }
        int PriceSize = 0;
        int PriceExtraCheese = 0;
        int PriceMushrooms = 0;
        int PriceTomatoes = 0;
        int PriceOnion = 0;
        int PriceOlives = 0;
        int PriceGreenPeppers = 0;
        int PriceThicrOrThinCrust = 0;
        int PriceEatInOrEatOut = 0;
        private void Calculator()
        {
            int Total = PriceSize + PriceExtraCheese + PriceMushrooms + PriceTomatoes + PriceOnion + PriceOlives + PriceGreenPeppers + PriceThicrOrThinCrust + PriceEatInOrEatOut;
            label_Price.Text = Total.ToString();
        }
        private void radioButton_Small_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton_Small.Checked)
            {
                PriceSize = 30;
                Calculator();
            }
        }

        private void radioButton_Meduim_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton_Meduim.Checked)
            {
                PriceSize = 45;
                Calculator();
            }
        }

        private void radioButton_Larg_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton_Larg.Checked)
            {
                PriceSize = 60;
                Calculator();
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_ExtraCheese.Checked)
            {
                PriceExtraCheese = 40;
                
            }
            else
            {
                PriceExtraCheese = 0;
            }
            Calculator();
        }

        private void checkBox_Mushrooms_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_Mushrooms.Checked)
            {
                PriceMushrooms = 35;
               
            }
            else
            {
                PriceMushrooms = 0;
            }
            Calculator();
        }

        private void checkBox_Tomatoes_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_Tomatoes.Checked)
            {
                PriceTomatoes = 30;
                
            }
            else
            {
                PriceTomatoes = 0;
            }
            Calculator();
        }

        private void checkBox_Onion_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_Onion.Checked)
            {
                PriceOnion = 25;
            }
            else
            {
                PriceOnion = 0;
            }
            Calculator();
        }

        private void checkBox_Olives_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_Olives.Checked)
            {
                PriceOlives = 20;
            }
            else
            {
                PriceOlives = 0;
            }
            Calculator();
        }

        private void checkBox_GreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_GreenPeppers.Checked)
            {
                PriceGreenPeppers = 33;
            }
            else
            {
                PriceGreenPeppers = 0;
            }
            Calculator();
        }

        private void radioButton_ThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton_ThinCrust.Checked)
            {
                PriceThicrOrThinCrust = 20;
                Calculator();
            }
        }

        private void radioButton_ThickCrust_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton_ThickCrust.Checked)
            {
                PriceThicrOrThinCrust = 35;
                Calculator();
            }
        }

        private void radioButton_Eatin_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton_Eatin.Checked)
            {
                PriceEatInOrEatOut = 20;
                Calculator();
            }
        }

        private void radioButton_TakeOut_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton_TakeOut.Checked)
            {
                PriceEatInOrEatOut = 10;
                Calculator();
            }
        }
        string Toppins = "";
        private void button_ORDER_Click(object sender, EventArgs e)
        {
            
            Toppins = "";
            if (radioButton_Small.Checked)
            {
                F2.label_ShowSize.Text = "Small";
            }
            if(radioButton_Meduim.Checked)
            {
                F2.label_ShowSize.Text = "Meduim";
            }
            if(radioButton_Larg.Checked)
            {
                F2.label_ShowSize.Text = "Larg";
            }
            if(checkBox_ExtraCheese.Checked)
            {
                Toppins += "Extra Cheese  ";
            }
            if(checkBox_Mushrooms.Checked)
            {
                Toppins += "Mushrooms  \n";
            }
            if(checkBox_Tomatoes.Checked)
            {
                Toppins += "Tomatoes  ";
            }
            if(checkBox_Onion.Checked)
            {
                Toppins += "Onion\n";
            }
            if(checkBox_Olives.Checked)
            {
                Toppins += "Olives  ";
            }
            if(checkBox_GreenPeppers.Checked)
            {
                Toppins += "Green Peppers\n";
            }
            if(radioButton_ThickCrust.Checked)
            {
                F2.label_ShowCrust.Text = "Thick Crust";
            }
            if(radioButton_ThinCrust.Checked)
            {
                F2.label_ShowCrust.Text = "Thin Crust";
            }
            if(radioButton_TakeOut.Checked)
            {
                F2.label_ShowWhareEat.Text = "Take Out";
            }
            if(radioButton_Eatin.Checked)
            {
                F2.label_ShowWhareEat.Text = "Take In";
            }

            F2.label_ShowTopins.Text = Toppins;
            F2.label_ShowTotal.Text = label_Price.Text;
            this.Hide();
            F2.Show();
           
        }

        private void FrOrder_Load(object sender, EventArgs e)
        {
            radioButton_Small.Checked = true;
            radioButton_Small.Focus();
        }
    }
}
