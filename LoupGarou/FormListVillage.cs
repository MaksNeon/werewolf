﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoupGarou
{
    public partial class FormListVillage : Form
    {
        public FormListVillage(BindingList<Villageois> village)
        {
            InitializeComponent();
            timerUpdateList.Start();
            lsbVillage.DataSource = village;
            //lsbVillage.DisplayMember = "Name"; // Assuming Villageois has a Name property
        }

        private void FormListVillage_Load(object sender, EventArgs e)
        {

        }

        private void FormListVillage_Enter(object sender, EventArgs e)
        {

        }
    }
}
