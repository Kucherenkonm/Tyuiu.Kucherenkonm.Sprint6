namespace Tyuiu.Kucherenkonm.Sprint6.Task0.V3
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
            textBoxTask_KNM = new TextBox();
            groupBoxInput_KNM = new GroupBox();
            labelVarX_KNM = new TextBox();
            textBoxVarX_KNM = new TextBox();
            groupBoxOutput_KNM = new GroupBox();
            labelResult_KNM = new TextBox();
            textBoxResult_KNM = new TextBox();
            pictureBoxFormula_KNM = new PictureBox();
            buttonDone_KNM = new Button();
            buttonHelp_KNM = new Button();
            groupBoxCondition_KNM.SuspendLayout();
            groupBoxInput_KNM.SuspendLayout();
            groupBoxOutput_KNM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_KNM).BeginInit();
            SuspendLayout();
            // 
            // groupBoxCondition_KNM
            // 
            groupBoxCondition_KNM.Controls.Add(textBoxTask_KNM);
            groupBoxCondition_KNM.Location = new Point(46, 45);
            groupBoxCondition_KNM.Name = "groupBoxCondition_KNM";
            groupBoxCondition_KNM.Size = new Size(379, 162);
            groupBoxCondition_KNM.TabIndex = 0;
            groupBoxCondition_KNM.TabStop = false;
            groupBoxCondition_KNM.Text = "Условие";
            // 
            // textBoxTask_KNM
            // 
            textBoxTask_KNM.BackColor = SystemColors.Menu;
            textBoxTask_KNM.Location = new Point(20, 26);
            textBoxTask_KNM.Multiline = true;
            textBoxTask_KNM.Name = "textBoxTask_KNM";
            textBoxTask_KNM.ReadOnly = true;
            textBoxTask_KNM.Size = new Size(337, 130);
            textBoxTask_KNM.TabIndex = 0;
            textBoxTask_KNM.Text = "Вычислить значение выражения по формуле\r\n\r\n";
            // 
            // groupBoxInput_KNM
            // 
            groupBoxInput_KNM.Controls.Add(labelVarX_KNM);
            groupBoxInput_KNM.Controls.Add(textBoxVarX_KNM);
            groupBoxInput_KNM.Location = new Point(46, 231);
            groupBoxInput_KNM.Name = "groupBoxInput_KNM";
            groupBoxInput_KNM.Size = new Size(293, 151);
            groupBoxInput_KNM.TabIndex = 1;
            groupBoxInput_KNM.TabStop = false;
            groupBoxInput_KNM.Text = "Ввод данных";
            // 
            // labelVarX_KNM
            // 
            labelVarX_KNM.BackColor = SystemColors.Control;
            labelVarX_KNM.Location = new Point(45, 60);
            labelVarX_KNM.Name = "labelVarX_KNM";
            labelVarX_KNM.Size = new Size(125, 27);
            labelVarX_KNM.TabIndex = 1;
            labelVarX_KNM.Text = "Переменная:";
            // 
            // textBoxVarX_KNM
            // 
            textBoxVarX_KNM.Location = new Point(45, 93);
            textBoxVarX_KNM.Name = "textBoxVarX_KNM";
            textBoxVarX_KNM.Size = new Size(202, 27);
            textBoxVarX_KNM.TabIndex = 0;
            textBoxVarX_KNM.KeyPress += textBoxVarX_KeyPress;
            // 
            // groupBoxOutput_KNM
            // 
            groupBoxOutput_KNM.Controls.Add(labelResult_KNM);
            groupBoxOutput_KNM.Controls.Add(textBoxResult_KNM);
            groupBoxOutput_KNM.Location = new Point(361, 231);
            groupBoxOutput_KNM.Name = "groupBoxOutput_KNM";
            groupBoxOutput_KNM.Size = new Size(293, 151);
            groupBoxOutput_KNM.TabIndex = 2;
            groupBoxOutput_KNM.TabStop = false;
            groupBoxOutput_KNM.Text = "Вывод данных";
            // 
            // labelResult_KNM
            // 
            labelResult_KNM.BackColor = SystemColors.Menu;
            labelResult_KNM.Location = new Point(42, 60);
            labelResult_KNM.Name = "labelResult_KNM";
            labelResult_KNM.Size = new Size(125, 27);
            labelResult_KNM.TabIndex = 1;
            labelResult_KNM.Text = "Результат:";
            // 
            // textBoxResult_KNM
            // 
            textBoxResult_KNM.Location = new Point(42, 93);
            textBoxResult_KNM.Name = "textBoxResult_KNM";
            textBoxResult_KNM.ReadOnly = true;
            textBoxResult_KNM.Size = new Size(202, 27);
            textBoxResult_KNM.TabIndex = 0;
            // 
            // pictureBoxFormula_KNM
            // 
            pictureBoxFormula_KNM.Image = Properties.Resources.Снимок_экрана_2025_11_30_013125;
            pictureBoxFormula_KNM.Location = new Point(484, 56);
            pictureBoxFormula_KNM.Name = "pictureBoxFormula_KNM";
            pictureBoxFormula_KNM.Size = new Size(199, 103);
            pictureBoxFormula_KNM.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxFormula_KNM.TabIndex = 3;
            pictureBoxFormula_KNM.TabStop = false;
            pictureBoxFormula_KNM.Click += pictureBoxFormula_KNM_Click;
            // 
            // buttonDone_KNM
            // 
            buttonDone_KNM.Location = new Point(643, 397);
            buttonDone_KNM.Name = "buttonDone_KNM";
            buttonDone_KNM.Size = new Size(124, 41);
            buttonDone_KNM.TabIndex = 4;
            buttonDone_KNM.Text = "Выполнить";
            buttonDone_KNM.UseVisualStyleBackColor = true;
            buttonDone_KNM.Click += buttonDone_KNM_Click_3;
            // 
            // buttonHelp_KNM
            // 
            buttonHelp_KNM.Location = new Point(588, 397);
            buttonHelp_KNM.Name = "buttonHelp_KNM";
            buttonHelp_KNM.Size = new Size(39, 41);
            buttonHelp_KNM.TabIndex = 5;
            buttonHelp_KNM.Text = "?";
            buttonHelp_KNM.UseVisualStyleBackColor = true;
            buttonHelp_KNM.Click += buttonHelp_KNM_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonHelp_KNM);
            Controls.Add(buttonDone_KNM);
            Controls.Add(groupBoxOutput_KNM);
            Controls.Add(pictureBoxFormula_KNM);
            Controls.Add(groupBoxInput_KNM);
            Controls.Add(groupBoxCondition_KNM);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 3 | Кучеренко Н.М.";
            groupBoxCondition_KNM.ResumeLayout(false);
            groupBoxCondition_KNM.PerformLayout();
            groupBoxInput_KNM.ResumeLayout(false);
            groupBoxInput_KNM.PerformLayout();
            groupBoxOutput_KNM.ResumeLayout(false);
            groupBoxOutput_KNM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_KNM).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_KNM;
        private GroupBox groupBoxInput_KNM;
        private GroupBox groupBoxOutput_KNM;
        private PictureBox pictureBoxFormula_KNM;
        private Button buttonDone_KNM;
        private Button buttonHelp_KNM;
        private TextBox textBoxVarX_KNM;
        private TextBox textBoxResult_KNM;
        private TextBox textBoxTask_KNM;
        private TextBox labelVarX_KNM;
        private TextBox labelResult_KNM;
    }
}
