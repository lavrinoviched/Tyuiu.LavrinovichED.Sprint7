namespace Tyuiu.LavrinovichED.Sprint7.Project.V11
{
    partial class FormHelp_LED
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHelp_LED));
            textBoxHelp_LED = new TextBox();
            labelHelp_LED = new Label();
            buttonOk_LED = new Button();
            SuspendLayout();
            // 
            // textBoxHelp_LED
            // 
            textBoxHelp_LED.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxHelp_LED.Location = new Point(12, 50);
            textBoxHelp_LED.Multiline = true;
            textBoxHelp_LED.Name = "textBoxHelp_LED";
            textBoxHelp_LED.ReadOnly = true;
            textBoxHelp_LED.Size = new Size(1008, 354);
            textBoxHelp_LED.TabIndex = 0;
            textBoxHelp_LED.TabStop = false;
            textBoxHelp_LED.Text = resources.GetString("textBoxHelp_LED.Text");
            // 
            // labelHelp_LED
            // 
            labelHelp_LED.AutoSize = true;
            labelHelp_LED.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelHelp_LED.Location = new Point(418, 9);
            labelHelp_LED.Name = "labelHelp_LED";
            labelHelp_LED.Size = new Size(155, 27);
            labelHelp_LED.TabIndex = 2;
            labelHelp_LED.Text = "Руководство";
            // 
            // buttonOk_LED
            // 
            buttonOk_LED.Location = new Point(923, 410);
            buttonOk_LED.Name = "buttonOk_LED";
            buttonOk_LED.Size = new Size(94, 29);
            buttonOk_LED.TabIndex = 3;
            buttonOk_LED.TabStop = false;
            buttonOk_LED.Text = "OK";
            buttonOk_LED.UseVisualStyleBackColor = true;
            buttonOk_LED.Click += buttonOk_LED_Click;
            // 
            // FormHelp_LED
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 450);
            Controls.Add(buttonOk_LED);
            Controls.Add(labelHelp_LED);
            Controls.Add(textBoxHelp_LED);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormHelp_LED";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Подсказка";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxHelp_LED;
        private Label labelHelp_LED;
        private Button buttonOk_LED;
    }
}