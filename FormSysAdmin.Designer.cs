namespace LegoStore
{
    partial class FormSysAdmin
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
            this.buttonРедактировать = new System.Windows.Forms.Button();
            this.buttonСменаДоступа = new System.Windows.Forms.Button();
            this.buttonРегистрация = new System.Windows.Forms.Button();
            this.buttonПодробно = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonПоиск = new System.Windows.Forms.Button();
            this.buttonСтатус = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonНазад = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxСтатус = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonIco = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonРедактировать
            // 
            this.buttonРедактировать.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonРедактировать.Location = new System.Drawing.Point(405, 3);
            this.buttonРедактировать.Name = "buttonРедактировать";
            this.buttonРедактировать.Size = new System.Drawing.Size(195, 40);
            this.buttonРедактировать.TabIndex = 0;
            this.buttonРедактировать.Text = "Редактировать";
            this.buttonРедактировать.UseVisualStyleBackColor = true;
            this.buttonРедактировать.Click += new System.EventHandler(this.buttonРедактировать_Click);
            // 
            // buttonСменаДоступа
            // 
            this.buttonСменаДоступа.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonСменаДоступа.Location = new System.Drawing.Point(606, 3);
            this.buttonСменаДоступа.Name = "buttonСменаДоступа";
            this.buttonСменаДоступа.Size = new System.Drawing.Size(195, 40);
            this.buttonСменаДоступа.TabIndex = 1;
            this.buttonСменаДоступа.Text = "Смена доступа";
            this.buttonСменаДоступа.UseVisualStyleBackColor = true;
            this.buttonСменаДоступа.Click += new System.EventHandler(this.buttonСменаДоступа_Click);
            // 
            // buttonРегистрация
            // 
            this.buttonРегистрация.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonРегистрация.Location = new System.Drawing.Point(204, 3);
            this.buttonРегистрация.Name = "buttonРегистрация";
            this.buttonРегистрация.Size = new System.Drawing.Size(195, 40);
            this.buttonРегистрация.TabIndex = 2;
            this.buttonРегистрация.Text = "Регистрация";
            this.buttonРегистрация.UseVisualStyleBackColor = true;
            // 
            // buttonПодробно
            // 
            this.buttonПодробно.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonПодробно.Location = new System.Drawing.Point(3, 3);
            this.buttonПодробно.Name = "buttonПодробно";
            this.buttonПодробно.Size = new System.Drawing.Size(195, 40);
            this.buttonПодробно.TabIndex = 3;
            this.buttonПодробно.Text = "Подробно";
            this.buttonПодробно.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.buttonСменаДоступа, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonРедактировать, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonПодробно, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonРегистрация, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 405);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(804, 46);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(804, 316);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.01205F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.98795F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(804, 89);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Controls.Add(this.buttonПоиск, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.buttonСтатус, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.comboBoxСтатус, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.textBox1, 3, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 50);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(798, 36);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // buttonПоиск
            // 
            this.buttonПоиск.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonПоиск.Location = new System.Drawing.Point(401, 3);
            this.buttonПоиск.Name = "buttonПоиск";
            this.buttonПоиск.Size = new System.Drawing.Size(193, 30);
            this.buttonПоиск.TabIndex = 0;
            this.buttonПоиск.Text = "Поиск по фамилии";
            this.buttonПоиск.UseVisualStyleBackColor = true;
            // 
            // buttonСтатус
            // 
            this.buttonСтатус.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonСтатус.Location = new System.Drawing.Point(3, 3);
            this.buttonСтатус.Name = "buttonСтатус";
            this.buttonСтатус.Size = new System.Drawing.Size(193, 30);
            this.buttonСтатус.TabIndex = 3;
            this.buttonСтатус.Text = "Статус";
            this.buttonСтатус.UseVisualStyleBackColor = true;
            this.buttonСтатус.Click += new System.EventHandler(this.buttonСтатус_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.289672F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.52141F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.buttonНазад, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonIco, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(798, 41);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // buttonНазад
            // 
            this.buttonНазад.AutoSize = true;
            this.buttonНазад.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonНазад.Location = new System.Drawing.Point(600, 3);
            this.buttonНазад.Name = "buttonНазад";
            this.buttonНазад.Size = new System.Drawing.Size(195, 35);
            this.buttonНазад.TabIndex = 0;
            this.buttonНазад.Text = "Назад";
            this.buttonНазад.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(201, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "Список всех сотрудников";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxСтатус
            // 
            this.comboBoxСтатус.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxСтатус.FormattingEnabled = true;
            this.comboBoxСтатус.Location = new System.Drawing.Point(202, 3);
            this.comboBoxСтатус.Name = "comboBoxСтатус";
            this.comboBoxСтатус.Size = new System.Drawing.Size(193, 21);
            this.comboBoxСтатус.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(600, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonIco
            // 
            this.buttonIco.AutoSize = true;
            this.buttonIco.BackgroundImage = global::LegoStore.Properties.Resources.LEGO_logo_700x700;
            this.buttonIco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonIco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonIco.Location = new System.Drawing.Point(3, 3);
            this.buttonIco.Name = "buttonIco";
            this.buttonIco.Size = new System.Drawing.Size(36, 35);
            this.buttonIco.TabIndex = 3;
            this.buttonIco.UseVisualStyleBackColor = true;
            // 
            // FormSysAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(804, 451);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(820, 490);
            this.Name = "FormSysAdmin";
            this.Text = "FormSysAdmin";
            this.Load += new System.EventHandler(this.FormSysAdmin_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonРедактировать;
        private System.Windows.Forms.Button buttonСменаДоступа;
        private System.Windows.Forms.Button buttonРегистрация;
        private System.Windows.Forms.Button buttonПодробно;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button buttonПоиск;
        private System.Windows.Forms.Button buttonСтатус;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button buttonНазад;
        private System.Windows.Forms.Button buttonIco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxСтатус;
        private System.Windows.Forms.TextBox textBox1;
    }
}