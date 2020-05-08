namespace WindowsFormsApp8
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Timeh = new System.Windows.Forms.Label();
            this.MestTime = new System.Windows.Forms.Label();
            this.UT = new System.Windows.Forms.Label();
            this.hourLocal = new System.Windows.Forms.Label();
            this.MinuteLocal = new System.Windows.Forms.Label();
            this.SecondLocal = new System.Windows.Forms.Label();
            this.SecondUT = new System.Windows.Forms.Label();
            this.MinuteUT = new System.Windows.Forms.Label();
            this.hourUT = new System.Windows.Forms.Label();
            this.hourTime = new System.Windows.Forms.Label();
            this.MinuteTime = new System.Windows.Forms.Label();
            this.SecondTime = new System.Windows.Forms.Label();
            this.siti = new System.Windows.Forms.Label();
            this.cnisok = new System.Windows.Forms.ComboBox();
            this.Time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Timeh
            // 
            this.Timeh.AutoSize = true;
            this.Timeh.Location = new System.Drawing.Point(339, 88);
            this.Timeh.Name = "Timeh";
            this.Timeh.Size = new System.Drawing.Size(86, 13);
            this.Timeh.TabIndex = 0;
            this.Timeh.Text = "Часовые пояса";
            // 
            // MestTime
            // 
            this.MestTime.AutoSize = true;
            this.MestTime.Location = new System.Drawing.Point(12, 204);
            this.MestTime.Name = "MestTime";
            this.MestTime.Size = new System.Drawing.Size(88, 13);
            this.MestTime.TabIndex = 1;
            this.MestTime.Text = "местное время ";
            // 
            // UT
            // 
            this.UT.AutoSize = true;
            this.UT.Location = new System.Drawing.Point(671, 204);
            this.UT.Name = "UT";
            this.UT.Size = new System.Drawing.Size(125, 13);
            this.UT.TabIndex = 2;
            this.UT.Text = "Универсальное время ";
            // 
            // hourLocal
            // 
            this.hourLocal.AutoSize = true;
            this.hourLocal.Location = new System.Drawing.Point(12, 229);
            this.hourLocal.Name = "hourLocal";
            this.hourLocal.Size = new System.Drawing.Size(10, 13);
            this.hourLocal.TabIndex = 3;
            this.hourLocal.Text = " ";
            // 
            // MinuteLocal
            // 
            this.MinuteLocal.AutoSize = true;
            this.MinuteLocal.Location = new System.Drawing.Point(52, 229);
            this.MinuteLocal.Name = "MinuteLocal";
            this.MinuteLocal.Size = new System.Drawing.Size(10, 13);
            this.MinuteLocal.TabIndex = 4;
            this.MinuteLocal.Text = " ";
            // 
            // SecondLocal
            // 
            this.SecondLocal.AutoSize = true;
            this.SecondLocal.Location = new System.Drawing.Point(94, 229);
            this.SecondLocal.Name = "SecondLocal";
            this.SecondLocal.Size = new System.Drawing.Size(10, 13);
            this.SecondLocal.TabIndex = 5;
            this.SecondLocal.Text = " ";
            // 
            // SecondUT
            // 
            this.SecondUT.AutoSize = true;
            this.SecondUT.Location = new System.Drawing.Point(761, 229);
            this.SecondUT.Name = "SecondUT";
            this.SecondUT.Size = new System.Drawing.Size(10, 13);
            this.SecondUT.TabIndex = 6;
            this.SecondUT.Text = " ";
            // 
            // MinuteUT
            // 
            this.MinuteUT.AutoSize = true;
            this.MinuteUT.Location = new System.Drawing.Point(720, 229);
            this.MinuteUT.Name = "MinuteUT";
            this.MinuteUT.Size = new System.Drawing.Size(10, 13);
            this.MinuteUT.TabIndex = 7;
            this.MinuteUT.Text = " ";
            // 
            // hourUT
            // 
            this.hourUT.AutoSize = true;
            this.hourUT.Location = new System.Drawing.Point(679, 229);
            this.hourUT.Name = "hourUT";
            this.hourUT.Size = new System.Drawing.Size(10, 13);
            this.hourUT.TabIndex = 8;
            this.hourUT.Text = " ";
            // 
            // hourTime
            // 
            this.hourTime.AutoSize = true;
            this.hourTime.Location = new System.Drawing.Point(650, 352);
            this.hourTime.Name = "hourTime";
            this.hourTime.Size = new System.Drawing.Size(10, 13);
            this.hourTime.TabIndex = 9;
            this.hourTime.Text = " ";
            // 
            // MinuteTime
            // 
            this.MinuteTime.AutoSize = true;
            this.MinuteTime.Location = new System.Drawing.Point(697, 352);
            this.MinuteTime.Name = "MinuteTime";
            this.MinuteTime.Size = new System.Drawing.Size(10, 13);
            this.MinuteTime.TabIndex = 10;
            this.MinuteTime.Text = " ";
            // 
            // SecondTime
            // 
            this.SecondTime.AutoSize = true;
            this.SecondTime.Location = new System.Drawing.Point(747, 352);
            this.SecondTime.Name = "SecondTime";
            this.SecondTime.Size = new System.Drawing.Size(10, 13);
            this.SecondTime.TabIndex = 11;
            this.SecondTime.Text = " ";
            // 
            // siti
            // 
            this.siti.AutoSize = true;
            this.siti.Location = new System.Drawing.Point(12, 328);
            this.siti.Name = "siti";
            this.siti.Size = new System.Drawing.Size(43, 13);
            this.siti.TabIndex = 12;
            this.siti.Text = "Города";
            // 
            // cnisok
            // 
            this.cnisok.FormattingEnabled = true;
            this.cnisok.Location = new System.Drawing.Point(12, 344);
            this.cnisok.Name = "cnisok";
            this.cnisok.Size = new System.Drawing.Size(121, 21);
            this.cnisok.TabIndex = 13;
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Location = new System.Drawing.Point(747, 328);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(40, 13);
            this.Time.TabIndex = 14;
            this.Time.Text = "Время";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.cnisok);
            this.Controls.Add(this.siti);
            this.Controls.Add(this.SecondTime);
            this.Controls.Add(this.MinuteTime);
            this.Controls.Add(this.hourTime);
            this.Controls.Add(this.hourUT);
            this.Controls.Add(this.MinuteUT);
            this.Controls.Add(this.SecondUT);
            this.Controls.Add(this.SecondLocal);
            this.Controls.Add(this.MinuteLocal);
            this.Controls.Add(this.hourLocal);
            this.Controls.Add(this.UT);
            this.Controls.Add(this.MestTime);
            this.Controls.Add(this.Timeh);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Timeh;
        private System.Windows.Forms.Label MestTime;
        private System.Windows.Forms.Label UT;
        private System.Windows.Forms.Label hourLocal;
        private System.Windows.Forms.Label MinuteLocal;
        private System.Windows.Forms.Label SecondLocal;
        private System.Windows.Forms.Label SecondUT;
        private System.Windows.Forms.Label MinuteUT;
        private System.Windows.Forms.Label hourUT;
        private System.Windows.Forms.Label hourTime;
        private System.Windows.Forms.Label MinuteTime;
        private System.Windows.Forms.Label SecondTime;
        private System.Windows.Forms.Label siti;
        private System.Windows.Forms.ComboBox cnisok;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Timer timer1;
    }
}

