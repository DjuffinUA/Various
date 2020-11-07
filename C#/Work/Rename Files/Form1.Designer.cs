namespace Rename_Files
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
            this.Button_Dir = new System.Windows.Forms.Button();
            this.Buton_Rename = new System.Windows.Forms.Button();
            this.TextBox_NewName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBox_ToFind = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBox_Replace = new System.Windows.Forms.TextBox();
            this.Button_Replace = new System.Windows.Forms.Button();
            this.Lable_Rename = new System.Windows.Forms.Label();
            this.Lable_Dir = new System.Windows.Forms.Label();
            this.Label_DirLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Button_Dir
            // 
            this.Button_Dir.Location = new System.Drawing.Point(13, 13);
            this.Button_Dir.Margin = new System.Windows.Forms.Padding(4);
            this.Button_Dir.Name = "Button_Dir";
            this.Button_Dir.Size = new System.Drawing.Size(137, 32);
            this.Button_Dir.TabIndex = 0;
            this.Button_Dir.Text = "Выбор папки";
            this.Button_Dir.UseVisualStyleBackColor = true;
            this.Button_Dir.Click += new System.EventHandler(this.Button_Dir_Click);
            // 
            // Buton_Rename
            // 
            this.Buton_Rename.Location = new System.Drawing.Point(524, 83);
            this.Buton_Rename.Margin = new System.Windows.Forms.Padding(4);
            this.Buton_Rename.Name = "Buton_Rename";
            this.Buton_Rename.Size = new System.Drawing.Size(139, 32);
            this.Buton_Rename.TabIndex = 1;
            this.Buton_Rename.Text = "Переименовать";
            this.Buton_Rename.UseVisualStyleBackColor = true;
            this.Buton_Rename.Visible = false;
            this.Buton_Rename.Click += new System.EventHandler(this.Buton_Rename_Click);
            // 
            // TextBox_NewName
            // 
            this.TextBox_NewName.Location = new System.Drawing.Point(287, 87);
            this.TextBox_NewName.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_NewName.Name = "TextBox_NewName";
            this.TextBox_NewName.Size = new System.Drawing.Size(232, 26);
            this.TextBox_NewName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Найти:";
            // 
            // TextBox_ToFind
            // 
            this.TextBox_ToFind.Location = new System.Drawing.Point(287, 121);
            this.TextBox_ToFind.Name = "TextBox_ToFind";
            this.TextBox_ToFind.Size = new System.Drawing.Size(232, 26);
            this.TextBox_ToFind.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Заменить на:";
            // 
            // TextBox_Replace
            // 
            this.TextBox_Replace.Location = new System.Drawing.Point(287, 153);
            this.TextBox_Replace.Name = "TextBox_Replace";
            this.TextBox_Replace.Size = new System.Drawing.Size(232, 26);
            this.TextBox_Replace.TabIndex = 6;
            // 
            // Button_Replace
            // 
            this.Button_Replace.Location = new System.Drawing.Point(524, 122);
            this.Button_Replace.Name = "Button_Replace";
            this.Button_Replace.Size = new System.Drawing.Size(139, 58);
            this.Button_Replace.TabIndex = 7;
            this.Button_Replace.Text = "Заменить";
            this.Button_Replace.UseVisualStyleBackColor = true;
            this.Button_Replace.Click += new System.EventHandler(this.Button_Replace_Click);
            // 
            // Lable_Rename
            // 
            this.Lable_Rename.AutoSize = true;
            this.Lable_Rename.Location = new System.Drawing.Point(12, 90);
            this.Lable_Rename.Name = "Lable_Rename";
            this.Lable_Rename.Size = new System.Drawing.Size(270, 18);
            this.Lable_Rename.TabIndex = 8;
            this.Lable_Rename.Text = "Что добавить перед именем файла:";
            // 
            // Lable_Dir
            // 
            this.Lable_Dir.AutoEllipsis = true;
            this.Lable_Dir.AutoSize = true;
            this.Lable_Dir.BackColor = System.Drawing.Color.Transparent;
            this.Lable_Dir.Cursor = System.Windows.Forms.Cursors.Help;
            this.Lable_Dir.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lable_Dir.Location = new System.Drawing.Point(286, 63);
            this.Lable_Dir.MaximumSize = new System.Drawing.Size(376, 18);
            this.Lable_Dir.MinimumSize = new System.Drawing.Size(0, 18);
            this.Lable_Dir.Name = "Lable_Dir";
            this.Lable_Dir.Size = new System.Drawing.Size(137, 18);
            this.Lable_Dir.TabIndex = 9;
            this.Lable_Dir.Text = "Папка не выбрана";
            this.Lable_Dir.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Lable_Dir_MouseDown);
            // 
            // Label_DirLable
            // 
            this.Label_DirLable.AutoSize = true;
            this.Label_DirLable.BackColor = System.Drawing.SystemColors.Control;
            this.Label_DirLable.Location = new System.Drawing.Point(156, 61);
            this.Label_DirLable.Name = "Label_DirLable";
            this.Label_DirLable.Size = new System.Drawing.Size(124, 18);
            this.Label_DirLable.TabIndex = 10;
            this.Label_DirLable.Text = "Выбрана папка:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 191);
            this.Controls.Add(this.Label_DirLable);
            this.Controls.Add(this.Lable_Dir);
            this.Controls.Add(this.Lable_Rename);
            this.Controls.Add(this.Button_Replace);
            this.Controls.Add(this.TextBox_Replace);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBox_ToFind);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBox_NewName);
            this.Controls.Add(this.Buton_Rename);
            this.Controls.Add(this.Button_Dir);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(692, 230);
            this.MinimumSize = new System.Drawing.Size(692, 230);
            this.Name = "Form1";
            this.Text = "Переименование файлов";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Dir;
        private System.Windows.Forms.Button Buton_Rename;
        private System.Windows.Forms.TextBox TextBox_NewName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBox_ToFind;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBox_Replace;
        private System.Windows.Forms.Button Button_Replace;
        private System.Windows.Forms.Label Lable_Rename;
        private System.Windows.Forms.Label Lable_Dir;
        private System.Windows.Forms.Label Label_DirLable;
    }
}

