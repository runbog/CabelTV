using CableTVApp.AppCode;
using CableTVApp.Provider;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CableTVApp.Providers {
  class ClientProgramsProvider {
    ProgramsProvider _ProgramsProvider = new ProgramsProvider();
    ClientProvider _ClientProvider = new ClientProvider();

    private string _ConnString = System.Configuration.ConfigurationSettings.AppSettings["CONNECT"];

    public void InsertClientPrograms(int ClientId, int ProgramsId) {
      SqlConnection connection = new SqlConnection(_ConnString);

      string query = "INSERT INTO ClientPrograms (ClientId, ProgramsId) ";
      query += String.Format("VALUES({0}, {1})", ClientId, ProgramsId);
      SqlCommand command = new SqlCommand(query, connection);
      connection.Open();
      command.ExecuteNonQuery();
      connection.Close();
    }

    public List<ClientPrograms> GetAllClientPrograms( ) {
      int j = 0;
      List<ClientPrograms> ClientProgramsList = new List<ClientPrograms>();
      List<Client> clientList = new List<Client>();
      clientList = _ClientProvider.GetAllClient();

      string sqlExpression = "SELECT ClientPrograms.ClientProgramsId, ClientPrograms.ClientId, ClientPrograms.ProgramsId, Programs.ProgramsName, Programs.Price  FROM ClientPrograms " +
        "INNER JOIN Programs " +
        " ON Programs.ProgramsId = ClientPrograms.ProgramsId";
      using (SqlConnection connection = new SqlConnection(_ConnString)) {
        connection.Open();
        SqlCommand command = new SqlCommand(sqlExpression, connection);
        SqlDataReader reader = command.ExecuteReader();

        if (reader.HasRows) {
          while (reader.Read()) {
            ClientPrograms selectedClientPrograms = new ClientPrograms();
            selectedClientPrograms.Number = ++j;
            selectedClientPrograms.ClientProgramsId = Convert.ToInt32(reader["ClientProgramsId"]);
            selectedClientPrograms.ClientId = Convert.ToInt32(reader["ClientId"]);
            selectedClientPrograms.ProgramsId = Convert.ToInt32(reader["ProgramsId"]);
            selectedClientPrograms.ProgramsName = reader["ProgramsName"].ToString();
            selectedClientPrograms.Price = Convert.ToDouble(reader["Price"]);
            ClientProgramsList.Add(selectedClientPrograms);
          }
        }
        reader.Close();
      }
      if (ClientProgramsList.Count == 0) {
        ClientPrograms noClientPrograms = new ClientPrograms();
        noClientPrograms.ClientProgramsId = 0;
        noClientPrograms.Message = NamesMy.NoDataNames.NoDataInClientPrograms;
        ClientProgramsList.Add(noClientPrograms);
      } else {
        for (int i = 0; i < ClientProgramsList.Count; i++) {
          ClientProgramsList[i].FIO = GetFIOName(ClientProgramsList[i].ClientId, clientList);
        }
      }

      return ClientProgramsList;
    }


    public List<ClientPrograms> GetAllClientProgramsByClientId(int ClientId) {
      int j = 0;
      List<ClientPrograms> ClientProgramsList = new List<ClientPrograms>();

      string sqlExpression = "SELECT ClientPrograms.ClientProgramsId, ClientPrograms.ClientId, ClientPrograms.ProgramsId, Programs.ProgramsName, Programs.Price  FROM ClientPrograms " +
        "INNER JOIN Programs " +
        " ON Programs.ProgramsId = ClientPrograms.ProgramsId" +
        " WHERE ClientId=" + ClientId;
      using (SqlConnection connection = new SqlConnection(_ConnString)) {
        connection.Open();
        SqlCommand command = new SqlCommand(sqlExpression, connection);
        SqlDataReader reader = command.ExecuteReader();

        if (reader.HasRows) {
          while (reader.Read()) {
            ClientPrograms selectedClientPrograms = new ClientPrograms();
            selectedClientPrograms.Number = ++j;
            selectedClientPrograms.ClientProgramsId = Convert.ToInt32(reader["ClientProgramsId"]);
            selectedClientPrograms.ClientId = Convert.ToInt32(reader["ClientId"]);
            selectedClientPrograms.ProgramsId = Convert.ToInt32(reader["ProgramsId"]);
            selectedClientPrograms.ProgramsName = reader["ProgramsName"].ToString();
            selectedClientPrograms.Price = Convert.ToDouble(reader["Price"]);
            ClientProgramsList.Add(selectedClientPrograms);
          }
        }
        reader.Close();
      }

      if (ClientProgramsList.Count == 0) {
        ClientPrograms noClientPrograms = new ClientPrograms();
        noClientPrograms.ClientProgramsId = 0;
        noClientPrograms.Message = NamesMy.NoDataNames.NoDataInClientPrograms;
        ClientProgramsList.Add(noClientPrograms);
      }

      return ClientProgramsList;
    }

    private string GetProgramsName(int ProgramsId, List<Programs> ProgramsList) {
      for (int i = 0; i < ProgramsList.Count; i++) {
        if (ProgramsId == ProgramsList[i].ProgramsId) {
          return ProgramsList[i].ProgramsName;
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

    public void DeleteClientProgramsByClientProgramsId(int ClientProgramsId) {
      string sqlExpression = "DELETE  FROM ClientPrograms WHERE ClientProgramsId=" + ClientProgramsId.ToString();
      using (SqlConnection connection = new SqlConnection(_ConnString)) {
        connection.Open();
        SqlCommand command = new SqlCommand(sqlExpression, connection);
        command.ExecuteNonQuery();
        connection.Close();
      }
    }

  }
}

public class ClientPrograms {
  private int _Number;
  private int _ClientProgramsId;
  private int _ClientId;
  private string _FIO;
  private int _ProgramsId;
  private string _ProgramsName;
  private double _Price;
  private string _Message;

  public ClientPrograms() {
    _Number = 0;
    _ClientProgramsId = 0;
    _ClientId = 0;
    _FIO = String.Empty;
    _ProgramsId = 0;
    _ProgramsName = String.Empty;
    _Price = 0;
    _Message = String.Empty;
  }

  public int Number {
    set { _Number = value; }
    get { return _Number; }
  }
  public int ClientProgramsId {
    set { _ClientProgramsId = value; }
    get { return _ClientProgramsId; }
  }
  public int ClientId {
    set { _ClientId = value; }
    get { return _ClientId; }
  }
  public string FIO {
    set { _FIO = value; }
    get { return _FIO; }
  }
  public int ProgramsId {
    set { _ProgramsId = value; }
    get { return _ProgramsId; }
  }
  public string ProgramsName {
    set { _ProgramsName = value; }
    get { return _ProgramsName; }
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
