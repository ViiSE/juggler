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
    public partial class FormAddJdk : Form
    {
        private readonly FormMain formMain;
        private readonly IProperties<JugglerPropertiesDTO> props;

        public FormAddJdk(FormMain formMain, IProperties<JugglerPropertiesDTO> props)
        {
            InitializeComponent();
            this.formMain = formMain;
            this.props = props;
        }

        private void ButtonSelectJdk_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog jdkFolderDialog = new FolderBrowserDialog())
            {
                DialogResult jdkDialogRes = jdkFolderDialog.ShowDialog();

                if (jdkDialogRes == DialogResult.OK && !string.IsNullOrWhiteSpace(jdkFolderDialog.SelectedPath))
                {
                    textBoxJdkPath.Text = jdkFolderDialog.SelectedPath;
                }
            }
        }

        private void ButtonAddJdkOk_Click(object sender, EventArgs e)
        {
            string path = textBoxJdkPath.Text;
            
            if (string.IsNullOrWhiteSpace(path))
            {
                MessageBox.Show("Select or input Path", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string alias = textBoxJdkAlias.Text;
            if (string.IsNullOrWhiteSpace(alias))
            {
                MessageBox.Show("Input Alias", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (new CheckerJdkPropertiesUnique(props.Get().JavaPropertiesDTO.JdkPropertiesDTOs).Check(new JdkPropertiesDTO() { Alias = alias, Path = path }))
            {
                formMain.AddNewJdk(new JdkPropertiesDTO() { Alias = alias, Path = path }, true);
                Close();
            }
            else
            {
                MessageBox.Show("Alias and/or Path already exists in JDK list (Alias and/or Path must be unique!)", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void ButtonAddJdkCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
