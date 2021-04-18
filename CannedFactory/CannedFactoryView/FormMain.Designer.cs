﻿namespace CannedFactoryView
{
	partial class FormMain
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
			this.buttonRef = new System.Windows.Forms.Button();
			this.buttonPayOrder = new System.Windows.Forms.Button();
			this.buttonOrderReady = new System.Windows.Forms.Button();
			this.buttonTakeOrderInWork = new System.Windows.Forms.Button();
			this.buttonCreateOrder = new System.Windows.Forms.Button();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.компонентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.рыбныеКонсервыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.menuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonRef
			// 
			this.buttonRef.Location = new System.Drawing.Point(682, 337);
			this.buttonRef.Margin = new System.Windows.Forms.Padding(2);
			this.buttonRef.Name = "buttonRef";
			this.buttonRef.Size = new System.Drawing.Size(141, 24);
			this.buttonRef.TabIndex = 13;
			this.buttonRef.Text = "Обновить список";
			this.buttonRef.UseVisualStyleBackColor = true;
			this.buttonRef.Click += new System.EventHandler(this.buttonRef_Click);
			// 
			// buttonPayOrder
			// 
			this.buttonPayOrder.Location = new System.Drawing.Point(682, 275);
			this.buttonPayOrder.Margin = new System.Windows.Forms.Padding(2);
			this.buttonPayOrder.Name = "buttonPayOrder";
			this.buttonPayOrder.Size = new System.Drawing.Size(141, 24);
			this.buttonPayOrder.TabIndex = 12;
			this.buttonPayOrder.Text = "Заказ оплачен";
			this.buttonPayOrder.UseVisualStyleBackColor = true;
			this.buttonPayOrder.Click += new System.EventHandler(this.buttonPayOrder_Click);
			// 
			// buttonOrderReady
			// 
			this.buttonOrderReady.Location = new System.Drawing.Point(682, 209);
			this.buttonOrderReady.Margin = new System.Windows.Forms.Padding(2);
			this.buttonOrderReady.Name = "buttonOrderReady";
			this.buttonOrderReady.Size = new System.Drawing.Size(141, 24);
			this.buttonOrderReady.TabIndex = 11;
			this.buttonOrderReady.Text = "Заказ готов";
			this.buttonOrderReady.UseVisualStyleBackColor = true;
			this.buttonOrderReady.Click += new System.EventHandler(this.buttonOrderReady_Click);
			// 
			// buttonTakeOrderInWork
			// 
			this.buttonTakeOrderInWork.Location = new System.Drawing.Point(682, 150);
			this.buttonTakeOrderInWork.Margin = new System.Windows.Forms.Padding(2);
			this.buttonTakeOrderInWork.Name = "buttonTakeOrderInWork";
			this.buttonTakeOrderInWork.Size = new System.Drawing.Size(141, 24);
			this.buttonTakeOrderInWork.TabIndex = 10;
			this.buttonTakeOrderInWork.Text = "Отдать на выполнение";
			this.buttonTakeOrderInWork.UseVisualStyleBackColor = true;
			this.buttonTakeOrderInWork.Click += new System.EventHandler(this.buttonTakeOrderInWork_Click);
			// 
			// buttonCreateOrder
			// 
			this.buttonCreateOrder.Location = new System.Drawing.Point(682, 93);
			this.buttonCreateOrder.Margin = new System.Windows.Forms.Padding(2);
			this.buttonCreateOrder.Name = "buttonCreateOrder";
			this.buttonCreateOrder.Size = new System.Drawing.Size(141, 24);
			this.buttonCreateOrder.TabIndex = 9;
			this.buttonCreateOrder.Text = "Создать заказ";
			this.buttonCreateOrder.UseVisualStyleBackColor = true;
			this.buttonCreateOrder.Click += new System.EventHandler(this.buttonCreateOrder_Click);
			// 
			// dataGridView
			// 
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Location = new System.Drawing.Point(0, 26);
			this.dataGridView.Margin = new System.Windows.Forms.Padding(2);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.ReadOnly = true;
			this.dataGridView.RowHeadersVisible = false;
			this.dataGridView.RowHeadersWidth = 51;
			this.dataGridView.RowTemplate.Height = 24;
			this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView.Size = new System.Drawing.Size(661, 413);
			this.dataGridView.TabIndex = 8;
			// 
			// menuStrip
			// 
			this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникиToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
			this.menuStrip.Size = new System.Drawing.Size(834, 24);
			this.menuStrip.TabIndex = 7;
			this.menuStrip.Text = "menuStrip";
			// 
			// справочникиToolStripMenuItem
			// 
			this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.компонентыToolStripMenuItem,
            this.рыбныеКонсервыToolStripMenuItem});
			this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
			this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
			this.справочникиToolStripMenuItem.Text = "Справочники";
			// 
			// компонентыToolStripMenuItem
			// 
			this.компонентыToolStripMenuItem.Name = "компонентыToolStripMenuItem";
			this.компонентыToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
			this.компонентыToolStripMenuItem.Text = "Компоненты";
			this.компонентыToolStripMenuItem.Click += new System.EventHandler(this.компонентыToolStripMenuItem_Click);
			// 
			// рыбныеКонсервыToolStripMenuItem
			// 
			this.рыбныеКонсервыToolStripMenuItem.Name = "рыбныеКонсервыToolStripMenuItem";
			this.рыбныеКонсервыToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
			this.рыбныеКонсервыToolStripMenuItem.Text = "Рыбные Консервы";
			this.рыбныеКонсервыToolStripMenuItem.Click += new System.EventHandler(this.рыбныеКонсервыToolStripMenuItem_Click);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(834, 450);
			this.Controls.Add(this.buttonRef);
			this.Controls.Add(this.buttonPayOrder);
			this.Controls.Add(this.buttonOrderReady);
			this.Controls.Add(this.buttonTakeOrderInWork);
			this.Controls.Add(this.buttonCreateOrder);
			this.Controls.Add(this.dataGridView);
			this.Controls.Add(this.menuStrip);
			this.Name = "FormMain";
			this.Text = "Консервный завод";
			this.Load += new System.EventHandler(this.FormMain_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonRef;
		private System.Windows.Forms.Button buttonPayOrder;
		private System.Windows.Forms.Button buttonOrderReady;
		private System.Windows.Forms.Button buttonTakeOrderInWork;
		private System.Windows.Forms.Button buttonCreateOrder;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem компонентыToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem рыбныеКонсервыToolStripMenuItem;
	}
}