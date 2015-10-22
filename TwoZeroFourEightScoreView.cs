using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace twozerofoureight
{
    public partial class TwoZeroFourEightScoreView : Form
    {
        public TwoZeroFourEightScoreView()
        {
            InitializeComponent();
        }

        public void scoreview(int sv) {

            lblScore.Text = Convert.ToString(sv);
        }

        private void num_Click(object sender, EventArgs e)
        {

        }
    }
}
