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
  public partial class UpdateFilmsForm : Form {
    private int _FilmsId = 0;
    private Films _selectedFilms = new Films();
    private FilmsProvider _FilmsProvider = new FilmsProvider();
    private ValidationMy _Validation = new ValidationMy();
    private CategoryProvider _CategoryProvider = new CategoryProvider();
    private List<Category> _CategoryList = new List<Category>();

    public UpdateFilmsForm(int FilmsId) {
      InitializeComponent();
      _FilmsId = FilmsId;
      LoadAllDate();

    }

    private void SaveBtn_Click(object sender, EventArgs e) {
      if (IsDataEnteringCorrect()) {
        _FilmsProvider.UpdateFilms(FilmsNameTBox.Text, GraduationYearDTP.Value, Convert.ToDouble(PriceTBox.Text), DescriptionTBox.Text,
          Convert.ToInt32(CategoryIdCBox.SelectedValue), _FilmsId);
        this.Close();
      }
    }

    private void DeleteBtn_Click(object sender, EventArgs e) {
      if (MessageBox.Show("Ви дійсно хочете видалити цей елемент?", "Видалити", MessageBoxButtons.YesNo) == DialogResult.Yes) {
        _FilmsProvider.DeleteFilmsByFilmsId(_FilmsId);
        this.Close();
      }
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

      _selectedFilms = _FilmsProvider.SelectedFilmsByFilmsId(_FilmsId);
      FilmsNameTBox.Text = _selectedFilms.FilmsName;
      DescriptionTBox.Text = _selectedFilms.Description;
      PriceTBox.Text = _selectedFilms.Price.ToString().Replace(".", ",");
      CategoryIdCBox.SelectedValue = _selectedFilms.CategoryId;
    }

    private bool IsDataEnteringCorrect() {
      bool isCorrect = true;
      if (_Validation.IsDataEntering(FilmsNameTBox.Text)) {
        FilmsNameValiadtionLbl.Text = NamesMy.ProgramButtons.RequiredValidation;
      } else {
        FilmsNameValiadtionLbl.Text = NamesMy.ProgramButtons.ErrorValidation;
        isCorrect = false;
      }
      if (_Validation.IsDataConvertToDouble(PriceTBox.Text)) {
        PriceValiadtionLbl.Text = NamesMy.ProgramButtons.RequiredValidation;
      } else {
        PriceValiadtionLbl.Text = NamesMy.ProgramButtons.ErrorValidation;
        isCorrect = false;
      }
      return isCorrect;
    }

  }
}
