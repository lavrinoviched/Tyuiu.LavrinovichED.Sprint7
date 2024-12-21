namespace Tyuiu.LavrinovichED.Sprint7.Project.V11
{
    public partial class FormMain_LED : Form
    {
        public FormMain_LED()
        {
            InitializeComponent();
        }

        private void toolStripHelp_LED_Click(object sender, EventArgs e)
        {
            FormHelp_LED formHelp = new FormHelp_LED();
            formHelp.ShowDialog();
        }

        private void toolStripButton_Info_Click(object sender, EventArgs e)
        {
            FormAbout_LED formAbout = new FormAbout_LED();
            formAbout.ShowDialog();
        }

        private void toolStripExit_LED_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
