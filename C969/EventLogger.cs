﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using C969.Database;


namespace C969
{
    public static class EventLogger
    {
        private static string filename = "logs.txt";

        public static void LogSuccessfulLogin(UserAccount user)
        {
            LogUnspecifiedEntry($"\"{user.Username}\" successfully logged in.");
        }
        public static void LogUnsuccessfulLogin(string username)
        {
            LogUnspecifiedEntry($"ERROR: Attempted log in with username \"{username}\".");
        }
        public static void LogConnectionIssue()
        {
            LogUnspecifiedEntry($"ERROR: Could not access database.");
        }
        public static void LogUnspecifiedEntry(string entry)
        {
            StringBuilder logBuilder = new StringBuilder();
            logBuilder.Append($"{DateTime.Now}: ");
            logBuilder.Append($"{entry}");

            if (entry[entry.Length - 1] != '.')
            {
                logBuilder.Append('.');
            }

            logBuilder.Append("\r\n");

            EnterLogItem(logBuilder.ToString());
        }

        private static void EnterLogItem(string entry)
        {
            using (StreamWriter fileWriter = File.AppendText(filename))
            {
                fileWriter.Write(entry);
            }
        }
    }
}