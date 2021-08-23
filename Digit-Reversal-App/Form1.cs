using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTFI1_Parinas_DigitReversal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Reverse_Click(object sender, EventArgs e)
        {
         //Objective: Reverse user's given number
         //Input: Number given by user
         //Process: Separate each digit and arrange it in reverse order
            //HOW: Modulus siguro?? I can divide given number by 10 and take the remainder as separate digit
            // Rinse & Repeat this till I have every digit, then rearrange them in reverse order
        //Output: Reversed number. Yehey.

            //1.) Declare 1st variable as number and store user's input there
            int number = int.Parse(txt1.Text);
            //2.) Declare variables; one for the remainder, and one for the current reversed number. Set revNumber as 0 for the first cycle
            int remainder, revNumber = 0;
            //3.1) Make sure that I don't have to repeatedly type the same formula to reverse each digit (I used loop)
            //3.2) MAKE SURE LOOP WON'T END IF REVERSED NUMBER ISN'T COMPLETE YET!
            while (number > 0)
            {
                //4.) Take user's input and divide it by 10, only taking the remainder as the answer. Store remainder in remainder variable
                remainder = number % 10;
                //5.) Take user's inputted number and divide by 10, store answer in number variable to replace it's current value with the answer as the new value
                number = number / 10;
                //6.) multiply value of revNumber (which is 0 in 1st cycle) by 10 and add it with remainder value from earlier. Store answer as the new revNumber value.
                revNumber = (revNumber * 10) + remainder;
                //7.) Cycle repeats till the value of number variable is equal to 0 and all digits for the user's given number have been reversed
            }
            //8.) If cycle no longer repeats, display current value of revNumber to output textbox
            txtOut.Text = revNumber.ToString();
            //9.) Ipagdasal na sana gumagana yung program pag inopen ni ser eisen
        }
    }
}
