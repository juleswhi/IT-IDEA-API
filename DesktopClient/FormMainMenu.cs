using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT_IDEA_DESKTOP
{
    public partial class FormMainMenu : Form
    {
        private Button currentButton;
        private Form activeForm;

        public FormMainMenu()
        {
            InitializeComponent();
        }



        private void ActivateButton(object btnSender)
        {
            if (btnSender == null) return;
            if (currentButton == (Button)btnSender) return;

            DisableButton();

            currentButton = (Button)btnSender;
            currentButton.ForeColor = Color.FromArgb(68, 119, 206);

        }

        private void DisableButton()
        {
            foreach (Control PreviousButton in PanelMenu.Controls)
            {

                if (PreviousButton.GetType() != typeof(Button)) continue;

                PreviousButton.ForeColor = Color.FromArgb(140, 171, 255);
            }
        }

        private void btnIdeas_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormShowIdeas(), sender, "Ideas");
        }

        private void btnAddIdea_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormAddIdea(), sender, "Add Idea");
        }

        private void OpenChildForm(Form childForm, object btnSender, string Name)
        {
            if (activeForm != null) activeForm.Close();

            ActivateButton(btnSender);
            activeForm = childForm;
            activeForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            this.PanelDesktop.Controls.Add(childForm);
            this.PanelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = Name;
        }

        private void btnShowSubIdea_Click(object sender, EventArgs e)
        {

        }

        private void btnAddSubIdea_Click(object sender, EventArgs e)
        {

        }
    }
}
