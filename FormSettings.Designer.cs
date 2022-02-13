namespace Juggler
{
    partial class FormSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonGetSavedPath = new System.Windows.Forms.Button();
            this.buttonGetSystemPath = new System.Windows.Forms.Button();
            this.buttonSaveSystemPath = new System.Windows.Forms.Button();
            this.checkBoxChangeJdkBasedOnDefaultJdk = new System.Windows.Forms.CheckBox();
            this.buttonRestoreSystemPath = new System.Windows.Forms.Button();
            this.statusStripSettings = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelSettings = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBarSettings = new System.Windows.Forms.ToolStripProgressBar();
            this.buttonRestoreJavaHome = new System.Windows.Forms.Button();
            this.buttonSaveSystemJavaHome = new System.Windows.Forms.Button();
            this.buttonGetSavedJavaHome = new System.Windows.Forms.Button();
            this.buttonGetSystemJavaHome = new System.Windows.Forms.Button();
            this.checkBoxAutomaticallySavePathAndJavaHome = new System.Windows.Forms.CheckBox();
            this.buttonRestoreRegistryJarfileCommand = new System.Windows.Forms.Button();
            this.statusStripSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonOK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonOK.Location = new System.Drawing.Point(118, 452);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(76, 29);
            this.buttonOK.TabIndex = 5;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonCancel.Location = new System.Drawing.Point(200, 452);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(76, 29);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // buttonGetSavedPath
            // 
            this.buttonGetSavedPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonGetSavedPath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonGetSavedPath.Location = new System.Drawing.Point(10, 106);
            this.buttonGetSavedPath.Name = "buttonGetSavedPath";
            this.buttonGetSavedPath.Size = new System.Drawing.Size(267, 29);
            this.buttonGetSavedPath.TabIndex = 8;
            this.buttonGetSavedPath.Text = "Get Saved PATH";
            this.buttonGetSavedPath.UseVisualStyleBackColor = true;
            this.buttonGetSavedPath.Click += new System.EventHandler(this.ButtonGetSavedPath_Click);
            // 
            // buttonGetSystemPath
            // 
            this.buttonGetSystemPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonGetSystemPath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonGetSystemPath.Location = new System.Drawing.Point(11, 71);
            this.buttonGetSystemPath.Name = "buttonGetSystemPath";
            this.buttonGetSystemPath.Size = new System.Drawing.Size(266, 29);
            this.buttonGetSystemPath.TabIndex = 9;
            this.buttonGetSystemPath.Text = "Get System PATH";
            this.buttonGetSystemPath.UseVisualStyleBackColor = true;
            this.buttonGetSystemPath.Click += new System.EventHandler(this.ButtonGetSystemPath_Click);
            // 
            // buttonSaveSystemPath
            // 
            this.buttonSaveSystemPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonSaveSystemPath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonSaveSystemPath.Location = new System.Drawing.Point(11, 231);
            this.buttonSaveSystemPath.Name = "buttonSaveSystemPath";
            this.buttonSaveSystemPath.Size = new System.Drawing.Size(266, 29);
            this.buttonSaveSystemPath.TabIndex = 10;
            this.buttonSaveSystemPath.Text = "Save System PATH";
            this.buttonSaveSystemPath.UseVisualStyleBackColor = true;
            this.buttonSaveSystemPath.Click += new System.EventHandler(this.ButtonSaveSystemPath_Click);
            // 
            // checkBoxChangeJdkBasedOnDefaultJdk
            // 
            this.checkBoxChangeJdkBasedOnDefaultJdk.AutoSize = true;
            this.checkBoxChangeJdkBasedOnDefaultJdk.Location = new System.Drawing.Point(12, 12);
            this.checkBoxChangeJdkBasedOnDefaultJdk.Name = "checkBoxChangeJdkBasedOnDefaultJdk";
            this.checkBoxChangeJdkBasedOnDefaultJdk.Size = new System.Drawing.Size(191, 17);
            this.checkBoxChangeJdkBasedOnDefaultJdk.TabIndex = 11;
            this.checkBoxChangeJdkBasedOnDefaultJdk.Text = "Change JDK based on default JDK";
            this.checkBoxChangeJdkBasedOnDefaultJdk.UseVisualStyleBackColor = true;
            // 
            // buttonRestoreSystemPath
            // 
            this.buttonRestoreSystemPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonRestoreSystemPath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonRestoreSystemPath.Location = new System.Drawing.Point(11, 321);
            this.buttonRestoreSystemPath.Name = "buttonRestoreSystemPath";
            this.buttonRestoreSystemPath.Size = new System.Drawing.Size(266, 29);
            this.buttonRestoreSystemPath.TabIndex = 12;
            this.buttonRestoreSystemPath.Text = "Restore System PATH";
            this.buttonRestoreSystemPath.UseVisualStyleBackColor = true;
            this.buttonRestoreSystemPath.Click += new System.EventHandler(this.ButtonRestoreSystemPath_Click);
            // 
            // statusStripSettings
            // 
            this.statusStripSettings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelSettings,
            this.toolStripProgressBarSettings});
            this.statusStripSettings.Location = new System.Drawing.Point(0, 484);
            this.statusStripSettings.Name = "statusStripSettings";
            this.statusStripSettings.Size = new System.Drawing.Size(291, 22);
            this.statusStripSettings.TabIndex = 13;
            this.statusStripSettings.Text = "statusStripsSettings";
            // 
            // toolStripStatusLabelSettings
            // 
            this.toolStripStatusLabelSettings.Name = "toolStripStatusLabelSettings";
            this.toolStripStatusLabelSettings.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabelSettings.Text = "Ready";
            // 
            // toolStripProgressBarSettings
            // 
            this.toolStripProgressBarSettings.Name = "toolStripProgressBarSettings";
            this.toolStripProgressBarSettings.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBarSettings.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            // 
            // buttonRestoreJavaHome
            // 
            this.buttonRestoreJavaHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonRestoreJavaHome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonRestoreJavaHome.Location = new System.Drawing.Point(11, 356);
            this.buttonRestoreJavaHome.Name = "buttonRestoreJavaHome";
            this.buttonRestoreJavaHome.Size = new System.Drawing.Size(266, 29);
            this.buttonRestoreJavaHome.TabIndex = 14;
            this.buttonRestoreJavaHome.Text = "Restore JAVA_HOME";
            this.buttonRestoreJavaHome.UseVisualStyleBackColor = true;
            this.buttonRestoreJavaHome.Click += new System.EventHandler(this.ButtonRestoreJavaHome_Click);
            // 
            // buttonSaveSystemJavaHome
            // 
            this.buttonSaveSystemJavaHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonSaveSystemJavaHome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonSaveSystemJavaHome.Location = new System.Drawing.Point(10, 266);
            this.buttonSaveSystemJavaHome.Name = "buttonSaveSystemJavaHome";
            this.buttonSaveSystemJavaHome.Size = new System.Drawing.Size(266, 29);
            this.buttonSaveSystemJavaHome.TabIndex = 15;
            this.buttonSaveSystemJavaHome.Text = "Save System JAVA_HOME";
            this.buttonSaveSystemJavaHome.UseVisualStyleBackColor = true;
            this.buttonSaveSystemJavaHome.Click += new System.EventHandler(this.ButtonSaveSystemJavaHome_Click);
            // 
            // buttonGetSavedJavaHome
            // 
            this.buttonGetSavedJavaHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonGetSavedJavaHome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonGetSavedJavaHome.Location = new System.Drawing.Point(10, 176);
            this.buttonGetSavedJavaHome.Name = "buttonGetSavedJavaHome";
            this.buttonGetSavedJavaHome.Size = new System.Drawing.Size(267, 29);
            this.buttonGetSavedJavaHome.TabIndex = 16;
            this.buttonGetSavedJavaHome.Text = "Get Saved JAVA_HOME";
            this.buttonGetSavedJavaHome.UseVisualStyleBackColor = true;
            this.buttonGetSavedJavaHome.Click += new System.EventHandler(this.ButtonGetSavedJavaHome_Click);
            // 
            // buttonGetSystemJavaHome
            // 
            this.buttonGetSystemJavaHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonGetSystemJavaHome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonGetSystemJavaHome.Location = new System.Drawing.Point(10, 141);
            this.buttonGetSystemJavaHome.Name = "buttonGetSystemJavaHome";
            this.buttonGetSystemJavaHome.Size = new System.Drawing.Size(267, 29);
            this.buttonGetSystemJavaHome.TabIndex = 17;
            this.buttonGetSystemJavaHome.Text = "Get System JAVA_HOME";
            this.buttonGetSystemJavaHome.UseVisualStyleBackColor = true;
            this.buttonGetSystemJavaHome.Click += new System.EventHandler(this.ButtonGetSystemJavaHome_Click);
            // 
            // checkBoxAutomaticallySavePathAndJavaHome
            // 
            this.checkBoxAutomaticallySavePathAndJavaHome.AutoSize = true;
            this.checkBoxAutomaticallySavePathAndJavaHome.Location = new System.Drawing.Point(11, 35);
            this.checkBoxAutomaticallySavePathAndJavaHome.Name = "checkBoxAutomaticallySavePathAndJavaHome";
            this.checkBoxAutomaticallySavePathAndJavaHome.Size = new System.Drawing.Size(234, 17);
            this.checkBoxAutomaticallySavePathAndJavaHome.TabIndex = 18;
            this.checkBoxAutomaticallySavePathAndJavaHome.Text = "Automatically save PATH and JAVA_HOME";
            this.checkBoxAutomaticallySavePathAndJavaHome.UseVisualStyleBackColor = true;
            // 
            // buttonRestoreRegistryJarfileCommand
            // 
            this.buttonRestoreRegistryJarfileCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonRestoreRegistryJarfileCommand.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonRestoreRegistryJarfileCommand.Location = new System.Drawing.Point(11, 391);
            this.buttonRestoreRegistryJarfileCommand.Name = "buttonRestoreRegistryJarfileCommand";
            this.buttonRestoreRegistryJarfileCommand.Size = new System.Drawing.Size(266, 29);
            this.buttonRestoreRegistryJarfileCommand.TabIndex = 19;
            this.buttonRestoreRegistryJarfileCommand.Text = "Restore Registry Jarfile Command";
            this.buttonRestoreRegistryJarfileCommand.UseVisualStyleBackColor = true;
            this.buttonRestoreRegistryJarfileCommand.Click += new System.EventHandler(this.ButtonRestoreRegistryJarfileCommand_Click);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 506);
            this.Controls.Add(this.buttonRestoreRegistryJarfileCommand);
            this.Controls.Add(this.checkBoxAutomaticallySavePathAndJavaHome);
            this.Controls.Add(this.buttonGetSystemJavaHome);
            this.Controls.Add(this.buttonGetSavedJavaHome);
            this.Controls.Add(this.buttonSaveSystemJavaHome);
            this.Controls.Add(this.buttonRestoreJavaHome);
            this.Controls.Add(this.statusStripSettings);
            this.Controls.Add(this.buttonRestoreSystemPath);
            this.Controls.Add(this.checkBoxChangeJdkBasedOnDefaultJdk);
            this.Controls.Add(this.buttonSaveSystemPath);
            this.Controls.Add(this.buttonGetSystemPath);
            this.Controls.Add(this.buttonGetSavedPath);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.statusStripSettings.ResumeLayout(false);
            this.statusStripSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonGetSavedPath;
        private System.Windows.Forms.Button buttonGetSystemPath;
        private System.Windows.Forms.Button buttonSaveSystemPath;
        private System.Windows.Forms.CheckBox checkBoxChangeJdkBasedOnDefaultJdk;
        private System.Windows.Forms.Button buttonRestoreSystemPath;
        private System.Windows.Forms.StatusStrip statusStripSettings;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelSettings;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBarSettings;
        private System.Windows.Forms.Button buttonRestoreJavaHome;
        private System.Windows.Forms.Button buttonSaveSystemJavaHome;
        private System.Windows.Forms.Button buttonGetSavedJavaHome;
        private System.Windows.Forms.Button buttonGetSystemJavaHome;
        private System.Windows.Forms.CheckBox checkBoxAutomaticallySavePathAndJavaHome;
        private System.Windows.Forms.Button buttonRestoreRegistryJarfileCommand;
    }
}