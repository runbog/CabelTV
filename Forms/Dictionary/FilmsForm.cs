using CableTVApp.AppCode;
using CableTVApp.Providers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CableTVApp.Forms.Dictionary {
  public partial class FilmsForm : Form {
    private int _selectedRowIndex = 0;
    private ValidationMy _validation = new ValidationMy();
    private FilmsProvider _FilmsProvider = new FilmsProvider();
    private List<Films> _FilmsList = new List<Films>();
    private CategoryProvider _CategoryProvider = new CategoryProvider();
    private List<Category> _CategoryList = new List<Category>();

    public FilmsForm() {
      InitializeComponent();
      LoadAllDate();
      DataLoad();
    }

    private void AddBtn_Click(object sender, EventArgs e) {
      if (IsDataEnteringCorrect()) {
        _FilmsProvider.InsertFilms(FilmsNameTBox.Text, GraduationYearDTP.Value, Convert.ToDouble(PriceTBox.Text), DescriptionTBox.Text,
          Convert.ToInt32(CategoryIdCBox.SelectedValue));
        DataLoad();
        ClearAllControls();
      }
    }

    private void ClearBtn_Click(object sender, EventArgs e) {
      ClearAllControls();
    }

    private void ExitBtn_Click(object sender, EventArgs e) {
      this.Close();
    }

    private void LoadAllDate() {
      _CategoryList = _CategoryProvider.GetAllCategory();
      CategoryIdCBox.DataSource = _CategoryList;
      CategoryIdCBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
      CategoryIdCBox.AutoCompleteSource = AutoCompleteSource.ListItems;
      CategoryIdCBox.ValueMember = "CategoryId";
      CategoryIdCBox.DisplayMember = "CategoryName";
    }

    private void DataLoad() {
      int firstRowIndex = 0;
      if (FilmsGridView.FirstDisplayedScrollingRowIndex > 0) {
        firstRowIndex = FilmsGridView.FirstDisplayedScrollingRowIndex;
      }
      try {
        _FilmsList = _FilmsProvider.GetAllFilms();
        LoadDataInFilmsGridView(_FilmsList);
        if (_selectedRowIndex == FilmsGridView.Rows.Count) {
          _selectedRowIndex = FilmsGridView.Rows.Count - 1;
        }
        if (_selectedRowIndex >= 0) {
          FilmsGridView.FirstDisplayedScrollingRowIndex = firstRowIndex;
          FilmsGridView.Rows[_selectedRowIndex].Selected = true;
        }
      } catch { }
    }

    private void LoadDataInFilmsGridView(List<Films> FilmsList) {
      FilmsGridView.DataSource = null;
      FilmsGridView.Columns.Clear();
      FilmsGridView.AutoGenerateColumns = false;
      FilmsGridView.RowHeadersVisible = false;

      FilmsGridView.DataSource = FilmsList;

      if (FilmsList.Count > 0) {
        if (FilmsList[0].Message == NamesMy.NoDataNames.NoDataInFilms) {
          DataGridViewColumn messageColumn = new DataGridViewTextBoxColumn();
          messageColumn.DataPropertyName = "Message";
          messageColumn.Width = FilmsGridView.Width - NamesMy.SizeOptins.MinusSizePanel;
          FilmsGridView.Columns.Add(messageColumn);
        } else {
          DataGridViewColumn DetailIdColumn = new DataGridViewTextBoxColumn();
          DetailIdColumn.DataPropertyName = "FilmsId";
          FilmsGridView.Columns.Add(DetailIdColumn);
          FilmsGridView.Columns[0].Visible = false;

          DataGridViewColumn numberColumn = new DataGridViewTextBoxColumn();
          numberColumn.HeaderText = "№ ";
          numberColumn.DataPropertyName = "Number";
          numberColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
          numberColumn.Width = NamesMy.SizeOptins.NumberSize;
          FilmsGridView.Columns.Add(numberColumn);

          DataGridViewColumn FilmsNameColumn = new DataGridViewTextBoxColumn();
          FilmsNameColumn.HeaderText = "Назва фільму";
          FilmsNameColumn.DataPropertyName = "FilmsName";
          FilmsNameColumn.Width = NamesMy.SizeOptins.NameSize;
          FilmsGridView.Columns.Add(FilmsNameColumn);

          DataGridViewColumn PriceColumn = new DataGridViewTextBoxColumn();
          PriceColumn.HeaderText = "Ціна";
          PriceColumn.DataPropertyName = "Price";
          PriceColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
          PriceColumn.Width = 80;
          FilmsGridView.Columns.Add(PriceColumn);

        }
        for (int i = 0; i < FilmsGridView.Columns.Count; i++) {
          FilmsGridView.Columns[i].HeaderCell.Style.BackColor = Color.LightGray;
        }
      }
    }

    private void ClearAllControls() {
      FilmsNameTBox.Text = String.Empty;
      DescriptionTBox.Text = String.Empty;
    }

    private bool IsDataEnteringCorrect() {
      bool isCorrect = true;
      if (_validation.IsDataEntering(FilmsNameTBox.Text)) {
        FilmsNameValiadtionLbl.Text = NamesMy.ProgramButtons.RequiredValidation;
      } else {
        FilmsNameValiadtionLbl.Text = NamesMy.ProgramButtons.ErrorValidation;
        isCorrect = false;
      }
      if (_validation.IsDataConvertToDouble(PriceTBox.Text)) {
        PriceValiadtionLbl.Text = NamesMy.ProgramButtons.RequiredValidation;
      } else {
        PriceValiadtionLbl.Text = NamesMy.ProgramButtons.ErrorValidation;
        isCorrect = false;
      }
      if (_validation.IsDataConvertToInt(CategoryIdCBox.SelectedValue.ToString())) {
        CategoryIdValiadtionLbl.Text = NamesMy.ProgramButtons.RequiredValidation;
      } else {
        CategoryIdValiadtionLbl.Text = NamesMy.ProgramButtons.ErrorValidation;
        isCorrect = false;
      }
      return isCorrect;
    }

    private void FilmsGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
      if (e.RowIndex >= 0 && FilmsGridView[0, e.RowIndex].Value.ToString() != _FilmsList[0].Message) {
        _selectedRowIndex = e.RowIndex;
        UpdateFilmsForm updateFilmsForm = new UpdateFilmsForm(Convert.ToInt32(FilmsGridView[0, e.RowIndex].Value.ToString()));
        updateFilmsForm.ShowDialog();
        DataLoad();
      }
    }
  }
}
