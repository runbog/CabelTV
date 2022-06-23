using CableTVApp.AppCode;
using CableTVApp.Provider;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CableTVApp.Providers {
  class ClientPayProvider {
    ClientProvider _ClientProvider = new ClientProvider();
    private string _ConnString = System.Configuration.ConfigurationSettings.AppSettings["CONNECT"];
    public void InsertBatchService(List<ClientPay> ClientPayList) {
      using (SqlConnection con = new SqlConnection(_ConnString)) {
        con.Open();
        for (int i = 0; i < ClientPayList.Count; i++) {
          using (SqlCommand cmd = new SqlCommand("INSERT INTO ClientPay (PayPeriodId, PayNecessary, Paid, ClientId)" +
            " VALUES(@PayPeriodId, @PayNecessary, @Paid, @ClientId)", con)) {
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@PayPeriodId", ClientPayList[i].PayPeriodId);
            cmd.Parameters.AddWithValue("@PayNecessary", ClientPayList[i].PayNecessary);
            cmd.Parameters.AddWithValue("@Paid", ClientPayList[i].Paid);
            cmd.Parameters.AddWithValue("@ClientId", ClientPayList[i].ClientId);
            cmd.ExecuteNonQuery();
            while (cmd.Parameters.Count > 0) {
              cmd.Parameters.RemoveAt(0);
            }
          }
        }
        con.Close();
      }
    }

    public List<ClientPay> GetAllPayForOneClient(int ClientId) {
      int i = 0;
      List<ClientPay> ServiceList = new List<ClientPay>();
      string sqlExpression = "SELECT * FROM ClientPay WHERE ClientId=" + ClientId;
      using (SqlConnection connection = new SqlConnection(_ConnString)) {
        connection.Open();
        SqlCommand command = new SqlCommand(sqlExpression, connection);
        SqlDataReader reader = command.ExecuteReader();

        if (reader.HasRows) {
          while (reader.Read()) {
            ClientPay selectedService = new ClientPay();
            selectedService.Number = ++i;
            selectedService.ClientPayId = Convert.ToInt32(reader["ClientPayId"]);
            selectedService.PayPeriodId = Convert.ToInt32(reader["PayPeriodId"]);
            selectedService.PayNecessary = Convert.ToDouble(reader["PayNecessary"]);
            selectedService.Paid = Convert.ToDouble(reader["Paid"]);
            selectedService.ClientId = Convert.ToInt32(reader["ClientId"]);
            ServiceList.Add(selectedService);
          }
        }
        reader.Close();
      }
      return ServiceList;
    }


    public double GetAllPay() {
      double pay = 0.0;
      List<ClientPay> ServiceList = new List<ClientPay>();
      string sqlExpression = "SELECT * FROM ClientPay ";
      using (SqlConnection connection = new SqlConnection(_ConnString)) {
        connection.Open();
        SqlCommand command = new SqlCommand(sqlExpression, connection);
        SqlDataReader reader = command.ExecuteReader();

        if (reader.HasRows) {
          while (reader.Read()) {
            pay += Convert.ToDouble(reader["Paid"]);
          }
        }
        reader.Close();
      }
      return pay;
    }


    public List<ClientPay> GetAllClientPay(int PayPeriodId) {
      int i = 0;
      List<Client> clientList = new List<Client>();
      clientList = _ClientProvider.GetAllClient();
      List<ClientPay> ServiceList = new List<ClientPay>();
      string sqlExpression = "SELECT * FROM ClientPay WHERE PayPeriodId=" + PayPeriodId;
      using (SqlConnection connection = new SqlConnection(_ConnString)) {
        connection.Open();
        SqlCommand command = new SqlCommand(sqlExpression, connection);
        SqlDataReader reader = command.ExecuteReader();

        if (reader.HasRows) {
          while (reader.Read()) {
            ClientPay selectedService = new ClientPay();
            selectedService.Number = ++i;
            selectedService.ClientPayId = Convert.ToInt32(reader["ClientPayId"]);
            selectedService.PayPeriodId = Convert.ToInt32(reader["PayPeriodId"]);
            selectedService.PayNecessary = Convert.ToDouble(reader["PayNecessary"]);
            selectedService.Paid = Convert.ToDouble(reader["Paid"]);
            selectedService.ClientId = Convert.ToInt32(reader["ClientId"]);
            ServiceList.Add(selectedService);
          }
        }
        reader.Close();
      }
      if (ServiceList.Count == 0) {
        ClientPay noService = new ClientPay();
        noService.ClientPayId = 0;
        noService.Message = NamesMy.NoDataNames.NoDataInClientPay;
        ServiceList.Add(noService);
      } else {
        for (int j = 0; j < ServiceList.Count; j++) {
          ServiceList[j].FIO = GetFIOName(ServiceList[j].ClientId, clientList);
        }
      }
        return ServiceList;
    }

    public void UpdateBatchService(List<ClientPay> ClientPayList) {
      using (SqlConnection con = new SqlConnection(_ConnString)) {
        con.Open();
        for (int i = 0; i < ClientPayList.Count; i++) {
          using (SqlCommand cmd = new SqlCommand("UPDATE ClientPay SET PayPeriodId=@PayPeriodId, PayNecessary=@PayNecessary," +
          " Paid = @Paid, ClientId=@ClientId " +
          " WHERE ClientPayId = @ClientPayId", con)) {
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@PayPeriodId", ClientPayList[i].PayPeriodId);
            cmd.Parameters.AddWithValue("@PayNecessary", ClientPayList[i].PayNecessary);
            cmd.Parameters.AddWithValue("@Paid", ClientPayList[i].Paid);
            cmd.Parameters.AddWithValue("@ClientId", ClientPayList[i].ClientId);
            cmd.Parameters.AddWithValue("@ClientPayId", ClientPayList[i].ClientPayId);
            cmd.ExecuteNonQuery();
            while (cmd.Parameters.Count > 0) {
              cmd.Parameters.RemoveAt(0);
            }
          }
        }
        con.Close();
      }
    }


    public void DeleteClientPayByPayPeriodId(int PayPeriodId) {
      string sqlExpression = "DELETE  FROM ClientPay WHERE PayPeriodId=" + PayPeriodId.ToString();
      using (SqlConnection connection = new SqlConnection(_ConnString)) {
        connection.Open();
        SqlCommand command = new SqlCommand(sqlExpression, connection);
        command.ExecuteNonQuery();
        connection.Close();
      }
    }

    private string GetFIOName(int ClientId, List<Client> ClientList) {
      for (int i = 0; i < ClientList.Count; i++) {
        if (ClientId == ClientList[i].ClientId) {
          return ClientList[i].FIO;
        }
      }
      return "";
    }
  }
}


public class ClientPay {
  private int _Number;
  private int _ClientPayId;
  private int _PayPeriodId;
  private double _PayNecessary;
  private double _Paid;
  private string _FIO;
  private int _ClientId;
  private DateTime _PayDate;
  private string _Message;

  public ClientPay() {
    _Number = 0;
    _ClientPayId = 0;
    _PayPeriodId = 0;
    _PayNecessary = 0;
    _ClientId = 0;
    _FIO = String.Empty;
    _Paid = 0;
    _PayDate = new DateTime();
    _Message = String.Empty;
  }

  public int Number {
    set { _Number = value; }
    get { return _Number; }
  }
  public int ClientPayId {
    set { _ClientPayId = value; }
    get { return _ClientPayId; }
  }
  public int PayPeriodId {
    set { _PayPeriodId = value; }
    get { return _PayPeriodId; }
  }
  public double PayNecessary {
    set { _PayNecessary = value; }
    get { return _PayNecessary; }
  }
  public int ClientId {
    set { _ClientId = value; }
    get { return _ClientId; }
  }
  public string FIO {
    set { _FIO = value; }
    get { return _FIO; }
  }
  public double Paid {
    set { _Paid = value; }
    get { return _Paid; }
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

