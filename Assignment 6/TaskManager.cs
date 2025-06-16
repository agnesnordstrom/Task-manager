using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    /// <summary>
    /// Manages a list of tasks, including creating, retrieving, editing and deleting task data.
    /// Also saves and loads task lists from file.
    /// </summary>
    internal class TaskManager
    {
        private List<Task> taskList;

        //Initializes a new instance of the TaskManager class with no parameters.
        public TaskManager() 
        { 
            taskList = new List<Task>();
        }

        /// <summary>
        /// Get the list of tasks
        /// </summary>
        public List<Task> TaskList { get { return taskList; } }

        /// <summary>
        /// Adds a new task to the task list
        /// </summary>
        /// <param name="taskDate">The date and time of the task</param>
        /// <param name="description">The description of the task</param>
        /// <param name="priority">The priority level of the task</param>
        public void AddTask(DateTime taskDate, string description, PriorityType priority)
        {
            var task = new Task(taskDate, description, priority);
            taskList.Add(task);
        }
        /// <summary>
        /// Removes a task from the task list at the given index.
        /// </summary>
        /// <param name="index"></param>
        public void RemoveTask(int index)
        {
            taskList.RemoveAt(index);
        }

        /// <summary>
        /// Replaces a task at the given index with updated information.
        /// </summary>
        /// <param name="index">Index of task to change.</param>
        /// <param name="taskDate">New date and time.</param>
        /// <param name="description">New description.</param>
        /// <param name="priority">New priority level.</param>
        public void ChangeTask(int index, DateTime taskDate, string description, PriorityType priority)
        {
            if (index >= 0 && index < taskList.Count)
            {
                Task updatedTask = new Task(taskDate, description, priority);
                taskList[index] = updatedTask;
            }
            else
            {
                MessageBox.Show("Select an item first!", "Error");
            }
        }

        /// <summary>
        /// Retrieves the task at the given index.
        /// </summary>
        /// <param name="index">Index of task to retrieve</param>
        /// <returns>Task at specified index, or null if index is invalid</returns>
        public Task GetTask(int index)
        {
            if (index >= 0 && index < TaskList.Count)
            {
                return TaskList[index];
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Reads data from a file and populatees the task list.
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public bool ReadDataFromFile(string fileName)
        {
            FileManager fileManager = new FileManager();
            return fileManager.ReadTaskListFromFile(taskList, fileName);
        }

        /// <summary>
        /// Saves the current task list to a file.
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public bool WriteDataToFile(string fileName)
        {
            FileManager fileManager = new FileManager();
            return fileManager.SaveTaskListToFile(taskList, fileName);
        }
    }
}
