namespace NetworkLocationEditor
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.gbRegistry = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SignatureName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GatewayMAC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DnsSuffix = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbControl = new System.Windows.Forms.GroupBox();
            this.tlpControl = new System.Windows.Forms.TableLayoutPanel();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblGatewayMAC = new System.Windows.Forms.Label();
            this.txtGatewayMAC = new System.Windows.Forms.TextBox();
            this.lblDnsSuffix = new System.Windows.Forms.Label();
            this.txtDnsSuffix = new System.Windows.Forms.TextBox();
            this.lblCategoryType = new System.Windows.Forms.Label();
            this.txtCategoryType = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblManaged = new System.Windows.Forms.Label();
            this.txtManaged = new System.Windows.Forms.TextBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.tlpMain.SuspendLayout();
            this.gbRegistry.SuspendLayout();
            this.gbControl.SuspendLayout();
            this.tlpControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.Controls.Add(this.gbRegistry, 0, 0);
            this.tlpMain.Controls.Add(this.gbControl, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.Size = new System.Drawing.Size(1006, 721);
            this.tlpMain.TabIndex = 0;
            // 
            // gbRegistry
            // 
            this.gbRegistry.Controls.Add(this.listView1);
            this.gbRegistry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbRegistry.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.gbRegistry.Location = new System.Drawing.Point(3, 3);
            this.gbRegistry.Name = "gbRegistry";
            this.gbRegistry.Size = new System.Drawing.Size(1000, 609);
            this.gbRegistry.TabIndex = 0;
            this.gbRegistry.TabStop = false;
            this.gbRegistry.Text = "注册表信息";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SignatureName,
            this.Description,
            this.GatewayMAC,
            this.DnsSuffix,
            this.Category});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(3, 21);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(994, 585);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // SignatureName
            // 
            this.SignatureName.Text = "配置编号";
            this.SignatureName.Width = 0;
            // 
            // Description
            // 
            this.Description.Text = "描述";
            this.Description.Width = 180;
            // 
            // GatewayMAC
            // 
            this.GatewayMAC.Text = "网关MAC地址";
            this.GatewayMAC.Width = 200;
            // 
            // DnsSuffix
            // 
            this.DnsSuffix.Text = "域名后缀";
            this.DnsSuffix.Width = 80;
            // 
            // Category
            // 
            this.Category.Text = "网络类别";
            this.Category.Width = 80;
            // 
            // gbControl
            // 
            this.gbControl.Controls.Add(this.tlpControl);
            this.gbControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbControl.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.gbControl.Location = new System.Drawing.Point(3, 618);
            this.gbControl.Name = "gbControl";
            this.gbControl.Size = new System.Drawing.Size(1000, 100);
            this.gbControl.TabIndex = 1;
            this.gbControl.TabStop = false;
            this.gbControl.Text = "注册表信息";
            // 
            // tlpControl
            // 
            this.tlpControl.ColumnCount = 10;
            this.tlpControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this.tlpControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpControl.Controls.Add(this.lblDescription, 0, 0);
            this.tlpControl.Controls.Add(this.txtDescription, 1, 0);
            this.tlpControl.Controls.Add(this.lblGatewayMAC, 0, 1);
            this.tlpControl.Controls.Add(this.txtGatewayMAC, 1, 1);
            this.tlpControl.Controls.Add(this.lblDnsSuffix, 3, 0);
            this.tlpControl.Controls.Add(this.txtDnsSuffix, 4, 0);
            this.tlpControl.Controls.Add(this.lblCategoryType, 6, 1);
            this.tlpControl.Controls.Add(this.txtCategoryType, 7, 1);
            this.tlpControl.Controls.Add(this.btnDelete, 9, 0);
            this.tlpControl.Controls.Add(this.btnSave, 9, 1);
            this.tlpControl.Controls.Add(this.lblCategory, 3, 1);
            this.tlpControl.Controls.Add(this.lblManaged, 6, 0);
            this.tlpControl.Controls.Add(this.txtManaged, 7, 0);
            this.tlpControl.Controls.Add(this.cbCategory, 4, 1);
            this.tlpControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tlpControl.Location = new System.Drawing.Point(3, 21);
            this.tlpControl.Name = "tlpControl";
            this.tlpControl.RowCount = 2;
            this.tlpControl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpControl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpControl.Size = new System.Drawing.Size(994, 76);
            this.tlpControl.TabIndex = 0;
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(57, 8);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(37, 15);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "描述";
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDescription.Location = new System.Drawing.Point(100, 3);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(160, 25);
            this.txtDescription.TabIndex = 0;
            // 
            // lblGatewayMAC
            // 
            this.lblGatewayMAC.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblGatewayMAC.AutoSize = true;
            this.lblGatewayMAC.Location = new System.Drawing.Point(3, 46);
            this.lblGatewayMAC.Name = "lblGatewayMAC";
            this.lblGatewayMAC.Size = new System.Drawing.Size(91, 15);
            this.lblGatewayMAC.TabIndex = 2;
            this.lblGatewayMAC.Text = "网关MAC地址";
            // 
            // txtGatewayMAC
            // 
            this.txtGatewayMAC.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtGatewayMAC.Location = new System.Drawing.Point(100, 41);
            this.txtGatewayMAC.Name = "txtGatewayMAC";
            this.txtGatewayMAC.Size = new System.Drawing.Size(160, 25);
            this.txtGatewayMAC.TabIndex = 1;
            // 
            // lblDnsSuffix
            // 
            this.lblDnsSuffix.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDnsSuffix.AutoSize = true;
            this.lblDnsSuffix.Location = new System.Drawing.Point(284, 8);
            this.lblDnsSuffix.Name = "lblDnsSuffix";
            this.lblDnsSuffix.Size = new System.Drawing.Size(67, 15);
            this.lblDnsSuffix.TabIndex = 4;
            this.lblDnsSuffix.Text = "域名后缀";
            // 
            // txtDnsSuffix
            // 
            this.txtDnsSuffix.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDnsSuffix.Location = new System.Drawing.Point(357, 3);
            this.txtDnsSuffix.Name = "txtDnsSuffix";
            this.txtDnsSuffix.Size = new System.Drawing.Size(160, 25);
            this.txtDnsSuffix.TabIndex = 2;
            // 
            // lblCategoryType
            // 
            this.lblCategoryType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCategoryType.AutoSize = true;
            this.lblCategoryType.Location = new System.Drawing.Point(541, 46);
            this.lblCategoryType.Name = "lblCategoryType";
            this.lblCategoryType.Size = new System.Drawing.Size(103, 15);
            this.lblCategoryType.TabIndex = 10;
            this.lblCategoryType.Text = "CategoryType";
            this.lblCategoryType.Visible = false;
            // 
            // txtCategoryType
            // 
            this.txtCategoryType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCategoryType.Location = new System.Drawing.Point(650, 41);
            this.txtCategoryType.Name = "txtCategoryType";
            this.txtCategoryType.Size = new System.Drawing.Size(160, 25);
            this.txtCategoryType.TabIndex = 5;
            this.txtCategoryType.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.Location = new System.Drawing.Point(910, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 25);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.Location = new System.Drawing.Point(910, 41);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 25);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblCategory
            // 
            this.lblCategory.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(284, 46);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(67, 15);
            this.lblCategory.TabIndex = 8;
            this.lblCategory.Text = "网络类别";
            // 
            // lblManaged
            // 
            this.lblManaged.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblManaged.AutoSize = true;
            this.lblManaged.Location = new System.Drawing.Point(565, 8);
            this.lblManaged.Name = "lblManaged";
            this.lblManaged.Size = new System.Drawing.Size(79, 15);
            this.lblManaged.TabIndex = 6;
            this.lblManaged.Text = "managered";
            this.lblManaged.Visible = false;
            // 
            // txtManaged
            // 
            this.txtManaged.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtManaged.Location = new System.Drawing.Point(650, 3);
            this.txtManaged.Name = "txtManaged";
            this.txtManaged.Size = new System.Drawing.Size(160, 25);
            this.txtManaged.TabIndex = 4;
            this.txtManaged.Visible = false;
            // 
            // cbCategory
            // 
            this.cbCategory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Items.AddRange(new object[] {
            "公用网络",
            "专用网络"});
            this.cbCategory.Location = new System.Drawing.Point(357, 42);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(160, 23);
            this.cbCategory.TabIndex = 11;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.tlpMain);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "网络位置编辑器";
            this.tlpMain.ResumeLayout(false);
            this.gbRegistry.ResumeLayout(false);
            this.gbControl.ResumeLayout(false);
            this.tlpControl.ResumeLayout(false);
            this.tlpControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.GroupBox gbRegistry;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader SignatureName;
        private System.Windows.Forms.ColumnHeader GatewayMAC;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ColumnHeader DnsSuffix;
        private System.Windows.Forms.GroupBox gbControl;
        private System.Windows.Forms.TableLayoutPanel tlpControl;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblGatewayMAC;
        private System.Windows.Forms.TextBox txtGatewayMAC;
        private System.Windows.Forms.Label lblDnsSuffix;
        private System.Windows.Forms.TextBox txtDnsSuffix;
        private System.Windows.Forms.Label lblManaged;
        private System.Windows.Forms.TextBox txtManaged;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblCategoryType;
        private System.Windows.Forms.TextBox txtCategoryType;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ColumnHeader Category;
        private System.Windows.Forms.ComboBox cbCategory;
    }
}

