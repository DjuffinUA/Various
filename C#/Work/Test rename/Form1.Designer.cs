namespace Test_rename
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
            this.Button_Dir = new System.Windows.Forms.Button();
            this.TextBox_NameList_In = new System.Windows.Forms.TextBox();
            this.TextBox_NameList_Out = new System.Windows.Forms.TextBox();
            this.Button_Run = new System.Windows.Forms.Button();
            this.TextBox_Find = new System.Windows.Forms.TextBox();
            this.TextBox_Rename = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Button_Dir
            // 
            this.Button_Dir.Location = new System.Drawing.Point(12, 12);
            this.Button_Dir.Name = "Button_Dir";
            this.Button_Dir.Size = new System.Drawing.Size(75, 23);
            this.Button_Dir.TabIndex = 0;
            this.Button_Dir.Text = "Dir";
            this.Button_Dir.UseVisualStyleBackColor = true;
            this.Button_Dir.Click += new System.EventHandler(this.Button_Dir_Click);
            // 
            // TextBox_NameList_In
            // 
            this.TextBox_NameList_In.Location = new System.Drawing.Point(12, 41);
            this.TextBox_NameList_In.Multiline = true;
            this.TextBox_NameList_In.Name = "TextBox_NameList_In";
            this.TextBox_NameList_In.Size = new System.Drawing.Size(346, 397);
            this.TextBox_NameList_In.TabIndex = 1;
            // 
            // TextBox_NameList_Out
            // 
            this.TextBox_NameList_Out.Location = new System.Drawing.Point(442, 41);
            this.TextBox_NameList_Out.Multiline = true;
            this.TextBox_NameList_Out.Name = "TextBox_NameList_Out";
            this.TextBox_NameList_Out.Size = new System.Drawing.Size(346, 397);
            this.TextBox_NameList_Out.TabIndex = 2;
            // 
            // Button_Run
            // 
            this.Button_Run.Location = new System.Drawing.Point(713, 12);
            this.Button_Run.Name = "Button_Run";
            this.Button_Run.Size = new System.Drawing.Size(75, 23);
            this.Button_Run.TabIndex = 3;
            this.Button_Run.Text = "Run";
            this.Button_Run.UseVisualStyleBackColor = true;
            this.Button_Run.Click += new System.EventHandler(this.Button_Run_Click);
            // 
            // TextBox_Find
            // 
            this.TextBox_Find.Location = new System.Drawing.Point(202, 14);
            this.TextBox_Find.Name = "TextBox_Find";
            this.TextBox_Find.Size = new System.Drawing.Size(156, 20);
            this.TextBox_Find.TabIndex = 4;
            // 
            // TextBox_Rename
            // 
            this.TextBox_Rename.Location = new System.Drawing.Point(442, 15);
            this.TextBox_Rename.Name = "TextBox_Rename";
            this.TextBox_Rename.Size = new System.Drawing.Size(156, 20);
            this.TextBox_Rename.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextBox_Rename);
            this.Controls.Add(this.TextBox_Find);
            this.Controls.Add(this.Button_Run);
            this.Controls.Add(this.TextBox_NameList_Out);
            this.Controls.Add(this.TextBox_NameList_In);
            this.Controls.Add(this.Button_Dir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Dir;
        private System.Windows.Forms.TextBox TextBox_NameList_In;
        private System.Windows.Forms.TextBox TextBox_NameList_Out;
        private System.Windows.Forms.Button Button_Run;
        private System.Windows.Forms.TextBox TextBox_Find;
        private System.Windows.Forms.TextBox TextBox_Rename;
    }
}

