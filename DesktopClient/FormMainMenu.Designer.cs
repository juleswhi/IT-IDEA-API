namespace IT_IDEA_DESKTOP
{
    partial class FormMainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PanelMenu = new Panel();
            btnAddIdea = new Button();
            btnIdeas = new Button();
            PanelLogo = new Panel();
            PanelTitle = new Panel();
            lblTitle = new Label();
            PanelDesktop = new Panel();
            PanelMenu.SuspendLayout();
            PanelTitle.SuspendLayout();
            SuspendLayout();
            // 
            // PanelMenu
            // 
            PanelMenu.BackColor = Color.FromArgb(81, 43, 129);
            PanelMenu.Controls.Add(btnAddIdea);
            PanelMenu.Controls.Add(btnIdeas);
            PanelMenu.Controls.Add(PanelLogo);
            PanelMenu.Dock = DockStyle.Left;
            PanelMenu.Location = new Point(0, 0);
            PanelMenu.Name = "PanelMenu";
            PanelMenu.Size = new Size(169, 450);
            PanelMenu.TabIndex = 0;
            // 
            // btnAddIdea
            // 
            btnAddIdea.Dock = DockStyle.Top;
            btnAddIdea.FlatAppearance.BorderSize = 0;
            btnAddIdea.FlatStyle = FlatStyle.Flat;
            btnAddIdea.Font = new Font("Candara Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddIdea.ForeColor = Color.FromArgb(255, 246, 220);
            btnAddIdea.Location = new Point(0, 225);
            btnAddIdea.Name = "btnAddIdea";
            btnAddIdea.Size = new Size(169, 125);
            btnAddIdea.TabIndex = 2;
            btnAddIdea.Text = "Add Idea";
            btnAddIdea.UseVisualStyleBackColor = true;
            btnAddIdea.Click += btnAddIdea_Click;
            // 
            // btnIdeas
            // 
            btnIdeas.Dock = DockStyle.Top;
            btnIdeas.FlatAppearance.BorderSize = 0;
            btnIdeas.FlatStyle = FlatStyle.Flat;
            btnIdeas.Font = new Font("Candara Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnIdeas.ForeColor = Color.FromArgb(255, 246, 220);
            btnIdeas.Location = new Point(0, 75);
            btnIdeas.Name = "btnIdeas";
            btnIdeas.Size = new Size(169, 150);
            btnIdeas.TabIndex = 1;
            btnIdeas.Text = "View Ideas";
            btnIdeas.UseVisualStyleBackColor = true;
            btnIdeas.Click += btnIdeas_Click;
            // 
            // PanelLogo
            // 
            PanelLogo.BackColor = Color.FromArgb(53, 21, 93);
            PanelLogo.Dock = DockStyle.Top;
            PanelLogo.Location = new Point(0, 0);
            PanelLogo.Name = "PanelLogo";
            PanelLogo.Size = new Size(169, 75);
            PanelLogo.TabIndex = 0;
            // 
            // PanelTitle
            // 
            PanelTitle.BackColor = Color.FromArgb(81, 43, 129);
            PanelTitle.Controls.Add(lblTitle);
            PanelTitle.Dock = DockStyle.Top;
            PanelTitle.Location = new Point(169, 0);
            PanelTitle.Name = "PanelTitle";
            PanelTitle.Size = new Size(631, 75);
            PanelTitle.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Candara", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.FromArgb(255, 246, 220);
            lblTitle.Location = new Point(197, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(168, 39);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Main Menu";
            // 
            // PanelDesktop
            // 
            PanelDesktop.Dock = DockStyle.Fill;
            PanelDesktop.Location = new Point(169, 75);
            PanelDesktop.Name = "PanelDesktop";
            PanelDesktop.Size = new Size(631, 375);
            PanelDesktop.TabIndex = 2;
            // 
            // FormMainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PanelDesktop);
            Controls.Add(PanelTitle);
            Controls.Add(PanelMenu);
            Name = "FormMainMenu";
            Text = "FormMainMenu";
            PanelMenu.ResumeLayout(false);
            PanelTitle.ResumeLayout(false);
            PanelTitle.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelMenu;
        private Panel PanelLogo;
        private Button btnAddIdea;
        private Button btnIdeas;
        private Panel PanelTitle;
        private Label lblTitle;
        private Panel PanelDesktop;
    }
}