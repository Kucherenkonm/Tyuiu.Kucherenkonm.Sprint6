namespace Tyuiu.Kucherenkonm.Sprint6.Task7.V25
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
            panelTop_KNM = new Panel();
            buttonHelp_KNM = new Button();
            buttonSave_KNM = new Button();
            buttonDone_KNM = new Button();
            buttonOpenFile_KNM = new Button();
            panelTop2_KNM = new Panel();
            groupBoxTask_KNM = new GroupBox();
            textBox1 = new TextBox();
            panelLeft_KNM = new Panel();
            groupBoxIn_KNM = new GroupBox();
            dataGridViewIn_KNM = new DataGridView();
            panelRight_KNM = new Panel();
            groupBoxOut_KNM = new GroupBox();
            dataGridViewOut_KNM = new DataGridView();
            splitter_KNM = new Splitter();
            openFileDialog_KNM = new OpenFileDialog();
            toolTip_KNM = new ToolTip(components);
            saveFileDialog_KNM = new SaveFileDialog();
            panelTop_KNM.SuspendLayout();
            panelTop2_KNM.SuspendLayout();
            groupBoxTask_KNM.SuspendLayout();
            panelLeft_KNM.SuspendLayout();
            groupBoxIn_KNM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_KNM).BeginInit();
            panelRight_KNM.SuspendLayout();
            groupBoxOut_KNM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_KNM).BeginInit();
            SuspendLayout();
            // 
            // panelTop_KNM
            // 
            panelTop_KNM.Controls.Add(buttonHelp_KNM);
            panelTop_KNM.Controls.Add(buttonSave_KNM);
            panelTop_KNM.Controls.Add(buttonDone_KNM);
            panelTop_KNM.Controls.Add(buttonOpenFile_KNM);
            panelTop_KNM.Dock = DockStyle.Top;
            panelTop_KNM.Location = new Point(0, 0);
            panelTop_KNM.Name = "panelTop_KNM";
            panelTop_KNM.Size = new Size(1174, 76);
            panelTop_KNM.TabIndex = 2;
            // 
            // buttonHelp_KNM
            // 
            buttonHelp_KNM.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_KNM.FlatStyle = FlatStyle.Flat;
            buttonHelp_KNM.Image = Properties.Resources.help;
            buttonHelp_KNM.Location = new Point(1092, 12);
            buttonHelp_KNM.Name = "buttonHelp_KNM";
            buttonHelp_KNM.RightToLeft = RightToLeft.No;
            buttonHelp_KNM.Size = new Size(70, 58);
            buttonHelp_KNM.TabIndex = 3;
            toolTip_KNM.SetToolTip(buttonHelp_KNM, "Нажмите для справки");
            buttonHelp_KNM.UseVisualStyleBackColor = true;
            buttonHelp_KNM.Click += buttonHelp_KNM_Click;
            buttonHelp_KNM.MouseEnter += buttonHelp_KNM_MouseEnter;
            // 
            // buttonSave_KNM
            // 
            buttonSave_KNM.FlatStyle = FlatStyle.Flat;
            buttonSave_KNM.Image = Properties.Resources.page_save;
            buttonSave_KNM.Location = new Point(185, 12);
            buttonSave_KNM.Name = "buttonSave_KNM";
            buttonSave_KNM.Size = new Size(70, 58);
            buttonSave_KNM.TabIndex = 2;
            toolTip_KNM.SetToolTip(buttonSave_KNM, "Нажмите, чтоб сохранить в файл");
            buttonSave_KNM.UseVisualStyleBackColor = true;
            buttonSave_KNM.Click += buttonSave_KNM_Click;
            buttonSave_KNM.MouseEnter += buttonSave_KNM_MouseEnter;
            // 
            // buttonDone_KNM
            // 
            buttonDone_KNM.Enabled = false;
            buttonDone_KNM.FlatStyle = FlatStyle.Flat;
            buttonDone_KNM.Image = Properties.Resources.page_white_go;
            buttonDone_KNM.Location = new Point(98, 12);
            buttonDone_KNM.Name = "buttonDone_KNM";
            buttonDone_KNM.Size = new Size(70, 58);
            buttonDone_KNM.TabIndex = 1;
            toolTip_KNM.SetToolTip(buttonDone_KNM, "Нажмите, чтоб выполнить");
            buttonDone_KNM.UseVisualStyleBackColor = true;
            buttonDone_KNM.Click += buttonDone_KNM_Click;
            buttonDone_KNM.MouseEnter += buttonDone_KNM_MouseEnter;
            // 
            // buttonOpenFile_KNM
            // 
            buttonOpenFile_KNM.FlatStyle = FlatStyle.Flat;
            buttonOpenFile_KNM.Image = Properties.Resources.folder_go;
            buttonOpenFile_KNM.Location = new Point(12, 12);
            buttonOpenFile_KNM.Name = "buttonOpenFile_KNM";
            buttonOpenFile_KNM.Size = new Size(70, 58);
            buttonOpenFile_KNM.TabIndex = 0;
            toolTip_KNM.SetToolTip(buttonOpenFile_KNM, "Нажмите, чтоб загрузить файл");
            buttonOpenFile_KNM.UseVisualStyleBackColor = true;
            buttonOpenFile_KNM.Click += buttonOpenFile_KNM_Click;
            buttonOpenFile_KNM.MouseEnter += buttonOpenFile_KNM_MouseEnter;
            // 
            // panelTop2_KNM
            // 
            panelTop2_KNM.Controls.Add(groupBoxTask_KNM);
            panelTop2_KNM.Dock = DockStyle.Top;
            panelTop2_KNM.Location = new Point(0, 76);
            panelTop2_KNM.Name = "panelTop2_KNM";
            panelTop2_KNM.Size = new Size(1174, 95);
            panelTop2_KNM.TabIndex = 3;
            // 
            // groupBoxTask_KNM
            // 
            groupBoxTask_KNM.Controls.Add(textBox1);
            groupBoxTask_KNM.Dock = DockStyle.Fill;
            groupBoxTask_KNM.Location = new Point(0, 0);
            groupBoxTask_KNM.Name = "groupBoxTask_KNM";
            groupBoxTask_KNM.Size = new Size(1174, 95);
            groupBoxTask_KNM.TabIndex = 0;
            groupBoxTask_KNM.TabStop = false;
            groupBoxTask_KNM.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(3, 23);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(1168, 69);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // panelLeft_KNM
            // 
            panelLeft_KNM.Controls.Add(groupBoxIn_KNM);
            panelLeft_KNM.Dock = DockStyle.Left;
            panelLeft_KNM.Location = new Point(0, 171);
            panelLeft_KNM.Name = "panelLeft_KNM";
            panelLeft_KNM.Size = new Size(557, 411);
            panelLeft_KNM.TabIndex = 4;
            // 
            // groupBoxIn_KNM
            // 
            groupBoxIn_KNM.Controls.Add(dataGridViewIn_KNM);
            groupBoxIn_KNM.Dock = DockStyle.Fill;
            groupBoxIn_KNM.Location = new Point(0, 0);
            groupBoxIn_KNM.Name = "groupBoxIn_KNM";
            groupBoxIn_KNM.Size = new Size(557, 411);
            groupBoxIn_KNM.TabIndex = 0;
            groupBoxIn_KNM.TabStop = false;
            groupBoxIn_KNM.Text = "Ввод";
            // 
            // dataGridViewIn_KNM
            // 
            dataGridViewIn_KNM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn_KNM.Dock = DockStyle.Fill;
            dataGridViewIn_KNM.Location = new Point(3, 23);
            dataGridViewIn_KNM.Name = "dataGridViewIn_KNM";
            dataGridViewIn_KNM.RowHeadersWidth = 51;
            dataGridViewIn_KNM.ScrollBars = ScrollBars.Vertical;
            dataGridViewIn_KNM.Size = new Size(551, 385);
            dataGridViewIn_KNM.TabIndex = 0;
            // 
            // panelRight_KNM
            // 
            panelRight_KNM.Controls.Add(groupBoxOut_KNM);
            panelRight_KNM.Dock = DockStyle.Right;
            panelRight_KNM.Location = new Point(557, 171);
            panelRight_KNM.Name = "panelRight_KNM";
            panelRight_KNM.Size = new Size(617, 411);
            panelRight_KNM.TabIndex = 5;
            // 
            // groupBoxOut_KNM
            // 
            groupBoxOut_KNM.Controls.Add(dataGridViewOut_KNM);
            groupBoxOut_KNM.Dock = DockStyle.Fill;
            groupBoxOut_KNM.Location = new Point(0, 0);
            groupBoxOut_KNM.Name = "groupBoxOut_KNM";
            groupBoxOut_KNM.Size = new Size(617, 411);
            groupBoxOut_KNM.TabIndex = 0;
            groupBoxOut_KNM.TabStop = false;
            groupBoxOut_KNM.Text = "Вывод";
            // 
            // dataGridViewOut_KNM
            // 
            dataGridViewOut_KNM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut_KNM.Dock = DockStyle.Fill;
            dataGridViewOut_KNM.Location = new Point(3, 23);
            dataGridViewOut_KNM.Name = "dataGridViewOut_KNM";
            dataGridViewOut_KNM.RowHeadersWidth = 51;
            dataGridViewOut_KNM.ScrollBars = ScrollBars.Vertical;
            dataGridViewOut_KNM.Size = new Size(611, 385);
            dataGridViewOut_KNM.TabIndex = 0;
            // 
            // splitter_KNM
            // 
            splitter_KNM.Location = new Point(557, 171);
            splitter_KNM.Name = "splitter_KNM";
            splitter_KNM.Size = new Size(4, 411);
            splitter_KNM.TabIndex = 6;
            splitter_KNM.TabStop = false;
            // 
            // openFileDialog_KNM
            // 
            openFileDialog_KNM.FileName = "openFileDialog1";
            // 
            // toolTip_KNM
            // 
            toolTip_KNM.IsBalloon = true;
            toolTip_KNM.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1174, 582);
            Controls.Add(splitter_KNM);
            Controls.Add(panelRight_KNM);
            Controls.Add(panelLeft_KNM);
            Controls.Add(panelTop2_KNM);
            Controls.Add(panelTop_KNM);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 7 | Вариант 25 | Кучеренко Н.М.";
            Load += FormMain_Load;
            panelTop_KNM.ResumeLayout(false);
            panelTop2_KNM.ResumeLayout(false);
            groupBoxTask_KNM.ResumeLayout(false);
            groupBoxTask_KNM.PerformLayout();
            panelLeft_KNM.ResumeLayout(false);
            groupBoxIn_KNM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_KNM).EndInit();
            panelRight_KNM.ResumeLayout(false);
            groupBoxOut_KNM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_KNM).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop_KNM;
        private Panel panelTop2_KNM;
        private Panel panelLeft_KNM;
        private Panel panelRight_KNM;
        private Splitter splitter_KNM;
        private GroupBox groupBoxTask_KNM;
        private GroupBox groupBoxIn_KNM;
        private GroupBox groupBoxOut_KNM;
        private DataGridView dataGridViewIn_KNM;
        private DataGridView dataGridViewOut_KNM;
        private Button buttonHelp_KNM;
        private Button buttonSave_KNM;
        private Button buttonDone_KNM;
        private OpenFileDialog openFileDialog_KNM;
        private ToolTip toolTip_KNM;
        private TextBox textBox1;
        private SaveFileDialog saveFileDialog_KNM;
        private Button buttonOpenFile_KNM;
    }
}
