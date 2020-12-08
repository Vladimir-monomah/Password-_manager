namespace Менеджер_паролей
{
    partial class FormPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPassword));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btPassword3 = new System.Windows.Forms.Button();
            this.tbLogin3 = new System.Windows.Forms.TextBox();
            this.llSite3 = new System.Windows.Forms.LinkLabel();
            this.btPassword2 = new System.Windows.Forms.Button();
            this.tbLogin2 = new System.Windows.Forms.TextBox();
            this.llSite2 = new System.Windows.Forms.LinkLabel();
            this.tbLogin1 = new System.Windows.Forms.TextBox();
            this.btPassword1 = new System.Windows.Forms.Button();
            this.llSite1 = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.btPassword3, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbLogin3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.llSite3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btPassword2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbLogin2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.llSite2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbLogin1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btPassword1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.llSite1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(678, 151);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btPassword3
            // 
            this.btPassword3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btPassword3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btPassword3.Location = new System.Drawing.Point(454, 103);
            this.btPassword3.Name = "btPassword3";
            this.btPassword3.Size = new System.Drawing.Size(221, 45);
            this.btPassword3.TabIndex = 8;
            this.btPassword3.Text = "пароль";
            this.btPassword3.UseVisualStyleBackColor = true;
            this.btPassword3.Click += new System.EventHandler(this.btPassword1_Click);
            // 
            // tbLogin3
            // 
            this.tbLogin3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLogin3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLogin3.Location = new System.Drawing.Point(228, 103);
            this.tbLogin3.Multiline = true;
            this.tbLogin3.Name = "tbLogin3";
            this.tbLogin3.ReadOnly = true;
            this.tbLogin3.Size = new System.Drawing.Size(220, 45);
            this.tbLogin3.TabIndex = 7;
            this.tbLogin3.Text = "vladimir-bykov-1999@mail.ru";
            this.tbLogin3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbLogin3.Click += new System.EventHandler(this.tbLogin1_Click);
            // 
            // llSite3
            // 
            this.llSite3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.llSite3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.llSite3.Location = new System.Drawing.Point(3, 100);
            this.llSite3.Name = "llSite3";
            this.llSite3.Size = new System.Drawing.Size(219, 51);
            this.llSite3.TabIndex = 6;
            this.llSite3.TabStop = true;
            this.llSite3.Tag = "http://aliexpress.com";
            this.llSite3.Text = "aliexpress";
            this.llSite3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.llSite3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llSite1_LinkClicked);
            // 
            // btPassword2
            // 
            this.btPassword2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btPassword2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btPassword2.Location = new System.Drawing.Point(454, 53);
            this.btPassword2.Name = "btPassword2";
            this.btPassword2.Size = new System.Drawing.Size(221, 44);
            this.btPassword2.TabIndex = 5;
            this.btPassword2.Text = "пароль";
            this.btPassword2.UseVisualStyleBackColor = true;
            this.btPassword2.Click += new System.EventHandler(this.btPassword1_Click);
            // 
            // tbLogin2
            // 
            this.tbLogin2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLogin2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLogin2.Location = new System.Drawing.Point(228, 53);
            this.tbLogin2.Multiline = true;
            this.tbLogin2.Name = "tbLogin2";
            this.tbLogin2.ReadOnly = true;
            this.tbLogin2.Size = new System.Drawing.Size(220, 44);
            this.tbLogin2.TabIndex = 4;
            this.tbLogin2.Text = "hobbit20141999@gmai.com";
            this.tbLogin2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbLogin2.Click += new System.EventHandler(this.tbLogin1_Click);
            // 
            // llSite2
            // 
            this.llSite2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.llSite2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.llSite2.Location = new System.Drawing.Point(3, 50);
            this.llSite2.Name = "llSite2";
            this.llSite2.Size = new System.Drawing.Size(219, 50);
            this.llSite2.TabIndex = 3;
            this.llSite2.TabStop = true;
            this.llSite2.Tag = "http://www.gmail.com";
            this.llSite2.Text = "gmail.com";
            this.llSite2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.llSite2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llSite1_LinkClicked);
            // 
            // tbLogin1
            // 
            this.tbLogin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLogin1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLogin1.Location = new System.Drawing.Point(228, 3);
            this.tbLogin1.Multiline = true;
            this.tbLogin1.Name = "tbLogin1";
            this.tbLogin1.ReadOnly = true;
            this.tbLogin1.Size = new System.Drawing.Size(220, 44);
            this.tbLogin1.TabIndex = 0;
            this.tbLogin1.Text = "vladimir-bykov-1999@mail.ru";
            this.tbLogin1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbLogin1.Click += new System.EventHandler(this.tbLogin1_Click);
            // 
            // btPassword1
            // 
            this.btPassword1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btPassword1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btPassword1.Location = new System.Drawing.Point(454, 3);
            this.btPassword1.Name = "btPassword1";
            this.btPassword1.Size = new System.Drawing.Size(221, 44);
            this.btPassword1.TabIndex = 1;
            this.btPassword1.Tag = "14031999KIR";
            this.btPassword1.Text = "пароль";
            this.btPassword1.UseVisualStyleBackColor = true;
            this.btPassword1.Click += new System.EventHandler(this.btPassword1_Click);
            // 
            // llSite1
            // 
            this.llSite1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.llSite1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.llSite1.Location = new System.Drawing.Point(3, 0);
            this.llSite1.Name = "llSite1";
            this.llSite1.Size = new System.Drawing.Size(219, 50);
            this.llSite1.TabIndex = 2;
            this.llSite1.TabStop = true;
            this.llSite1.Tag = "http://videosharp.info";
            this.llSite1.Text = "VideoSharp.info";
            this.llSite1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.llSite1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llSite1_LinkClicked);
            // 
            // FormPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 151);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Мои пароли";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btPassword3;
        private System.Windows.Forms.TextBox tbLogin3;
        private System.Windows.Forms.LinkLabel llSite3;
        private System.Windows.Forms.Button btPassword2;
        private System.Windows.Forms.TextBox tbLogin2;
        private System.Windows.Forms.LinkLabel llSite2;
        private System.Windows.Forms.TextBox tbLogin1;
        private System.Windows.Forms.Button btPassword1;
        private System.Windows.Forms.LinkLabel llSite1;
    }
}

