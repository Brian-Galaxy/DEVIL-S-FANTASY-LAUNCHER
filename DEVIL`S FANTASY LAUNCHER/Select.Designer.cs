
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
            this.authPnl = new System.Windows.Forms.Panel();
            this.passBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.inCheck = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.authPnl.SuspendLayout();
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
            // authPnl
            // 
            this.authPnl.BackgroundImage = global::DEVIL_S_FANTASY_LAUNCHER.Properties.Resources._1579214717_1_2;
            this.authPnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.authPnl.Controls.Add(this.button1);
            this.authPnl.Controls.Add(this.passBox);
            this.authPnl.Controls.Add(this.nameBox);
            this.authPnl.Controls.Add(this.inCheck);
            this.authPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.authPnl.Location = new System.Drawing.Point(0, 0);
            this.authPnl.Name = "authPnl";
            this.authPnl.Size = new System.Drawing.Size(834, 461);
            this.authPnl.TabIndex = 1;
            this.authPnl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.authPnl_MouseDown);
            // 
            // passBox
            // 
            this.passBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.passBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passBox.Font = new System.Drawing.Font("Anonymous Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passBox.Location = new System.Drawing.Point(158, 162);
            this.passBox.Name = "passBox";
            this.passBox.PasswordChar = '⩈';
            this.passBox.Size = new System.Drawing.Size(163, 20);
            this.passBox.TabIndex = 2;
            this.passBox.Text = "Пароль";
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.nameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameBox.Font = new System.Drawing.Font("Anonymous Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameBox.Location = new System.Drawing.Point(158, 136);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(163, 20);
            this.nameBox.TabIndex = 1;
            this.nameBox.Text = "Логин";
            // 
            // inCheck
            // 
            this.inCheck.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.inCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.inCheck.Font = new System.Drawing.Font("Anonymous Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inCheck.Location = new System.Drawing.Point(247, 250);
            this.inCheck.Name = "inCheck";
            this.inCheck.Size = new System.Drawing.Size(104, 24);
            this.inCheck.TabIndex = 0;
            this.inCheck.Text = "Запомнить?";
            this.inCheck.UseVisualStyleBackColor = false;
            this.inCheck.CheckStateChanged += new System.EventHandler(this.inCheck_CheckStateChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Anonymous Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(589, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Войти";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // selectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.clsBtn);
            this.Controls.Add(this.authPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "selectForm";
            this.Text = "DEVIL`S FANTASY LAUNCHER";
            this.authPnl.ResumeLayout(false);
            this.authPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button clsBtn;
        private System.Windows.Forms.Panel authPnl;
        private System.Windows.Forms.CheckBox inCheck;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.Button button1;
    }
}

