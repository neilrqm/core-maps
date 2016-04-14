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
            this.mapControl.Location = new System.Drawing.Point(12, 12);
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
            this.mapControl.Size = new System.Drawing.Size(680, 459);
            this.mapControl.TabIndex = 0;
            this.mapControl.Zoom = 12D;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.searchTextBox.Location = new System.Drawing.Point(12, 479);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(414, 20);
            this.searchTextBox.TabIndex = 1;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // ccCheckBox
            // 
            this.ccCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ccCheckBox.AutoSize = true;
            this.ccCheckBox.Location = new System.Drawing.Point(432, 481);
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
            this.jyCheckBox.Location = new System.Drawing.Point(478, 481);
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
            this.scCheckBox.Location = new System.Drawing.Point(522, 481);
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
            this.dmCheckBox.Location = new System.Drawing.Point(568, 481);
            this.dmCheckBox.Name = "dmCheckBox";
            this.dmCheckBox.Size = new System.Drawing.Size(43, 17);
            this.dmCheckBox.TabIndex = 5;
            this.dmCheckBox.Text = "DM";
            this.dmCheckBox.UseVisualStyleBackColor = true;
            // 
            // actionButton
            // 
            this.actionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.actionButton.Location = new System.Drawing.Point(617, 477);
            this.actionButton.Name = "actionButton";
            this.actionButton.Size = new System.Drawing.Size(75, 23);
            this.actionButton.TabIndex = 6;
            this.actionButton.Text = "Search";
            this.actionButton.UseVisualStyleBackColor = true;
            this.actionButton.Click += new System.EventHandler(this.actionButton_Click);
            // 
            // CoreMaps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 512);
            this.Controls.Add(this.actionButton);
            this.Controls.Add(this.dmCheckBox);
            this.Controls.Add(this.scCheckBox);
            this.Controls.Add(this.jyCheckBox);
            this.Controls.Add(this.ccCheckBox);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.mapControl);
            this.MinimumSize = new System.Drawing.Size(720, 551);
            this.Name = "CoreMaps";
            this.Text = "Core Activity Map";
            this.Load += new System.EventHandler(this.CoreMaps_Load);
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
    }
}

