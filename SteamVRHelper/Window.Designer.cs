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
            this.gbxEnableUpscaling = new System.Windows.Forms.GroupBox();
            this.btnGetUpscaling = new System.Windows.Forms.Button();
            this.chbxEnableUpscaling = new System.Windows.Forms.CheckBox();
            this.gbxUpscaling = new System.Windows.Forms.GroupBox();
            this.lblScaledGames = new System.Windows.Forms.Label();
            this.lbxUpscaledGames = new System.Windows.Forms.ListBox();
            this.lblSharpnessValue = new System.Windows.Forms.Label();
            this.lblRenderScaleValue = new System.Windows.Forms.Label();
            this.btnApplyUpscaling = new System.Windows.Forms.Button();
            this.tbrSharpness = new System.Windows.Forms.TrackBar();
            this.lblSharpness = new System.Windows.Forms.Label();
            this.tbrRenderScale = new System.Windows.Forms.TrackBar();
            this.lblRenderScale = new System.Windows.Forms.Label();
            this.rbtnNIS = new System.Windows.Forms.RadioButton();
            this.rbtnFSR = new System.Windows.Forms.RadioButton();
            this.gbxService.SuspendLayout();
            this.gbxExit.SuspendLayout();
            this.gbxEnableUpscaling.SuspendLayout();
            this.gbxUpscaling.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbrSharpness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrRenderScale)).BeginInit();
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
            this.btnExit.Size = new System.Drawing.Size(188, 82);
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
            this.gbxExit.Location = new System.Drawing.Point(12, 151);
            this.gbxExit.Name = "gbxExit";
            this.gbxExit.Size = new System.Drawing.Size(200, 113);
            this.gbxExit.TabIndex = 6;
            this.gbxExit.TabStop = false;
            this.gbxExit.Text = "Exit VR";
            // 
            // gbxEnableUpscaling
            // 
            this.gbxEnableUpscaling.Controls.Add(this.btnGetUpscaling);
            this.gbxEnableUpscaling.Controls.Add(this.chbxEnableUpscaling);
            this.gbxEnableUpscaling.Location = new System.Drawing.Point(12, 95);
            this.gbxEnableUpscaling.Name = "gbxEnableUpscaling";
            this.gbxEnableUpscaling.Size = new System.Drawing.Size(200, 50);
            this.gbxEnableUpscaling.TabIndex = 7;
            this.gbxEnableUpscaling.TabStop = false;
            this.gbxEnableUpscaling.Text = "Upscaling";
            // 
            // btnGetUpscaling
            // 
            this.btnGetUpscaling.Location = new System.Drawing.Point(119, 19);
            this.btnGetUpscaling.Name = "btnGetUpscaling";
            this.btnGetUpscaling.Size = new System.Drawing.Size(75, 23);
            this.btnGetUpscaling.TabIndex = 5;
            this.btnGetUpscaling.Text = "Get";
            this.btnGetUpscaling.UseVisualStyleBackColor = true;
            this.btnGetUpscaling.Click += new System.EventHandler(this.btnGetUpscaling_Click);
            // 
            // chbxEnableUpscaling
            // 
            this.chbxEnableUpscaling.AutoSize = true;
            this.chbxEnableUpscaling.Location = new System.Drawing.Point(6, 23);
            this.chbxEnableUpscaling.Name = "chbxEnableUpscaling";
            this.chbxEnableUpscaling.Size = new System.Drawing.Size(68, 20);
            this.chbxEnableUpscaling.TabIndex = 0;
            this.chbxEnableUpscaling.Text = "Enabled";
            this.chbxEnableUpscaling.UseVisualStyleBackColor = true;
            this.chbxEnableUpscaling.CheckedChanged += new System.EventHandler(this.chbxEnableUpscaling_CheckedChanged);
            // 
            // gbxUpscaling
            // 
            this.gbxUpscaling.Controls.Add(this.lblScaledGames);
            this.gbxUpscaling.Controls.Add(this.lbxUpscaledGames);
            this.gbxUpscaling.Controls.Add(this.lblSharpnessValue);
            this.gbxUpscaling.Controls.Add(this.lblRenderScaleValue);
            this.gbxUpscaling.Controls.Add(this.btnApplyUpscaling);
            this.gbxUpscaling.Controls.Add(this.tbrSharpness);
            this.gbxUpscaling.Controls.Add(this.lblSharpness);
            this.gbxUpscaling.Controls.Add(this.tbrRenderScale);
            this.gbxUpscaling.Controls.Add(this.lblRenderScale);
            this.gbxUpscaling.Controls.Add(this.rbtnNIS);
            this.gbxUpscaling.Controls.Add(this.rbtnFSR);
            this.gbxUpscaling.Location = new System.Drawing.Point(218, 12);
            this.gbxUpscaling.Name = "gbxUpscaling";
            this.gbxUpscaling.Size = new System.Drawing.Size(401, 252);
            this.gbxUpscaling.TabIndex = 8;
            this.gbxUpscaling.TabStop = false;
            this.gbxUpscaling.Text = "Upscaling Settings";
            // 
            // lblScaledGames
            // 
            this.lblScaledGames.AutoSize = true;
            this.lblScaledGames.Location = new System.Drawing.Point(200, 23);
            this.lblScaledGames.Name = "lblScaledGames";
            this.lblScaledGames.Size = new System.Drawing.Size(79, 16);
            this.lblScaledGames.TabIndex = 11;
            this.lblScaledGames.Text = "Scaled Games";
            // 
            // lbxUpscaledGames
            // 
            this.lbxUpscaledGames.FormattingEnabled = true;
            this.lbxUpscaledGames.ItemHeight = 16;
            this.lbxUpscaledGames.Location = new System.Drawing.Point(200, 47);
            this.lbxUpscaledGames.Name = "lbxUpscaledGames";
            this.lbxUpscaledGames.Size = new System.Drawing.Size(195, 196);
            this.lbxUpscaledGames.TabIndex = 10;
            // 
            // lblSharpnessValue
            // 
            this.lblSharpnessValue.AutoSize = true;
            this.lblSharpnessValue.Location = new System.Drawing.Point(151, 150);
            this.lblSharpnessValue.Name = "lblSharpnessValue";
            this.lblSharpnessValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSharpnessValue.Size = new System.Drawing.Size(43, 16);
            this.lblSharpnessValue.TabIndex = 9;
            this.lblSharpnessValue.Text = "[value]";
            this.lblSharpnessValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRenderScaleValue
            // 
            this.lblRenderScaleValue.AutoSize = true;
            this.lblRenderScaleValue.Location = new System.Drawing.Point(151, 83);
            this.lblRenderScaleValue.Name = "lblRenderScaleValue";
            this.lblRenderScaleValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblRenderScaleValue.Size = new System.Drawing.Size(43, 16);
            this.lblRenderScaleValue.TabIndex = 8;
            this.lblRenderScaleValue.Text = "[value]";
            this.lblRenderScaleValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnApplyUpscaling
            // 
            this.btnApplyUpscaling.Location = new System.Drawing.Point(6, 220);
            this.btnApplyUpscaling.Name = "btnApplyUpscaling";
            this.btnApplyUpscaling.Size = new System.Drawing.Size(188, 23);
            this.btnApplyUpscaling.TabIndex = 7;
            this.btnApplyUpscaling.Text = "Apply";
            this.btnApplyUpscaling.UseVisualStyleBackColor = true;
            this.btnApplyUpscaling.Click += new System.EventHandler(this.btnApplyUpscaling_Click);
            // 
            // tbrSharpness
            // 
            this.tbrSharpness.LargeChange = 10;
            this.tbrSharpness.Location = new System.Drawing.Point(6, 169);
            this.tbrSharpness.Maximum = 100;
            this.tbrSharpness.Minimum = 1;
            this.tbrSharpness.Name = "tbrSharpness";
            this.tbrSharpness.Size = new System.Drawing.Size(188, 45);
            this.tbrSharpness.TabIndex = 6;
            this.tbrSharpness.Value = 1;
            this.tbrSharpness.Scroll += new System.EventHandler(this.tbrSharpness_Scroll);
            // 
            // lblSharpness
            // 
            this.lblSharpness.AutoSize = true;
            this.lblSharpness.Location = new System.Drawing.Point(6, 150);
            this.lblSharpness.Name = "lblSharpness";
            this.lblSharpness.Size = new System.Drawing.Size(63, 16);
            this.lblSharpness.TabIndex = 5;
            this.lblSharpness.Text = "Sharpness:";
            // 
            // tbrRenderScale
            // 
            this.tbrRenderScale.LargeChange = 10;
            this.tbrRenderScale.Location = new System.Drawing.Point(6, 102);
            this.tbrRenderScale.Maximum = 100;
            this.tbrRenderScale.Minimum = 1;
            this.tbrRenderScale.Name = "tbrRenderScale";
            this.tbrRenderScale.Size = new System.Drawing.Size(188, 45);
            this.tbrRenderScale.TabIndex = 4;
            this.tbrRenderScale.Value = 1;
            this.tbrRenderScale.Scroll += new System.EventHandler(this.tbrRenderScale_Scroll);
            // 
            // lblRenderScale
            // 
            this.lblRenderScale.AutoSize = true;
            this.lblRenderScale.Location = new System.Drawing.Point(6, 83);
            this.lblRenderScale.Name = "lblRenderScale";
            this.lblRenderScale.Size = new System.Drawing.Size(77, 16);
            this.lblRenderScale.TabIndex = 3;
            this.lblRenderScale.Text = "Render Scale:";
            // 
            // rbtnNIS
            // 
            this.rbtnNIS.AutoSize = true;
            this.rbtnNIS.Location = new System.Drawing.Point(6, 47);
            this.rbtnNIS.Name = "rbtnNIS";
            this.rbtnNIS.Size = new System.Drawing.Size(89, 20);
            this.rbtnNIS.TabIndex = 2;
            this.rbtnNIS.TabStop = true;
            this.rbtnNIS.Text = "NIS (NVidia)";
            this.rbtnNIS.UseVisualStyleBackColor = true;
            this.rbtnNIS.CheckedChanged += new System.EventHandler(this.rbtnOpenVR_Changed);
            // 
            // rbtnFSR
            // 
            this.rbtnFSR.AutoSize = true;
            this.rbtnFSR.Location = new System.Drawing.Point(6, 21);
            this.rbtnFSR.Name = "rbtnFSR";
            this.rbtnFSR.Size = new System.Drawing.Size(82, 20);
            this.rbtnFSR.TabIndex = 1;
            this.rbtnFSR.TabStop = true;
            this.rbtnFSR.Text = "FSR (AMD)";
            this.rbtnFSR.UseVisualStyleBackColor = true;
            this.rbtnFSR.CheckedChanged += new System.EventHandler(this.rbtnOpenVR_Changed);
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 275);
            this.Controls.Add(this.gbxUpscaling);
            this.Controls.Add(this.gbxEnableUpscaling);
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
            this.gbxEnableUpscaling.ResumeLayout(false);
            this.gbxEnableUpscaling.PerformLayout();
            this.gbxUpscaling.ResumeLayout(false);
            this.gbxUpscaling.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbrSharpness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrRenderScale)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RadioButton rbtnSteamVR;
        private RadioButton rbtnOculus;
        private Button btnExit;
        private GroupBox gbxService;
        private GroupBox gbxExit;
        private Button btnGetSteamVR;
        private GroupBox gbxEnableUpscaling;
        private CheckBox chbxEnableUpscaling;
        private GroupBox gbxUpscaling;
        private RadioButton rbtnNIS;
        private RadioButton rbtnFSR;
        private TrackBar tbrSharpness;
        private Label lblSharpness;
        private TrackBar tbrRenderScale;
        private Label lblRenderScale;
        private Button btnApplyUpscaling;
        private Label lblSharpnessValue;
        private Label lblRenderScaleValue;
        private Button btnGetUpscaling;
        private Label lblUpscaledGames;
        private CheckedListBox chlbxUpscaledGames;
        private Label lblScaledGames;
        private ListBox lbxUpscaledGames;
    }
}