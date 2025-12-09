using System.Data;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.Kucherenkonm.Sprint6.Task7.V25.Lib
{
    public class DataService : ISprint6Task7V25
    {
        public int[,] GetMatrix(string path)
        {
            string[] lines = File.ReadAllText(path).Split("\n");
            int rows = File.ReadLines(path).Count();
            int columns = lines[0].Split(";").Length;
            int[,] matrix = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] intLines = lines[i].Split(";");
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = Convert.ToInt32(intLines[j]);
                }
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, 6] % 5 == 0) matrix[i, 6] = 2;
            }
            return matrix;
        }
    }
}
