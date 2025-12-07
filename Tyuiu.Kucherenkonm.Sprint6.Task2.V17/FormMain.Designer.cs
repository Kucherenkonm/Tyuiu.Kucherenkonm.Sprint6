namespace Tyuiu.Kucherenkonm.Sprint6.Task2.V17
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
            groupBoxInput_KNM = new GroupBox();
            textBoxStop_KNM = new TextBox();
            labelStop_KNM = new TextBox();
            textBoxStart_KNM = new TextBox();
            labelStart_KNM = new TextBox();
            groupBoxOutput_KNM = new GroupBox();
            chartFunction_KNM = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewFunction_KNM = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            Function = new DataGridViewTextBoxColumn();
            labelResult_KNM = new TextBox();
            buttonHelp_KNM = new Button();
            buttonDone_KNM = new Button();
            groupBoxTask_KNM.SuspendLayout();
            groupBoxInput_KNM.SuspendLayout();
            groupBoxOutput_KNM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_KNM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_KNM).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_KNM
            // 
            groupBoxTask_KNM.Controls.Add(textBoxTask_KNM);
            groupBoxTask_KNM.Location = new Point(14, 24);
            groupBoxTask_KNM.Name = "groupBoxTask_KNM";
            groupBoxTask_KNM.Size = new Size(406, 209);
            groupBoxTask_KNM.TabIndex = 0;
            groupBoxTask_KNM.TabStop = false;
            groupBoxTask_KNM.Text = "Условие";
            // 
            // textBoxTask_KNM
            // 
            textBoxTask_KNM.Location = new Point(15, 26);
            textBoxTask_KNM.Multiline = true;
            textBoxTask_KNM.Name = "textBoxTask_KNM";
            textBoxTask_KNM.ReadOnly = true;
            textBoxTask_KNM.Size = new Size(369, 163);
            textBoxTask_KNM.TabIndex = 0;
            textBoxTask_KNM.Text = "Протабулировать функцию.\r\nРезультат вывести и построить график функции\r\n";
            // 
            // groupBoxInput_KNM
            // 
            groupBoxInput_KNM.Controls.Add(textBoxStop_KNM);
            groupBoxInput_KNM.Controls.Add(labelStop_KNM);
            groupBoxInput_KNM.Controls.Add(textBoxStart_KNM);
            groupBoxInput_KNM.Controls.Add(labelStart_KNM);
            groupBoxInput_KNM.Location = new Point(14, 239);
            groupBoxInput_KNM.Name = "groupBoxInput_KNM";
            groupBoxInput_KNM.Size = new Size(305, 199);
            groupBoxInput_KNM.TabIndex = 1;
            groupBoxInput_KNM.TabStop = false;
            groupBoxInput_KNM.Text = "Ввод данных";
            // 
            // textBoxStop_KNM
            // 
            textBoxStop_KNM.Location = new Point(159, 121);
            textBoxStop_KNM.Name = "textBoxStop_KNM";
            textBoxStop_KNM.Size = new Size(125, 27);
            textBoxStop_KNM.TabIndex = 3;
            // 
            // labelStop_KNM
            // 
            labelStop_KNM.Location = new Point(159, 76);
            labelStop_KNM.Name = "labelStop_KNM";
            labelStop_KNM.ReadOnly = true;
            labelStop_KNM.Size = new Size(125, 27);
            labelStop_KNM.TabIndex = 2;
            labelStop_KNM.Text = "Конец шага";
            // 
            // textBoxStart_KNM
            // 
            textBoxStart_KNM.Location = new Point(15, 121);
            textBoxStart_KNM.Name = "textBoxStart_KNM";
            textBoxStart_KNM.Size = new Size(125, 27);
            textBoxStart_KNM.TabIndex = 1;
            // 
            // labelStart_KNM
            // 
            labelStart_KNM.Location = new Point(15, 76);
            labelStart_KNM.Name = "labelStart_KNM";
            labelStart_KNM.ReadOnly = true;
            labelStart_KNM.Size = new Size(125, 27);
            labelStart_KNM.TabIndex = 0;
            labelStart_KNM.Text = "Старт шага";
            // 
            // groupBoxOutput_KNM
            // 
            groupBoxOutput_KNM.Controls.Add(chartFunction_KNM);
            groupBoxOutput_KNM.Controls.Add(dataGridViewFunction_KNM);
            groupBoxOutput_KNM.Controls.Add(labelResult_KNM);
            groupBoxOutput_KNM.Location = new Point(438, 24);
            groupBoxOutput_KNM.Name = "groupBoxOutput_KNM";
            groupBoxOutput_KNM.Size = new Size(783, 414);
            groupBoxOutput_KNM.TabIndex = 2;
            groupBoxOutput_KNM.TabStop = false;
            groupBoxOutput_KNM.Text = "Вывод данных";
            // 
            // chartFunction_KNM
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_KNM.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction_KNM.Legends.Add(legend1);
            chartFunction_KNM.Location = new Point(278, 59);
            chartFunction_KNM.Name = "chartFunction_KNM";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_KNM.Series.Add(series1);
            chartFunction_KNM.Size = new Size(474, 330);
            chartFunction_KNM.TabIndex = 2;
            chartFunction_KNM.Text = "chart1";
            // 
            // dataGridViewFunction_KNM
            // 
            dataGridViewFunction_KNM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction_KNM.Columns.AddRange(new DataGridViewColumn[] { X, Function });
            dataGridViewFunction_KNM.Location = new Point(19, 59);
            dataGridViewFunction_KNM.Name = "dataGridViewFunction_KNM";
            dataGridViewFunction_KNM.RowHeadersVisible = false;
            dataGridViewFunction_KNM.RowHeadersWidth = 51;
            dataGridViewFunction_KNM.Size = new Size(253, 330);
            dataGridViewFunction_KNM.TabIndex = 1;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.MinimumWidth = 6;
            X.Name = "X";
            X.Width = 125;
            // 
            // Function
            // 
            Function.HeaderText = "F(x)";
            Function.MinimumWidth = 6;
            Function.Name = "Function";
            Function.Width = 125;
            // 
            // labelResult_KNM
            // 
            labelResult_KNM.Location = new Point(19, 26);
            labelResult_KNM.Name = "labelResult_KNM";
            labelResult_KNM.ReadOnly = true;
            labelResult_KNM.Size = new Size(125, 27);
            labelResult_KNM.TabIndex = 0;
            labelResult_KNM.Text = "Результат";
            // 
            // buttonHelp_KNM
            // 
            buttonHelp_KNM.Location = new Point(326, 267);
            buttonHelp_KNM.Name = "buttonHelp_KNM";
            buttonHelp_KNM.Size = new Size(106, 66);
            buttonHelp_KNM.TabIndex = 3;
            buttonHelp_KNM.Text = "Справка";
            buttonHelp_KNM.UseVisualStyleBackColor = true;
            buttonHelp_KNM.Click += buttonHelp_KNM_Click;
            // 
            // buttonDone_KNM
            // 
            buttonDone_KNM.Location = new Point(325, 350);
            buttonDone_KNM.Name = "buttonDone_KNM";
            buttonDone_KNM.Size = new Size(107, 63);
            buttonDone_KNM.TabIndex = 4;
            buttonDone_KNM.Text = "Выполнить";
            buttonDone_KNM.UseVisualStyleBackColor = true;
            buttonDone_KNM.Click += buttonDone_KNM_Click;
            buttonDone_KNM.MouseDown += buttonDone_KNM_MouseDown;
            buttonDone_KNM.MouseEnter += buttonDone_KNM_MouseEnter;
            buttonDone_KNM.MouseLeave += buttonDone_KNM_Leave;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1244, 450);
            Controls.Add(buttonDone_KNM);
            Controls.Add(buttonHelp_KNM);
            Controls.Add(groupBoxOutput_KNM);
            Controls.Add(groupBoxInput_KNM);
            Controls.Add(groupBoxTask_KNM);
            MaximizeBox = false;
            Name = "FormMain";
            Text = "Спринт 6 | Таск 2 | Вариант 17 | Кучеренко Н.М.";
            groupBoxTask_KNM.ResumeLayout(false);
            groupBoxTask_KNM.PerformLayout();
            groupBoxInput_KNM.ResumeLayout(false);
            groupBoxInput_KNM.PerformLayout();
            groupBoxOutput_KNM.ResumeLayout(false);
            groupBoxOutput_KNM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_KNM).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_KNM).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_KNM;
        private TextBox textBoxTask_KNM;
        private GroupBox groupBoxInput_KNM;
        private TextBox textBoxStop_KNM;
        private TextBox labelStop_KNM;
        private TextBox textBoxStart_KNM;
        private TextBox labelStart_KNM;
        private GroupBox groupBoxOutput_KNM;
        private Button buttonHelp_KNM;
        private Button buttonDone_KNM;
        private DataGridView dataGridViewFunction_KNM;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn Function;
        private TextBox labelResult_KNM;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_KNM;
    }
}
