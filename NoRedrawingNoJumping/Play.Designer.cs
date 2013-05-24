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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Play));
            this.btnBack = new System.Windows.Forms.Button();
            this.button_refresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Image = global::NoRedrawingNoJumping.Properties.Resources.back_arrow;
            this.btnBack.Location = new System.Drawing.Point(148, 275);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(39, 36);
            this.btnBack.TabIndex = 1;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // button_refresh
            // 
            this.button_refresh.Image = global::NoRedrawingNoJumping.Properties.Resources.refresh;
            this.button_refresh.Location = new System.Drawing.Point(89, 275);
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
            this.ClientSize = new System.Drawing.Size(284, 311);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.button_refresh);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Play";
            this.Text = "NO Redrawing NO Jumping  - Play";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Play_FormClosed);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Play_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Play_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.Button btnBack;
    }
}

