using E2BWordBank;

namespace E2BDictionary
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        List<Word> wordList = WordRepository.GetAllWords();
        private void frmMain_Load(object sender, EventArgs e) 
        {
            try
            {
                wordGridView.Rows.Clear();
                wordGridView.AutoGenerateColumns = false;
                wordGridView.DataSource = wordList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void findWordTextBox_TextChanged(object sender, EventArgs e) 
        {
            try
            {
                string searchValue = findWordTextBox.Text;
                if(searchValue.Trim() == string.Empty)
                {
                    wordGridView.DataSource = null;
                    wordGridView.Rows.Clear();
                    wordGridView.DataSource = wordList;
                }
                else
                {
                    int rowIndex = 0;
                    wordGridView.ClearSelection();
                    var words =(List<Word>) wordGridView.DataSource;
                    var word = words.FirstOrDefault(c => c.En.ToLower().StartsWith(searchValue.ToLower()));
                    if(word != null)
                    {
                        rowIndex = words.IndexOf(word);
                        wordGridView.Rows[rowIndex].Selected = true;
                        wordGridView.FirstDisplayedScrollingRowIndex = rowIndex;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
