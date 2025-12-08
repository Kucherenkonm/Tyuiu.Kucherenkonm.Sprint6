using Tyuiu.Kucherenkonm.Sprint6.Task6.V23.Lib;
namespace Tyuiu.Kucherenkonm.Sprint6.Task6.V23
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();
        private void buttonOpenFile_KNM_Click(object sender, EventArgs e)
        {
            openFileDialog_KNM.ShowDialog();
            openFilePath = openFileDialog_KNM.FileName;
            textBoxIn_KNM.Text = File.ReadAllText(openFilePath);
            groupBoxIn_KNM.Text = groupBoxIn_KNM.Text + " " + openFileDialog_KNM.FileName;
            buttonDone_KNM.Enabled = true;
        }

        private void buttonDone_KNM_Click(object sender, EventArgs e)
        {
            textBoxOut_KNM.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonHelp_KNM_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
