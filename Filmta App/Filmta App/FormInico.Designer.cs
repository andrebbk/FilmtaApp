namespace Filmta_App
{
    partial class FormInico
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
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSideBar = new System.Windows.Forms.Panel();
            this.panelTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTopBar
            // 
            this.panelTopBar.BackColor = System.Drawing.Color.Black;
            this.panelTopBar.BackgroundImage = global::Filmta_App.Properties.Resources.dark_brushed_metal_texturehalf;
            this.panelTopBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTopBar.Controls.Add(this.buttonMinimize);
            this.panelTopBar.Controls.Add(this.buttonSair);
            this.panelTopBar.Controls.Add(this.pictureBox1);
            this.panelTopBar.Controls.Add(this.label1);
            this.panelTopBar.Location = new System.Drawing.Point(0, 0);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.Size = new System.Drawing.Size(1920, 74);
            this.panelTopBar.TabIndex = 0;
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.BackColor = System.Drawing.Color.Transparent;
            this.buttonMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.buttonMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Font = new System.Drawing.Font("Myanmar Text", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinimize.ForeColor = System.Drawing.Color.DarkGray;
            this.buttonMinimize.Location = new System.Drawing.Point(1787, -1);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(51, 51);
            this.buttonMinimize.TabIndex = 3;
            this.buttonMinimize.Text = "_";
            this.buttonMinimize.UseVisualStyleBackColor = false;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.BackColor = System.Drawing.Color.Transparent;
            this.buttonSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSair.FlatAppearance.BorderSize = 0;
            this.buttonSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.buttonSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSair.Font = new System.Drawing.Font("Myanmar Text", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSair.ForeColor = System.Drawing.Color.DarkGray;
            this.buttonSair.Location = new System.Drawing.Point(1844, 16);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(51, 38);
            this.buttonSair.TabIndex = 2;
            this.buttonSair.Text = "X";
            this.buttonSair.UseVisualStyleBackColor = false;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Filmta_App.Properties.Resources.steampunk_victorian;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(13, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 71);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(116, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "FILMTA";
            // 
            // panelSideBar
            // 
            this.panelSideBar.BackColor = System.Drawing.Color.Black;
            this.panelSideBar.BackgroundImage = global::Filmta_App.Properties.Resources.dark_brushed_metal_texturehalf;
            this.panelSideBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelSideBar.Location = new System.Drawing.Point(0, 74);
            this.panelSideBar.Name = "panelSideBar";
            this.panelSideBar.Size = new System.Drawing.Size(333, 1006);
            this.panelSideBar.TabIndex = 0;
            // 
            // FormInico
            // 
            this.ActiveBorderColor = System.Drawing.Color.White;
            this.ActiveShadowColor = System.Drawing.Color.White;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::Filmta_App.Properties.Resources.dark_pattern;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1918, 1078);
            this.ControlBox = false;
            this.Controls.Add(this.panelSideBar);
            this.Controls.Add(this.panelTopBar);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.InactiveShadowColor = System.Drawing.Color.White;
            this.Name = "FormInico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filmta";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelTopBar.ResumeLayout(false);
            this.panelTopBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopBar;
        private System.Windows.Forms.Panel panelSideBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button buttonMinimize;
    }
}

