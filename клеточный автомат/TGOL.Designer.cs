namespace клеточный_автомат
{
    partial class TGOL
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
            this.picture = new System.Windows.Forms.PictureBox();
            this.start = new System.Windows.Forms.Button();
            this.random = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.settings = new System.Windows.Forms.Button();
            this.trackBarX = new System.Windows.Forms.TrackBar();
            this.trackBarY = new System.Windows.Forms.TrackBar();
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarY)).BeginInit();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picture.BackColor = System.Drawing.Color.Transparent;
            this.picture.Location = new System.Drawing.Point(12, 9);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(545, 494);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            // 
            // start
            // 
            this.start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.start.Location = new System.Drawing.Point(564, 13);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(113, 23);
            this.start.TabIndex = 1;
            this.start.Text = "start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.Start_Click);
            // 
            // random
            // 
            this.random.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.random.Location = new System.Drawing.Point(564, 43);
            this.random.Name = "random";
            this.random.Size = new System.Drawing.Size(113, 23);
            this.random.TabIndex = 2;
            this.random.Text = "random";
            this.random.UseVisualStyleBackColor = true;
            this.random.Click += new System.EventHandler(this.Random_Click);
            // 
            // delete
            // 
            this.delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delete.Location = new System.Drawing.Point(564, 73);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(113, 23);
            this.delete.TabIndex = 3;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // settings
            // 
            this.settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.settings.Location = new System.Drawing.Point(566, 186);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(113, 23);
            this.settings.TabIndex = 6;
            this.settings.Text = "settings";
            this.settings.UseVisualStyleBackColor = true;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // trackBarX
            // 
            this.trackBarX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarX.LargeChange = 1;
            this.trackBarX.Location = new System.Drawing.Point(566, 102);
            this.trackBarX.Maximum = 800;
            this.trackBarX.Minimum = 10;
            this.trackBarX.Name = "trackBarX";
            this.trackBarX.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBarX.Size = new System.Drawing.Size(113, 45);
            this.trackBarX.TabIndex = 7;
            this.trackBarX.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarX.Value = 10;
            this.trackBarX.Scroll += new System.EventHandler(this.TrackBarX_Scroll);
            // 
            // trackBarY
            // 
            this.trackBarY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarY.LargeChange = 1;
            this.trackBarY.Location = new System.Drawing.Point(566, 135);
            this.trackBarY.Maximum = 800;
            this.trackBarY.Minimum = 10;
            this.trackBarY.Name = "trackBarY";
            this.trackBarY.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBarY.Size = new System.Drawing.Size(113, 45);
            this.trackBarY.TabIndex = 8;
            this.trackBarY.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarY.Value = 10;
            this.trackBarY.Scroll += new System.EventHandler(this.TrackBarY_Scroll);
            // 
            // labelX
            // 
            this.labelX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(583, 164);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(19, 13);
            this.labelX.TabIndex = 9;
            this.labelX.Text = "10";
            // 
            // labelY
            // 
            this.labelY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(635, 164);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(19, 13);
            this.labelY.TabIndex = 10;
            this.labelY.Text = "10";
            // 
            // TGOL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(689, 515);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.trackBarY);
            this.Controls.Add(this.trackBarX);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.random);
            this.Controls.Add(this.start);
            this.Controls.Add(this.picture);
            this.MinimumSize = new System.Drawing.Size(358, 260);
            this.Name = "TGOL";
            this.Text = "the game of life";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TGOL_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button random;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button settings;
        private System.Windows.Forms.TrackBar trackBarX;
        private System.Windows.Forms.TrackBar trackBarY;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelY;
    }
}

