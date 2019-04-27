using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace Utils
{

    // todo: unit tests

    public class DBHelper
    {
        public string _constring = "";
        public SqlConnection _connection;


        public DataTable getTable(string query)
        {

           SqlDataAdapter a = new SqlDataAdapter(query, _connection);
            DataTable dt = new DataTable();
            a.Fill(dt);
            return dt;
        }


        public Dictionary<string, string> dt2Diq(DataTable dt)
        {

            Dictionary<string, string> d = new Dictionary<string, string>();
            foreach (DataRow dr in dt.Rows)
                d.Add(dr[0].ToString(), dr[1].ToString());

            return d;

        }

        public List<string> getList(string query)
        {
            DataTable dt = getTable(query);

            List<string> l = new List<string>();

            foreach (DataRow dr in dt.Rows)
                    l.Add(dr[0].ToString());

            return l;
        }


        public List<string> dt2List(DataTable dt)
        {
            List<string> l = new List<string>();
            foreach (DataRow dr in dt.Rows)
            {
                l.Add(dr[0].ToString());

            }

            return l;

        }


        public void openConnection()
        {
            _connection.ConnectionString = _constring;
            _connection.Open();
        }

        public void closeConnection()
        {
            _connection.Close();
        }



        // connection must be opened and closed manually. 
        public void runCommand(string command)
        {



            var cmd = new SqlCommand(command);
            cmd.Connection = _connection;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("exception: ");
                Console.WriteLine(ex.ToString());
            }

        }



    }

}
