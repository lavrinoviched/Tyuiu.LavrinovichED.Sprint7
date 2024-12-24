using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
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

        private void buttonGrafClock_LED_Click(object sender, EventArgs e)
        {

            // Очистка предыдущих данных на графике
            chart_LED.Series.Clear();

            // Создание новой серии для сплайн-графика
            Series splineSeries = new Series
            {
                Name = "Отработанные часы",
                Color = System.Drawing.Color.Blue,
                ChartType = SeriesChartType.Spline // Устанавливаем тип графика как сплайн
            };

            // Добавление данных из DataGridView в серию графика
            foreach (DataGridViewRow row in dataGridView_LED.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[1].Value != null)
                {
                    string lastName = row.Cells[0].Value.ToString();
                    if (double.TryParse(row.Cells[10].Value.ToString(), out double hours))
                    {
                        // Используем индекс строки как значение по оси X
                        int index = row.Index;
                        splineSeries.Points.AddXY(index, hours);

                        // Добавляем подпись с фамилией на график
                        DataPoint point = splineSeries.Points[splineSeries.Points.Count - 1];
                        point.Label = lastName; // Устанавливаем подпись для точки
                    }
                }
            }

            // Добавление серии на график
            chart_LED.Series.Add(splineSeries);

            // Настройка заголовков осей
            chart_LED.ChartAreas[0].AxisX.Title = "Фамилия";
            chart_LED.ChartAreas[0].AxisY.Title = "Отработанные часы";

            splineSeries.IsValueShownAsLabel = true; // Показывать значения на графике
        }

        private void buttonGtafMoney_LED_Click(object sender, EventArgs e)
        {
            // Очистка предыдущих данных на графике
            chart_LED.Series.Clear();

            // Создание новой серии для сплайн-графика
            Series splineSeries = new Series
            {
                Name = "Заработная плата",
                Color = System.Drawing.Color.Blue,
                ChartType = SeriesChartType.Spline // Устанавливаем тип графика как сплайн
            };

            // Добавление данных из DataGridView в серию графика
            foreach (DataGridViewRow row in dataGridView_LED.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[11].Value != null)
                {
                    string lastName = row.Cells[0].Value.ToString();
                    if (double.TryParse(row.Cells[11].Value.ToString(), out double hours))
                    {
                        // Используем индекс строки как значение по оси X
                        int index = row.Index;
                        splineSeries.Points.AddXY(index, hours);

                        // Добавляем подпись с фамилией на график
                        DataPoint point = splineSeries.Points[splineSeries.Points.Count - 1];
                        point.Label = lastName; // Устанавливаем подпись для точки
                    }
                }
            }

            // Добавление серии на график
            chart_LED.Series.Add(splineSeries);

            // Настройка заголовков осей
            chart_LED.ChartAreas[0].AxisX.Title = "Фамилия";
            chart_LED.ChartAreas[0].AxisY.Title = "Заработная плата";

            // Настройка отображения подписей
            splineSeries.IsValueShownAsLabel = true; // Показывать значения на графике
        }

        private void buttonSearch_LED_Click(object sender, EventArgs e)
        {
            if (textBoxFilter_LED != null)
            {
                string currentText = textBoxFilter_LED.Text;
                foreach (DataGridViewRow row in dataGridView_LED.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null && textBoxFilter_LED.Text != string.Empty && cell.Value.ToString().Contains(textBoxFilter_LED.Text))
                        {
                            cell.Style.BackColor = Color.Yellow;
                        }
                        else
                        {
                            cell.Style.BackColor = Color.White;
                        }
                    }
                }
            }
        }

        private void buttonDone_LED_Click_1(object sender, EventArgs e)
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

        private void buttonDel_LED_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверенны, что хотите удалить \nвыбранные элементы?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);

            if (dialogResult == DialogResult.Yes)
            {
                index = dataGridView_LED.CurrentCell.RowIndex;
                dataGridView_LED.Rows.RemoveAt(index);
            }
        }



        private void buttonStaff_LED_Click(object sender, EventArgs e)
        {
            int min = 0;
            int max = 0;
            //заведение и заполнение матрицв
            int rows = dataGridView_LED.RowCount;
            int columns = dataGridView_LED.ColumnCount;
            string str;
            string[,] matrix = new string[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    str = "";
                    str += dataGridView_LED.Rows[i].Cells[j].Value;
                    matrix[i, j] = str;
                }

            }

            double summalet = 0;
            int k = 0;
            double srzn = 0;
            // количество 
            for (int i = 0; i < rows - 1; i++)
            {
                k++;
                textBoxStaff_LED.Text = k.ToString();

            }
        }
    }

}
