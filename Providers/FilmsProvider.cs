using CableTVApp.AppCode;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CableTVApp.Providers {
  class FilmsProvider {
    private string _ConnString = System.Configuration.ConfigurationSettings.AppSettings["CONNECT"];

    public void InsertFilms(string FilmsName, DateTime GraduationYear, double Price, string Description, int CategoryId) {
      SqlConnection connection = new SqlConnection(_ConnString);
      string query = "INSERT INTO Films (FilmsName, GraduationYear, Price, Description,  CategoryId) ";
      query += String.Format("VALUES(N'{0}', '{1}', {2}, N'{3}', {4})",
        FilmsName, GraduationYear.ToString("yyyy-MM-dd HH:mm:ss"), Price.ToString().Replace(",", "."), Description, CategoryId);
      SqlCommand command = new SqlCommand(query, connection);
      connection.Open();
      command.ExecuteNonQuery();
      connection.Close();
    }

    public Films SelectedFilmsByFilmsId(int FilmsId) {
      Films selectedFilms = new Films();
      string sqlExpression = "SELECT * FROM Films WHERE FilmsId=" + FilmsId.ToString();
      using (SqlConnection connection = new SqlConnection(_ConnString)) {
        connection.Open();
        SqlCommand command = new SqlCommand(sqlExpression, connection);
        SqlDataReader reader = command.ExecuteReader();

        if (reader.HasRows) {
          while (reader.Read()) {
            selectedFilms.FilmsId = Convert.ToInt32(reader["FilmsId"]);
            selectedFilms.FilmsName = reader["FilmsName"].ToString();
            selectedFilms.GraduationYear = Convert.ToDateTime(reader["GraduationYear"]);
            selectedFilms.Price = Convert.ToDouble(reader["Price"]);
            selectedFilms.Description = reader["Description"].ToString();
            selectedFilms.CategoryId = Convert.ToInt32(reader["CategoryId"]);
          }
        }
        reader.Close();
      }
      return selectedFilms;
    }

    public List<Films> GetAllFilms() {
      int i = 0;
      List<Films> FilmsList = new List<Films>();
      string sqlExpression = "SELECT * FROM Films";
      using (SqlConnection connection = new SqlConnection(_ConnString)) {
        connection.Open();
        SqlCommand command = new SqlCommand(sqlExpression, connection);
        SqlDataReader reader = command.ExecuteReader();

        if (reader.HasRows) {
          while (reader.Read()) {
            Films selectedFilms = new Films();
            selectedFilms.Number = ++i;
            selectedFilms.FilmsId = Convert.ToInt32(reader["FilmsId"]);
            selectedFilms.FilmsName = reader["FilmsName"].ToString();
            selectedFilms.GraduationYear = Convert.ToDateTime(reader["GraduationYear"]);
            selectedFilms.Price = Convert.ToDouble(reader["Price"]);
            selectedFilms.Description = reader["Description"].ToString();
            selectedFilms.CategoryId = Convert.ToInt32(reader["CategoryId"]);
            FilmsList.Add(selectedFilms);
          }
        }
        reader.Close();
      }
      if (FilmsList.Count == 0) {
        Films noFilms = new Films();
        noFilms.FilmsId = 0;
        noFilms.Message = NamesMy.NoDataNames.NoDataInFilms;
        FilmsList.Add(noFilms);
      }

      return FilmsList;
    }

    public void UpdateFilms(string FilmsName, DateTime GraduationYear, double Price, string Description, int CategoryId, int FilmsId) {
      using (SqlConnection con = new SqlConnection(_ConnString)) {
        using (SqlCommand cmd = new SqlCommand("UPDATE Films SET FilmsName = @FilmsName, GraduationYear=@GraduationYear, Price=@Price, Description = @Description, " +
          "CategoryId=@CategoryId WHERE FilmsId = @FilmsId", con)) {
          cmd.CommandType = CommandType.Text;
          cmd.Parameters.AddWithValue("@FilmsName", FilmsName);
          cmd.Parameters.AddWithValue("@GraduationYear", GraduationYear.ToString("yyyy-MM-dd HH:mm:ss"));
          cmd.Parameters.AddWithValue("@Price", Price.ToString().Replace(",", "."));
          cmd.Parameters.AddWithValue("@Description", Description);
          cmd.Parameters.AddWithValue("@CategoryId", CategoryId);
          cmd.Parameters.AddWithValue("@FilmsId", FilmsId);
          con.Open();
          int rowsAffected = cmd.ExecuteNonQuery();
          con.Close();
        }
      }
    }

    public void DeleteFilmsByFilmsId(int FilmsId) {
      string sqlExpression = "DELETE  FROM Films WHERE FilmsId=" + FilmsId.ToString();
      using (SqlConnection connection = new SqlConnection(_ConnString)) {
        connection.Open();
        SqlCommand command = new SqlCommand(sqlExpression, connection);
        command.ExecuteNonQuery();
        connection.Close();
      }
    }

  }
}

public class Films {
  private int _Number;
  private int _FilmsId;
  private string _FilmsName;
  private DateTime _GraduationYear;
  private double _Price;
  private string _Description;
  private int _CategoryId;
  private string _Message;

  public Films() {
    _Number = 0;
    _FilmsId = 0;
    _FilmsName = String.Empty;
    _GraduationYear = new DateTime();
    _Price = 0.0;
    _Description = String.Empty;
    _CategoryId = 0;
    _Message = String.Empty;
  }

  public int Number {
    set { _Number = value; }
    get { return _Number; }
  }
  public int FilmsId {
    set { _FilmsId = value; }
    get { return _FilmsId; }
  }
  public string FilmsName {
    set { _FilmsName = value; }
    get { return _FilmsName; }
  }
  public DateTime GraduationYear {
    set { _GraduationYear = value; }
    get { return _GraduationYear; }
  }
  public double Price {
    set { _Price = value; }
    get { return _Price; }
  }
  public string Description {
    set { _Description = value; }
    get { return _Description; }
  }
  public int CategoryId {
    set { _CategoryId = value; }
    get { return _CategoryId; }
  }
  public string Message {
    set { _Message = value; }
    get { return _Message; }
  }
}