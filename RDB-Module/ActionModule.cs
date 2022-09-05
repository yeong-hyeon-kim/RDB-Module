using System.Data;
using System.Data.OleDb;
using System.Runtime.Versioning;

namespace RDB_Module
{
    [SupportedOSPlatform("windows")]
    public class ConnectionState
    {
        private static OleDbConnection ConnState;
        private static string Connection;

        public ConnectionState()
        {

        }

        public ConnectionState(string connectionString)
        {
            Connection = connectionString;
        }

        public static OleDbConnection Instance()
        {
            if (ConnState == null)
            {
                ConnState = new OleDbConnection(Connection);
            }

            return ConnState;
        }
    }

    [SupportedOSPlatform("windows")]
    public class ActionModule
    {
        public ActionModule(string connectionString)
        {
            new ConnectionState(connectionString);
        }

        /// <summary>
        /// SQL SELECT INSERT, UPDATE, DELETE
        /// </summary>
        /// <param name="Query">SQL</param>
        /// <param name="DML_Type">C : INSERT, R : SELECT, U : UPDATE, D : DELETE</param>
        /// <param name="Message">Message</param>
        /// <param name="Result">Result</param>
        public void ExecuteQuery(string Query, string DML_Type, out string Message, ref DataTable Result)
        {
            try
            {
                using (var db = ConnectionState.Instance())
                {
                    OleDbDataAdapter OleDbAdt = new OleDbDataAdapter(Query, db);
                    OleDbCommand Command = new OleDbCommand(Query, db);

                    int QueryResult = 0;
                    string HelpText = string.Empty;

                    string ActionType = DML_Type.ToUpper();

                    switch (ActionType)
                    {
                        case "C":
                            OleDbAdt.InsertCommand = Command;
                            QueryResult = OleDbAdt.InsertCommand.ExecuteNonQuery();
                            break;
                        case "R":
                            DataSet dsResult = new DataSet();

                            QueryResult = OleDbAdt.Fill(dsResult, ActionType);
                            Result = dsResult.Tables[ActionType];
                            break;
                        case "U":
                            OleDbAdt.InsertCommand = Command;
                            QueryResult = OleDbAdt.InsertCommand.ExecuteNonQuery();
                            break;
                        case "D":
                            OleDbAdt.DeleteCommand = Command;
                            QueryResult = OleDbAdt.DeleteCommand.ExecuteNonQuery();
                            break;
                        default:
                            HelpText = "Check Type!";
                            break;
                    }

                    if (HelpText == null)
                    {
                        if (QueryResult > 0)
                        {
                            Message = $"Query OK : {ActionType}";
                        }
                        else
                        {
                            Message = $"Query FAIL : {ActionType}";
                        }
                    }
                    else
                    {
                        Message = HelpText;
                    }

                }
            }
            catch (Exception ex)
            {
                Message = $"EXCEPTION! \\n {ex.Message}";
            }
        }
    }
}