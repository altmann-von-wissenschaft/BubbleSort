
namespace BubbleSort
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.table = new System.Windows.Forms.DataGridView();
            this.login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nickname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelSort = new System.Windows.Forms.Label();
            this.buttonAge = new System.Windows.Forms.Button();
            this.buttonNick = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.numeric = new System.Windows.Forms.NumericUpDown();
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelControl = new System.Windows.Forms.Label();
            this.labelGeneration = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.AllowUserToAddRows = false;
            this.table.AllowUserToDeleteRows = false;
            this.table.AllowUserToResizeColumns = false;
            this.table.AllowUserToResizeRows = false;
            this.table.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.login,
            this.nickname,
            this.age});
            this.table.Location = new System.Drawing.Point(12, 12);
            this.table.Name = "table";
            this.table.ReadOnly = true;
            this.table.RowHeadersVisible = false;
            this.table.RowTemplate.Height = 25;
            this.table.Size = new System.Drawing.Size(475, 352);
            this.table.TabIndex = 0;
            // 
            // login
            // 
            this.login.HeaderText = "Логин";
            this.login.Name = "login";
            this.login.ReadOnly = true;
            // 
            // nickname
            // 
            this.nickname.HeaderText = "Никнейм";
            this.nickname.Name = "nickname";
            this.nickname.ReadOnly = true;
            // 
            // age
            // 
            this.age.HeaderText = "Возраст";
            this.age.Name = "age";
            this.age.ReadOnly = true;
            // 
            // controlPanel
            // 
            this.controlPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.controlPanel.Controls.Add(this.labelStatus);
            this.controlPanel.Controls.Add(this.buttonLoad);
            this.controlPanel.Controls.Add(this.buttonSave);
            this.controlPanel.Controls.Add(this.labelSort);
            this.controlPanel.Controls.Add(this.buttonAge);
            this.controlPanel.Controls.Add(this.buttonNick);
            this.controlPanel.Controls.Add(this.buttonLogin);
            this.controlPanel.Controls.Add(this.buttonGenerate);
            this.controlPanel.Controls.Add(this.numeric);
            this.controlPanel.Controls.Add(this.labelAmount);
            this.controlPanel.Controls.Add(this.labelControl);
            this.controlPanel.Controls.Add(this.labelGeneration);
            this.controlPanel.Location = new System.Drawing.Point(493, 12);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(210, 352);
            this.controlPanel.TabIndex = 1;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.labelStatus.Location = new System.Drawing.Point(12, 320);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(0, 17);
            this.labelStatus.TabIndex = 11;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(47, 276);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(110, 23);
            this.buttonLoad.TabIndex = 10;
            this.buttonLoad.Text = "Загрузить";
            this.buttonLoad.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(47, 247);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(110, 23);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // labelSort
            // 
            this.labelSort.AutoSize = true;
            this.labelSort.Location = new System.Drawing.Point(10, 184);
            this.labelSort.Name = "labelSort";
            this.labelSort.Size = new System.Drawing.Size(101, 15);
            this.labelSort.TabIndex = 8;
            this.labelSort.Text = "Сортировать по: ";
            // 
            // buttonAge
            // 
            this.buttonAge.Location = new System.Drawing.Point(117, 209);
            this.buttonAge.Name = "buttonAge";
            this.buttonAge.Size = new System.Drawing.Size(85, 23);
            this.buttonAge.TabIndex = 7;
            this.buttonAge.Text = "Возраст";
            this.buttonAge.UseVisualStyleBackColor = true;
            // 
            // buttonNick
            // 
            this.buttonNick.Location = new System.Drawing.Point(117, 180);
            this.buttonNick.Name = "buttonNick";
            this.buttonNick.Size = new System.Drawing.Size(85, 23);
            this.buttonNick.TabIndex = 6;
            this.buttonNick.Text = "Никнейм";
            this.buttonNick.UseVisualStyleBackColor = true;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(117, 151);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(85, 23);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "Логин";
            this.buttonLogin.UseVisualStyleBackColor = true;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(47, 79);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(110, 23);
            this.buttonGenerate.TabIndex = 4;
            this.buttonGenerate.Text = "Генерировать";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            // 
            // numeric
            // 
            this.numeric.Location = new System.Drawing.Point(117, 40);
            this.numeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numeric.Name = "numeric";
            this.numeric.Size = new System.Drawing.Size(73, 23);
            this.numeric.TabIndex = 3;
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(12, 42);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(99, 15);
            this.labelAmount.TabIndex = 2;
            this.labelAmount.Text = "Кол-во записей: ";
            // 
            // labelControl
            // 
            this.labelControl.AutoSize = true;
            this.labelControl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelControl.Location = new System.Drawing.Point(50, 122);
            this.labelControl.Name = "labelControl";
            this.labelControl.Size = new System.Drawing.Size(107, 17);
            this.labelControl.TabIndex = 1;
            this.labelControl.Text = "Управление БД";
            // 
            // labelGeneration
            // 
            this.labelGeneration.AutoSize = true;
            this.labelGeneration.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelGeneration.Location = new System.Drawing.Point(38, 11);
            this.labelGeneration.Name = "labelGeneration";
            this.labelGeneration.Size = new System.Drawing.Size(128, 17);
            this.labelGeneration.TabIndex = 0;
            this.labelGeneration.Text = "Генерация данных";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 379);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.table);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BubbleSort";
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Label labelGeneration;
        private System.Windows.Forms.Label labelControl;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.NumericUpDown numeric;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.DataGridViewTextBoxColumn login;
        private System.Windows.Forms.DataGridViewTextBoxColumn nickname;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.Button buttonNick;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonAge;
        private System.Windows.Forms.Label labelSort;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelStatus;
    }
}

