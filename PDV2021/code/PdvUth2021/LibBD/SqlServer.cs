using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace LibBD
{
    public class SqlServer : BD
    {
        //Attribs de SQLserver
        SqlConnection con;
        SqlCommand com;
        //SqlDataReader dr;

        //Conection string
        string connectionString;

        //Constructor
        public SqlServer(string server, string db, string us, string pwd, string port="1433")
        {
            //Initialize attribs
            this.SERVER = server;
            this.DBNAME = db;
            this.US = us;
            this.PWD = pwd;
            this.PORT = port;
            //Concatenates the connectionString
            this.connectionString = $"Server={this.SERVER},{this.PORT};Database={this.DBNAME};User Id={this.US};Password={this.PWD}:";
            //instanciate the connections
            this.con = new SqlConnection(this.connectionString);
        }

        //BD actions
        public override bool Connect()
        {
            bool res = true;
            try
            {
                if (con.State != ConnectionState.Closed)
                    con.Open();
                else if (con.State != ConnectionState.Broken)
                {
                    con.Close(); con.Open();
                }
                //stablish correct executing
                res = true;
            }
            catch(SqlException sqlex)
            {
                BD.ERROR = "SQL Error at opening SqlServer Connection. " + sqlex.Message;
            }
            catch (Exception ex)
            {
                BD.ERROR = "Error at opening SqlServer Connection. " + ex.Message;
            }
            //return the method result
            return res;
        }

        public override bool Disconnect()
        {
            throw new NotImplementedException();
        }

        public override bool create(string table, List<DataCollection> data)
        {
            throw new NotImplementedException();
        }

        public override bool delete(string table, int id)
        {
            throw new NotImplementedException();
        }

        public override List<object> index(string table, OrderBy order)
        {
            throw new NotImplementedException();
        }

        public override List<object> read(List<string> fields, string table, List<SearchCollection> data)
        {
            throw new NotImplementedException();
        }

        public override List<object> read(List<string> fields, string table1, string table2, List<string> onfields, List<SearchCollection> data)
        {
            throw new NotImplementedException();
        }

        public override bool update(string table, List<DataCollection> data, int id)
        {
            throw new NotImplementedException();
        }
    }
}
