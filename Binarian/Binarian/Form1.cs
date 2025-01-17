using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Binarian
{
    public partial class Form1 : Form
    {
        byte total = 0;
        int[] bits = new int[8];
        int[] bitsB = new int[8];
        int[] bitsC = new int[8];
        public Form1()
        {
            InitializeComponent();
        }
        private void calc()
        {
            //git tested
            total = 0;
            if (bits[0] != 0) total += 1;
            if (bits[1] != 0) total += 2;
            if (bits[2] != 0) total += 4;
            if (bits[3] != 0) total += 8;
            if (bits[4] != 0) total += 16;
            if (bits[5] != 0) total += 32;
            if (bits[6] != 0) total += 64;
            if (bits[7] != 0) total += 128;
            label1.Text = total.ToString();
        }
        private void bit1_TextChanged(object sender, EventArgs e)
        {
          
            label1.Text = total.ToString();
            //bit1
            if (bit1.Text == "1") 
                bits[0] = 1;
            else            
                bits[0] = 0;
            //bit2
            if (bit2.Text == "1")
                bits[1] = 1;
            else
                bits[1] = 0;
            //bit3
            if (bit3.Text == "1")
                bits[2] = 1;
            else
                bits[2] = 0;
            //bit4
            if (bit4.Text == "1")
                bits[3] = 1;
            else
                bits[3] = 0;
            //bit5
            if (bit5.Text == "1")
                bits[4] = 1;
            else
                bits[4] = 0;
            //bit6
            if (bit6.Text == "1")
                bits[5] = 1;
            else
                bits[5] = 0;
            //bit7
            if (bit7.Text == "1")
                bits[6] = 1;
            else
                bits[6] = 0;
            //bit8
            if (bit8.Text == "1")
                bits[7] = 1;
            else
                bits[7] = 0;
            calc();

        }
        //Row 2
        private void ulator()
        {
            //git tested
            total = 0;
            if (bitsB[0] != 0) total += 1;
            if (bitsB[1] != 0) total += 2;
            if (bitsB[2] != 0) total += 4;
            if (bitsB[3] != 0) total += 8;
            if (bitsB[4] != 0) total += 16;
            if (bitsB[5] != 0) total += 32;
            if (bitsB[6] != 0) total += 64;
            if (bitsB[7] != 0) total += 128;
            label2.Text = total.ToString();
        }
        private void BitB8_TextChanged_1(object sender, EventArgs e)
        {
            label2.Text = total.ToString();
            //bit1
            if (BitB1.Text == "1")
                bitsB[0] = 1;
            else
                bitsB[0] = 0;
            //bit2
            if (BitB2.Text == "1")
                bitsB[1] = 1;
            else
                bitsB[1] = 0;
            //bit3
            if (BitB3.Text == "1")
                bitsB[2] = 1;
            else
                bitsB[2] = 0;
            //bit4
            if (BitB4.Text == "1")
                bitsB[3] = 1;
            else
                bitsB[3] = 0;
            //bit5
            if (BitB5.Text == "1")
                bitsB[4] = 1;
            else
                bitsB[4] = 0;
            //bit6
            if (BitB6.Text == "1")
                bitsB[5] = 1;
            else
                bitsB[5] = 0;
            //bit7
            if (BitB7.Text == "1")
                bitsB[6] = 1;
            else
                bitsB[6] = 0;
            //bit8
            if (BitB8.Text == "1")
                bitsB[7] = 1;
            else
                bitsB[7] = 0;
            ulator();

        }

        private void bit7_MouseDown(object sender, MouseEventArgs e) => ((TextBox)sender).Text = (((TextBox)sender).Text == "1") ? "0" : "1";

        private void Clear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bits.Length; i++)
                bits[i] = 0;
            Update();
        }
        private void Update()
        {
            bit1.Text = (bits[0] == 1 ? "1" : "0");
            bit2.Text = (bits[0] == 1 ? "1" : "0");
            bit3.Text = (bits[0] == 1 ? "1" : "0");
            bit4.Text = (bits[0] == 1 ? "1" : "0");
            bit5.Text = (bits[0] == 1 ? "1" : "0");
            bit6.Text = (bits[0] == 1 ? "1" : "0");
            bit7.Text = (bits[0] == 1 ? "1" : "0");
            bit8.Text = (bits[0] == 1 ? "1" : "0");
            BitB1.Text = (bitsB[0] == 1 ? "1" : "0");
            BitB2.Text = (bitsB[0] == 1 ? "1" : "0");
            BitB3.Text = (bitsB[0] == 1 ? "1" : "0");
            BitB4.Text = (bitsB[0] == 1 ? "1" : "0");
            BitB5.Text = (bitsB[0] == 1 ? "1" : "0");
            BitB6.Text = (bitsB[0] == 1 ? "1" : "0");
            BitB7.Text = (bitsB[0] == 1 ? "1" : "0");
            BitB8.Text = (bitsB[0] == 1 ? "1" : "0");
            bitC1.Text = (bitsC[0] == 1 ? "1" : "0");
            bitC2.Text = (bitsC[0] == 1 ? "1" : "0");
            bitC3.Text = (bitsC[0] == 1 ? "1" : "0");
            bitC4.Text = (bitsC[0] == 1 ? "1" : "0");
            bitC5.Text = (bitsC[0] == 1 ? "1" : "0");
            bitC6.Text = (bitsC[0] == 1 ? "1" : "0");
            bitC7.Text = (bitsC[0] == 1 ? "1" : "0");
            bitC8.Text = (bitsC[0] == 1 ? "1" : "0");
          
        }
        private void UpdateA()
        {
            bit1.Text = (bits[0] == 1 ? "1" : "0");
            bit2.Text = (bits[0] == 1 ? "1" : "0");
            bit3.Text = (bits[0] == 1 ? "1" : "0");
            bit4.Text = (bits[0] == 1 ? "1" : "0");
            bit5.Text = (bits[0] == 1 ? "1" : "0");
            bit6.Text = (bits[0] == 1 ? "1" : "0");
            bit7.Text = (bits[0] == 1 ? "1" : "0");
            bit8.Text = (bits[0] == 1 ? "1" : "0");
        }
        private void UpdateB()
        {
            BitB1.Text = (bitsB[0] == 1 ? "1" : "0");
            BitB2.Text = (bitsB[0] == 1 ? "1" : "0");
            BitB3.Text = (bitsB[0] == 1 ? "1" : "0");
            BitB4.Text = (bitsB[0] == 1 ? "1" : "0");
            BitB5.Text = (bitsB[0] == 1 ? "1" : "0");
            BitB6.Text = (bitsB[0] == 1 ? "1" : "0");
            BitB7.Text = (bitsB[0] == 1 ? "1" : "0");
            BitB8.Text = (bitsB[0] == 1 ? "1" : "0");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bit1.Text = bit2.Text;
            bit2.Text = bit3.Text;
            bit3.Text = bit4.Text;
            bit4.Text = bit5.Text;
            bit5.Text = bit6.Text;
            bit6.Text = bit7.Text;
            bit7.Text = bit8.Text;
            bit8.Text = "";
            BitB1.Text = BitB2.Text;
            BitB2.Text = BitB3.Text;
            BitB3.Text = BitB4.Text;
            BitB4.Text = BitB5.Text;
            BitB5.Text = BitB6.Text;
            BitB6.Text = BitB7.Text;
            BitB7.Text = BitB8.Text;
            BitB8.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bits.Length; i++)
                bits[i] = 0;
            UpdateA();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bits.Length; i++)
                bits[i] = 0;
            UpdateB();
        }
    }
}

        