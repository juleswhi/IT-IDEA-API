using IT_IDEA_DESKTOP;
namespace IT_IDEA_DESKTOP.Forms
{
    public partial class FormShowIdeas : Form
    {
        public List<Idea> Ideas { get; set; }

        public FormShowIdeas()
        {
            Ideas = APIClient.GetIdeasAsync().Result;
            InitializeComponent();
            DataGridView.DataSource = Ideas;
        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                var row = senderGrid.Rows[1];
                lblTest.Text = DataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }
    }
}
