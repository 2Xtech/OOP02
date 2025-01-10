using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokeDex
{
    public static class ProgressBarExtensions
    {
        // Import the SetWindowTheme function from uxtheme.dll
        [DllImport("uxtheme.dll")]
        static extern int SetWindowTheme(IntPtr hWnd, string appName = "", string partList = "");

        /// <summary>
        /// Extension method that disables the visual style (theme) of a ProgressBar control.
        /// </summary>
        /// <param name="progressBar">The ProgressBar control to modify.</param>
        public static void DisableStyle(this ProgressBar progressBar)
        {
            // Pass empty strings for appName and partList to disable visual styles
            SetWindowTheme(progressBar.Handle);
        }
    }
}
