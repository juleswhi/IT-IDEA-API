﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT_IDEA_DESKTOP.Forms
{
    public partial class FormAddIdea : Form
    {
        public FormAddIdea()
        {
            InitializeComponent();
        }

        private async void lblAddIdea_Click(object sender, EventArgs e)
        {
            List<string> names = await APIClient.GetDescriptionsAsync();

            ((Label)sender).Text = names[0];
        }
    }
}