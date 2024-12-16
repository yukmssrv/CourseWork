namespace CourseWork
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            tabControlDTP = new TabControl();
            tabPage2 = new TabPage();
            buttonClearAvto = new Button();
            buttonDeleteAvto = new Button();
            buttonChangeAvto = new Button();
            buttonAddAvto = new Button();
            dataGridViewAvto = new DataGridView();
            Columnregistrationnumber = new DataGridViewTextBoxColumn();
            ColumnName = new DataGridViewTextBoxColumn();
            ColumnFirma = new DataGridViewTextBoxColumn();
            ColumnBodynumber = new DataGridViewTextBoxColumn();
            ColumnChassisnumber = new DataGridViewTextBoxColumn();
            ColumnEnginenumber = new DataGridViewTextBoxColumn();
            ColumnBodymodel = new DataGridViewTextBoxColumn();
            ColumnColor = new DataGridViewTextBoxColumn();
            ColumnVolume = new DataGridViewTextBoxColumn();
            ColumnPower = new DataGridViewTextBoxColumn();
            ColumnWheel = new DataGridViewTextBoxColumn();
            ColumnDrivewheel = new DataGridViewTextBoxColumn();
            ColumnYearv = new DataGridViewTextBoxColumn();
            ColumnDateofregistration = new DataGridViewTextBoxColumn();
            Columntehtalonnumber = new DataGridViewTextBoxColumn();
            Columndatetehtalon = new DataGridViewTextBoxColumn();
            ColumnYeartax = new DataGridViewTextBoxColumn();
            tabPage1 = new TabPage();
            buttonDeleteOwner = new Button();
            buttonButtonChangeOwner = new Button();
            buttonAddOwner = new Button();
            groupBox1 = new GroupBox();
            dataGridViewYuowner = new DataGridView();
            ColumnAvtoInYuowner = new DataGridViewTextBoxColumn();
            ColumnOrganizationname = new DataGridViewTextBoxColumn();
            ColumnAddress = new DataGridViewTextBoxColumn();
            ColumnFIOruk = new DataGridViewTextBoxColumn();
            ColumnPhonenumberruk = new DataGridViewTextBoxColumn();
            groupBoxFOwner = new GroupBox();
            dataGridViewFowner = new DataGridView();
            ColumnAvtoInFowner = new DataGridViewTextBoxColumn();
            ColumnFIOowner = new DataGridViewTextBoxColumn();
            ColumnMalliableaddress = new DataGridViewTextBoxColumn();
            ColumnPhonenumber = new DataGridViewTextBoxColumn();
            ColumnPassportseries = new DataGridViewTextBoxColumn();
            ColumnPassportnumber = new DataGridViewTextBoxColumn();
            ColumnDatePassport = new DataGridViewTextBoxColumn();
            ColumnPassportorganization = new DataGridViewTextBoxColumn();
            tabPage3 = new TabPage();
            buttonClearDriver = new Button();
            buttonDeleteDriver = new Button();
            buttonChangeDriver = new Button();
            buttonAddDriver = new Button();
            dataGridViewDriver = new DataGridView();
            ColumnFIOdriver = new DataGridViewTextBoxColumn();
            ColumnDatebirth = new DataGridViewTextBoxColumn();
            ColumnNumberVU = new DataGridViewTextBoxColumn();
            ColumnCategoryVU = new DataGridViewTextBoxColumn();
            ColumnDateVU = new DataGridViewTextBoxColumn();
            tabPage4 = new TabPage();
            buttonClearTO = new Button();
            buttonDeleteTO = new Button();
            buttonChangeTO = new Button();
            buttonAddTO = new Button();
            dataGridViewTO = new DataGridView();
            ColumnAvtoInTO = new DataGridViewTextBoxColumn();
            ColumnDateTO = new DataGridViewTextBoxColumn();
            ColumnFIOinsp = new DataGridViewTextBoxColumn();
            ColumnMileage = new DataGridViewTextBoxColumn();
            ColumnPay = new DataGridViewTextBoxColumn();
            ColumnPaysign = new DataGridViewTextBoxColumn();
            tabPage5 = new TabPage();
            buttonClearDTP = new Button();
            buttonDeleteDTP = new Button();
            buttonChangeDTP = new Button();
            buttonAddDTP = new Button();
            dataGridViewDTP = new DataGridView();
            ColumnDateDTP = new DataGridViewTextBoxColumn();
            ColumnPlace = new DataGridViewTextBoxColumn();
            ColumnParticipants = new DataGridViewTextBoxColumn();
            ColumnSeverity = new DataGridViewTextBoxColumn();
            ColumnFIOinpect = new DataGridViewTextBoxColumn();
            ColumnDescriptions = new DataGridViewTextBoxColumn();
            Deserialize = new Button();
            serialize = new Button();
            tabControlDTP.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAvto).BeginInit();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewYuowner).BeginInit();
            groupBoxFOwner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFowner).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDriver).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTO).BeginInit();
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDTP).BeginInit();
            SuspendLayout();
            // 
            // tabControlDTP
            // 
            tabControlDTP.Controls.Add(tabPage2);
            tabControlDTP.Controls.Add(tabPage1);
            tabControlDTP.Controls.Add(tabPage3);
            tabControlDTP.Controls.Add(tabPage4);
            tabControlDTP.Controls.Add(tabPage5);
            tabControlDTP.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tabControlDTP.ItemSize = new Size(117, 28);
            tabControlDTP.Location = new Point(12, 12);
            tabControlDTP.Name = "tabControlDTP";
            tabControlDTP.SelectedIndex = 0;
            tabControlDTP.Size = new Size(1181, 629);
            tabControlDTP.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(buttonClearAvto);
            tabPage2.Controls.Add(buttonDeleteAvto);
            tabPage2.Controls.Add(buttonChangeAvto);
            tabPage2.Controls.Add(buttonAddAvto);
            tabPage2.Controls.Add(dataGridViewAvto);
            tabPage2.Location = new Point(4, 32);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1173, 593);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Автомобиль";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonClearAvto
            // 
            buttonClearAvto.Location = new Point(414, 542);
            buttonClearAvto.Name = "buttonClearAvto";
            buttonClearAvto.Size = new Size(117, 42);
            buttonClearAvto.TabIndex = 51;
            buttonClearAvto.Text = "Очистить";
            buttonClearAvto.UseVisualStyleBackColor = true;
            buttonClearAvto.Click += buttonClearAvto_Click_1;
            // 
            // buttonDeleteAvto
            // 
            buttonDeleteAvto.Location = new Point(281, 542);
            buttonDeleteAvto.Name = "buttonDeleteAvto";
            buttonDeleteAvto.Size = new Size(117, 42);
            buttonDeleteAvto.TabIndex = 50;
            buttonDeleteAvto.Text = "Удалить";
            buttonDeleteAvto.UseVisualStyleBackColor = true;
            buttonDeleteAvto.Click += buttonDeleteAvto_Click;
            // 
            // buttonChangeAvto
            // 
            buttonChangeAvto.Location = new Point(149, 542);
            buttonChangeAvto.Name = "buttonChangeAvto";
            buttonChangeAvto.Size = new Size(117, 42);
            buttonChangeAvto.TabIndex = 49;
            buttonChangeAvto.Text = "Изменить";
            buttonChangeAvto.UseVisualStyleBackColor = true;
            buttonChangeAvto.Click += buttonChangeAvto_Click;
            // 
            // buttonAddAvto
            // 
            buttonAddAvto.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddAvto.Location = new Point(17, 542);
            buttonAddAvto.Name = "buttonAddAvto";
            buttonAddAvto.Size = new Size(117, 42);
            buttonAddAvto.TabIndex = 48;
            buttonAddAvto.Text = "Добавить";
            buttonAddAvto.UseVisualStyleBackColor = true;
            buttonAddAvto.Click += buttonAddAvto_Click;
            // 
            // dataGridViewAvto
            // 
            dataGridViewAvto.BackgroundColor = Color.White;
            dataGridViewAvto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAvto.Columns.AddRange(new DataGridViewColumn[] { Columnregistrationnumber, ColumnName, ColumnFirma, ColumnBodynumber, ColumnChassisnumber, ColumnEnginenumber, ColumnBodymodel, ColumnColor, ColumnVolume, ColumnPower, ColumnWheel, ColumnDrivewheel, ColumnYearv, ColumnDateofregistration, Columntehtalonnumber, Columndatetehtalon, ColumnYeartax });
            dataGridViewAvto.Location = new Point(6, 6);
            dataGridViewAvto.Name = "dataGridViewAvto";
            dataGridViewAvto.RowHeadersWidth = 51;
            dataGridViewAvto.RowTemplate.Height = 29;
            dataGridViewAvto.Size = new Size(1161, 520);
            dataGridViewAvto.TabIndex = 47;
            // 
            // Columnregistrationnumber
            // 
            Columnregistrationnumber.HeaderText = "Номер гос регистрации";
            Columnregistrationnumber.MinimumWidth = 6;
            Columnregistrationnumber.Name = "Columnregistrationnumber";
            Columnregistrationnumber.Width = 125;
            // 
            // ColumnName
            // 
            ColumnName.HeaderText = "Марка авто";
            ColumnName.MinimumWidth = 6;
            ColumnName.Name = "ColumnName";
            ColumnName.Width = 125;
            // 
            // ColumnFirma
            // 
            ColumnFirma.HeaderText = "Модель автомобиля";
            ColumnFirma.MinimumWidth = 6;
            ColumnFirma.Name = "ColumnFirma";
            ColumnFirma.Width = 125;
            // 
            // ColumnBodynumber
            // 
            ColumnBodynumber.HeaderText = "Номер кузова";
            ColumnBodynumber.MinimumWidth = 6;
            ColumnBodynumber.Name = "ColumnBodynumber";
            ColumnBodynumber.Width = 125;
            // 
            // ColumnChassisnumber
            // 
            ColumnChassisnumber.HeaderText = "Номер шасси";
            ColumnChassisnumber.MinimumWidth = 6;
            ColumnChassisnumber.Name = "ColumnChassisnumber";
            ColumnChassisnumber.Width = 125;
            // 
            // ColumnEnginenumber
            // 
            ColumnEnginenumber.HeaderText = "Номер двигателя";
            ColumnEnginenumber.MinimumWidth = 6;
            ColumnEnginenumber.Name = "ColumnEnginenumber";
            ColumnEnginenumber.Width = 125;
            // 
            // ColumnBodymodel
            // 
            ColumnBodymodel.HeaderText = "Модель кузова";
            ColumnBodymodel.MinimumWidth = 6;
            ColumnBodymodel.Name = "ColumnBodymodel";
            ColumnBodymodel.Width = 125;
            // 
            // ColumnColor
            // 
            ColumnColor.HeaderText = "Цвет автомобиля";
            ColumnColor.MinimumWidth = 6;
            ColumnColor.Name = "ColumnColor";
            ColumnColor.Width = 125;
            // 
            // ColumnVolume
            // 
            ColumnVolume.HeaderText = "Объем двигателя";
            ColumnVolume.MinimumWidth = 6;
            ColumnVolume.Name = "ColumnVolume";
            ColumnVolume.Width = 125;
            // 
            // ColumnPower
            // 
            ColumnPower.HeaderText = "Мощность двигателя";
            ColumnPower.MinimumWidth = 6;
            ColumnPower.Name = "ColumnPower";
            ColumnPower.Width = 125;
            // 
            // ColumnWheel
            // 
            ColumnWheel.HeaderText = "Руль";
            ColumnWheel.MinimumWidth = 6;
            ColumnWheel.Name = "ColumnWheel";
            ColumnWheel.Width = 125;
            // 
            // ColumnDrivewheel
            // 
            ColumnDrivewheel.HeaderText = "Привод";
            ColumnDrivewheel.MinimumWidth = 6;
            ColumnDrivewheel.Name = "ColumnDrivewheel";
            ColumnDrivewheel.Width = 125;
            // 
            // ColumnYearv
            // 
            ColumnYearv.HeaderText = "Год выпуска";
            ColumnYearv.MinimumWidth = 6;
            ColumnYearv.Name = "ColumnYearv";
            ColumnYearv.Width = 125;
            // 
            // ColumnDateofregistration
            // 
            ColumnDateofregistration.HeaderText = "Дата постановки на учет";
            ColumnDateofregistration.MinimumWidth = 6;
            ColumnDateofregistration.Name = "ColumnDateofregistration";
            ColumnDateofregistration.Width = 125;
            // 
            // Columntehtalonnumber
            // 
            Columntehtalonnumber.HeaderText = "Номер тех. талона";
            Columntehtalonnumber.MinimumWidth = 6;
            Columntehtalonnumber.Name = "Columntehtalonnumber";
            Columntehtalonnumber.Width = 125;
            // 
            // Columndatetehtalon
            // 
            Columndatetehtalon.HeaderText = "Дата выдачи тех. талона";
            Columndatetehtalon.MinimumWidth = 6;
            Columndatetehtalon.Name = "Columndatetehtalon";
            Columndatetehtalon.Width = 125;
            // 
            // ColumnYeartax
            // 
            ColumnYeartax.HeaderText = "Годовой налог";
            ColumnYeartax.MinimumWidth = 6;
            ColumnYeartax.Name = "ColumnYeartax";
            ColumnYeartax.Width = 125;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(buttonDeleteOwner);
            tabPage1.Controls.Add(buttonButtonChangeOwner);
            tabPage1.Controls.Add(buttonAddOwner);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(groupBoxFOwner);
            tabPage1.Location = new Point(4, 32);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1173, 593);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Владелец";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteOwner
            // 
            buttonDeleteOwner.Location = new Point(287, 541);
            buttonDeleteOwner.Name = "buttonDeleteOwner";
            buttonDeleteOwner.Size = new Size(117, 42);
            buttonDeleteOwner.TabIndex = 54;
            buttonDeleteOwner.Text = "Удалить";
            buttonDeleteOwner.UseVisualStyleBackColor = true;
            buttonDeleteOwner.Click += buttonDeleteOwner_Click;
            // 
            // buttonButtonChangeOwner
            // 
            buttonButtonChangeOwner.Location = new Point(155, 541);
            buttonButtonChangeOwner.Name = "buttonButtonChangeOwner";
            buttonButtonChangeOwner.Size = new Size(117, 42);
            buttonButtonChangeOwner.TabIndex = 53;
            buttonButtonChangeOwner.Text = "Изменить";
            buttonButtonChangeOwner.UseVisualStyleBackColor = true;
            buttonButtonChangeOwner.Click += buttonButtonChangeOwner_Click;
            // 
            // buttonAddOwner
            // 
            buttonAddOwner.Location = new Point(23, 541);
            buttonAddOwner.Name = "buttonAddOwner";
            buttonAddOwner.Size = new Size(117, 42);
            buttonAddOwner.TabIndex = 52;
            buttonAddOwner.Text = "Добавить";
            buttonAddOwner.UseVisualStyleBackColor = true;
            buttonAddOwner.Click += buttonAddOwner_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridViewYuowner);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(590, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(566, 504);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Юридическое лицо";
            // 
            // dataGridViewYuowner
            // 
            dataGridViewYuowner.BackgroundColor = Color.White;
            dataGridViewYuowner.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewYuowner.Columns.AddRange(new DataGridViewColumn[] { ColumnAvtoInYuowner, ColumnOrganizationname, ColumnAddress, ColumnFIOruk, ColumnPhonenumberruk });
            dataGridViewYuowner.Location = new Point(6, 29);
            dataGridViewYuowner.Name = "dataGridViewYuowner";
            dataGridViewYuowner.RowHeadersWidth = 51;
            dataGridViewYuowner.RowTemplate.Height = 29;
            dataGridViewYuowner.Size = new Size(554, 471);
            dataGridViewYuowner.TabIndex = 0;
            // 
            // ColumnAvtoInYuowner
            // 
            ColumnAvtoInYuowner.HeaderText = "Автомобиль";
            ColumnAvtoInYuowner.MinimumWidth = 6;
            ColumnAvtoInYuowner.Name = "ColumnAvtoInYuowner";
            ColumnAvtoInYuowner.Width = 125;
            // 
            // ColumnOrganizationname
            // 
            ColumnOrganizationname.HeaderText = "Название организации";
            ColumnOrganizationname.MinimumWidth = 6;
            ColumnOrganizationname.Name = "ColumnOrganizationname";
            ColumnOrganizationname.Width = 125;
            // 
            // ColumnAddress
            // 
            ColumnAddress.HeaderText = "Адрес организации";
            ColumnAddress.MinimumWidth = 6;
            ColumnAddress.Name = "ColumnAddress";
            ColumnAddress.Width = 125;
            // 
            // ColumnFIOruk
            // 
            ColumnFIOruk.HeaderText = "ФИО руководителя";
            ColumnFIOruk.MinimumWidth = 6;
            ColumnFIOruk.Name = "ColumnFIOruk";
            ColumnFIOruk.Width = 125;
            // 
            // ColumnPhonenumberruk
            // 
            ColumnPhonenumberruk.HeaderText = "Телефон руководителя";
            ColumnPhonenumberruk.MinimumWidth = 6;
            ColumnPhonenumberruk.Name = "ColumnPhonenumberruk";
            ColumnPhonenumberruk.Width = 125;
            // 
            // groupBoxFOwner
            // 
            groupBoxFOwner.Controls.Add(dataGridViewFowner);
            groupBoxFOwner.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxFOwner.Location = new Point(18, 31);
            groupBoxFOwner.Name = "groupBoxFOwner";
            groupBoxFOwner.Size = new Size(566, 504);
            groupBoxFOwner.TabIndex = 4;
            groupBoxFOwner.TabStop = false;
            groupBoxFOwner.Text = "Физическое лицо";
            // 
            // dataGridViewFowner
            // 
            dataGridViewFowner.BackgroundColor = SystemColors.Window;
            dataGridViewFowner.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFowner.Columns.AddRange(new DataGridViewColumn[] { ColumnAvtoInFowner, ColumnFIOowner, ColumnMalliableaddress, ColumnPhonenumber, ColumnPassportseries, ColumnPassportnumber, ColumnDatePassport, ColumnPassportorganization });
            dataGridViewFowner.Location = new Point(6, 29);
            dataGridViewFowner.Name = "dataGridViewFowner";
            dataGridViewFowner.RowHeadersWidth = 51;
            dataGridViewFowner.RowTemplate.Height = 29;
            dataGridViewFowner.Size = new Size(554, 471);
            dataGridViewFowner.TabIndex = 0;
            // 
            // ColumnAvtoInFowner
            // 
            ColumnAvtoInFowner.HeaderText = "Автомобиль";
            ColumnAvtoInFowner.MinimumWidth = 6;
            ColumnAvtoInFowner.Name = "ColumnAvtoInFowner";
            ColumnAvtoInFowner.Width = 125;
            // 
            // ColumnFIOowner
            // 
            ColumnFIOowner.HeaderText = "ФИО";
            ColumnFIOowner.MinimumWidth = 6;
            ColumnFIOowner.Name = "ColumnFIOowner";
            ColumnFIOowner.Width = 125;
            // 
            // ColumnMalliableaddress
            // 
            ColumnMalliableaddress.HeaderText = "Почтовый адресс";
            ColumnMalliableaddress.MinimumWidth = 6;
            ColumnMalliableaddress.Name = "ColumnMalliableaddress";
            ColumnMalliableaddress.Width = 125;
            // 
            // ColumnPhonenumber
            // 
            ColumnPhonenumber.HeaderText = "Номер телефона";
            ColumnPhonenumber.MinimumWidth = 6;
            ColumnPhonenumber.Name = "ColumnPhonenumber";
            ColumnPhonenumber.Width = 125;
            // 
            // ColumnPassportseries
            // 
            ColumnPassportseries.HeaderText = "Серия паспорта";
            ColumnPassportseries.MinimumWidth = 6;
            ColumnPassportseries.Name = "ColumnPassportseries";
            ColumnPassportseries.Width = 125;
            // 
            // ColumnPassportnumber
            // 
            ColumnPassportnumber.HeaderText = "Номер паспорта";
            ColumnPassportnumber.MinimumWidth = 6;
            ColumnPassportnumber.Name = "ColumnPassportnumber";
            ColumnPassportnumber.Width = 125;
            // 
            // ColumnDatePassport
            // 
            ColumnDatePassport.HeaderText = "Дата выдачи";
            ColumnDatePassport.MinimumWidth = 6;
            ColumnDatePassport.Name = "ColumnDatePassport";
            ColumnDatePassport.Width = 125;
            // 
            // ColumnPassportorganization
            // 
            ColumnPassportorganization.HeaderText = "Кем выдан";
            ColumnPassportorganization.MinimumWidth = 6;
            ColumnPassportorganization.Name = "ColumnPassportorganization";
            ColumnPassportorganization.Resizable = DataGridViewTriState.True;
            ColumnPassportorganization.SortMode = DataGridViewColumnSortMode.NotSortable;
            ColumnPassportorganization.Width = 125;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(buttonClearDriver);
            tabPage3.Controls.Add(buttonDeleteDriver);
            tabPage3.Controls.Add(buttonChangeDriver);
            tabPage3.Controls.Add(buttonAddDriver);
            tabPage3.Controls.Add(dataGridViewDriver);
            tabPage3.Location = new Point(4, 32);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1173, 593);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Водитель";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonClearDriver
            // 
            buttonClearDriver.Location = new Point(420, 544);
            buttonClearDriver.Name = "buttonClearDriver";
            buttonClearDriver.Size = new Size(117, 42);
            buttonClearDriver.TabIndex = 55;
            buttonClearDriver.Text = "Очистить";
            buttonClearDriver.UseVisualStyleBackColor = true;
            buttonClearDriver.Click += buttonClearDriver_Click;
            // 
            // buttonDeleteDriver
            // 
            buttonDeleteDriver.Location = new Point(287, 544);
            buttonDeleteDriver.Name = "buttonDeleteDriver";
            buttonDeleteDriver.Size = new Size(117, 42);
            buttonDeleteDriver.TabIndex = 54;
            buttonDeleteDriver.Text = "Удалить";
            buttonDeleteDriver.UseVisualStyleBackColor = true;
            buttonDeleteDriver.Click += buttonDeleteDriver_Click;
            // 
            // buttonChangeDriver
            // 
            buttonChangeDriver.Location = new Point(155, 544);
            buttonChangeDriver.Name = "buttonChangeDriver";
            buttonChangeDriver.Size = new Size(117, 42);
            buttonChangeDriver.TabIndex = 53;
            buttonChangeDriver.Text = "Изменить";
            buttonChangeDriver.UseVisualStyleBackColor = true;
            buttonChangeDriver.Click += buttonChangeDriver_Click;
            // 
            // buttonAddDriver
            // 
            buttonAddDriver.Location = new Point(23, 544);
            buttonAddDriver.Name = "buttonAddDriver";
            buttonAddDriver.Size = new Size(117, 42);
            buttonAddDriver.TabIndex = 52;
            buttonAddDriver.Text = "Добавить";
            buttonAddDriver.UseVisualStyleBackColor = true;
            buttonAddDriver.Click += buttonAddDriver_Click;
            // 
            // dataGridViewDriver
            // 
            dataGridViewDriver.BackgroundColor = Color.White;
            dataGridViewDriver.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDriver.Columns.AddRange(new DataGridViewColumn[] { ColumnFIOdriver, ColumnDatebirth, ColumnNumberVU, ColumnCategoryVU, ColumnDateVU });
            dataGridViewDriver.Location = new Point(10, 7);
            dataGridViewDriver.Name = "dataGridViewDriver";
            dataGridViewDriver.RowHeadersWidth = 51;
            dataGridViewDriver.RowTemplate.Height = 29;
            dataGridViewDriver.Size = new Size(1153, 532);
            dataGridViewDriver.TabIndex = 0;
            // 
            // ColumnFIOdriver
            // 
            ColumnFIOdriver.HeaderText = "ФИО";
            ColumnFIOdriver.MinimumWidth = 6;
            ColumnFIOdriver.Name = "ColumnFIOdriver";
            ColumnFIOdriver.Width = 220;
            // 
            // ColumnDatebirth
            // 
            ColumnDatebirth.HeaderText = "Дата рождения";
            ColumnDatebirth.MinimumWidth = 6;
            ColumnDatebirth.Name = "ColumnDatebirth";
            ColumnDatebirth.Width = 220;
            // 
            // ColumnNumberVU
            // 
            ColumnNumberVU.HeaderText = "Номер ВУ";
            ColumnNumberVU.MinimumWidth = 6;
            ColumnNumberVU.Name = "ColumnNumberVU";
            ColumnNumberVU.Width = 220;
            // 
            // ColumnCategoryVU
            // 
            ColumnCategoryVU.HeaderText = "Категория ВУ";
            ColumnCategoryVU.MinimumWidth = 6;
            ColumnCategoryVU.Name = "ColumnCategoryVU";
            ColumnCategoryVU.Width = 220;
            // 
            // ColumnDateVU
            // 
            ColumnDateVU.HeaderText = "Дата выдачи ВУ";
            ColumnDateVU.MinimumWidth = 6;
            ColumnDateVU.Name = "ColumnDateVU";
            ColumnDateVU.Width = 220;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(buttonClearTO);
            tabPage4.Controls.Add(buttonDeleteTO);
            tabPage4.Controls.Add(buttonChangeTO);
            tabPage4.Controls.Add(buttonAddTO);
            tabPage4.Controls.Add(dataGridViewTO);
            tabPage4.Location = new Point(4, 32);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1173, 593);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Тех. осмотр";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // buttonClearTO
            // 
            buttonClearTO.Location = new Point(421, 540);
            buttonClearTO.Name = "buttonClearTO";
            buttonClearTO.Size = new Size(117, 42);
            buttonClearTO.TabIndex = 59;
            buttonClearTO.Text = "Очистить";
            buttonClearTO.UseVisualStyleBackColor = true;
            buttonClearTO.Click += buttonClearTO_Click;
            // 
            // buttonDeleteTO
            // 
            buttonDeleteTO.Location = new Point(288, 540);
            buttonDeleteTO.Name = "buttonDeleteTO";
            buttonDeleteTO.Size = new Size(117, 42);
            buttonDeleteTO.TabIndex = 58;
            buttonDeleteTO.Text = "Удалить";
            buttonDeleteTO.UseVisualStyleBackColor = true;
            buttonDeleteTO.Click += buttonDeleteTO_Click;
            // 
            // buttonChangeTO
            // 
            buttonChangeTO.Location = new Point(155, 540);
            buttonChangeTO.Name = "buttonChangeTO";
            buttonChangeTO.Size = new Size(117, 42);
            buttonChangeTO.TabIndex = 57;
            buttonChangeTO.Text = "Изменить";
            buttonChangeTO.UseVisualStyleBackColor = true;
            buttonChangeTO.Click += buttonChangeTO_Click;
            // 
            // buttonAddTO
            // 
            buttonAddTO.Location = new Point(23, 540);
            buttonAddTO.Name = "buttonAddTO";
            buttonAddTO.Size = new Size(117, 42);
            buttonAddTO.TabIndex = 56;
            buttonAddTO.Text = "Добавить";
            buttonAddTO.UseVisualStyleBackColor = true;
            buttonAddTO.Click += buttonAddTO_Click;
            // 
            // dataGridViewTO
            // 
            dataGridViewTO.BackgroundColor = Color.White;
            dataGridViewTO.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTO.Columns.AddRange(new DataGridViewColumn[] { ColumnAvtoInTO, ColumnDateTO, ColumnFIOinsp, ColumnMileage, ColumnPay, ColumnPaysign });
            dataGridViewTO.Location = new Point(3, 3);
            dataGridViewTO.Name = "dataGridViewTO";
            dataGridViewTO.RowHeadersWidth = 51;
            dataGridViewTO.RowTemplate.Height = 29;
            dataGridViewTO.Size = new Size(1167, 528);
            dataGridViewTO.TabIndex = 0;
            // 
            // ColumnAvtoInTO
            // 
            ColumnAvtoInTO.HeaderText = "Автомобиль";
            ColumnAvtoInTO.MinimumWidth = 6;
            ColumnAvtoInTO.Name = "ColumnAvtoInTO";
            ColumnAvtoInTO.Width = 185;
            // 
            // ColumnDateTO
            // 
            ColumnDateTO.HeaderText = "Дата ТО";
            ColumnDateTO.MinimumWidth = 6;
            ColumnDateTO.Name = "ColumnDateTO";
            ColumnDateTO.Width = 186;
            // 
            // ColumnFIOinsp
            // 
            ColumnFIOinsp.HeaderText = "ФИО инспектора";
            ColumnFIOinsp.MinimumWidth = 6;
            ColumnFIOinsp.Name = "ColumnFIOinsp";
            ColumnFIOinsp.Width = 186;
            // 
            // ColumnMileage
            // 
            ColumnMileage.HeaderText = "Пробег на дату ТО";
            ColumnMileage.MinimumWidth = 6;
            ColumnMileage.Name = "ColumnMileage";
            ColumnMileage.Width = 185;
            // 
            // ColumnPay
            // 
            ColumnPay.HeaderText = "Оплата за ТО";
            ColumnPay.MinimumWidth = 6;
            ColumnPay.Name = "ColumnPay";
            ColumnPay.Width = 186;
            // 
            // ColumnPaysign
            // 
            ColumnPaysign.HeaderText = "Оплата за знак ТО";
            ColumnPaysign.MinimumWidth = 6;
            ColumnPaysign.Name = "ColumnPaysign";
            ColumnPaysign.Width = 186;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(buttonClearDTP);
            tabPage5.Controls.Add(buttonDeleteDTP);
            tabPage5.Controls.Add(buttonChangeDTP);
            tabPage5.Controls.Add(buttonAddDTP);
            tabPage5.Controls.Add(dataGridViewDTP);
            tabPage5.Location = new Point(4, 32);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(1173, 593);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "ДТП";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // buttonClearDTP
            // 
            buttonClearDTP.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonClearDTP.Location = new Point(420, 543);
            buttonClearDTP.Name = "buttonClearDTP";
            buttonClearDTP.Size = new Size(117, 42);
            buttonClearDTP.TabIndex = 59;
            buttonClearDTP.Text = "Очистить";
            buttonClearDTP.UseVisualStyleBackColor = true;
            buttonClearDTP.Click += buttonClearDTP_Click;
            // 
            // buttonDeleteDTP
            // 
            buttonDeleteDTP.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDeleteDTP.Location = new Point(287, 543);
            buttonDeleteDTP.Name = "buttonDeleteDTP";
            buttonDeleteDTP.Size = new Size(117, 42);
            buttonDeleteDTP.TabIndex = 58;
            buttonDeleteDTP.Text = "Удалить";
            buttonDeleteDTP.UseVisualStyleBackColor = true;
            buttonDeleteDTP.Click += buttonDeleteDTP_Click;
            // 
            // buttonChangeDTP
            // 
            buttonChangeDTP.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonChangeDTP.Location = new Point(155, 543);
            buttonChangeDTP.Name = "buttonChangeDTP";
            buttonChangeDTP.Size = new Size(117, 42);
            buttonChangeDTP.TabIndex = 57;
            buttonChangeDTP.Text = "Изменить";
            buttonChangeDTP.UseVisualStyleBackColor = true;
            buttonChangeDTP.Click += buttonChangeDTP_Click;
            // 
            // buttonAddDTP
            // 
            buttonAddDTP.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddDTP.Location = new Point(23, 543);
            buttonAddDTP.Name = "buttonAddDTP";
            buttonAddDTP.Size = new Size(117, 42);
            buttonAddDTP.TabIndex = 56;
            buttonAddDTP.Text = "Добавить";
            buttonAddDTP.UseVisualStyleBackColor = true;
            buttonAddDTP.Click += buttonAddDTP_Click;
            // 
            // dataGridViewDTP
            // 
            dataGridViewDTP.BackgroundColor = Color.White;
            dataGridViewDTP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDTP.Columns.AddRange(new DataGridViewColumn[] { ColumnDateDTP, ColumnPlace, ColumnParticipants, ColumnSeverity, ColumnFIOinpect, ColumnDescriptions });
            dataGridViewDTP.Location = new Point(3, 3);
            dataGridViewDTP.Name = "dataGridViewDTP";
            dataGridViewDTP.RowHeadersWidth = 51;
            dataGridViewDTP.RowTemplate.Height = 29;
            dataGridViewDTP.Size = new Size(1167, 534);
            dataGridViewDTP.TabIndex = 1;
            // 
            // ColumnDateDTP
            // 
            ColumnDateDTP.HeaderText = "Дата ДТП";
            ColumnDateDTP.MinimumWidth = 6;
            ColumnDateDTP.Name = "ColumnDateDTP";
            ColumnDateDTP.Resizable = DataGridViewTriState.True;
            ColumnDateDTP.Width = 183;
            // 
            // ColumnPlace
            // 
            ColumnPlace.HeaderText = "Место ДТП";
            ColumnPlace.MinimumWidth = 6;
            ColumnPlace.Name = "ColumnPlace";
            ColumnPlace.Resizable = DataGridViewTriState.True;
            ColumnPlace.Width = 186;
            // 
            // ColumnParticipants
            // 
            ColumnParticipants.HeaderText = " Участники ДТП (Водители и автомобили)";
            ColumnParticipants.MinimumWidth = 6;
            ColumnParticipants.Name = "ColumnParticipants";
            ColumnParticipants.Resizable = DataGridViewTriState.True;
            ColumnParticipants.SortMode = DataGridViewColumnSortMode.NotSortable;
            ColumnParticipants.Width = 186;
            // 
            // ColumnSeverity
            // 
            ColumnSeverity.HeaderText = "Степень тяжести ДТП";
            ColumnSeverity.MinimumWidth = 6;
            ColumnSeverity.Name = "ColumnSeverity";
            ColumnSeverity.Resizable = DataGridViewTriState.True;
            ColumnSeverity.Width = 186;
            // 
            // ColumnFIOinpect
            // 
            ColumnFIOinpect.HeaderText = "ФИО инспектора";
            ColumnFIOinpect.MinimumWidth = 6;
            ColumnFIOinpect.Name = "ColumnFIOinpect";
            ColumnFIOinpect.Resizable = DataGridViewTriState.True;
            ColumnFIOinpect.Width = 186;
            // 
            // ColumnDescriptions
            // 
            ColumnDescriptions.HeaderText = "Описание ДТП";
            ColumnDescriptions.MinimumWidth = 6;
            ColumnDescriptions.Name = "ColumnDescriptions";
            ColumnDescriptions.Resizable = DataGridViewTriState.True;
            ColumnDescriptions.Width = 186;
            // 
            // Deserialize
            // 
            Deserialize.Location = new Point(1017, 647);
            Deserialize.Name = "Deserialize";
            Deserialize.Size = new Size(172, 49);
            Deserialize.TabIndex = 52;
            Deserialize.Text = "Загрузить сохраненные данные";
            Deserialize.UseVisualStyleBackColor = true;
            Deserialize.Click += button1_Click_1;
            // 
            // serialize
            // 
            serialize.Location = new Point(839, 647);
            serialize.Name = "serialize";
            serialize.Size = new Size(172, 49);
            serialize.TabIndex = 53;
            serialize.Text = "Сохранить";
            serialize.UseVisualStyleBackColor = true;
            serialize.Click += serialize_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1205, 701);
            Controls.Add(serialize);
            Controls.Add(Deserialize);
            Controls.Add(tabControlDTP);
            Name = "Form1";
            Text = "Система ГосАвтоИнспекции";
            tabControlDTP.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewAvto).EndInit();
            tabPage1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewYuowner).EndInit();
            groupBoxFOwner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewFowner).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewDriver).EndInit();
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTO).EndInit();
            tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewDTP).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlDTP;
        private TabPage tabPage2;
        private TabPage tabPage1;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private DataGridView dataGridViewAvto;
        private DataGridViewTextBoxColumn Columnregistrationnumber;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ColumnFirma;
        private DataGridViewTextBoxColumn ColumnBodynumber;
        private DataGridViewTextBoxColumn ColumnChassisnumber;
        private DataGridViewTextBoxColumn ColumnEnginenumber;
        private DataGridViewTextBoxColumn ColumnBodymodel;
        private DataGridViewTextBoxColumn ColumnColor;
        private DataGridViewTextBoxColumn ColumnVolume;
        private DataGridViewTextBoxColumn ColumnPower;
        private DataGridViewTextBoxColumn ColumnWheel;
        private DataGridViewTextBoxColumn ColumnDrivewheel;
        private DataGridViewTextBoxColumn ColumnYearv;
        private DataGridViewTextBoxColumn ColumnDateofregistration;
        private DataGridViewTextBoxColumn Columntehtalonnumber;
        private DataGridViewTextBoxColumn Columndatetehtalon;
        private DataGridViewTextBoxColumn ColumnYeartax;
        private Button buttonClearAvto;
        private Button buttonDeleteAvto;
        private Button buttonChangeAvto;
        private Button buttonAddAvto;
        private GroupBox groupBoxFOwner;
        private Button buttonDeleteOwner;
        private Button buttonButtonChangeOwner;
        private Button buttonAddOwner;
        private GroupBox groupBox1;
        private DataGridView dataGridViewFowner;
        private DataGridView dataGridViewYuowner;
        private DataGridView dataGridViewDriver;
        private DataGridView dataGridViewTO;
        private DataGridView dataGridViewDTP;
        private Button buttonClearDriver;
        private Button buttonDeleteDriver;
        private Button buttonChangeDriver;
        private Button buttonAddDriver;
        private Button buttonClearTO;
        private Button buttonDeleteTO;
        private Button buttonChangeTO;
        private Button buttonAddTO;
        private Button buttonClearDTP;
        private Button buttonDeleteDTP;
        private Button buttonChangeDTP;
        private Button buttonAddDTP;
        private DataGridViewTextBoxColumn ColumnFIOdriver;
        private DataGridViewTextBoxColumn ColumnDatebirth;
        private DataGridViewTextBoxColumn ColumnNumberVU;
        private DataGridViewTextBoxColumn ColumnCategoryVU;
        private DataGridViewTextBoxColumn ColumnDateVU;
        private DataGridViewTextBoxColumn ColumnAvtoInTO;
        private DataGridViewTextBoxColumn ColumnDateTO;
        private DataGridViewTextBoxColumn ColumnFIOinsp;
        private DataGridViewTextBoxColumn ColumnMileage;
        private DataGridViewTextBoxColumn ColumnPay;
        private DataGridViewTextBoxColumn ColumnPaysign;
        private DataGridViewTextBoxColumn ColumnDateDTP;
        private DataGridViewTextBoxColumn ColumnPlace;
        private DataGridViewTextBoxColumn ColumnParticipants;
        private DataGridViewTextBoxColumn ColumnSeverity;
        private DataGridViewTextBoxColumn ColumnFIOinpect;
        private DataGridViewTextBoxColumn ColumnDescriptions;
        private DataGridViewTextBoxColumn ColumnAvtoInFowner;
        private DataGridViewTextBoxColumn ColumnFIOowner;
        private DataGridViewTextBoxColumn ColumnMalliableaddress;
        private DataGridViewTextBoxColumn ColumnPhonenumber;
        private DataGridViewTextBoxColumn ColumnPassportseries;
        private DataGridViewTextBoxColumn ColumnPassportnumber;
        private DataGridViewTextBoxColumn ColumnDatePassport;
        private DataGridViewTextBoxColumn ColumnPassportorganization;
        private DataGridViewTextBoxColumn ColumnAvtoInYuowner;
        private DataGridViewTextBoxColumn ColumnOrganizationname;
        private DataGridViewTextBoxColumn ColumnAddress;
        private DataGridViewTextBoxColumn ColumnFIOruk;
        private DataGridViewTextBoxColumn ColumnPhonenumberruk;
        private Button Deserialize;
        private Button serialize;
    }
}