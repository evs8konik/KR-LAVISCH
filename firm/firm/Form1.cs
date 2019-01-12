
using System;
using System.Data;

using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace firm
{
    
    public partial class Form1 : Form
    {
        public firmEntities entering;
        Form Password;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Button b_ok;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Button bt_Cancel;
        public Form1()
        {
            InitializeComponent();
            RebootExpense();
            RebootEmployee();
            RebootDepartment();
            RebootCheck();
            создатьРезервнуюКопиюБазыToolStripMenuItem.Visible = false;
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        private void создатьРезервнуюКопиюБазыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rezerv();
            MessageBox.Show("Резервное копирование совершено! Копию можно найти в папке C:\\Program Files\\Microsoft SQL Server\\MSSQL12.MSSQLSERVER\\MSSQL\\Backup", "Внимание!",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1);
        }
        private void rezerv()
        {
            SqlConnection connect = new SqlConnection(
                              @"server=POLLYPUH;Trusted_Connection=yes;database=firm;connection timeout=30");
            connect.Open();
            SqlCommand com = new SqlCommand(@"BACKUP DATABASE [firm] TO DISK = 'backupdb.bak' WITH INIT , NOUNLOAD ,  NOSKIP , STATS = 10, NOFORMAT", connect);
            SqlDataReader r = com.ExecuteReader();
            connect.Close();
        }

        private void RebootExpense()
        {
            entering = new firmEntities();
            var expenses = from Expense in entering.Expense_ET select Expense;
            DataTable dt_expenses = new DataTable("Expense");
            dt_expenses.Columns.Add("ID", typeof(Int32));
            dt_expenses.Columns.Add("Название вида расходов", typeof(String));
            dt_expenses.Columns.Add("Предельная сумма", typeof(Double));
            dt_expenses.Columns.Add("Описание вида расходов", typeof(String));
            dt_expenses.Columns.Add("Баланс", typeof(Double));
            foreach (var expense in expenses)
                dt_expenses.Rows.Add(
                    expense.ID_expense,
                    expense.Expense_name,
                    expense.Limit_sum,
                    expense.Expense_describe,
                    expense.Balance
                   );
            dgv_Expense.DataSource = dt_expenses;
        }

        private void RebootCheck()
        {
            entering = new firmEntities();
            var checks = from Check_emp in entering.Check_emp_ET select Check_emp;
            DataTable dt_checks = new DataTable("Check_emp");
            dt_checks.Columns.Add("ID", typeof(Int32));
            dt_checks.Columns.Add("Фамилия сотрудника", typeof(String));
            dt_checks.Columns.Add("Сумма", typeof(Double));
            dt_checks.Columns.Add("Код", typeof(Int32));
            dt_checks.Columns.Add("Название типа расходов", typeof(String));
            dt_checks.Columns.Add("Дата", typeof(DateTime));
            foreach (var ch in checks)
                dt_checks.Rows.Add(
                    ch.ID_check,
                    ch.Employee.FIO_employee,
                    ch.Amount,
                    ch.Code,
                    ch.Expense.Expense_name,
                    ch.Date_check
                   );
            dgv_Check.DataSource = dt_checks;
        }


        private void RebootEmployee()
        {
            entering = new firmEntities();
            var employees = from Employee in entering.Employee_ET select Employee;
            DataTable dt_employees = new DataTable("Employee");
            dt_employees.Columns.Add("ID", typeof(Int32));
            dt_employees.Columns.Add("ФИО", typeof(String));
            dt_employees.Columns.Add("Отдел", typeof(String));
            foreach (var employee in employees)
                dt_employees.Rows.Add(
                    employee.ID_employee,
                    employee.FIO_employee,
                    employee.Department.Department_name);
            dgv_employee.DataSource = dt_employees;
        }

        private void RebootDepartment()
        {
            entering = new firmEntities();
            var deps = from Department in entering.Department_ET select Department;
            DataTable dt_departments = new DataTable("Employee");
            dt_departments.Columns.Add("ID", typeof(Int32));
            dt_departments.Columns.Add("Название", typeof(String));
            dt_departments.Columns.Add("Количество работников", typeof(Int32));
            foreach (var dep in deps)
                dt_departments.Rows.Add(
                    dep.ID_department,
                    dep.Department_name,
                    dep.Employee_count);
            dgv_Department.DataSource = dt_departments;
        }

        private void войтиКакАдминистраторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Password = new Form();
            tb_password = new System.Windows.Forms.TextBox();
            b_ok = new System.Windows.Forms.Button();
            lb1 = new System.Windows.Forms.Label();
            bt_Cancel = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // tb_password
            // 
            tb_password.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            tb_password.Location = new System.Drawing.Point(54, 66);
            tb_password.Name = "tb_password";
            tb_password.PasswordChar = '*';
            tb_password.Size = new System.Drawing.Size(141, 36);
            tb_password.TabIndex = 0;
            // 
            // b_ok
            // 
            b_ok.BackColor = System.Drawing.Color.Transparent;
            b_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            b_ok.Location = new System.Drawing.Point(54, 117);
            b_ok.Name = "b_ok";
            b_ok.Size = new System.Drawing.Size(141, 42);
            b_ok.TabIndex = 1;
            b_ok.Text = "Ok";
            b_ok.UseVisualStyleBackColor = false;
            b_ok.Click += new System.EventHandler(this.b_ok_Click);
            // 
            // label1
            // 
            lb1.AutoSize = true;
            lb1.BackColor = System.Drawing.Color.Transparent;
            lb1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            lb1.Location = new System.Drawing.Point(49, 35);
            lb1.Name = "label1";
            lb1.Size = new System.Drawing.Size(146, 28);
            lb1.TabIndex = 2;
            lb1.Text = "Введите пароль";
            // 
            // bt_Cancel
            // 
            bt_Cancel.BackColor = System.Drawing.Color.Transparent;
            bt_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bt_Cancel.Location = new System.Drawing.Point(54, 178);
            bt_Cancel.Name = "bt_Cancel";
            bt_Cancel.Size = new System.Drawing.Size(141, 42);
            bt_Cancel.TabIndex = 3;
            bt_Cancel.Text = "Отмена";
            bt_Cancel.UseVisualStyleBackColor = false;
            bt_Cancel.Click += new System.EventHandler(this.bt_Cancel_Click);
            // 
            // Password
            // 
            Password.AcceptButton = this.b_ok;
            Password.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            Password.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            Password.ClientSize = new System.Drawing.Size(246, 243);
            Password.Controls.Add(this.bt_Cancel);
            Password.Controls.Add(this.lb1);
            Password.Controls.Add(this.b_ok);
            Password.Controls.Add(this.tb_password);
            Password.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Password.Name = "Password";
            Password.Text = "Password";
            Password.ResumeLayout(false);
            Password.PerformLayout();
            Password.ShowDialog();
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            Password.Close();
        }

        private void b_ok_Click(object sender, EventArgs e)
        {
            int a = GetPassword();
            if (a == 1)
            {
                Password.Close();

            }
            tb_password.Text = "";
        }

        private int GetPassword()
        {
            string pass;
            int a = 1;
            pass = System.Convert.ToString(tb_password.Text);
            try
            {
                if (Regex.Matches(this.tb_password.Text, "1111").Count == 1)
                {
                    MessageBox.Show("Успешно", "Успех");

                    создатьРезервнуюКопиюБазыToolStripMenuItem.Visible = true;
                    dgv_Expense.ReadOnly = false;
                    tb_description.Visible = true;
                    tb_Limit.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    tb_Name.Visible = true;
                    bt_del.Visible = true;
                    button1.Visible = true;
                }
                else
                { throw new Exception("Неправильный пароль"); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Не то");
                a = -1;
            }
            return a;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            entering = new firmEntities();
            Expense expense;
            expense = new Expense();

            string name_expense = tb_Name.Text;
            string descr_expense = tb_description.Text;
            string limit = tb_Limit.Text;
            if ((name_expense != "") && (name_expense != "") && (limit != ""))
            {
                expense.Balance = Convert.ToInt32(limit);
                expense.Expense_describe = descr_expense;
                expense.Expense_name = name_expense;
                expense.Limit_sum = Convert.ToInt32(limit);

                entering.Expense_ET.Add(expense);
                entering.SaveChanges();
                RebootExpense();

            }
        }

        private void bt_del_Click(object sender, EventArgs e)
        {
            int id_s = dgv_Expense.CurrentRow.Index;
            int id = System.Convert.ToInt32(dgv_Expense.Rows[id_s].Cells[0].Value);
            var expense = (from Expense in entering.Expense_ET
                           where Expense.ID_expense == id
                           select Expense).First();
            entering.Expense_ET.Remove(expense);
            entering.SaveChanges();
            RebootExpense();
        }
    }
}
