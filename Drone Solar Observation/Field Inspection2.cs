﻿using System;
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
    public partial class Field_Inspection2 : Form
    {
        public Field_Inspection2()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Field_Inspection2 field_Inspection2 = new Field_Inspection2();
            field_Inspection2.Show();
            this.Hide();
        }
    }
}
