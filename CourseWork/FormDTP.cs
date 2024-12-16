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
    public partial class FormDTP : Form
    {
        private DataGridView dataGridViewDTP = new DataGridView();
        private Form1 form;
        private Accident accident = null;
        private int replace = 0;
        private int index = 0;
        List<Accident> ListAccident = new List<Accident>();
        List<string> part = new List<string>();
        public FormDTP(Form1 form1)
        {
            InitializeComponent();
            form = form1;
            foreach (Avto avto in form.GetAvto())
            {
                comboBoxpartDtpAvto.Items.Add($"{avto.Registrationnumber}");
            }
            foreach (Driver driver in form.GetDriver())
            {
                comboBoxpartDtpDriver.Items.Add($"{driver.fio.surname} {driver.fio.name} {driver.fio.middlename}");
            }
        }
        public FormDTP(Form1 form1, Accident accid, int rowIndex)
        {
            InitializeComponent();
            form = form1;
            accident = accid;
            replace = 1;
            index = rowIndex;
            string[] accident_items = Split(accident.participant);
            foreach (Avto avto in form.GetAvto())
            {
                comboBoxpartDtpAvto.Items.Add($"{avto.Registrationnumber}");
            }
            foreach (Driver driver in form.GetDriver())
            {
                comboBoxpartDtpDriver.Items.Add($"{driver.fio.surname} {driver.fio.name} {driver.fio.middlename}");
            }
            for (int i = 0; i < accident_items.Length - 3; i += 4)
            {
                part.Add(accident_items[i] + " " + accident_items[i + 3]);
            }
            UpdatelistBoxPartDTP();
            dateTimedateDTP.Text = accident.dateDTP;
            textBoxplaceDTP.Text = accident.Place;
            comboBoxseverityDTP.Text = accident.Severity;
            textBoxFIOinspDTP.Text = accident.fio.surname + " " + accident.fio.name + " " + accident.fio.middlename;
            richTextBoxDescriptions.Text = accident.Description;
        }
        public Accident UpdatedAccident()
        {
            string dateDTP = dateTimedateDTP.Text.Trim();
            string place = textBoxplaceDTP.Text.Trim();
            string participant = "";
            foreach (string s in listBoxPartDTP.Items)
            {
                participant += s + " ";
            }
            string severity = comboBoxseverityDTP.Text.Trim();
            string[] fio = new string[3];
            string FaImOt = textBoxFIOinspDTP.Text.Trim();
            fio = split(FaImOt);
            string description = richTextBoxDescriptions.Text.Trim();
            accident = new Accident(dateDTP, place, participant, severity, fio[0], fio[1], fio[2], description);

            return accident;
        }
        private bool AreAccidentFieldsValid()
        {
            // Проверяем каждое поле на заполненность
            if (string.IsNullOrWhiteSpace(dateTimedateDTP.Text) ||
                string.IsNullOrWhiteSpace(textBoxplaceDTP.Text) ||
                listBoxPartDTP.Items.Count == 0 || // Проверяем, что есть хотя бы один участник
                string.IsNullOrWhiteSpace(comboBoxseverityDTP.Text) ||
                string.IsNullOrWhiteSpace(textBoxFIOinspDTP.Text) ||
                string.IsNullOrWhiteSpace(richTextBoxDescriptions.Text))
            {
                return false; // Одно из полей не заполнено
            }

            return true; // Все поля заполнены
        }
        private void buttonAddInDTP_Click(object sender, EventArgs e)
        {
            try
            {
                if (!AreAccidentFieldsValid())
                {
                    MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка");
                    return; // Завершаем выполнение метода, если поля не заполнены
                }

                Accident newAccident;

                if (replace == 1)
                {
                    newAccident = UpdatedAccident();
                    form.GetAccident()[index] = newAccident; // Исправлено: обновляем новый акцидент
                }
                else
                {
                    newAccident = UpdatedAccident();
                    form.GetAccident().Add(newAccident);
                }

                // Вывод сообщения об успешном добавлении данных
                MessageBox.Show("Информация о ДТП добавлена успешно!", "Информация");
                ClearFieldsDTP();
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
        private void ClearFieldsDTP()
        {
            textBoxplaceDTP.Clear();
            listBoxPartDTP.ClearSelected();
            comboBoxseverityDTP.SelectedIndex = -1;
            textBoxFIOinspDTP.Clear();
            richTextBoxDescriptions.Clear();
        }
        private string[] Split(string str)
        {
            string[] SplitString = new string[100];
            int cnt = 0, check = 0;
            foreach (char c in str)
            {
                if (c == ' ' && check != cnt)
                {
                    check = cnt;
                    cnt++;
                    continue;
                }
                else
                {
                    SplitString[cnt] += c;
                }
            }
            return SplitString;
        }
        private string[] split(string str)
        {
            string[] SplitString = new string[4];
            string surname = "", name = "", middlename = "", avto = "";
            int s = 0, p = 0, k = 0;
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
                else if (c == ' ' && k == 0)
                {
                    k++;
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
                    else if (k == 0)
                    {
                        middlename += c;
                    }
                    else
                    {
                        avto += c;
                    }
                }
            }
            SplitString[0] = surname;
            SplitString[1] = name;
            SplitString[2] = middlename;
            SplitString[3] = avto;
            return SplitString;
        }
        private void buttonAddpartDTP_Click(object sender, EventArgs e)
        {
            try
            {
                string participants = "";
                string driver = comboBoxpartDtpDriver.Text.Trim();
                string registrationnumber = comboBoxpartDtpAvto.Text.Trim();
                participants += driver + " " + registrationnumber;
                if (string.IsNullOrEmpty(driver) || string.IsNullOrEmpty(registrationnumber))
                {
                    throw new Exception("Необходимо заполнить значения в обоих полях");
                }
                part.Add(participants);
                comboBoxpartDtpDriver.Items.Remove(driver); comboBoxpartDtpAvto.Items.Remove(registrationnumber);
                UpdatelistBoxPartDTP();
                MessageBox.Show("Участник ДТП добавлен успешно!", "Информация");
                ClearFieldsPartDTP();
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
        private void buttonDeletepartDTP_Click(object sender, EventArgs e)
        {
            try
            {
                // Проверяем, есть ли выбранный элемент
                if (listBoxPartDTP.SelectedItem == null)
                {
                    throw new Exception("Необходимо выбрать элемент для удаления.");
                }
                // Удаляем выбранный элемент из списка
                part.Remove(listBoxPartDTP.SelectedItem.ToString());
                UpdatelistBoxPartDTP();

                MessageBox.Show("Элемент успешно удалён.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка");
            }
        }
        private void UpdatelistBoxPartDTP()
        {
            listBoxPartDTP.Items.Clear();
            foreach (string a in part)
            {
                listBoxPartDTP.Items.Add(a);
            }
        }
        private void ClearFieldsPartDTP()
        {
            comboBoxpartDtpDriver.SelectedIndex = -1;
            comboBoxpartDtpAvto.SelectedIndex = -1;
        }
    }
}