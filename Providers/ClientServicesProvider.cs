using CableTVApp.AppCode;
using CableTVApp.Provider;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CableTVApp.Providers {
  class ClientServicesProvider {
    ServicesProvider _ServicesProvider = new ServicesProvider();
    ClientProvider _ClientProvider = new ClientProvider();

    private string _ConnString = System.Configuration.ConfigurationSettings.AppSettings["CONNECT"];

    public void InsertClientServices(int ClientId, int ServicesId) {
      SqlConnection connection = new SqlConnection(_ConnString);

      string query = "INSERT INTO ClientServices (ClientId, ServicesId) ";
      query += String.Format("VALUES({0}, {1})", ClientId, ServicesId);
      SqlCommand command = new SqlCommand(query, connection);
      connection.Open();
      command.ExecuteNonQuery();
      connection.Close();
    }

    public List<ClientServices> GetAllClientServices() {
      int j = 0;
      List<ClientServices> ClientServicesList = new List<ClientServices>();
      List<Client> clientList = new List<Client>();
      clientList = _ClientProvider.GetAllClient();

      string sqlExpression = "SELECT ClientServices.ClientServicesId, ClientServices.ClientId, ClientServices.ServicesId," +
        " Services.ServicesName, Services.Price  FROM ClientServices " +
        "INNER JOIN Services " +
        " ON Services.ServicesId = ClientServices.ServicesId";
      using (SqlConnection connection = new SqlConnection(_ConnString)) {
        connection.Open();
        SqlCommand command = new SqlCommand(sqlExpression, connection);
        SqlDataReader reader = command.ExecuteReader();

        if (reader.HasRows) {
          while (reader.Read()) {
            ClientServices selectedClientServices = new ClientServices();
            selectedClientServices.Number = ++j;
            selectedClientServices.ClientServicesId = Convert.ToInt32(reader["ClientServicesId"]);
            selectedClientServices.ClientId = Convert.ToInt32(reader["ClientId"]);
            selectedClientServices.ServicesId = Convert.ToInt32(reader["ServicesId"]);
            selectedClientServices.ServicesName = reader["ServicesName"].ToString();
            selectedClientServices.Price = Convert.ToDouble(reader["Price"]);
            ClientServicesList.Add(selectedClientServices);
          }
        }
        reader.Close();
      }
      if (ClientServicesList.Count == 0) {
        ClientServices noClientServices = new ClientServices();
        noClientServices.ClientServicesId = 0;
        noClientServices.Message = NamesMy.NoDataNames.NoDataInClientServices;
        ClientServicesList.Add(noClientServices);
      } else {
        for (int i = 0; i < ClientServicesList.Count; i++) {
          ClientServicesList[i].FIO = GetFIOName(ClientServicesList[i].ClientId, clientList);
        }
      }

      return ClientServicesList;
    }


    public List<ClientServices> GetAllClientServicesByClientId(int ClientId) {
      int j = 0;
      List<ClientServices> ClientServicesList = new List<ClientServices>();

      string sqlExpression = "SELECT ClientServices.ClientServicesId, ClientServices.ClientId, ClientServices.ServicesId, Services.ServicesName, Services.Price  FROM ClientServices " +
        "INNER JOIN Services " +
        " ON Services.ServicesId = ClientServices.ServicesId" +
        " WHERE ClientId=" + ClientId;
      using (SqlConnection connection = new SqlConnection(_ConnString)) {
        connection.Open();
        SqlCommand command = new SqlCommand(sqlExpression, connection);
        SqlDataReader reader = command.ExecuteReader();

        if (reader.HasRows) {
          while (reader.Read()) {
            ClientServices selectedClientServices = new ClientServices();
            selectedClientServices.Number = ++j;
            selectedClientServices.ClientServicesId = Convert.ToInt32(reader["ClientServicesId"]);
            selectedClientServices.ClientId = Convert.ToInt32(reader["ClientId"]);
            selectedClientServices.ServicesId = Convert.ToInt32(reader["ServicesId"]);
            selectedClientServices.ServicesName = reader["ServicesName"].ToString();
            selectedClientServices.Price = Convert.ToDouble(reader["Price"]);
            ClientServicesList.Add(selectedClientServices);
          }
        }
        reader.Close();
      }

      if (ClientServicesList.Count == 0) {
        ClientServices noClientServices = new ClientServices();
        noClientServices.ClientServicesId = 0;
        noClientServices.Message = NamesMy.NoDataNames.NoDataInClientServices;
        ClientServicesList.Add(noClientServices);
      }

      return ClientServicesList;
    }

    public void DeleteClientServicesByClientServicesId(int ClientServicesId) {
      string sqlExpression = "DELETE  FROM ClientServices WHERE ClientServicesId=" + ClientServicesId.ToString();
      using (SqlConnection connection = new SqlConnection(_ConnString)) {
        connection.Open();
        SqlCommand command = new SqlCommand(sqlExpression, connection);
        command.ExecuteNonQuery();
        connection.Close();
      }
    }


    private string GetServicesName(int ServicesId, List<Services> ServicesList) {
      for (int i = 0; i < ServicesList.Count; i++) {
        if (ServicesId == ServicesList[i].ServicesId) {
          return ServicesList[i].ServicesName;
        }
      }
      return "";
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


public class ClientServices {
  private int _Number;
  private int _ClientServicesId;
  private int _ClientId;
  private string _FIO;
  private int _ServicesId;
  private string _ServicesName;
  private double _Price;
  private string _Message;

  public ClientServices() {
    _Number = 0;
    _ClientServicesId = 0;
    _ClientId = 0;
    _FIO = String.Empty;
    _ServicesId = 0;
    _ServicesName = String.Empty;
    _Price = 0;
    _Message = String.Empty;
  }

  public int Number {
    set { _Number = value; }
    get { return _Number; }
  }
  public int ClientServicesId {
    set { _ClientServicesId = value; }
    get { return _ClientServicesId; }
  }
  public int ClientId {
    set { _ClientId = value; }
    get { return _ClientId; }
  }
  public string FIO {
    set { _FIO = value; }
    get { return _FIO; }
  }
  public int ServicesId {
    set { _ServicesId = value; }
    get { return _ServicesId; }
  }
  public string ServicesName {
    set { _ServicesName = value; }
    get { return _ServicesName; }
  }
  public double Price {
    set { _Price = value; }
    get { return _Price; }
  }
  public string Message {
    set { _Message = value; }
    get { return _Message; }
  }
}
