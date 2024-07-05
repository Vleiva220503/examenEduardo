namespace WindowsFormsApp1
{
    partial class FormPrincipal
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
            this.btnStartCall = new System.Windows.Forms.Button();
            this.panelVideo = new System.Windows.Forms.Panel();
            this.txtCallUrl = new System.Windows.Forms.TextBox();
            this.btnCopyUrl = new System.Windows.Forms.Button();
            this.btnGoToUrl = new System.Windows.Forms.Button();
            this.txtInputUrl = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStartCall
            // 
            this.btnStartCall.Location = new System.Drawing.Point(338, 507);
            this.btnStartCall.Name = "btnStartCall";
            this.btnStartCall.Size = new System.Drawing.Size(120, 41);
            this.btnStartCall.TabIndex = 0;
            this.btnStartCall.Text = "btnStartCall";
            this.btnStartCall.UseVisualStyleBackColor = true;
            this.btnStartCall.Click += new System.EventHandler(this.btnStartCall_Click_1);
            // 
            // panelVideo
            // 
            this.panelVideo.Location = new System.Drawing.Point(12, 36);
            this.panelVideo.Name = "panelVideo";
            this.panelVideo.Size = new System.Drawing.Size(766, 256);
            this.panelVideo.TabIndex = 1;
            // 
            // txtCallUrl
            // 
            this.txtCallUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCallUrl.Location = new System.Drawing.Point(129, 436);
            this.txtCallUrl.Name = "txtCallUrl";
            this.txtCallUrl.Size = new System.Drawing.Size(273, 26);
            this.txtCallUrl.TabIndex = 2;
            // 
            // btnCopyUrl
            // 
            this.btnCopyUrl.Location = new System.Drawing.Point(478, 428);
            this.btnCopyUrl.Name = "btnCopyUrl";
            this.btnCopyUrl.Size = new System.Drawing.Size(146, 34);
            this.btnCopyUrl.TabIndex = 3;
            this.btnCopyUrl.Text = "btnCopyUrl";
            this.btnCopyUrl.UseVisualStyleBackColor = true;
            this.btnCopyUrl.Click += new System.EventHandler(this.btnCopyUrl_Click);
            // 
            // btnGoToUrl
            // 
            this.btnGoToUrl.Location = new System.Drawing.Point(478, 362);
            this.btnGoToUrl.Name = "btnGoToUrl";
            this.btnGoToUrl.Size = new System.Drawing.Size(146, 34);
            this.btnGoToUrl.TabIndex = 4;
            this.btnGoToUrl.Text = "btnGoToUrl";
            this.btnGoToUrl.UseVisualStyleBackColor = true;
            this.btnGoToUrl.Click += new System.EventHandler(this.btnGoToUrl_Click);
            // 
            // txtInputUrl
            // 
            this.txtInputUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputUrl.Location = new System.Drawing.Point(129, 365);
            this.txtInputUrl.Name = "txtInputUrl";
            this.txtInputUrl.Size = new System.Drawing.Size(273, 26);
            this.txtInputUrl.TabIndex = 5;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 592);
            this.Controls.Add(this.txtInputUrl);
            this.Controls.Add(this.btnGoToUrl);
            this.Controls.Add(this.btnCopyUrl);
            this.Controls.Add(this.txtCallUrl);
            this.Controls.Add(this.panelVideo);
            this.Controls.Add(this.btnStartCall);
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartCall;
        private System.Windows.Forms.Panel panelVideo;
        private System.Windows.Forms.TextBox txtCallUrl;
        private System.Windows.Forms.Button btnCopyUrl;
        private System.Windows.Forms.Button btnGoToUrl;
        private System.Windows.Forms.TextBox txtInputUrl;
    }
}