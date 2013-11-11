namespace Taviana_Launcher
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
            this.text_StatusLabel = new System.Windows.Forms.Label();
            this.button_Action = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // text_StatusLabel
            // 
            this.text_StatusLabel.AutoEllipsis = true;
            this.text_StatusLabel.AutoSize = true;
            this.text_StatusLabel.BackColor = System.Drawing.Color.ForestGreen;
            this.text_StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_StatusLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.text_StatusLabel.Location = new System.Drawing.Point(450, 177);
            this.text_StatusLabel.Name = "text_StatusLabel";
            this.text_StatusLabel.Size = new System.Drawing.Size(158, 31);
            this.text_StatusLabel.TabIndex = 1;
            this.text_StatusLabel.Text = "StatusLabel";
            this.text_StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_Action
            // 
            this.button_Action.Location = new System.Drawing.Point(449, 220);
            this.button_Action.Name = "button_Action";
            this.button_Action.Size = new System.Drawing.Size(160, 46);
            this.button_Action.TabIndex = 2;
            this.button_Action.Text = "ActionButton";
            this.button_Action.UseVisualStyleBackColor = true;
            this.button_Action.Click += new System.EventHandler(this.button_Action_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Taviana_Launcher.Properties.Resources.paypal_donate_44;
            this.pictureBox2.Location = new System.Drawing.Point(464, 281);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(131, 83);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Taviana_Launcher.Properties.Resources._7_logo_source;
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1032, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1059, 376);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button_Action);
            this.Controls.Add(this.text_StatusLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Painless Jack - Tavi Epoch Launcher - www.ausinsane.com";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label text_StatusLabel;
        private System.Windows.Forms.Button button_Action;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

