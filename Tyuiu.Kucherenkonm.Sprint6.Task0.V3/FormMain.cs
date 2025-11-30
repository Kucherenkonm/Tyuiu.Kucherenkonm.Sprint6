using Tyuiu.Kucherenkonm.Sprint6.Task0.V3.Lib;
namespace Tyuiu.Kucherenkonm.Sprint6.Task0.V3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_KNM_Click_3(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_KNM.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX_KNM.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxVarX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonHelp_KNM_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Таск 0 выполнила студентка группы ИИПб-25-1 Кучеренко Надежда Михайловна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void pictureBoxFormula_KNM_Click(object sender, EventArgs e)
        {

        }
    }
}
