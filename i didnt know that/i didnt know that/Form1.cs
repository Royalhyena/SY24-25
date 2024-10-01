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

        Button[] btnGrid = new Button[100];
        Tile[] tilegrid = new Tile[100];
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();

            ResetGame();
        }
        void ResetGame()
        {
            for (int i = 0; i < 100; i++)
            {
                btnGrid[i] = (Button)Controls["button" + (i + 1)];
                tilegrid[i] = new Tile(btnGrid[i]);
                tilegrid[i].setflagimage(Flagbox.Image);
                //   tilegrid[i].setflag(false);
                tilegrid[i].setmineimage(Minebox.Image);
                // tilegrid[i].setmine(true);
            }
            craeteminee(5);

            for (int r = 1; r < 11; r++)
            {
                for (int c = 1; c < 11; c++)
                {
                    tilegrid[getindex(getButton(r, c))].setnearby(countadjaceent(r, c));
                }
                // int idx = getindex(getButton(2, 3));
                // btnGrid[idx].BackColor = Color.Green;
            }
        }
        private Button getButton(int r, int c)
        {
            int idx = (c - 1) * 10 + (r - 1);
            return (Button)btnGrid[idx];

        }
        private int getindex(Button b)
        {
            string tmp = b.Name.Substring(6);
            int retval = 0;
            int.TryParse(tmp, out retval);
            return retval - 1;
        }
        private void button91_MouseDown(object sender, MouseEventArgs e)
        {
            Button b = sender as Button;
            Tile t = tilegrid[getindex(b)];
            if (e.Button == MouseButtons.Right)
                t.setflag();
            if (e.Button == MouseButtons.Left)
            {
                t.setdug();
            }

        }
        private int countadjaceent(int r, int c)
        {
            /**
            for (int x = -1; x <= 1; x++)
            {
                for (int y = -1; y <= 1; y++)
                {
                    getButton(r + x, c + y).BackColor = Color.HotPink;
                }
            }
            **/
            int count = 0;
            if (r > 1 && c > 1)
            {
                if (tilegrid[getindex(getButton(r - 1, c - 1))].getmine()) count++;
            }
            if (r > 1)
            {
                if (tilegrid[getindex(getButton(r - 1, c))].getmine()) count++;
            }
            if (r > 1 && c < 10)
            {
                if (tilegrid[getindex(getButton(r - 1, c + 1))].getmine()) count++;
            }
            if (c > 1)
            {
                if (tilegrid[getindex(getButton(r, c - 1))].getmine()) count++;
            }
            if (c < 10)
            {
                if (tilegrid[getindex(getButton(r, c + 1))].getmine()) count++;
            }
            if (r < 10 && c > 1)
            {
                if (tilegrid[getindex(getButton(r + 1, c - 1))].getmine()) count++;
            }
            if (r < 10)
            {
                if (tilegrid[getindex(getButton(r + 1, c))].getmine()) count++;
            }
            if (r < 10 && c < 10)
            {
                if (tilegrid[getindex(getButton(r + 1, c + 1))].getmine()) count++;
            }
            return count;
        }


        private void craeteminee(int numMines)
        {

            int minecount = 0;
            // until we have enough minrs
            while (minecount < numMines)
            {
                //  // generate num from 1-100
                int rnum = random.Next(0, 100);
                // set mine on that tile if there is not all ready a min
                if (tilegrid[rnum].getmine() == false)
                {
                    minecount++;
                    tilegrid[rnum].setmine(true);

                }
            }

        }
        private void setcount()
        {
            for (int r = 1; r < 10; r++)
            {
                for (int c = 1; c < 10; c++)
                {
                    getButton(r, c).BackColor = Color.Honeydew;
                }
            }
        }
        private void Reset_Click(object sender, EventArgs e)
        {
            ResetGame();


        }
    }
}

