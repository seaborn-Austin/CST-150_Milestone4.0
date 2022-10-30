using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_150_Milestone4._0
{
    public partial class reorderFrm : Form
    {
        public reorderFrm()
        {
            InitializeComponent();
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int ordrNumber = r.Next(5000, 10000);
            MessageBox.Show(quantityTxt.Text + " " + nameTxt.Text + "'s with SKU " + skuTxt.Text
                               + " has been reordered from " + supplierTxt.Text
                               + " Your order number is: " + "ORDR" + ordrNumber);
        }
    }
}
