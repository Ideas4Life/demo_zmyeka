namespace Zmeya
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorOfFonMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.greenMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.purpleMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.lilacMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.brownMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.turquoiseMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.colorOfBallMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.greenMenuBall = new System.Windows.Forms.ToolStripMenuItem();
            this.darkRedMenuBall = new System.Windows.Forms.ToolStripMenuItem();
            this.blueMenuBall = new System.Windows.Forms.ToolStripMenuItem();
            this.orangeMenuBall = new System.Windows.Forms.ToolStripMenuItem();
            this.brownMenuBall = new System.Windows.Forms.ToolStripMenuItem();
            this.redMenuBall = new System.Windows.Forms.ToolStripMenuItem();
            this.scoreMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::Zmeya.Properties.Resources.fon5;
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 13F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stopToolStripMenuItem,
            this.startToolStripMenuItem,
            this.newGameToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.scoreMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(587, 30);
            this.menuStrip1.TabIndex = 0;
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.stopToolStripMenuItem.Font = new System.Drawing.Font("Arial", 14F);
            this.stopToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(59, 26);
            this.stopToolStripMenuItem.Text = "stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.MenuItemStop_Click);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.startToolStripMenuItem.Font = new System.Drawing.Font("Arial", 14F);
            this.startToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(58, 26);
            this.startToolStripMenuItem.Text = "start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.MenuItemStart_Click);
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Font = new System.Drawing.Font("Arial", 13F);
            this.newGameToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(104, 26);
            this.newGameToolStripMenuItem.Text = "new game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameMenu_Paint);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recordsMenu,
            this.instructionMenu});
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Arial", 13F);
            this.helpToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(56, 26);
            this.helpToolStripMenuItem.Text = "help";
            // 
            // recordsMenu
            // 
            this.recordsMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.recordsMenu.Name = "recordsMenu";
            this.recordsMenu.Size = new System.Drawing.Size(180, 26);
            this.recordsMenu.Text = "Records";
            this.recordsMenu.Click += new System.EventHandler(this.recordsMenu_Click);
            // 
            // instructionMenu
            // 
            this.instructionMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.instructionMenu.Name = "instructionMenu";
            this.instructionMenu.Size = new System.Drawing.Size(180, 26);
            this.instructionMenu.Text = "Instruction";
            this.instructionMenu.Click += new System.EventHandler(this.instructionMenu_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorOfFonMenu,
            this.colorOfBallMenu});
            this.settingsToolStripMenuItem.Font = new System.Drawing.Font("Arial", 13F);
            this.settingsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(84, 26);
            this.settingsToolStripMenuItem.Text = "settings";
            // 
            // colorOfFonMenu
            // 
            this.colorOfFonMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.greenMenu,
            this.purpleMenu,
            this.lilacMenu,
            this.brownMenu,
            this.turquoiseMenu});
            this.colorOfFonMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.colorOfFonMenu.Name = "colorOfFonMenu";
            this.colorOfFonMenu.Size = new System.Drawing.Size(180, 26);
            this.colorOfFonMenu.Text = "Color of fon";
            // 
            // greenMenu
            // 
            this.greenMenu.BackgroundImage = global::Zmeya.Properties.Resources.fon1;
            this.greenMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.greenMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.greenMenu.Name = "greenMenu";
            this.greenMenu.Size = new System.Drawing.Size(180, 26);
            this.greenMenu.Text = "green";
            this.greenMenu.Click += new System.EventHandler(this.greenMenuFon_Click);
            // 
            // purpleMenu
            // 
            this.purpleMenu.BackgroundImage = global::Zmeya.Properties.Resources.fon2;
            this.purpleMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.purpleMenu.Name = "purpleMenu";
            this.purpleMenu.Size = new System.Drawing.Size(180, 26);
            this.purpleMenu.Text = "purple";
            this.purpleMenu.Click += new System.EventHandler(this.purpleMenuFon_Click);
            // 
            // lilacMenu
            // 
            this.lilacMenu.BackgroundImage = global::Zmeya.Properties.Resources.fon3;
            this.lilacMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lilacMenu.Name = "lilacMenu";
            this.lilacMenu.Size = new System.Drawing.Size(180, 26);
            this.lilacMenu.Text = "lilac";
            this.lilacMenu.Click += new System.EventHandler(this.lilacMenuFon_Click);
            // 
            // brownMenu
            // 
            this.brownMenu.BackgroundImage = global::Zmeya.Properties.Resources.fon4;
            this.brownMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.brownMenu.Name = "brownMenu";
            this.brownMenu.Size = new System.Drawing.Size(180, 26);
            this.brownMenu.Text = "brown";
            this.brownMenu.Click += new System.EventHandler(this.brownMenuFon_Click);
            // 
            // turquoiseMenu
            // 
            this.turquoiseMenu.BackgroundImage = global::Zmeya.Properties.Resources.fon5;
            this.turquoiseMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.turquoiseMenu.Name = "turquoiseMenu";
            this.turquoiseMenu.Size = new System.Drawing.Size(180, 26);
            this.turquoiseMenu.Text = "turquoise";
            this.turquoiseMenu.Click += new System.EventHandler(this.turquoiseMenuFon_Click);
            // 
            // colorOfBallMenu
            // 
            this.colorOfBallMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.greenMenuBall,
            this.darkRedMenuBall,
            this.blueMenuBall,
            this.orangeMenuBall,
            this.brownMenuBall,
            this.redMenuBall});
            this.colorOfBallMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.colorOfBallMenu.Name = "colorOfBallMenu";
            this.colorOfBallMenu.Size = new System.Drawing.Size(180, 26);
            this.colorOfBallMenu.Text = "Color of ball";
            // 
            // greenMenuBall
            // 
            this.greenMenuBall.BackgroundImage = global::Zmeya.Properties.Resources.sharikFon2;
            this.greenMenuBall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.greenMenuBall.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.greenMenuBall.Name = "greenMenuBall";
            this.greenMenuBall.Size = new System.Drawing.Size(180, 26);
            this.greenMenuBall.Text = "green";
            this.greenMenuBall.Click += new System.EventHandler(this.greenMenuIBall_Click);
            // 
            // darkRedMenuBall
            // 
            this.darkRedMenuBall.BackgroundImage = global::Zmeya.Properties.Resources.sharikFon3;
            this.darkRedMenuBall.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.darkRedMenuBall.Name = "darkRedMenuBall";
            this.darkRedMenuBall.Size = new System.Drawing.Size(180, 26);
            this.darkRedMenuBall.Text = "darkRed";
            this.darkRedMenuBall.Click += new System.EventHandler(this.darkRedMenuBall_Click);
            // 
            // blueMenuBall
            // 
            this.blueMenuBall.BackgroundImage = global::Zmeya.Properties.Resources.sharikFon4;
            this.blueMenuBall.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.blueMenuBall.Name = "blueMenuBall";
            this.blueMenuBall.Size = new System.Drawing.Size(180, 26);
            this.blueMenuBall.Text = "blue";
            this.blueMenuBall.Click += new System.EventHandler(this.blueMenuBall_Click);
            // 
            // orangeMenuBall
            // 
            this.orangeMenuBall.BackgroundImage = global::Zmeya.Properties.Resources.sharikFon1;
            this.orangeMenuBall.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.orangeMenuBall.Name = "orangeMenuBall";
            this.orangeMenuBall.Size = new System.Drawing.Size(180, 26);
            this.orangeMenuBall.Text = "orange";
            this.orangeMenuBall.Click += new System.EventHandler(this.orangeMenuBall_Click);
            // 
            // brownMenuBall
            // 
            this.brownMenuBall.BackgroundImage = global::Zmeya.Properties.Resources.sharikFon5;
            this.brownMenuBall.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.brownMenuBall.Name = "brownMenuBall";
            this.brownMenuBall.Size = new System.Drawing.Size(180, 26);
            this.brownMenuBall.Text = "brown";
            this.brownMenuBall.Click += new System.EventHandler(this.brownMenuBall_Click);
            // 
            // redMenuBall
            // 
            this.redMenuBall.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("redMenuBall.BackgroundImage")));
            this.redMenuBall.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.redMenuBall.Name = "redMenuBall";
            this.redMenuBall.Size = new System.Drawing.Size(180, 26);
            this.redMenuBall.Text = "red";
            this.redMenuBall.Click += new System.EventHandler(this.redMenuBall_Click);
            // 
            // scoreMenu
            // 
            this.scoreMenu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.scoreMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.scoreMenu.Name = "scoreMenu";
            this.scoreMenu.Size = new System.Drawing.Size(86, 26);
            this.scoreMenu.Text = "score: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 453);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(603, 492);
            this.MinimumSize = new System.Drawing.Size(603, 492);
            this.Name = "Form1";
            this.Text = "Zmeyka";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorOfFonMenu;
        private System.Windows.Forms.ToolStripMenuItem colorOfBallMenu;
        private System.Windows.Forms.ToolStripMenuItem greenMenu;
        private System.Windows.Forms.ToolStripMenuItem purpleMenu;
        private System.Windows.Forms.ToolStripMenuItem lilacMenu;
        private System.Windows.Forms.ToolStripMenuItem brownMenu;
        private System.Windows.Forms.ToolStripMenuItem turquoiseMenu;
        private System.Windows.Forms.ToolStripMenuItem greenMenuBall;
        private System.Windows.Forms.ToolStripMenuItem darkRedMenuBall;
        private System.Windows.Forms.ToolStripMenuItem blueMenuBall;
        private System.Windows.Forms.ToolStripMenuItem orangeMenuBall;
        private System.Windows.Forms.ToolStripMenuItem brownMenuBall;
        private System.Windows.Forms.ToolStripMenuItem redMenuBall;
        private System.Windows.Forms.ToolStripMenuItem scoreMenu;
        private System.Windows.Forms.ToolStripMenuItem recordsMenu;
        private System.Windows.Forms.ToolStripMenuItem instructionMenu;
    }
}

