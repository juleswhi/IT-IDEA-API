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

        private async void btnCreateIdea_Click(object sender, EventArgs e)
        {

            // validate

            if (txtBoxName.Text.Contains('\'') || txtBoxDescription.Text.Contains('\''))
            {
                lblResult.Text = "Please Do Not Use a Quotation Mark";
                return;
            }
            if (!int.TryParse(txtBoxFeasibility.Text, out int a))
            {
                lblResult.Text = "Please Only Use a Number for feasibility";
                return;
            }
            if (a > 5 || a < 0)
            {
                lblResult.Text = "Please Make Feasibility A Number Between 1 and 5";
                return;
            }



            // Call API to create Idea
            HttpResponseMessage res = await APIClient.CreateIdeaAsync(new Idea()
            {
                Id = "23",
                Name = txtBoxName.Text,
                Description = txtBoxDescription.Text,
                Feasibility = txtBoxFeasibility.Text,
            });

            if (res.IsSuccessStatusCode)
            {
                lblResult.Text = "Success!";
            }

        }
    }
}
