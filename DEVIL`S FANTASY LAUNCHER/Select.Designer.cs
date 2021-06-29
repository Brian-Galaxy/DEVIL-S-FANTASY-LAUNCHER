
namespace DEVIL_S_FANTASY_LAUNCHER
{
    partial class selectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(selectForm));
            this.clsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clsBtn
            // 
            this.clsBtn.BackColor = System.Drawing.Color.Red;
            this.clsBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.clsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.clsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.clsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clsBtn.Font = new System.Drawing.Font("Anonymous Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clsBtn.Location = new System.Drawing.Point(793, 0);
            this.clsBtn.Name = "clsBtn";
            this.clsBtn.Size = new System.Drawing.Size(41, 23);
            this.clsBtn.TabIndex = 0;
            this.clsBtn.TabStop = false;
            this.clsBtn.Text = "X";
            this.clsBtn.UseVisualStyleBackColor = false;
            this.clsBtn.Click += new System.EventHandler(this.clsBtn_Click);
            // 
            // selectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.clsBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "selectForm";
            this.Text = "DEVIL`S FANTASY LAUNCHER";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button clsBtn;
    }
}

