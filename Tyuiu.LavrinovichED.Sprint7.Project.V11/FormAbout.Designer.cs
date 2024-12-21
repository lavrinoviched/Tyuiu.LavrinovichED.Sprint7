namespace Tyuiu.LavrinovichED.Sprint7.Project.V11
{
    partial class FormAbout_LED
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout_LED));
            textBox_LED = new TextBox();
            pictureBox_LED = new PictureBox();
            buttonOK_LED = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox_LED).BeginInit();
            SuspendLayout();
            // 
            // textBox_LED
            // 
            textBox_LED.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox_LED.Location = new Point(293, 18);
            textBox_LED.Multiline = true;
            textBox_LED.Name = "textBox_LED";
            textBox_LED.ReadOnly = true;
            textBox_LED.Size = new Size(533, 293);
            textBox_LED.TabIndex = 0;
            textBox_LED.Text = resources.GetString("textBox_LED.Text");
            // 
            // pictureBox_LED
            // 
            pictureBox_LED.ErrorImage = (Image)resources.GetObject("pictureBox_LED.ErrorImage");
            pictureBox_LED.Image = (Image)resources.GetObject("pictureBox_LED.Image");
            pictureBox_LED.Location = new Point(23, 18);
            pictureBox_LED.Name = "pictureBox_LED";
            pictureBox_LED.Size = new Size(253, 335);
            pictureBox_LED.TabIndex = 1;
            pictureBox_LED.TabStop = false;
            // 
            // buttonOK_LED
            // 
            buttonOK_LED.Location = new Point(732, 335);
            buttonOK_LED.Name = "buttonOK_LED";
            buttonOK_LED.Size = new Size(94, 29);
            buttonOK_LED.TabIndex = 2;
            buttonOK_LED.Text = "OK";
            buttonOK_LED.UseVisualStyleBackColor = true;
            buttonOK_LED.Click += buttonOK_LED_Click;
            // 
            // FormAbout_LED
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 374);
            Controls.Add(buttonOK_LED);
            Controls.Add(pictureBox_LED);
            Controls.Add(textBox_LED);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout_LED";
            Text = "О разработчике";
            ((System.ComponentModel.ISupportInitialize)pictureBox_LED).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_LED;
        private PictureBox pictureBox_LED;
        private Button buttonOK_LED;
    }
}