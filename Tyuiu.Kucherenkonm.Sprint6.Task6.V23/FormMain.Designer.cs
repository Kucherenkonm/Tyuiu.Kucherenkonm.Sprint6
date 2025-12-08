namespace Tyuiu.Kucherenkonm.Sprint6.Task6.V23
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            openFileDialog_KNM = new OpenFileDialog();
            toolTip_KNM = new ToolTip(components);
            buttonOpenFile_KNM = new Button();
            buttonHelp_KNM = new Button();
            buttonDone_KNM = new Button();
            panelButtons_KNM = new Panel();
            panelTask_KNM = new Panel();
            groupBoxTask_KNM = new GroupBox();
            textBoxTask_KNM = new TextBox();
            panelOut_KNM = new Panel();
            groupBoxOut_KNM = new GroupBox();
            textBoxOut_KNM = new TextBox();
            panelIn_KNM = new Panel();
            groupBoxIn_KNM = new GroupBox();
            textBoxIn_KNM = new TextBox();
            splitter_KNM = new Splitter();
            panelButtons_KNM.SuspendLayout();
            panelTask_KNM.SuspendLayout();
            groupBoxTask_KNM.SuspendLayout();
            panelOut_KNM.SuspendLayout();
            groupBoxOut_KNM.SuspendLayout();
            panelIn_KNM.SuspendLayout();
            groupBoxIn_KNM.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog_KNM
            // 
            openFileDialog_KNM.FileName = "openFileDialog1";
            // 
            // toolTip_KNM
            // 
            toolTip_KNM.ToolTipTitle = "Подсказка";
            // 
            // buttonOpenFile_KNM
            // 
            buttonOpenFile_KNM.Image = Properties.Resources.folder_go;
            buttonOpenFile_KNM.Location = new Point(12, 12);
            buttonOpenFile_KNM.Name = "buttonOpenFile_KNM";
            buttonOpenFile_KNM.Size = new Size(69, 67);
            buttonOpenFile_KNM.TabIndex = 0;
            toolTip_KNM.SetToolTip(buttonOpenFile_KNM, "Открыть файл\r\nВыберите нужный файл для обработки\r\n");
            buttonOpenFile_KNM.UseVisualStyleBackColor = true;
            buttonOpenFile_KNM.Click += buttonOpenFile_KNM_Click;
            // 
            // buttonHelp_KNM
            // 
            buttonHelp_KNM.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_KNM.Image = Properties.Resources.emotion_wink;
            buttonHelp_KNM.Location = new Point(942, 12);
            buttonHelp_KNM.Name = "buttonHelp_KNM";
            buttonHelp_KNM.Size = new Size(69, 67);
            buttonHelp_KNM.TabIndex = 2;
            toolTip_KNM.SetToolTip(buttonHelp_KNM, "Сведения о программе");
            buttonHelp_KNM.UseVisualStyleBackColor = true;
            buttonHelp_KNM.Click += buttonHelp_KNM_Click;
            // 
            // buttonDone_KNM
            // 
            buttonDone_KNM.Image = Properties.Resources.page_white_go;
            buttonDone_KNM.Location = new Point(102, 12);
            buttonDone_KNM.Name = "buttonDone_KNM";
            buttonDone_KNM.Size = new Size(69, 67);
            buttonDone_KNM.TabIndex = 1;
            toolTip_KNM.SetToolTip(buttonDone_KNM, "Ответ");
            buttonDone_KNM.UseVisualStyleBackColor = true;
            buttonDone_KNM.Click += buttonDone_KNM_Click;
            // 
            // panelButtons_KNM
            // 
            panelButtons_KNM.Controls.Add(buttonHelp_KNM);
            panelButtons_KNM.Controls.Add(buttonDone_KNM);
            panelButtons_KNM.Controls.Add(buttonOpenFile_KNM);
            panelButtons_KNM.Dock = DockStyle.Top;
            panelButtons_KNM.Location = new Point(0, 0);
            panelButtons_KNM.Name = "panelButtons_KNM";
            panelButtons_KNM.Size = new Size(1023, 85);
            panelButtons_KNM.TabIndex = 0;
            // 
            // panelTask_KNM
            // 
            panelTask_KNM.Controls.Add(groupBoxTask_KNM);
            panelTask_KNM.Dock = DockStyle.Top;
            panelTask_KNM.Location = new Point(0, 85);
            panelTask_KNM.Name = "panelTask_KNM";
            panelTask_KNM.Size = new Size(1023, 89);
            panelTask_KNM.TabIndex = 1;
            // 
            // groupBoxTask_KNM
            // 
            groupBoxTask_KNM.Controls.Add(textBoxTask_KNM);
            groupBoxTask_KNM.Dock = DockStyle.Fill;
            groupBoxTask_KNM.Location = new Point(0, 0);
            groupBoxTask_KNM.Name = "groupBoxTask_KNM";
            groupBoxTask_KNM.Size = new Size(1023, 89);
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
            textBoxTask_KNM.Size = new Size(1017, 63);
            textBoxTask_KNM.TabIndex = 0;
            textBoxTask_KNM.Text = resources.GetString("textBoxTask_KNM.Text");
            // 
            // panelOut_KNM
            // 
            panelOut_KNM.Controls.Add(groupBoxOut_KNM);
            panelOut_KNM.Dock = DockStyle.Right;
            panelOut_KNM.Location = new Point(525, 174);
            panelOut_KNM.Name = "panelOut_KNM";
            panelOut_KNM.Size = new Size(498, 367);
            panelOut_KNM.TabIndex = 2;
            // 
            // groupBoxOut_KNM
            // 
            groupBoxOut_KNM.Controls.Add(textBoxOut_KNM);
            groupBoxOut_KNM.Dock = DockStyle.Fill;
            groupBoxOut_KNM.Location = new Point(0, 0);
            groupBoxOut_KNM.Name = "groupBoxOut_KNM";
            groupBoxOut_KNM.Size = new Size(498, 367);
            groupBoxOut_KNM.TabIndex = 0;
            groupBoxOut_KNM.TabStop = false;
            groupBoxOut_KNM.Text = "Вывод";
            // 
            // textBoxOut_KNM
            // 
            textBoxOut_KNM.Dock = DockStyle.Fill;
            textBoxOut_KNM.Location = new Point(3, 23);
            textBoxOut_KNM.Multiline = true;
            textBoxOut_KNM.Name = "textBoxOut_KNM";
            textBoxOut_KNM.Size = new Size(492, 341);
            textBoxOut_KNM.TabIndex = 0;
            // 
            // panelIn_KNM
            // 
            panelIn_KNM.Controls.Add(groupBoxIn_KNM);
            panelIn_KNM.Dock = DockStyle.Left;
            panelIn_KNM.Location = new Point(0, 174);
            panelIn_KNM.Name = "panelIn_KNM";
            panelIn_KNM.Size = new Size(500, 367);
            panelIn_KNM.TabIndex = 3;
            // 
            // groupBoxIn_KNM
            // 
            groupBoxIn_KNM.Controls.Add(textBoxIn_KNM);
            groupBoxIn_KNM.Dock = DockStyle.Fill;
            groupBoxIn_KNM.Location = new Point(0, 0);
            groupBoxIn_KNM.Name = "groupBoxIn_KNM";
            groupBoxIn_KNM.Size = new Size(500, 367);
            groupBoxIn_KNM.TabIndex = 0;
            groupBoxIn_KNM.TabStop = false;
            groupBoxIn_KNM.Text = "Ввод";
            // 
            // textBoxIn_KNM
            // 
            textBoxIn_KNM.Dock = DockStyle.Fill;
            textBoxIn_KNM.Location = new Point(3, 23);
            textBoxIn_KNM.Multiline = true;
            textBoxIn_KNM.Name = "textBoxIn_KNM";
            textBoxIn_KNM.Size = new Size(494, 341);
            textBoxIn_KNM.TabIndex = 0;
            // 
            // splitter_KNM
            // 
            splitter_KNM.Location = new Point(500, 174);
            splitter_KNM.Name = "splitter_KNM";
            splitter_KNM.Size = new Size(21, 367);
            splitter_KNM.TabIndex = 4;
            splitter_KNM.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1023, 541);
            Controls.Add(splitter_KNM);
            Controls.Add(panelIn_KNM);
            Controls.Add(panelOut_KNM);
            Controls.Add(panelTask_KNM);
            Controls.Add(panelButtons_KNM);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 6 | Вариант 23 | Кучеренко Н.М.";
            panelButtons_KNM.ResumeLayout(false);
            panelTask_KNM.ResumeLayout(false);
            groupBoxTask_KNM.ResumeLayout(false);
            groupBoxTask_KNM.PerformLayout();
            panelOut_KNM.ResumeLayout(false);
            groupBoxOut_KNM.ResumeLayout(false);
            groupBoxOut_KNM.PerformLayout();
            panelIn_KNM.ResumeLayout(false);
            groupBoxIn_KNM.ResumeLayout(false);
            groupBoxIn_KNM.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private OpenFileDialog openFileDialog_KNM;
        private ToolTip toolTip_KNM;
        private Panel panelButtons_KNM;
        private Button buttonDone_KNM;
        private Button buttonOpenFile_KNM;
        private Panel panelTask_KNM;
        private Panel panelOut_KNM;
        private Panel panelIn_KNM;
        private Splitter splitter_KNM;
        private Button buttonHelp_KNM;
        private GroupBox groupBoxTask_KNM;
        private TextBox textBoxTask_KNM;
        private GroupBox groupBoxOut_KNM;
        private TextBox textBoxOut_KNM;
        private GroupBox groupBoxIn_KNM;
        private TextBox textBoxIn_KNM;
    }
}
