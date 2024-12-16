namespace Tyuiu.LavrinovichED.Sprint7.Project.V11
{
    partial class FormStart
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
            buttonStart_LED = new Button();
            buttonExit_LED = new Button();
            buttonDev_LED = new Button();
            SuspendLayout();
            // 
            // buttonStart_LED
            // 
            buttonStart_LED.BackColor = Color.LightSteelBlue;
            buttonStart_LED.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonStart_LED.Location = new Point(203, 145);
            buttonStart_LED.Name = "buttonStart_LED";
            buttonStart_LED.Size = new Size(400, 101);
            buttonStart_LED.TabIndex = 0;
            buttonStart_LED.Text = "Запустить ";
            buttonStart_LED.UseVisualStyleBackColor = false;
            buttonStart_LED.Click += this.buttonStart_LED_Click;
            // 
            // buttonExit_LED
            // 
            buttonExit_LED.BackColor = Color.LightCoral;
            buttonExit_LED.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonExit_LED.Location = new Point(66, 252);
            buttonExit_LED.Name = "buttonExit_LED";
            buttonExit_LED.Size = new Size(197, 51);
            buttonExit_LED.TabIndex = 1;
            buttonExit_LED.Text = "Выход";
            buttonExit_LED.UseVisualStyleBackColor = false;
            // 
            // buttonDev_LED
            // 
            buttonDev_LED.BackColor = Color.LightBlue;
            buttonDev_LED.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonDev_LED.Location = new Point(549, 252);
            buttonDev_LED.Name = "buttonDev_LED";
            buttonDev_LED.Size = new Size(197, 51);
            buttonDev_LED.TabIndex = 2;
            buttonDev_LED.Text = "О разработчике";
            buttonDev_LED.UseVisualStyleBackColor = false;
            // 
            // FormStart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDev_LED);
            Controls.Add(buttonExit_LED);
            Controls.Add(buttonStart_LED);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormStart";
            Text = "Пуск";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonStart_LED;
        private Button buttonExit_LED;
        private Button buttonDev_LED;
    }
}