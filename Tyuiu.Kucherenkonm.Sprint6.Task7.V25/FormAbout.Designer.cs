namespace Tyuiu.Kucherenkonm.Sprint6.Task7.V25
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            pictureBox_KNM = new PictureBox();
            textBox_KNM = new TextBox();
            buttonOk_KNM = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox_KNM).BeginInit();
            SuspendLayout();
            // 
            // pictureBox_KNM
            // 
            pictureBox_KNM.Image = Properties.Resources.__3_4;
            pictureBox_KNM.Location = new Point(30, 50);
            pictureBox_KNM.Name = "pictureBox_KNM";
            pictureBox_KNM.Size = new Size(136, 177);
            pictureBox_KNM.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_KNM.TabIndex = 0;
            pictureBox_KNM.TabStop = false;
            // 
            // textBox_KNM
            // 
            textBox_KNM.Location = new Point(190, 50);
            textBox_KNM.Multiline = true;
            textBox_KNM.Name = "textBox_KNM";
            textBox_KNM.ReadOnly = true;
            textBox_KNM.Size = new Size(395, 227);
            textBox_KNM.TabIndex = 1;
            textBox_KNM.Text = resources.GetString("textBox_KNM.Text");
            // 
            // buttonOk_KNM
            // 
            buttonOk_KNM.FlatStyle = FlatStyle.Flat;
            buttonOk_KNM.Location = new Point(498, 306);
            buttonOk_KNM.Name = "buttonOk_KNM";
            buttonOk_KNM.Size = new Size(87, 47);
            buttonOk_KNM.TabIndex = 2;
            buttonOk_KNM.Text = "OK";
            buttonOk_KNM.UseVisualStyleBackColor = true;
            buttonOk_KNM.Click += buttonOk_KNM_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 386);
            Controls.Add(buttonOk_KNM);
            Controls.Add(textBox_KNM);
            Controls.Add(pictureBox_KNM);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О разработчике";
            ((System.ComponentModel.ISupportInitialize)pictureBox_KNM).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox_KNM;
        private TextBox textBox_KNM;
        private Button buttonOk_KNM;
    }
}