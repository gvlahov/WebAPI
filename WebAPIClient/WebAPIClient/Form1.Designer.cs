namespace WebAPIClient
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
            this.tabControlPages = new System.Windows.Forms.TabControl();
            this.tabPageRequest = new System.Windows.Forms.TabPage();
            this.textBoxRequest = new System.Windows.Forms.TextBox();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.buttonCall = new System.Windows.Forms.Button();
            this.tabPageResponse = new System.Windows.Forms.TabPage();
            this.textBoxResponse = new System.Windows.Forms.TextBox();
            this.tabControlPages.SuspendLayout();
            this.tabPageRequest.SuspendLayout();
            this.tabPageResponse.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlPages
            // 
            this.tabControlPages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlPages.Controls.Add(this.tabPageRequest);
            this.tabControlPages.Controls.Add(this.tabPageResponse);
            this.tabControlPages.Location = new System.Drawing.Point(12, 12);
            this.tabControlPages.Name = "tabControlPages";
            this.tabControlPages.SelectedIndex = 0;
            this.tabControlPages.Size = new System.Drawing.Size(760, 537);
            this.tabControlPages.TabIndex = 0;
            // 
            // tabPageRequest
            // 
            this.tabPageRequest.Controls.Add(this.textBoxRequest);
            this.tabPageRequest.Controls.Add(this.textBoxURL);
            this.tabPageRequest.Controls.Add(this.buttonCall);
            this.tabPageRequest.Location = new System.Drawing.Point(4, 22);
            this.tabPageRequest.Name = "tabPageRequest";
            this.tabPageRequest.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRequest.Size = new System.Drawing.Size(752, 511);
            this.tabPageRequest.TabIndex = 0;
            this.tabPageRequest.Text = "Request";
            this.tabPageRequest.UseVisualStyleBackColor = true;
            // 
            // textBoxRequest
            // 
            this.textBoxRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRequest.Location = new System.Drawing.Point(6, 35);
            this.textBoxRequest.Multiline = true;
            this.textBoxRequest.Name = "textBoxRequest";
            this.textBoxRequest.Size = new System.Drawing.Size(740, 470);
            this.textBoxRequest.TabIndex = 3;
            // 
            // textBoxURL
            // 
            this.textBoxURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxURL.Location = new System.Drawing.Point(87, 8);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(659, 20);
            this.textBoxURL.TabIndex = 2;
            this.textBoxURL.Text = "http://localhost:58255/api/orders";
            // 
            // buttonCall
            // 
            this.buttonCall.Location = new System.Drawing.Point(6, 6);
            this.buttonCall.Name = "buttonCall";
            this.buttonCall.Size = new System.Drawing.Size(75, 23);
            this.buttonCall.TabIndex = 1;
            this.buttonCall.Text = "Call";
            this.buttonCall.UseVisualStyleBackColor = true;
            this.buttonCall.Click += new System.EventHandler(this.buttonCall_Click);
            // 
            // tabPageResponse
            // 
            this.tabPageResponse.Controls.Add(this.textBoxResponse);
            this.tabPageResponse.Location = new System.Drawing.Point(4, 22);
            this.tabPageResponse.Name = "tabPageResponse";
            this.tabPageResponse.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageResponse.Size = new System.Drawing.Size(752, 511);
            this.tabPageResponse.TabIndex = 1;
            this.tabPageResponse.Text = "Response";
            this.tabPageResponse.UseVisualStyleBackColor = true;
            // 
            // textBoxResponse
            // 
            this.textBoxResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxResponse.Location = new System.Drawing.Point(6, 6);
            this.textBoxResponse.Multiline = true;
            this.textBoxResponse.Name = "textBoxResponse";
            this.textBoxResponse.Size = new System.Drawing.Size(740, 499);
            this.textBoxResponse.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tabControlPages);
            this.Name = "Form1";
            this.Text = "Web API Client";
            this.tabControlPages.ResumeLayout(false);
            this.tabPageRequest.ResumeLayout(false);
            this.tabPageRequest.PerformLayout();
            this.tabPageResponse.ResumeLayout(false);
            this.tabPageResponse.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlPages;
        private System.Windows.Forms.TabPage tabPageRequest;
        private System.Windows.Forms.TabPage tabPageResponse;
        private System.Windows.Forms.Button buttonCall;
        private System.Windows.Forms.TextBox textBoxRequest;
        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.TextBox textBoxResponse;

    }
}

