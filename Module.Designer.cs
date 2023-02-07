
namespace _07_02_2023
{
    partial class Module
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtCour = new System.Windows.Forms.TextBox();
            this.txtList = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtComm = new System.Windows.Forms.TextBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.lblPCode = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCour = new System.Windows.Forms.Label();
            this.lblList = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblComm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Детали заказа №";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(75, 81);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(209, 20);
            this.txtDate.TabIndex = 2;
            // 
            // txtCour
            // 
            this.txtCour.Location = new System.Drawing.Point(75, 118);
            this.txtCour.Name = "txtCour";
            this.txtCour.ReadOnly = true;
            this.txtCour.Size = new System.Drawing.Size(209, 20);
            this.txtCour.TabIndex = 3;
            // 
            // txtList
            // 
            this.txtList.Location = new System.Drawing.Point(75, 159);
            this.txtList.Name = "txtList";
            this.txtList.ReadOnly = true;
            this.txtList.Size = new System.Drawing.Size(209, 20);
            this.txtList.TabIndex = 4;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(75, 200);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(209, 20);
            this.txtStatus.TabIndex = 5;
            // 
            // txtComm
            // 
            this.txtComm.Location = new System.Drawing.Point(12, 251);
            this.txtComm.Multiline = true;
            this.txtComm.Name = "txtComm";
            this.txtComm.ReadOnly = true;
            this.txtComm.Size = new System.Drawing.Size(272, 97);
            this.txtComm.TabIndex = 6;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(106, 369);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(88, 28);
            this.btn_Exit.TabIndex = 7;
            this.btn_Exit.Text = "Окей";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // lblPCode
            // 
            this.lblPCode.AutoSize = true;
            this.lblPCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPCode.Location = new System.Drawing.Point(229, 9);
            this.lblPCode.Name = "lblPCode";
            this.lblPCode.Size = new System.Drawing.Size(0, 24);
            this.lblPCode.TabIndex = 8;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(15, 84);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(39, 13);
            this.lblDate.TabIndex = 9;
            this.lblDate.Text = "Дата :";
            // 
            // lblCour
            // 
            this.lblCour.AutoSize = true;
            this.lblCour.Location = new System.Drawing.Point(15, 121);
            this.lblCour.Name = "lblCour";
            this.lblCour.Size = new System.Drawing.Size(49, 13);
            this.lblCour.TabIndex = 10;
            this.lblCour.Text = "Курьер :";
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Location = new System.Drawing.Point(15, 162);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(44, 13);
            this.lblList.TabIndex = 11;
            this.lblList.Text = "Заказ :";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(9, 203);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(47, 13);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "Статус :";
            // 
            // lblComm
            // 
            this.lblComm.AutoSize = true;
            this.lblComm.Location = new System.Drawing.Point(15, 236);
            this.lblComm.Name = "lblComm";
            this.lblComm.Size = new System.Drawing.Size(83, 13);
            this.lblComm.TabIndex = 13;
            this.lblComm.Text = "Комментарий :";
            // 
            // Module
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 418);
            this.Controls.Add(this.lblComm);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.lblCour);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblPCode);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.txtComm);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtList);
            this.Controls.Add(this.txtCour);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label1);
            this.Name = "Module";
            this.Text = "Module";
            this.Load += new System.EventHandler(this.Module_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtCour;
        private System.Windows.Forms.TextBox txtList;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtComm;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label lblPCode;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCour;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblComm;
    }
}