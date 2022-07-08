
namespace _Приложение_из_примера_по_курсовой
{
    partial class Form3
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
            this.panel_main = new System.Windows.Forms.Panel();
            this.label_start = new System.Windows.Forms.Label();
            this.label_exit = new System.Windows.Forms.Label();
            this.label_main = new System.Windows.Forms.Label();
            this.label_university = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel_main.Controls.Add(this.label3);
            this.panel_main.Controls.Add(this.label2);
            this.panel_main.Controls.Add(this.label1);
            this.panel_main.Controls.Add(this.label_start);
            this.panel_main.Controls.Add(this.label_exit);
            this.panel_main.Controls.Add(this.label_main);
            this.panel_main.Location = new System.Drawing.Point(0, 251);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(985, 240);
            this.panel_main.TabIndex = 3;
            // 
            // label_start
            // 
            this.label_start.AutoSize = true;
            this.label_start.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_start.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label_start.Location = new System.Drawing.Point(33, 187);
            this.label_start.Name = "label_start";
            this.label_start.Size = new System.Drawing.Size(105, 33);
            this.label_start.TabIndex = 0;
            this.label_start.Text = "Запуск";
            this.label_start.Click += new System.EventHandler(this.label_start_Click);
            this.label_start.MouseLeave += new System.EventHandler(this.label_start_MouseLeave);
            this.label_start.MouseHover += new System.EventHandler(this.label_start_MouseHover);
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_exit.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label_exit.Location = new System.Drawing.Point(851, 187);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(98, 33);
            this.label_exit.TabIndex = 4;
            this.label_exit.Text = "Выход";
            this.label_exit.Click += new System.EventHandler(this.label_exit_Click);
            this.label_exit.MouseLeave += new System.EventHandler(this.label_exit_MouseLeave);
            this.label_exit.MouseHover += new System.EventHandler(this.label_exit_MouseHover);
            // 
            // label_main
            // 
            this.label_main.AutoSize = true;
            this.label_main.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_main.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label_main.Location = new System.Drawing.Point(372, 187);
            this.label_main.Name = "label_main";
            this.label_main.Size = new System.Drawing.Size(200, 33);
            this.label_main.TabIndex = 3;
            this.label_main.Text = "Главное меню";
            this.label_main.Click += new System.EventHandler(this.label_main_Click);
            this.label_main.MouseLeave += new System.EventHandler(this.label_main_MouseLeave);
            this.label_main.MouseHover += new System.EventHandler(this.label_main_MouseHover);
            // 
            // label_university
            // 
            this.label_university.AutoSize = true;
            this.label_university.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_university.ForeColor = System.Drawing.SystemColors.Info;
            this.label_university.Location = new System.Drawing.Point(175, 518);
            this.label_university.Name = "label_university";
            this.label_university.Size = new System.Drawing.Size(630, 13);
            this.label_university.TabIndex = 4;
            this.label_university.Text = "ФГБОУ ВО «Сибирский государственный университет имени М.Ф. Решетнева» Лесосибирск" +
    "ий филиал";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(39, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Курсовая работа по дисциплине \"Программирование\"";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(39, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(586, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Тема: \"Разработка приложения с графическим интерфейсом \"Деканат\"\"";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(39, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(435, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Разработал: студент группы БИТ20-11 Лукомский В.О.";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.label_university);
            this.Controls.Add(this.panel_main);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "Form3";
            this.Text = "Информация о приложении";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Label label_start;
        private System.Windows.Forms.Label label_exit;
        private System.Windows.Forms.Label label_main;
        private System.Windows.Forms.Label label_university;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}