using DarkUI.Controls;

namespace Intersect.Editor.Forms.Editors
{
    partial class FrmCrafts
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCrafts));
            this.btnCancel = new DarkUI.Controls.DarkButton();
            this.btnSave = new DarkUI.Controls.DarkButton();
            this.grpCrafts = new DarkUI.Controls.DarkGroupBox();
            this.btnClearSearch = new DarkUI.Controls.DarkButton();
            this.txtSearch = new DarkUI.Controls.DarkTextBox();
            this.lstCrafts = new System.Windows.Forms.TreeView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.grpGeneral = new DarkUI.Controls.DarkGroupBox();
            this.btnAddFolder = new DarkUI.Controls.DarkButton();
            this.lblFolder = new System.Windows.Forms.Label();
            this.cmbFolder = new DarkUI.Controls.DarkComboBox();
            this.nudCraftQuantity = new DarkUI.Controls.DarkNumericUpDown();
            this.lblCraftQuantity = new System.Windows.Forms.Label();
            this.nudSpeed = new DarkUI.Controls.DarkNumericUpDown();
            this.cmbResult = new DarkUI.Controls.DarkComboBox();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new DarkUI.Controls.DarkTextBox();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.grpIngredients = new DarkUI.Controls.DarkGroupBox();
            this.nudSuccessRate = new DarkUI.Controls.DarkNumericUpDown();
            this.lblSuccessRate = new System.Windows.Forms.Label();
            this.cmbCraftEvent = new DarkUI.Controls.DarkComboBox();
            this.lblCraftEvent = new System.Windows.Forms.Label();
            this.nudQuantity = new DarkUI.Controls.DarkNumericUpDown();
            this.cmbIngredient = new DarkUI.Controls.DarkComboBox();
            this.btnDupIngredient = new DarkUI.Controls.DarkButton();
            this.btnRemove = new DarkUI.Controls.DarkButton();
            this.btnAdd = new DarkUI.Controls.DarkButton();
            this.lblIngredient = new System.Windows.Forms.Label();
            this.lstIngredients = new System.Windows.Forms.ListBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.toolStrip = new DarkUI.Controls.DarkToolStrip();
            this.toolStripItemNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripItemDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnChronological = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripItemCopy = new System.Windows.Forms.ToolStripButton();
            this.toolStripItemPaste = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripItemUndo = new System.Windows.Forms.ToolStripButton();
            this.btnEditRequirements = new DarkUI.Controls.DarkButton();
            this.grpCrafts.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            this.grpGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCraftQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeed)).BeginInit();
            this.grpIngredients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSuccessRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(495, 715);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(8);
            this.btnCancel.Size = new System.Drawing.Size(258, 42);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(178, 715);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(8);
            this.btnSave.Size = new System.Drawing.Size(254, 42);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grpCrafts
            // 
            this.grpCrafts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpCrafts.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpCrafts.Controls.Add(this.btnClearSearch);
            this.grpCrafts.Controls.Add(this.txtSearch);
            this.grpCrafts.Controls.Add(this.lstCrafts);
            this.grpCrafts.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpCrafts.Location = new System.Drawing.Point(18, 55);
            this.grpCrafts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpCrafts.Name = "grpCrafts";
            this.grpCrafts.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpCrafts.Size = new System.Drawing.Size(304, 612);
            this.grpCrafts.TabIndex = 22;
            this.grpCrafts.TabStop = false;
            this.grpCrafts.Text = "Crafts";
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.Location = new System.Drawing.Point(268, 20);
            this.btnClearSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Padding = new System.Windows.Forms.Padding(8);
            this.btnClearSearch.Size = new System.Drawing.Size(27, 31);
            this.btnClearSearch.TabIndex = 28;
            this.btnClearSearch.Text = "X";
            this.btnClearSearch.Click += new System.EventHandler(this.btnClearSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtSearch.Location = new System.Drawing.Point(9, 20);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(250, 26);
            this.txtSearch.TabIndex = 27;
            this.txtSearch.Text = "Search...";
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // lstCrafts
            // 
            this.lstCrafts.AllowDrop = true;
            this.lstCrafts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.lstCrafts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstCrafts.ForeColor = System.Drawing.Color.Gainsboro;
            this.lstCrafts.HideSelection = false;
            this.lstCrafts.ImageIndex = 0;
            this.lstCrafts.ImageList = this.imageList;
            this.lstCrafts.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.lstCrafts.Location = new System.Drawing.Point(9, 60);
            this.lstCrafts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstCrafts.Name = "lstCrafts";
            this.lstCrafts.SelectedImageIndex = 0;
            this.lstCrafts.Size = new System.Drawing.Size(286, 540);
            this.lstCrafts.TabIndex = 26;
            this.lstCrafts.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.lstCrafts_AfterSelect);
            this.lstCrafts.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.lstCrafts_NodeMouseClick);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "folder_Open_16xLG.png");
            this.imageList.Images.SetKeyName(1, "LegacyPackage_16x.png");
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.grpGeneral);
            this.pnlContainer.Controls.Add(this.grpIngredients);
            this.pnlContainer.Location = new System.Drawing.Point(332, 55);
            this.pnlContainer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(696, 650);
            this.pnlContainer.TabIndex = 31;
            this.pnlContainer.Visible = false;
            // 
            // grpGeneral
            // 
            this.grpGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpGeneral.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpGeneral.Controls.Add(this.btnEditRequirements);
            this.grpGeneral.Controls.Add(this.btnAddFolder);
            this.grpGeneral.Controls.Add(this.lblFolder);
            this.grpGeneral.Controls.Add(this.cmbFolder);
            this.grpGeneral.Controls.Add(this.nudCraftQuantity);
            this.grpGeneral.Controls.Add(this.lblCraftQuantity);
            this.grpGeneral.Controls.Add(this.nudSpeed);
            this.grpGeneral.Controls.Add(this.cmbResult);
            this.grpGeneral.Controls.Add(this.lblItem);
            this.grpGeneral.Controls.Add(this.lblName);
            this.grpGeneral.Controls.Add(this.txtName);
            this.grpGeneral.Controls.Add(this.lblSpeed);
            this.grpGeneral.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpGeneral.Location = new System.Drawing.Point(8, 5);
            this.grpGeneral.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpGeneral.Name = "grpGeneral";
            this.grpGeneral.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpGeneral.Size = new System.Drawing.Size(684, 235);
            this.grpGeneral.TabIndex = 31;
            this.grpGeneral.TabStop = false;
            this.grpGeneral.Text = "General";
            // 
            // btnAddFolder
            // 
            this.btnAddFolder.Location = new System.Drawing.Point(368, 63);
            this.btnAddFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddFolder.Name = "btnAddFolder";
            this.btnAddFolder.Padding = new System.Windows.Forms.Padding(8);
            this.btnAddFolder.Size = new System.Drawing.Size(27, 32);
            this.btnAddFolder.TabIndex = 46;
            this.btnAddFolder.Text = "+";
            this.btnAddFolder.Click += new System.EventHandler(this.btnAddFolder_Click);
            // 
            // lblFolder
            // 
            this.lblFolder.AutoSize = true;
            this.lblFolder.Location = new System.Drawing.Point(9, 69);
            this.lblFolder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(58, 20);
            this.lblFolder.TabIndex = 45;
            this.lblFolder.Text = "Folder:";
            // 
            // cmbFolder
            // 
            this.cmbFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbFolder.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbFolder.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbFolder.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbFolder.ButtonIcon = ((System.Drawing.Bitmap)(resources.GetObject("cmbFolder.ButtonIcon")));
            this.cmbFolder.DrawDropdownHoverOutline = false;
            this.cmbFolder.DrawFocusRectangle = false;
            this.cmbFolder.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFolder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFolder.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbFolder.FormattingEnabled = true;
            this.cmbFolder.Location = new System.Drawing.Point(110, 63);
            this.cmbFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbFolder.Name = "cmbFolder";
            this.cmbFolder.Size = new System.Drawing.Size(247, 27);
            this.cmbFolder.TabIndex = 44;
            this.cmbFolder.Text = null;
            this.cmbFolder.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbFolder.SelectedIndexChanged += new System.EventHandler(this.cmbFolder_SelectedIndexChanged);
            // 
            // nudCraftQuantity
            // 
            this.nudCraftQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudCraftQuantity.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudCraftQuantity.Location = new System.Drawing.Point(110, 146);
            this.nudCraftQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudCraftQuantity.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudCraftQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCraftQuantity.Name = "nudCraftQuantity";
            this.nudCraftQuantity.Size = new System.Drawing.Size(285, 26);
            this.nudCraftQuantity.TabIndex = 43;
            this.nudCraftQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCraftQuantity.ValueChanged += new System.EventHandler(this.nudCraftQuantity_ValueChanged);
            // 
            // lblCraftQuantity
            // 
            this.lblCraftQuantity.AutoSize = true;
            this.lblCraftQuantity.Location = new System.Drawing.Point(9, 149);
            this.lblCraftQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCraftQuantity.Name = "lblCraftQuantity";
            this.lblCraftQuantity.Size = new System.Drawing.Size(72, 20);
            this.lblCraftQuantity.TabIndex = 42;
            this.lblCraftQuantity.Text = "Quantity:";
            // 
            // nudSpeed
            // 
            this.nudSpeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudSpeed.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudSpeed.Location = new System.Drawing.Point(110, 186);
            this.nudSpeed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudSpeed.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSpeed.Name = "nudSpeed";
            this.nudSpeed.Size = new System.Drawing.Size(285, 26);
            this.nudSpeed.TabIndex = 35;
            this.nudSpeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSpeed.ValueChanged += new System.EventHandler(this.nudSpeed_ValueChanged);
            // 
            // cmbResult
            // 
            this.cmbResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbResult.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbResult.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbResult.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbResult.ButtonIcon = ((System.Drawing.Bitmap)(resources.GetObject("cmbResult.ButtonIcon")));
            this.cmbResult.DrawDropdownHoverOutline = false;
            this.cmbResult.DrawFocusRectangle = false;
            this.cmbResult.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbResult.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbResult.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbResult.FormattingEnabled = true;
            this.cmbResult.Location = new System.Drawing.Point(110, 105);
            this.cmbResult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbResult.Name = "cmbResult";
            this.cmbResult.Size = new System.Drawing.Size(283, 27);
            this.cmbResult.TabIndex = 34;
            this.cmbResult.Text = null;
            this.cmbResult.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbResult.SelectedIndexChanged += new System.EventHandler(this.cmbResult_SelectedIndexChanged);
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(9, 109);
            this.lblItem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(45, 20);
            this.lblItem.TabIndex = 33;
            this.lblItem.Text = "Item:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(9, 26);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 20);
            this.lblName.TabIndex = 19;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtName.Location = new System.Drawing.Point(110, 23);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(284, 26);
            this.txtName.TabIndex = 18;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(9, 189);
            this.lblSpeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(82, 20);
            this.lblSpeed.TabIndex = 3;
            this.lblSpeed.Text = "Time (ms):";
            // 
            // grpIngredients
            // 
            this.grpIngredients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpIngredients.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpIngredients.Controls.Add(this.nudSuccessRate);
            this.grpIngredients.Controls.Add(this.lblSuccessRate);
            this.grpIngredients.Controls.Add(this.cmbCraftEvent);
            this.grpIngredients.Controls.Add(this.lblCraftEvent);
            this.grpIngredients.Controls.Add(this.nudQuantity);
            this.grpIngredients.Controls.Add(this.cmbIngredient);
            this.grpIngredients.Controls.Add(this.btnDupIngredient);
            this.grpIngredients.Controls.Add(this.btnRemove);
            this.grpIngredients.Controls.Add(this.btnAdd);
            this.grpIngredients.Controls.Add(this.lblIngredient);
            this.grpIngredients.Controls.Add(this.lstIngredients);
            this.grpIngredients.Controls.Add(this.lblQuantity);
            this.grpIngredients.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpIngredients.Location = new System.Drawing.Point(8, 249);
            this.grpIngredients.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpIngredients.Name = "grpIngredients";
            this.grpIngredients.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpIngredients.Size = new System.Drawing.Size(684, 396);
            this.grpIngredients.TabIndex = 30;
            this.grpIngredients.TabStop = false;
            this.grpIngredients.Text = "Ingredients";
            // 
            // nudSuccessRate
            // 
            this.nudSuccessRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudSuccessRate.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudSuccessRate.Location = new System.Drawing.Point(18, 358);
            this.nudSuccessRate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudSuccessRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSuccessRate.Name = "nudSuccessRate";
            this.nudSuccessRate.Size = new System.Drawing.Size(159, 26);
            this.nudSuccessRate.TabIndex = 45;
            this.nudSuccessRate.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudSuccessRate.ValueChanged += new System.EventHandler(this.nudSuccessRate_ValueChanged);
            // 
            // lblSuccessRate
            // 
            this.lblSuccessRate.AutoSize = true;
            this.lblSuccessRate.Location = new System.Drawing.Point(14, 337);
            this.lblSuccessRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSuccessRate.Name = "lblSuccessRate";
            this.lblSuccessRate.Size = new System.Drawing.Size(113, 20);
            this.lblSuccessRate.TabIndex = 44;
            this.lblSuccessRate.Text = "Success Rate:";
            // 
            // cmbCraftEvent
            // 
            this.cmbCraftEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbCraftEvent.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbCraftEvent.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbCraftEvent.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbCraftEvent.ButtonIcon = ((System.Drawing.Bitmap)(resources.GetObject("cmbCraftEvent.ButtonIcon")));
            this.cmbCraftEvent.DrawDropdownHoverOutline = false;
            this.cmbCraftEvent.DrawFocusRectangle = false;
            this.cmbCraftEvent.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCraftEvent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCraftEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCraftEvent.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbCraftEvent.FormattingEnabled = true;
            this.cmbCraftEvent.Location = new System.Drawing.Point(185, 358);
            this.cmbCraftEvent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbCraftEvent.Name = "cmbCraftEvent";
            this.cmbCraftEvent.Size = new System.Drawing.Size(206, 27);
            this.cmbCraftEvent.TabIndex = 43;
            this.cmbCraftEvent.Text = null;
            this.cmbCraftEvent.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbCraftEvent.SelectedIndexChanged += new System.EventHandler(this.cmbCraftEvent_SelectedIndexChanged);
            // 
            // lblCraftEvent
            // 
            this.lblCraftEvent.AutoSize = true;
            this.lblCraftEvent.Location = new System.Drawing.Point(181, 337);
            this.lblCraftEvent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCraftEvent.Name = "lblCraftEvent";
            this.lblCraftEvent.Size = new System.Drawing.Size(54, 20);
            this.lblCraftEvent.TabIndex = 42;
            this.lblCraftEvent.Text = "Event:";
            // 
            // nudQuantity
            // 
            this.nudQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudQuantity.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudQuantity.Location = new System.Drawing.Point(18, 262);
            this.nudQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudQuantity.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(376, 26);
            this.nudQuantity.TabIndex = 41;
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantity.ValueChanged += new System.EventHandler(this.nudQuantity_ValueChanged);
            // 
            // cmbIngredient
            // 
            this.cmbIngredient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbIngredient.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbIngredient.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbIngredient.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbIngredient.ButtonIcon = ((System.Drawing.Bitmap)(resources.GetObject("cmbIngredient.ButtonIcon")));
            this.cmbIngredient.DrawDropdownHoverOutline = false;
            this.cmbIngredient.DrawFocusRectangle = false;
            this.cmbIngredient.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbIngredient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIngredient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbIngredient.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbIngredient.FormattingEnabled = true;
            this.cmbIngredient.Location = new System.Drawing.Point(18, 198);
            this.cmbIngredient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbIngredient.Name = "cmbIngredient";
            this.cmbIngredient.Size = new System.Drawing.Size(373, 27);
            this.cmbIngredient.TabIndex = 40;
            this.cmbIngredient.Text = null;
            this.cmbIngredient.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbIngredient.SelectedIndexChanged += new System.EventHandler(this.cmbIngredient_SelectedIndexChanged);
            // 
            // btnDupIngredient
            // 
            this.btnDupIngredient.Location = new System.Drawing.Point(282, 299);
            this.btnDupIngredient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDupIngredient.Name = "btnDupIngredient";
            this.btnDupIngredient.Padding = new System.Windows.Forms.Padding(8);
            this.btnDupIngredient.Size = new System.Drawing.Size(112, 35);
            this.btnDupIngredient.TabIndex = 39;
            this.btnDupIngredient.Text = "Duplicate";
            this.btnDupIngredient.Click += new System.EventHandler(this.btnDupIngredient_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(146, 299);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Padding = new System.Windows.Forms.Padding(8);
            this.btnRemove.Size = new System.Drawing.Size(118, 35);
            this.btnRemove.TabIndex = 38;
            this.btnRemove.Text = "Remove";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(18, 299);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(8);
            this.btnAdd.Size = new System.Drawing.Size(112, 35);
            this.btnAdd.TabIndex = 37;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblIngredient
            // 
            this.lblIngredient.AutoSize = true;
            this.lblIngredient.Location = new System.Drawing.Point(14, 173);
            this.lblIngredient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIngredient.Name = "lblIngredient";
            this.lblIngredient.Size = new System.Drawing.Size(45, 20);
            this.lblIngredient.TabIndex = 31;
            this.lblIngredient.Text = "Item:";
            // 
            // lstIngredients
            // 
            this.lstIngredients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.lstIngredients.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstIngredients.ForeColor = System.Drawing.Color.Gainsboro;
            this.lstIngredients.FormattingEnabled = true;
            this.lstIngredients.ItemHeight = 20;
            this.lstIngredients.Items.AddRange(new object[] {
            "Ingredient: None x1"});
            this.lstIngredients.Location = new System.Drawing.Point(18, 29);
            this.lstIngredients.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstIngredients.Name = "lstIngredients";
            this.lstIngredients.Size = new System.Drawing.Size(382, 142);
            this.lstIngredients.TabIndex = 29;
            this.lstIngredients.SelectedIndexChanged += new System.EventHandler(this.lstIngredients_SelectedIndexChanged);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(14, 237);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(72, 20);
            this.lblQuantity.TabIndex = 28;
            this.lblQuantity.Text = "Quantity:";
            // 
            // toolStrip
            // 
            this.toolStrip.AutoSize = false;
            this.toolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.toolStrip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripItemNew,
            this.toolStripSeparator1,
            this.toolStripItemDelete,
            this.toolStripSeparator2,
            this.btnChronological,
            this.toolStripSeparator4,
            this.toolStripItemCopy,
            this.toolStripItemPaste,
            this.toolStripSeparator3,
            this.toolStripItemUndo});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(8, 0, 2, 0);
            this.toolStrip.Size = new System.Drawing.Size(1041, 38);
            this.toolStrip.TabIndex = 43;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripItemNew
            // 
            this.toolStripItemNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripItemNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripItemNew.Image = ((System.Drawing.Image)(resources.GetObject("toolStripItemNew.Image")));
            this.toolStripItemNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripItemNew.Name = "toolStripItemNew";
            this.toolStripItemNew.Size = new System.Drawing.Size(28, 35);
            this.toolStripItemNew.Text = "New";
            this.toolStripItemNew.Click += new System.EventHandler(this.toolStripItemNew_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // toolStripItemDelete
            // 
            this.toolStripItemDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripItemDelete.Enabled = false;
            this.toolStripItemDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripItemDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripItemDelete.Image")));
            this.toolStripItemDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripItemDelete.Name = "toolStripItemDelete";
            this.toolStripItemDelete.Size = new System.Drawing.Size(28, 35);
            this.toolStripItemDelete.Text = "Delete";
            this.toolStripItemDelete.Click += new System.EventHandler(this.toolStripItemDelete_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // btnChronological
            // 
            this.btnChronological.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnChronological.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.btnChronological.Image = ((System.Drawing.Image)(resources.GetObject("btnChronological.Image")));
            this.btnChronological.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnChronological.Name = "btnChronological";
            this.btnChronological.Size = new System.Drawing.Size(28, 35);
            this.btnChronological.Text = "Order Chronologically";
            this.btnChronological.Click += new System.EventHandler(this.btnChronological_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripSeparator4.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 38);
            // 
            // toolStripItemCopy
            // 
            this.toolStripItemCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripItemCopy.Enabled = false;
            this.toolStripItemCopy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripItemCopy.Image = ((System.Drawing.Image)(resources.GetObject("toolStripItemCopy.Image")));
            this.toolStripItemCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripItemCopy.Name = "toolStripItemCopy";
            this.toolStripItemCopy.Size = new System.Drawing.Size(28, 35);
            this.toolStripItemCopy.Text = "Copy";
            this.toolStripItemCopy.Click += new System.EventHandler(this.toolStripItemCopy_Click);
            // 
            // toolStripItemPaste
            // 
            this.toolStripItemPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripItemPaste.Enabled = false;
            this.toolStripItemPaste.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripItemPaste.Image = ((System.Drawing.Image)(resources.GetObject("toolStripItemPaste.Image")));
            this.toolStripItemPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripItemPaste.Name = "toolStripItemPaste";
            this.toolStripItemPaste.Size = new System.Drawing.Size(28, 35);
            this.toolStripItemPaste.Text = "Paste";
            this.toolStripItemPaste.Click += new System.EventHandler(this.toolStripItemPaste_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 38);
            // 
            // toolStripItemUndo
            // 
            this.toolStripItemUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripItemUndo.Enabled = false;
            this.toolStripItemUndo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripItemUndo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripItemUndo.Image")));
            this.toolStripItemUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripItemUndo.Name = "toolStripItemUndo";
            this.toolStripItemUndo.Size = new System.Drawing.Size(28, 35);
            this.toolStripItemUndo.Text = "Undo";
            this.toolStripItemUndo.Click += new System.EventHandler(this.toolStripItemUndo_Click);
            // 
            // btnEditRequirements
            // 
            this.btnEditRequirements.Location = new System.Drawing.Point(420, 23);
            this.btnEditRequirements.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditRequirements.Name = "btnEditRequirements";
            this.btnEditRequirements.Padding = new System.Windows.Forms.Padding(8);
            this.btnEditRequirements.Size = new System.Drawing.Size(256, 35);
            this.btnEditRequirements.TabIndex = 44;
            this.btnEditRequirements.Text = "Edit Crafting Requirements";
            this.btnEditRequirements.Click += new System.EventHandler(this.btnEditRequirements_Click);
            // 
            // FrmCrafts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1041, 775);
            this.ControlBox = false;
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpCrafts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCrafts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crafts Editor";
            this.Load += new System.EventHandler(this.frmCrafting_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.form_KeyDown);
            this.grpCrafts.ResumeLayout(false);
            this.grpCrafts.PerformLayout();
            this.pnlContainer.ResumeLayout(false);
            this.grpGeneral.ResumeLayout(false);
            this.grpGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCraftQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeed)).EndInit();
            this.grpIngredients.ResumeLayout(false);
            this.grpIngredients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSuccessRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DarkButton btnCancel;
        private DarkButton btnSave;
        private DarkGroupBox grpCrafts;
        private System.Windows.Forms.Panel pnlContainer;
        private DarkGroupBox grpGeneral;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label lblName;
        private DarkTextBox txtName;
        private System.Windows.Forms.Label lblSpeed;
        private DarkGroupBox grpIngredients;
        private DarkButton btnRemove;
        private DarkButton btnAdd;
        private System.Windows.Forms.Label lblIngredient;
        private System.Windows.Forms.ListBox lstIngredients;
        private System.Windows.Forms.Label lblQuantity;
        private DarkToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripItemNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripItemDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.ToolStripButton toolStripItemCopy;
        public System.Windows.Forms.ToolStripButton toolStripItemPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        public System.Windows.Forms.ToolStripButton toolStripItemUndo;
        private DarkButton btnDupIngredient;
        private DarkComboBox cmbResult;
        private DarkComboBox cmbIngredient;
        private DarkNumericUpDown nudSpeed;
        private DarkNumericUpDown nudQuantity;
        private DarkNumericUpDown nudCraftQuantity;
        private System.Windows.Forms.Label lblCraftQuantity;
        private DarkButton btnClearSearch;
        private DarkTextBox txtSearch;
        public System.Windows.Forms.TreeView lstCrafts;
        private System.Windows.Forms.ToolStripButton btnChronological;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private DarkButton btnAddFolder;
        private System.Windows.Forms.Label lblFolder;
        private DarkComboBox cmbFolder;
        private System.Windows.Forms.ImageList imageList;
        private DarkComboBox cmbCraftEvent;
        private System.Windows.Forms.Label lblCraftEvent;
        private DarkNumericUpDown nudSuccessRate;
        private System.Windows.Forms.Label lblSuccessRate;
        private DarkButton btnEditRequirements;
    }
}