using CableTVApp.AppCode;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CableTVApp.Providers {
  class PayPeriodProvider {
    private string _ConnString = System.Configuration.ConfigurationSettings.AppSettings["CONNECT"];

    public void InsertPayPeriod(string PayPeriodName, string Description, DateTime PayDate) {
      SqlConnection connection = new SqlConnection(_ConnString);
      string query = "INSERT INTO PayPeriod (PayPeriodName, Description, PayDate) ";
      query += String.Format("VALUES(N'{0}', N'{1}', '{2}')", PayPeriodName, Description, PayDate.ToString("yyyy-MM-dd HH:mm:ss"));
      SqlCommand command = new SqlCommand(query, connection);
      connection.Open();
      command.ExecuteNonQuery();
      connection.Close();
    }

    public PayPeriod SelectedPayPeriodByPayPeriodId(int PayPeriodId) {
      int i = 0;
      PayPeriod selectedPayPeriod = new PayPeriod();
      string sqlExpression = "SELECT * FROM PayPeriod WHERE PayPeriodId=" + PayPeriodId.ToString();
      using (SqlConnection connection = new SqlConnection(_ConnString)) {
        connection.Open();
        SqlCommand command = new SqlCommand(sqlExpression, connection);
        SqlDataReader reader = command.ExecuteReader();

        if (reader.HasRows) {
          while (reader.Read()) {
            selectedPayPeriod.Number = ++i;
            selectedPayPeriod.PayPeriodId = Convert.ToInt32(reader["PayPeriodId"]);
            selectedPayPeriod.PayPeriodName = reader["PayPeriodName"].ToString();
            selectedPayPeriod.Description = reader["Description"].ToString();
            selectedPayPeriod.PayDate = Convert.ToDateTime(reader["PayDate"]);
          }
        }
        reader.Close();
      }
      return selectedPayPeriod;
    }

    public List<PayPeriod> GetAllPayPeriod() {
      int i = 0;
      List<PayPeriod> PayPeriodList = new List<PayPeriod>();
      string sqlExpression = "SELECT * FROM PayPeriod";
      using (SqlConnection connection = new SqlConnection(_ConnString)) {
        connection.Open();
        SqlCommand command = new SqlCommand(sqlExpression, connection);
        SqlDataReader reader = command.ExecuteReader();

        if (reader.HasRows) {
          while (reader.Read()) {
            PayPeriod selectedPayPeriod = new PayPeriod();
            selectedPayPeriod.Number = ++i;
            selectedPayPeriod.PayPeriodId = Convert.ToInt32(reader["PayPeriodId"]);
            selectedPayPeriod.PayPeriodName = reader["PayPeriodName"].ToString();
            selectedPayPeriod.Description = reader["Description"].ToString();
            selectedPayPeriod.PayDate = Convert.ToDateTime(reader["PayDate"]);
            PayPeriodList.Add(selectedPayPeriod);
          }
        }
        reader.Close();
      }
      if (PayPeriodList.Count == 0) {
        PayPeriod noPayPeriod = new PayPeriod();
        noPayPeriod.PayPeriodId = 0;
        noPayPeriod.Message = NamesMy.NoDataNames.NoDataInPayPeriod;
        PayPeriodList.Add(noPayPeriod);
      }

      return PayPeriodList;
    }

    public void UpdatePayPeriod(string PayPeriodName, string Description, int PayPeriodId) {
      using (SqlConnection con = new SqlConnection(_ConnString)) {
        using (SqlCommand cmd = new SqlCommand("UPDATE PayPeriod SET PayPeriodName = @PayPeriodName, Description = @Description " +
          " WHERE PayPeriodId = @PayPeriodId", con)) {
          cmd.CommandType = CommandType.Text;
          cmd.Parameters.AddWithValue("@PayPeriodName", PayPeriodName);
          cmd.Parameters.AddWithValue("@Description", Description);
          cmd.Parameters.AddWithValue("@PayPeriodId", PayPeriodId);
          con.Open();
          int rowsAffected = cmd.ExecuteNonQuery();
          con.Close();
        }
      }
    }

    public void DeletePayPeriodByPayPeriodId(int PayPeriodId) {
      string sqlExpression = "DELETE  FROM PayPeriod WHERE PayPeriodId=" + PayPeriodId.ToString();
      using (SqlConnection connection = new SqlConnection(_ConnString)) {
        connection.Open();
        SqlCommand command = new SqlCommand(sqlExpression, connection);
        command.ExecuteNonQuery();
        connection.Close();
      }
    }

    public int GetLastRecords() {
      int lastRecordNumber = 0;
      string sqlExpression = "Select MAX (PayPeriodId) From PayPeriod";
      using (SqlConnection connection = new SqlConnection(_ConnString)) {
        connection.Open();
        SqlCommand command = new SqlCommand(sqlExpression, connection);
        SqlDataReader reader = command.ExecuteReader();

        if (reader.HasRows) {
          while (reader.Read()) {
            lastRecordNumber = Convert.ToInt32(reader.GetValue(0));
          }
        }
        reader.Close();
      }
      return lastRecordNumber;
    }

  
  }
}


public class PayPeriod {
  private int _Number;
  private int _PayPeriodId;
  private string _PayPeriodName;
  private string _Description;
  private DateTime _PayDate;
  private string _Message;

  public PayPeriod() {
    _Number = 0;
    _PayPeriodId = 0;
    _PayPeriodName = String.Empty;
    _Description = String.Empty;
    _PayDate = new DateTime();
    _Message = String.Empty;
  }

  public int Number {
    set { _Number = value; }
    get { return _Number; }
  }
  public int PayPeriodId {
    set { _PayPeriodId = value; }
    get { return _PayPeriodId; }
  }
  public string PayPeriodName {
    set { _PayPeriodName = value; }
    get { return _PayPeriodName; }
  }
  public string Description {
    set { _Description = value; }
    get { return _Description; }
  }
  public DateTime PayDate {
    set { _PayDate = value; }
    get { return _PayDate; }
  }
  public string Message {
    set { _Message = value; }
    get { return _Message; }
  }
}
