using System.Diagnostics;
using System.Windows.Forms;


namespace Assignment_6
{
    /// <summary>
    /// Main form of the application.
    /// Responsible for managing the TaskManager class and UI.
    /// </summary>
    public partial class MainForm : Form
    {
        private TaskManager taskManager = new TaskManager();

        private string fileName = Application.StartupPath + "\\Tasks.txt";

        /// <summary>
        /// Initialize the main form, its components nad update the list of tasks.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        /// <summary>
        /// Empty the task list
        /// </summary>
        public void DeleteAllTasks()
        {
            while (lstTaskList.Items.Count > 0)
            {
                lstTaskList.Items.RemoveAt(0);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Create the ToolTip and associate with the Form container.
            ToolTip toolTip1 = new ToolTip();

            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;

            toolTip1.ShowAlways = true;

            toolTip1.SetToolTip(this.dtpDateAndTime, "Click to open the calendar for date, write the time in the box");
        }

        /// <summary>
        /// Populate priority combobox with formatted enum values.
        /// Sets default index to 2, "Normal".
        /// </summary>
        private void loadPriorityList()
        {
            cmbPriority.DataSource = Enum.GetValues(typeof(PriorityType));
            cmbPriority.Format += (s, e) =>
            {
                if (e.ListItem is PriorityType p)
                {
                    e.Value = p.ToString().Replace("_", " ");
                }
            };
            cmbPriority.SelectedIndex = 2;
        }

        /// <summary>
        /// Initializes or resets the GUI to default state.
        /// </summary>
        private void InitializeGUI()
        {
            DeleteAllTasks();
            this.Load += MainForm_Load; //Load tooltips
            loadPriorityList();         //Load priority combobox
            lstTaskList.SelectedIndexChanged += lstTaskList_SelectedIndexChanged; // Updates input fields based on selected task, disables buttons if selection is invalid
            UpdateGUI();            //Populate list UI
            chkNoDate.CheckedChanged += ChkNoDate_CheckedChanged;   //Update date field when "no date" checkbox is checked


            btnChange.Enabled = false;
            btnDelete.Enabled = false;

            //Set up and start timer
            clockTimer.Interval = 1000; // 1 second
            clockTimer.Tick += clockTimer_Tick;
            clockTimer.Start();
        }

        /// <summary>
        /// Validates required fields (Description and Priority)
        /// </summary>
        /// <param name="errorMessages">A list of error messages for any missing fields</param>
        /// <returns>Returns true if no errors are found, otherwise false</returns>
        public bool ValidateRequiredInput(out List<string> errorMessages)
        {
            errorMessages = new List<string>();

            if (string.IsNullOrWhiteSpace(txtDescription.Text))
                errorMessages.Add("Description is required.");

            if (cmbPriority.SelectedItem == null)
                errorMessages.Add("Priority must be selected.");

            return errorMessages.Count == 0;
        }

        /// <summary>
        /// Refresh task list UI.
        /// </summary>
        public void UpdateGUI()
        {
            lstTaskList.Items.Clear();

            foreach (Task task in taskManager.TaskList)
            {
                lstTaskList.Items.Add(task.ToString());
            }
        }

        /// <summary>
        /// Disable date selection if "no date" is checked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChkNoDate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNoDate.Checked)
            {
                dtpDateAndTime.Enabled = false;
            }
            else
            {
                dtpDateAndTime.Enabled = true;
            }
        }

        /// <summary>
        /// Fill input fields with the data from the selected task.
        /// Disable change and delete buttons if index is invalid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstTaskList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstTaskList.SelectedIndex;

            if (ValidateListIndex(index))
            {
                Task currTask = taskManager.GetTask(index);
                PopulateFields(currTask);

                btnChange.Enabled = true;
                btnDelete.Enabled = true;
            }
            else
            {
                SetDefaultValues();

                btnChange.Enabled = false;
                btnDelete.Enabled = false;
            }

        }

        /// <summary>
        /// Checks if the given index is within valid task list bounds.
        /// </summary>
        /// <param name="index">Index to validate</param>
        /// <returns>Returns true if the index is valid, otherwise false.</returns>
        public bool ValidateListIndex(int index)
        {
            return index >= 0 && index < taskManager.TaskList.Count;
        }

        /// <summary>
        /// Add a new task using current input values.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateRequiredInput(out List<string> errorMessages))
            {
                string errorMessage = string.Join("\n", errorMessages);
                MessageBox.Show(errorMessage, "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                var (taskDate, description, priority) = ReadInputValues();
                taskManager.AddTask(taskDate, description, priority);

                UpdateGUI();
                SetDefaultValues();
            }
        }

        /// <summary>
        /// Reset input fields to default values.
        /// </summary>
        public void SetDefaultValues()
        {
            txtDescription.Text = string.Empty;
            cmbPriority.SelectedIndex = 2;
            dtpDateAndTime.Value = DateTime.Now;

        }

        /// <summary>
        /// Delete the selected task if confirmed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = lstTaskList.SelectedIndex;

            if (!ValidateListIndex(index))
            {
                MessageBox.Show("You have to select a task first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete the selected task?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Task currTask = taskManager.GetTask(index);

                    taskManager.RemoveTask(index);
                    lstTaskList.SelectedIndex = -1;
                    UpdateGUI();
                }
            }
        }

        /// <summary>
        /// Update the selected task with new input values.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChange_Click(object sender, EventArgs e)
        {
            int index = lstTaskList.SelectedIndex;

            if (!ValidateListIndex(index))
            {
                MessageBox.Show("You have to select a task first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (!ValidateRequiredInput(out List<string> errorMessages))
                {
                    string errorMessage = string.Join("\n", errorMessages);
                    MessageBox.Show(errorMessage, "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    var (taskDate, description, priority) = ReadInputValues();
                    taskManager.ChangeTask(index, taskDate, description, priority);
                }
                UpdateGUI();
                lstTaskList.SelectedIndex = index;
            }
        }

        /// <summary>
        /// Read task input from fields.
        /// </summary>
        /// <returns>A tuple with task date,  description, and priority</returns>
        private (DateTime, string, PriorityType) ReadInputValues()
        {
            //If noDate is check, set taskdate to MinValue, otherwise, set taskDate to input value
            DateTime taskDate = chkNoDate.Checked ? DateTime.MinValue : dtpDateAndTime.Value;
            string description = txtDescription.Text;
            PriorityType priority = (PriorityType)Enum.Parse(typeof(PriorityType), cmbPriority.SelectedItem.ToString());

            return (taskDate, description, priority);
        }

        /// <summary>
        /// Fill input fields with the selected task's data.
        /// </summary>
        /// <param name="task"></param>
        private void PopulateFields(Task task)
        {
            int index = lstTaskList.SelectedIndex;

            if (ValidateListIndex(index))
            {
                txtDescription.Text = task.Description;
                cmbPriority.SelectedIndex = (int)task.Priority;

                //Handle date fields, check NoDate if date is set to MinValue
                if (task.Date == DateTime.MinValue)
                {
                    chkNoDate.Checked = true;
                    dtpDateAndTime.Enabled = false;
                }
                else
                {
                    chkNoDate.Checked = false;
                    dtpDateAndTime.Enabled = true;
                    dtpDateAndTime.Value = task.Date;
                }
            }
        }

        /// <summary>
        /// Update the clock label every second.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clockTimer_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        /// <summary>
        /// Clears all existing tasks and resets the UI to an empty state
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(
                "Are you sure you want to reset the list? Unsaved changes will be lost.",
                "Confirm Open",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                taskManager = new TaskManager();
                InitializeGUI();
            }
        }

        /// <summary>
        /// Loads task data from a file into the application.
        /// Triggered when the user selects "Open" from the menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openDataFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(
                "Are you sure you want to open a file? Unsaved changes will be lost.",
                "Confirm Open",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                string errMessage = "Something went wrong when opening the file";
                bool ok = taskManager.ReadDataFromFile(fileName);
                if (!ok)
                    MessageBox.Show(errMessage);
                else
                    UpdateGUI();
            }
        }

        /// <summary>
        /// Saves the current task list to a file.
        /// Triggered when the user selects "Save" from the menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveDataFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(
        "Do you want to save changes to the file?",
        "Confirm Save",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                string errMessage = "Something went wrong while saving data to file";
                bool ok = taskManager.WriteDataToFile(fileName);
                if (!ok)
                    MessageBox.Show(errMessage);
                else
                    MessageBox.Show("Data saved to file:" + Environment.NewLine + fileName);
            }
        }

        /// <summary>
        /// Exit program through menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit?",
                "Confirm Exit",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// Open AboutBox form through menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutTheProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.ShowDialog();
        }
    }
}
