using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drone_Solar_Observation
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbAO.Clear();
            tbAT.Clear();
            tbBSD.Clear();
            tbESAKP.Clear();
            tbIC.Clear();
            tbNOMAASCW.Clear();
            tbPA.Clear();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Inspection_Checklist frmICL = new Inspection_Checklist();
            frmICL.Show();
            this.Hide();
        }
    }
}
