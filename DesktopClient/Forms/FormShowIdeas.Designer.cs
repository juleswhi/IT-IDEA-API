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
            formAddIdeaBindingSource = new BindingSource(components);
            DataGridView = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            feasibilityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ideaBindingSource = new BindingSource(components);
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
            DataGridView.AutoGenerateColumns = false;
            DataGridView.BackgroundColor = Color.DarkGray;
            DataGridView.BorderStyle = BorderStyle.None;
            DataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            DataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, feasibilityDataGridViewTextBoxColumn });
            DataGridView.DataSource = ideaBindingSource;
            DataGridView.Dock = DockStyle.Fill;
            DataGridView.Location = new Point(0, 0);
            DataGridView.Name = "DataGridView";
            DataGridView.RowTemplate.Height = 25;
            DataGridView.Size = new Size(800, 450);
            DataGridView.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // feasibilityDataGridViewTextBoxColumn
            // 
            feasibilityDataGridViewTextBoxColumn.DataPropertyName = "Feasibility";
            feasibilityDataGridViewTextBoxColumn.HeaderText = "Feasibility";
            feasibilityDataGridViewTextBoxColumn.Name = "feasibilityDataGridViewTextBoxColumn";
            // 
            // ideaBindingSource
            // 
            ideaBindingSource.DataSource = typeof(Idea);
            // 
            // FormShowIdeas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DataGridView);
            Name = "FormShowIdeas";
            Text = "FormShowIdeas";
            ((System.ComponentModel.ISupportInitialize)formAddIdeaBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)ideaBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource formAddIdeaBindingSource;
        private DataGridView DataGridView;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn feasibilityDataGridViewTextBoxColumn;
        private BindingSource ideaBindingSource;
    }
}