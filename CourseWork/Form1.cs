using Newtonsoft.Json;
using System.Diagnostics.Contracts;
using System.IO;
using System.Numerics;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Windows.Forms;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace CourseWork
{
    public partial class Form1 : Form
    {
        private List<Avto> ListAvto = new List<Avto>();
        private List<Owner> ListOwner = new List<Owner>();
        private List<Fowner> ListFowner = new List<Fowner>();
        private List<Yuowner> ListYuowner = new List<Yuowner>();
        private List<Driver> ListDriver = new List<Driver>();
        private List<Technical_Inspection> ListTO = new List<Technical_Inspection>();
        private List<Accident> ListAccident = new List<Accident>();
        private List<string> listPartDTP = new List<string>();

        private void SerializeData()
        {
            byte[] jsonUtf8Bytes = JsonSerializer.SerializeToUtf8Bytes(ListAvto);
            File.WriteAllBytes("ListAvto.json", jsonUtf8Bytes);
            jsonUtf8Bytes = JsonSerializer.SerializeToUtf8Bytes(ListFowner);
            File.WriteAllBytes("ListFowner.json", jsonUtf8Bytes);
            jsonUtf8Bytes = JsonSerializer.SerializeToUtf8Bytes(ListYuowner);
            File.WriteAllBytes("ListYuowner.json", jsonUtf8Bytes);
            jsonUtf8Bytes = JsonSerializer.SerializeToUtf8Bytes(ListDriver);
            File.WriteAllBytes("ListDriver.json", jsonUtf8Bytes);
            jsonUtf8Bytes = JsonSerializer.SerializeToUtf8Bytes(ListTO);
            File.WriteAllBytes("ListTO.json", jsonUtf8Bytes);
            jsonUtf8Bytes = JsonSerializer.SerializeToUtf8Bytes(ListAccident);
            File.WriteAllBytes("ListAccident.json", jsonUtf8Bytes);

        }
        // Метод для десериализации
        private void DeserializeData()
        {
            byte[] jsonUtf8Bytes = File.ReadAllBytes("ListAvto.json");
            var readOnlySpan = new ReadOnlySpan<byte>(jsonUtf8Bytes);
            List<Avto> l_avto = JsonSerializer.Deserialize<List<Avto>>(readOnlySpan)!;
            ListAvto = l_avto;

            jsonUtf8Bytes = File.ReadAllBytes("ListFowner.json");
            readOnlySpan = new ReadOnlySpan<byte>(jsonUtf8Bytes);
            List<Fowner> l_fowner = JsonSerializer.Deserialize<List<Fowner>>(readOnlySpan)!;
            ListFowner = l_fowner;

            jsonUtf8Bytes = File.ReadAllBytes("ListYuowner.json");
            readOnlySpan = new ReadOnlySpan<byte>(jsonUtf8Bytes);
            List<Yuowner> l_yuowner = JsonSerializer.Deserialize<List<Yuowner>>(readOnlySpan)!;
            ListYuowner = l_yuowner;

            jsonUtf8Bytes = File.ReadAllBytes("ListDriver.json");
            readOnlySpan = new ReadOnlySpan<byte>(jsonUtf8Bytes);
            List<Driver> l_driver = JsonSerializer.Deserialize<List<Driver>>(readOnlySpan)!;
            ListDriver = l_driver;

            jsonUtf8Bytes = File.ReadAllBytes("ListTO.json");
            readOnlySpan = new ReadOnlySpan<byte>(jsonUtf8Bytes);
            List<Technical_Inspection> l_to = JsonSerializer.Deserialize<List<Technical_Inspection>>(readOnlySpan)!;
            ListTO = l_to;

            jsonUtf8Bytes = File.ReadAllBytes("ListAccident.json");
            readOnlySpan = new ReadOnlySpan<byte>(jsonUtf8Bytes);
            List<Accident> l_accident = JsonSerializer.Deserialize<List<Accident>>(readOnlySpan)!;
            ListAccident = l_accident;
        }
        public List<Avto> GetAvto()
        {
            return ListAvto;
        }
        public List<Fowner> GetFowner()
        {
            return ListFowner;
        }
        public List<Yuowner> GetYuowner()
        {
            return ListYuowner;
        }
        public List<Driver> GetDriver()
        {
            return ListDriver;
        }
        public List<Technical_Inspection> GetTechnical_Inspection()
        {
            return ListTO;
        }
        public List<Accident> GetAccident()
        {
            return ListAccident;
        }
        public List<string> GetPartDTP()
        {
            return listPartDTP;
        }
        public Form1()
        {
            InitializeComponent();
        }
        /// 
        /// АВТОМОБИЛЬ
        /// 
        public void UpdateAvto()
        {
            dataGridViewAvto.Rows.Clear();
            foreach (Avto newAvto in ListAvto)
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dataGridViewAvto);

                newRow.Cells[dataGridViewAvto.Columns["Columnregistrationnumber"].Index].Value = newAvto.Registrationnumber;
                newRow.Cells[dataGridViewAvto.Columns["ColumnName"].Index].Value = newAvto.Name;
                newRow.Cells[dataGridViewAvto.Columns["ColumnFirma"].Index].Value = newAvto.Firma;
                newRow.Cells[dataGridViewAvto.Columns["ColumnBodynumber"].Index].Value = newAvto.Bodynumber;
                newRow.Cells[dataGridViewAvto.Columns["ColumnChassisnumber"].Index].Value = newAvto.Chassisnumber;
                newRow.Cells[dataGridViewAvto.Columns["ColumnEnginenumber"].Index].Value = newAvto.Enginenumber;
                newRow.Cells[dataGridViewAvto.Columns["ColumnBodymodel"].Index].Value = newAvto.Bodymodel;
                newRow.Cells[dataGridViewAvto.Columns["ColumnColor"].Index].Value = newAvto.Color;
                newRow.Cells[dataGridViewAvto.Columns["ColumnVolume"].Index].Value = newAvto.Volume;
                newRow.Cells[dataGridViewAvto.Columns["ColumnPower"].Index].Value = newAvto.Power;
                newRow.Cells[dataGridViewAvto.Columns["ColumnWheel"].Index].Value = newAvto.Wheel;
                newRow.Cells[dataGridViewAvto.Columns["ColumnDrivewheel"].Index].Value = newAvto.Drivewheel;
                newRow.Cells[dataGridViewAvto.Columns["ColumnYearv"].Index].Value = newAvto.Yearv;
                newRow.Cells[dataGridViewAvto.Columns["ColumnDateofregistration"].Index].Value = newAvto.Dateofregistration;
                newRow.Cells[dataGridViewAvto.Columns["Columntehtalonnumber"].Index].Value = newAvto.Tehtalonumber;
                newRow.Cells[dataGridViewAvto.Columns["Columndatetehtalon"].Index].Value = newAvto.Datetehtalon;
                newRow.Cells[dataGridViewAvto.Columns["ColumnYeartax"].Index].Value = newAvto.Yeartax;

                dataGridViewAvto.Rows.Add(newRow);
            }
        }
        private void buttonAddAvto_Click(object sender, EventArgs e)
        {
            int i = ListAvto.Count;
            FormAvto form2 = new FormAvto(this);
            form2.ShowDialog();

            if (ListAvto.Count > i)
            {
                UpdateAvto();
            }
        }
        private void buttonChangeAvto_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewAvto.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridViewAvto.SelectedRows[0]; // Получаем выбранную строку
                    int rowIndex = dataGridViewAvto.Rows.IndexOf(selectedRow);
                    if (ListAvto != null && rowIndex >= 0 && rowIndex < ListAvto.Count)// Проверяем, что строка существует в ListAvto
                    {
                        Avto currentAvto = ListAvto[rowIndex]; // Получаем текущий объект Avto из списка
                        FormAvto form2 = new FormAvto(this, currentAvto, rowIndex);
                        form2.ShowDialog();

                        UpdateAvto();

                    }
                    else
                    {
                        MessageBox.Show("Не удалось найти данные для редактирования.", "Ошибка");
                    }
                }
                else
                {
                    MessageBox.Show("Пожалуйста, выберите строку для редактирования.", "Ошибка");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка");
            }
        }
        private void buttonDeleteAvto_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewAvto.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridViewAvto.SelectedRows[0];
                    // Проверка на пустую строку
                    bool rowIsEmpty = selectedRow.Cells.Cast<DataGridViewCell>().All(cell => string.IsNullOrEmpty(cell.Value?.ToString()));
                    if (rowIsEmpty)
                    {
                        MessageBox.Show("Невозможно удалить пустую строку.");
                    }
                    int indexToRemove = dataGridViewAvto.Rows.IndexOf(selectedRow);
                    // Проверка на корректность индекса и существование ListAvto
                    if (ListAvto != null && indexToRemove >= 0 && indexToRemove < ListAvto.Count)
                    {
                        dataGridViewAvto.Rows.Remove(selectedRow);
                        ListAvto.RemoveAt(indexToRemove);
                    }
                    else
                    {
                        MessageBox.Show("Ошибка при удалении строки. Проверьте данные.");
                    }
                }
                else
                {
                    MessageBox.Show("Пожалуйста, выберите строку для удаления.");
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show($"Ошибка при удалении строки: {ex.Message}", "Ошибка");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка");
            }
        }
        private void buttonClearAvto_Click_1(object sender, EventArgs e)
        {
            dataGridViewAvto.Rows.Clear();
            ListAvto.Clear();
        }
        /// 
        /// ВЛАДЕЛЕЦ
        /// 
        public void UpdateFowner()
        {
            dataGridViewFowner.Rows.Clear();
            foreach (Fowner newFowner in ListFowner)
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dataGridViewFowner);

                string FIOOwner = newFowner.fio.surname + " " + newFowner.fio.name + " " + newFowner.fio.middlename;
                string Malliableaddress = newFowner.City + ", " + newFowner.Street + ", " + newFowner.House + ", " + newFowner.Flat;

                newRow.Cells[dataGridViewFowner.Columns["ColumnAvtoInFowner"].Index].Value = newFowner.av.Registrationnumber;
                newRow.Cells[dataGridViewFowner.Columns["ColumnFIOowner"].Index].Value = FIOOwner;
                newRow.Cells[dataGridViewFowner.Columns["ColumnMalliableaddress"].Index].Value = Malliableaddress;
                newRow.Cells[dataGridViewFowner.Columns["ColumnPhonenumber"].Index].Value = newFowner.Phonenumber;
                newRow.Cells[dataGridViewFowner.Columns["ColumnPassportseries"].Index].Value = newFowner.Passportseries;
                newRow.Cells[dataGridViewFowner.Columns["ColumnPassportnumber"].Index].Value = newFowner.Passportnumber;
                newRow.Cells[dataGridViewFowner.Columns["ColumnDatePassport"].Index].Value = newFowner.datePassport;
                newRow.Cells[dataGridViewFowner.Columns["ColumnPassportorganization"].Index].Value = newFowner.Passportorganization;

                dataGridViewFowner.Rows.Add(newRow);
            }
        }
        public void UpdateYuowner()
        {
            dataGridViewYuowner.Rows.Clear();
            foreach (Yuowner newYuowner in ListYuowner)
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dataGridViewYuowner);

                string FIOYuowner = newYuowner.fio.surname + " " + newYuowner.fio.name + " " + newYuowner.fio.middlename;
                string Address = newYuowner.City + ", " + newYuowner.Street + ", " + newYuowner.House + ", " + newYuowner.Flat;

                newRow.Cells[dataGridViewYuowner.Columns["ColumnAvtoInYuowner"].Index].Value = newYuowner.av.Registrationnumber;
                newRow.Cells[dataGridViewYuowner.Columns["ColumnOrganizationname"].Index].Value = newYuowner.Organizationname;
                newRow.Cells[dataGridViewYuowner.Columns["ColumnAddress"].Index].Value = Address;
                newRow.Cells[dataGridViewYuowner.Columns["ColumnFIOruk"].Index].Value = FIOYuowner;
                newRow.Cells[dataGridViewYuowner.Columns["ColumnPhonenumberruk"].Index].Value = newYuowner.Phonenumber;

                dataGridViewYuowner.Rows.Add(newRow);
            }
        }
        private void buttonAddOwner_Click(object sender, EventArgs e)
        {
            int i = ListFowner.Count;
            int j = ListYuowner.Count;
            FormOwner form3 = new FormOwner(this);
            form3.ShowDialog();
            if (ListFowner.Count > i)
            {
                UpdateFowner();
                ListFowner.Last().av.Index = 1;
            }
            if (ListYuowner.Count > j)
            {
                UpdateYuowner();
                ListYuowner.Last().av.Index = 1;
            }
        }
        private void buttonButtonChangeOwner_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewFowner.SelectedRows.Count > 0 && dataGridViewYuowner.SelectedRows.Count > 0 || (dataGridViewFowner.SelectedRows.Count > 0 && dataGridViewYuowner.SelectedCells.Count > 0) || (dataGridViewYuowner.SelectedRows.Count > 0 && dataGridViewFowner.SelectedCells.Count > 0))
                {
                    MessageBox.Show("Выберите только один элемент\n ПОДСКАЗКА: для снятия выбора зажмите Ctrl+строка", "Ошибка");
                }
                else if (dataGridViewFowner.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridViewFowner.SelectedRows[0];
                    int rowIndex = dataGridViewFowner.Rows.IndexOf(selectedRow);

                    if (ListFowner != null && rowIndex >= 0 && rowIndex < ListFowner.Count)// Проверяем, что строка существует в листе
                    {
                        Fowner currentFowner = ListFowner[rowIndex];// Получаем текущий объект из списка
                        Avto avtoOwner = currentFowner.av;
                        FormOwner form3 = new FormOwner(this, currentFowner, rowIndex, avtoOwner);
                        form3.ShowDialog();

                        UpdateFowner();
                    }
                    else
                    {
                        MessageBox.Show("Не удалось найти данные для редактирования.", "Ошибка");
                    }
                }
                else if (dataGridViewYuowner.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridViewYuowner.SelectedRows[0];
                    int rowIndex = dataGridViewYuowner.Rows.IndexOf(selectedRow);

                    if (ListYuowner != null && rowIndex >= 0 && rowIndex < ListYuowner.Count)
                    {
                        Yuowner currentYuowner = ListYuowner[rowIndex];
                        Avto avtoYuowner = currentYuowner.av;
                        FormOwner form3 = new FormOwner(this, currentYuowner, rowIndex, avtoYuowner);
                        form3.ShowDialog();

                        UpdateYuowner();
                    }
                    else
                    {
                        MessageBox.Show("Не удалось найти данные для редактирования.", "Ошибка");
                    }
                }
                else
                {
                    MessageBox.Show("Пожалуйста, выберите строку для редактирования.", "Ошибка");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка");
            }
        }
        private void buttonDeleteOwner_Click(object sender, EventArgs e)
        {
            try
            {
                // Проверяем, есть ли выбранные строки в dataGridViewFowner или dataGridViewYuowner
                if (dataGridViewFowner.SelectedRows.Count > 0)
                {
                    // Удаляем выбранную строку из dataGridViewFowner
                    DataGridViewRow selectedRow = dataGridViewFowner.SelectedRows[0];
                    // Проверка на пустую строку
                    bool rowIsEmpty = selectedRow.Cells.Cast<DataGridViewCell>().All(cell => string.IsNullOrEmpty(cell.Value?.ToString()));
                    if (rowIsEmpty)
                    {
                        MessageBox.Show("Невозможно удалить пустую строку.");
                        return; // Выходим из метода, если строка пуста
                    }
                    int index = selectedRow.Index;

                    // Удаляем из ListOwner
                    if (ListFowner[index] is Fowner)
                    {
                        ListFowner.RemoveAt(index);
                        dataGridViewFowner.Rows.Remove(selectedRow);
                    }
                }
                else if (dataGridViewYuowner.SelectedRows.Count > 0)
                {
                    // Удаляем выбранную строку из dataGridViewYuowner
                    DataGridViewRow selectedRow = dataGridViewYuowner.SelectedRows[0];
                    // Проверка на пустую строку
                    bool rowIsEmpty = selectedRow.Cells.Cast<DataGridViewCell>().All(cell => string.IsNullOrEmpty(cell.Value?.ToString()));
                    if (rowIsEmpty)
                    {
                        MessageBox.Show("Невозможно удалить пустую строку.");
                        return; // Выходим из метода, если строка пуста
                    }
                    int index = selectedRow.Index;

                    // Удаляем из ListOwner
                    if (ListYuowner[index] is Yuowner)
                    {
                        ListYuowner.RemoveAt(index);
                        dataGridViewYuowner.Rows.Remove(selectedRow);
                    }
                }
                else
                {
                    MessageBox.Show("Пожалуйста, выберите строку для удаления.");
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show($"Ошибка при удалении строки: {ex.Message}", "Ошибка");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка");
            }
        }
        ///
        ///ВОДИТЕЛЬ
        ///
        public void UpdateDriver()
        {
            dataGridViewDriver.Rows.Clear();
            foreach (Driver newDriver in ListDriver)
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dataGridViewDriver);

                string FIODriver = newDriver.fio.surname + " " + newDriver.fio.name + " " + newDriver.fio.middlename;

                newRow.Cells[dataGridViewDriver.Columns["ColumnFIOdriver"].Index].Value = FIODriver;
                newRow.Cells[dataGridViewDriver.Columns["ColumnDatebirth"].Index].Value = newDriver.datebirth;
                newRow.Cells[dataGridViewDriver.Columns["ColumnNumberVU"].Index].Value = newDriver.NumberVU;
                newRow.Cells[dataGridViewDriver.Columns["ColumnCategoryVU"].Index].Value = newDriver.Category;
                newRow.Cells[dataGridViewDriver.Columns["ColumnDateVU"].Index].Value = newDriver.dateVU;

                dataGridViewDriver.Rows.Add(newRow);
            }
        }
        private void buttonAddDriver_Click(object sender, EventArgs e)
        {
            int i = ListDriver.Count;
            FormDriver form4 = new FormDriver(this);
            form4.ShowDialog();
            if (ListDriver.Count > i)
            {
                UpdateDriver();
            }
        }
        private void buttonChangeDriver_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewDriver.SelectedRows.Count > 0)
                {
                    // Получаем выбранную строку
                    DataGridViewRow selectedRow = dataGridViewDriver.SelectedRows[0];
                    int rowIndex = dataGridViewDriver.Rows.IndexOf(selectedRow);

                    if (ListDriver != null && rowIndex >= 0 && rowIndex < ListDriver.Count) // Проверяем, что строка существует в ListDriver
                    {
                        Driver currentDriver = ListDriver[rowIndex];// Получаем текущий объект Driver из списка

                        FormDriver form4 = new FormDriver(this, currentDriver, rowIndex);
                        form4.ShowDialog();

                        UpdateDriver();
                    }
                    else
                    {
                        MessageBox.Show("Не удалось найти данные для редактирования.", "Ошибка");
                    }
                }
                else
                {
                    MessageBox.Show("Пожалуйста, выберите строку для редактирования.", "Ошибка");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка");
            }
        }
        private void buttonDeleteDriver_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewDriver.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridViewDriver.SelectedRows[0];

                    // Проверка на пустую строку
                    bool rowIsEmpty = selectedRow.Cells.Cast<DataGridViewCell>().All(cell => string.IsNullOrEmpty(cell.Value?.ToString()));
                    if (rowIsEmpty)
                    {
                        MessageBox.Show("Невозможно удалить пустую строку.");
                        return; // Выходим из метода, если строка пуста
                    }

                    int indexToRemove = dataGridViewDriver.Rows.IndexOf(selectedRow);

                    // Проверка на корректность индекса и существование ListDriver
                    if (ListDriver != null && indexToRemove >= 0 && indexToRemove < ListDriver.Count)
                    {
                        ListDriver.RemoveAt(indexToRemove); // Удаляем из списка
                        dataGridViewDriver.Rows.Remove(selectedRow); // Удаляем из DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Ошибка при удалении строки. Проверьте данные."); // Более общий вариант сообщения об ошибке
                    }
                }
                else
                {
                    MessageBox.Show("Пожалуйста, выберите строку для удаления.");
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show($"Ошибка при удалении строки: {ex.Message}", "Ошибка");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка");
            }
        }
        private void buttonClearDriver_Click(object sender, EventArgs e)
        {
            dataGridViewDriver.Rows.Clear();
            ListDriver.Clear();
        }
        ///
        ///ТЕХ.ОСМОТР
        ///
        public void UpdateTO()
        {
            dataGridViewTO.Rows.Clear();
            foreach (Technical_Inspection newTechnical_Inspection in ListTO)
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dataGridViewTO);

                string FIOinsp = newTechnical_Inspection.fio.surname + " " + newTechnical_Inspection.fio.name + " " + newTechnical_Inspection.fio.middlename;

                newRow.Cells[dataGridViewTO.Columns["ColumnAvtoInTO"].Index].Value = newTechnical_Inspection.av.Registrationnumber;
                newRow.Cells[dataGridViewTO.Columns["ColumnDateTO"].Index].Value = newTechnical_Inspection.dateTO;
                newRow.Cells[dataGridViewTO.Columns["ColumnFIOinsp"].Index].Value = FIOinsp;
                newRow.Cells[dataGridViewTO.Columns["ColumnMileage"].Index].Value = newTechnical_Inspection.Mileage;
                newRow.Cells[dataGridViewTO.Columns["ColumnPay"].Index].Value = newTechnical_Inspection.Pay;
                newRow.Cells[dataGridViewTO.Columns["ColumnPaysign"].Index].Value = newTechnical_Inspection.Paysign;

                dataGridViewTO.Rows.Add(newRow);
            }
        }
        private void buttonAddTO_Click(object sender, EventArgs e)
        {
            try
            {
                int i = ListTO.Count;
                FormTO form5 = new FormTO(this);
                form5.ShowDialog();
                if (ListTO.Count > i)
                {
                    UpdateTO();
                    ListTO.Last().av.Index = 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка");
            }
        }
        private void buttonChangeTO_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewTO.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridViewTO.SelectedRows[0];// Получаем выбранную строку
                    int rowIndex = dataGridViewTO.Rows.IndexOf(selectedRow);

                    if (ListTO != null && rowIndex >= 0 && rowIndex < ListTO.Count)// Проверяем, что строка существует в ListTO
                    {
                        Technical_Inspection currentTechnical_Inspection = ListTO[rowIndex];// Получаем текущий объект из списка

                        FormTO form5 = new FormTO(this, currentTechnical_Inspection, rowIndex);
                        form5.ShowDialog();

                        UpdateTO();
                    }
                    else
                    {
                        MessageBox.Show("Не удалось найти данные для редактирования.", "Ошибка");
                    }
                }
                else
                {
                    MessageBox.Show("Пожалуйста, выберите строку для редактирования.", "Ошибка");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка");
            }
        }
        private void buttonDeleteTO_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewTO.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridViewTO.SelectedRows[0];

                    // Проверка на пустую строку
                    bool rowIsEmpty = selectedRow.Cells.Cast<DataGridViewCell>().All(cell => string.IsNullOrEmpty(cell.Value?.ToString()));
                    if (rowIsEmpty)
                    {
                        MessageBox.Show("Невозможно удалить пустую строку.");
                        return;
                    }
                    int indexToRemove = dataGridViewTO.Rows.IndexOf(selectedRow);

                    // Проверка на корректность индекса и существование ListTO
                    if (ListTO != null && indexToRemove >= 0 && indexToRemove < ListTO.Count)
                    {
                        ListTO.RemoveAt(indexToRemove);
                        dataGridViewTO.Rows.Remove(selectedRow);
                    }
                    else
                    {
                        MessageBox.Show("Ошибка при удалении строки. Проверьте данные.");
                    }
                }
                else
                {
                    MessageBox.Show("Пожалуйста, выберите строку для удаления.");
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show($"Ошибка при удалении строки: {ex.Message}", "Ошибка");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка");
            }
        }
        private void buttonClearTO_Click(object sender, EventArgs e)
        {
            dataGridViewTO.Rows.Clear();
            ListTO.Clear();
        }
        ///
        ///ДТП
        ///
        public void UpdateDTP()
        {
            dataGridViewDTP.Rows.Clear();
            foreach (Accident newAccident in ListAccident)
            {

                string participants = "";
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dataGridViewDTP);

                string FIOinspect = newAccident.fio.surname + " " + newAccident.fio.name + " " + newAccident.fio.middlename;
                foreach (string part in listPartDTP)
                {
                    participants += part + "\n";
                }

                newRow.Cells[dataGridViewDTP.Columns["ColumnDateDTP"].Index].Value = newAccident.dateDTP;
                newRow.Cells[dataGridViewDTP.Columns["ColumnPlace"].Index].Value = newAccident.Place;
                newRow.Cells[dataGridViewDTP.Columns["ColumnParticipants"].Index].Value = newAccident.participant;
                newRow.Cells[dataGridViewDTP.Columns["ColumnSeverity"].Index].Value = newAccident.Severity;
                newRow.Cells[dataGridViewDTP.Columns["ColumnFIOinpect"].Index].Value = FIOinspect;
                newRow.Cells[dataGridViewDTP.Columns["ColumnDescriptions"].Index].Value = newAccident.Description;

                dataGridViewDTP.Rows.Add(newRow);
            }
        }
        private void buttonAddDTP_Click(object sender, EventArgs e)
        {
            int i = ListAccident.Count;
            FormDTP form6 = new FormDTP(this);
            form6.ShowDialog();
            if (ListAccident.Count > i)
            {
                UpdateDTP();
            }
        }
        private void buttonChangeDTP_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewDTP.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridViewDTP.SelectedRows[0]; // Получаем выбранную строку
                    int rowIndex = dataGridViewDTP.Rows.IndexOf(selectedRow);

                    if (ListAccident != null && rowIndex >= 0 && rowIndex < ListAccident.Count) // Проверяем, что строка существует в ListAccident
                    {
                        Accident currentAccident = ListAccident[rowIndex]; // Получаем текущий объект из списка

                        FormDTP form6 = new FormDTP(this, currentAccident, rowIndex);
                        form6.ShowDialog();
                        UpdateDTP();
                    }
                    else
                    {
                        MessageBox.Show("Не удалось найти данные для редактирования.", "Ошибка");
                    }
                }
                else
                {
                    MessageBox.Show("Пожалуйста, выберите строку для редактирования.", "Ошибка");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка");
            }
        }
        private void buttonDeleteDTP_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewDTP.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridViewDTP.SelectedRows[0];
                    // Проверка на пустую строку
                    bool rowIsEmpty = selectedRow.Cells.Cast<DataGridViewCell>().All(cell => string.IsNullOrEmpty(cell.Value?.ToString()));
                    if (rowIsEmpty)
                    {
                        MessageBox.Show("Невозможно удалить пустую строку.");
                        return;
                    }
                    int indexToRemove = dataGridViewDTP.Rows.IndexOf(selectedRow);
                    // Проверка на корректность индекса и существование ListAccident
                    if (ListAccident != null && indexToRemove >= 0 && indexToRemove < ListAccident.Count)
                    {
                        ListAccident.RemoveAt(indexToRemove);
                        dataGridViewDTP.Rows.Remove(selectedRow);
                    }
                    else
                    {
                        MessageBox.Show("Ошибка при удалении строки. Проверьте данные.");
                    }
                }
                else
                {
                    MessageBox.Show("Пожалуйста, выберите строку для удаления.");
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show($"Ошибка при удалении строки: {ex.Message}", "Ошибка");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка");
            }
        }
        private void buttonClearDTP_Click(object sender, EventArgs e)
        {
            dataGridViewDTP.Rows.Clear();
            ListAccident.Clear();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            DeserializeData();
            UpdateAvto();
            UpdateFowner();
            UpdateYuowner();
            UpdateDriver();
            UpdateTO();
            UpdateDTP();
        }
        private void serialize_Click(object sender, EventArgs e)
        {
            SerializeData();
        }
    }
}