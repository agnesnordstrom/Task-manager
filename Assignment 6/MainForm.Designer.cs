namespace Assignment_6
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip = new ContextMenuStrip(components);
            clockTimer = new System.Windows.Forms.Timer(components);
            timer1 = new System.Windows.Forms.Timer(components);
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openDataFileToolStripMenuItem = new ToolStripMenuItem();
            saveDataFileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem1 = new ToolStripMenuItem();
            aboutTheProgramToolStripMenuItem = new ToolStripMenuItem();
            menuMainMenu = new MenuStrip();
            cmbPriority = new ComboBox();
            lblDescription = new Label();
            lstTaskList = new ListBox();
            lblListDate = new Label();
            lblListHour = new Label();
            lblListPriority = new Label();
            lblListDescription = new Label();
            grpToDo = new GroupBox();
            btnChange = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            dtpDateAndTime = new DateTimePicker();
            lblPriority = new Label();
            txtDescription = new TextBox();
            chkNoDate = new CheckBox();
            lblClock = new Label();
            lblDateAndTime = new Label();
            menuMainMenu.SuspendLayout();
            grpToDo.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(24, 24);
            menuStrip.Name = "contextMenuStrip1";
            menuStrip.Size = new Size(61, 4);
            // 
            // clockTimer
            // 
            clockTimer.Enabled = true;
            clockTimer.Interval = 1000;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openDataFileToolStripMenuItem, saveDataFileToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + N";
            newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newToolStripMenuItem.Size = new Size(301, 34);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // openDataFileToolStripMenuItem
            // 
            openDataFileToolStripMenuItem.Name = "openDataFileToolStripMenuItem";
            openDataFileToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + O";
            openDataFileToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openDataFileToolStripMenuItem.Size = new Size(301, 34);
            openDataFileToolStripMenuItem.Text = "Open data file";
            openDataFileToolStripMenuItem.Click += openDataFileToolStripMenuItem_Click;
            // 
            // saveDataFileToolStripMenuItem
            // 
            saveDataFileToolStripMenuItem.Name = "saveDataFileToolStripMenuItem";
            saveDataFileToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + S";
            saveDataFileToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveDataFileToolStripMenuItem.Size = new Size(301, 34);
            saveDataFileToolStripMenuItem.Text = "Save data file";
            saveDataFileToolStripMenuItem.Click += saveDataFileToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeyDisplayString = "Alt + F4";
            exitToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            exitToolStripMenuItem.Size = new Size(301, 34);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem1
            // 
            helpToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { aboutTheProgramToolStripMenuItem });
            helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            helpToolStripMenuItem1.Size = new Size(65, 29);
            helpToolStripMenuItem1.Text = "Help";
            // 
            // aboutTheProgramToolStripMenuItem
            // 
            aboutTheProgramToolStripMenuItem.Name = "aboutTheProgramToolStripMenuItem";
            aboutTheProgramToolStripMenuItem.Size = new Size(270, 34);
            aboutTheProgramToolStripMenuItem.Text = "About the program";
            aboutTheProgramToolStripMenuItem.Click += aboutTheProgramToolStripMenuItem_Click;
            // 
            // menuMainMenu
            // 
            menuMainMenu.BackColor = Color.LightSlateGray;
            menuMainMenu.ImageScalingSize = new Size(24, 24);
            menuMainMenu.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem1 });
            menuMainMenu.Location = new Point(0, 0);
            menuMainMenu.Name = "menuMainMenu";
            menuMainMenu.Size = new Size(1367, 33);
            menuMainMenu.TabIndex = 0;
            menuMainMenu.Text = "Main menu";
            // 
            // cmbPriority
            // 
            cmbPriority.FormattingEnabled = true;
            cmbPriority.Location = new Point(733, 70);
            cmbPriority.Name = "cmbPriority";
            cmbPriority.Size = new Size(317, 33);
            cmbPriority.TabIndex = 4;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(59, 155);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(57, 25);
            lblDescription.TabIndex = 5;
            lblDescription.Text = "To do";
            // 
            // lstTaskList
            // 
            lstTaskList.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstTaskList.FormattingEnabled = true;
            lstTaskList.ItemHeight = 20;
            lstTaskList.Location = new Point(29, 80);
            lstTaskList.Name = "lstTaskList";
            lstTaskList.Size = new Size(1264, 344);
            lstTaskList.TabIndex = 1;
            // 
            // lblListDate
            // 
            lblListDate.AutoSize = true;
            lblListDate.Location = new Point(29, 52);
            lblListDate.Name = "lblListDate";
            lblListDate.Size = new Size(49, 25);
            lblListDate.TabIndex = 0;
            lblListDate.Text = "Date";
            // 
            // lblListHour
            // 
            lblListHour.AutoSize = true;
            lblListHour.Location = new Point(206, 52);
            lblListHour.Name = "lblListHour";
            lblListHour.Size = new Size(52, 25);
            lblListHour.TabIndex = 1;
            lblListHour.Text = "Hour";
            // 
            // lblListPriority
            // 
            lblListPriority.AutoSize = true;
            lblListPriority.Location = new Point(301, 52);
            lblListPriority.Name = "lblListPriority";
            lblListPriority.Size = new Size(68, 25);
            lblListPriority.TabIndex = 2;
            lblListPriority.Text = "Priority";
            lblListPriority.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblListDescription
            // 
            lblListDescription.AutoSize = true;
            lblListDescription.Location = new Point(513, 51);
            lblListDescription.Name = "lblListDescription";
            lblListDescription.Size = new Size(102, 25);
            lblListDescription.TabIndex = 3;
            lblListDescription.Text = "Description";
            // 
            // grpToDo
            // 
            grpToDo.Controls.Add(lblListDescription);
            grpToDo.Controls.Add(lblListPriority);
            grpToDo.Controls.Add(lblListHour);
            grpToDo.Controls.Add(lblListDate);
            grpToDo.Controls.Add(lstTaskList);
            grpToDo.Location = new Point(30, 219);
            grpToDo.Name = "grpToDo";
            grpToDo.Size = new Size(1311, 441);
            grpToDo.TabIndex = 8;
            grpToDo.TabStop = false;
            grpToDo.Text = "To do";
            // 
            // btnChange
            // 
            btnChange.Location = new Point(71, 671);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(161, 34);
            btnChange.TabIndex = 9;
            btnChange.Text = "Save changes";
            btnChange.UseVisualStyleBackColor = true;
            btnChange.Click += btnChange_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(250, 671);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(459, 198);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(313, 34);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dtpDateAndTime
            // 
            dtpDateAndTime.CustomFormat = "yyyy-MM-dd HH:mm";
            dtpDateAndTime.Format = DateTimePickerFormat.Custom;
            dtpDateAndTime.Location = new Point(199, 70);
            dtpDateAndTime.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtpDateAndTime.Name = "dtpDateAndTime";
            dtpDateAndTime.RightToLeftLayout = true;
            dtpDateAndTime.Size = new Size(400, 31);
            dtpDateAndTime.TabIndex = 2;
            // 
            // lblPriority
            // 
            lblPriority.AutoSize = true;
            lblPriority.Location = new Point(635, 73);
            lblPriority.Name = "lblPriority";
            lblPriority.Size = new Size(68, 25);
            lblPriority.TabIndex = 3;
            lblPriority.Text = "Priority";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(199, 149);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(851, 31);
            txtDescription.TabIndex = 6;
            // 
            // chkNoDate
            // 
            chkNoDate.AutoSize = true;
            chkNoDate.Location = new Point(202, 112);
            chkNoDate.Name = "chkNoDate";
            chkNoDate.Size = new Size(134, 29);
            chkNoDate.TabIndex = 11;
            chkNoDate.Text = "No deadline";
            chkNoDate.UseVisualStyleBackColor = true;
            // 
            // lblClock
            // 
            lblClock.AutoSize = true;
            lblClock.Location = new Point(1264, 680);
            lblClock.Name = "lblClock";
            lblClock.Size = new Size(0, 25);
            lblClock.TabIndex = 12;
            // 
            // lblDateAndTime
            // 
            lblDateAndTime.AutoSize = true;
            lblDateAndTime.Location = new Point(59, 70);
            lblDateAndTime.Name = "lblDateAndTime";
            lblDateAndTime.Size = new Size(124, 25);
            lblDateAndTime.TabIndex = 1;
            lblDateAndTime.Text = "Date and time";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1367, 726);
            Controls.Add(lblClock);
            Controls.Add(chkNoDate);
            Controls.Add(txtDescription);
            Controls.Add(lblPriority);
            Controls.Add(dtpDateAndTime);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(btnChange);
            Controls.Add(grpToDo);
            Controls.Add(lblDescription);
            Controls.Add(lblDateAndTime);
            Controls.Add(cmbPriority);
            Controls.Add(menuMainMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "ToDoList reminder by Agnes";
            menuMainMenu.ResumeLayout(false);
            menuMainMenu.PerformLayout();
            grpToDo.ResumeLayout(false);
            grpToDo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem newToolStripMenuItem1;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ContextMenuStrip menuStrip;
        private System.Windows.Forms.Timer clockTimer;
        private System.Windows.Forms.Timer timer1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openDataFileToolStripMenuItem;
        private ToolStripMenuItem saveDataFileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem1;
        private ToolStripMenuItem aboutTheProgramToolStripMenuItem;
        private MenuStrip menuMainMenu;
        private ComboBox cmbPriority;
        private Label lblDescription;
        private ListBox lstTaskList;
        private Label lblListDate;
        private Label lblListHour;
        private Label lblListPriority;
        private Label lblListDescription;
        private GroupBox grpToDo;
        private Button btnChange;
        private Button btnDelete;
        private Button btnAdd;
        private DateTimePicker dtpDateAndTime;
        private Label lblPriority;
        private TextBox txtDescription;
        private CheckBox chkNoDate;
        private Label lblClock;
        private Label lblDateAndTime;
    }
}
