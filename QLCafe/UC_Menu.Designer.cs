namespace QLCafe
{
	partial class UC_Menu
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lvMenu = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
			this.panelControl2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelControl1
			// 
			this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
			this.panelControl1.Controls.Add(this.panel1);
			this.panelControl1.Controls.Add(this.panelControl2);
			this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelControl1.Location = new System.Drawing.Point(0, 0);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new System.Drawing.Size(1182, 508);
			this.panelControl1.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.lvMenu);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(2, 95);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1178, 411);
			this.panel1.TabIndex = 1;
			// 
			// lvMenu
			// 
			this.lvMenu.AllowDrop = true;
			this.lvMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lvMenu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
			this.lvMenu.Font = new System.Drawing.Font("Tahoma", 15F);
			this.lvMenu.FullRowSelect = true;
			this.lvMenu.GridLines = true;
			this.lvMenu.HideSelection = false;
			this.lvMenu.Location = new System.Drawing.Point(101, 19);
			this.lvMenu.Name = "lvMenu";
			this.lvMenu.Size = new System.Drawing.Size(999, 369);
			this.lvMenu.TabIndex = 2;
			this.lvMenu.UseCompatibleStateImageBehavior = false;
			this.lvMenu.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Id";
			this.columnHeader1.Width = 77;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Tên nước";
			this.columnHeader2.Width = 358;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Id nhóm nước";
			this.columnHeader3.Width = 194;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Giá";
			this.columnHeader4.Width = 241;
			// 
			// panelControl2
			// 
			this.panelControl2.Appearance.BackColor = System.Drawing.Color.Peru;
			this.panelControl2.Appearance.Options.UseBackColor = true;
			this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.panelControl2.Controls.Add(this.labelControl1);
			this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelControl2.Location = new System.Drawing.Point(2, 2);
			this.panelControl2.Name = "panelControl2";
			this.panelControl2.Size = new System.Drawing.Size(1178, 93);
			this.panelControl2.TabIndex = 0;
			// 
			// labelControl1
			// 
			this.labelControl1.Appearance.Font = new System.Drawing.Font("VNI-Algerian", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
			this.labelControl1.Appearance.Options.UseFont = true;
			this.labelControl1.Appearance.Options.UseForeColor = true;
			this.labelControl1.Location = new System.Drawing.Point(517, 12);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(151, 69);
			this.labelControl1.TabIndex = 0;
			this.labelControl1.Text = "Menu";
			// 
			// UC_Menu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panelControl1);
			this.Name = "UC_Menu";
			this.Size = new System.Drawing.Size(1182, 508);
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
			this.panelControl2.ResumeLayout(false);
			this.panelControl2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.PanelControl panelControl1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ListView lvMenu;
		private DevExpress.XtraEditors.PanelControl panelControl2;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
	}
}
