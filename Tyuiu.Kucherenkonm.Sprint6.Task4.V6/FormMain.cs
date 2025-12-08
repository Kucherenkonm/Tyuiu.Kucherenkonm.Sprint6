using Tyuiu.Kucherenkonm.Sprint6.Task4.V6.Lib;
using static System.Net.Mime.MediaTypeNames;
namespace Tyuiu.Kucherenkonm.Sprint6.Task4.V6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDone_KNM_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_KNM.Text);
                int stopStep = Convert.ToInt32(textBoxStop_KNM.Text);
                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                this.chartFunction_KNM.ChartAreas[0].AxisX.Title = "Ось Х";
                this.chartFunction_KNM.ChartAreas[0].AxisY.Title = "Ось Y";
                textBoxResult_KNM.Text = "";
                chartFunction_KNM.Series[0].Points.Clear();
                for (int i = 0; i < len; i++)
                {
                    this.chartFunction_KNM.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxResult_KNM.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonSave_KNM_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask4V6.txt");
                File.WriteAllText(path, textBoxResult_KNM.Text);
                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранен успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_KNM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнила студентка группы ИИПб-25-1 \n Кучеренко Надежда Михайловна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
