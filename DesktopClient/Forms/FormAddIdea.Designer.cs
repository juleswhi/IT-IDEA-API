namespace IT_IDEA_DESKTOP.Forms
{
    partial class FormAddIdea
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
            txtBoxName = new TextBox();
            lblName = new Label();
            label1 = new Label();
            txtBoxFeasibility = new TextBox();
            label2 = new Label();
            txtBoxDescription = new TextBox();
            btnCreateIdea = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // txtBoxName
            // 
            txtBoxName.Location = new Point(177, 27);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(112, 23);
            txtBoxName.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.ForeColor = Color.FromArgb(255, 246, 220);
            lblName.Location = new Point(85, 27);
            lblName.Name = "lblName";
            lblName.Size = new Size(69, 26);
            lblName.TabIndex = 1;
            lblName.Text = "Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 246, 220);
            label1.Location = new Point(15, 71);
            label1.Name = "label1";
            label1.Size = new Size(139, 26);
            label1.TabIndex = 3;
            label1.Text = "Feasibility X/5:";
            // 
            // txtBoxFeasibility
            // 
            txtBoxFeasibility.Location = new Point(177, 74);
            txtBoxFeasibility.Name = "txtBoxFeasibility";
            txtBoxFeasibility.Size = new Size(112, 23);
            txtBoxFeasibility.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(255, 246, 220);
            label2.Location = new Point(39, 120);
            label2.Name = "label2";
            label2.Size = new Size(115, 26);
            label2.TabIndex = 5;
            label2.Text = "Description:";
            // 
            // txtBoxDescription
            // 
            txtBoxDescription.Location = new Point(177, 125);
            txtBoxDescription.Name = "txtBoxDescription";
            txtBoxDescription.Size = new Size(584, 23);
            txtBoxDescription.TabIndex = 4;
            // 
            // btnCreateIdea
            // 
            btnCreateIdea.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreateIdea.Location = new Point(350, 272);
            btnCreateIdea.Name = "btnCreateIdea";
            btnCreateIdea.Size = new Size(114, 55);
            btnCreateIdea.TabIndex = 6;
            btnCreateIdea.Text = "Create!";
            btnCreateIdea.UseVisualStyleBackColor = true;
            btnCreateIdea.Click += btnCreateIdea_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblResult.ForeColor = Color.FromArgb(255, 246, 220);
            lblResult.Location = new Point(365, 330);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 26);
            lblResult.TabIndex = 7;
            // 
            // FormAddIdea
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(81, 43, 129);
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(btnCreateIdea);
            Controls.Add(label2);
            Controls.Add(txtBoxDescription);
            Controls.Add(label1);
            Controls.Add(txtBoxFeasibility);
            Controls.Add(lblName);
            Controls.Add(txtBoxName);
            Name = "FormAddIdea";
            Text = ":q";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxName;
        private Label lblName;
        private Label label1;
        private TextBox txtBoxFeasibility;
        private Label label2;
        private TextBox txtBoxDescription;
        private Button btnCreateIdea;
        private Label lblResult;
    }
}