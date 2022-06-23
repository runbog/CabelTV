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
  class ProgramsProvider {
    private string _ConnString = System.Configuration.ConfigurationSettings.AppSettings["CONNECT"];

    public void InsertPrograms(string ProgramsName, double Price, string Description) {
      SqlConnection connection = new SqlConnection(_ConnString);

      string query = "INSERT INTO Programs (ProgramsName, Price, Description) ";
      query += String.Format("VALUES(N'{0}', {1}, N'{2}')",
        ProgramsName, Price.ToString().Replace(",", "."), Description);
      SqlCommand command = new SqlCommand(query, connection);
      connection.Open();
      command.ExecuteNonQuery();
      connection.Close();
    }

    public Programs SelectedProgramsByProgramsId(int ProgramsId) {
      Programs selectedPrograms = new Programs();
      string sqlExpression = "SELECT * FROM Programs WHERE ProgramsId=" + ProgramsId.ToString();
      using (SqlConnection connection = new SqlConnection(_ConnString)) {
        connection.Open();
        SqlCommand command = new SqlCommand(sqlExpression, connection);
        SqlDataReader reader = command.ExecuteReader();

        if (reader.HasRows) {
          while (reader.Read()) {
            selectedPrograms.ProgramsId = Convert.ToInt32(reader["ProgramsId"]);
            selectedPrograms.Description = reader["Description"].ToString();
            selectedPrograms.Price = Convert.ToDouble(reader["Price"]);
            selectedPrograms.ProgramsName = reader["ProgramsName"].ToString();
          }
        }
        reader.Close();
      }
      return selectedPrograms;
    }

    public List<Programs> GetAllPrograms() {
      int i = 0;
      List<Programs> ProgramsList = new List<Programs>();
      string sqlExpression = "SELECT * FROM Programs";
      using (SqlConnection connection = new SqlConnection(_ConnString)) {
        connection.Open();
        SqlCommand command = new SqlCommand(sqlExpression, connection);
        SqlDataReader reader = command.ExecuteReader();

        if (reader.HasRows) {
          while (reader.Read()) {
            Programs selectedPrograms = new Programs();
            selectedPrograms.Number = ++i;
            selectedPrograms.ProgramsId = Convert.ToInt32(reader["ProgramsId"]);
            selectedPrograms.Description = reader["Description"].ToString();
            selectedPrograms.Price = Convert.ToDouble(reader["Price"]);
            selectedPrograms.ProgramsName = reader["ProgramsName"].ToString();
            ProgramsList.Add(selectedPrograms);
          }
        }
        reader.Close();
      }
      if (ProgramsList.Count == 0) {
        Programs noPrograms = new Programs();
        noPrograms.ProgramsId = 0;
        noPrograms.Message = NamesMy.NoDataNames.NoDataInPrograms;
        ProgramsList.Add(noPrograms);
      }

      return ProgramsList;
    }

    public void UpdatePrograms(string ProgramsName, double Price, string Description, int ProgramsId) {
      using (SqlConnection con = new SqlConnection(_ConnString)) {
        using (SqlCommand cmd = new SqlCommand("UPDATE Programs SET ProgramsName=@ProgramsName, Price=@Price," +
          " Description = @Description,  " +
          " WHERE ProgramsId = @ProgramsId", con)) {
          cmd.CommandType = CommandType.Text;
          cmd.Parameters.AddWithValue("@ProgramsName", ProgramsName);
          cmd.Parameters.AddWithValue("@Price", Price.ToString().Replace(",", "."));
          cmd.Parameters.AddWithValue("@Description", Description);
          cmd.Parameters.AddWithValue("@ProgramsId", ProgramsId);
          con.Open();
          int rowsAffected = cmd.ExecuteNonQuery();
          con.Close();
        }
      }
    }

    public void DeleteProgramsByProgramsId(int ProgramsId) {
      string sqlExpression = "DELETE  FROM Programs WHERE ProgramsId=" + ProgramsId.ToString();
      using (SqlConnection connection = new SqlConnection(_ConnString)) {
        connection.Open();
        SqlCommand command = new SqlCommand(sqlExpression, connection);
        command.ExecuteNonQuery();
        connection.Close();
      }
    }

    public int GetLastRecords() {
      int lastRecordNumber = 0;
      string SqlString = "Select MAX (ProgramsId) From Programs ";
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


public class Programs {
  private int _Number;
  private int _ProgramsId;
  private string _ProgramsName;
  private double _Price;
  private string _Description;
  private string _Message;

  public Programs() {
    _Number = 0;
    _ProgramsId = 0;
    _Description = String.Empty;
    _Price = 0.0;
    _ProgramsName = String.Empty;
    _Message = String.Empty;
  }

  public int Number {
    set { _Number = value; }
    get { return _Number; }
  }
  public int ProgramsId {
    set { _ProgramsId = value; }
    get { return _ProgramsId; }
  }
  public string Description {
    set { _Description = value; }
    get { return _Description; }
  }
  public double Price {
    set { _Price = value; }
    get { return _Price; }
  }
  public string ProgramsName {
    set { _ProgramsName = value; }
    get { return _ProgramsName; }
  }
  public string Message {
    set { _Message = value; }
    get { return _Message; }
  }
}
