namespace NoRedrawingNoJumping
{
    partial class Play
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
            this.button_refresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_refresh
            // 
            this.button_refresh.Image = global::NoRedrawingNoJumping.Properties.Resources.refresh;
            this.button_refresh.Location = new System.Drawing.Point(115, 224);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(36, 36);
            this.button_refresh.TabIndex = 0;
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // Play
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button_refresh);
            this.Name = "Play";
            this.Text = "NO Redrawing NO Jumping  - Play";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Play_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Play_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_refresh;
    }
}

