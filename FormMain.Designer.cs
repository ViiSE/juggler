namespace Juggler
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelListOfJdk = new System.Windows.Forms.Label();
            this.buttonAddJdk = new System.Windows.Forms.Button();
            this.buttonSetJdk = new System.Windows.Forms.Button();
            this.buttonRemoveJdk = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listViewJdk = new System.Windows.Forms.ListView();
            this.columnHeaderJdkAlias = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderJdkPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeJdkPathPatternsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelMain = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBarMain = new System.Windows.Forms.ToolStripProgressBar();
            this.notifyIconJuggler = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripNotify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemClose = new System.Windows.Forms.ToolStripMenuItem();
            this.jdkListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            this.contextMenuStripNotify.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Juggler.Properties.Resources.java_logo_icon_128;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // labelListOfJdk
            // 
            resources.ApplyResources(this.labelListOfJdk, "labelListOfJdk");
            this.labelListOfJdk.Name = "labelListOfJdk";
            // 
            // buttonAddJdk
            // 
            resources.ApplyResources(this.buttonAddJdk, "buttonAddJdk");
            this.buttonAddJdk.Name = "buttonAddJdk";
            this.buttonAddJdk.UseVisualStyleBackColor = true;
            this.buttonAddJdk.Click += new System.EventHandler(this.ButtonAddJdk_Click);
            // 
            // buttonSetJdk
            // 
            resources.ApplyResources(this.buttonSetJdk, "buttonSetJdk");
            this.buttonSetJdk.Name = "buttonSetJdk";
            this.buttonSetJdk.UseVisualStyleBackColor = true;
            this.buttonSetJdk.Click += new System.EventHandler(this.ButtonSetJdk_Click);
            // 
            // buttonRemoveJdk
            // 
            resources.ApplyResources(this.buttonRemoveJdk, "buttonRemoveJdk");
            this.buttonRemoveJdk.Name = "buttonRemoveJdk";
            this.buttonRemoveJdk.UseVisualStyleBackColor = true;
            this.buttonRemoveJdk.Click += new System.EventHandler(this.ButtonRemoveJdk_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listViewJdk);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.buttonRemoveJdk);
            this.groupBox1.Controls.Add(this.labelListOfJdk);
            this.groupBox1.Controls.Add(this.buttonAddJdk);
            this.groupBox1.Controls.Add(this.buttonSetJdk);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // listViewJdk
            // 
            resources.ApplyResources(this.listViewJdk, "listViewJdk");
            this.listViewJdk.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderJdkAlias,
            this.columnHeaderJdkPath});
            this.listViewJdk.FullRowSelect = true;
            this.listViewJdk.GridLines = true;
            this.listViewJdk.HideSelection = false;
            this.listViewJdk.MultiSelect = false;
            this.listViewJdk.Name = "listViewJdk";
            this.listViewJdk.UseCompatibleStateImageBehavior = false;
            this.listViewJdk.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderJdkAlias
            // 
            resources.ApplyResources(this.columnHeaderJdkAlias, "columnHeaderJdkAlias");
            // 
            // columnHeaderJdkPath
            // 
            resources.ApplyResources(this.columnHeaderJdkPath, "columnHeaderJdkPath");
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolStripMenuItemHelp});
            resources.ApplyResources(this.menuStripMain, "menuStripMain");
            this.menuStripMain.Name = "menuStripMain";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            resources.ApplyResources(this.closeToolStripMenuItem, "closeToolStripMenuItem");
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeJdkPathPatternsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            resources.ApplyResources(this.editToolStripMenuItem, "editToolStripMenuItem");
            // 
            // changeJdkPathPatternsToolStripMenuItem
            // 
            this.changeJdkPathPatternsToolStripMenuItem.Name = "changeJdkPathPatternsToolStripMenuItem";
            resources.ApplyResources(this.changeJdkPathPatternsToolStripMenuItem, "changeJdkPathPatternsToolStripMenuItem");
            this.changeJdkPathPatternsToolStripMenuItem.Click += new System.EventHandler(this.ChangeJdkPathPatternsToolStripMenuItem_Click);
            // 
            // toolStripMenuItemHelp
            // 
            this.toolStripMenuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.toolStripMenuItemHelp.Name = "toolStripMenuItemHelp";
            resources.ApplyResources(this.toolStripMenuItemHelp, "toolStripMenuItemHelp");
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // statusStripMain
            // 
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelMain,
            this.toolStripProgressBarMain});
            resources.ApplyResources(this.statusStripMain, "statusStripMain");
            this.statusStripMain.Name = "statusStripMain";
            // 
            // toolStripStatusLabelMain
            // 
            this.toolStripStatusLabelMain.Name = "toolStripStatusLabelMain";
            resources.ApplyResources(this.toolStripStatusLabelMain, "toolStripStatusLabelMain");
            // 
            // toolStripProgressBarMain
            // 
            this.toolStripProgressBarMain.MarqueeAnimationSpeed = 0;
            this.toolStripProgressBarMain.Name = "toolStripProgressBarMain";
            resources.ApplyResources(this.toolStripProgressBarMain, "toolStripProgressBarMain");
            this.toolStripProgressBarMain.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            // 
            // notifyIconJuggler
            // 
            this.notifyIconJuggler.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIconJuggler.ContextMenuStrip = this.contextMenuStripNotify;
            resources.ApplyResources(this.notifyIconJuggler, "notifyIconJuggler");
            this.notifyIconJuggler.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIconJuggler_MouseDoubleClick);
            // 
            // contextMenuStripNotify
            // 
            this.contextMenuStripNotify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemOpen,
            this.toolStripMenuItemClose,
            this.jdkListToolStripMenuItem});
            this.contextMenuStripNotify.Name = "contextMenuStripNotify";
            resources.ApplyResources(this.contextMenuStripNotify, "contextMenuStripNotify");
            // 
            // toolStripMenuItemOpen
            // 
            this.toolStripMenuItemOpen.Name = "toolStripMenuItemOpen";
            resources.ApplyResources(this.toolStripMenuItemOpen, "toolStripMenuItemOpen");
            this.toolStripMenuItemOpen.Click += new System.EventHandler(this.ToolStripMenuItemOpen_Click);
            // 
            // toolStripMenuItemClose
            // 
            this.toolStripMenuItemClose.Name = "toolStripMenuItemClose";
            resources.ApplyResources(this.toolStripMenuItemClose, "toolStripMenuItemClose");
            this.toolStripMenuItemClose.Click += new System.EventHandler(this.ToolStripMenuItemClose_Click);
            // 
            // jdkListToolStripMenuItem
            // 
            this.jdkListToolStripMenuItem.Name = "jdkListToolStripMenuItem";
            resources.ApplyResources(this.jdkListToolStripMenuItem, "jdkListToolStripMenuItem");
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStripMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStripMain;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.contextMenuStripNotify.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelListOfJdk;
        private System.Windows.Forms.Button buttonAddJdk;
        private System.Windows.Forms.Button buttonSetJdk;
        private System.Windows.Forms.Button buttonRemoveJdk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeJdkPathPatternsToolStripMenuItem;
        private System.Windows.Forms.ListView listViewJdk;
        private System.Windows.Forms.ColumnHeader columnHeaderJdkAlias;
        private System.Windows.Forms.ColumnHeader columnHeaderJdkPath;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBarMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMain;
        private System.Windows.Forms.NotifyIcon notifyIconJuggler;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripNotify;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpen;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemClose;
        private System.Windows.Forms.ToolStripMenuItem jdkListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

