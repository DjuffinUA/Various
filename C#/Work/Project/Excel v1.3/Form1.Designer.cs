namespace Excel_v1._3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.B_Open = new System.Windows.Forms.Button();
            this.B_Save = new System.Windows.Forms.Button();
            this.B_Run = new System.Windows.Forms.Button();
            this.B_Text = new System.Windows.Forms.TextBox();
            this.Colum_2 = new System.Windows.Forms.ComboBox();
            this.Colum_5 = new System.Windows.Forms.ComboBox();
            this.Colum_4 = new System.Windows.Forms.ComboBox();
            this.Colum_3 = new System.Windows.Forms.ComboBox();
            this.B_Help = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // B_Open
            // 
            this.B_Open.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B_Open.Location = new System.Drawing.Point(13, 13);
            this.B_Open.Margin = new System.Windows.Forms.Padding(4);
            this.B_Open.Name = "B_Open";
            this.B_Open.Size = new System.Drawing.Size(112, 32);
            this.B_Open.TabIndex = 0;
            this.B_Open.Text = "Открыть";
            this.B_Open.UseVisualStyleBackColor = true;
            this.B_Open.Click += new System.EventHandler(this.B_Open_Click);
            // 
            // B_Save
            // 
            this.B_Save.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B_Save.Location = new System.Drawing.Point(133, 13);
            this.B_Save.Margin = new System.Windows.Forms.Padding(4);
            this.B_Save.Name = "B_Save";
            this.B_Save.Size = new System.Drawing.Size(112, 32);
            this.B_Save.TabIndex = 1;
            this.B_Save.Text = "Сохранить";
            this.B_Save.UseVisualStyleBackColor = true;
            this.B_Save.Click += new System.EventHandler(this.B_Save_Click);
            // 
            // B_Run
            // 
            this.B_Run.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B_Run.Location = new System.Drawing.Point(253, 13);
            this.B_Run.Margin = new System.Windows.Forms.Padding(4);
            this.B_Run.Name = "B_Run";
            this.B_Run.Size = new System.Drawing.Size(112, 32);
            this.B_Run.TabIndex = 2;
            this.B_Run.Text = "Выполнить";
            this.B_Run.UseVisualStyleBackColor = true;
            this.B_Run.Click += new System.EventHandler(this.B_Run_Click);
            // 
            // B_Text
            // 
            this.B_Text.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B_Text.Location = new System.Drawing.Point(13, 53);
            this.B_Text.Margin = new System.Windows.Forms.Padding(4);
            this.B_Text.Multiline = true;
            this.B_Text.Name = "B_Text";
            this.B_Text.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.B_Text.Size = new System.Drawing.Size(1238, 615);
            this.B_Text.TabIndex = 3;
            // 
            // Colum_2
            // 
            this.Colum_2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Colum_2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Colum_2.FormattingEnabled = true;
            this.Colum_2.Location = new System.Drawing.Point(507, 17);
            this.Colum_2.Margin = new System.Windows.Forms.Padding(4);
            this.Colum_2.MaxDropDownItems = 10;
            this.Colum_2.Name = "Colum_2";
            this.Colum_2.Size = new System.Drawing.Size(180, 26);
            this.Colum_2.TabIndex = 5;
            this.Colum_2.SelectedIndexChanged += new System.EventHandler(this.Colum_2_SelectedIndexChanged);
            // 
            // Colum_5
            // 
            this.Colum_5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Colum_5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Colum_5.FormattingEnabled = true;
            this.Colum_5.Location = new System.Drawing.Point(1071, 17);
            this.Colum_5.Margin = new System.Windows.Forms.Padding(4);
            this.Colum_5.MaxDropDownItems = 10;
            this.Colum_5.Name = "Colum_5";
            this.Colum_5.Size = new System.Drawing.Size(180, 26);
            this.Colum_5.TabIndex = 6;
            this.Colum_5.SelectedIndexChanged += new System.EventHandler(this.Colum_5_SelectedIndexChanged);
            // 
            // Colum_4
            // 
            this.Colum_4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Colum_4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Colum_4.FormattingEnabled = true;
            this.Colum_4.Location = new System.Drawing.Point(883, 17);
            this.Colum_4.Margin = new System.Windows.Forms.Padding(4);
            this.Colum_4.MaxDropDownItems = 10;
            this.Colum_4.Name = "Colum_4";
            this.Colum_4.Size = new System.Drawing.Size(180, 26);
            this.Colum_4.TabIndex = 7;
            this.Colum_4.SelectedIndexChanged += new System.EventHandler(this.Colum_4_SelectedIndexChanged);
            // 
            // Colum_3
            // 
            this.Colum_3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Colum_3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Colum_3.FormattingEnabled = true;
            this.Colum_3.Location = new System.Drawing.Point(695, 17);
            this.Colum_3.Margin = new System.Windows.Forms.Padding(4);
            this.Colum_3.MaxDropDownItems = 10;
            this.Colum_3.Name = "Colum_3";
            this.Colum_3.Size = new System.Drawing.Size(180, 26);
            this.Colum_3.TabIndex = 8;
            this.Colum_3.SelectedIndexChanged += new System.EventHandler(this.Colum_3_SelectedIndexChanged);
            // 
            // B_Help
            // 
            this.B_Help.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B_Help.Location = new System.Drawing.Point(373, 13);
            this.B_Help.Margin = new System.Windows.Forms.Padding(4);
            this.B_Help.Name = "B_Help";
            this.B_Help.Size = new System.Drawing.Size(112, 32);
            this.B_Help.TabIndex = 9;
            this.B_Help.Text = "Справка";
            this.B_Help.UseVisualStyleBackColor = true;
            this.B_Help.Click += new System.EventHandler(this.B_Help_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.B_Help);
            this.Controls.Add(this.Colum_3);
            this.Controls.Add(this.Colum_4);
            this.Controls.Add(this.Colum_5);
            this.Controls.Add(this.Colum_2);
            this.Controls.Add(this.B_Text);
            this.Controls.Add(this.B_Run);
            this.Controls.Add(this.B_Save);
            this.Controls.Add(this.B_Open);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "Form1";
            this.Text = "Сортировка CSV файлов";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_Open;
        private System.Windows.Forms.Button B_Save;
        private System.Windows.Forms.Button B_Run;
        private System.Windows.Forms.TextBox B_Text;
        private System.Windows.Forms.ComboBox Colum_2;
        private System.Windows.Forms.ComboBox Colum_5;
        private System.Windows.Forms.ComboBox Colum_4;
        private System.Windows.Forms.ComboBox Colum_3;
        private System.Windows.Forms.Button B_Help;
    }
}

