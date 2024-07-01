using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DMS_DA
{
    public class clsDataAccessSettings
    {

        static public string ConnectionString = "Server=.;Database=DMS; User Id =aa; Password=123;Trusted_Connection=True;TrustServerCertificate=true;";

        static public void SetErrorLoggingEvent(string exMessage)
        {
            string sourceName = "Debt Managment System";

            if(!EventLog.SourceExists(sourceName))
            {
                EventLog.CreateEventSource(sourceName, "Application");

            }


            EventLog.WriteEntry(sourceName, exMessage, EventLogEntryType.Error);

        }

    }
}
