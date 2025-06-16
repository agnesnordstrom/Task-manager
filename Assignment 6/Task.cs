using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    /// <summary>
    /// Represents a task with a date and time, description, and priority.
    /// </summary>
    internal class Task
    {
        private DateTime date;
        private string description;
        private PriorityType priority;


        /// <summary>
        /// Default constructor, creates an empty task.
        /// </summary>
        public Task()
        {

        }

        /// <summary>
        /// Constructor that intializes the task with a date
        /// </summary>
        /// <param name="taskDate"></param>
        public Task(DateTime taskDate) : this(taskDate, string.Empty, PriorityType.Normal)
        {

        }

        /// <summary>
        /// Constructor that initiates the task with a date, description and priority.
        /// </summary>
        /// <param name="taskDate"></param>
        /// <param name="description"></param>
        /// <param name="priority"></param>
        public Task(DateTime taskDate, string description, PriorityType priority)
        {
            this.date = taskDate;
            this.description = description;
            this.priority = priority;
        }

        /// <summary>
        /// Gets or sets the description of the task.
        /// </summary>
        public string Description
        {
            get { return description; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    description = value;
            }
        }

        /// <summary>
        /// Gets or sets the priority of the task.
        /// </summary>
        public PriorityType Priority { get => priority; set => priority = value; }

        /// <summary>
        /// Gets or sets the date and time of the task.
        /// </summary>
        public DateTime Date { get => date; set => date = value; }

        /// <summary>
        /// Returns the priority as a formatted string, with underscores replaced by spaces.
        /// </summary>
        /// <returns></returns>
        public string GetPriorityString()
        {
            return priority.ToString().Replace("_", " ");
        }

        /// <summary>
        /// Returns the time portion of the date as a string.
        /// Returns an empty string if the date is set to MinValue (same as not set)
        /// </summary>
        /// <returns></returns>
        public string GetTimeString()
        {
            return date == DateTime.MinValue ? "" : date.ToString("HH:mm");
        }

        /// <summary>
        /// Returns a formatted string representation of the task,
        /// including date, time, priority, and description.
        /// </summary>
        public override string ToString()
        {
            string dateStr = date == DateTime.MinValue
                ? "no deadline"
                : date.ToString("ddd, dd, MMM");


            dateStr = FixedLengthString(dateStr, 15); // pad or truncate to 15 chars

            string textOut = string.Format("{0} {1,5}    {2,-18} {3,-20}",
                                    dateStr,
                GetTimeString(),
                GetPriorityString(),
                Description);

            return textOut;
        }

        /// <summary>
        /// Returns a string padded or truncated to a fixed length.
        /// For view consistency in the MainForm listbox.
        /// </summary>
        private string FixedLengthString(string input, int totalLength)
        {
            if (input.Length >= totalLength)
                return input.Substring(0, totalLength); // truncate if too long
            else
                return input.PadRight(totalLength);
        }
    }
}
