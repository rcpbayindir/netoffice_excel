﻿using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetOffice.DeveloperToolbox
{
    /// <summary>
    /// Represents the host application
    /// </summary>
    public interface IToolboxHost
    {
        /// <summary>
        /// Current Language ID (1031 or 1033)
        /// </summary>
        int CurrentLanguageID { get; set; }

        /// <summary>
        /// Application Icon
        /// </summary>
        Icon Icon { get; }

        /// <summary>
        /// Current loaded content controls
        /// </summary>
        IToolboxControl[] ToolboxControls { get; }

        /// <summary>
        /// Switch to toolbox control
        /// </summary>
        /// <param name="controlName">logical name of the control</param>
        void SwitchTo(string controlName);

        /// <summary>
        /// Display the application main window
        /// </summary>
        void ShowMainWindow();

        /// <summary>
        /// Minimize the application main window
        /// </summary>
        /// <param name="showInTaskbar">true if visible in taskbar, otherwise false</param>
        void MinimizeMainWindow(bool showInTaskbar);

        /// <summary>
        /// Occurs when the application main window has been minimized
        /// </summary>
        event EventHandler Minimized;
    }
}
