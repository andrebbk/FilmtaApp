namespace Filmta_App
{
    partial class FormPopupWindow
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelTexto = new System.Windows.Forms.Label();
            this.buttonSim = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Filmta_App.Properties.Resources.steampunk_victorian;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(151, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 101);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // labelTexto
            // 
            this.labelTexto.AutoEllipsis = true;
            this.labelTexto.BackColor = System.Drawing.Color.Transparent;
            this.labelTexto.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTexto.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTexto.Location = new System.Drawing.Point(30, 120);
            this.labelTexto.Name = "labelTexto";
            this.labelTexto.Size = new System.Drawing.Size(381, 45);
            this.labelTexto.TabIndex = 3;
            this.labelTexto.Text = "Tem a certeza que pretende sair?";
            // 
            // buttonSim
            // 
            this.buttonSim.BackColor = System.Drawing.Color.Transparent;
            this.buttonSim.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSim.FlatAppearance.BorderSize = 2;
            this.buttonSim.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonSim.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonSim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSim.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSim.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSim.Location = new System.Drawing.Point(53, 184);
            this.buttonSim.Name = "buttonSim";
            this.buttonSim.Size = new System.Drawing.Size(140, 45);
            this.buttonSim.TabIndex = 4;
            this.buttonSim.Text = "SIM";
            this.buttonSim.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(228, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 45);
            this.button1.TabIndex = 5;
            this.button1.Text = "NÃO";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FormPopupWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Filmta_App.Properties.Resources.dark_brushed_metal_texturehalf;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(439, 255);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSim);
            this.Controls.Add(this.labelTexto);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPopupWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filmta";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelTexto;
        private System.Windows.Forms.Button buttonSim;
        private System.Windows.Forms.Button button1;
    }
}