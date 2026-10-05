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
    public partial class FrmSummary : Form
    {
        FrOrder F1;
        public FrmSummary(FrOrder Fo)
        {
            InitializeComponent();
            F1 = Fo;
           
        }

        private void textBox_Su_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmSummary_Load(object sender, EventArgs e)
        {
            string D = DateTime.Now.ToString("dd/MM//yyyy: hh:mm ");
            label_ShowTime.Text = D;
            Random R = new Random();
            int Number = R.Next(20, 550);
            label_ShowNumberClient.Text = Number.ToString();

            Bitmap bmp = new Bitmap(pictureBox_ImageSu.Image);

            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    if (bmp.GetPixel(x, y) == Color.White)
                    {
                        bmp.SetPixel(x, y, this.BackColor);
                    }
                }
            }

            pictureBox_ImageSu.Image = bmp;
        }

        private void button_goback_Click(object sender, EventArgs e)
        {
            this.Hide();
            F1.Show();
        }
        int Line = 0;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string Titel = label_ShowTitel.Text;
            string DateAndTime = label_ShowTime.Text;
            string Number = "##NO: " + label_ShowNumberClient.Text;
            string Size = label_ShowSize.Text;
            string Crust = label_ShowCrust.Text;
            string WhereToEat = label_ShowWhareEat.Text;
            string Toppins = label_ShowTopins.Text;
            string Total = label_ShowTotal.Text;

            textBox_Su.Text =
                   Titel + Environment.NewLine + Environment.NewLine +
                 "Date And Time:  "+ DateAndTime + Environment.NewLine + Environment.NewLine +
                 Number + Environment.NewLine + Environment.NewLine +
               "Size: "+Size + Environment.NewLine + Environment.NewLine +
               "Crust Type: "+Crust + Environment.NewLine + Environment.NewLine +
    "Where To Eat: "+WhereToEat + Environment.NewLine + Environment.NewLine +
    "Toppins: "+Toppins + Environment.NewLine + Environment.NewLine +
    "Total: "+Total;

            e.HasMorePages = false;
            Font F = new Font("Monotype Corsiva", 25 , FontStyle.Bold);
            int CurrentHeight = 0;
            for (; Line < textBox_Su.Lines.Length; Line++)
            {
                e.Graphics.DrawString(textBox_Su.Lines[Line], F, Brushes.Black, 10, CurrentHeight + 50);
                CurrentHeight += F.Height;
                if (CurrentHeight > e.PageBounds.Height - 50)
                {
                    e.HasMorePages = true;
                    break;
                }
            }

        }
        private void button_SureOrder_Click(object sender, EventArgs e)
        {
           DialogResult R= MessageBox.Show("Do You Want To Confim The Order(Y/N)? ", "Titel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            List<string> TempStr = new List<string>();
            if(R==DialogResult.Yes)
            {
                for (int i = 0; i < textBox_Su.Lines.Length; i++)
                {
                    string Str = textBox_Su.Lines[i];
                    if (Str.Length < 70)
                    {
                        TempStr.Add(Str);
                    }
                    else
                    {
                        while (Str.Length > 70)
                        {
                            string StrSub = Str.Substring(0, 70);
                            TempStr.Add(StrSub);
                            Str = Str.Substring(70, Str.Length - 70);
                        }
                        TempStr.Add(Str);
                    }
                }
                textBox_Su.Text = "";
                foreach (string Str in TempStr)
                {
                    textBox_Su.Text += Str + Environment.NewLine;
                }
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
            }
            else
            {
                this.Show();
            }
        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            Line = 0;
        }
    }
}
