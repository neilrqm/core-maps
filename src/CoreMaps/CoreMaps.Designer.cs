namespace CoreMaps
{
    partial class CoreMaps
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
            this.mapControl = new GMap.NET.WindowsForms.GMapControl();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.ccCheckBox = new System.Windows.Forms.CheckBox();
            this.jyCheckBox = new System.Windows.Forms.CheckBox();
            this.scCheckBox = new System.Windows.Forms.CheckBox();
            this.dmCheckBox = new System.Windows.Forms.CheckBox();
            this.actionButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearMarkersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMarkersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadMarkersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mapControl
            // 
            this.mapControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mapControl.Bearing = 0F;
            this.mapControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mapControl.CanDragMap = true;
            this.mapControl.EmptyTileColor = System.Drawing.Color.Navy;
            this.mapControl.GrayScaleMode = false;
            this.mapControl.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.mapControl.LevelsKeepInMemmory = 5;
            this.mapControl.Location = new System.Drawing.Point(12, 27);
            this.mapControl.MarkersEnabled = true;
            this.mapControl.MaxZoom = 18;
            this.mapControl.MinZoom = 11;
            this.mapControl.MouseWheelZoomEnabled = true;
            this.mapControl.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.mapControl.Name = "mapControl";
            this.mapControl.NegativeMode = false;
            this.mapControl.PolygonsEnabled = false;
            this.mapControl.RetryLoadTile = 0;
            this.mapControl.RoutesEnabled = false;
            this.mapControl.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.mapControl.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.mapControl.ShowTileGridLines = false;
            this.mapControl.Size = new System.Drawing.Size(680, 482);
            this.mapControl.TabIndex = 0;
            this.mapControl.Zoom = 12D;
            this.mapControl.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.mapControl_MarkerClicked);
            this.mapControl.Click += new System.EventHandler(this.mapControl_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.searchTextBox.Location = new System.Drawing.Point(63, 517);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(363, 20);
            this.searchTextBox.TabIndex = 1;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // ccCheckBox
            // 
            this.ccCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ccCheckBox.AutoSize = true;
            this.ccCheckBox.Location = new System.Drawing.Point(432, 519);
            this.ccCheckBox.Name = "ccCheckBox";
            this.ccCheckBox.Size = new System.Drawing.Size(40, 17);
            this.ccCheckBox.TabIndex = 2;
            this.ccCheckBox.Text = "CC";
            this.ccCheckBox.UseVisualStyleBackColor = true;
            // 
            // jyCheckBox
            // 
            this.jyCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.jyCheckBox.AutoSize = true;
            this.jyCheckBox.Location = new System.Drawing.Point(478, 519);
            this.jyCheckBox.Name = "jyCheckBox";
            this.jyCheckBox.Size = new System.Drawing.Size(38, 17);
            this.jyCheckBox.TabIndex = 3;
            this.jyCheckBox.Text = "JY";
            this.jyCheckBox.UseVisualStyleBackColor = true;
            // 
            // scCheckBox
            // 
            this.scCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.scCheckBox.AutoSize = true;
            this.scCheckBox.Location = new System.Drawing.Point(522, 519);
            this.scCheckBox.Name = "scCheckBox";
            this.scCheckBox.Size = new System.Drawing.Size(40, 17);
            this.scCheckBox.TabIndex = 4;
            this.scCheckBox.Text = "SC";
            this.scCheckBox.UseVisualStyleBackColor = true;
            // 
            // dmCheckBox
            // 
            this.dmCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dmCheckBox.AutoSize = true;
            this.dmCheckBox.Location = new System.Drawing.Point(568, 519);
            this.dmCheckBox.Name = "dmCheckBox";
            this.dmCheckBox.Size = new System.Drawing.Size(43, 17);
            this.dmCheckBox.TabIndex = 5;
            this.dmCheckBox.Text = "DM";
            this.dmCheckBox.UseVisualStyleBackColor = true;
            // 
            // actionButton
            // 
            this.actionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.actionButton.Location = new System.Drawing.Point(617, 515);
            this.actionButton.Name = "actionButton";
            this.actionButton.Size = new System.Drawing.Size(75, 23);
            this.actionButton.TabIndex = 6;
            this.actionButton.Text = "Search";
            this.actionButton.UseVisualStyleBackColor = true;
            this.actionButton.Click += new System.EventHandler(this.actionButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 520);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Address:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(704, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearMarkersToolStripMenuItem,
            this.saveMarkersToolStripMenuItem,
            this.loadMarkersToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // clearMarkersToolStripMenuItem
            // 
            this.clearMarkersToolStripMenuItem.Name = "clearMarkersToolStripMenuItem";
            this.clearMarkersToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clearMarkersToolStripMenuItem.Text = "Clear Markers";
            this.clearMarkersToolStripMenuItem.Click += new System.EventHandler(this.clearMarkersToolStripMenuItem_Click);
            // 
            // saveMarkersToolStripMenuItem
            // 
            this.saveMarkersToolStripMenuItem.Name = "saveMarkersToolStripMenuItem";
            this.saveMarkersToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveMarkersToolStripMenuItem.Text = "Save Markers";
            this.saveMarkersToolStripMenuItem.Click += new System.EventHandler(this.saveMarkersToolStripMenuItem_Click);
            // 
            // loadMarkersToolStripMenuItem
            // 
            this.loadMarkersToolStripMenuItem.Name = "loadMarkersToolStripMenuItem";
            this.loadMarkersToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadMarkersToolStripMenuItem.Text = "Load Markers";
            this.loadMarkersToolStripMenuItem.Click += new System.EventHandler(this.loadMarkersToolStripMenuItem_Click);
            // 
            // CoreMaps
            // 
            this.AcceptButton = this.actionButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 550);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.actionButton);
            this.Controls.Add(this.dmCheckBox);
            this.Controls.Add(this.scCheckBox);
            this.Controls.Add(this.jyCheckBox);
            this.Controls.Add(this.ccCheckBox);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.mapControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(720, 589);
            this.Name = "CoreMaps";
            this.Text = "Core Activity Map";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CoreMaps_FormClosing);
            this.Load += new System.EventHandler(this.CoreMaps_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl mapControl;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.CheckBox ccCheckBox;
        private System.Windows.Forms.CheckBox jyCheckBox;
        private System.Windows.Forms.CheckBox scCheckBox;
        private System.Windows.Forms.CheckBox dmCheckBox;
        private System.Windows.Forms.Button actionButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearMarkersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMarkersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadMarkersToolStripMenuItem;
    }
}

