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
            this.btnExit = new System.Windows.Forms.Button();
            this.gbxService = new System.Windows.Forms.GroupBox();
            this.lblActiveService = new System.Windows.Forms.Label();
            this.btnServiceSteam = new System.Windows.Forms.Button();
            this.btnServiceOculus = new System.Windows.Forms.Button();
            this.btnBackupService = new System.Windows.Forms.Button();
            this.gbxExit = new System.Windows.Forms.GroupBox();
            this.gbxUpscaling = new System.Windows.Forms.GroupBox();
            this.btnEnableUpscaling = new System.Windows.Forms.Button();
            this.btnDisableUpscaling = new System.Windows.Forms.Button();
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
            this.btnUpscalerBackup = new System.Windows.Forms.Button();
            this.gbxService.SuspendLayout();
            this.gbxExit.SuspendLayout();
            this.gbxUpscaling.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbrSharpness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrRenderScale)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(6, 22);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(188, 74);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gbxService
            // 
            this.gbxService.Controls.Add(this.lblActiveService);
            this.gbxService.Controls.Add(this.btnServiceSteam);
            this.gbxService.Controls.Add(this.btnServiceOculus);
            this.gbxService.Controls.Add(this.btnBackupService);
            this.gbxService.Location = new System.Drawing.Point(12, 12);
            this.gbxService.Name = "gbxService";
            this.gbxService.Size = new System.Drawing.Size(200, 144);
            this.gbxService.TabIndex = 5;
            this.gbxService.TabStop = false;
            this.gbxService.Text = "VR Service";
            // 
            // lblActiveService
            // 
            this.lblActiveService.AutoSize = true;
            this.lblActiveService.Location = new System.Drawing.Point(6, 25);
            this.lblActiveService.Name = "lblActiveService";
            this.lblActiveService.Size = new System.Drawing.Size(43, 16);
            this.lblActiveService.TabIndex = 18;
            this.lblActiveService.Text = "[value]";
            // 
            // btnServiceSteam
            // 
            this.btnServiceSteam.Location = new System.Drawing.Point(6, 47);
            this.btnServiceSteam.Name = "btnServiceSteam";
            this.btnServiceSteam.Size = new System.Drawing.Size(188, 23);
            this.btnServiceSteam.TabIndex = 17;
            this.btnServiceSteam.Text = "Enable Steam";
            this.btnServiceSteam.UseVisualStyleBackColor = true;
            this.btnServiceSteam.Click += new System.EventHandler(this.btnServiceSteam_Click);
            // 
            // btnServiceOculus
            // 
            this.btnServiceOculus.Location = new System.Drawing.Point(6, 76);
            this.btnServiceOculus.Name = "btnServiceOculus";
            this.btnServiceOculus.Size = new System.Drawing.Size(188, 23);
            this.btnServiceOculus.TabIndex = 16;
            this.btnServiceOculus.Text = "Enable Oculus";
            this.btnServiceOculus.UseVisualStyleBackColor = true;
            this.btnServiceOculus.Click += new System.EventHandler(this.btnServiceOculus_Click);
            // 
            // btnBackupService
            // 
            this.btnBackupService.Location = new System.Drawing.Point(6, 105);
            this.btnBackupService.Name = "btnBackupService";
            this.btnBackupService.Size = new System.Drawing.Size(188, 23);
            this.btnBackupService.TabIndex = 15;
            this.btnBackupService.Text = "Backup";
            this.btnBackupService.UseVisualStyleBackColor = true;
            this.btnBackupService.Click += new System.EventHandler(this.btnBackupService_Click);
            // 
            // gbxExit
            // 
            this.gbxExit.Controls.Add(this.btnExit);
            this.gbxExit.Location = new System.Drawing.Point(12, 162);
            this.gbxExit.Name = "gbxExit";
            this.gbxExit.Size = new System.Drawing.Size(200, 102);
            this.gbxExit.TabIndex = 6;
            this.gbxExit.TabStop = false;
            this.gbxExit.Text = "Exit VR";
            // 
            // gbxUpscaling
            // 
            this.gbxUpscaling.Controls.Add(this.btnUpscalerBackup);
            this.gbxUpscaling.Controls.Add(this.btnEnableUpscaling);
            this.gbxUpscaling.Controls.Add(this.btnDisableUpscaling);
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
            // btnEnableUpscaling
            // 
            this.btnEnableUpscaling.Location = new System.Drawing.Point(200, 220);
            this.btnEnableUpscaling.Name = "btnEnableUpscaling";
            this.btnEnableUpscaling.Size = new System.Drawing.Size(97, 23);
            this.btnEnableUpscaling.TabIndex = 14;
            this.btnEnableUpscaling.Text = "Enable";
            this.btnEnableUpscaling.UseVisualStyleBackColor = true;
            this.btnEnableUpscaling.Click += new System.EventHandler(this.btnEnableUpscaling_Click);
            // 
            // btnDisableUpscaling
            // 
            this.btnDisableUpscaling.Location = new System.Drawing.Point(303, 220);
            this.btnDisableUpscaling.Name = "btnDisableUpscaling";
            this.btnDisableUpscaling.Size = new System.Drawing.Size(92, 23);
            this.btnDisableUpscaling.TabIndex = 13;
            this.btnDisableUpscaling.Text = "Disable";
            this.btnDisableUpscaling.UseVisualStyleBackColor = true;
            this.btnDisableUpscaling.Click += new System.EventHandler(this.btnDisableUpscaling_Click);
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
            this.lbxUpscaledGames.Size = new System.Drawing.Size(195, 164);
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
            this.btnApplyUpscaling.Location = new System.Drawing.Point(105, 220);
            this.btnApplyUpscaling.Name = "btnApplyUpscaling";
            this.btnApplyUpscaling.Size = new System.Drawing.Size(89, 23);
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
            // btnUpscalerBackup
            // 
            this.btnUpscalerBackup.Location = new System.Drawing.Point(10, 220);
            this.btnUpscalerBackup.Name = "btnUpscalerBackup";
            this.btnUpscalerBackup.Size = new System.Drawing.Size(89, 23);
            this.btnUpscalerBackup.TabIndex = 15;
            this.btnUpscalerBackup.Text = "Backup";
            this.btnUpscalerBackup.UseVisualStyleBackColor = true;
            this.btnUpscalerBackup.Click += new System.EventHandler(this.btnUpscalerBackup_Click);
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 275);
            this.Controls.Add(this.gbxUpscaling);
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
            this.gbxUpscaling.ResumeLayout(false);
            this.gbxUpscaling.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbrSharpness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrRenderScale)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnExit;
        private GroupBox gbxService;
        private GroupBox gbxExit;
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
        private Label lblUpscaledGames;
        private CheckedListBox chlbxUpscaledGames;
        private Label lblScaledGames;
        private ListBox lbxUpscaledGames;
        private Button btnEnableUpscaling;
        private Button btnDisableUpscaling;
        private Button btnBackupService;
        private Button btnServiceSteam;
        private Button btnServiceOculus;
        private Label lblActiveService;
        private Button btnUpscalerBackup;
    }
}