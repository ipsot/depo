
namespace depo
{
    partial class FormRoute
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
            this.buttonAddFinish = new System.Windows.Forms.Button();
            this.buttonAddStart = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxFinish = new System.Windows.Forms.ComboBox();
            this.comboBoxStart = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddFinish
            // 
            this.buttonAddFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddFinish.Location = new System.Drawing.Point(429, 342);
            this.buttonAddFinish.Name = "buttonAddFinish";
            this.buttonAddFinish.Size = new System.Drawing.Size(359, 50);
            this.buttonAddFinish.TabIndex = 17;
            this.buttonAddFinish.Text = "Добавить новую точку конца пути";
            this.buttonAddFinish.UseVisualStyleBackColor = true;
            this.buttonAddFinish.Click += new System.EventHandler(this.buttonAddFinish_Click);
            // 
            // buttonAddStart
            // 
            this.buttonAddStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddStart.Location = new System.Drawing.Point(12, 342);
            this.buttonAddStart.Name = "buttonAddStart";
            this.buttonAddStart.Size = new System.Drawing.Size(359, 50);
            this.buttonAddStart.TabIndex = 16;
            this.buttonAddStart.Text = "Добавить новую точку отправления";
            this.buttonAddStart.UseVisualStyleBackColor = true;
            this.buttonAddStart.Click += new System.EventHandler(this.buttonAddStart_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(12, 251);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(443, 50);
            this.buttonDelete.TabIndex = 15;
            this.buttonDelete.Text = "Удалить путь";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(494, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Конец пути";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(494, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Начало пути";
            // 
            // comboBoxFinish
            // 
            this.comboBoxFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxFinish.FormattingEnabled = true;
            this.comboBoxFinish.Location = new System.Drawing.Point(498, 139);
            this.comboBoxFinish.Name = "comboBoxFinish";
            this.comboBoxFinish.Size = new System.Drawing.Size(280, 32);
            this.comboBoxFinish.TabIndex = 12;
            // 
            // comboBoxStart
            // 
            this.comboBoxStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxStart.FormattingEnabled = true;
            this.comboBoxStart.Location = new System.Drawing.Point(498, 64);
            this.comboBoxStart.Name = "comboBoxStart";
            this.comboBoxStart.Size = new System.Drawing.Size(280, 32);
            this.comboBoxStart.TabIndex = 11;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(498, 191);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(280, 50);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "Добавить новый путь";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.start,
            this.finish});
            this.dataGridView1.Location = new System.Drawing.Point(12, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(443, 207);
            this.dataGridView1.TabIndex = 9;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // start
            // 
            this.start.HeaderText = "Начало пути";
            this.start.Name = "start";
            this.start.ReadOnly = true;
            this.start.Width = 200;
            // 
            // finish
            // 
            this.finish.HeaderText = "Конец пути";
            this.finish.Name = "finish";
            this.finish.ReadOnly = true;
            this.finish.Width = 200;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(835, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 84);
            this.button1.TabIndex = 18;
            this.button1.Text = "Главное меню";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonAddFinish);
            this.Controls.Add(this.buttonAddStart);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxFinish);
            this.Controls.Add(this.comboBoxStart);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormRoute";
            this.Text = "FormRoute";
            this.Load += new System.EventHandler(this.FormRoute_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddFinish;
        private System.Windows.Forms.Button buttonAddStart;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxFinish;
        private System.Windows.Forms.ComboBox comboBoxStart;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn start;
        private System.Windows.Forms.DataGridViewTextBoxColumn finish;
        private System.Windows.Forms.Button button1;
    }
}