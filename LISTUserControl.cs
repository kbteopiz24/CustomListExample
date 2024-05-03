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
    public partial class ListUserControl : UserControl
    {
        public ListUserControl()
        {
            InitializeComponent();
        }

        private string _brandName, _modelName;
        private double _itemPrice;
        private Image _icon;

        [Category("Custom Props")]
        public string BrandName
        {
            get { return _brandName; }
            set { _brandName = value; }
        }

        [Category("Custom Props")]
        public string ModelName
        {
            get { return _modelName; }
            set { _modelName = value; }
        }

        [Category("Custom Props")]

        public double ItemPrice
        {
            get { return _itemPrice; }
            set { _itemPrice = double.Parse(value.ToString()); }
        }

        [Category("Custom Props")]

        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; pictureBox1.Image = value; }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ListUserControl_Load(object sender, EventArgs e)
        {

        }

        private void brandName_Click(object sender, EventArgs e)
        {
                
        }
    }
}
