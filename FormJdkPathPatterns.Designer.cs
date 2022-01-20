namespace Juggler
{
    partial class FormJdkPathPatterns
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJdkPathPatterns));
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.dataGridViewJdkPathPattern = new System.Windows.Forms.DataGridView();
            this.ColumnJdkPathPattern = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJdkPathPattern)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOK.Location = new System.Drawing.Point(286, 190);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(106, 31);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(398, 190);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(106, 31);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // dataGridViewJdkPathPattern
            // 
            this.dataGridViewJdkPathPattern.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewJdkPathPattern.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewJdkPathPattern.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnJdkPathPattern});
            this.dataGridViewJdkPathPattern.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewJdkPathPattern.Name = "dataGridViewJdkPathPattern";
            this.dataGridViewJdkPathPattern.Size = new System.Drawing.Size(492, 172);
            this.dataGridViewJdkPathPattern.TabIndex = 4;
            // 
            // ColumnJdkPathPattern
            // 
            this.ColumnJdkPathPattern.HeaderText = "Path Pattern";
            this.ColumnJdkPathPattern.Name = "ColumnJdkPathPattern";
            this.ColumnJdkPathPattern.Width = 448;
            // 
            // FormJdkPathPatterns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 234);
            this.Controls.Add(this.dataGridViewJdkPathPattern);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FormJdkPathPatterns";
            this.Text = "JDK Path Patterns";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJdkPathPattern)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.DataGridView dataGridViewJdkPathPattern;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnJdkPathPattern;
    }
}