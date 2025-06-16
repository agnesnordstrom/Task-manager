using System;
using System.Collections.Generic;
using System.IO;

namespace Assignment_6
{
    /// <summary>
    /// Handles saving and loading a list of tasks to and from a file.
    /// </summary>
    public class FileManager
    {
        private const string fileToken = "ABC123"; //Verification that the file was created by this application


        /// <summary>
        /// Saves the given list of tasks to a file.
        /// </summary>
        /// <param name="taskList">List of tasks to save</param>
        /// <param name="fileName">Name of file to save to</param>
        /// <returns>Returns true if successful, false if unsuccessful.</returns>
        internal bool SaveTaskListToFile(List<Task> taskList, string fileName)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    writer.WriteLine(fileToken);
                    writer.WriteLine(taskList.Count);

                    foreach (Task task in taskList)
                    {
                        writer.WriteLine(task.Description);
                        writer.WriteLine((int)task.Priority); // Save enum as int
                        writer.WriteLine(task.Date.ToString("o")); // ISO 8601 format
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Reads a list of tasks from a file, replacing the given taskList content.
        /// </summary>
        /// <param name="taskList">List of tasks to read</param>
        /// <param name="fileName">Name of file to read from</param>
        /// <returns>Returns true if successful, false if unsuccessful.</returns>
        internal bool ReadTaskListFromFile(List<Task> taskList, string fileName)
        {
            try
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    string token = reader.ReadLine();
                    if (token != fileToken)
                        return false;

                    int count = int.Parse(reader.ReadLine());

                    taskList.Clear(); // Clear existing tasks

                    for (int i = 0; i < count; i++)
                    {
                        string description = reader.ReadLine();
                        PriorityType priority = (PriorityType)int.Parse(reader.ReadLine());
                        DateTime taskDate = DateTime.Parse(reader.ReadLine());

                        taskList.Add(new Task(taskDate, description, priority));
                    }

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
