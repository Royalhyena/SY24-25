using System;
using System.Collections.Generic;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace i_didnt_know_that
{
    internal class Tile
    {
        private Button m_b;
        private bool m_flag;
        private bool m_dug;
        private bool m_mine;
        private int m_nearby;
        private Image m_flagimage;
        private Image m_mineimage;

        public Tile(Button buttonB)
        {
            m_b = buttonB;
            m_b.BackColor = Color.Green;

        }
        public void setnearby(int n) { m_nearby = n; m_b.Text = m_nearby.ToString(); }
        public void setflagimage(Image flagimage) { m_flagimage = flagimage; }
        public void setmineimage(Image mineimage) { m_mineimage = mineimage; }
        public void setmine(bool b)
        {
            m_mine = b;
          
        }
        public Boolean getmine() { return m_mine; }
        public void setdug() 
        { 
            m_dug = true;
            if (m_mine)
                m_b.BackgroundImage = m_mineimage;
        }
        public void setflag()
        {
            m_flag = !m_flag;
            if (m_flag)
                m_b.BackgroundImage = m_flagimage;
            else
                m_b.BackgroundImage = null;
        }
     
    }
}
