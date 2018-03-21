using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;



namespace WindowsFormsApp1
{



    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }
        
        //True or False Variable to determine if prime
        private Boolean isPrime(int n)


        {
            //If divisible by 2
            bool temp = true;
            for (int i = 2; i < n; i++)
            {

                if ((n % i) == 0)
                {
                    temp = false;
                    break;

                }

            }
            return temp;

        }
    
        

        private void button1_Click(object sender, EventArgs e)
        {//error handeling
            try
            {//Hides the form, declares variables, arguements for prime number.
                this.Hide();
                ulong a = 18446744073709551615;
                bool value = false;
                for (ulong j = 3; j <= a; j++)
                {
                    if (j == 2)
                        //primeNumbers.Items.Add(j);
                        //swPrimeNumber.WriteLine(j);
                        Console.WriteLine(j);


                    else
                    {
                        value = isPrime((int)(j));
                        if (value)
                        {
                            //primeNumbers.Items.Add(j);
                            //swPrimeNumber.WriteLine(j);
                            Console.WriteLine(j);

                        }

                    }

                }

            }
            catch
            {//What happens if you somehow goof.
                MessageBox.Show("You Dun Goofed Somehow! You Dun Did It.");
            }

            

        }
      

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
