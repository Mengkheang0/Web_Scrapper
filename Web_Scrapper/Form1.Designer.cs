
namespace Web_Scrapper
{
    partial class Form1
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
            this.listBox = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.downloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.itemCount = new System.Windows.Forms.Label();
            this.searchBt = new Guna.UI2.WinForms.Guna2Button();
            this.searchBx = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.imagePreview = new Guna.UI2.WinForms.Guna2PictureBox();
            this.downloadAll = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.header = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePreview)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(33)))));
            this.listBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox.Font = new System.Drawing.Font("SF UI Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.ForeColor = System.Drawing.Color.White;
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 18;
            this.listBox.Location = new System.Drawing.Point(75, 187);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(795, 668);
            this.listBox.TabIndex = 0;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            this.listBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listBox_MouseUp);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.downloadToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            // 
            // downloadToolStripMenuItem
            // 
            this.downloadToolStripMenuItem.Image = global::Web_Scrapper.Properties.Resources.download_32px;
            this.downloadToolStripMenuItem.Name = "downloadToolStripMenuItem";
            this.downloadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.downloadToolStripMenuItem.Text = "Download";
            this.downloadToolStripMenuItem.Click += new System.EventHandler(this.downloadToolStripMenuItem_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip1";
            this.contextMenuStrip2.Size = new System.Drawing.Size(169, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            this.toolStripMenuItem1.Text = "Remove all Files";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // itemCount
            // 
            this.itemCount.AutoSize = true;
            this.itemCount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.itemCount.Location = new System.Drawing.Point(72, 927);
            this.itemCount.Name = "itemCount";
            this.itemCount.Size = new System.Drawing.Size(50, 16);
            this.itemCount.TabIndex = 2;
            this.itemCount.Text = "Item : 0";
            // 
            // searchBt
            // 
            this.searchBt.BorderRadius = 4;
            this.searchBt.BorderThickness = 1;
            this.searchBt.CheckedState.Parent = this.searchBt;
            this.searchBt.CustomImages.Parent = this.searchBt;
            this.searchBt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.searchBt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.searchBt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.searchBt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.searchBt.DisabledState.Parent = this.searchBt;
            this.searchBt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.searchBt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchBt.ForeColor = System.Drawing.Color.White;
            this.searchBt.HoverState.Parent = this.searchBt;
            this.searchBt.Location = new System.Drawing.Point(742, 91);
            this.searchBt.Name = "searchBt";
            this.searchBt.ShadowDecoration.Parent = this.searchBt;
            this.searchBt.Size = new System.Drawing.Size(128, 39);
            this.searchBt.TabIndex = 8;
            this.searchBt.Text = "Search";
            this.searchBt.Click += new System.EventHandler(this.searchBt_Click);
            // 
            // searchBx
            // 
            this.searchBx.BorderRadius = 6;
            this.searchBx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBx.DefaultText = "";
            this.searchBx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchBx.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchBx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchBx.DisabledState.Parent = this.searchBx;
            this.searchBx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchBx.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(33)))));
            this.searchBx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.searchBx.FocusedState.Parent = this.searchBx;
            this.searchBx.Font = new System.Drawing.Font("Ebrima", 10F);
            this.searchBx.ForeColor = System.Drawing.Color.White;
            this.searchBx.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchBx.HoverState.Parent = this.searchBx;
            this.searchBx.Location = new System.Drawing.Point(102, 91);
            this.searchBx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchBx.Name = "searchBx";
            this.searchBx.PasswordChar = '\0';
            this.searchBx.PlaceholderForeColor = System.Drawing.Color.White;
            this.searchBx.PlaceholderText = "Enter URL";
            this.searchBx.SelectedText = "";
            this.searchBx.ShadowDecoration.Parent = this.searchBx;
            this.searchBx.Size = new System.Drawing.Size(587, 36);
            this.searchBx.TabIndex = 9;
            this.searchBx.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 12;
            this.guna2BorderlessForm1.ContainerControl = this;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Coolvetica Rg", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(1171, 103);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(140, 27);
            this.guna2HtmlLabel1.TabIndex = 10;
            this.guna2HtmlLabel1.Text = "Image Previews";
            // 
            // imagePreview
            // 
            this.imagePreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagePreview.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(33)))));
            this.imagePreview.ImageRotate = 0F;
            this.imagePreview.Location = new System.Drawing.Point(886, 187);
            this.imagePreview.Name = "imagePreview";
            this.imagePreview.ShadowDecoration.Parent = this.imagePreview;
            this.imagePreview.Size = new System.Drawing.Size(737, 668);
            this.imagePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagePreview.TabIndex = 11;
            this.imagePreview.TabStop = false;
            this.imagePreview.MouseUp += new System.Windows.Forms.MouseEventHandler(this.imagePreview_MouseUp);
            // 
            // downloadAll
            // 
            this.downloadAll.BorderRadius = 4;
            this.downloadAll.BorderThickness = 1;
            this.downloadAll.CheckedState.Parent = this.downloadAll;
            this.downloadAll.CustomImages.Parent = this.downloadAll;
            this.downloadAll.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.downloadAll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.downloadAll.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.downloadAll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.downloadAll.DisabledState.Parent = this.downloadAll;
            this.downloadAll.FillColor = System.Drawing.Color.Maroon;
            this.downloadAll.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.downloadAll.ForeColor = System.Drawing.Color.White;
            this.downloadAll.HoverState.Parent = this.downloadAll;
            this.downloadAll.Location = new System.Drawing.Point(719, 904);
            this.downloadAll.Name = "downloadAll";
            this.downloadAll.ShadowDecoration.Parent = this.downloadAll;
            this.downloadAll.Size = new System.Drawing.Size(151, 39);
            this.downloadAll.TabIndex = 8;
            this.downloadAll.Text = "DownloadAllImages";
            this.downloadAll.Click += new System.EventHandler(this.downloadAll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(1155, 866);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "# rightclick on image to download \r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(395, 869);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "# select to display image";
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.Transparent;
            this.header.Font = new System.Drawing.Font("Roboto", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.header.Location = new System.Drawing.Point(642, 1);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(311, 39);
            this.header.TabIndex = 10;
            this.header.Text = "IMAGE DOWNLOADER";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1644, 1016);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.imagePreview);
            this.Controls.Add(this.header);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.searchBx);
            this.Controls.Add(this.downloadAll);
            this.Controls.Add(this.searchBt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.itemCount);
            this.Controls.Add(this.listBox);
            this.Font = new System.Drawing.Font("SF UI Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imagePreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem downloadToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private Guna.UI2.WinForms.Guna2Button searchBt;
        private Guna.UI2.WinForms.Guna2TextBox searchBx;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Label itemCount;
        private Guna.UI2.WinForms.Guna2PictureBox imagePreview;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button downloadAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2HtmlLabel header;
    }
}

