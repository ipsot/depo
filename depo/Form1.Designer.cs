
namespace depo
{
    partial class FormMainMenu
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
            this.buttonBus = new System.Windows.Forms.Button();
            this.buttonDriver = new System.Windows.Forms.Button();
            this.buttonRoute = new System.Windows.Forms.Button();
            this.buttonVoyage = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBus
            // 
            this.buttonBus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBus.Location = new System.Drawing.Point(82, 12);
            this.buttonBus.Name = "buttonBus";
            this.buttonBus.Size = new System.Drawing.Size(374, 91);
            this.buttonBus.TabIndex = 0;
            this.buttonBus.Text = "Просмотр автобусов";
            this.buttonBus.UseVisualStyleBackColor = true;
            this.buttonBus.Click += new System.EventHandler(this.buttonBus_Click);
            // 
            // buttonDriver
            // 
            this.buttonDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDriver.Location = new System.Drawing.Point(82, 109);
            this.buttonDriver.Name = "buttonDriver";
            this.buttonDriver.Size = new System.Drawing.Size(374, 91);
            this.buttonDriver.TabIndex = 1;
            this.buttonDriver.Text = "Просмотр водителей";
            this.buttonDriver.UseVisualStyleBackColor = true;
            this.buttonDriver.Click += new System.EventHandler(this.buttonDriver_Click);
            // 
            // buttonRoute
            // 
            this.buttonRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRoute.Location = new System.Drawing.Point(82, 206);
            this.buttonRoute.Name = "buttonRoute";
            this.buttonRoute.Size = new System.Drawing.Size(374, 91);
            this.buttonRoute.TabIndex = 2;
            this.buttonRoute.Text = "Просмотр маршрутов";
            this.buttonRoute.UseVisualStyleBackColor = true;
            this.buttonRoute.Click += new System.EventHandler(this.buttonRoute_Click);
            // 
            // buttonVoyage
            // 
            this.buttonVoyage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonVoyage.Location = new System.Drawing.Point(82, 303);
            this.buttonVoyage.Name = "buttonVoyage";
            this.buttonVoyage.Size = new System.Drawing.Size(374, 91);
            this.buttonVoyage.TabIndex = 3;
            this.buttonVoyage.Text = "Просмотр рейсов";
            this.buttonVoyage.UseVisualStyleBackColor = true;
            this.buttonVoyage.Click += new System.EventHandler(this.buttonVoyage_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(82, 498);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(374, 91);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.Text = "Выйти из программы";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 655);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonVoyage);
            this.Controls.Add(this.buttonRoute);
            this.Controls.Add(this.buttonDriver);
            this.Controls.Add(this.buttonBus);
            this.Name = "FormMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBus;
        private System.Windows.Forms.Button buttonDriver;
        private System.Windows.Forms.Button buttonRoute;
        private System.Windows.Forms.Button buttonVoyage;
        private System.Windows.Forms.Button buttonExit;
    }
}

