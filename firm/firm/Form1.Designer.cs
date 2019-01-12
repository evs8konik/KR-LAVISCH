namespace firm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьРезервнуюКопиюБазыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.войтиКакАдминистраторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgv_Department = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgv_employee = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgv_Expense = new System.Windows.Forms.DataGridView();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Limit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_description = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bt_del = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.dgv_Check = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Department)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_employee)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Expense)).BeginInit();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Check)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(582, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьРезервнуюКопиюБазыToolStripMenuItem,
            this.войтиКакАдминистраторToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // создатьРезервнуюКопиюБазыToolStripMenuItem
            // 
            this.создатьРезервнуюКопиюБазыToolStripMenuItem.Name = "создатьРезервнуюКопиюБазыToolStripMenuItem";
            this.создатьРезервнуюКопиюБазыToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.создатьРезервнуюКопиюБазыToolStripMenuItem.Text = "Создать резервную копию базы";
            this.создатьРезервнуюКопиюБазыToolStripMenuItem.Click += new System.EventHandler(this.создатьРезервнуюКопиюБазыToolStripMenuItem_Click);
            // 
            // войтиКакАдминистраторToolStripMenuItem
            // 
            this.войтиКакАдминистраторToolStripMenuItem.Name = "войтиКакАдминистраторToolStripMenuItem";
            this.войтиКакАдминистраторToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.войтиКакАдминистраторToolStripMenuItem.Text = "Войти как администратор";
            this.войтиКакАдминистраторToolStripMenuItem.Click += new System.EventHandler(this.войтиКакАдминистраторToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dgv_Check);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(550, 356);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "Чеки";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgv_Department);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(550, 356);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Отделы";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgv_Department
            // 
            this.dgv_Department.AllowUserToAddRows = false;
            this.dgv_Department.AllowUserToDeleteRows = false;
            this.dgv_Department.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Department.Location = new System.Drawing.Point(16, 13);
            this.dgv_Department.MultiSelect = false;
            this.dgv_Department.Name = "dgv_Department";
            this.dgv_Department.ReadOnly = true;
            this.dgv_Department.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Department.Size = new System.Drawing.Size(520, 327);
            this.dgv_Department.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgv_employee);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(550, 356);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Сотрудники";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgv_employee
            // 
            this.dgv_employee.AllowUserToAddRows = false;
            this.dgv_employee.AllowUserToDeleteRows = false;
            this.dgv_employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_employee.Location = new System.Drawing.Point(17, 20);
            this.dgv_employee.MultiSelect = false;
            this.dgv_employee.Name = "dgv_employee";
            this.dgv_employee.ReadOnly = true;
            this.dgv_employee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_employee.Size = new System.Drawing.Size(519, 321);
            this.dgv_employee.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bt_del);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.tb_description);
            this.tabPage2.Controls.Add(this.tb_Limit);
            this.tabPage2.Controls.Add(this.tb_Name);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.dgv_Expense);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(550, 356);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Виды расходов";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgv_Expense
            // 
            this.dgv_Expense.AllowUserToAddRows = false;
            this.dgv_Expense.AllowUserToDeleteRows = false;
            this.dgv_Expense.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dgv_Expense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Expense.Location = new System.Drawing.Point(6, 6);
            this.dgv_Expense.MultiSelect = false;
            this.dgv_Expense.Name = "dgv_Expense";
            this.dgv_Expense.ReadOnly = true;
            this.dgv_Expense.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Expense.Size = new System.Drawing.Size(539, 289);
            this.dgv_Expense.TabIndex = 0;
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(6, 320);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(100, 20);
            this.tb_Name.TabIndex = 1;
            this.tb_Name.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите название";
            this.label1.Visible = false;
            // 
            // tb_Limit
            // 
            this.tb_Limit.Location = new System.Drawing.Point(131, 320);
            this.tb_Limit.Name = "tb_Limit";
            this.tb_Limit.Size = new System.Drawing.Size(100, 20);
            this.tb_Limit.TabIndex = 3;
            this.tb_Limit.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Лимит денег";
            this.label2.Visible = false;
            // 
            // tb_description
            // 
            this.tb_description.Location = new System.Drawing.Point(256, 320);
            this.tb_description.Name = "tb_description";
            this.tb_description.Size = new System.Drawing.Size(100, 20);
            this.tb_description.TabIndex = 5;
            this.tb_description.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Описание";
            this.label3.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(388, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_del
            // 
            this.bt_del.Location = new System.Drawing.Point(470, 317);
            this.bt_del.Name = "bt_del";
            this.bt_del.Size = new System.Drawing.Size(75, 23);
            this.bt_del.TabIndex = 8;
            this.bt_del.Text = "Удалить";
            this.bt_del.UseVisualStyleBackColor = true;
            this.bt_del.Visible = false;
            this.bt_del.Click += new System.EventHandler(this.bt_del_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 35);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(558, 382);
            this.tabControl1.TabIndex = 0;
            // 
            // dgv_Check
            // 
            this.dgv_Check.AllowUserToAddRows = false;
            this.dgv_Check.AllowUserToDeleteRows = false;
            this.dgv_Check.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Check.Location = new System.Drawing.Point(13, 20);
            this.dgv_Check.MultiSelect = false;
            this.dgv_Check.Name = "dgv_Check";
            this.dgv_Check.ReadOnly = true;
            this.dgv_Check.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Check.Size = new System.Drawing.Size(521, 321);
            this.dgv_Check.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 429);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Firm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Department)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_employee)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Expense)).EndInit();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Check)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьРезервнуюКопиюБазыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem войтиКакАдминистраторToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dgv_Check;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgv_Department;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgv_employee;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button bt_del;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_description;
        private System.Windows.Forms.TextBox tb_Limit;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Expense;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

