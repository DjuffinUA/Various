﻿namespace Excel_v1._2
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
            this.Open = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Run = new System.Windows.Forms.Button();
            this.Box_Open = new System.Windows.Forms.TextBox();
            this.Table_Run = new System.Windows.Forms.DataGridView();
            this.RefSes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_colum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pattern = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Side = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Table_Run)).BeginInit();
            this.SuspendLayout();
            // 
            // Open
            // 
            this.Open.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Open.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Open.Location = new System.Drawing.Point(156, 27);
            this.Open.MinimumSize = new System.Drawing.Size(0, 30);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(114, 30);
            this.Open.TabIndex = 0;
            this.Open.Text = "Открыть";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Save.Location = new System.Drawing.Point(414, 27);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(114, 30);
            this.Save.TabIndex = 1;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Run
            // 
            this.Run.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Run.Location = new System.Drawing.Point(672, 27);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(114, 30);
            this.Run.TabIndex = 2;
            this.Run.Text = "Выполнить";
            this.Run.UseVisualStyleBackColor = true;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // Box_Open
            // 
            this.Box_Open.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Box_Open.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Box_Open.Location = new System.Drawing.Point(12, 90);
            this.Box_Open.MaximumSize = new System.Drawing.Size(900, 800);
            this.Box_Open.MinimumSize = new System.Drawing.Size(450, 400);
            this.Box_Open.Multiline = true;
            this.Box_Open.Name = "Box_Open";
            this.Box_Open.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Box_Open.Size = new System.Drawing.Size(450, 400);
            this.Box_Open.TabIndex = 3;
            this.Box_Open.WordWrap = false;
            // 
            // Table_Run
            // 
            this.Table_Run.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table_Run.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RefSes,
            this.Name_colum,
            this.Pattern,
            this.Side,
            this.Value,
            this.Total});
            this.Table_Run.Location = new System.Drawing.Point(482, 89);
            this.Table_Run.Name = "Table_Run";
            this.Table_Run.RowTemplate.ReadOnly = true;
            this.Table_Run.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Table_Run.Size = new System.Drawing.Size(450, 400);
            this.Table_Run.TabIndex = 4;
            // 
            // RefSes
            // 
            this.RefSes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.RefSes.Frozen = true;
            this.RefSes.HeaderText = "RefSes";
            this.RefSes.Name = "RefSes";
            this.RefSes.Width = 67;
            // 
            // Name_colum
            // 
            this.Name_colum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Name_colum.Frozen = true;
            this.Name_colum.HeaderText = "Name";
            this.Name_colum.Name = "Name_colum";
            this.Name_colum.Width = 60;
            // 
            // Pattern
            // 
            this.Pattern.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Pattern.Frozen = true;
            this.Pattern.HeaderText = "Pattern";
            this.Pattern.Name = "Pattern";
            this.Pattern.Width = 66;
            // 
            // Side
            // 
            this.Side.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Side.Frozen = true;
            this.Side.HeaderText = "Side";
            this.Side.Name = "Side";
            this.Side.Width = 53;
            // 
            // Value
            // 
            this.Value.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Value.Frozen = true;
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            this.Value.Width = 59;
            // 
            // Total
            // 
            this.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Total.Frozen = true;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.Width = 56;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.Table_Run);
            this.Controls.Add(this.Box_Open);
            this.Controls.Add(this.Run);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Open);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(960, 540);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Table_Run)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Run;
        private System.Windows.Forms.TextBox Box_Open;
        private System.Windows.Forms.DataGridView Table_Run;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefSes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_colum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pattern;
        private System.Windows.Forms.DataGridViewTextBoxColumn Side;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}
