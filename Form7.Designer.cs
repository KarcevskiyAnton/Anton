namespace AccessDataBaseDemo
{
    partial class Form7
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "-при нажатии на кнопку \"АВТОМОБИЛЬ\" открывается окно ",
            "с базой данных об автомобиле;",
            "",
            "-при нажатии на кнопку \"ДОБАВИТЬ\" и при заполнении всех текстовых полей ",
            "появляется собщение\"Запись успешно добавлена\";",
            "",
            "-при нажатии на кнопку \"ОБНОВИТЬ\" отображается база данных",
            " с внесёнными изменениями;",
            "",
            "-при нажатии на кнопку \"УДАЛИТЬ\" и введении гос номера в текстовое поле ",
            "появляется собщение\"Запись успешно удалена\";",
            "",
            "-при введении в поле ввода данных и нажатие кнопки \"ПОИСК\" рядом с ним ",
            "отобразится строка с найденным совпадением",
            "",
            "-оставшиеся окна работают аналогично;"});
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(611, 276);
            this.listBox1.TabIndex = 0;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 276);
            this.Controls.Add(this.listBox1);
            this.Name = "Form7";
            this.Text = "Руководство пользователя";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
    }
}