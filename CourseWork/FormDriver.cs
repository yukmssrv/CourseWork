using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class FormDriver : Form
    {
        private DataGridView dataGridViewDriver = new DataGridView();
        private Form1 form;
        private Driver driver = null;
        private int replace = 0;
        private int index = 0;
        public FormDriver(Form1 form1)
        {
            InitializeComponent();
            form = form1;
        }
        public FormDriver(Form1 form1, Driver dr, int rowIndex)
        {
            InitializeComponent();
            form = form1;
            driver = dr;
            index = rowIndex;
            textBoxFIOdriver.Text = driver.fio.surname + " " + driver.fio.name + " " + driver.fio.middlename;
            dateTimeDatebirth.Text = driver.datebirth;
            textBoxNumberVU.Text = driver.NumberVU;
            comboBoxcategoryVU.Text = driver.Category;
            dateTimeDateVU.Text = driver.dateVU;
            replace = 1;
        }
        public Driver UpdatedDriver()
        {
            string[] fio = new string[3];
            string FaImOt = textBoxFIOdriver.Text.Trim();
            fio = split(FaImOt);
            string datebirth = dateTimeDatebirth.Text.Trim();
            string numberVU = textBoxNumberVU.Text.Trim();
            string category = comboBoxcategoryVU.Text.Trim();
            string dateVU = dateTimeDateVU.Text.Trim();
            driver = new Driver(fio[0], fio[1], fio[2], datebirth, numberVU, category, dateVU);

            driver.ValidateDateOfBirth();
            return driver;
        }
        private bool AreDriverFieldsValid()
        {
            // Проверяем каждое поле на заполненность
            if (string.IsNullOrWhiteSpace(textBoxFIOdriver.Text) ||
                string.IsNullOrWhiteSpace(dateTimeDatebirth.Text) ||
                string.IsNullOrWhiteSpace(textBoxNumberVU.Text) ||
                string.IsNullOrWhiteSpace(comboBoxcategoryVU.Text) ||
                string.IsNullOrWhiteSpace(dateTimeDateVU.Text))
            {
                return false; // Одно из полей не заполнено
            }

            return true; // Все поля заполнены
        }
        private void buttonAddInDriver_Click(object sender, EventArgs e)
        {
            try
            {
                // Проверяем, что все поля заполнены
                if (!AreDriverFieldsValid())
                {
                    MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка");
                    return; // Прерываем выполнение метода
                }
                Driver newDriver = null;

                if (replace == 1)
                {
                    driver = UpdatedDriver();
                    form.GetDriver()[index] = driver;

                    replace = 0;
                }
                else
                {
                    newDriver = UpdatedDriver();

                    form.GetDriver().Add(newDriver);

                    MessageBox.Show("Водитель добавлен успешно!", "Информация");
                }
                ClearFieldsDriver();
                Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Некорректный ввод данных. Проверьте введённые значения.", "Ошибка");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка");
            }
        }
        private string[] split(string str)
        {
            string[] fio = new string[3];
            string surname = "", name = "", middlename = "";
            int s = 0, p = 0;
            foreach (char c in str)
            {
                if (c == ' ' && s == 0)
                {
                    s++;
                }
                else if (c == ' ' && p == 0)
                {
                    p++;
                }
                else
                {
                    if (s == 0)
                    {
                        surname += c;
                    }
                    else if (p == 0)
                    {
                        name += c;
                    }
                    else
                    {
                        middlename += c;
                    }
                }
            }
            fio[0] = surname;
            fio[1] = name;
            fio[2] = middlename;
            return fio;
        }
        private void ClearFieldsDriver()
        {
            textBoxFIOdriver.Clear();
            textBoxNumberVU.Clear();
            comboBoxcategoryVU.SelectedIndex = -1;
            comboBoxcategoryVU.SelectedIndex = -1;
        }
    }
}