namespace Web_Brw
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
            this.webBrowser1 = new Web_Brw.WebBrowser();
            this.webBrowser2 = new Web_Brw.WebBrowser();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.webBrowser1.Location = new System.Drawing.Point(27, 27);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(297, 225);
            this.webBrowser1.TabIndex = 0;
            // 
            // webBrowser2
            // 
            this.webBrowser2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.webBrowser2.Location = new System.Drawing.Point(352, 27);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.Size = new System.Drawing.Size(297, 225);
            this.webBrowser2.TabIndex = 1;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 458);
            this.Controls.Add(this.webBrowser2);
            this.Controls.Add(this.webBrowser1);
            this.Name = "Form1";
            this.Text = "Web Browser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private WebBrowser webBrowser1;
        private WebBrowser webBrowser2;

    }
}

