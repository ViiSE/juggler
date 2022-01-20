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
    public partial class FormJdkPathPatterns : Form
    {
        private readonly IProperties<JugglerPropertiesDTO> props;

        public FormJdkPathPatterns(IProperties<JugglerPropertiesDTO> props)
        {
            InitializeComponent();
            this.props = props;

            FillDataGridViewJdkPathPattern();
        }

        private void FillDataGridViewJdkPathPattern()
        {
            foreach (string jdkPathPattern in props.Get().JavaPropertiesDTO.JdkPathPatterns)
            {
                dataGridViewJdkPathPattern.Rows.Add(jdkPathPattern);
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if (dataGridViewJdkPathPattern.Rows.Count != 0)
            {
                List<string> jdkPathPatterns = new List<string>();

                foreach (DataGridViewRow jdkPathPatternRow in dataGridViewJdkPathPattern.Rows)
                {
                    if (jdkPathPatternRow.Cells[0].Value != null)
                    {
                        string pattern = jdkPathPatternRow.Cells[0].Value.ToString();
                        if (pattern.Length > 0)
                        {
                            jdkPathPatterns.Add(jdkPathPatternRow.Cells[0].Value.ToString());
                        }
                    }
                }

                if (jdkPathPatterns.Count > 0)
                {
                    props.Get().JavaPropertiesDTO.JdkPathPatterns = jdkPathPatterns;
                    props.Save();
                }
            }

            Close();
        }
    }
}
