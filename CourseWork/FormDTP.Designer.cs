namespace CourseWork
{
    partial class FormDTP
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
            groupBoxPartDTP = new GroupBox();
            groupBox3 = new GroupBox();
            comboBoxpartDtpAvto = new ComboBox();
            groupBox2 = new GroupBox();
            comboBoxpartDtpDriver = new ComboBox();
            listBoxPartDTP = new ListBox();
            buttonDeletepartDTP = new Button();
            buttonAddpartDTP = new Button();
            dateTimedateDTP = new DateTimePicker();
            richTextBoxDescriptions = new RichTextBox();
            textBoxFIOinspDTP = new TextBox();
            textBoxplaceDTP = new TextBox();
            comboBoxseverityDTP = new ComboBox();
            labelDescriptions = new Label();
            labelfioinspDTP = new Label();
            labeleverityDTP = new Label();
            labelplaceDTP = new Label();
            labelDateDTP = new Label();
            buttonAddInDTP = new Button();
            groupBoxPartDTP.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxPartDTP
            // 
            groupBoxPartDTP.Controls.Add(groupBox3);
            groupBoxPartDTP.Controls.Add(groupBox2);
            groupBoxPartDTP.Controls.Add(listBoxPartDTP);
            groupBoxPartDTP.Controls.Add(buttonDeletepartDTP);
            groupBoxPartDTP.Controls.Add(buttonAddpartDTP);
            groupBoxPartDTP.Location = new Point(43, 120);
            groupBoxPartDTP.Name = "groupBoxPartDTP";
            groupBoxPartDTP.Size = new Size(825, 171);
            groupBoxPartDTP.TabIndex = 68;
            groupBoxPartDTP.TabStop = false;
            groupBoxPartDTP.Text = "Перечень участников ДТП";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(comboBoxpartDtpAvto);
            groupBox3.Location = new Point(228, 30);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(199, 80);
            groupBox3.TabIndex = 60;
            groupBox3.TabStop = false;
            groupBox3.Text = "Автомобиль";
            // 
            // comboBoxpartDtpAvto
            // 
            comboBoxpartDtpAvto.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxpartDtpAvto.FormattingEnabled = true;
            comboBoxpartDtpAvto.Location = new Point(7, 33);
            comboBoxpartDtpAvto.Name = "comboBoxpartDtpAvto";
            comboBoxpartDtpAvto.Size = new Size(185, 31);
            comboBoxpartDtpAvto.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBoxpartDtpDriver);
            groupBox2.Location = new Point(9, 30);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(199, 80);
            groupBox2.TabIndex = 59;
            groupBox2.TabStop = false;
            groupBox2.Text = "Водитель:";
            // 
            // comboBoxpartDtpDriver
            // 
            comboBoxpartDtpDriver.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxpartDtpDriver.FormattingEnabled = true;
            comboBoxpartDtpDriver.Location = new Point(7, 33);
            comboBoxpartDtpDriver.Name = "comboBoxpartDtpDriver";
            comboBoxpartDtpDriver.Size = new Size(185, 31);
            comboBoxpartDtpDriver.TabIndex = 1;
            // 
            // listBoxPartDTP
            // 
            listBoxPartDTP.FormattingEnabled = true;
            listBoxPartDTP.ItemHeight = 23;
            listBoxPartDTP.Location = new Point(450, 30);
            listBoxPartDTP.Name = "listBoxPartDTP";
            listBoxPartDTP.Size = new Size(367, 96);
            listBoxPartDTP.TabIndex = 58;
            // 
            // buttonDeletepartDTP
            // 
            buttonDeletepartDTP.Location = new Point(158, 121);
            buttonDeletepartDTP.Name = "buttonDeletepartDTP";
            buttonDeletepartDTP.Size = new Size(135, 33);
            buttonDeletepartDTP.TabIndex = 57;
            buttonDeletepartDTP.Text = "Удалить";
            buttonDeletepartDTP.UseVisualStyleBackColor = true;
            buttonDeletepartDTP.Click += buttonDeletepartDTP_Click;
            // 
            // buttonAddpartDTP
            // 
            buttonAddpartDTP.Location = new Point(16, 121);
            buttonAddpartDTP.Name = "buttonAddpartDTP";
            buttonAddpartDTP.Size = new Size(135, 33);
            buttonAddpartDTP.TabIndex = 55;
            buttonAddpartDTP.Text = "Добавить";
            buttonAddpartDTP.UseVisualStyleBackColor = true;
            buttonAddpartDTP.Click += buttonAddpartDTP_Click;
            // 
            // dateTimedateDTP
            // 
            dateTimedateDTP.Location = new Point(493, 32);
            dateTimedateDTP.Name = "dateTimedateDTP";
            dateTimedateDTP.Size = new Size(205, 30);
            dateTimedateDTP.TabIndex = 64;
            // 
            // richTextBoxDescriptions
            // 
            richTextBoxDescriptions.Location = new Point(30, 434);
            richTextBoxDescriptions.Name = "richTextBoxDescriptions";
            richTextBoxDescriptions.Size = new Size(836, 95);
            richTextBoxDescriptions.TabIndex = 63;
            richTextBoxDescriptions.Text = "";
            // 
            // textBoxFIOinspDTP
            // 
            textBoxFIOinspDTP.BorderStyle = BorderStyle.FixedSingle;
            textBoxFIOinspDTP.Location = new Point(493, 344);
            textBoxFIOinspDTP.Name = "textBoxFIOinspDTP";
            textBoxFIOinspDTP.Size = new Size(206, 30);
            textBoxFIOinspDTP.TabIndex = 62;
            // 
            // textBoxplaceDTP
            // 
            textBoxplaceDTP.BorderStyle = BorderStyle.FixedSingle;
            textBoxplaceDTP.Location = new Point(493, 75);
            textBoxplaceDTP.Name = "textBoxplaceDTP";
            textBoxplaceDTP.Size = new Size(206, 30);
            textBoxplaceDTP.TabIndex = 61;
            // 
            // comboBoxseverityDTP
            // 
            comboBoxseverityDTP.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxseverityDTP.FormattingEnabled = true;
            comboBoxseverityDTP.Items.AddRange(new object[] { "Легкой тяжести", "Средней тяжести", "Тяжкое ДТП", "Катастрофическое ДТП" });
            comboBoxseverityDTP.Location = new Point(493, 298);
            comboBoxseverityDTP.Name = "comboBoxseverityDTP";
            comboBoxseverityDTP.Size = new Size(205, 31);
            comboBoxseverityDTP.TabIndex = 60;
            // 
            // labelDescriptions
            // 
            labelDescriptions.AutoSize = true;
            labelDescriptions.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelDescriptions.Location = new Point(43, 389);
            labelDescriptions.Name = "labelDescriptions";
            labelDescriptions.Size = new Size(131, 23);
            labelDescriptions.TabIndex = 59;
            labelDescriptions.Text = "Описание ДТП:";
            // 
            // labelfioinspDTP
            // 
            labelfioinspDTP.AutoSize = true;
            labelfioinspDTP.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelfioinspDTP.Location = new Point(43, 345);
            labelfioinspDTP.Name = "labelfioinspDTP";
            labelfioinspDTP.Size = new Size(398, 23);
            labelfioinspDTP.TabIndex = 58;
            labelfioinspDTP.Text = "ФИО инспектора, проводившего расследование:";
            // 
            // labeleverityDTP
            // 
            labeleverityDTP.AutoSize = true;
            labeleverityDTP.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labeleverityDTP.Location = new Point(43, 299);
            labeleverityDTP.Name = "labeleverityDTP";
            labeleverityDTP.Size = new Size(185, 23);
            labeleverityDTP.TabIndex = 57;
            labeleverityDTP.Text = "Степень тяжести ДТП:";
            // 
            // labelplaceDTP
            // 
            labelplaceDTP.AutoSize = true;
            labelplaceDTP.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelplaceDTP.Location = new Point(43, 79);
            labelplaceDTP.Name = "labelplaceDTP";
            labelplaceDTP.Size = new Size(101, 23);
            labelplaceDTP.TabIndex = 56;
            labelplaceDTP.Text = "Место ДТП:";
            // 
            // labelDateDTP
            // 
            labelDateDTP.AutoSize = true;
            labelDateDTP.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelDateDTP.Location = new Point(43, 37);
            labelDateDTP.Name = "labelDateDTP";
            labelDateDTP.Size = new Size(89, 23);
            labelDateDTP.TabIndex = 55;
            labelDateDTP.Text = "Дата ДТП:";
            // 
            // buttonAddInDTP
            // 
            buttonAddInDTP.Location = new Point(706, 604);
            buttonAddInDTP.Name = "buttonAddInDTP";
            buttonAddInDTP.Size = new Size(180, 46);
            buttonAddInDTP.TabIndex = 83;
            buttonAddInDTP.Text = "Добавить";
            buttonAddInDTP.UseVisualStyleBackColor = true;
            buttonAddInDTP.Click += buttonAddInDTP_Click;
            // 
            // FormDTP
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 664);
            Controls.Add(buttonAddInDTP);
            Controls.Add(groupBoxPartDTP);
            Controls.Add(dateTimedateDTP);
            Controls.Add(richTextBoxDescriptions);
            Controls.Add(textBoxFIOinspDTP);
            Controls.Add(textBoxplaceDTP);
            Controls.Add(comboBoxseverityDTP);
            Controls.Add(labelDescriptions);
            Controls.Add(labelfioinspDTP);
            Controls.Add(labeleverityDTP);
            Controls.Add(labelplaceDTP);
            Controls.Add(labelDateDTP);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FormDTP";
            Text = "Дорожно-транспортное происшествие";
            groupBoxPartDTP.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxPartDTP;
        private GroupBox groupBox3;
        private ComboBox comboBoxpartDtpAvto;
        private GroupBox groupBox2;
        private ComboBox comboBoxpartDtpDriver;
        private ListBox listBoxPartDTP;
        private Button buttonDeletepartDTP;
        private Button buttonAddpartDTP;
        private DateTimePicker dateTimedateDTP;
        private RichTextBox richTextBoxDescriptions;
        private TextBox textBoxFIOinspDTP;
        private TextBox textBoxplaceDTP;
        private ComboBox comboBoxseverityDTP;
        private Label labelDescriptions;
        private Label labelfioinspDTP;
        private Label labeleverityDTP;
        private Label labelplaceDTP;
        private Label labelDateDTP;
        private Button buttonAddInDTP;
    }
}