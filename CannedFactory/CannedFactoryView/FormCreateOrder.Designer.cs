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
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(271, 140);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 15;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(171, 140);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(93, 23);
            this.buttonSave.TabIndex = 14;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxSum
            // 
            this.textBoxSum.Location = new System.Drawing.Point(113, 98);
            this.textBoxSum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.Size = new System.Drawing.Size(257, 22);
            this.textBoxSum.TabIndex = 13;
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(113, 55);
            this.textBoxCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(257, 22);
            this.textBoxCount.TabIndex = 12;
            this.textBoxCount.TextChanged += new System.EventHandler(this.textBoxCount_TextChanged);
            // 
            // comboBoxCanned
            // 
            this.comboBoxCanned.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCanned.FormattingEnabled = true;
            this.comboBoxCanned.Location = new System.Drawing.Point(113, 11);
            this.comboBoxCanned.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxCanned.Name = "comboBoxCanned";
            this.comboBoxCanned.Size = new System.Drawing.Size(257, 24);
            this.comboBoxCanned.TabIndex = 11;
            this.comboBoxCanned.SelectedIndexChanged += new System.EventHandler(this.comboBoxCanned_SelectedIndexChanged);
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Location = new System.Drawing.Point(15, 98);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(54, 17);
            this.labelSum.TabIndex = 10;
            this.labelSum.Text = "Сумма:";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(15, 55);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(90, 17);
            this.labelCount.TabIndex = 9;
            this.labelCount.Text = "Количество:";
            // 
            // labelCanned
            // 
            this.labelCanned.AutoSize = true;
            this.labelCanned.Location = new System.Drawing.Point(15, 11);
            this.labelCanned.Name = "labelCanned";
            this.labelCanned.Size = new System.Drawing.Size(66, 17);
            this.labelCanned.TabIndex = 8;
            this.labelCanned.Text = "Консервы:";
            // 
            // FormCreateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 191);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxSum);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.comboBoxCanned);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.labelCanned);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
	}
}