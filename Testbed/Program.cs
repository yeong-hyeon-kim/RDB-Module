using RDB_Module;
using System.Data;

namespace TestBed
{
    public class Program
    {
        static private RAction Action;
        static private string ConnString = string.Empty;

        static void Main(string[] args)
        {
            DataTable Result = new DataTable();
            string Message = string.Empty;

            Action = new RAction(ConnString);
            Action.ExecuteQuery("Database SQL Query", "Database Action Type", out Message, ref Result);
        }
    }
}



