using System;
using System.Collections.Generic;
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

        /// <summary>
        /// Initializes the thread culture to match the given locale.
        /// </summary>
        public static void Init()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo(Locale);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(Locale);
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
                "txtGotoLineNumericError"
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

            Init(); // must call this..

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
