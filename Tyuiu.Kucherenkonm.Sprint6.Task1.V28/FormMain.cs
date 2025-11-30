using Tyuiu.Kucherenkonm.Sprint6.Task1.V28.Lib;
namespace Tyuiu.Kucherenkonm.Sprint6.Task1.V28
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonResult_KNM_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStartValue_KNM.Text);
                int stopValue = Convert.ToInt32(textBoxStopValue_KNM.Text);

                string strLine;

                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startValue, stopValue);
                textBoxResult_KNM.Text = "";
                textBoxResult_KNM.AppendText("+--------+--------+" + Environment.NewLine);
                textBoxResult_KNM.AppendText("+     x     |    f(x)   +" + Environment.NewLine);
                textBoxResult_KNM.AppendText("+--------+--------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,6:d}     |  {1,6:f2}   | ", startValue, valueArray[i]);
                    textBoxResult_KNM.AppendText(strLine + Environment.NewLine);
                    startValue++;
                }
                textBoxResult_KNM.AppendText("+--------+--------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonHelp_KNM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнила студентка группы ИИПб-25-1 \n Кучеренко Надежда Михайловна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    
    }
}
