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
    public partial class FormAvto : Form
    {
        private DataGridView dataGridViewAvto = new DataGridView();
        private Form1 form;
        private Avto avto = null;
        private int replace = 0;
        private int index = 0;
        public FormAvto(Form1 form1)
        {
            InitializeComponent();
            form = form1;
        }
        public FormAvto(Form1 form1, Avto av, int rowIndex)
        {
            InitializeComponent();
            form = form1;
            avto = av;
            index = rowIndex;
            replace = 1;
            textBoxregistrationnumber.Text = avto.Registrationnumber;
            textBoxname.Text = avto.Name;
            textBoxfirma.Text = avto.Firma;
            textBoxbodynumber.Text = avto.Bodynumber;
            textBoxchassisnumer.Text = avto.Chassisnumber;
            textBoxenginenumber.Text = avto.Enginenumber;
            textBoxbodymodel.Text = avto.Bodymodel;
            textBoxcolor.Text = avto.Color;
            textBoxvolume.Text = avto.Volume.ToString();
            textBoxpower.Text = avto.Power.ToString();
            comboBoxwheel.Text = avto.Wheel;
            comboBoxdrivewheel.Text = avto.Drivewheel;
            textBoxyearv.Text = avto.Yearv.ToString();
            dateTimeDateucheta.Text = avto.Dateofregistration;
            textBoxtehtalonnumber.Text = avto.Tehtalonumber;
            dateTimeDatetehtalon.Text = avto.Datetehtalon;
            textBoxyeartax.Text = avto.Yeartax.ToString();
        }
        public Avto UpdatedAvto()
        {
            string registrationnumber = textBoxregistrationnumber.Text.Trim();
            string name = textBoxname.Text.Trim();
            string firma = textBoxfirma.Text.Trim();
            string bodynumber = textBoxbodynumber.Text.Trim();
            string chassisnumber = textBoxchassisnumer.Text.Trim();
            string enginenumber = textBoxenginenumber.Text.Trim();
            string bodymodel = textBoxbodymodel.Text.Trim();
            string color = textBoxcolor.Text.Trim();
            string volume = textBoxvolume.Text.Trim();
            int power = int.Parse(textBoxpower.Text.Trim());
            string wheel = comboBoxwheel.Text.Trim();
            string drivewheel = comboBoxdrivewheel.Text.Trim();
            int yearv = int.Parse(textBoxyearv.Text.Trim());
            string dateofregistration = dateTimeDateucheta.Text.Trim();
            string tehtalonumber = textBoxtehtalonnumber.Text.Trim();
            string datetehtalon = dateTimeDatetehtalon.Text.Trim();
            int yeartax = int.Parse(textBoxyeartax.Text.Trim());
            avto = new Avto(registrationnumber, name, firma, bodynumber, chassisnumber, enginenumber, bodymodel, color, volume, power, wheel, drivewheel, yearv, dateofregistration, tehtalonumber, datetehtalon, yeartax);
            avto.ValidateDates();

            return avto;
        }
        private bool AreFieldsValid()
        {
            // Проверяем каждое поле на заполненность
            if (string.IsNullOrWhiteSpace(textBoxregistrationnumber.Text) ||
                string.IsNullOrWhiteSpace(textBoxname.Text) ||
                string.IsNullOrWhiteSpace(textBoxfirma.Text) ||
                string.IsNullOrWhiteSpace(textBoxbodynumber.Text) ||
                string.IsNullOrWhiteSpace(textBoxchassisnumer.Text) ||
                string.IsNullOrWhiteSpace(textBoxenginenumber.Text) ||
                string.IsNullOrWhiteSpace(textBoxbodymodel.Text) ||
                string.IsNullOrWhiteSpace(textBoxcolor.Text) ||
                string.IsNullOrWhiteSpace(textBoxvolume.Text) ||
                string.IsNullOrWhiteSpace(textBoxpower.Text) ||
                comboBoxwheel.SelectedIndex == -1 ||
                comboBoxdrivewheel.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(textBoxyearv.Text) ||
                string.IsNullOrWhiteSpace(textBoxtehtalonnumber.Text) ||
                string.IsNullOrWhiteSpace(textBoxyeartax.Text))
            {
                return false; // Одно из полей не заполнено
            }

            return true; // Все поля заполнены
        }
        private void buttonAddInAvto_Click(object sender, EventArgs e)
        {
            try
            {
                // Проверяем, что все поля заполнены
                if (!AreFieldsValid())
                {
                    MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка");
                    return; // Прерываем выполнение метода
                }
                Avto newAvto = null;
                if (replace == 1)
                {
                    avto = UpdatedAvto();
                    form.GetAvto()[index] = avto;

                }
                else
                {
                    newAvto = UpdatedAvto();

                    form.GetAvto().Add(newAvto);

                    MessageBox.Show("Автомобиль добавлен успешно!", "Информация");
                }
                ClearFields();
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
        private void ClearFields()
        {
            textBoxregistrationnumber.Clear();
            textBoxname.Clear();
            textBoxfirma.Clear();
            textBoxbodynumber.Clear();
            textBoxchassisnumer.Clear();
            textBoxenginenumber.Clear();
            textBoxbodymodel.Clear();
            textBoxcolor.Clear();
            textBoxvolume.Clear();
            textBoxpower.Clear();
            comboBoxwheel.SelectedIndex = -1;
            comboBoxdrivewheel.SelectedIndex = -1;
            textBoxyearv.Clear();
            textBoxtehtalonnumber.Clear();
            textBoxyeartax.Clear();
        }
    }
}


