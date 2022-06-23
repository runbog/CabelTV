using CableTVApp.AppCode;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CableTVApp.Provider {
  class ServicesProvider {
    private string _ConnString = System.Configuration.ConfigurationSettings.AppSettings["CONNECT"];

    public void InsertService(string ServicesName, double Price, string Description) {
      SqlConnection connection = new SqlConnection(_ConnString);

      string query = "INSERT INTO Services (ServicesName, Price, Description) ";
      query += String.Format("VALUES(N'{0}', {1}, N'{2}')",
        ServicesName, Price.ToString().Replace(",", "."), Description);
      SqlCommand command = new SqlCommand(query, connection);
      connection.Open();
      command.ExecuteNonQuery();
      connection.Close();
    }

    public Services SelectedServiceByServicesId(int ServicesId) {
      Services selectedService = new Services();
      string sqlExpression = "SELECT * FROM Services WHERE ServicesId=" + ServicesId.ToString();
      using (SqlConnection connection = new SqlConnection(_ConnString)) {
        connection.Open();
        SqlCommand command = new SqlCommand(sqlExpression, connection);
        SqlDataReader reader = command.ExecuteReader();

        if (reader.HasRows) {
          while (reader.Read()) {
            selectedService.ServicesId = Convert.ToInt32(reader["ServicesId"]);
            selectedService.Description = reader["Description"].ToString();
            selectedService.Price = Convert.ToDouble(reader["Price"]);
            selectedService.ServicesName = reader["ServicesName"].ToString();
          }
        }
        reader.Close();
      }
      return selectedService;
    }

    public List<Services> GetAllService() {
      int i = 0;
      List<Services> ServiceList = new List<Services>();
      string sqlExpression = "SELECT * FROM Services";
      using (SqlConnection connection = new SqlConnection(_ConnString)) {
        connection.Open();
        SqlCommand command = new SqlCommand(sqlExpression, connection);
        SqlDataReader reader = command.ExecuteReader();

        if (reader.HasRows) {
          while (reader.Read()) {
            Services selectedService = new Services();
            selectedService.Number = ++i;
            selectedService.ServicesId = Convert.ToInt32(reader["ServicesId"]);
            selectedService.Description = reader["Description"].ToString();
            selectedService.Price = Convert.ToDouble(reader["Price"]);
            selectedService.ServicesName = reader["ServicesName"].ToString();
            ServiceList.Add(selectedService);
          }
        }
        reader.Close();
      }
      if (ServiceList.Count == 0) {
        Services noService = new Services();
        noService.ServicesId = 0;
        noService.Message = NamesMy.NoDataNames.NoDataInServices;
        ServiceList.Add(noService);
      }

      return ServiceList;
    }

    public void UpdateService(string ServicesName, double Price, string Description, int ServicesId) {
      using (SqlConnection con = new SqlConnection(_ConnString)) {
        using (SqlCommand cmd = new SqlCommand("UPDATE Services SET ServicesName=@ServicesName, Price=@Price," +
          " Description = @Description  " +
          " WHERE ServicesId = @ServicesId", con)) {
          cmd.CommandType = CommandType.Text;
          cmd.Parameters.AddWithValue("@ServicesName", ServicesName);
          cmd.Parameters.AddWithValue("@Price", Price.ToString().Replace(",", "."));
          cmd.Parameters.AddWithValue("@Description", Description);
          cmd.Parameters.AddWithValue("@ServicesId", ServicesId);
          con.Open();
          int rowsAffected = cmd.ExecuteNonQuery();
          con.Close();
        }
      }
    }

    public void DeleteServiceByServicesId(int ServicesId) {
      string sqlExpression = "DELETE  FROM Services WHERE ServicesId=" + ServicesId.ToString();
      using (SqlConnection connection = new SqlConnection(_ConnString)) {
        connection.Open();
        SqlCommand command = new SqlCommand(sqlExpression, connection);
        command.ExecuteNonQuery();
        connection.Close();
      }
    }

    public int GetLastRecords() {
      int lastRecordNumber = 0;
      string SqlString = "Select MAX (ServicesId) From Services ";
      using (SqlConnection conn = new SqlConnection(_ConnString)) {
        using (SqlCommand cmd = new SqlCommand(SqlString, conn)) {
          conn.Open();
          using (SqlDataReader reader = cmd.ExecuteReader()) {
            while (reader.Read()) {
              lastRecordNumber = Convert.ToInt32(reader.GetValue(0));
            }
          }
        }
        conn.Close();
      }
      return lastRecordNumber;
    }

  }
}


public class Services {
  private int _Number;
  private int _ServicesId;
  private string _ServicesName;
  private double _Price;
  private string _Description;
  private string _Message;

  public Services() {
    _Number = 0;
    _ServicesId = 0;
    _Description = String.Empty;
    _Price = 0.0;
    _ServicesName = String.Empty;
    _Message = String.Empty;
  }

  public int Number {
    set { _Number = value; }
    get { return _Number; }
  }
  public int ServicesId {
    set { _ServicesId = value; }
    get { return _ServicesId; }
  }
  public string Description {
    set { _Description = value; }
    get { return _Description; }
  }
  public double Price {
    set { _Price = value; }
    get { return _Price; }
  }
  public string ServicesName {
    set { _ServicesName = value; }
    get { return _ServicesName; }
  }
  public string Message {
    set { _Message = value; }
    get { return _Message; }
  }
}
