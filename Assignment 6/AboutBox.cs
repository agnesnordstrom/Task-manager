using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_6
{
    /// <summary>
    /// Represents an AboutBox that shows information about the project, and an image of my cat.
    /// </summary>
    public partial class AboutBox : Form
    {
        public AboutBox()
        {
            InitializeComponent();

            lblProductName.Text = Application.ProductName;
            lblVersion.Text = $"Version {Application.ProductVersion}";
            lblDescription.Text = ((AssemblyDescriptionAttribute)Attribute.GetCustomAttribute(
            Assembly.GetExecutingAssembly(), typeof(AssemblyDescriptionAttribute)))?.Description ?? "No description";
        }

        /// <summary>
        /// Close the form when OK is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
