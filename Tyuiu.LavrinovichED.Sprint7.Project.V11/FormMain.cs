using System;
using System.Windows.Forms;
using Tyuiu.LavrinovichED.Sprint7.Project.V11.Lib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tyuiu.LavrinovichED.Sprint7.Project.V11
{
    public partial class FormMain_LED : Form
    {
        public FormMain_LED()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        static string openFilePath;
        static int rows;
        static int columns;
        int index;

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

        private void ToolStripMenuItemSave_LED_Click(object sender, EventArgs e) //Сохранить
        {
            saveFileDialog_LED.FileName = openFilePath;
            saveFileDialog_LED.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_LED.ShowDialog();

            string path = saveFileDialog_LED.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridView_LED.RowCount;
            int columns = dataGridView_LED.ColumnCount;

            string str = "";



            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridView_LED.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridView_LED.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }




        private void buttonDel_LED_Click(object sender, EventArgs e) //удалить
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверенны, что хотите удалить \nвыбранные элементы?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);

            if (dialogResult == DialogResult.Yes)
            {
                index = dataGridView_LED.CurrentCell.RowIndex;
                dataGridView_LED.Rows.RemoveAt(index);
            }
        }

        private void buttonDone_LED_Click(object sender, EventArgs e) //добавить
        {
            string surname = textBoxSurname_LED.Text;
            string name = textBoxName_LED.Text;
            string middle = textBoxMiddle_LED.Text; //отчество 
            string telephone = textBoxTel_LED.Text;
            string data = textBoxData_LED.Text;
            string mesto = textBoxMesto_LED.Text;
            string post = textBoxPost_LED.Text;
            string work = textBoxWork_LED.Text;
            string birtday = textBoxBirtday_LED.Text;
            string education = textBoxEducation_LED.Text;
            string clock = textBoxClock_LED.Text;
            string money = textBoxMoney_LED.Text;

            // заполнение
            dataGridView_LED.Rows.Add(surname, name, middle, telephone, data, mesto, post, work, birtday, education, clock, money);
            textBoxSurname_LED.Text = "";
            textBoxName_LED.Text = "";
            textBoxMiddle_LED.Text = "";
            textBoxTel_LED.Text = "";
            textBoxData_LED.Text = "";
            textBoxMesto_LED.Text = "";
            textBoxPost_LED.Text = "";
            textBoxWork_LED.Text = "";
            textBoxBirtday_LED.Text = "";
            textBoxEducation_LED.Text = "";
            textBoxClock_LED.Text = "";
            textBoxMoney_LED.Text = "";
            dataGridView_LED.CurrentCell = dataGridView_LED.Rows[dataGridView_LED.Rows.Count - 1].Cells[0];

        }

        private void ToolStripMenuItemFile_LED_Click_1(object sender, EventArgs e)//открыть
        {
            try
            {
                openFileDialog_LED.ShowDialog();
                openFilePath = openFileDialog_LED.FileName;
                string[,] matrix = ds.LoadFromDataFile(openFilePath);
                rows = matrix.GetLength(0);
                columns = matrix.GetLength(1);

                dataGridView_LED.RowCount = rows + 1;
                dataGridView_LED.ColumnCount = columns;

                //добавление данных
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridView_LED.Rows[i].Cells[j].Value = matrix[i, j];
                    }
                }
                dataGridView_LED.AutoResizeColumns();
                //dataGridViewRabotniki_KAN.ScrollBars = ScrollBars.Both;
                for (int i = 0; i < dataGridView_LED.RowCount - 1; i++)
                {

                    if (dataGridView_LED.Rows[i].Cells[3].Value.ToString() == "")
                    {
                        dataGridView_LED.Rows.RemoveAt(i);
                        i--;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripTextBoxSearch_LED_Click(object sender, EventArgs e)
        {
            //
            
        }
    }
}
