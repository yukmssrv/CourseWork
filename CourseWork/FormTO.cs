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
    public partial class FormTO : Form
    {
        private DataGridView dataGridViewTO = new DataGridView();
        List<Avto> ListAvto = new List<Avto>();
        private Form1 form;
        private Technical_Inspection technical_Inspection = null;
        private int replace = 0;
        private int index = 0;
        public FormTO(Form1 form1)
        {
            InitializeComponent();
            form = form1;
            foreach (Avto avto in form.GetAvto())
            {
                comboBoxavtointo.Items.Add($"{avto.Registrationnumber}");
            }
        }
        public FormTO(Form1 form1, Technical_Inspection to, int rowIndex)
        {
            InitializeComponent();
            form = form1;
            technical_Inspection = to;
            index = rowIndex;
            replace = 1;
            foreach (Avto avto in form.GetAvto())
            {
                if (avto.Index == 0)
                {
                    comboBoxavtointo.Items.Add($"{avto.Registrationnumber}");
                }
            }
            comboBoxavtointo.Items.Add($"{technical_Inspection.av.Registrationnumber}");
            comboBoxavtointo.SelectedIndex = comboBoxavtointo.Items.IndexOf(technical_Inspection.av.Registrationnumber);
            dateTimedateTO.Text = technical_Inspection.dateTO;
            textBoxFIOinsp.Text = technical_Inspection.fio.surname + " " + technical_Inspection.fio.name + " " + technical_Inspection.fio.middlename;
            textBoxTOprobeg.Text = technical_Inspection.Mileage.ToString();
            textBoxTOpay.Text = technical_Inspection.Pay.ToString();
            textBoxTOpaysign.Text = technical_Inspection.Paysign.ToString();
        }
        public Technical_Inspection UpdatedTechnical_Inspection()
        {
            Avto av = null;
            string transport = comboBoxavtointo.Text.Trim();
            if (string.IsNullOrEmpty(transport))
            {
                throw new Exception("Выберите автомобиль");
            }
            foreach (Avto avto in form.GetAvto())
            {
                if (avto.Registrationnumber == transport)
                {
                    av = avto;
                    break;
                }
            }
            string dateTO = dateTimedateTO.Text.Trim();
            string[] fio = new string[3];
            string FaImOt = textBoxFIOinsp.Text.Trim();
            fio = split(FaImOt);
            int mileage = int.Parse(textBoxTOprobeg.Text.Trim());
            int pay = int.Parse(textBoxTOpay.Text.Trim());
            int paysign = int.Parse(textBoxTOpaysign.Text.Trim());
            technical_Inspection = new Technical_Inspection(av, dateTO, fio[0], fio[1], fio[2], mileage, pay, paysign);

            return technical_Inspection;
        }
        private bool AreTechnicalInspectionFieldsValid()
        {
            // Проверяем каждое поле на заполненность
            if (string.IsNullOrWhiteSpace(comboBoxavtointo.Text) ||
                string.IsNullOrWhiteSpace(dateTimedateTO.Text) ||
                string.IsNullOrWhiteSpace(textBoxFIOinsp.Text) ||
                string.IsNullOrWhiteSpace(textBoxTOprobeg.Text) ||
                string.IsNullOrWhiteSpace(textBoxTOpay.Text) ||
                string.IsNullOrWhiteSpace(textBoxTOpaysign.Text))
            {
                return false; // Одно из полей не заполнено
            }
            return true; // Все поля заполнены
        }
        private void buttonAddInTO_Click(object sender, EventArgs e)
        {
            try
            {
                // Проверяем, что все поля заполнены
                if (!AreTechnicalInspectionFieldsValid())
                {
                    MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка");
                    return; // Прерываем выполнение метода
                }
                Technical_Inspection newTechnical_Inspection = null;
                if (replace == 1)
                {
                    newTechnical_Inspection = UpdatedTechnical_Inspection();
                    form.GetTechnical_Inspection()[index] = technical_Inspection;
                }
                else
                {
                    newTechnical_Inspection = UpdatedTechnical_Inspection();

                    form.GetTechnical_Inspection().Add(newTechnical_Inspection);

                    MessageBox.Show("Информаци о тех. осмотре добавлена успешно!", "Информация");
                }
                ClearFieldsTO();
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
        private void ClearFieldsTO()
        {
            comboBoxavtointo.SelectedIndex = -1;
            textBoxFIOinsp.Clear();
            textBoxTOprobeg.Clear();
            textBoxTOpay.Clear();
            textBoxTOpaysign.Clear();
        }
    }
}