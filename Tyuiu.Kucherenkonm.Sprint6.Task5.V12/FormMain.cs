using Tyuiu.Kucherenkonm.Sprint6.Task5.V12.Lib;
namespace Tyuiu.Kucherenkonm.Sprint6.Task5.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\DataSprint6\InPutDataFileTask5V12.txt";
        private void buttonDone_KNM_Click(object sender, EventArgs e)
        {
            dataGridViewResult_KNM.ColumnCount = 2;
            dataGridViewResult_KNM.Columns[0].Width = 20;
            dataGridViewResult_KNM.Columns[1].Width = 50;

            this.chartFunction_KNM.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartFunction_KNM.ChartAreas[0].AxisY.Title = "Ось Y";

            chartFunction_KNM.Series[0].Points.Clear();

            double[] numMass = new double[ds.len];

            numMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numMass.Length; i++)
            {
                dataGridViewResult_KNM.Rows.Add(Convert.ToString(i), Convert.ToString(numMass[i]));
                chartFunction_KNM.Series[0].Points.AddXY(i, numMass[i]);
            }
        }

        private void buttonOpen_KNM_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_KNM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнила студентка группы ИИПб-25-1 \n Кучеренко Надежда Михайловна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
