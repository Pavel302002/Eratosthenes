using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace EratosthenesProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void numbersButton_Click(object sender, EventArgs e)
        {
            var era = new Eratosthenes();
            int n = (int)nUpDown.Value;

            era.Init(n);
            var simpleNumbers = era.GetSieve(); //возврат самого решета
            answerRichTextBox.Text = era.ToStr(simpleNumbers); // возврат решета в виде строки

            int lastNumber = simpleNumbers[simpleNumbers.Count - 1];

            int columnsCount = 5; // установленное кол-во столбцов
            int rowsCount = (int)(lastNumber / columnsCount) + 1; //расчет кол-ва строк

            FillGridView(rowsCount, columnsCount, lastNumber, simpleNumbers); //передаем данные для заполнения
        }

        private void FillGridView(int rowsCount, int columnsCount, int lastNumber, List<int> numbers)
        {
            sieveGridView.RowHeadersVisible = false; //убираем заголовки столбцов
            sieveGridView.RowCount = rowsCount;
            sieveGridView.ColumnCount = columnsCount;
            // выставляем ширину ячеек
            for (int i = 0; i < columnsCount; i++)
            {
                sieveGridView.Columns[i].Width = 64;
            }
            // убираем сортировку столбцов
            foreach (DataGridViewColumn column in sieveGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            //заполнение ячеек
            int k = 0;
            int count = 1; //значения ячеек (числа от 1 до n)
            bool flag = false; //flag - показатель, что все нужные ячейки заполнены
            for (int i = 0; i < rowsCount && !flag; i++)
            {
                for (int j = 0; j < columnsCount && !flag; j++)
                {
                    sieveGridView.Rows[i].Cells[j].Value = count; //заполнение ячеек числами

                    if (count == numbers[k])
                    {
                        sieveGridView.Rows[i].Cells[j].Style.BackColor = Color.Green;
                        k++; 
                    }
                    else
                    {
                        sieveGridView.Rows[i].Cells[j].Style.BackColor = Color.Red;
                    }

                    sieveGridView.Rows[i].Cells[j].ReadOnly = true; //запрет на изменение ячеек

                    if (count == lastNumber)
                    {
                        flag = true;
                    }
                    else count++;
                }
            }
            
            for (int i = 0; i < rowsCount; i++)
            {
                for (int j = 0; j < columnsCount; j++)
                {
                    if (sieveGridView.Rows[i].Cells[j].Value == null)
                    {
                        sieveGridView.Rows[i].Cells[j].Style.BackColor = Color.White;
                    }
                }
            }
        }

        // сохранение в файл
        private void saveButton_Click(object sender, EventArgs e)
        {
            GroupBox groupBox = groupBox1;
            Bitmap image = new Bitmap(groupBox.Width, groupBox.Height); //заносим в image размер таблицы
            groupBox.DrawToBitmap(image, groupBox.ClientRectangle); //отрисовываем таблицу

            SaveFileDialog saveDialog = new SaveFileDialog(); //заносим параметры в saveDialog
            saveDialog.Title = "Сохранить картинку как...";
            saveDialog.OverwritePrompt = true;
            saveDialog.CheckPathExists = true;
            saveDialog.Filter = "Image Files(*.PNG)|*.PNG";
            saveDialog.ShowHelp = true;

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string path = saveDialog.FileName; //запись пути
                    image.Save(path, ImageFormat.Png); //сохранение рисунка в заданном формате по пути
                }
                catch
                {
                    MessageBox.Show("Невозможно сохранить изображение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //О программе
        private void aboutButton_Click(object sender, EventArgs e)
        {
            string text = "(с) Ляхман П.С., 720-1\n" +
                "Для поиска ряда простых чисел в данной программе используется алгоритм \"Решето Эратосфена\" - " +
                "алгоритм нахождение всех простых чисел до некоторого целого числа n.\n" +
                "В рамках курсовой работы алгоритм был модифицирован для поиска первых n простых чисел.\n" +
                "\nДля нахождения первых n простых чисел необходимо ввести значение N в диапазоне от 1 до 50, после чего нажать на кнопку" +
                "\"Найти первых N простых чисел\". Далее на экране появится само решето и текстовое поле с записью ряда простых чисел.\n" +
                "Чтобы сохранить полученное решето и ряд простых чисел, необходимо нажать на кнопку \"Сохранить ответ...\"\n" +
                "Изображение хранит в себе информацию о конечном решете и ряде первых n простых чисел.";
            string handler = "О программе";

            MessageBox.Show(text, handler, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
