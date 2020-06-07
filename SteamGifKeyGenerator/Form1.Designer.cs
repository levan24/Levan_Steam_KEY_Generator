namespace SteamGifKeyGenerator
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Generate = new System.Windows.Forms.Button();
            this.KeyCounter = new System.Windows.Forms.NumericUpDown();
            this.KeyList = new System.Windows.Forms.TextBox();
            this.Clear = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.SystemTrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.PopUpMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RestoreMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseMenu = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.KeyCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.PopUpMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Generate
            // 
            this.Generate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Generate.ForeColor = System.Drawing.Color.Yellow;
            this.Generate.Location = new System.Drawing.Point(39, 75);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(80, 32);
            this.Generate.TabIndex = 0;
            this.Generate.Text = "Generate";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // KeyCounter
            // 
            this.KeyCounter.BackColor = System.Drawing.SystemColors.InfoText;
            this.KeyCounter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KeyCounter.ForeColor = System.Drawing.Color.Cornsilk;
            this.KeyCounter.Location = new System.Drawing.Point(101, 113);
            this.KeyCounter.Name = "KeyCounter";
            this.KeyCounter.Size = new System.Drawing.Size(81, 20);
            this.KeyCounter.TabIndex = 1;
            // 
            // KeyList
            // 
            this.KeyList.BackColor = System.Drawing.Color.White;
            this.KeyList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.KeyList.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.KeyList.Location = new System.Drawing.Point(22, 154);
            this.KeyList.Multiline = true;
            this.KeyList.Name = "KeyList";
            this.KeyList.ReadOnly = true;
            this.KeyList.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.KeyList.Size = new System.Drawing.Size(240, 304);
            this.KeyList.TabIndex = 2;
            this.KeyList.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Clear
            // 
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear.ForeColor = System.Drawing.Color.Yellow;
            this.Clear.Location = new System.Drawing.Point(157, 75);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(80, 32);
            this.Clear.TabIndex = 3;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SteamGifKeyGenerator.Properties.Resources._5ec3d1e3965c0;
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SteamGifKeyGenerator.Properties.Resources.Steam_GIF_Generator;
            this.pictureBox2.Location = new System.Drawing.Point(39, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(245, 67);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SteamGifKeyGenerator.Properties.Resources.pngwing_com__2_;
            this.pictureBox3.Location = new System.Drawing.Point(3, 114);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(92, 34);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // SystemTrayIcon
            // 
            this.SystemTrayIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.SystemTrayIcon.BalloonTipTitle = "Время";
            this.SystemTrayIcon.ContextMenuStrip = this.PopUpMenu;
            this.SystemTrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("SystemTrayIcon.Icon")));
            this.SystemTrayIcon.Text = "SteamGenerator";
            this.SystemTrayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // PopUpMenu
            // 
            this.PopUpMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RestoreMenu,
            this.CloseMenu});
            this.PopUpMenu.Name = "PopUpMenu";
            this.PopUpMenu.Size = new System.Drawing.Size(136, 48);
            // 
            // RestoreMenu
            // 
            this.RestoreMenu.Name = "RestoreMenu";
            this.RestoreMenu.Size = new System.Drawing.Size(135, 22);
            this.RestoreMenu.Text = "Развернуть";
            this.RestoreMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // CloseMenu
            // 
            this.CloseMenu.Name = "CloseMenu";
            this.CloseMenu.Size = new System.Drawing.Size(135, 22);
            this.CloseMenu.Text = "Закрыть";
            this.CloseMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CloseMenu_MouseDown);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::SteamGifKeyGenerator.Properties.Resources.pngwing_com__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(284, 477);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.KeyList);
            this.Controls.Add(this.KeyCounter);
            this.Controls.Add(this.Generate);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generator By  (_Leo_)";
            this.TopMost = true;
            this.Resize += new System.EventHandler(this.Main_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.KeyCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.PopUpMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.NumericUpDown KeyCounter;
        private System.Windows.Forms.TextBox KeyList;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.NotifyIcon SystemTrayIcon;
        private System.Windows.Forms.ContextMenuStrip PopUpMenu;
        private System.Windows.Forms.ToolStripMenuItem RestoreMenu;
        private System.Windows.Forms.ToolStripMenuItem CloseMenu;
    }
}

