
namespace _Приложение_из_примера_по_курсовой
{
    partial class Form2
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel_main = new System.Windows.Forms.Panel();
            this.label_main = new System.Windows.Forms.Label();
            this.label_exit = new System.Windows.Forms.Label();
            this.label_information = new System.Windows.Forms.Label();
            this.label_university = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 60);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(960, 357);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel_main.Controls.Add(this.label_main);
            this.panel_main.Controls.Add(this.label_exit);
            this.panel_main.Controls.Add(this.label_information);
            this.panel_main.Location = new System.Drawing.Point(0, 439);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(984, 66);
            this.panel_main.TabIndex = 3;
            // 
            // label_main
            // 
            this.label_main.AutoSize = true;
            this.label_main.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_main.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label_main.Location = new System.Drawing.Point(44, 12);
            this.label_main.Name = "label_main";
            this.label_main.Size = new System.Drawing.Size(200, 33);
            this.label_main.TabIndex = 0;
            this.label_main.Text = "Главное меню";
            this.label_main.Click += new System.EventHandler(this.label_main_Click);
            this.label_main.MouseLeave += new System.EventHandler(this.label_main_MouseLeave);
            this.label_main.MouseHover += new System.EventHandler(this.label_main_MouseHover);
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_exit.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label_exit.Location = new System.Drawing.Point(780, 12);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(98, 33);
            this.label_exit.TabIndex = 4;
            this.label_exit.Text = "Выход";
            this.label_exit.Click += new System.EventHandler(this.label_exit_Click);
            this.label_exit.MouseLeave += new System.EventHandler(this.label_exit_MouseLeave);
            this.label_exit.MouseHover += new System.EventHandler(this.label_exit_MouseHover);
            // 
            // label_information
            // 
            this.label_information.AutoSize = true;
            this.label_information.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_information.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label_information.Location = new System.Drawing.Point(427, 12);
            this.label_information.Name = "label_information";
            this.label_information.Size = new System.Drawing.Size(194, 33);
            this.label_information.TabIndex = 3;
            this.label_information.Text = "Информация";
            this.label_information.Click += new System.EventHandler(this.label_information_Click);
            this.label_information.MouseLeave += new System.EventHandler(this.label_information_MouseLeave);
            this.label_information.MouseHover += new System.EventHandler(this.label_information_MouseHover);
            // 
            // label_university
            // 
            this.label_university.AutoSize = true;
            this.label_university.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_university.ForeColor = System.Drawing.SystemColors.Info;
            this.label_university.Location = new System.Drawing.Point(201, 527);
            this.label_university.Name = "label_university";
            this.label_university.Size = new System.Drawing.Size(630, 13);
            this.label_university.TabIndex = 4;
            this.label_university.Text = "ФГБОУ ВО «Сибирский государственный университет имени М.Ф. Решетнева» Лесосибирск" +
    "ий филиал";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "Запуск расчетов";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(122, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 32);
            this.button2.TabIndex = 6;
            this.button2.Text = "Сохранить данные";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(980, 558);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_university);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form2";
            this.Text = "Расчет итоговых значений";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Label label_main;
        private System.Windows.Forms.Label label_exit;
        private System.Windows.Forms.Label label_information;
        private System.Windows.Forms.Label label_university;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}