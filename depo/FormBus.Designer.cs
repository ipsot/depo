
namespace depo
{
    partial class FormBus
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
            this.dataGridViewBus = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonTS = new System.Windows.Forms.Button();
            this.buttonMainMenu = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sitting_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_ts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBus)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBus
            // 
            this.dataGridViewBus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.type,
            this.model,
            this.DateTS,
            this.sitting_count,
            this.id_ts});
            this.dataGridViewBus.Location = new System.Drawing.Point(189, 49);
            this.dataGridViewBus.Name = "dataGridViewBus";
            this.dataGridViewBus.Size = new System.Drawing.Size(644, 419);
            this.dataGridViewBus.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(35, 94);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(135, 141);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(35, 293);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(135, 141);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonTS
            // 
            this.buttonTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTS.Location = new System.Drawing.Point(870, 293);
            this.buttonTS.Name = "buttonTS";
            this.buttonTS.Size = new System.Drawing.Size(153, 141);
            this.buttonTS.TabIndex = 3;
            this.buttonTS.Text = "Техническое обслуживание";
            this.buttonTS.UseVisualStyleBackColor = true;
            this.buttonTS.Click += new System.EventHandler(this.buttonTS_Click);
            // 
            // buttonMainMenu
            // 
            this.buttonMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMainMenu.Location = new System.Drawing.Point(870, 49);
            this.buttonMainMenu.Name = "buttonMainMenu";
            this.buttonMainMenu.Size = new System.Drawing.Size(135, 141);
            this.buttonMainMenu.TabIndex = 4;
            this.buttonMainMenu.Text = "Главное меню";
            this.buttonMainMenu.UseVisualStyleBackColor = true;
            this.buttonMainMenu.Click += new System.EventHandler(this.buttonMainMenu_Click);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // type
            // 
            this.type.HeaderText = "Тип";
            this.type.Name = "type";
            this.type.Width = 150;
            // 
            // model
            // 
            this.model.HeaderText = "Модель";
            this.model.Name = "model";
            this.model.Width = 150;
            // 
            // DateTS
            // 
            this.DateTS.HeaderText = "Дата тех. обслуживания";
            this.DateTS.Name = "DateTS";
            // 
            // sitting_count
            // 
            this.sitting_count.HeaderText = "Количество мест для сидения";
            this.sitting_count.Name = "sitting_count";
            // 
            // id_ts
            // 
            this.id_ts.HeaderText = "Номер чека о прохождении ТО";
            this.id_ts.Name = "id_ts";
            // 
            // FormBus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 546);
            this.Controls.Add(this.buttonMainMenu);
            this.Controls.Add(this.buttonTS);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewBus);
            this.Name = "FormBus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBus";
            this.Load += new System.EventHandler(this.FormBus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBus;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonTS;
        private System.Windows.Forms.Button buttonMainMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn model;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTS;
        private System.Windows.Forms.DataGridViewTextBoxColumn sitting_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_ts;
    }
}