using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace UserLogin
{
	public static class Logger
	{
        static private List<string> currentSessionActivities = new List<string>();


        static public void LogActivity(string activity)
        {
            string activityLine = DateTime.Now + ";"
            + LoginValidation.currentUserName + ";" + LoginValidation.currentUserRole + ";"
            + activity;
            currentSessionActivities.Add(activityLine);

            String filePath = "D:\\PS44WPF\\UserLogin\\test.txt";
            StreamWriter sw = new StreamWriter(filePath, true);

            if (File.Exists(filePath))
            {
                sw.WriteLine(activityLine);
            }

            sw.Close();
        }

        static public IEnumerable<string> GetCurrentSessionActivities(string filter)
        {
            List<string> filteredActivities = currentSessionActivities.Where(w => w.Contains(filter)).ToList();
            return currentSessionActivities;
        }
    }
}

