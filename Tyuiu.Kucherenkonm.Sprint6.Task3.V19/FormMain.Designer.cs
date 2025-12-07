
namespace Tyuiu.Kucherenkonm.Sprint6.Task3.V19
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
            groupBoxTask_KNM = new GroupBox();
            dataGridViewMatrix_KNM = new DataGridView();
            textBoxTask_KNM = new TextBox();
            groupBoxOutput_KNM = new GroupBox();
            dataGridViewResult_KNM = new DataGridView();
            labelResult_KNM = new TextBox();
            buttonHelp_KNM = new Button();
            buttonDone_KNM = new Button();
            groupBoxTask_KNM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_KNM).BeginInit();
            groupBoxOutput_KNM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_KNM).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_KNM
            // 
            groupBoxTask_KNM.Controls.Add(dataGridViewMatrix_KNM);
            groupBoxTask_KNM.Controls.Add(textBoxTask_KNM);
            groupBoxTask_KNM.Location = new Point(28, 42);
            groupBoxTask_KNM.Name = "groupBoxTask_KNM";
            groupBoxTask_KNM.Size = new Size(618, 426);
            groupBoxTask_KNM.TabIndex = 0;
            groupBoxTask_KNM.TabStop = false;
            groupBoxTask_KNM.Text = "Условие";
            // 
            // dataGridViewMatrix_KNM
            // 
            dataGridViewMatrix_KNM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix_KNM.ColumnHeadersVisible = false;
            dataGridViewMatrix_KNM.Location = new Point(256, 69);
            dataGridViewMatrix_KNM.Name = "dataGridViewMatrix_KNM";
            dataGridViewMatrix_KNM.RowHeadersVisible = false;
            dataGridViewMatrix_KNM.RowHeadersWidth = 51;
            dataGridViewMatrix_KNM.Size = new Size(318, 311);
            dataGridViewMatrix_KNM.TabIndex = 1;
            // 
            // textBoxTask_KNM
            // 
            textBoxTask_KNM.Location = new Point(17, 69);
            textBoxTask_KNM.Multiline = true;
            textBoxTask_KNM.Name = "textBoxTask_KNM";
            textBoxTask_KNM.ReadOnly = true;
            textBoxTask_KNM.Size = new Size(218, 99);
            textBoxTask_KNM.TabIndex = 0;
            textBoxTask_KNM.Text = "Дана матрица 5*5\r\nВыполнить сортировку по возрастанию\r\nв пятом столбце.";
            // 
            // groupBoxOutput_KNM
            // 
            groupBoxOutput_KNM.Controls.Add(dataGridViewResult_KNM);
            groupBoxOutput_KNM.Controls.Add(labelResult_KNM);
            groupBoxOutput_KNM.Location = new Point(683, 42);
            groupBoxOutput_KNM.Name = "groupBoxOutput_KNM";
            groupBoxOutput_KNM.Size = new Size(345, 426);
            groupBoxOutput_KNM.TabIndex = 1;
            groupBoxOutput_KNM.TabStop = false;
            groupBoxOutput_KNM.Text = "Вывод данных";
            // 
            // dataGridViewResult_KNM
            // 
            dataGridViewResult_KNM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_KNM.ColumnHeadersVisible = false;
            dataGridViewResult_KNM.Location = new Point(21, 69);
            dataGridViewResult_KNM.Name = "dataGridViewResult_KNM";
            dataGridViewResult_KNM.RowHeadersVisible = false;
            dataGridViewResult_KNM.RowHeadersWidth = 51;
            dataGridViewResult_KNM.Size = new Size(305, 311);
            dataGridViewResult_KNM.TabIndex = 1;
            // 
            // labelResult_KNM
            // 
            labelResult_KNM.Location = new Point(16, 26);
            labelResult_KNM.Name = "labelResult_KNM";
            labelResult_KNM.ReadOnly = true;
            labelResult_KNM.Size = new Size(125, 27);
            labelResult_KNM.TabIndex = 0;
            labelResult_KNM.Text = "Результат";
            // 
            // buttonHelp_KNM
            // 
            buttonHelp_KNM.Location = new Point(699, 479);
            buttonHelp_KNM.Name = "buttonHelp_KNM";
            buttonHelp_KNM.Size = new Size(145, 51);
            buttonHelp_KNM.TabIndex = 2;
            buttonHelp_KNM.Text = "Справка";
            buttonHelp_KNM.UseVisualStyleBackColor = true;
            buttonHelp_KNM.Click += buttonHelp_KNM_Click;
            // 
            // buttonDone_KNM
            // 
            buttonDone_KNM.Location = new Point(864, 479);
            buttonDone_KNM.Name = "buttonDone_KNM";
            buttonDone_KNM.Size = new Size(145, 51);
            buttonDone_KNM.TabIndex = 3;
            buttonDone_KNM.Text = "Выполнить";
            buttonDone_KNM.UseVisualStyleBackColor = true;
            buttonDone_KNM.Click += buttonDone_KNM_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 542);
            Controls.Add(buttonDone_KNM);
            Controls.Add(buttonHelp_KNM);
            Controls.Add(groupBoxOutput_KNM);
            Controls.Add(groupBoxTask_KNM);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            Text = "Спринт 6 | Таск 3 | Вариант 19 | Кучеренко Н.М.";
            Load += FormMain_Load;
            groupBoxTask_KNM.ResumeLayout(false);
            groupBoxTask_KNM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_KNM).EndInit();
            groupBoxOutput_KNM.ResumeLayout(false);
            groupBoxOutput_KNM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_KNM).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_KNM;
        private DataGridView dataGridViewMatrix_KNM;
        private TextBox textBoxTask_KNM;
        private GroupBox groupBoxOutput_KNM;
        private DataGridView dataGridViewResult_KNM;
        private TextBox labelResult_KNM;
        private Button buttonHelp_KNM;
        private Button buttonDone_KNM;
    }
}
