using CableTVApp.AppCode;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CableTVApp.Providers {
  class ProgramsLProvider {
    private FilmsProvider _FilmsProvider = new FilmsProvider();
    private string _ConnString = System.Configuration.ConfigurationSettings.AppSettings["CONNECT"];
    public void InsertBatchService(List<ProgramsL> ProgramsLList) {
      using (SqlConnection con = new SqlConnection(_ConnString)) {
        con.Open();
        for (int i = 0; i < ProgramsLList.Count; i++) {
          using (SqlCommand cmd = new SqlCommand("INSERT INTO ProgramsL (ProgramsId, FilmsId) VALUES(@ProgramsId, @FilmsId)", con)) {
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@ProgramsId", ProgramsLList[i].ProgramsId);
            cmd.Parameters.AddWithValue("@FilmsId", ProgramsLList[i].FilmsId);
            cmd.ExecuteNonQuery();
            while (cmd.Parameters.Count > 0) {
              cmd.Parameters.RemoveAt(0);
            }
          }
        }
        con.Close();
      }
    }

    public List<ProgramsL> GetAllServiceLByProgramsId(int ProgramsId) {
      int i = 0;
      List<Films> filmsList = new List<Films>();
      filmsList = _FilmsProvider.GetAllFilms();

      List<ProgramsL> ProgramsLList = new List<ProgramsL>();
      string sqlExpression = "SELECT * FROM ProgramsL WHERE ProgramsId=" + ProgramsId;
      using (SqlConnection connection = new SqlConnection(_ConnString)) {
        connection.Open();
        SqlCommand command = new SqlCommand(sqlExpression, connection);
        SqlDataReader reader = command.ExecuteReader();

        if (reader.HasRows) {
          while (reader.Read()) {
            ProgramsL selectedProgramsL = new ProgramsL();
            selectedProgramsL.Number = ++i;
            selectedProgramsL.ProgramsLId = Convert.ToInt32(reader["ProgramsLId"]);
            selectedProgramsL.ProgramsId = Convert.ToInt32(reader["ProgramsId"]);
            selectedProgramsL.FilmsId = Convert.ToInt32(reader["FilmsId"]);
            ProgramsLList.Add(selectedProgramsL);
          }
        }
        reader.Close();
      }

      if (ProgramsLList.Count == 0) {
        ProgramsL noProgramsL = new ProgramsL();
        noProgramsL.ProgramsLId = 0;
        noProgramsL.Message = NamesMy.NoDataNames.NoDataInLPrograms;
        ProgramsLList.Add(noProgramsL);
      } else {
        for (int j = 0; j < ProgramsLList.Count; i++) {
          ProgramsLList[i].FilmsName = GetFilmsName(ProgramsLList[i].FilmsId, filmsList);
          ProgramsLList[i].Price = GetPrice(ProgramsLList[i].FilmsId, filmsList);
        }
      }


      return ProgramsLList;
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

    public void DeleteServiceLByProgramsId(int ProgramsId) {
      string sqlExpression = "DELETE  FROM ProgramsL WHERE ProgramsId=" + ProgramsId.ToString();
      using (SqlConnection connection = new SqlConnection(_ConnString)) {
        connection.Open();
        SqlCommand command = new SqlCommand(sqlExpression, connection);
        command.ExecuteNonQuery();
        connection.Close();
      }
    }

    public void DeleteServiceL(int ProgramsLId) {
      string sqlExpression = "DELETE  FROM ProgramsL WHERE ProgramsLId=" + ProgramsLId.ToString();
      using (SqlConnection connection = new SqlConnection(_ConnString)) {
        connection.Open();
        SqlCommand command = new SqlCommand(sqlExpression, connection);
        command.ExecuteNonQuery();
        connection.Close();
      }
    }

  }
}

public class ProgramsL {
  private int _Number;
  private int _ProgramsLId;
  private int _ProgramsId;
  private string _ProgramsName;
  private int _FilmsId;
  private string _FilmsName;
  private double _Price;
  private string _Message;

  public ProgramsL() {
    _Number = 0;
    _ProgramsLId = 0;
    _ProgramsId = 0;
    _ProgramsName = String.Empty;
    _FilmsId = 0;
    _FilmsName = String.Empty;
    _Price = 0;
    _Message = String.Empty;
  }

  public int Number {
    set { _Number = value; }
    get { return _Number; }
  }
  public int ProgramsLId {
    set { _ProgramsLId = value; }
    get { return _ProgramsLId; }
  }
  public int ProgramsId {
    set { _ProgramsId = value; }
    get { return _ProgramsId; }
  }
  public string ProgramsName {
    set { _ProgramsName = value; }
    get { return _ProgramsName; }
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

