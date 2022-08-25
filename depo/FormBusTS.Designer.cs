
namespace depo
{
    partial class FormBusTS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewBusTS = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonMainMenu = new System.Windows.Forms.Button();
            this.buttonShowBus = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mileage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.change_details = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.change_consumables = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBusTS)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBusTS
            // 
            this.dataGridViewBusTS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBusTS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.mileage,
            this.change_details,
            this.change_consumables});
            this.dataGridViewBusTS.Location = new System.Drawing.Point(278, 39);
            this.dataGridViewBusTS.Name = "dataGridViewBusTS";
            this.dataGridViewBusTS.Size = new System.Drawing.Size(543, 299);
            this.dataGridViewBusTS.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(32, 39);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(183, 127);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(32, 211);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(183, 127);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonMainMenu
            // 
            this.buttonMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMainMenu.Location = new System.Drawing.Point(870, 12);
            this.buttonMainMenu.Name = "buttonMainMenu";
            this.buttonMainMenu.Size = new System.Drawing.Size(238, 127);
            this.buttonMainMenu.TabIndex = 3;
            this.buttonMainMenu.Text = "Главное меню";
            this.buttonMainMenu.UseVisualStyleBackColor = true;
            this.buttonMainMenu.Click += new System.EventHandler(this.buttonMainMenu_Click);
            // 
            // buttonShowBus
            // 
            this.buttonShowBus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowBus.Location = new System.Drawing.Point(870, 194);
            this.buttonShowBus.Name = "buttonShowBus";
            this.buttonShowBus.Size = new System.Drawing.Size(238, 127);
            this.buttonShowBus.TabIndex = 4;
            this.buttonShowBus.Text = "Просмотр автобусов";
            this.buttonShowBus.UseVisualStyleBackColor = true;
            this.buttonShowBus.Click += new System.EventHandler(this.buttonShowBus_Click);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // mileage
            // 
            this.mileage.HeaderText = "Пробег";
            this.mileage.Name = "mileage";
            // 
            // change_details
            // 
            this.change_details.HeaderText = "Замена деталей";
            this.change_details.Name = "change_details";
            this.change_details.Width = 200;
            // 
            // change_consumables
            // 
            this.change_consumables.HeaderText = "Расходные материалы";
            this.change_consumables.Name = "change_consumables";
            this.change_consumables.Width = 200;
            // 
            // FormBusTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 386);
            this.Controls.Add(this.buttonShowBus);
            this.Controls.Add(this.buttonMainMenu);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewBusTS);
            this.Name = "FormBusTS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBusTS";
            this.Load += new System.EventHandler(this.FormBusTS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBusTS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBusTS;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonMainMenu;
        private System.Windows.Forms.Button buttonShowBus;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn mileage;
        private System.Windows.Forms.DataGridViewTextBoxColumn change_details;
        private System.Windows.Forms.DataGridViewTextBoxColumn change_consumables;
    }
}