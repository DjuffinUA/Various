namespace Сharacter_Interface
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
            this.Avatar = new System.Windows.Forms.PictureBox();
            this.LineTitle = new System.Windows.Forms.TextBox();
            this.NameLine = new System.Windows.Forms.TextBox();
            this.LineStaminaMana = new System.Windows.Forms.TextBox();
            this.LineVitality = new System.Windows.Forms.TextBox();
            this.LineStrength = new System.Windows.Forms.TextBox();
            this.LineAgility = new System.Windows.Forms.TextBox();
            this.LineIntellect = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Level = new System.Windows.Forms.NumericUpDown();
            this.Class = new System.Windows.Forms.ComboBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelClass = new System.Windows.Forms.Label();
            this.labelLevel = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelCharacteristics = new System.Windows.Forms.Label();
            this.labelHP = new System.Windows.Forms.Label();
            this.labelStaminaMana = new System.Windows.Forms.Label();
            this.labelVitality = new System.Windows.Forms.Label();
            this.labelStrength = new System.Windows.Forms.Label();
            this.labelAgility = new System.Windows.Forms.Label();
            this.labelIntellect = new System.Windows.Forms.Label();
            this.labelHP2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Level)).BeginInit();
            this.SuspendLayout();
            // 
            // Avatar
            // 
            this.Avatar.BackColor = System.Drawing.Color.Gray;
            this.Avatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.Avatar, "Avatar");
            this.Avatar.Name = "Avatar";
            this.Avatar.TabStop = false;
            // 
            // LineTitle
            // 
            resources.ApplyResources(this.LineTitle, "LineTitle");
            this.LineTitle.Name = "LineTitle";
            // 
            // NameLine
            // 
            resources.ApplyResources(this.NameLine, "NameLine");
            this.NameLine.Name = "NameLine";
            // 
            // LineStaminaMana
            // 
            resources.ApplyResources(this.LineStaminaMana, "LineStaminaMana");
            this.LineStaminaMana.Name = "LineStaminaMana";
            // 
            // LineVitality
            // 
            resources.ApplyResources(this.LineVitality, "LineVitality");
            this.LineVitality.Name = "LineVitality";
            // 
            // LineStrength
            // 
            resources.ApplyResources(this.LineStrength, "LineStrength");
            this.LineStrength.Name = "LineStrength";
            // 
            // LineAgility
            // 
            resources.ApplyResources(this.LineAgility, "LineAgility");
            this.LineAgility.Name = "LineAgility";
            // 
            // LineIntellect
            // 
            resources.ApplyResources(this.LineIntellect, "LineIntellect");
            this.LineIntellect.Name = "LineIntellect";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // Level
            // 
            resources.ApplyResources(this.Level, "Level");
            this.Level.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Level.Name = "Level";
            this.Level.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Class
            // 
            this.Class.FormattingEnabled = true;
            this.Class.Items.AddRange(new object[] {
            resources.GetString("Class.Items"),
            resources.GetString("Class.Items1"),
            resources.GetString("Class.Items2"),
            resources.GetString("Class.Items3")});
            resources.ApplyResources(this.Class, "Class");
            this.Class.Name = "Class";
            // 
            // labelName
            // 
            resources.ApplyResources(this.labelName, "labelName");
            this.labelName.Name = "labelName";
            // 
            // labelClass
            // 
            resources.ApplyResources(this.labelClass, "labelClass");
            this.labelClass.Name = "labelClass";
            // 
            // labelLevel
            // 
            resources.ApplyResources(this.labelLevel, "labelLevel");
            this.labelLevel.Name = "labelLevel";
            // 
            // labelTitle
            // 
            resources.ApplyResources(this.labelTitle, "labelTitle");
            this.labelTitle.Name = "labelTitle";
            // 
            // labelCharacteristics
            // 
            resources.ApplyResources(this.labelCharacteristics, "labelCharacteristics");
            this.labelCharacteristics.Name = "labelCharacteristics";
            // 
            // labelHP
            // 
            resources.ApplyResources(this.labelHP, "labelHP");
            this.labelHP.Name = "labelHP";
            // 
            // labelStaminaMana
            // 
            resources.ApplyResources(this.labelStaminaMana, "labelStaminaMana");
            this.labelStaminaMana.Name = "labelStaminaMana";
            // 
            // labelVitality
            // 
            resources.ApplyResources(this.labelVitality, "labelVitality");
            this.labelVitality.Name = "labelVitality";
            // 
            // labelStrength
            // 
            resources.ApplyResources(this.labelStrength, "labelStrength");
            this.labelStrength.Name = "labelStrength";
            // 
            // labelAgility
            // 
            resources.ApplyResources(this.labelAgility, "labelAgility");
            this.labelAgility.Name = "labelAgility";
            // 
            // labelIntellect
            // 
            resources.ApplyResources(this.labelIntellect, "labelIntellect");
            this.labelIntellect.Name = "labelIntellect";
            // 
            // labelHP2
            // 
            resources.ApplyResources(this.labelHP2, "labelHP2");
            this.labelHP2.Name = "labelHP2";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelHP2);
            this.Controls.Add(this.labelIntellect);
            this.Controls.Add(this.labelAgility);
            this.Controls.Add(this.labelStrength);
            this.Controls.Add(this.labelVitality);
            this.Controls.Add(this.labelStaminaMana);
            this.Controls.Add(this.labelHP);
            this.Controls.Add(this.labelCharacteristics);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelLevel);
            this.Controls.Add(this.labelClass);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.Class);
            this.Controls.Add(this.Level);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.LineIntellect);
            this.Controls.Add(this.LineAgility);
            this.Controls.Add(this.LineStrength);
            this.Controls.Add(this.LineVitality);
            this.Controls.Add(this.LineStaminaMana);
            this.Controls.Add(this.NameLine);
            this.Controls.Add(this.LineTitle);
            this.Controls.Add(this.Avatar);
            this.MaximizeBox = false;
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Level)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Avatar;
        private System.Windows.Forms.TextBox LineTitle;
        private System.Windows.Forms.TextBox NameLine;
        private System.Windows.Forms.TextBox LineStaminaMana;
        private System.Windows.Forms.TextBox LineVitality;
        private System.Windows.Forms.TextBox LineStrength;
        private System.Windows.Forms.TextBox LineAgility;
        private System.Windows.Forms.TextBox LineIntellect;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.NumericUpDown Level;
        private System.Windows.Forms.ComboBox Class;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelCharacteristics;
        private System.Windows.Forms.Label labelHP;
        private System.Windows.Forms.Label labelStaminaMana;
        private System.Windows.Forms.Label labelVitality;
        private System.Windows.Forms.Label labelStrength;
        private System.Windows.Forms.Label labelAgility;
        private System.Windows.Forms.Label labelIntellect;
        private System.Windows.Forms.Label labelHP2;
    }
}

