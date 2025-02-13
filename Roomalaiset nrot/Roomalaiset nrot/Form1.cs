using System.Runtime.Intrinsics.X86;

namespace Roomalaiset_nrot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MuutaBT_Click(object sender, EventArgs e)
        {
            if (int.TryParse(TekstiTB.Text, out int number) && number >= 0 && number <= 3999)
            {
                VastausLB.Text = "Roomalainen numero: " + ConvertToRoman(number);
                VastausLB.Visible = true;
            }
            else
            {
                VastausLB.Text = "Anna luku väliltä 0 - 3999";
                VastausLB.Visible = true;
            }
        }
        private string ConvertToRoman(int num)
        {
            string[] thousands = { "", "M", "MM", "MMM" };
            string[] hundreds = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] tens = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] ones = { "", "I", "II", "III", "IV", "V", "VII", "VIII", "IX" };

            String numStr = num.ToString();
            int len = numStr.Length;

            string roman = "";
            if (len == 4) roman += thousands[int.Parse(numStr.Substring(0, 1))];
            if (len >= 3) roman += hundreds[int.Parse(numStr.Substring(len - 3, 1))];
            if (len >= 2) roman += tens[int.Parse(numStr.Substring(len - 2, 1))];
            if (len >= 1) roman += ones[int.Parse(numStr.Substring(len - 1, 1))];

            return roman;
        }
    }
}
