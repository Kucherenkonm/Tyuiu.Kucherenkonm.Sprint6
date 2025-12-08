namespace Tyuiu.Kucherenkonm.Sprint6.Task6.V23
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox_KNM = new PictureBox();
            textBoxInfo_KNM = new TextBox();
            buttonOk_KNM = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox_KNM).BeginInit();
            SuspendLayout();
            // 
            // pictureBox_KNM
            // 
            pictureBox_KNM.Image = Properties.Resources.Картинка;
            pictureBox_KNM.Location = new Point(12, 33);
            pictureBox_KNM.Name = "pictureBox_KNM";
            pictureBox_KNM.Size = new Size(273, 277);
            pictureBox_KNM.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_KNM.TabIndex = 0;
            pictureBox_KNM.TabStop = false;
            // 
            // textBoxInfo_KNM
            // 
            textBoxInfo_KNM.Location = new Point(303, 66);
            textBoxInfo_KNM.Multiline = true;
            textBoxInfo_KNM.Name = "textBoxInfo_KNM";
            textBoxInfo_KNM.ReadOnly = true;
            textBoxInfo_KNM.Size = new Size(327, 132);
            textBoxInfo_KNM.TabIndex = 1;
            textBoxInfo_KNM.Text = "Разработчик: Кучеренко Надежда Михайловна\r\nГруппа ИИПб-25-1";
            // 
            // buttonOk_KNM
            // 
            buttonOk_KNM.Location = new Point(484, 272);
            buttonOk_KNM.Name = "buttonOk_KNM";
            buttonOk_KNM.Size = new Size(133, 38);
            buttonOk_KNM.TabIndex = 2;
            buttonOk_KNM.Text = "ОК";
            buttonOk_KNM.UseVisualStyleBackColor = true;
            buttonOk_KNM.Click += buttonOk_KNM_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 347);
            Controls.Add(buttonOk_KNM);
            Controls.Add(textBoxInfo_KNM);
            Controls.Add(pictureBox_KNM);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBox_KNM).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox_KNM;
        private TextBox textBoxInfo_KNM;
        private Button buttonOk_KNM;
    }
}