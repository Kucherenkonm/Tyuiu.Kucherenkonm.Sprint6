namespace Tyuiu.Kucherenkonm.Sprint6.Task5.V12
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxTask_KNM = new GroupBox();
            textBoxTask_KNM = new TextBox();
            groupBoxOutput_KNM = new GroupBox();
            dataGridViewResult_KNM = new DataGridView();
            chartFunction_KNM = new System.Windows.Forms.DataVisualization.Charting.Chart();
            buttonOpen_KNM = new Button();
            buttonHelp_KNM = new Button();
            buttonDone_KNM = new Button();
            groupBoxTask_KNM.SuspendLayout();
            groupBoxOutput_KNM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_KNM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction_KNM).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_KNM
            // 
            groupBoxTask_KNM.Controls.Add(textBoxTask_KNM);
            groupBoxTask_KNM.Location = new Point(12, 12);
            groupBoxTask_KNM.Name = "groupBoxTask_KNM";
            groupBoxTask_KNM.Size = new Size(745, 107);
            groupBoxTask_KNM.TabIndex = 0;
            groupBoxTask_KNM.TabStop = false;
            groupBoxTask_KNM.Text = "Условие";
            // 
            // textBoxTask_KNM
            // 
            textBoxTask_KNM.Dock = DockStyle.Fill;
            textBoxTask_KNM.Location = new Point(3, 23);
            textBoxTask_KNM.Multiline = true;
            textBoxTask_KNM.Name = "textBoxTask_KNM";
            textBoxTask_KNM.ReadOnly = true;
            textBoxTask_KNM.Size = new Size(739, 81);
            textBoxTask_KNM.TabIndex = 0;
            textBoxTask_KNM.Text = "Прочитать данные из файла. Вывести значение, не кратные 5. Построить диаграмму по этим значениям";
            // 
            // groupBoxOutput_KNM
            // 
            groupBoxOutput_KNM.Controls.Add(dataGridViewResult_KNM);
            groupBoxOutput_KNM.Location = new Point(15, 117);
            groupBoxOutput_KNM.Name = "groupBoxOutput_KNM";
            groupBoxOutput_KNM.Size = new Size(425, 433);
            groupBoxOutput_KNM.TabIndex = 1;
            groupBoxOutput_KNM.TabStop = false;
            groupBoxOutput_KNM.Text = "Вывод данных";
            // 
            // dataGridViewResult_KNM
            // 
            dataGridViewResult_KNM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_KNM.Dock = DockStyle.Fill;
            dataGridViewResult_KNM.Location = new Point(3, 23);
            dataGridViewResult_KNM.Name = "dataGridViewResult_KNM";
            dataGridViewResult_KNM.RowHeadersWidth = 51;
            dataGridViewResult_KNM.ScrollBars = ScrollBars.Vertical;
            dataGridViewResult_KNM.Size = new Size(419, 407);
            dataGridViewResult_KNM.TabIndex = 0;
            // 
            // chartFunction_KNM
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_KNM.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction_KNM.Legends.Add(legend1);
            chartFunction_KNM.Location = new Point(463, 125);
            chartFunction_KNM.Name = "chartFunction_KNM";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_KNM.Series.Add(series1);
            chartFunction_KNM.Size = new Size(719, 425);
            chartFunction_KNM.TabIndex = 2;
            chartFunction_KNM.Text = "chart1";
            // 
            // buttonOpen_KNM
            // 
            buttonOpen_KNM.Location = new Point(923, 36);
            buttonOpen_KNM.Name = "buttonOpen_KNM";
            buttonOpen_KNM.Size = new Size(120, 63);
            buttonOpen_KNM.TabIndex = 3;
            buttonOpen_KNM.Text = "Открыть файл";
            buttonOpen_KNM.UseVisualStyleBackColor = true;
            buttonOpen_KNM.Click += buttonOpen_KNM_Click;
            // 
            // buttonHelp_KNM
            // 
            buttonHelp_KNM.Location = new Point(1062, 36);
            buttonHelp_KNM.Name = "buttonHelp_KNM";
            buttonHelp_KNM.Size = new Size(120, 63);
            buttonHelp_KNM.TabIndex = 4;
            buttonHelp_KNM.Text = "Справка";
            buttonHelp_KNM.UseVisualStyleBackColor = true;
            buttonHelp_KNM.Click += buttonHelp_KNM_Click;
            // 
            // buttonDone_KNM
            // 
            buttonDone_KNM.Location = new Point(776, 36);
            buttonDone_KNM.Name = "buttonDone_KNM";
            buttonDone_KNM.Size = new Size(120, 63);
            buttonDone_KNM.TabIndex = 5;
            buttonDone_KNM.Text = "Выполнить";
            buttonDone_KNM.UseVisualStyleBackColor = true;
            buttonDone_KNM.Click += buttonDone_KNM_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1218, 562);
            Controls.Add(buttonDone_KNM);
            Controls.Add(buttonHelp_KNM);
            Controls.Add(buttonOpen_KNM);
            Controls.Add(chartFunction_KNM);
            Controls.Add(groupBoxOutput_KNM);
            Controls.Add(groupBoxTask_KNM);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 5 | Вариант 12 | Кучеренко Н.М.";
            groupBoxTask_KNM.ResumeLayout(false);
            groupBoxTask_KNM.PerformLayout();
            groupBoxOutput_KNM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_KNM).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction_KNM).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_KNM;
        private TextBox textBoxTask_KNM;
        private GroupBox groupBoxOutput_KNM;
        private DataGridView dataGridViewResult_KNM;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_KNM;
        private Button buttonOpen_KNM;
        private Button buttonHelp_KNM;
        private Button buttonDone_KNM;
    }
}
