using Tyuiu.Kucherenkonm.Sprint6.Task2.V17.Lib;
namespace Tyuiu.Kucherenkonm.Sprint6.Task2.V17
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

                this.chartFunction_KNM.Titles.Add("График функции");
                this.chartFunction_KNM.ChartAreas[0].AxisX.Title = "Ось Х";
                this.chartFunction_KNM.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i < len; i++)
                {
                    this.dataGridViewFunction_KNM.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartFunction_KNM.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_KNM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнила студентка группы ИИПб-25-1 \n Кучеренко Надежда Михайловна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_KNM_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_KNM.BackColor = Color.Red;
        }

        private void buttonDone_KNM_Leave(object sender, EventArgs e)
        {
            buttonDone_KNM.BackColor = Color.Green;
        }

        private void buttonDone_KNM_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_KNM.BackColor = Color.Blue;
        }
    }
}
