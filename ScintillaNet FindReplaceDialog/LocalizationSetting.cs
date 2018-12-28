using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ScintillaNET_FindReplaceDialog
{
    /// <summary>
    /// An utility class to localize the dialog(s).
    /// </summary>
    public static class LocalizationSetting
    {
        /// <summary>
        /// Gets or sets the locale for the class library and for the host application's threads.
        /// </summary>
        public static string Locale { get; set; } = "en";

        /// <summary>
        /// Translated messages for the class library.
        /// </summary>
        private static List<KeyValuePair<string, string>> messageResources = new List<KeyValuePair<string, string>>();

        /// <summary>
        /// An indicator if the localized messages have been loaded from the resource.
        /// </summary>
        private static bool localizedMessagesLoaded = false;

        /*
        /// <summary>
        /// Initializes the thread culture to match the given locale.
        /// </summary>
        public static void Init()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo(Locale);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(Locale);
        }
        */

        /// <summary>
        /// Localizes a form to match specific culture.
        /// </summary>
        /// <param name="form">A form to localize.</param>
        public static void SetCulture(Form form)
        {
            // Make the CultureInfo.
            CultureInfo cultureInfo = new CultureInfo(Locale);

            // Make a ComponentResourceManager.
            ComponentResourceManager componentResourceManager
                = new ComponentResourceManager(form.GetType());

            // Apply resources to the form.
            componentResourceManager.ApplyResources(
                form, "$this", cultureInfo);

            List<ToolStripMenuItem> menuItems = new List<ToolStripMenuItem>();

            foreach(Control control in GetControlControls(form, form))
            {
                componentResourceManager.ApplyResources(
                    control, control.Name, cultureInfo);
            }

            foreach (IComponent component in GetComponents(form))
            {
                if (component is ToolStripMenuItem)
                {
                    componentResourceManager.ApplyResources(
                        component, (component as ToolStripMenuItem).Name, cultureInfo);
                }
            }
        }

        /// <summary>
        /// Iterates through all the controls on the form.
        /// </summary>
        /// <param name="control">A control to start iterating from.</param>
        /// <param name="form">A form to which the controls belong to.</param>
        /// <returns>A collection of controls.</returns>
        public static IEnumerable<Control> GetControlControls(Control control, Form form)
        {
            List<Control> result = new List<Control>();

            foreach (Control c in control.Controls)
            {
                if (!c.Equals(form))
                {
                    result.Add(c);
                }


                result.AddRange(GetControlControls(c, form));
            }

            return result;
        }

        /// <summary>
        /// Gets the components on the form through reflection.
        /// </summary>
        /// <param name="form">A form which controls to get.</param>
        /// <returns>A collection of components the form has.</returns>
        public static IEnumerable<IComponent> GetComponents(Form form)
        {
            List<IComponent> result = new List<IComponent>();
            IContainer container;
            try
            {
                FieldInfo fieldInfo = form.GetType().GetField("components", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
                container = (IContainer)fieldInfo.GetValue(form);
            }
            catch
            {
                return result;
            }

            foreach (Component c in container.Components)
            {
                result.Add(c);
                if (c is ContextMenuStrip)
                {
                    foreach (object item in (c as ContextMenuStrip).Items)
                    {
                        if (item is ToolStripMenuItem)
                        result.Add(item as ToolStripMenuItem);
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// The list of localized messages in the library.
        /// </summary>
        private static readonly IList<string> messages =
            new List<string>
            {
                "txtTotalFound",
                "txtErrorInRegexp",
                "txtTotalReplaced",
                "txtMatchNotFound",
                "txtSearchWrapBeginningSel",
                "txtSearchWrapBeginningDoc",
                "txtClearHistory",
                "txtSearchWrapEndSel",
                "txtSearchWrapEndDoc",
                "txtLine1",
                "txtLine2",
                "txtGotoLineError",
                "txtGotoLineNumericError",
                "txtClockToolTip",
                "textExtChars"
            }.AsReadOnly();


        /// <summary>
        /// Loads the localized messages into a cache to be used by the library.
        /// </summary>
        /// <param name="type">A type for which this assembly belongs to.</param>
        public static void LoadLocalizations(Type type)
        {
            if (localizedMessagesLoaded) // don't keep reloading..
            {
                return;
            }

            System.Resources.ResourceManager resourceManager =
                new System.Resources.ResourceManager("ScintillaNET_FindReplaceDialog.LocalizationMessages.Messages", type.Assembly);


            foreach (string message in messages)
            {
                // try to get the localized text..
                try
                {
                    CultureInfo cultureInfo = new CultureInfo(Locale);
                    messageResources.Add(new KeyValuePair<string, string>(message, resourceManager.GetString(message, cultureInfo)));
                }
                catch
                {
                    // get the general text..
                    messageResources.Add(new KeyValuePair<string, string>(message, resourceManager.GetString(message)));
                }
            }
        }

        /// <summary>
        /// Gets a localized message for the selected culture.
        /// </summary>
        /// <param name="name">The name of the message.</param>
        /// <param name="defaultValue">The default value for the message.</param>
        /// <returns>A localized message for the selected culture if found; otherwise <paramref name="defaultValue"/>.</returns>
        public static string GetMessage(string name, string defaultValue)
        {
            try
            {
                return messageResources.First(f => f.Key == name).Value;
            }
            catch
            {
                return defaultValue;
            }
        }
    }
}
