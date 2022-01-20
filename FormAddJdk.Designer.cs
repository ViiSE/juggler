namespace Juggler
{
    partial class FormAddJdk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddJdk));
            this.buttonSelectJdk = new System.Windows.Forms.Button();
            this.textBoxJdkAlias = new System.Windows.Forms.TextBox();
            this.buttonAddJdkOk = new System.Windows.Forms.Button();
            this.buttonAddJdkCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxJdkPath = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSelectJdk
            // 
            this.buttonSelectJdk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSelectJdk.Location = new System.Drawing.Point(6, 25);
            this.buttonSelectJdk.Name = "buttonSelectJdk";
            this.buttonSelectJdk.Size = new System.Drawing.Size(89, 29);
            this.buttonSelectJdk.TabIndex = 1;
            this.buttonSelectJdk.Text = "Browse...";
            this.buttonSelectJdk.UseVisualStyleBackColor = true;
            this.buttonSelectJdk.Click += new System.EventHandler(this.ButtonSelectJdk_Click);
            // 
            // textBoxJdkAlias
            // 
            this.textBoxJdkAlias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxJdkAlias.Location = new System.Drawing.Point(6, 25);
            this.textBoxJdkAlias.Name = "textBoxJdkAlias";
            this.textBoxJdkAlias.Size = new System.Drawing.Size(347, 26);
            this.textBoxJdkAlias.TabIndex = 3;
            // 
            // buttonAddJdkOk
            // 
            this.buttonAddJdkOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddJdkOk.Location = new System.Drawing.Point(187, 178);
            this.buttonAddJdkOk.Name = "buttonAddJdkOk";
            this.buttonAddJdkOk.Size = new System.Drawing.Size(89, 29);
            this.buttonAddJdkOk.TabIndex = 4;
            this.buttonAddJdkOk.Text = "OK";
            this.buttonAddJdkOk.UseVisualStyleBackColor = true;
            this.buttonAddJdkOk.Click += new System.EventHandler(this.ButtonAddJdkOk_Click);
            // 
            // buttonAddJdkCancel
            // 
            this.buttonAddJdkCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddJdkCancel.Location = new System.Drawing.Point(282, 178);
            this.buttonAddJdkCancel.Name = "buttonAddJdkCancel";
            this.buttonAddJdkCancel.Size = new System.Drawing.Size(89, 29);
            this.buttonAddJdkCancel.TabIndex = 5;
            this.buttonAddJdkCancel.Text = "Cancel";
            this.buttonAddJdkCancel.UseVisualStyleBackColor = true;
            this.buttonAddJdkCancel.Click += new System.EventHandler(this.ButtonAddJdkCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxJdkPath);
            this.groupBox1.Controls.Add(this.buttonSelectJdk);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 77);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "JDK Path";
            // 
            // textBoxJdkPath
            // 
            this.textBoxJdkPath.Location = new System.Drawing.Point(102, 26);
            this.textBoxJdkPath.Name = "textBoxJdkPath";
            this.textBoxJdkPath.Size = new System.Drawing.Size(251, 26);
            this.textBoxJdkPath.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxJdkAlias);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(12, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 73);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alias";
            // 
            // FormAddJdk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 219);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonAddJdkCancel);
            this.Controls.Add(this.buttonAddJdkOk);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormAddJdk";
            this.Text = "Add JDK";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonSelectJdk;
        private System.Windows.Forms.TextBox textBoxJdkAlias;
        private System.Windows.Forms.Button buttonAddJdkOk;
        private System.Windows.Forms.Button buttonAddJdkCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxJdkPath;
    }
}