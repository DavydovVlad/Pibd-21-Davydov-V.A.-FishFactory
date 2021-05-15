namespace CannedFactoryView
{
	partial class FormCreateOrder
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.comboBoxCanned = new System.Windows.Forms.ComboBox();
            this.labelSum = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelCanned = new System.Windows.Forms.Label();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.labelClient = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(223, 155);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(56, 19);
            this.buttonCancel.TabIndex = 15;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(148, 155);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(70, 19);
            this.buttonSave.TabIndex = 14;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxSum
            // 
            this.textBoxSum.Location = new System.Drawing.Point(85, 80);
            this.textBoxSum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.Size = new System.Drawing.Size(194, 20);
            this.textBoxSum.TabIndex = 13;
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(85, 45);
            this.textBoxCount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(194, 20);
            this.textBoxCount.TabIndex = 12;
            this.textBoxCount.TextChanged += new System.EventHandler(this.textBoxCount_TextChanged);
            // 
            // comboBoxCanned
            // 
            this.comboBoxCanned.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCanned.FormattingEnabled = true;
            this.comboBoxCanned.Location = new System.Drawing.Point(85, 9);
            this.comboBoxCanned.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxCanned.Name = "comboBoxCanned";
            this.comboBoxCanned.Size = new System.Drawing.Size(194, 21);
            this.comboBoxCanned.TabIndex = 11;
            this.comboBoxCanned.SelectedIndexChanged += new System.EventHandler(this.comboBoxCanned_SelectedIndexChanged);
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Location = new System.Drawing.Point(11, 80);
            this.labelSum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(44, 13);
            this.labelSum.TabIndex = 10;
            this.labelSum.Text = "Сумма:";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(11, 45);
            this.labelCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(69, 13);
            this.labelCount.TabIndex = 9;
            this.labelCount.Text = "Количество:";
            // 
            // labelCanned
            // 
            this.labelCanned.AutoSize = true;
            this.labelCanned.Location = new System.Drawing.Point(11, 9);
            this.labelCanned.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCanned.Name = "labelCanned";
            this.labelCanned.Size = new System.Drawing.Size(52, 13);
            this.labelCanned.TabIndex = 8;
            this.labelCanned.Text = "Консервы:";
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(85, 118);
            this.comboBoxClient.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(194, 21);
            this.comboBoxClient.TabIndex = 17;
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Location = new System.Drawing.Point(11, 118);
            this.labelClient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(49, 13);
            this.labelClient.TabIndex = 16;
            this.labelClient.Text = " Клиент:";
            // 
            // FormCreateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 183);
            this.Controls.Add(this.comboBoxClient);
            this.Controls.Add(this.labelClient);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxSum);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.comboBoxCanned);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.labelCanned);
            this.Name = "FormCreateOrder";
            this.Text = "Заказ";
            this.Load += new System.EventHandler(this.FormCreateOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.TextBox textBoxSum;
		private System.Windows.Forms.TextBox textBoxCount;
		private System.Windows.Forms.ComboBox comboBoxCanned;
		private System.Windows.Forms.Label labelSum;
		private System.Windows.Forms.Label labelCount;
		private System.Windows.Forms.Label labelCanned;
        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.Label labelClient;
    }
}