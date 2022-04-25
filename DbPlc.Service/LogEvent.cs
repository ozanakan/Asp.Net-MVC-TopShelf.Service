using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbPlc.Service
{
    class LogEvent
    {
        public void Log(Exception e)
        {
            if (e is SqlException exception) SqlError(exception.Errors);
        }
        private static void AddLog(string logMessage)
        {
            if (!EventLog.SourceExists("DbPlc"))
            {
                EventLog.CreateEventSource("DbPlc", "DbPlc");
            }
            var log = new EventLog
            {
                Source = "DbPlc"
            };
            log.WriteEntry(logMessage, EventLogEntryType.Error);
        }

        private static void SqlError(SqlErrorCollection sqlErrors)
        {
            var sb = new StringBuilder();
            foreach (SqlError item in sqlErrors)
            {
                sb.AppendLine("Hata Tarihi: ");
                sb.Append(DateTime.Now);
                sb.Append(Environment.NewLine);
                sb.AppendLine("Satır Numarası: ");
                sb.Append(item.LineNumber);
                sb.Append(Environment.NewLine);
                sb.AppendLine("Mesaj: ");
                sb.Append(item.Message);

                AddLog(sb.ToString());
            }
        }

    }
}
