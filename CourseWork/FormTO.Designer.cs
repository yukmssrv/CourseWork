namespace CourseWork
{
    partial class FormTO
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
            comboBoxavtointo = new ComboBox();
            labelavtointo = new Label();
            dateTimedateTO = new DateTimePicker();
            textBoxTOpaysign = new TextBox();
            textBoxTOpay = new TextBox();
            textBoxTOprobeg = new TextBox();
            textBoxFIOinsp = new TextBox();
            labelTOpaysign = new Label();
            labelTOpay = new Label();
            labelTOprobeg = new Label();
            labelFIOinsp = new Label();
            labelDateTO = new Label();
            buttonAddInTO = new Button();
            SuspendLayout();
            // 
            // comboBoxavtointo
            // 
            comboBoxavtointo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxavtointo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxavtointo.FormattingEnabled = true;
            comboBoxavtointo.Location = new Point(295, 34);
            comboBoxavtointo.Name = "comboBoxavtointo";
            comboBoxavtointo.Size = new Size(161, 31);
            comboBoxavtointo.TabIndex = 63;
            // 
            // labelavtointo
            // 
            labelavtointo.AutoSize = true;
            labelavtointo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelavtointo.Location = new Point(39, 40);
            labelavtointo.Name = "labelavtointo";
            labelavtointo.Size = new Size(111, 23);
            labelavtointo.TabIndex = 62;
            labelavtointo.Text = "Автомобиль:";
            // 
            // dateTimedateTO
            // 
            dateTimedateTO.Location = new Point(295, 87);
            dateTimedateTO.Name = "dateTimedateTO";
            dateTimedateTO.Size = new Size(161, 30);
            dateTimedateTO.TabIndex = 61;
            // 
            // textBoxTOpaysign
            // 
            textBoxTOpaysign.BorderStyle = BorderStyle.FixedSingle;
            textBoxTOpaysign.Location = new Point(295, 292);
            textBoxTOpaysign.Name = "textBoxTOpaysign";
            textBoxTOpaysign.Size = new Size(162, 30);
            textBoxTOpaysign.TabIndex = 60;
            // 
            // textBoxTOpay
            // 
            textBoxTOpay.BorderStyle = BorderStyle.FixedSingle;
            textBoxTOpay.Location = new Point(295, 239);
            textBoxTOpay.Name = "textBoxTOpay";
            textBoxTOpay.Size = new Size(162, 30);
            textBoxTOpay.TabIndex = 59;
            // 
            // textBoxTOprobeg
            // 
            textBoxTOprobeg.BorderStyle = BorderStyle.FixedSingle;
            textBoxTOprobeg.Location = new Point(295, 184);
            textBoxTOprobeg.Name = "textBoxTOprobeg";
            textBoxTOprobeg.Size = new Size(162, 30);
            textBoxTOprobeg.TabIndex = 58;
            // 
            // textBoxFIOinsp
            // 
            textBoxFIOinsp.BorderStyle = BorderStyle.FixedSingle;
            textBoxFIOinsp.Location = new Point(295, 136);
            textBoxFIOinsp.Name = "textBoxFIOinsp";
            textBoxFIOinsp.Size = new Size(162, 30);
            textBoxFIOinsp.TabIndex = 57;
            // 
            // labelTOpaysign
            // 
            labelTOpaysign.AutoSize = true;
            labelTOpaysign.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelTOpaysign.Location = new Point(39, 292);
            labelTOpaysign.Name = "labelTOpaysign";
            labelTOpaysign.Size = new Size(160, 23);
            labelTOpaysign.TabIndex = 56;
            labelTOpaysign.Text = "Оплата за знак ТО:";
            // 
            // labelTOpay
            // 
            labelTOpay.AutoSize = true;
            labelTOpay.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelTOpay.Location = new Point(39, 239);
            labelTOpay.Name = "labelTOpay";
            labelTOpay.Size = new Size(120, 23);
            labelTOpay.TabIndex = 55;
            labelTOpay.Text = "Оплата за ТО:";
            // 
            // labelTOprobeg
            // 
            labelTOprobeg.AutoSize = true;
            labelTOprobeg.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelTOprobeg.Location = new Point(39, 184);
            labelTOprobeg.Name = "labelTOprobeg";
            labelTOprobeg.Size = new Size(161, 23);
            labelTOprobeg.TabIndex = 54;
            labelTOprobeg.Text = "Пробег на дату ТО:";
            // 
            // labelFIOinsp
            // 
            labelFIOinsp.AutoSize = true;
            labelFIOinsp.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelFIOinsp.Location = new Point(39, 137);
            labelFIOinsp.Name = "labelFIOinsp";
            labelFIOinsp.Size = new Size(148, 23);
            labelFIOinsp.TabIndex = 53;
            labelFIOinsp.Text = "ФИО инспектора:";
            // 
            // labelDateTO
            // 
            labelDateTO.AutoSize = true;
            labelDateTO.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelDateTO.Location = new Point(39, 87);
            labelDateTO.Name = "labelDateTO";
            labelDateTO.Size = new Size(204, 23);
            labelDateTO.TabIndex = 52;
            labelDateTO.Text = "Дата тех. обслуживания:";
            // 
            // buttonAddInTO
            // 
            buttonAddInTO.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddInTO.Location = new Point(473, 374);
            buttonAddInTO.Name = "buttonAddInTO";
            buttonAddInTO.Size = new Size(180, 46);
            buttonAddInTO.TabIndex = 82;
            buttonAddInTO.Text = "Добавить";
            buttonAddInTO.UseVisualStyleBackColor = true;
            buttonAddInTO.Click += buttonAddInTO_Click;
            // 
            // FormTO
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 434);
            Controls.Add(buttonAddInTO);
            Controls.Add(comboBoxavtointo);
            Controls.Add(labelavtointo);
            Controls.Add(dateTimedateTO);
            Controls.Add(textBoxTOpaysign);
            Controls.Add(textBoxTOpay);
            Controls.Add(textBoxTOprobeg);
            Controls.Add(textBoxFIOinsp);
            Controls.Add(labelTOpaysign);
            Controls.Add(labelTOpay);
            Controls.Add(labelTOprobeg);
            Controls.Add(labelFIOinsp);
            Controls.Add(labelDateTO);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FormTO";
            Text = "Технический осмотр";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxavtointo;
        private Label labelavtointo;
        private DateTimePicker dateTimedateTO;
        private TextBox textBoxTOpaysign;
        private TextBox textBoxTOpay;
        private TextBox textBoxTOprobeg;
        private TextBox textBoxFIOinsp;
        private Label labelTOpaysign;
        private Label labelTOpay;
        private Label labelTOprobeg;
        private Label labelFIOinsp;
        private Label labelDateTO;
        private Button buttonAddInTO;
    }
}