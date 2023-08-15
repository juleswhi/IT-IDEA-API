namespace IT_IDEA_DESKTOP.Forms
{
    partial class FormShowIdeas
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            formAddIdeaBindingSource = new BindingSource(components);
            DataGridView = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            feasibilityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            DGVbtnSubIdea = new DataGridViewButtonColumn();
            ideaBindingSource = new BindingSource(components);
            lblTest = new Label();
            ((System.ComponentModel.ISupportInitialize)formAddIdeaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ideaBindingSource).BeginInit();
            SuspendLayout();
            // 
            // formAddIdeaBindingSource
            // 
            formAddIdeaBindingSource.DataSource = typeof(FormAddIdea);
            // 
            // DataGridView
            // 
            DataGridView.AccessibleName = "Ideas";
            DataGridView.AllowUserToAddRows = false;
            DataGridView.AllowUserToDeleteRows = false;
            DataGridView.AutoGenerateColumns = false;
            DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DataGridView.BackgroundColor = Color.DarkGray;
            DataGridView.BorderStyle = BorderStyle.None;
            DataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            DataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.SeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, feasibilityDataGridViewTextBoxColumn, DGVbtnSubIdea });
            DataGridView.DataSource = ideaBindingSource;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.SeaGreen;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            DataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            DataGridView.Dock = DockStyle.Fill;
            DataGridView.Location = new Point(0, 0);
            DataGridView.Name = "DataGridView";
            DataGridView.ReadOnly = true;
            DataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            DataGridView.RowTemplate.Height = 25;
            DataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            DataGridView.Size = new Size(800, 450);
            DataGridView.TabIndex = 0;
            DataGridView.CellContentClick += DataGridView_CellContentClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 42;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            nameDataGridViewTextBoxColumn.Width = 64;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            descriptionDataGridViewTextBoxColumn.Width = 92;
            // 
            // feasibilityDataGridViewTextBoxColumn
            // 
            feasibilityDataGridViewTextBoxColumn.DataPropertyName = "Feasibility";
            feasibilityDataGridViewTextBoxColumn.HeaderText = "Feasibility";
            feasibilityDataGridViewTextBoxColumn.Name = "feasibilityDataGridViewTextBoxColumn";
            feasibilityDataGridViewTextBoxColumn.ReadOnly = true;
            feasibilityDataGridViewTextBoxColumn.Width = 84;
            // 
            // DGVbtnSubIdea
            // 
            DGVbtnSubIdea.HeaderText = "SubIdeas";
            DGVbtnSubIdea.Name = "DGVbtnSubIdea";
            DGVbtnSubIdea.ReadOnly = true;
            DGVbtnSubIdea.Width = 60;
            // 
            // ideaBindingSource
            // 
            ideaBindingSource.DataSource = typeof(Idea);
            // 
            // lblTest
            // 
            lblTest.AutoSize = true;
            lblTest.Location = new Point(649, 237);
            lblTest.Name = "lblTest";
            lblTest.Size = new Size(38, 15);
            lblTest.TabIndex = 1;
            lblTest.Text = "label1";
            // 
            // FormShowIdeas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTest);
            Controls.Add(DataGridView);
            Name = "FormShowIdeas";
            Text = "FormShowIdeas";
            ((System.ComponentModel.ISupportInitialize)formAddIdeaBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)ideaBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource formAddIdeaBindingSource;
        private DataGridView DataGridView;
        private BindingSource ideaBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn feasibilityDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn DGVbtnSubIdea;
        private Label lblTest;
    }
}