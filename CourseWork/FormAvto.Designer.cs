namespace CourseWork
{
    partial class FormAvto
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
            groupBoxDatetehtalon = new GroupBox();
            dateTimeDatetehtalon = new DateTimePicker();
            groupBoxDateuchet = new GroupBox();
            dateTimeDateucheta = new DateTimePicker();
            label25 = new Label();
            label24 = new Label();
            textBoxyeartax = new TextBox();
            textBoxtehtalonnumber = new TextBox();
            textBoxyearv = new TextBox();
            comboBoxdrivewheel = new ComboBox();
            comboBoxwheel = new ComboBox();
            textBoxpower = new TextBox();
            textBoxvolume = new TextBox();
            textBoxcolor = new TextBox();
            textBoxbodymodel = new TextBox();
            textBoxenginenumber = new TextBox();
            textBoxchassisnumer = new TextBox();
            textBoxbodynumber = new TextBox();
            textBoxfirma = new TextBox();
            textBoxname = new TextBox();
            labelyeartax = new Label();
            labeltehtalonnumber = new Label();
            labelyearv = new Label();
            labeldrivewheel = new Label();
            labelwheel = new Label();
            labelpower = new Label();
            labelvolume = new Label();
            labelcolor = new Label();
            labelbodymodel = new Label();
            labelenginenumber = new Label();
            labelchassisnumber = new Label();
            labelbodynumber = new Label();
            labelfirma = new Label();
            labelname = new Label();
            labelregistrationnumber = new Label();
            textBoxregistrationnumber = new TextBox();
            buttonAddInAvto = new Button();
            groupBoxDatetehtalon.SuspendLayout();
            groupBoxDateuchet.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxDatetehtalon
            // 
            groupBoxDatetehtalon.Controls.Add(dateTimeDatetehtalon);
            groupBoxDatetehtalon.Location = new Point(513, 362);
            groupBoxDatetehtalon.Name = "groupBoxDatetehtalon";
            groupBoxDatetehtalon.Size = new Size(375, 92);
            groupBoxDatetehtalon.TabIndex = 79;
            groupBoxDatetehtalon.TabStop = false;
            groupBoxDatetehtalon.Text = "Дата выдачи тех. талона";
            // 
            // dateTimeDatetehtalon
            // 
            dateTimeDatetehtalon.Location = new Point(7, 43);
            dateTimeDatetehtalon.Name = "dateTimeDatetehtalon";
            dateTimeDatetehtalon.Size = new Size(361, 30);
            dateTimeDatetehtalon.TabIndex = 43;
            // 
            // groupBoxDateuchet
            // 
            groupBoxDateuchet.Controls.Add(dateTimeDateucheta);
            groupBoxDateuchet.Location = new Point(513, 187);
            groupBoxDateuchet.Name = "groupBoxDateuchet";
            groupBoxDateuchet.Size = new Size(375, 92);
            groupBoxDateuchet.TabIndex = 78;
            groupBoxDateuchet.TabStop = false;
            groupBoxDateuchet.Text = "Дата постановки на учет";
            // 
            // dateTimeDateucheta
            // 
            dateTimeDateucheta.Location = new Point(7, 43);
            dateTimeDateucheta.Name = "dateTimeDateucheta";
            dateTimeDateucheta.Size = new Size(361, 30);
            dateTimeDateucheta.TabIndex = 43;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(413, 497);
            label25.Name = "label25";
            label25.Size = new Size(35, 23);
            label25.TabIndex = 77;
            label25.Text = "л.с.";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(413, 451);
            label24.Name = "label24";
            label24.Size = new Size(23, 23);
            label24.TabIndex = 76;
            label24.Text = "л.";
            // 
            // textBoxyeartax
            // 
            textBoxyeartax.BorderStyle = BorderStyle.FixedSingle;
            textBoxyeartax.Location = new Point(747, 489);
            textBoxyeartax.Name = "textBoxyeartax";
            textBoxyeartax.Size = new Size(140, 30);
            textBoxyeartax.TabIndex = 75;
            // 
            // textBoxtehtalonnumber
            // 
            textBoxtehtalonnumber.BorderStyle = BorderStyle.FixedSingle;
            textBoxtehtalonnumber.Location = new Point(747, 307);
            textBoxtehtalonnumber.Name = "textBoxtehtalonnumber";
            textBoxtehtalonnumber.Size = new Size(140, 30);
            textBoxtehtalonnumber.TabIndex = 74;
            // 
            // textBoxyearv
            // 
            textBoxyearv.BorderStyle = BorderStyle.FixedSingle;
            textBoxyearv.Location = new Point(747, 140);
            textBoxyearv.Name = "textBoxyearv";
            textBoxyearv.Size = new Size(140, 30);
            textBoxyearv.TabIndex = 73;
            // 
            // comboBoxdrivewheel
            // 
            comboBoxdrivewheel.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxdrivewheel.FormattingEnabled = true;
            comboBoxdrivewheel.Items.AddRange(new object[] { "Да", "Нет" });
            comboBoxdrivewheel.Location = new Point(747, 92);
            comboBoxdrivewheel.Name = "comboBoxdrivewheel";
            comboBoxdrivewheel.Size = new Size(140, 31);
            comboBoxdrivewheel.TabIndex = 72;
            // 
            // comboBoxwheel
            // 
            comboBoxwheel.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxwheel.FormattingEnabled = true;
            comboBoxwheel.Items.AddRange(new object[] { "Правый", "Левый" });
            comboBoxwheel.Location = new Point(747, 40);
            comboBoxwheel.Name = "comboBoxwheel";
            comboBoxwheel.Size = new Size(140, 31);
            comboBoxwheel.TabIndex = 71;
            // 
            // textBoxpower
            // 
            textBoxpower.BorderStyle = BorderStyle.FixedSingle;
            textBoxpower.Location = new Point(266, 489);
            textBoxpower.Name = "textBoxpower";
            textBoxpower.Size = new Size(140, 30);
            textBoxpower.TabIndex = 70;
            // 
            // textBoxvolume
            // 
            textBoxvolume.BorderStyle = BorderStyle.FixedSingle;
            textBoxvolume.Location = new Point(266, 440);
            textBoxvolume.Name = "textBoxvolume";
            textBoxvolume.Size = new Size(140, 30);
            textBoxvolume.TabIndex = 69;
            // 
            // textBoxcolor
            // 
            textBoxcolor.BackColor = SystemColors.Window;
            textBoxcolor.BorderStyle = BorderStyle.FixedSingle;
            textBoxcolor.Location = new Point(266, 390);
            textBoxcolor.Name = "textBoxcolor";
            textBoxcolor.Size = new Size(140, 30);
            textBoxcolor.TabIndex = 68;
            // 
            // textBoxbodymodel
            // 
            textBoxbodymodel.BorderStyle = BorderStyle.FixedSingle;
            textBoxbodymodel.Location = new Point(266, 335);
            textBoxbodymodel.Name = "textBoxbodymodel";
            textBoxbodymodel.Size = new Size(140, 30);
            textBoxbodymodel.TabIndex = 67;
            // 
            // textBoxenginenumber
            // 
            textBoxenginenumber.BorderStyle = BorderStyle.FixedSingle;
            textBoxenginenumber.Location = new Point(266, 284);
            textBoxenginenumber.Name = "textBoxenginenumber";
            textBoxenginenumber.Size = new Size(140, 30);
            textBoxenginenumber.TabIndex = 66;
            // 
            // textBoxchassisnumer
            // 
            textBoxchassisnumer.BorderStyle = BorderStyle.FixedSingle;
            textBoxchassisnumer.Location = new Point(266, 233);
            textBoxchassisnumer.Name = "textBoxchassisnumer";
            textBoxchassisnumer.Size = new Size(140, 30);
            textBoxchassisnumer.TabIndex = 65;
            // 
            // textBoxbodynumber
            // 
            textBoxbodynumber.BorderStyle = BorderStyle.FixedSingle;
            textBoxbodynumber.Location = new Point(266, 187);
            textBoxbodynumber.Name = "textBoxbodynumber";
            textBoxbodynumber.Size = new Size(140, 30);
            textBoxbodynumber.TabIndex = 64;
            // 
            // textBoxfirma
            // 
            textBoxfirma.BorderStyle = BorderStyle.FixedSingle;
            textBoxfirma.Location = new Point(266, 138);
            textBoxfirma.Name = "textBoxfirma";
            textBoxfirma.Size = new Size(140, 30);
            textBoxfirma.TabIndex = 63;
            // 
            // textBoxname
            // 
            textBoxname.BorderStyle = BorderStyle.FixedSingle;
            textBoxname.Location = new Point(266, 89);
            textBoxname.Name = "textBoxname";
            textBoxname.Size = new Size(140, 30);
            textBoxname.TabIndex = 62;
            // 
            // labelyeartax
            // 
            labelyeartax.AutoSize = true;
            labelyeartax.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelyeartax.Location = new Point(513, 489);
            labelyeartax.Name = "labelyeartax";
            labelyeartax.Size = new Size(130, 23);
            labelyeartax.TabIndex = 61;
            labelyeartax.Text = "Годовой налог:";
            // 
            // labeltehtalonnumber
            // 
            labeltehtalonnumber.AutoSize = true;
            labeltehtalonnumber.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labeltehtalonnumber.Location = new Point(513, 312);
            labeltehtalonnumber.Name = "labeltehtalonnumber";
            labeltehtalonnumber.Size = new Size(159, 23);
            labeltehtalonnumber.TabIndex = 60;
            labeltehtalonnumber.Text = "Номер тех. талона:";
            // 
            // labelyearv
            // 
            labelyearv.AutoSize = true;
            labelyearv.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelyearv.Location = new Point(513, 140);
            labelyearv.Name = "labelyearv";
            labelyearv.Size = new Size(110, 23);
            labelyearv.TabIndex = 59;
            labelyearv.Text = "Год выпуска:";
            // 
            // labeldrivewheel
            // 
            labeldrivewheel.AutoSize = true;
            labeldrivewheel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labeldrivewheel.Location = new Point(513, 92);
            labeldrivewheel.Name = "labeldrivewheel";
            labeldrivewheel.Size = new Size(187, 23);
            labeldrivewheel.TabIndex = 58;
            labeldrivewheel.Text = "Привод на все колеса:";
            // 
            // labelwheel
            // 
            labelwheel.AutoSize = true;
            labelwheel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelwheel.Location = new Point(513, 43);
            labelwheel.Name = "labelwheel";
            labelwheel.Size = new Size(50, 23);
            labelwheel.TabIndex = 57;
            labelwheel.Text = "Руль:";
            // 
            // labelpower
            // 
            labelpower.AutoSize = true;
            labelpower.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelpower.Location = new Point(37, 489);
            labelpower.Name = "labelpower";
            labelpower.Size = new Size(180, 23);
            labelpower.TabIndex = 56;
            labelpower.Text = "Мощность двигателя:";
            // 
            // labelvolume
            // 
            labelvolume.AutoSize = true;
            labelvolume.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelvolume.Location = new Point(36, 442);
            labelvolume.Name = "labelvolume";
            labelvolume.Size = new Size(151, 23);
            labelvolume.TabIndex = 55;
            labelvolume.Text = "Объем двигателя:";
            // 
            // labelcolor
            // 
            labelcolor.AutoSize = true;
            labelcolor.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelcolor.Location = new Point(35, 390);
            labelcolor.Name = "labelcolor";
            labelcolor.Size = new Size(152, 23);
            labelcolor.TabIndex = 54;
            labelcolor.Text = "Цвет автомобиля:";
            // 
            // labelbodymodel
            // 
            labelbodymodel.AutoSize = true;
            labelbodymodel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelbodymodel.Location = new Point(37, 339);
            labelbodymodel.Name = "labelbodymodel";
            labelbodymodel.Size = new Size(132, 23);
            labelbodymodel.TabIndex = 53;
            labelbodymodel.Text = "Модель кузова:";
            // 
            // labelenginenumber
            // 
            labelenginenumber.AutoSize = true;
            labelenginenumber.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelenginenumber.Location = new Point(37, 289);
            labelenginenumber.Name = "labelenginenumber";
            labelenginenumber.Size = new Size(150, 23);
            labelenginenumber.TabIndex = 52;
            labelenginenumber.Text = "Номер двигателя:";
            // 
            // labelchassisnumber
            // 
            labelchassisnumber.AutoSize = true;
            labelchassisnumber.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelchassisnumber.Location = new Point(37, 235);
            labelchassisnumber.Name = "labelchassisnumber";
            labelchassisnumber.Size = new Size(121, 23);
            labelchassisnumber.TabIndex = 51;
            labelchassisnumber.Text = "Номер шасси:";
            // 
            // labelbodynumber
            // 
            labelbodynumber.AutoSize = true;
            labelbodynumber.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelbodynumber.Location = new Point(37, 187);
            labelbodynumber.Name = "labelbodynumber";
            labelbodynumber.Size = new Size(124, 23);
            labelbodynumber.TabIndex = 50;
            labelbodynumber.Text = "Номер кузова:";
            // 
            // labelfirma
            // 
            labelfirma.AutoSize = true;
            labelfirma.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelfirma.Location = new Point(37, 139);
            labelfirma.Name = "labelfirma";
            labelfirma.Size = new Size(175, 23);
            labelfirma.TabIndex = 49;
            labelfirma.Text = "Модель автомобиля:";
            // 
            // labelname
            // 
            labelname.AutoSize = true;
            labelname.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelname.Location = new Point(37, 90);
            labelname.Name = "labelname";
            labelname.Size = new Size(165, 23);
            labelname.TabIndex = 48;
            labelname.Text = "Марка автомобиля:";
            // 
            // labelregistrationnumber
            // 
            labelregistrationnumber.AutoSize = true;
            labelregistrationnumber.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelregistrationnumber.Location = new Point(37, 43);
            labelregistrationnumber.Name = "labelregistrationnumber";
            labelregistrationnumber.Size = new Size(201, 23);
            labelregistrationnumber.TabIndex = 47;
            labelregistrationnumber.Text = "Номер гос.регистрации:";
            // 
            // textBoxregistrationnumber
            // 
            textBoxregistrationnumber.BorderStyle = BorderStyle.FixedSingle;
            textBoxregistrationnumber.Location = new Point(266, 43);
            textBoxregistrationnumber.Name = "textBoxregistrationnumber";
            textBoxregistrationnumber.Size = new Size(140, 30);
            textBoxregistrationnumber.TabIndex = 46;
            // 
            // buttonAddInAvto
            // 
            buttonAddInAvto.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddInAvto.Location = new Point(722, 561);
            buttonAddInAvto.Name = "buttonAddInAvto";
            buttonAddInAvto.Size = new Size(180, 46);
            buttonAddInAvto.TabIndex = 80;
            buttonAddInAvto.Text = "Добавить";
            buttonAddInAvto.UseVisualStyleBackColor = true;
            buttonAddInAvto.Click += buttonAddInAvto_Click;
            // 
            // FormAvto
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(929, 621);
            Controls.Add(buttonAddInAvto);
            Controls.Add(groupBoxDatetehtalon);
            Controls.Add(groupBoxDateuchet);
            Controls.Add(label25);
            Controls.Add(label24);
            Controls.Add(textBoxyeartax);
            Controls.Add(textBoxtehtalonnumber);
            Controls.Add(textBoxyearv);
            Controls.Add(comboBoxdrivewheel);
            Controls.Add(comboBoxwheel);
            Controls.Add(textBoxpower);
            Controls.Add(textBoxvolume);
            Controls.Add(textBoxcolor);
            Controls.Add(textBoxbodymodel);
            Controls.Add(textBoxenginenumber);
            Controls.Add(textBoxchassisnumer);
            Controls.Add(textBoxbodynumber);
            Controls.Add(textBoxfirma);
            Controls.Add(textBoxname);
            Controls.Add(labelyeartax);
            Controls.Add(labeltehtalonnumber);
            Controls.Add(labelyearv);
            Controls.Add(labeldrivewheel);
            Controls.Add(labelwheel);
            Controls.Add(labelpower);
            Controls.Add(labelvolume);
            Controls.Add(labelcolor);
            Controls.Add(labelbodymodel);
            Controls.Add(labelenginenumber);
            Controls.Add(labelchassisnumber);
            Controls.Add(labelbodynumber);
            Controls.Add(labelfirma);
            Controls.Add(labelname);
            Controls.Add(labelregistrationnumber);
            Controls.Add(textBoxregistrationnumber);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FormAvto";
            Text = "Автомобиль";
            groupBoxDatetehtalon.ResumeLayout(false);
            groupBoxDateuchet.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxDatetehtalon;
        private DateTimePicker dateTimeDatetehtalon;
        private GroupBox groupBoxDateuchet;
        private DateTimePicker dateTimeDateucheta;
        private Label label25;
        private Label label24;
        private TextBox textBoxyeartax;
        private TextBox textBoxtehtalonnumber;
        private TextBox textBoxyearv;
        private ComboBox comboBoxdrivewheel;
        private ComboBox comboBoxwheel;
        private TextBox textBoxpower;
        private TextBox textBoxvolume;
        private TextBox textBoxcolor;
        private TextBox textBoxbodymodel;
        private TextBox textBoxenginenumber;
        private TextBox textBoxchassisnumer;
        private TextBox textBoxbodynumber;
        private TextBox textBoxfirma;
        private TextBox textBoxname;
        private Label labelyeartax;
        private Label labeltehtalonnumber;
        private Label labelyearv;
        private Label labeldrivewheel;
        private Label labelwheel;
        private Label labelpower;
        private Label labelvolume;
        private Label labelcolor;
        private Label labelbodymodel;
        private Label labelenginenumber;
        private Label labelchassisnumber;
        private Label labelbodynumber;
        private Label labelfirma;
        private Label labelname;
        private Label labelregistrationnumber;
        private TextBox textBoxregistrationnumber;
        private Button buttonAddInAvto;
    }
}