using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juggler
{
    public partial class FormSettings : Form
    {
        private readonly IProperties<JugglerPropertiesDTO> props;
        private readonly IRegistry<string> jarRegistry;
        private readonly FormMain formMain;

        public FormSettings(IProperties<JugglerPropertiesDTO> props, IRegistry<string> jarRegistry, FormMain formMain)
        {
            InitializeComponent();
            this.props = props;
            this.jarRegistry = jarRegistry;
            this.formMain= formMain;
            checkBoxChangeJdkBasedOnDefaultJdk.Checked = props.Get().JavaPropertiesDTO.ChangeJdkBasedOnDefaultJdk;
            checkBoxAutomaticallySavePathAndJavaHome.Checked = props.Get().JavaPropertiesDTO.AutomaticallySavePathAndJavaHome;
            toolStripProgressBarSettings.MarqueeAnimationSpeed = 0;
        }

        private bool CheckDefaultIsPresent()
        {
            bool defaultIsPresent = false;

            foreach (JdkPropertiesDTO jdkPropertiesDTO in props.Get().JavaPropertiesDTO.JdkPropertiesDTOs)
            {
                if (jdkPropertiesDTO.IsDefault)
                {
                    defaultIsPresent = true;
                    break;
                }
            }

            return defaultIsPresent;
        }

        private void DisableAll()
        {
            buttonOK.Enabled = false;
            buttonCancel.Enabled = false;
            buttonGetSavedPath.Enabled = false;
            buttonGetSystemPath.Enabled = false;
            buttonSaveSystemPath.Enabled = false;
            checkBoxChangeJdkBasedOnDefaultJdk.Enabled = false;
            buttonRestoreSystemPath.Enabled = false;
            buttonRestoreJavaHome.Enabled = false;
            buttonSaveSystemJavaHome.Enabled = false;
            buttonGetSavedJavaHome.Enabled = false;
            buttonGetSystemJavaHome.Enabled = false;
            checkBoxAutomaticallySavePathAndJavaHome.Enabled = false;
        }

        private void ButtonGetSavedPath_Click(object sender, EventArgs e)
        {
            if (props.Get().SavedPath != null)
            {
                Clipboard.SetText(props.Get().SavedPath);
                MessageBox.Show("Saved PATH has been copied to clipboard!", "Copied!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("There is not saved PATH!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ButtonGetSystemPath_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Environment.GetEnvironmentVariable("Path", EnvironmentVariableTarget.Machine));
            MessageBox.Show("System PATH has been copied to clipboard!", "Copied!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButtonGetSystemJavaHome_Click(object sender, EventArgs e)
        {
            if (Environment.GetEnvironmentVariable("JAVA_HOME", EnvironmentVariableTarget.Machine) != null)
            {
                Clipboard.SetText(Environment.GetEnvironmentVariable("JAVA_HOME", EnvironmentVariableTarget.Machine));
                MessageBox.Show("System JAVA_HOME has been copied to clipboard!", "Copied!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("There is not system JAVA_HOME!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ButtonGetSavedJavaHome_Click(object sender, EventArgs e)
        {
            if (props.Get().SavedJavaHome != null)
            {
                Clipboard.SetText(props.Get().SavedJavaHome);
                MessageBox.Show("Saved JAVA_HOME has been copied to clipboard!", "Copied!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("There is not saved JAVA_HOME!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ButtonSaveSystemPath_Click(object sender, EventArgs e)
        {
            props.Get().SavedPath = Environment.GetEnvironmentVariable("Path", EnvironmentVariableTarget.Machine);
            props.Save();
            MessageBox.Show("System PATH has been saved!", "Saved!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButtonSaveSystemJavaHome_Click(object sender, EventArgs e)
        {
            props.Get().SavedJavaHome = Environment.GetEnvironmentVariable("JAVA_HOME", EnvironmentVariableTarget.Machine);
            props.Save();
            MessageBox.Show("System JAVA_HOME has been saved!", "Saved!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if (!CheckDefaultIsPresent())
            {
                MessageBox.Show("Default JDK is not set! Please, set default JDK in main window.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                props.Get().JavaPropertiesDTO.ChangeJdkBasedOnDefaultJdk = checkBoxChangeJdkBasedOnDefaultJdk.Checked;
                props.Get().JavaPropertiesDTO.AutomaticallySavePathAndJavaHome = checkBoxAutomaticallySavePathAndJavaHome.Checked;
                props.Save();
                Close();
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            if (props.Get().JavaPropertiesDTO.ChangeJdkBasedOnDefaultJdk != checkBoxChangeJdkBasedOnDefaultJdk.Checked ||
                props.Get().JavaPropertiesDTO.AutomaticallySavePathAndJavaHome != checkBoxAutomaticallySavePathAndJavaHome.Checked)
            {
                DialogResult dialogResult = MessageBox.Show("There are unsaved changes. Save it?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    if (!CheckDefaultIsPresent())
                    {
                        MessageBox.Show("Default JDK is not set! Please, set default JDK in main window.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        props.Get().JavaPropertiesDTO.ChangeJdkBasedOnDefaultJdk = checkBoxChangeJdkBasedOnDefaultJdk.Checked;
                        props.Save();
                        Close();
                    }
                }
                else
                {
                    Close();
                }
            }
            else
            {
                Close();
            }
        }

        private void ButtonRestoreSystemPath_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure? Default JDK can be changed.", "Restore PATH", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                string defaultPath = "";
                string oldDefaultPath = "";

                string savedPath = props.Get().SavedPath;

                foreach (JdkPropertiesDTO jdkPropertiesDTODefaultPath in props.Get().JavaPropertiesDTO.JdkPropertiesDTOs)
                {
                    if (jdkPropertiesDTODefaultPath.IsDefault)
                    {
                        defaultPath = jdkPropertiesDTODefaultPath.Path;
                    }

                    if (savedPath.Contains(jdkPropertiesDTODefaultPath.Path))
                    {
                        oldDefaultPath = jdkPropertiesDTODefaultPath.Path;
                    }
                }

                if (!defaultPath.Equals(oldDefaultPath))
                {
                    formMain.ChangeDefaultJdk(oldDefaultPath);
                }

                IProgress<int> progressBarAnimationSpeed = new Progress<int>(value => { toolStripProgressBarSettings.MarqueeAnimationSpeed = value; });
                IProgress<int> progressBarValue = new Progress<int>(value => { toolStripProgressBarSettings.Value = value; });
                IProgress<string> progressStatusText = new Progress<string>(value => { toolStripStatusLabelSettings.Text = value; });

                IProgress<bool> progressBtnOkEnabled = new Progress<bool>(value => { buttonOK.Enabled = value; });
                IProgress<bool> progressBtnCancelEnabled = new Progress<bool>(value => { buttonCancel.Enabled = value; });
                IProgress<bool> progressBtnGetSavedPathEnabled = new Progress<bool>(value => { buttonGetSavedPath.Enabled = value; });
                IProgress<bool> progressBtnGetSystemPathEnabled = new Progress<bool>(value => { buttonGetSystemPath.Enabled = value; });
                IProgress<bool> progressBtnSaveSystemPathEnabled = new Progress<bool>(value => { buttonSaveSystemPath.Enabled = value; });
                IProgress<bool> progressChkBoxChangeJdkBasedOnDefaultJdkEnabled = new Progress<bool>(value => { checkBoxChangeJdkBasedOnDefaultJdk.Enabled = value; });
                IProgress<bool> progressBtnRestoreSystemPathEnabled = new Progress<bool>(value => { buttonRestoreSystemPath.Enabled = value; });
                IProgress<bool> progressBtnRestoreRestoreJavaHomeEnabled = new Progress<bool>(value => { buttonRestoreJavaHome.Enabled = value; });
                IProgress<bool> progressBtnSaveSystemJavaHomeEnabled = new Progress<bool>(value => { buttonSaveSystemJavaHome.Enabled = value; });
                IProgress<bool> progressBtnGetSavedJavaHomeEnabled = new Progress<bool>(value => { buttonGetSavedJavaHome.Enabled = value; });
                IProgress<bool> progressBtnGetSystemJavaHomeEnabled = new Progress<bool>(value => { buttonGetSystemJavaHome.Enabled = value; });
                IProgress<bool> progressChkBoxAutomaticallySavePathAndJavaHomeEnabled = new Progress<bool>(value => { checkBoxAutomaticallySavePathAndJavaHome.Enabled = value; });

                toolStripStatusLabelSettings.Text = "Please, wait...";
                toolStripProgressBarSettings.MarqueeAnimationSpeed = 100;

                DisableAll();
                Task.Run(() => Environment.SetEnvironmentVariable("PATH", props.Get().SavedPath, EnvironmentVariableTarget.Machine)).ContinueWith(t => {
                    progressBarAnimationSpeed?.Report(0);
                    progressBarValue?.Report(0);
                    progressStatusText?.Report("Ready");
                        
                    progressBtnOkEnabled?.Report(true);
                    progressBtnCancelEnabled?.Report(true);
                    progressBtnGetSavedPathEnabled?.Report(true);
                    progressBtnGetSystemPathEnabled?.Report(true);
                    progressBtnSaveSystemPathEnabled?.Report(true);
                    progressChkBoxChangeJdkBasedOnDefaultJdkEnabled?.Report(true);
                    progressBtnRestoreSystemPathEnabled?.Report(true);
                    progressBtnRestoreRestoreJavaHomeEnabled?.Report(true);
                    progressBtnSaveSystemJavaHomeEnabled?.Report(true);
                    progressBtnGetSavedJavaHomeEnabled?.Report(true);
                    progressBtnGetSystemJavaHomeEnabled?.Report(true);
                    progressChkBoxAutomaticallySavePathAndJavaHomeEnabled?.Report(true);
                });
            }
        }

        private void ButtonRestoreJavaHome_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure? JAVA_HOME of JDK and bin JDK folder can be different.", "Restore JAVA_HOME", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                IProgress<int> progressBarAnimationSpeed = new Progress<int>(value => { toolStripProgressBarSettings.MarqueeAnimationSpeed = value; });
                IProgress<int> progressBarValue = new Progress<int>(value => { toolStripProgressBarSettings.Value = value; });
                IProgress<string> progressStatusText = new Progress<string>(value => { toolStripStatusLabelSettings.Text = value; });

                IProgress<bool> progressBtnOkEnabled = new Progress<bool>(value => { buttonOK.Enabled = value; });
                IProgress<bool> progressBtnCancelEnabled = new Progress<bool>(value => { buttonCancel.Enabled = value; });
                IProgress<bool> progressBtnGetSavedPathEnabled = new Progress<bool>(value => { buttonGetSavedPath.Enabled = value; });
                IProgress<bool> progressBtnGetSystemPathEnabled = new Progress<bool>(value => { buttonGetSystemPath.Enabled = value; });
                IProgress<bool> progressBtnSaveSystemPathEnabled = new Progress<bool>(value => { buttonSaveSystemPath.Enabled = value; });
                IProgress<bool> progressChkBoxChangeJdkBasedOnDefaultJdkEnabled = new Progress<bool>(value => { checkBoxChangeJdkBasedOnDefaultJdk.Enabled = value; });
                IProgress<bool> progressBtnRestoreSystemPathEnabled = new Progress<bool>(value => { buttonRestoreSystemPath.Enabled = value; });
                IProgress<bool> progressBtnRestoreRestoreJavaHomeEnabled = new Progress<bool>(value => { buttonRestoreJavaHome.Enabled = value; });
                IProgress<bool> progressBtnSaveSystemJavaHomeEnabled = new Progress<bool>(value => { buttonSaveSystemJavaHome.Enabled = value; });
                IProgress<bool> progressBtnGetSavedJavaHomeEnabled = new Progress<bool>(value => { buttonGetSavedJavaHome.Enabled = value; });
                IProgress<bool> progressBtnGetSystemJavaHomeEnabled = new Progress<bool>(value => { buttonGetSystemJavaHome.Enabled = value; });
                IProgress<bool> progressChkBoxAutomaticallySavePathAndJavaHomeEnabled = new Progress<bool>(value => { checkBoxAutomaticallySavePathAndJavaHome.Enabled = value; });

                toolStripStatusLabelSettings.Text = "Please, wait...";
                toolStripProgressBarSettings.MarqueeAnimationSpeed = 100;

                DisableAll();
                Task.Run(() => Environment.SetEnvironmentVariable("JAVA_HOME", props.Get().SavedJavaHome, EnvironmentVariableTarget.Machine)).ContinueWith(t => {
                    progressBarAnimationSpeed?.Report(0);
                    progressBarValue?.Report(0);
                    progressStatusText?.Report("Ready");

                    progressBtnOkEnabled?.Report(true);
                    progressBtnCancelEnabled?.Report(true);
                    progressBtnGetSavedPathEnabled?.Report(true);
                    progressBtnGetSystemPathEnabled?.Report(true);
                    progressBtnSaveSystemPathEnabled?.Report(true);
                    progressChkBoxChangeJdkBasedOnDefaultJdkEnabled?.Report(true);
                    progressBtnRestoreSystemPathEnabled?.Report(true);
                    progressBtnRestoreRestoreJavaHomeEnabled?.Report(true);
                    progressBtnSaveSystemJavaHomeEnabled?.Report(true);
                    progressBtnGetSavedJavaHomeEnabled?.Report(true);
                    progressBtnGetSystemJavaHomeEnabled?.Report(true);
                    progressChkBoxAutomaticallySavePathAndJavaHomeEnabled?.Report(true);
                });
            }
        }

        private void ButtonRestoreRegistryJarfileCommand_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure? jarfile/shell/open/command Will be changed", "Restore jarfile/shell/open/command", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                string defaultJdkPath = props.Get().SavedJavaHome;
                if (defaultJdkPath.Length != 0)
                {
                    MessageBox.Show("Saved JAVA_HOME is not found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                IProgress<int> progressBarAnimationSpeed = new Progress<int>(value => { toolStripProgressBarSettings.MarqueeAnimationSpeed = value; });
                IProgress<int> progressBarValue = new Progress<int>(value => { toolStripProgressBarSettings.Value = value; });
                IProgress<string> progressStatusText = new Progress<string>(value => { toolStripStatusLabelSettings.Text = value; });

                IProgress<bool> progressBtnOkEnabled = new Progress<bool>(value => { buttonOK.Enabled = value; });
                IProgress<bool> progressBtnCancelEnabled = new Progress<bool>(value => { buttonCancel.Enabled = value; });
                IProgress<bool> progressBtnGetSavedPathEnabled = new Progress<bool>(value => { buttonGetSavedPath.Enabled = value; });
                IProgress<bool> progressBtnGetSystemPathEnabled = new Progress<bool>(value => { buttonGetSystemPath.Enabled = value; });
                IProgress<bool> progressBtnSaveSystemPathEnabled = new Progress<bool>(value => { buttonSaveSystemPath.Enabled = value; });
                IProgress<bool> progressChkBoxChangeJdkBasedOnDefaultJdkEnabled = new Progress<bool>(value => { checkBoxChangeJdkBasedOnDefaultJdk.Enabled = value; });
                IProgress<bool> progressBtnRestoreSystemPathEnabled = new Progress<bool>(value => { buttonRestoreSystemPath.Enabled = value; });
                IProgress<bool> progressBtnRestoreRestoreJavaHomeEnabled = new Progress<bool>(value => { buttonRestoreJavaHome.Enabled = value; });
                IProgress<bool> progressBtnSaveSystemJavaHomeEnabled = new Progress<bool>(value => { buttonSaveSystemJavaHome.Enabled = value; });
                IProgress<bool> progressBtnGetSavedJavaHomeEnabled = new Progress<bool>(value => { buttonGetSavedJavaHome.Enabled = value; });
                IProgress<bool> progressBtnGetSystemJavaHomeEnabled = new Progress<bool>(value => { buttonGetSystemJavaHome.Enabled = value; });
                IProgress<bool> progressChkBoxAutomaticallySavePathAndJavaHomeEnabled = new Progress<bool>(value => { checkBoxAutomaticallySavePathAndJavaHome.Enabled = value; });

                toolStripStatusLabelSettings.Text = "Please, wait...";
                toolStripProgressBarSettings.MarqueeAnimationSpeed = 100;

                DisableAll();
                Task.Run(() => jarRegistry.Change(defaultJdkPath + "\\bin")).ContinueWith(t => {
                    progressBarAnimationSpeed?.Report(0);
                    progressBarValue?.Report(0);
                    progressStatusText?.Report("Ready");

                    progressBtnOkEnabled?.Report(true);
                    progressBtnCancelEnabled?.Report(true);
                    progressBtnGetSavedPathEnabled?.Report(true);
                    progressBtnGetSystemPathEnabled?.Report(true);
                    progressBtnSaveSystemPathEnabled?.Report(true);
                    progressChkBoxChangeJdkBasedOnDefaultJdkEnabled?.Report(true);
                    progressBtnRestoreSystemPathEnabled?.Report(true);
                    progressBtnRestoreRestoreJavaHomeEnabled?.Report(true);
                    progressBtnSaveSystemJavaHomeEnabled?.Report(true);
                    progressBtnGetSavedJavaHomeEnabled?.Report(true);
                    progressBtnGetSystemJavaHomeEnabled?.Report(true);
                    progressChkBoxAutomaticallySavePathAndJavaHomeEnabled?.Report(true);
                });
            }
        }
    }
}
