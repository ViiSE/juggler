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
    public partial class FormMain : Form
    {
        private bool needExit = false;

        private readonly IPath jdkPath;
        private readonly IRegistry<string> jarRegistry;
        private readonly IProperties<JugglerPropertiesDTO> props;

        public FormMain(IPath jdkPath, IRegistry<string> jarRegistry, IProperties<JugglerPropertiesDTO> props)
        {
            InitializeComponent();
            this.jdkPath = jdkPath;
            this.jarRegistry = jarRegistry;
            this.props = props;

            List<JdkPropertiesDTO> jdkPropertiesDTOs = props.Get().JavaPropertiesDTO.JdkPropertiesDTOs;
            for (int i = 0; i < jdkPropertiesDTOs.Count; i++)
            {
                JdkPropertiesDTO jdkDTO = jdkPropertiesDTOs[i];
                AddNewJdk(jdkDTO, false);
            }
        }

        public void AddNewJdk(JdkPropertiesDTO jdkPropertiesDTO, bool needSave)
        {
            ListViewItem aliasJdkItem = new ListViewItem()
            {
                Text = jdkPropertiesDTO.Alias
            };

            ListViewItem.ListViewSubItem pathJdkItem = new ListViewItem.ListViewSubItem
            {
                Text = jdkPropertiesDTO.Path
            };


            ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem
            {
                Text = jdkPropertiesDTO.Alias,
                Name = jdkPropertiesDTO.Alias
            };
            toolStripMenuItem.Click += new EventHandler(ToolStripJdkListItem_Click);

            ListViewItem jdkItem = listViewJdk.Items.Add(aliasJdkItem);
            if (jdkPropertiesDTO.IsDefault)
            {
                jdkItem.BackColor = Color.LightGreen;
                toolStripMenuItem.Checked = true;
            }
            jdkItem.SubItems.Add(pathJdkItem);
            jdkListToolStripMenuItem.DropDownItems.Add(toolStripMenuItem);

            if (needSave)
            {
                SaveJdkList();
            }
        }

        private void SaveJdkList()
        {
            List<JdkPropertiesDTO> jdkPropertiesDTOs = new List<JdkPropertiesDTO>();
            foreach (ListViewItem jdkItem in listViewJdk.Items)
            {
                jdkPropertiesDTOs.Add(
                    new JdkPropertiesDTO()
                    {
                        Alias = jdkItem.SubItems[0].Text,
                        Path = jdkItem.SubItems[1].Text,
                        IsDefault = jdkItem.BackColor == Color.LightGreen
                    }
                    );
            }
            props.Get().JavaPropertiesDTO.JdkPropertiesDTOs = jdkPropertiesDTOs;
            props.Save();
        }

        private void SaveDefaultJdk(string alias)
        {
            List<JdkPropertiesDTO> jdkPropertiesDTOs = new List<JdkPropertiesDTO>();
            foreach (JdkPropertiesDTO jdkPropertiesDTO in props.Get().JavaPropertiesDTO.JdkPropertiesDTOs)
            {
                JdkPropertiesDTO newjdkPropertiesDTO = new JdkPropertiesDTO();
                if (jdkPropertiesDTO.Alias == alias)
                {
                    newjdkPropertiesDTO.IsDefault = true;
                }
                else
                {
                    if (jdkPropertiesDTO.IsDefault)
                    {
                        newjdkPropertiesDTO.IsDefault = false;
                    }
                    else
                    {
                        newjdkPropertiesDTO.IsDefault = jdkPropertiesDTO.IsDefault;
                    }
                }

                newjdkPropertiesDTO.Alias = jdkPropertiesDTO.Alias;
                newjdkPropertiesDTO.Path = jdkPropertiesDTO.Path;

                jdkPropertiesDTOs.Add(newjdkPropertiesDTO);
            }

            props.Get().JavaPropertiesDTO.JdkPropertiesDTOs = jdkPropertiesDTOs;
            props.Save();
        }

        private void DisableAll()
        {
            buttonAddJdk.Enabled = false;
            buttonSetJdk.Enabled = false;
            buttonRemoveJdk.Enabled = false;
            listViewJdk.Enabled = false;
            menuStripMain.Enabled = false;
        }

        public void ChangeDefaultJdk(string oldDefaultPath)
        {
            foreach (ListViewItem jdkListItem in listViewJdk.Items)
            {
                if (jdkListItem.SubItems[1].Text.Equals(oldDefaultPath))
                {
                    jdkListItem.BackColor = Color.LightGreen;
                }
                else
                {
                    jdkListItem.BackColor = SystemColors.Window;
                }
            }
            SaveJdkList();
        }

        private void ButtonAddJdk_Click(object sender, EventArgs e)
        {
            FormAddJdk formAddJdk = new FormAddJdk(this, props);
            formAddJdk.ShowDialog();
        }

        private void ButtonRemoveJdk_Click(object sender, EventArgs e)
        {
            if (listViewJdk.Items.Count != 0 && listViewJdk.SelectedItems.Count != 0)
            {
                int deletedIndex = -1;
                for (int i = 0; i < jdkListToolStripMenuItem.DropDownItems.Count; i++)
                {
                    ToolStripItem item = jdkListToolStripMenuItem.DropDownItems[i];
                    if (item.Name.Equals(listViewJdk.SelectedItems[0].SubItems[0].Text))
                    {
                        deletedIndex = i;
                        break;
                    }
                }
                if (deletedIndex != -1)
                {
                    jdkListToolStripMenuItem.DropDownItems.RemoveAt(deletedIndex);
                }
                listViewJdk.Items.Remove(listViewJdk.SelectedItems[0]);
                SaveJdkList();
            }
        }

        private void ButtonSetJdk_Click(object sender, EventArgs e)
        {
            if (listViewJdk.SelectedItems.Count != 0)
            {
                string oldDefaultPath = "";

                foreach (ListViewItem jdkListItem in listViewJdk.Items)
                {
                    if (jdkListItem.BackColor == Color.LightGreen)
                    {
                        oldDefaultPath = jdkListItem.SubItems[1].Text;
                    }

                    jdkListItem.BackColor = SystemColors.Window;
                }

                listViewJdk.SelectedItems[0].BackColor = Color.LightGreen;
                string path = listViewJdk.SelectedItems[0].SubItems[1].Text;
                toolStripStatusLabelMain.Text = "Please, wait...";
                toolStripProgressBarMain.MarqueeAnimationSpeed = 100;
                
                IProgress<int> progressBarAnimationSpeed = new Progress<int>(value => { toolStripProgressBarMain.MarqueeAnimationSpeed = value; });
                IProgress<int> progressBarValue = new Progress<int>(value => { toolStripProgressBarMain.Value = value; });
                IProgress<string> progressStatusText = new Progress<string>(value => { toolStripStatusLabelMain.Text = value; });
                
                IProgress<bool> progressBtnAddJdkEnabled = new Progress<bool>(value => { buttonAddJdk.Enabled = value; });
                IProgress<bool> progressBtnSetJdkEnabled = new Progress<bool>(value => { buttonSetJdk.Enabled = value; });
                IProgress<bool> progressBtnRemoveJdkEnabled = new Progress<bool>(value => { buttonRemoveJdk.Enabled = value; });
                IProgress<bool> progressListViewJdkEnabled = new Progress<bool>(value => { listViewJdk.Enabled = value; });
                IProgress<bool> progressMenuStripMainEnabled = new Progress<bool>(value => { menuStripMain.Enabled = value; });

                DisableAll();
                Task.Run(() =>
                {
                    if (props.Get().JavaPropertiesDTO.ChangeJdkBasedOnDefaultJdk)
                    {
                        if (oldDefaultPath.Length != 0)
                        {
                            List<string> jdkPathPatterns = new List<string>();

                            foreach (JdkPropertiesDTO jdkPropertiesDTO in props.Get().JavaPropertiesDTO.JdkPropertiesDTOs)
                            {
                                if (jdkPropertiesDTO.Path.Equals(oldDefaultPath) && jdkPropertiesDTO.IsDefault)
                                {
                                    jdkPathPatterns.Add(jdkPropertiesDTO.Path);
                                    break;
                                }
                            }

                            if (jdkPathPatterns.Count == 0)
                            {
                                jdkPathPatterns = props.Get().JavaPropertiesDTO.JdkPathPatterns;
                            }

                            string jdkPathExec = jdkPath.Change(path, jdkPathPatterns);
                            if (jdkPathExec.Length != 0)
                            {
                                jarRegistry.Change(jdkPathExec);
                            }
                        }
                        else
                        {
                            string jdkPathExec = jdkPath.Change(path, props.Get().JavaPropertiesDTO.JdkPathPatterns);
                            if (jdkPathExec.Length != 0)
                            {
                                jarRegistry.Change(jdkPathExec);
                            }
                        }
                    }
                    else
                    {
                        string jdkPathExec = jdkPath.Change(path, props.Get().JavaPropertiesDTO.JdkPathPatterns);
                        if (jdkPathExec.Length != 0)
                        {
                            jarRegistry.Change(jdkPathExec);
                        }
                    }

                    if (props.Get().JavaPropertiesDTO.AutomaticallySavePathAndJavaHome)
                    {
                        props.Get().SavedPath = Environment.GetEnvironmentVariable("Path", EnvironmentVariableTarget.Machine);
                        props.Get().SavedJavaHome = Environment.GetEnvironmentVariable("JAVA_HOME", EnvironmentVariableTarget.Machine);
                    }
                }).ContinueWith(t =>
                {
                    progressBarAnimationSpeed?.Report(0);
                    progressBarValue?.Report(0);
                    progressStatusText?.Report("Ready");
                    
                    progressBtnAddJdkEnabled?.Report(true);
                    progressBtnSetJdkEnabled?.Report(true);
                    progressBtnRemoveJdkEnabled?.Report(true);
                    progressListViewJdkEnabled?.Report(true);
                    progressMenuStripMainEnabled?.Report(true);
                });
                SaveJdkList();
                string defaultJdkAlias = props.Get().JavaPropertiesDTO.JdkPropertiesDTOs.Where(jdkProps => jdkProps.IsDefault).Select(s => s.Alias).FirstOrDefault();
                foreach (ToolStripMenuItem item in jdkListToolStripMenuItem.DropDownItems)
                {
                    if (defaultJdkAlias.Equals(item.Name))
                    {
                        item.Checked = true;
                    }
                    else
                    {
                        item.Checked = false;
                    }
                }
            }
        }

        private void ToolStripJdkListItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem senderItem = sender as ToolStripMenuItem;
            if (!senderItem.Checked) {
                string path = props.Get().JavaPropertiesDTO.JdkPropertiesDTOs.Where(jdkProp => jdkProp.Alias.Equals(senderItem.Name)).Select(s => s.Path).FirstOrDefault();

                if (path != null || path.Length != 0)
                {
                    notifyIconJuggler.BalloonTipIcon = ToolTipIcon.Info;
                    notifyIconJuggler.BalloonTipTitle = "Juggler";
                    notifyIconJuggler.BalloonTipText = "Change JDK to '" + senderItem.Name + "', please, wait...";
                    notifyIconJuggler.ShowBalloonTip(5000);
                    string jdkPathExec = jdkPath.Change(path, props.Get().JavaPropertiesDTO.JdkPathPatterns);
                    if (jdkPathExec.Length != 0)
                    {
                        jarRegistry.Change(jdkPathExec);
                    }
                    SaveDefaultJdk(senderItem.Name);
                    foreach (ToolStripMenuItem item in jdkListToolStripMenuItem.DropDownItems)
                    {
                        if (senderItem.Name.Equals(item.Name))
                        {
                            item.Checked = true;
                        }
                        else
                        {
                            item.Checked = false;
                        }
                    }
                    foreach (ListViewItem jdkListItem in listViewJdk.Items)
                    {
                        if (jdkListItem.Text == senderItem.Name)
                        {
                            jdkListItem.BackColor = Color.LightGreen;
                        }
                        else
                        {
                            jdkListItem.BackColor = SystemColors.Window;
                        }
                    }
                    notifyIconJuggler.BalloonTipText = "Done! JDK is changed to '" + senderItem.Name + "'.";
                    notifyIconJuggler.ShowBalloonTip(1000);
                }
            }
        }

        private void ChangeJdkPathPatternsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormJdkPathPatterns formJdkPathPatterns = new FormJdkPathPatterns(props);
            formJdkPathPatterns.ShowDialog();
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            needExit = true;
            Application.Exit();
        }

        private void ToolStripMenuItemOpen_Click(object sender, EventArgs e)
        {
            Show();
            notifyIconJuggler.Visible = false;
        }

        private void ToolStripMenuItemClose_Click(object sender, EventArgs e)
        {
            needExit = true;
            Application.Exit();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            if (!needExit)
            {
                e.Cancel = true;
                notifyIconJuggler.Visible = true;
            }
            Hide();
        }

        private void NotifyIconJuggler_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            notifyIconJuggler.Visible = false;
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSettings formSettings = new FormSettings(props, jarRegistry, this);
            formSettings.ShowDialog();
        }

        private void ToolStripMenuItemGetSystemPath_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Environment.GetEnvironmentVariable("Path", EnvironmentVariableTarget.Machine));
            notifyIconJuggler.BalloonTipIcon = ToolTipIcon.Info;
            notifyIconJuggler.BalloonTipTitle = "Copied!";
            notifyIconJuggler.BalloonTipText = "System PATH has been copied to clipboard!";
            notifyIconJuggler.ShowBalloonTip(1000);
        }

        private void ToolStripMenuItemGetSavedPath_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(props.Get().SavedPath);
            notifyIconJuggler.BalloonTipIcon = ToolTipIcon.Info;
            notifyIconJuggler.BalloonTipTitle = "Copied!";
            notifyIconJuggler.BalloonTipText = "Saved PATH has been copied to clipboard!";
            notifyIconJuggler.ShowBalloonTip(1000);
        }

        private void ToolStripMenuItemGetSystemJavaHome_Click(object sender, EventArgs e)
        {
            if (Environment.GetEnvironmentVariable("JAVA_HOME", EnvironmentVariableTarget.Machine) != null)
            {
                Clipboard.SetText(Environment.GetEnvironmentVariable("JAVA_HOME", EnvironmentVariableTarget.Machine));
                notifyIconJuggler.BalloonTipTitle = "Copied!";
                notifyIconJuggler.BalloonTipText = "System JAVA_HOME has been copied to clipboard!";
                notifyIconJuggler.ShowBalloonTip(1000);
            }
            else
            {
                notifyIconJuggler.BalloonTipIcon = ToolTipIcon.Warning;
                notifyIconJuggler.BalloonTipTitle = "Failed";
                notifyIconJuggler.BalloonTipText = "There is not system JAVA_HOME!";
                notifyIconJuggler.ShowBalloonTip(1000);
            }
        }

        private void ToolStripMenuItemGetSavedJavaHome_Click(object sender, EventArgs e)
        {
            if (props.Get().SavedJavaHome != null)
            {
                Clipboard.SetText(props.Get().SavedJavaHome);
                notifyIconJuggler.BalloonTipIcon = ToolTipIcon.Info;
                notifyIconJuggler.BalloonTipTitle = "Copied!";
                notifyIconJuggler.BalloonTipText = "Saved JAVA_HOME has been copied to clipboard!";
                notifyIconJuggler.ShowBalloonTip(1000);
            }
            else
            {
                notifyIconJuggler.BalloonTipIcon = ToolTipIcon.Warning;
                notifyIconJuggler.BalloonTipTitle = "Failed";
                notifyIconJuggler.BalloonTipText = "There is not saved JAVA_HOME!";
                notifyIconJuggler.ShowBalloonTip(1000);
            }
            
        }

        private void ToolStripMenuItemSaveSystemPath_Click(object sender, EventArgs e)
        {
            props.Get().SavedPath = Environment.GetEnvironmentVariable("Path", EnvironmentVariableTarget.Machine);
            props.Save();
            notifyIconJuggler.BalloonTipIcon = ToolTipIcon.Info;
            notifyIconJuggler.BalloonTipTitle = "Saved!";
            notifyIconJuggler.BalloonTipText = "System PATH has been saved!";
            notifyIconJuggler.ShowBalloonTip(1000);
        }

        private void ToolStripMenuItemSaveSystemJavaHome_Click(object sender, EventArgs e)
        {
            props.Get().SavedJavaHome = Environment.GetEnvironmentVariable("JAVA_HOME", EnvironmentVariableTarget.Machine);
            props.Save();
            notifyIconJuggler.BalloonTipIcon = ToolTipIcon.Info;
            notifyIconJuggler.BalloonTipTitle = "Saved!";
            notifyIconJuggler.BalloonTipText = "System JAVA_HOME has been saved!";
            notifyIconJuggler.ShowBalloonTip(1000);
        }

        private void ToolStripMenuItemRestoreSystemPath_Click(object sender, EventArgs e)
        {
            notifyIconJuggler.BalloonTipIcon = ToolTipIcon.Info;
            notifyIconJuggler.BalloonTipTitle = "Restore PATH";
            notifyIconJuggler.BalloonTipText = "Restore PATH, please, wait. Default JDK can be changed!";
            notifyIconJuggler.ShowBalloonTip(5000);

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
                ChangeDefaultJdk(oldDefaultPath);
            }

            Environment.SetEnvironmentVariable("PATH", props.Get().SavedPath, EnvironmentVariableTarget.Machine);
            notifyIconJuggler.BalloonTipIcon = ToolTipIcon.Info;
            notifyIconJuggler.BalloonTipTitle = "Success!";
            notifyIconJuggler.BalloonTipText = "PATH has been restored!";
            notifyIconJuggler.ShowBalloonTip(1000);
        }

        private void ToolStripMenuItemRestoreJavaHomePath_Click(object sender, EventArgs e)
        {
            notifyIconJuggler.BalloonTipIcon = ToolTipIcon.Info;
            notifyIconJuggler.BalloonTipTitle = "Restore JAVA_HOME";
            notifyIconJuggler.BalloonTipText = "Restore JAVA_HOME, please, wait...";
            notifyIconJuggler.ShowBalloonTip(5000);

            Environment.SetEnvironmentVariable("JAVA_HOME", props.Get().SavedJavaHome, EnvironmentVariableTarget.Machine);
            notifyIconJuggler.BalloonTipIcon = ToolTipIcon.Info;
            notifyIconJuggler.BalloonTipTitle = "Success!";
            notifyIconJuggler.BalloonTipText = "JAVA_HOME has been restored!";
            notifyIconJuggler.ShowBalloonTip(1000);
        }

        private void ToolStripMenuItemRestoreRegistryJarfileShellCommand_Click(object sender, EventArgs e)
        {
            notifyIconJuggler.BalloonTipIcon = ToolTipIcon.Info;
            notifyIconJuggler.BalloonTipTitle = "Restore Registry";
            notifyIconJuggler.BalloonTipText = "Restore Registry jarfile open command, please, wait...";
            notifyIconJuggler.ShowBalloonTip(5000);

            string defaultJdkPath = props.Get().SavedJavaHome;
            if (defaultJdkPath.Length != 0)
            {
                jarRegistry.Change(defaultJdkPath + "\\bin");
            }

            notifyIconJuggler.BalloonTipIcon = ToolTipIcon.Info;
            notifyIconJuggler.BalloonTipTitle = "Success!";
            notifyIconJuggler.BalloonTipText = "Registry jarfile open command has been restored!";
            notifyIconJuggler.ShowBalloonTip(1000);
        }
    }
}
