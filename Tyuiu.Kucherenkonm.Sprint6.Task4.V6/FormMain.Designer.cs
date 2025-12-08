
namespace Tyuiu.Kucherenkonm.Sprint6.Task4.V6
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            groupBoxTask_KNM = new GroupBox();
            textBoxTask_KNM = new TextBox();
            groupBoxOutput_KNM = new GroupBox();
            textBoxResult_KNM = new TextBox();
            groupBoxInput_KNM = new GroupBox();
            textBoxStop_KNM = new TextBox();
            labelStop_KNM = new TextBox();
            textBoxStart_KNM = new TextBox();
            labelStart_KNM = new TextBox();
            chartFunction_KNM = new System.Windows.Forms.DataVisualization.Charting.Chart();
            buttonDone_KNM = new Button();
            buttonSave_KNM = new Button();
            buttonHelp_KNM = new Button();
            groupBoxTask_KNM.SuspendLayout();
            groupBoxOutput_KNM.SuspendLayout();
            groupBoxInput_KNM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_KNM).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_KNM
            // 
            groupBoxTask_KNM.Controls.Add(textBoxTask_KNM);
            groupBoxTask_KNM.Location = new Point(12, 12);
            groupBoxTask_KNM.Name = "groupBoxTask_KNM";
            groupBoxTask_KNM.Size = new Size(367, 133);
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
            textBoxTask_KNM.Size = new Size(361, 107);
            textBoxTask_KNM.TabIndex = 0;
            textBoxTask_KNM.Text = "Протабулировать функцию. Реультат вывести в textBox. Построить график функции и сохранить в файл по нажатию кнопки";
            // 
            // groupBoxOutput_KNM
            // 
            groupBoxOutput_KNM.Controls.Add(textBoxResult_KNM);
            groupBoxOutput_KNM.Location = new Point(12, 162);
            groupBoxOutput_KNM.Name = "groupBoxOutput_KNM";
            groupBoxOutput_KNM.Padding = new Padding(5);
            groupBoxOutput_KNM.Size = new Size(367, 428);
            groupBoxOutput_KNM.TabIndex = 1;
            groupBoxOutput_KNM.TabStop = false;
            groupBoxOutput_KNM.Text = "Вывод данных";
            // 
            // textBoxResult_KNM
            // 
            textBoxResult_KNM.Dock = DockStyle.Fill;
            textBoxResult_KNM.Location = new Point(5, 25);
            textBoxResult_KNM.Multiline = true;
            textBoxResult_KNM.Name = "textBoxResult_KNM";
            textBoxResult_KNM.ScrollBars = ScrollBars.Vertical;
            textBoxResult_KNM.Size = new Size(357, 398);
            textBoxResult_KNM.TabIndex = 0;
            // 
            // groupBoxInput_KNM
            // 
            groupBoxInput_KNM.Controls.Add(textBoxStop_KNM);
            groupBoxInput_KNM.Controls.Add(labelStop_KNM);
            groupBoxInput_KNM.Controls.Add(textBoxStart_KNM);
            groupBoxInput_KNM.Controls.Add(labelStart_KNM);
            groupBoxInput_KNM.Location = new Point(411, 12);
            groupBoxInput_KNM.Name = "groupBoxInput_KNM";
            groupBoxInput_KNM.Size = new Size(336, 133);
            groupBoxInput_KNM.TabIndex = 2;
            groupBoxInput_KNM.TabStop = false;
            groupBoxInput_KNM.Text = "Ввод данных";
            // 
            // textBoxStop_KNM
            // 
            textBoxStop_KNM.Location = new Point(185, 85);
            textBoxStop_KNM.Name = "textBoxStop_KNM";
            textBoxStop_KNM.Size = new Size(125, 27);
            textBoxStop_KNM.TabIndex = 3;
            // 
            // labelStop_KNM
            // 
            labelStop_KNM.Location = new Point(185, 41);
            labelStop_KNM.Name = "labelStop_KNM";
            labelStop_KNM.ReadOnly = true;
            labelStop_KNM.Size = new Size(125, 27);
            labelStop_KNM.TabIndex = 2;
            labelStop_KNM.Text = "Конец шага";
            // 
            // textBoxStart_KNM
            // 
            textBoxStart_KNM.Location = new Point(17, 85);
            textBoxStart_KNM.Name = "textBoxStart_KNM";
            textBoxStart_KNM.Size = new Size(125, 27);
            textBoxStart_KNM.TabIndex = 1;
            // 
            // labelStart_KNM
            // 
            labelStart_KNM.Location = new Point(17, 41);
            labelStart_KNM.Name = "labelStart_KNM";
            labelStart_KNM.ReadOnly = true;
            labelStart_KNM.Size = new Size(125, 27);
            labelStart_KNM.TabIndex = 0;
            labelStart_KNM.Text = "Старт шага";
            // 
            // chartFunction_KNM
            // 
            chartArea2.Name = "ChartArea1";
            chartFunction_KNM.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartFunction_KNM.Legends.Add(legend2);
            chartFunction_KNM.Location = new Point(411, 162);
            chartFunction_KNM.Name = "chartFunction_KNM";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartFunction_KNM.Series.Add(series2);
            chartFunction_KNM.Size = new Size(727, 419);
            chartFunction_KNM.TabIndex = 3;
            title2.Name = "Title1";
            title2.Text = "График функции";
            chartFunction_KNM.Titles.Add(title2);
            // 
            // buttonDone_KNM
            // 
            buttonDone_KNM.Location = new Point(773, 56);
            buttonDone_KNM.Name = "buttonDone_KNM";
            buttonDone_KNM.Size = new Size(110, 61);
            buttonDone_KNM.TabIndex = 4;
            buttonDone_KNM.Text = "Выполнить";
            buttonDone_KNM.UseVisualStyleBackColor = true;
            buttonDone_KNM.Click += buttonDone_KNM_Click;
            // 
            // buttonSave_KNM
            // 
            buttonSave_KNM.Location = new Point(902, 56);
            buttonSave_KNM.Name = "buttonSave_KNM";
            buttonSave_KNM.Size = new Size(111, 61);
            buttonSave_KNM.TabIndex = 5;
            buttonSave_KNM.Text = "Сохранить";
            buttonSave_KNM.UseVisualStyleBackColor = true;
            buttonSave_KNM.Click += buttonSave_KNM_Click;
            // 
            // buttonHelp_KNM
            // 
            buttonHelp_KNM.Location = new Point(1032, 56);
            buttonHelp_KNM.Name = "buttonHelp_KNM";
            buttonHelp_KNM.Size = new Size(106, 61);
            buttonHelp_KNM.TabIndex = 6;
            buttonHelp_KNM.Text = "Справка";
            buttonHelp_KNM.UseVisualStyleBackColor = true;
            buttonHelp_KNM.Click += buttonHelp_KNM_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 606);
            Controls.Add(buttonHelp_KNM);
            Controls.Add(buttonSave_KNM);
            Controls.Add(buttonDone_KNM);
            Controls.Add(chartFunction_KNM);
            Controls.Add(groupBoxInput_KNM);
            Controls.Add(groupBoxOutput_KNM);
            Controls.Add(groupBoxTask_KNM);
            MinimumSize = new Size(800, 450);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 4 | Вариант 6 | Кучеренко Н.М.";
            groupBoxTask_KNM.ResumeLayout(false);
            groupBoxTask_KNM.PerformLayout();
            groupBoxOutput_KNM.ResumeLayout(false);
            groupBoxOutput_KNM.PerformLayout();
            groupBoxInput_KNM.ResumeLayout(false);
            groupBoxInput_KNM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_KNM).EndInit();
            ResumeLayout(false);
        }
        #endregion

        private GroupBox groupBoxTask_KNM;
        private GroupBox groupBoxOutput_KNM;
        private GroupBox groupBoxInput_KNM;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_KNM;
        private Button buttonDone_KNM;
        private Button buttonSave_KNM;
        private Button buttonHelp_KNM;
        private TextBox textBoxTask_KNM;
        private TextBox textBoxResult_KNM;
        private TextBox textBoxStop_KNM;
        private TextBox labelStop_KNM;
        private TextBox textBoxStart_KNM;
        private TextBox labelStart_KNM;
    }
}
