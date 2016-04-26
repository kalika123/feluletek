using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Projekt
{
    class DAL
    {

       private static DAL _instance = null;
       private SqlConnection _con = null;
       private SqlCommand _cmd = null;
        //jhjhjhjghhg
       private DAL() {

               _con = new SqlConnection();
               _cmd = new SqlCommand();
               
       }

       public bool connect()
       {
           try
           {
               _con.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\SAPIENTIA\Feluletek\Projekt\Projekt\Database1.mdf;Integrated Security=True";
               _con.Open();

           }
           catch (Exception ex)
           {
               Console.WriteLine("hiba " +  ex.Message);
               return false;
           }
           return true;
           
       }

       public void close()
       {
           _con.Close();
       }

       public int getUser(string usrname, string passw)
       {
           SqlDataReader reader;

           _cmd.CommandText = "SELECT Id FROM users WHERE username = '" + usrname + "' AND password = '" + passw + "'";
           _cmd.CommandType = CommandType.Text;
           _cmd.Connection = _con;

           reader = _cmd.ExecuteReader();
           int tempId = -1;
           while (reader.Read())
           {
               tempId = reader.GetInt32(0);
           }

           reader.Close();
         
           return tempId;
       }

       public List<Task> getTasks(int id)
       {
           List<Task> tasks = new List<Task>();
           SqlDataReader reader;

           _cmd.CommandText = "SELECT * FROM Tasks WHERE usrid = '" + id + "'";
           _cmd.CommandType = CommandType.Text;
           _cmd.Connection = _con;

           reader = _cmd.ExecuteReader();
           Task task = new Task() ;
           while (reader.Read())
           {

               Console.WriteLine(reader["Priority"].ToString());
               task.title = reader["Title"].ToString();
               task.descript = reader["Description"].ToString();
               string priority = reader["Priority"].ToString();
               task.setPriority(Convert.ToInt32(priority));
               tasks.Add(task);
           }

           reader.Close();

           Console.WriteLine(tasks.ToString());
           return tasks;

       }

       public bool isConnected()
       {
           if ((_con != null) && (_con.State == ConnectionState.Open))
               return true;
           return false;
       }

       public static DAL getInstance(){
           if (_instance == null)
           {
               _instance = new DAL();
           }
           return _instance;
       }

       

    }
}
