namespace WindowsAnimate
{
    partial class frmAnimate
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
            this.lblSpeed = new System.Windows.Forms.Label();
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.lblInit = new System.Windows.Forms.Label();
            this.txtInit = new System.Windows.Forms.TextBox();
            this.btnAnimate = new System.Windows.Forms.Button();
            this.rchTxtbox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(31, 56);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(56, 20);
            this.lblSpeed.TabIndex = 0;
            this.lblSpeed.Text = "Speed";
            // 
            // txtSpeed
            // 
            this.txtSpeed.Location = new System.Drawing.Point(112, 49);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(127, 26);
            this.txtSpeed.TabIndex = 1;
            // 
            // lblInit
            // 
            this.lblInit.AutoSize = true;
            this.lblInit.Location = new System.Drawing.Point(307, 55);
            this.lblInit.Name = "lblInit";
            this.lblInit.Size = new System.Drawing.Size(31, 20);
            this.lblInit.TabIndex = 2;
            this.lblInit.Text = "Init";
            // 
            // txtInit
            // 
            this.txtInit.Location = new System.Drawing.Point(373, 49);
            this.txtInit.Name = "txtInit";
            this.txtInit.Size = new System.Drawing.Size(207, 26);
            this.txtInit.TabIndex = 3;
            // 
            // btnAnimate
            // 
            this.btnAnimate.Location = new System.Drawing.Point(35, 112);
            this.btnAnimate.Name = "btnAnimate";
            this.btnAnimate.Size = new System.Drawing.Size(106, 38);
            this.btnAnimate.TabIndex = 4;
            this.btnAnimate.Text = "Animate";
            this.btnAnimate.UseVisualStyleBackColor = true;
            this.btnAnimate.Click += new System.EventHandler(this.btnAnimate_Click);
            // 
            // rchTxtbox
            // 
            this.rchTxtbox.Location = new System.Drawing.Point(35, 174);
            this.rchTxtbox.Name = "rchTxtbox";
            this.rchTxtbox.Size = new System.Drawing.Size(558, 243);
            this.rchTxtbox.TabIndex = 5;
            this.rchTxtbox.Text = "";
            // 
            // frmAnimate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 429);
            this.Controls.Add(this.rchTxtbox);
            this.Controls.Add(this.btnAnimate);
            this.Controls.Add(this.txtInit);
            this.Controls.Add(this.lblInit);
            this.Controls.Add(this.txtSpeed);
            this.Controls.Add(this.lblSpeed);
            this.Name = "frmAnimate";
            this.Text = "Animation";
            this.Load += new System.EventHandler(this.frmAnimate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.TextBox txtSpeed;
        private System.Windows.Forms.Label lblInit;
        private System.Windows.Forms.TextBox txtInit;
        private System.Windows.Forms.Button btnAnimate;
        private System.Windows.Forms.RichTextBox rchTxtbox;
    }
}

