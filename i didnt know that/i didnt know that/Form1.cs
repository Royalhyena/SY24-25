using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace i_didnt_know_that
{

    public partial class Form1 : Form
    {
        Random random = new Random();
        Button[] btnGrid = new Button[100];
        Tile[] tilegrid = new Tile[100];
        public Form1()
        {
            InitializeComponent();
           
            for (int i = 0; i < 100; i++)
            {
                btnGrid[i] = (Button)Controls["button" + (i + 1)];
                tilegrid[i] = new Tile(btnGrid[i]);
            }
            for (int i = 0; i < 100; i++)
            {
                btnGrid[i].BackColor = Color.Green;
            }
        }
        private Button getButton(int r, int c)
        {
            return (Button)getButton(r, c);
        }
       private int getindex(Button b)
        {
            string tmp = b.Name.Substring(6);
                int retval = 0;
            int.TryParse(tmp, out retval);
            return retval -1;
        }
        private void button91_MouseDown(object sender, MouseEventArgs e)
        {
            Button b = sender as Button;
            b.BackColor = Color.Red;
        }
    }
}

