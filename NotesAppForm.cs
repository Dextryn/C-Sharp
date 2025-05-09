using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;


namespace NotesApp
{
    public partial class Form1 : Form
    {
        DataTable table;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("Title", typeof(string));
            table.Columns.Add("Messages", typeof(string));

            dataGridView1.DataSource = table;

            dataGridView1.Columns["Messages"].Visible = false;
            dataGridView1.Columns["Title"].Width = 245;
        }

        private void ButtonNew_Click(object sender, EventArgs e)
        {
            TextTitle.Clear();
            TextMessage.Clear();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            table.Rows.Add(TextTitle.Text, TextMessage.Text);
            TextTitle.Clear();
            TextMessage.Clear();
        }

        private void ButtonRead_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            if (index > -1)
            {
                TextTitle.Text = table.Rows[index].ItemArray[0].ToString();
                TextMessage.Text = table.Rows[index].ItemArray[1].ToString();
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            table.Rows[index].Delete();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
