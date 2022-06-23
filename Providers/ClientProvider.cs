using CableTVApp.AppCode;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CableTVApp.Provider {
  class ClientProvider {
    private string _ConnString = System.Configuration.ConfigurationSettings.AppSettings["CONNECT"];

    public void InsertClient(string LastName, string FirstName, string Phone) {
      SqlConnection connection = new SqlConnection(_ConnString);
      string query = "INSERT INTO Client (LastName, FirstName, Phone) VALUES(N'" + LastName + "',N'" + FirstName + "', N'" + Phone + "')";
      SqlCommand command = new SqlCommand(query, connection);
      connection.Open();
      command.ExecuteNonQuery();
      connection.Close();
    }

    public Client SelectedClientByClientId(int ClientId) {
      int i = 0;
      Client selectedClient = new Client();
      string sqlExpression = "SELECT * FROM Client WHERE ClientId=" + ClientId.ToString();
      using (SqlConnection connection = new SqlConnection(_ConnString)) {
        connection.Open();
        SqlCommand command = new SqlCommand(sqlExpression, connection);
        SqlDataReader reader = command.ExecuteReader();

        if (reader.HasRows) {
          while (reader.Read()) {

            selectedClient.Number = ++i;
            selectedClient.ClientId = Convert.ToInt32(reader["ClientId"]);
            selectedClient.LastName = reader["LastName"].ToString();
            selectedClient.FirstName = reader["FirstName"].ToString();
            selectedClient.Phone = reader["Phone"].ToString();
          }
        }
        reader.Close();
      }
      return selectedClient;
    }

    public List<Client> GetAllClient() {
      int i = 0;
      List<Client> ClientList = new List<Client>();
      string sqlExpression = "SELECT * FROM Client ORDER BY LastName";
      using (SqlConnection connection = new SqlConnection(_ConnString)) {
        connection.Open();
        SqlCommand command = new SqlCommand(sqlExpression, connection);
        SqlDataReader reader = command.ExecuteReader();

        if (reader.HasRows) {
          while (reader.Read()) {
            Client oneClient = new Client();
            oneClient.Number = ++i;
            oneClient.ClientId = Convert.ToInt32(reader["ClientId"]);
            oneClient.LastName = reader["LastName"].ToString();
            oneClient.FirstName = reader["FirstName"].ToString();
            oneClient.FIO = oneClient.LastName + " " + oneClient.FirstName;
            oneClient.Phone = reader["Phone"].ToString();
            ClientList.Add(oneClient);
          }
        }
        reader.Close();
      }
      if (ClientList.Count == 0) {
        Client noClient = new Client();
        noClient.ClientId = 0;
        noClient.Message = NamesMy.NoDataNames.NoDataInClient;
        ClientList.Add(noClient);
      }

      return ClientList;
    }

    public void UpdateClient(string LastName, string FirstName, string Phone, int ClientId) {
      using (SqlConnection con = new SqlConnection(_ConnString)) {
        using (SqlCommand cmd = new SqlCommand("UPDATE Client SET LastName = @LastName, FirstName = @FirstName, " +
          "Phone = @Phone " +
          " WHERE ClientId = @ClientId", con)) {
          cmd.CommandType = CommandType.Text;
          cmd.Parameters.AddWithValue("@LastName", LastName);
          cmd.Parameters.AddWithValue("@FirstName", FirstName);
          cmd.Parameters.AddWithValue("@Phone", Phone);
          cmd.Parameters.AddWithValue("@ClientId", ClientId);
          con.Open();
          int rowsAffected = cmd.ExecuteNonQuery();
          con.Close();
        }
      }
    }

    public void DeleteClientByClientId(int ClientId) {
      string sqlExpression = "DELETE  FROM Client WHERE ClientId=" + ClientId.ToString();
      using (SqlConnection connection = new SqlConnection(_ConnString)) {
        connection.Open();
        SqlCommand command = new SqlCommand(sqlExpression, connection);
        command.ExecuteNonQuery();
        connection.Close();
      }
    }

  }
}


public class Client {
  private int _Number;
  private int _ClientId;
  private string _FirstName;
  private string _LastName;
  private string _FIO;
  private string _Phone;
  private string _Message;

  public Client() {
    _Number = 0;
    _ClientId = 0;
    _FirstName = String.Empty;
    _LastName = String.Empty;
    _FIO = String.Empty;
    _Phone = String.Empty;
    _Message = String.Empty;
  }

  public int Number {
    set { _Number = value; }
    get { return _Number; }
  }
  public int ClientId {
    set { _ClientId = value; }
    get { return _ClientId; }
  }
  public string FirstName {
    set { _FirstName = value; }
    get { return _FirstName; }
  }
  public string LastName {
    set { _LastName = value; }
    get { return _LastName; }
  }
  public string FIO {
    set { _FIO = value; }
    get { return _FIO; }
  }
  public string Phone {
    set { _Phone = value; }
    get { return _Phone; }
  }
  public string Message {
    set { _Message = value; }
    get { return _Message; }
  }
}
