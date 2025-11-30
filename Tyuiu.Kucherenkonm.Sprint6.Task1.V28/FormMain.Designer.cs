namespace Tyuiu.Kucherenkonm.Sprint6.Task1.V28
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
            groupBoxCondition_KNM = new GroupBox();
            textBoxTask = new TextBox();
            groupBoxInput_KNM = new GroupBox();
            textBoxStopValue_KNM = new TextBox();
            labelStopValue_KNM = new TextBox();
            textBoxStartValue_KNM = new TextBox();
            labelStartValue_KNM = new TextBox();
            groupBoxOutput_KNM = new GroupBox();
            textBoxResult_KNM = new TextBox();
            labelResult_KNM = new TextBox();
            buttonHelp_KNM = new Button();
            buttonResult_KNM = new Button();
            groupBoxCondition_KNM.SuspendLayout();
            groupBoxInput_KNM.SuspendLayout();
            groupBoxOutput_KNM.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCondition_KNM
            // 
            groupBoxCondition_KNM.Controls.Add(textBoxTask);
            groupBoxCondition_KNM.Location = new Point(43, 37);
            groupBoxCondition_KNM.Name = "groupBoxCondition_KNM";
            groupBoxCondition_KNM.Size = new Size(337, 175);
            groupBoxCondition_KNM.TabIndex = 0;
            groupBoxCondition_KNM.TabStop = false;
            groupBoxCondition_KNM.Text = "Условие";
            // 
            // textBoxTask
            // 
            textBoxTask.BackColor = SystemColors.MenuBar;
            textBoxTask.Font = new Font("Segoe UI", 10F);
            textBoxTask.Location = new Point(24, 34);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(287, 122);
            textBoxTask.TabIndex = 0;
            textBoxTask.Text = "Протабулировать функцию:\r\ncos(x)+4x/2-sin(x)*3x\r\nна заданном диапазоне.\r\nРезультат вывести в виде таблицы.\r\n";
            // 
            // groupBoxInput_KNM
            // 
            groupBoxInput_KNM.Controls.Add(textBoxStopValue_KNM);
            groupBoxInput_KNM.Controls.Add(labelStopValue_KNM);
            groupBoxInput_KNM.Controls.Add(textBoxStartValue_KNM);
            groupBoxInput_KNM.Controls.Add(labelStartValue_KNM);
            groupBoxInput_KNM.Location = new Point(43, 218);
            groupBoxInput_KNM.Name = "groupBoxInput_KNM";
            groupBoxInput_KNM.Size = new Size(339, 128);
            groupBoxInput_KNM.TabIndex = 1;
            groupBoxInput_KNM.TabStop = false;
            groupBoxInput_KNM.Text = "Ввод данных";
            // 
            // textBoxStopValue_KNM
            // 
            textBoxStopValue_KNM.Location = new Point(164, 64);
            textBoxStopValue_KNM.Name = "textBoxStopValue_KNM";
            textBoxStopValue_KNM.Size = new Size(125, 27);
            textBoxStopValue_KNM.TabIndex = 3;
            // 
            // labelStopValue_KNM
            // 
            labelStopValue_KNM.BackColor = SystemColors.MenuBar;
            labelStopValue_KNM.Location = new Point(164, 31);
            labelStopValue_KNM.Name = "labelStopValue_KNM";
            labelStopValue_KNM.ReadOnly = true;
            labelStopValue_KNM.Size = new Size(125, 27);
            labelStopValue_KNM.TabIndex = 2;
            labelStopValue_KNM.Text = "Конец шага:";
            // 
            // textBoxStartValue_KNM
            // 
            textBoxStartValue_KNM.Location = new Point(19, 64);
            textBoxStartValue_KNM.Name = "textBoxStartValue_KNM";
            textBoxStartValue_KNM.Size = new Size(125, 27);
            textBoxStartValue_KNM.TabIndex = 1;
            // 
            // labelStartValue_KNM
            // 
            labelStartValue_KNM.BackColor = SystemColors.MenuBar;
            labelStartValue_KNM.Location = new Point(19, 31);
            labelStartValue_KNM.Name = "labelStartValue_KNM";
            labelStartValue_KNM.ReadOnly = true;
            labelStartValue_KNM.Size = new Size(125, 27);
            labelStartValue_KNM.TabIndex = 0;
            labelStartValue_KNM.Text = "Старт шага:";
            // 
            // groupBoxOutput_KNM
            // 
            groupBoxOutput_KNM.Controls.Add(textBoxResult_KNM);
            groupBoxOutput_KNM.Controls.Add(labelResult_KNM);
            groupBoxOutput_KNM.Location = new Point(411, 37);
            groupBoxOutput_KNM.Name = "groupBoxOutput_KNM";
            groupBoxOutput_KNM.Size = new Size(354, 380);
            groupBoxOutput_KNM.TabIndex = 2;
            groupBoxOutput_KNM.TabStop = false;
            groupBoxOutput_KNM.Text = "Вывод данных";
            // 
            // textBoxResult_KNM
            // 
            textBoxResult_KNM.BackColor = SystemColors.Window;
            textBoxResult_KNM.Location = new Point(22, 69);
            textBoxResult_KNM.Multiline = true;
            textBoxResult_KNM.Name = "textBoxResult_KNM";
            textBoxResult_KNM.ReadOnly = true;
            textBoxResult_KNM.ScrollBars = ScrollBars.Vertical;
            textBoxResult_KNM.Size = new Size(309, 305);
            textBoxResult_KNM.TabIndex = 1;
            // 
            // labelResult_KNM
            // 
            labelResult_KNM.BackColor = SystemColors.Menu;
            labelResult_KNM.Location = new Point(22, 26);
            labelResult_KNM.Name = "labelResult_KNM";
            labelResult_KNM.ReadOnly = true;
            labelResult_KNM.Size = new Size(125, 27);
            labelResult_KNM.TabIndex = 0;
            labelResult_KNM.Text = "Результат";
            // 
            // buttonHelp_KNM
            // 
            buttonHelp_KNM.BackColor = SystemColors.Info;
            buttonHelp_KNM.Location = new Point(43, 358);
            buttonHelp_KNM.Name = "buttonHelp_KNM";
            buttonHelp_KNM.Size = new Size(161, 65);
            buttonHelp_KNM.TabIndex = 3;
            buttonHelp_KNM.Text = "Справка";
            buttonHelp_KNM.UseVisualStyleBackColor = false;
            buttonHelp_KNM.Click += buttonHelp_KNM_Click;
            // 
            // buttonResult_KNM
            // 
            buttonResult_KNM.BackColor = SystemColors.ActiveCaption;
            buttonResult_KNM.Location = new Point(219, 358);
            buttonResult_KNM.Name = "buttonResult_KNM";
            buttonResult_KNM.Size = new Size(161, 66);
            buttonResult_KNM.TabIndex = 4;
            buttonResult_KNM.Text = "Выполнить";
            buttonResult_KNM.UseVisualStyleBackColor = false;
            buttonResult_KNM.Click += buttonResult_KNM_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonResult_KNM);
            Controls.Add(buttonHelp_KNM);
            Controls.Add(groupBoxOutput_KNM);
            Controls.Add(groupBoxInput_KNM);
            Controls.Add(groupBoxCondition_KNM);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 1 |  Вариант 28 | Кучеренко Н.М.";
            groupBoxCondition_KNM.ResumeLayout(false);
            groupBoxCondition_KNM.PerformLayout();
            groupBoxInput_KNM.ResumeLayout(false);
            groupBoxInput_KNM.PerformLayout();
            groupBoxOutput_KNM.ResumeLayout(false);
            groupBoxOutput_KNM.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_KNM;
        private TextBox textBoxTask;
        private GroupBox groupBoxInput_KNM;
        private TextBox textBoxStartValue_KNM;
        private TextBox labelStartValue_KNM;
        private GroupBox groupBoxOutput_KNM;
        private TextBox textBoxStopValue_KNM;
        private TextBox labelStopValue_KNM;
        private TextBox labelResult_KNM;
        private Button buttonHelp_KNM;
        private Button buttonResult_KNM;
        private TextBox textBoxResult_KNM;
    }
}
