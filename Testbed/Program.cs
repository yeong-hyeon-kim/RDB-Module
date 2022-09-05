using RDB_Module;
using System.Data;
using System.Runtime.Versioning;

namespace TestBed
{
    [SupportedOSPlatform("windows")]
    public class Program
    {
        static private ActionModule Action;
        static private string ConnString = string.Empty;

        static void Main(string[] args)
        {
            DataTable dtResult = new DataTable();
            string Message = string.Empty;

            Action = new ActionModule(ConnString);
            Action.ExecuteQuery("Database SQL Query", "Database Action Type", out Message, ref dtResult);
        }
    }
}



