using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace CourseWork
{
    public partial class FormOwner : Form
    {
        private DataGridView dataGridViewOwner = new DataGridView();
        private Form1 form;
        Avto avtoOwn = null;
        private Owner newowner = null;
        private Fowner fowner = null;
        private Yuowner yuowner = null;
        private int replace = 0;
        private int index = 0;
        public FormOwner(Form1 form1)
        {
            InitializeComponent();
            form = form1;
            foreach (Avto avto in form.GetAvto())
            {
                if (avto.Index == 0)
                {
                    comboBoxavtoinowner.Items.Add($"{avto.Registrationnumber}");
                }
            }
        }
        public FormOwner(Form1 form1, Fowner fow, int rowIndex, Avto avtoOwner)
        {
            InitializeComponent();
            form = form1;
            fowner = fow;
            index = rowIndex;
            replace = 1;
            avtoOwn = avtoOwner;
            foreach (Avto avto in form.GetAvto())
            {
                if (avto.Index == 0)
                {
                    comboBoxavtoinowner.Items.Add($"{avto.Registrationnumber}");
                }
            }
            comboBoxavtoinowner.Items.Add($"{avtoOwn.Registrationnumber}");
            comboBoxowner.Text = "Физическое лицо";
            comboBoxavtoinowner.Text = fowner.av.Registrationnumber;
            textBoxFIOowner.Text = fowner.fio.surname + " " + fowner.fio.name + " " + fowner.fio.middlename;
            textBoxcity.Text = fowner.City;
            textBoxstreet.Text = fowner.Street;
            textBoxhouse.Text = fowner.House;
            textBoxflat.Text = fowner.Flat;
            textBoxphonenumber.Text = fowner.Phonenumber.ToString();
            textBoxpassportseries.Text = fowner.Passportseries;
            textBoxpassportnumber.Text = fowner.Passportnumber;
            dateTimeDatePassport.Text = fowner.datePassport.ToString();
            textBoxpassportorganization.Text = fowner.Passportorganization;
        }
        public FormOwner(Form1 form1, Yuowner yuow, int rowIndex, Avto avtoOwner)
        {
            InitializeComponent();
            form = form1;
            yuowner = yuow;
            index = rowIndex;
            replace = 1;
            avtoOwn = avtoOwner;
            foreach (Avto avto in form.GetAvto())
            {
                if (avto.Index == 0)
                {
                    comboBoxavtoinowner.Items.Add($"{avto.Registrationnumber}");
                }
            }
            comboBoxavtoinowner.Items.Add($"{avtoOwn.Registrationnumber}");
            comboBoxowner.Text = "Юридическое лицо";
            comboBoxavtoinowner.Text = yuowner.av.Registrationnumber;
            textBoxorganizationname.Text = yuowner.Organizationname;
            textBoxCityYU.Text = yuowner.City;
            textBoxStreetYU.Text = yuowner.Street;
            textBoxHouseYU.Text = yuowner.House;
            textBoxFlatYU.Text = yuowner.Flat;
            textBoxFIOruk.Text = yuowner.fio.surname + " " + yuowner.fio.name + " " + yuowner.fio.middlename;
            textBoxphonenumberruk.Text = yuowner.Phonenumber.ToString();
        }
        private bool AreOwnerFieldsValid()
        {
            // Проверяем, заполнены ли все необходимые поля для владельца
            if (comboBoxowner.SelectedIndex < 0)
            {
                return false; // Не выбран тип владельца
            }
            string transport = comboBoxavtoinowner.Text.Trim();
            if (string.IsNullOrEmpty(transport))
            {
                return false; // Не выбран автомобиль
            }
            if (comboBoxowner.SelectedIndex == 0) // Если это физическое лицо
            {
                string FaImOt = textBoxFIOowner.Text.Trim();
                if (string.IsNullOrEmpty(FaImOt) ||
                    string.IsNullOrEmpty(textBoxcity.Text.Trim()) ||
                    string.IsNullOrEmpty(textBoxstreet.Text.Trim()) ||
                    string.IsNullOrEmpty(textBoxhouse.Text.Trim()) ||
                    string.IsNullOrEmpty(textBoxphonenumber.Text.Trim()) ||
                    string.IsNullOrEmpty(textBoxpassportseries.Text.Trim()) ||
                    string.IsNullOrEmpty(textBoxpassportnumber.Text.Trim()) ||
                    string.IsNullOrEmpty(dateTimeDatePassport.Text.Trim()) ||
                    string.IsNullOrEmpty(textBoxpassportorganization.Text.Trim()))
                {
                    return false; // Одно из полей не заполнено
                }
            }
            else if (comboBoxowner.SelectedIndex == 1) // Если это юридическое лицо
            {
                string organizationname = textBoxorganizationname.Text.Trim();
                if (string.IsNullOrEmpty(organizationname) ||
                    string.IsNullOrEmpty(textBoxCityYU.Text.Trim()) ||
                    string.IsNullOrEmpty(textBoxStreetYU.Text.Trim()) ||
                    string.IsNullOrEmpty(textBoxHouseYU.Text.Trim()) ||
                    string.IsNullOrEmpty(textBoxphonenumberruk.Text.Trim()))
                {
                    return false; // Одно из полей не заполнено
                }
            }
            return true; // Все поля заполнены
        }
        public Fowner UpdatedFowner()
        {
            Avto av = null;
            string transport = comboBoxavtoinowner.Text.Trim();
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
            string[] fio = new string[3];
            string FaImOt = textBoxFIOowner.Text.Trim();
            fio = split(FaImOt);
            string city = textBoxcity.Text.Trim();
            string street = textBoxstreet.Text.Trim();
            string house = textBoxhouse.Text.Trim();
            string flat = textBoxflat.Text.Trim();
            ulong phonenumber = ulong.Parse(textBoxphonenumber.Text);
            string passportseries = textBoxpassportseries.Text.Trim();
            string passportnumber = textBoxpassportnumber.Text.Trim();
            string datePassport = dateTimeDatePassport.Text.Trim();
            string passportorganization = textBoxpassportorganization.Text.Trim();
            fowner = new Fowner(av, city, street, house, flat, fio[0], fio[1], fio[2], phonenumber, passportseries, passportnumber, datePassport, passportorganization);

            return fowner;
        }
        public Yuowner UpdatedYuowner()
        {
            Avto av = null;
            string transport = comboBoxavtoinowner.Text.Trim();
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
            string organizationname = textBoxorganizationname.Text.Trim();
            string city = textBoxCityYU.Text.Trim();
            string street = textBoxStreetYU.Text.Trim();
            string house = textBoxHouseYU.Text.Trim();
            string flat = textBoxFlatYU.Text.Trim();
            string[] fio = new string[3];
            string FaImOt = textBoxFIOruk.Text.Trim();
            fio = split(FaImOt);
            ulong phonenumber = ulong.Parse(textBoxphonenumberruk.Text);
            yuowner = new Yuowner(av, organizationname, city, street, house, flat, fio[0], fio[1], fio[2], phonenumber);

            return yuowner;
        }
        private void buttonAddInOwner_Click(object sender, EventArgs e)
        {
            try
            {
                if (!AreOwnerFieldsValid())
                {
                    MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка");
                }
                Owner newOwner = null;
                if (comboBoxowner.SelectedIndex == 0)
                {
                    Fowner newFowner = null;
                    if (replace == 1)
                    {
                        fowner = UpdatedFowner();
                        form.GetFowner()[index] = fowner;
                    }
                    else
                    {
                        newFowner = UpdatedFowner();
                        newOwner = fowner;

                    }
                }
                else if (comboBoxowner.SelectedIndex == 1)
                {
                    Yuowner newYuowner = null;
                    if (replace == 1)
                    {
                        yuowner = UpdatedYuowner();
                        form.GetYuowner()[index] = yuowner;
                    }
                    else
                    {
                        newYuowner = UpdatedYuowner();
                        newOwner = newYuowner;
                    }
                }
                if (replace != 1)
                {
                    if (newOwner != null)
                    {
                        if (newOwner is Fowner)
                        {
                            form.GetFowner().Add(newOwner as Fowner);

                        }
                        else if (newOwner is Yuowner)
                        {

                            form.GetYuowner().Add(newOwner as Yuowner);

                        }
                        MessageBox.Show("Владелец добавлен успешно!", "Информация");
                        ClearFieldsOwner();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Ошибка при добавлении владельца. Выберите корректный тип владельца.", "Ошибка");
                    }
                }
                else Close();
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
        private void ClearFieldsOwner()
        {
            comboBoxowner.SelectedIndex = -1;
            textBoxFIOowner.Clear();
            textBoxcity.Clear();
            textBoxstreet.Clear();
            textBoxhouse.Clear();
            textBoxflat.Clear();
            textBoxphonenumber.Clear();
            textBoxpassportnumber.Clear();
            textBoxpassportseries.Clear();
            textBoxpassportorganization.Clear();
            textBoxorganizationname.Clear();
            textBoxFIOruk.Clear();
            textBoxphonenumberruk.Clear();
            comboBoxavtoinowner.SelectedIndex = -1;
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
    }
}