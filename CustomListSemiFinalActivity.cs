using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rhehfe(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            customListItems();
        }
        private void customListItems()
        {
            ListUserControl[] listItems = new ListUserControl[20];

            for(int i = 0; i < listItems.Length; i++)
            {
                listItems[i] = new ListUserControl();
               
      /*
                if (flowLayoutPanel1.Controls.Count > 0)
                {
                    flowLayoutPanel1.Controls.Clear();
                } else {
                    flowLayoutPanel1.Controls.Add(listItems[i]);
                }
            */     

                
              
            }
        }
    }
}
