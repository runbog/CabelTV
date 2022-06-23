using CableTVApp.AppCode;
using CableTVApp.Providers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CableTVApp.Provider {
  class ServicesLProvider {
    private FilmsProvider _FilmsProvider = new FilmsProvider();
    private string _ConnString = System.Configuration.ConfigurationSettings.AppSettings["CONNECT"];
    public void InsertBatchService(List<ServicesL> ServicesLList) {
      using (SqlConnection con = new SqlConnection(_ConnString)) {
        con.Open();
        for (int i=0; i<ServicesLList.Count; i++) {
          using (SqlCommand cmd = new SqlCommand("INSERT INTO ServicesL (ServicesId, FilmsId) VALUES(@ServicesId, @FilmsId)", con)) {
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@ServicesId", ServicesLList[i].ServicesId);
            cmd.Parameters.AddWithValue("@FilmsId", ServicesLList[i].FilmsId);
            cmd.ExecuteNonQuery();
            while (cmd.Parameters.Count > 0) {
              cmd.Parameters.RemoveAt(0);
            }
          }
        }
        con.Close();
      }
    }

    public List<ServicesL> GetAllServiceLByServicesId(int ServicesId) {
      int i = 0;
      List<Films> filmsList = new List<Films>();
      filmsList = _FilmsProvider.GetAllFilms();

      List<ServicesL> ServicesLList = new List<ServicesL>();
      string sqlExpression = "SELECT * FROM ServicesL WHERE ServicesId=" + ServicesId;
      using (SqlConnection connection = new SqlConnection(_ConnString)) {
        connection.Open();
        SqlCommand command = new SqlCommand(sqlExpression, connection);
        SqlDataReader reader = command.ExecuteReader();

        if (reader.HasRows) {
          while (reader.Read()) {
            ServicesL selectedServicesL = new ServicesL();
            selectedServicesL.Number = ++i;
            selectedServicesL.ServicesLId = Convert.ToInt32(reader["ServicesLId"]);
            selectedServicesL.ServicesId = Convert.ToInt32(reader["ServicesId"]);
            selectedServicesL.FilmsId = Convert.ToInt32(reader["FilmsId"]);
            ServicesLList.Add(selectedServicesL);
          }
        }
        reader.Close();
      }

      if (ServicesLList.Count == 0) {
        ServicesL noServicesL = new ServicesL();
        noServicesL.ServicesLId = 0;
        noServicesL.Message = NamesMy.NoDataNames.NoDataInLServices;
        ServicesLList.Add(noServicesL);
      } else {
        for (int j = 0; j < ServicesLList.Count; i++) {
          ServicesLList[i].FilmsName = GetFilmsName(ServicesLList[i].FilmsId, filmsList);
          ServicesLList[i].Price = GetPrice(ServicesLList[i].FilmsId, filmsList);
        }
      }


      return ServicesLList;
    }

    private string GetFilmsName(int FilmsId, List<Films> FilmsList) {
      for (int i = 0; i < FilmsList.Count; i++) {
        if (FilmsId == FilmsList[i].FilmsId) {
          return FilmsList[i].FilmsName;
        }
      }
      return "";
    }

    private double GetPrice(int FilmsId, List<Films> FilmsList) {
      for (int i = 0; i < FilmsList.Count; i++) {
        if (FilmsId == FilmsList[i].FilmsId) {
          return FilmsList[i].Price;
        }
      }
      return 0.0;
    }

    public void DeleteServiceLByServicesId(int ServicesId) {
      string sqlExpression = "DELETE  FROM ServicesL WHERE ServicesId=" + ServicesId.ToString();
      using (SqlConnection connection = new SqlConnection(_ConnString)) {
        connection.Open();
        SqlCommand command = new SqlCommand(sqlExpression, connection);
        command.ExecuteNonQuery();
        connection.Close();
      }
    }

    public void DeleteServiceL(int ServicesLId) {
      string sqlExpression = "DELETE  FROM ServicesL WHERE ServicesLId=" + ServicesLId.ToString();
      using (SqlConnection connection = new SqlConnection(_ConnString)) {
        connection.Open();
        SqlCommand command = new SqlCommand(sqlExpression, connection);
        command.ExecuteNonQuery();
        connection.Close();
      }
    }

  }
}



public class ServicesL {
  private int _Number;
  private int _ServicesLId;
  private int _ServicesId;
  private string _ServicesName;
  private int _FilmsId;
  private string _FilmsName;
  private double _Price;
  private string _Message;

  public ServicesL() {
    _Number = 0;
    _ServicesLId = 0;
    _ServicesId = 0;
    _ServicesName = String.Empty;
    _FilmsId = 0;
    _FilmsName = String.Empty;
    _Price = 0;
    _Message = String.Empty;
  }

  public int Number {
    set { _Number = value; }
    get { return _Number; }
  }
  public int ServicesLId {
    set { _ServicesLId = value; }
    get { return _ServicesLId; }
  }
  public int ServicesId {
    set { _ServicesId = value; }
    get { return _ServicesId; }
  }
  public string ServicesName {
    set { _ServicesName = value; }
    get { return _ServicesName; }
  }
  public int FilmsId {
    set { _FilmsId = value; }
    get { return _FilmsId; }
  }
  public string FilmsName {
    set { _FilmsName = value; }
    get { return _FilmsName; }
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
