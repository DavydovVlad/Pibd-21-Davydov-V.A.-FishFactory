namespace CannedFactoryView
{
	partial class FormCanned
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
			this.groupBoxComponents = new System.Windows.Forms.GroupBox();
			this.buttonRef = new System.Windows.Forms.Button();
			this.buttonDel = new System.Windows.Forms.Button();
			this.buttonUpd = new System.Windows.Forms.Button();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnComponent = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.textBoxPrice = new System.Windows.Forms.TextBox();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.labelPrice = new System.Windows.Forms.Label();
			this.labelName = new System.Windows.Forms.Label();
			this.groupBoxComponents.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(293, 318);
			this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(56, 24);
			this.buttonCancel.TabIndex = 13;
			this.buttonCancel.Text = "Отмена";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(203, 318);
			this.buttonSave.Margin = new System.Windows.Forms.Padding(2);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(75, 24);
			this.buttonSave.TabIndex = 12;
			this.buttonSave.Text = "Сохранить";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// groupBoxComponents
			// 
			this.groupBoxComponents.Controls.Add(this.buttonRef);
			this.groupBoxComponents.Controls.Add(this.buttonDel);
			this.groupBoxComponents.Controls.Add(this.buttonUpd);
			this.groupBoxComponents.Controls.Add(this.buttonAdd);
			this.groupBoxComponents.Controls.Add(this.dataGridView);
			this.groupBoxComponents.Location = new System.Drawing.Point(6, 95);
			this.groupBoxComponents.Margin = new System.Windows.Forms.Padding(2);
			this.groupBoxComponents.Name = "groupBoxComponents";
			this.groupBoxComponents.Padding = new System.Windows.Forms.Padding(2);
			this.groupBoxComponents.Size = new System.Drawing.Size(413, 218);
			this.groupBoxComponents.TabIndex = 11;
			this.groupBoxComponents.TabStop = false;
			this.groupBoxComponents.Text = "Компоненты";
			// 
			// buttonRef
			// 
			this.buttonRef.Location = new System.Drawing.Point(325, 145);
			this.buttonRef.Margin = new System.Windows.Forms.Padding(2);
			this.buttonRef.Name = "buttonRef";
			this.buttonRef.Size = new System.Drawing.Size(75, 24);
			this.buttonRef.TabIndex = 4;
			this.buttonRef.Text = "Обновить";
			this.buttonRef.UseVisualStyleBackColor = true;
			this.buttonRef.Click += new System.EventHandler(this.buttonRef_Click);
			// 
			// buttonDel
			// 
			this.buttonDel.Location = new System.Drawing.Point(325, 106);
			this.buttonDel.Margin = new System.Windows.Forms.Padding(2);
			this.buttonDel.Name = "buttonDel";
			this.buttonDel.Size = new System.Drawing.Size(75, 24);
			this.buttonDel.TabIndex = 3;
			this.buttonDel.Text = "Удалить";
			this.buttonDel.UseVisualStyleBackColor = true;
			this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
			// 
			// buttonUpd
			// 
			this.buttonUpd.Location = new System.Drawing.Point(325, 68);
			this.buttonUpd.Margin = new System.Windows.Forms.Padding(2);
			this.buttonUpd.Name = "buttonUpd";
			this.buttonUpd.Size = new System.Drawing.Size(75, 24);
			this.buttonUpd.TabIndex = 2;
			this.buttonUpd.Text = "Изменить";
			this.buttonUpd.UseVisualStyleBackColor = true;
			this.buttonUpd.Click += new System.EventHandler(this.buttonUpd_Click);
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(325, 35);
			this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(75, 20);
			this.buttonAdd.TabIndex = 1;
			this.buttonAdd.Text = "Добавить";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// dataGridView
			// 
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnComponent,
            this.ColumnCount});
			this.dataGridView.Location = new System.Drawing.Point(7, 18);
			this.dataGridView.Margin = new System.Windows.Forms.Padding(2);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.ReadOnly = true;
			this.dataGridView.RowHeadersVisible = false;
			this.dataGridView.RowHeadersWidth = 51;
			this.dataGridView.RowTemplate.Height = 24;
			this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView.Size = new System.Drawing.Size(266, 195);
			this.dataGridView.TabIndex = 0;
			// 
			// ColumnId
			// 
			this.ColumnId.HeaderText = "ID";
			this.ColumnId.MinimumWidth = 6;
			this.ColumnId.Name = "ColumnId";
			this.ColumnId.ReadOnly = true;
			this.ColumnId.Visible = false;
			this.ColumnId.Width = 125;
			// 
			// ColumnComponent
			// 
			this.ColumnComponent.HeaderText = "Компонент";
			this.ColumnComponent.MinimumWidth = 6;
			this.ColumnComponent.Name = "ColumnComponent";
			this.ColumnComponent.ReadOnly = true;
			this.ColumnComponent.Width = 125;
			// 
			// ColumnCount
			// 
			this.ColumnCount.HeaderText = "Количество";
			this.ColumnCount.MinimumWidth = 6;
			this.ColumnCount.Name = "ColumnCount";
			this.ColumnCount.ReadOnly = true;
			this.ColumnCount.Width = 125;
			// 
			// textBoxPrice
			// 
			this.textBoxPrice.Location = new System.Drawing.Point(79, 42);
			this.textBoxPrice.Margin = new System.Windows.Forms.Padding(2);
			this.textBoxPrice.Name = "textBoxPrice";
			this.textBoxPrice.Size = new System.Drawing.Size(76, 20);
			this.textBoxPrice.TabIndex = 10;
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(79, 9);
			this.textBoxName.Margin = new System.Windows.Forms.Padding(2);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(200, 20);
			this.textBoxName.TabIndex = 9;
			// 
			// labelPrice
			// 
			this.labelPrice.AutoSize = true;
			this.labelPrice.Location = new System.Drawing.Point(11, 46);
			this.labelPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelPrice.Name = "labelPrice";
			this.labelPrice.Size = new System.Drawing.Size(36, 13);
			this.labelPrice.TabIndex = 8;
			this.labelPrice.Text = "Цена:";
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(11, 9);
			this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(60, 13);
			this.labelName.TabIndex = 7;
			this.labelName.Text = "Название:";
			// 
			// FormCanned
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(430, 355);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.groupBoxComponents);
			this.Controls.Add(this.textBoxPrice);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.labelPrice);
			this.Controls.Add(this.labelName);
			this.Name = "FormCanned";
			this.Text = "Рыбные консервы";
			this.Load += new System.EventHandler(this.FormCanned_Load);
			this.groupBoxComponents.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.GroupBox groupBoxComponents;
		private System.Windows.Forms.Button buttonRef;
		private System.Windows.Forms.Button buttonDel;
		private System.Windows.Forms.Button buttonUpd;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnComponent;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCount;
		private System.Windows.Forms.TextBox textBoxPrice;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.Label labelPrice;
		private System.Windows.Forms.Label labelName;
	}
}