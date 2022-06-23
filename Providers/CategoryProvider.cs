using CableTVApp.AppCode;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CableTVApp.Providers {
  class CategoryProvider {
    private string _ConnString = System.Configuration.ConfigurationSettings.AppSettings["CONNECT"];

    public void InsertCategory(string CategoryName, string Description) {
      SqlConnection connection = new SqlConnection(_ConnString);
      string query = "INSERT INTO Category (CategoryName, Description) VALUES(N'" + CategoryName + "',N'" + Description + "')";
      SqlCommand command = new SqlCommand(query, connection);
      connection.Open();
      command.ExecuteNonQuery();
      connection.Close();
    }

    public Category SelectedCategoryByCategoryId(int CategoryId) {
      int i = 0;
      Category selectedCategory = new Category();
      string sqlExpression = "SELECT * FROM Category WHERE CategoryId=" + CategoryId.ToString();
      using (SqlConnection connection = new SqlConnection(_ConnString)) {
        connection.Open();
        SqlCommand command = new SqlCommand(sqlExpression, connection);
        SqlDataReader reader = command.ExecuteReader();

        if (reader.HasRows) {
          while (reader.Read()) {
            selectedCategory.Number = ++i;
            selectedCategory.CategoryId = Convert.ToInt32(reader["CategoryId"]);
            selectedCategory.CategoryName = reader["CategoryName"].ToString();
            selectedCategory.Description = reader["Description"].ToString();
          }
        }
        reader.Close();
      }
      return selectedCategory;
    }

    public List<Category> GetAllCategory() {
      int i = 0;
      List<Category> categoryList = new List<Category>();
      string sqlExpression = "SELECT * FROM Category";
      using (SqlConnection connection = new SqlConnection(_ConnString)) {
        connection.Open();
        SqlCommand command = new SqlCommand(sqlExpression, connection);
        SqlDataReader reader = command.ExecuteReader();

        if (reader.HasRows) {
          while (reader.Read()) {
            Category oneCategory = new Category();
            oneCategory.Number = ++i;
            oneCategory.CategoryId = Convert.ToInt32(reader["CategoryId"]);
            oneCategory.CategoryName = reader["CategoryName"].ToString();
            oneCategory.Description = reader["Description"].ToString();
            categoryList.Add(oneCategory);
          }
        }
        reader.Close();
      }
      if (categoryList.Count == 0) {
        Category noCategory = new Category();
        noCategory.CategoryId = 0;
        noCategory.Message = NamesMy.NoDataNames.NoDataInCategory;
        categoryList.Add(noCategory);
      }

      return categoryList;
    }

    public void UpdateCategory(string CategoryName, string Description, int CategoryId) {
      using (SqlConnection con = new SqlConnection(_ConnString)) {
        using (SqlCommand cmd = new SqlCommand("UPDATE Category SET CategoryName = @CategoryName, Description = @Description " +
          " WHERE CategoryId = @CategoryId", con)) {
          cmd.CommandType = CommandType.Text;
          cmd.Parameters.AddWithValue("@CategoryName", CategoryName);
          cmd.Parameters.AddWithValue("@Description", Description);
          cmd.Parameters.AddWithValue("@CategoryId", CategoryId);
          con.Open();
          int rowsAffected = cmd.ExecuteNonQuery();
          con.Close();
        }
      }
    }

    public void DeleteCategoryByCategoryId(int CategoryId) {
      string sqlExpression = "DELETE  FROM Category WHERE CategoryId=" + CategoryId.ToString();
      using (SqlConnection connection = new SqlConnection(_ConnString)) {
        connection.Open();
        SqlCommand command = new SqlCommand(sqlExpression, connection);
        command.ExecuteNonQuery();
        connection.Close();
      }
    }

  }
}

public class Category {
  private int _Number;
  private int _CategoryId;
  private string _CategoryName;
  private string _Description;
  private string _Message;

  public Category() {
    _Number = 0;
    _CategoryId = 0;
    _CategoryName = String.Empty;
    _Description = String.Empty;
    _Message = String.Empty;
  }

  public int Number {
    set { _Number = value; }
    get { return _Number; }
  }
  public int CategoryId {
    set { _CategoryId = value; }
    get { return _CategoryId; }
  }
  public string CategoryName {
    set { _CategoryName = value; }
    get { return _CategoryName; }
  }
  public string Description {
    set { _Description = value; }
    get { return _Description; }
  }
  public string Message {
    set { _Message = value; }
    get { return _Message; }
  }
}
