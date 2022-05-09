namespace SteamVRHelper
{
    partial class Window
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            this.rbtnSteamVR = new System.Windows.Forms.RadioButton();
            this.rbtnOculus = new System.Windows.Forms.RadioButton();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbxService = new System.Windows.Forms.GroupBox();
            this.btnGetSteamVR = new System.Windows.Forms.Button();
            this.gbxExit = new System.Windows.Forms.GroupBox();
            this.gbxService.SuspendLayout();
            this.gbxExit.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtnSteamVR
            // 
            this.rbtnSteamVR.AutoSize = true;
            this.rbtnSteamVR.Location = new System.Drawing.Point(6, 22);
            this.rbtnSteamVR.Name = "rbtnSteamVR";
            this.rbtnSteamVR.Size = new System.Drawing.Size(71, 20);
            this.rbtnSteamVR.TabIndex = 2;
            this.rbtnSteamVR.TabStop = true;
            this.rbtnSteamVR.Text = "SteamVR";
            this.rbtnSteamVR.UseVisualStyleBackColor = true;
            this.rbtnSteamVR.CheckedChanged += new System.EventHandler(this.rbtnService_Changed);
            // 
            // rbtnOculus
            // 
            this.rbtnOculus.AutoSize = true;
            this.rbtnOculus.Location = new System.Drawing.Point(6, 48);
            this.rbtnOculus.Name = "rbtnOculus";
            this.rbtnOculus.Size = new System.Drawing.Size(62, 20);
            this.rbtnOculus.TabIndex = 3;
            this.rbtnOculus.TabStop = true;
            this.rbtnOculus.Text = "Oculus";
            this.rbtnOculus.UseVisualStyleBackColor = true;
            this.rbtnOculus.CheckedChanged += new System.EventHandler(this.rbtnService_Changed);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(6, 22);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(188, 72);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gbxService
            // 
            this.gbxService.Controls.Add(this.btnGetSteamVR);
            this.gbxService.Controls.Add(this.rbtnSteamVR);
            this.gbxService.Controls.Add(this.rbtnOculus);
            this.gbxService.Location = new System.Drawing.Point(12, 12);
            this.gbxService.Name = "gbxService";
            this.gbxService.Size = new System.Drawing.Size(200, 77);
            this.gbxService.TabIndex = 5;
            this.gbxService.TabStop = false;
            this.gbxService.Text = "VR Service";
            // 
            // btnGetSteamVR
            // 
            this.btnGetSteamVR.Location = new System.Drawing.Point(119, 21);
            this.btnGetSteamVR.Name = "btnGetSteamVR";
            this.btnGetSteamVR.Size = new System.Drawing.Size(75, 23);
            this.btnGetSteamVR.TabIndex = 4;
            this.btnGetSteamVR.Text = "Get";
            this.btnGetSteamVR.UseVisualStyleBackColor = true;
            this.btnGetSteamVR.Click += new System.EventHandler(this.btnGetSteamVR_Click);
            // 
            // gbxExit
            // 
            this.gbxExit.Controls.Add(this.btnExit);
            this.gbxExit.Location = new System.Drawing.Point(12, 95);
            this.gbxExit.Name = "gbxExit";
            this.gbxExit.Size = new System.Drawing.Size(200, 100);
            this.gbxExit.TabIndex = 6;
            this.gbxExit.TabStop = false;
            this.gbxExit.Text = "Exit Oculus Link";
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 204);
            this.Controls.Add(this.gbxExit);
            this.Controls.Add(this.gbxService);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SteamVR Helper";
            this.gbxService.ResumeLayout(false);
            this.gbxService.PerformLayout();
            this.gbxExit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RadioButton rbtnSteamVR;
        private RadioButton rbtnOculus;
        private Button btnExit;
        private GroupBox gbxService;
        private GroupBox gbxExit;
        private Button btnGetSteamVR;
    }
}