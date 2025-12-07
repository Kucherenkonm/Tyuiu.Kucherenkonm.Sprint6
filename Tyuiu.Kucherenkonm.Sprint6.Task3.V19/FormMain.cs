using System.Drawing.Drawing2D;
using System.Threading;
using Tyuiu.Kucherenkonm.Sprint6.Task3.V19.Lib;
namespace Tyuiu.Kucherenkonm.Sprint6.Task3.V19
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] mtrx = new int[5, 5] { {4,  32, -20,  27,  21},
                                      {17, 15, -1, -2, -1},
                                      {-3, 18, 12, -10, 29},
                                      {7, -15, 2, -8, 12},
                                      {-10, 25, 5, 27, 21}};
        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.GetUpperBound(1) + 1;

            dataGridViewMatrix_KNM.ColumnCount = columns;
            dataGridViewMatrix_KNM.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_KNM.Columns[i].Width = 35;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_KNM.Rows[i].Cells[j].Value = mtrx[i, j];
                }
            }
        }

        private void buttonDone_KNM_Click(object sender, EventArgs e)
        {
            int[,] res = ds.Calculate(mtrx);
            int row = res.GetUpperBound(0) + 1;
            int column = res.GetUpperBound(1) + 1;
            dataGridViewResult_KNM.ColumnCount = column;
            dataGridViewResult_KNM.RowCount = row;
            for (int i = 0; i < column; i++)
            {
                dataGridViewResult_KNM.Columns[i].Width = 35;
            }
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    dataGridViewResult_KNM.Rows[i].Cells[j].Value = res[i, j];
                }
            }
        }

        private void buttonHelp_KNM_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Таск 3 выполнила студентка группы ИИПб-25-1 \n Кучеренко Надежда Михайловна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
