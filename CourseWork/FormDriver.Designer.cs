namespace CourseWork
{
    partial class FormDriver
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
            dateTimeDateVU = new DateTimePicker();
            dateTimeDatebirth = new DateTimePicker();
            labelDatebirth = new Label();
            comboBoxcategoryVU = new ComboBox();
            textBoxNumberVU = new TextBox();
            textBoxFIOdriver = new TextBox();
            labeldateVU = new Label();
            labelcategoryVU = new Label();
            labelnumberVU = new Label();
            labelFIOdriver = new Label();
            buttonAddInDriver = new Button();
            SuspendLayout();
            // 
            // dateTimeDateVU
            // 
            dateTimeDateVU.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimeDateVU.Location = new Point(222, 199);
            dateTimeDateVU.Name = "dateTimeDateVU";
            dateTimeDateVU.Size = new Size(178, 30);
            dateTimeDateVU.TabIndex = 56;
            // 
            // dateTimeDatebirth
            // 
            dateTimeDatebirth.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimeDatebirth.Location = new Point(222, 76);
            dateTimeDatebirth.Name = "dateTimeDatebirth";
            dateTimeDatebirth.Size = new Size(178, 30);
            dateTimeDatebirth.TabIndex = 55;
            // 
            // labelDatebirth
            // 
            labelDatebirth.AutoSize = true;
            labelDatebirth.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelDatebirth.Location = new Point(55, 81);
            labelDatebirth.Name = "labelDatebirth";
            labelDatebirth.Size = new Size(136, 23);
            labelDatebirth.TabIndex = 54;
            labelDatebirth.Text = "Дата рождения:";
            // 
            // comboBoxcategoryVU
            // 
            comboBoxcategoryVU.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxcategoryVU.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxcategoryVU.FormattingEnabled = true;
            comboBoxcategoryVU.Items.AddRange(new object[] { "A", "A1", "B", "B1", "C", "C1", "D", "D1", "BE", "CE", "C1E", "DE", "D1E", "M", "Tm", "Tb" });
            comboBoxcategoryVU.Location = new Point(221, 154);
            comboBoxcategoryVU.Name = "comboBoxcategoryVU";
            comboBoxcategoryVU.Size = new Size(179, 31);
            comboBoxcategoryVU.TabIndex = 53;
            // 
            // textBoxNumberVU
            // 
            textBoxNumberVU.BorderStyle = BorderStyle.FixedSingle;
            textBoxNumberVU.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNumberVU.Location = new Point(221, 117);
            textBoxNumberVU.Name = "textBoxNumberVU";
            textBoxNumberVU.Size = new Size(179, 30);
            textBoxNumberVU.TabIndex = 52;
            // 
            // textBoxFIOdriver
            // 
            textBoxFIOdriver.BorderStyle = BorderStyle.FixedSingle;
            textBoxFIOdriver.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxFIOdriver.Location = new Point(222, 35);
            textBoxFIOdriver.Name = "textBoxFIOdriver";
            textBoxFIOdriver.Size = new Size(178, 30);
            textBoxFIOdriver.TabIndex = 51;
            // 
            // labeldateVU
            // 
            labeldateVU.AutoSize = true;
            labeldateVU.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labeldateVU.Location = new Point(55, 205);
            labeldateVU.Name = "labeldateVU";
            labeldateVU.Size = new Size(140, 23);
            labeldateVU.TabIndex = 50;
            labeldateVU.Text = "Дата выдачи ВУ:";
            // 
            // labelcategoryVU
            // 
            labelcategoryVU.AutoSize = true;
            labelcategoryVU.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelcategoryVU.Location = new Point(55, 162);
            labelcategoryVU.Name = "labelcategoryVU";
            labelcategoryVU.Size = new Size(120, 23);
            labelcategoryVU.TabIndex = 49;
            labelcategoryVU.Text = "Категория ВУ:";
            // 
            // labelnumberVU
            // 
            labelnumberVU.AutoSize = true;
            labelnumberVU.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelnumberVU.Location = new Point(55, 124);
            labelnumberVU.Name = "labelnumberVU";
            labelnumberVU.Size = new Size(92, 23);
            labelnumberVU.TabIndex = 48;
            labelnumberVU.Text = "Номер ВУ:";
            // 
            // labelFIOdriver
            // 
            labelFIOdriver.AutoSize = true;
            labelFIOdriver.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelFIOdriver.Location = new Point(55, 42);
            labelFIOdriver.Name = "labelFIOdriver";
            labelFIOdriver.Size = new Size(52, 23);
            labelFIOdriver.TabIndex = 47;
            labelFIOdriver.Text = "ФИО:";
            // 
            // buttonAddInDriver
            // 
            buttonAddInDriver.Location = new Point(432, 292);
            buttonAddInDriver.Name = "buttonAddInDriver";
            buttonAddInDriver.Size = new Size(160, 40);
            buttonAddInDriver.TabIndex = 81;
            buttonAddInDriver.Text = "Добавить";
            buttonAddInDriver.UseVisualStyleBackColor = true;
            buttonAddInDriver.Click += buttonAddInDriver_Click;
            // 
            // FormDriver
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(629, 355);
            Controls.Add(buttonAddInDriver);
            Controls.Add(dateTimeDateVU);
            Controls.Add(dateTimeDatebirth);
            Controls.Add(labelDatebirth);
            Controls.Add(comboBoxcategoryVU);
            Controls.Add(textBoxNumberVU);
            Controls.Add(textBoxFIOdriver);
            Controls.Add(labeldateVU);
            Controls.Add(labelcategoryVU);
            Controls.Add(labelnumberVU);
            Controls.Add(labelFIOdriver);
            Name = "FormDriver";
            Text = "Водитель";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimeDateVU;
        private DateTimePicker dateTimeDatebirth;
        private Label labelDatebirth;
        private ComboBox comboBoxcategoryVU;
        private TextBox textBoxNumberVU;
        private TextBox textBoxFIOdriver;
        private Label labeldateVU;
        private Label labelcategoryVU;
        private Label labelnumberVU;
        private Label labelFIOdriver;
        private Button buttonAddInDriver;
    }
}