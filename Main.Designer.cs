
namespace _07_02_2023
{
    partial class Main
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
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.btnDownUp = new System.Windows.Forms.Button();
            this.btnUpDown = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDate = new System.Windows.Forms.Button();
            this.btnRange = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.dtpFirst = new System.Windows.Forms.DateTimePicker();
            this.dtpSecond = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvMain.Location = new System.Drawing.Point(0, 106);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.RowHeadersVisible = false;
            this.dgvMain.Size = new System.Drawing.Size(751, 388);
            this.dgvMain.TabIndex = 0;
            this.dgvMain.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellContentClick);
            this.dgvMain.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellContentDoubleClick);
            // 
            // btnDownUp
            // 
            this.btnDownUp.Location = new System.Drawing.Point(133, 6);
            this.btnDownUp.Name = "btnDownUp";
            this.btnDownUp.Size = new System.Drawing.Size(112, 37);
            this.btnDownUp.TabIndex = 1;
            this.btnDownUp.Text = "По возрастанию";
            this.btnDownUp.UseVisualStyleBackColor = true;
            this.btnDownUp.Click += new System.EventHandler(this.btnDownUp_Click);
            // 
            // btnUpDown
            // 
            this.btnUpDown.Location = new System.Drawing.Point(260, 6);
            this.btnUpDown.Name = "btnUpDown";
            this.btnUpDown.Size = new System.Drawing.Size(112, 37);
            this.btnUpDown.TabIndex = 2;
            this.btnUpDown.Text = "По убыванию";
            this.btnUpDown.UseVisualStyleBackColor = true;
            this.btnUpDown.Click += new System.EventHandler(this.btnUpDown_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Сортировка :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Фильтрация :";
            // 
            // btnDate
            // 
            this.btnDate.Location = new System.Drawing.Point(388, 54);
            this.btnDate.Name = "btnDate";
            this.btnDate.Size = new System.Drawing.Size(112, 37);
            this.btnDate.TabIndex = 5;
            this.btnDate.Text = "За дату";
            this.btnDate.UseVisualStyleBackColor = true;
            this.btnDate.Click += new System.EventHandler(this.btnDate_Click);
            // 
            // btnRange
            // 
            this.btnRange.Location = new System.Drawing.Point(260, 54);
            this.btnRange.Name = "btnRange";
            this.btnRange.Size = new System.Drawing.Size(112, 37);
            this.btnRange.TabIndex = 4;
            this.btnRange.Text = "Диапозон";
            this.btnRange.UseVisualStyleBackColor = true;
            this.btnRange.Click += new System.EventHandler(this.btnRange_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(627, 54);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(112, 37);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Сброс";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // dtpFirst
            // 
            this.dtpFirst.Checked = false;
            this.dtpFirst.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFirst.Location = new System.Drawing.Point(133, 52);
            this.dtpFirst.Name = "dtpFirst";
            this.dtpFirst.Size = new System.Drawing.Size(112, 20);
            this.dtpFirst.TabIndex = 8;
            this.dtpFirst.Value = new System.DateTime(2023, 2, 7, 0, 0, 0, 0);
            // 
            // dtpSecond
            // 
            this.dtpSecond.Checked = false;
            this.dtpSecond.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSecond.Location = new System.Drawing.Point(133, 78);
            this.dtpSecond.Name = "dtpSecond";
            this.dtpSecond.Size = new System.Drawing.Size(112, 20);
            this.dtpSecond.TabIndex = 9;
            this.dtpSecond.Value = new System.DateTime(2023, 2, 7, 0, 0, 0, 0);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 494);
            this.Controls.Add(this.dtpSecond);
            this.Controls.Add(this.dtpFirst);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDate);
            this.Controls.Add(this.btnRange);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpDown);
            this.Controls.Add(this.btnDownUp);
            this.Controls.Add(this.dgvMain);
            this.Name = "Main";
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Button btnDownUp;
        private System.Windows.Forms.Button btnUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDate;
        private System.Windows.Forms.Button btnRange;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DateTimePicker dtpFirst;
        private System.Windows.Forms.DateTimePicker dtpSecond;
    }
}