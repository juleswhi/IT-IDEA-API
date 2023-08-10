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

    }
}
