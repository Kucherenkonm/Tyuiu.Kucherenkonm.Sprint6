using Tyuiu.Kucherenkonm.Sprint6.Task7.V25.Lib;
namespace Tyuiu.Kucherenkonm.Sprint6.Task7.V25
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialog_KNM.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialog_KNM.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        static int rows;
        static int columns;
        static string openFilePath;

        DataService ds = new DataService();
        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            rows = lines.Length;
            columns = lines[0].Split(';').Length;
            int[,] arrayValues = new int[rows, columns];
            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }
        private void buttonOpenFile_KNM_Click(object sender, EventArgs e)
        {
            openFileDialog_KNM.ShowDialog();
            openFilePath = openFileDialog_KNM.FileName;

            int[,] arrayValues = new int[rows, columns];

            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewIn_KNM.ColumnCount = columns;
            dataGridViewIn_KNM.RowCount = rows;
            dataGridViewOut_KNM.ColumnCount = columns;
            dataGridViewOut_KNM.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewIn_KNM.Columns[i].Width = 40;
                dataGridViewOut_KNM.Columns[i].Width = 40;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewIn_KNM.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone_KNM.Enabled = true;
        }

        private void buttonSave_KNM_Click(object sender, EventArgs e)
        {
            saveFileDialog_KNM.FileName = "OutPutFileTask7V24.csv";
            saveFileDialog_KNM.InitialDirectory = Path.Combine(Path.GetTempPath());
            saveFileDialog_KNM.ShowDialog();

            string path = saveFileDialog_KNM.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOut_KNM.RowCount;
            int columns = dataGridViewOut_KNM.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOut_KNM.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOut_KNM.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonDone_KNM_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOut_KNM.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSave_KNM.Enabled = true;
        }

        private void buttonHelp_KNM_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewIn_KNM.ColumnCount = 50;
            dataGridViewOut_KNM.ColumnCount = 50;

            dataGridViewOut_KNM.RowCount = 50;
            dataGridViewIn_KNM.RowCount = 50;

            panelLeft_KNM.Width = this.Width / 2;

            for (int i = 0; i < 50; i++)
            {
                dataGridViewIn_KNM.Columns[i].Width = 25;
                dataGridViewOut_KNM.Columns[i].Width = 25;
            }
        }

        private void buttonOpenFile_KNM_MouseEnter(object sender, EventArgs e)
        {
            toolTip_KNM.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_KNM_MouseEnter(object sender, EventArgs e)
        {
            toolTip_KNM.ToolTipTitle = "Выполнить";
        }

        private void buttonSave_KNM_MouseEnter(object sender, EventArgs e)
        {
            toolTip_KNM.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonHelp_KNM_MouseEnter(object sender, EventArgs e)
        {
            toolTip_KNM.ToolTipTitle = "Справка";
        }
    }
}
