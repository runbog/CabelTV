using CableTVApp.AppCode;
using CableTVApp.Provider;
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

namespace CableTVApp.Forms.Jobs {
  public partial class ProgramsJobsForm : Form {
    private int _selectedRowIndex = 0;
    private ValidationMy _validation = new ValidationMy();
    private FilmsProvider _FilmsProvider = new FilmsProvider();
    private List<Films> _allFilmsList = new List<Films>();
    private ProgramsProvider _ProgramsProvider = new ProgramsProvider();
    private List<Programs> _ProgramsList = new List<Programs>();
    private ProgramsLProvider _ProgramsLProvider = new ProgramsLProvider();
    private List<ProgramsL> _allProgramsLTempList = new List<ProgramsL>();

    public ProgramsJobsForm() {
      InitializeComponent();
      LoadAllDate();
      DataLoad();
    }

    private void AddRabotaBtn_Click(object sender, EventArgs e) {
      ProgramsL oneSpisokTemp = new ProgramsL();
      oneSpisokTemp.FilmsId = Convert.ToInt32(FilmsCBox.SelectedValue.ToString());
      oneSpisokTemp.FilmsName = FilmsCBox.Text;
      oneSpisokTemp.Price = GetPrice(oneSpisokTemp.FilmsId, _allFilmsList);
      _allProgramsLTempList.Add(oneSpisokTemp);
      LoadDataProgramsLTemp(_allProgramsLTempList);
    }

    private double GetPrice(int FilmsId, List<Films> FilmsList) {
      for (int i = 0; i < FilmsList.Count; i++) {
        if (FilmsId == FilmsList[i].FilmsId) {
          return FilmsList[i].Price;
        }
      }
      return 0.0;
    }

    private void AddBtn_Click(object sender, EventArgs e) {
      if (IsDataEnteringCorrect()) {
        _ProgramsProvider.InsertPrograms(ProgramsNameTBox.Text, Convert.ToDouble(PriceTBox.Text), DescriptionTBox.Text);
        int lastProgramsId = _ProgramsProvider.GetLastRecords();
        for (int i = 0; i < _allProgramsLTempList.Count(); i++) {
          _allProgramsLTempList[i].ProgramsId = lastProgramsId;
        }
        _ProgramsLProvider.InsertBatchService(_allProgramsLTempList);
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

    private void ProgramsGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
      if (e.ColumnIndex == 4) {
        if (MessageBox.Show("Ви дійсно бажаєте видалити?", "Видалити", MessageBoxButtons.YesNo) == DialogResult.Yes) {
          int selectedPrograms = Convert.ToInt32(ProgramsGridView[0, e.RowIndex].Value.ToString());
          _ProgramsProvider.DeleteProgramsByProgramsId(selectedPrograms);
          _ProgramsLProvider.DeleteServiceLByProgramsId(selectedPrograms);
          DataLoad();
        }
      }
    }

    private void LoadAllDate() {
      _allFilmsList = _FilmsProvider.GetAllFilms();
      FilmsCBox.DataSource = _allFilmsList;
      FilmsCBox.ValueMember = "FilmsId";
      FilmsCBox.DisplayMember = "FilmsName";
    }

    private void DataLoad() {
      int firstRowIndex = 0;
      if (ProgramsGridView.FirstDisplayedScrollingRowIndex > 0) {
        firstRowIndex = ProgramsGridView.FirstDisplayedScrollingRowIndex;
      }
      try {
        _ProgramsList = _ProgramsProvider.GetAllPrograms();
        LoadDataInProgramsGridView(_ProgramsList);
        if (_selectedRowIndex == ProgramsGridView.Rows.Count) {
          _selectedRowIndex = ProgramsGridView.Rows.Count - 1;
        }
        if (_selectedRowIndex >= 0) {
          ProgramsGridView.FirstDisplayedScrollingRowIndex = firstRowIndex;
          ProgramsGridView.Rows[_selectedRowIndex].Selected = true;
        }
      } catch { }
    }

    private void LoadDataInProgramsGridView(List<Programs> AllProgramsList) {
      ProgramsGridView.DataSource = null;
      ProgramsGridView.Columns.Clear();
      ProgramsGridView.AutoGenerateColumns = false;
      ProgramsGridView.RowHeadersVisible = false;

      ProgramsGridView.DataSource = AllProgramsList;

      if (AllProgramsList.Count > 0) {
        if (AllProgramsList[0].Message == NamesMy.NoDataNames.NoDataInPrograms) {
          DataGridViewColumn dataColumn = new DataGridViewTextBoxColumn();
          dataColumn.DataPropertyName = "Message";
          dataColumn.Width = ProgramsGridView.Width - NamesMy.SizeOptins.MinusSizePanel;
          ProgramsGridView.Columns.Add(dataColumn);
        } else {
          DataGridViewColumn idColumn = new DataGridViewTextBoxColumn();
          idColumn.DataPropertyName = "ProgramsId";
          ProgramsGridView.Columns.Add(idColumn);
          ProgramsGridView.Columns[0].Visible = false;

          DataGridViewColumn numberColumn = new DataGridViewTextBoxColumn();
          numberColumn.HeaderText = "№ з/п";
          numberColumn.DataPropertyName = "Number";
          numberColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
          numberColumn.Width = NamesMy.SizeOptins.NumberSize;
          ProgramsGridView.Columns.Add(numberColumn);

          DataGridViewColumn FilmsNameColumn = new DataGridViewTextBoxColumn();
          FilmsNameColumn.HeaderText = "Програма";
          FilmsNameColumn.DataPropertyName = "ProgramsName";
          FilmsNameColumn.Width = NamesMy.SizeOptins.Title;
          ProgramsGridView.Columns.Add(FilmsNameColumn);

          DataGridViewColumn PriceColumn = new DataGridViewTextBoxColumn();
          PriceColumn.HeaderText = "Ціна";
          PriceColumn.DataPropertyName = "Price";
          PriceColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
          PriceColumn.Width = 80;
          ProgramsGridView.Columns.Add(PriceColumn);

          DataGridViewButtonColumn deleteBtn = new DataGridViewButtonColumn();
          deleteBtn.HeaderText = NamesMy.ProgramButtons.DeleteBtn;
          deleteBtn.Text = NamesMy.ProgramButtons.DeleteBtn;
          deleteBtn.UseColumnTextForButtonValue = true;
          deleteBtn.ToolTipText = NamesMy.ProgramButtons.DeleteBtn;
          deleteBtn.Width = NamesMy.SizeOptins.DeleteBtnSize;
          ProgramsGridView.Columns.Add(deleteBtn);

        }
        for (int i = 0; i < ProgramsGridView.Columns.Count; i++) {
          ProgramsGridView.Columns[i].HeaderCell.Style.BackColor = Color.LightGray;
        }
      }
    }

    private void LoadDataProgramsLTemp(List<ProgramsL> AllProgramsLTempList) {
      FilmsDataGridView.DataSource = null;
      FilmsDataGridView.Columns.Clear();
      FilmsDataGridView.AutoGenerateColumns = false;
      FilmsDataGridView.RowHeadersVisible = false;

      FilmsDataGridView.DataSource = AllProgramsLTempList;

      DataGridViewColumn idColumn = new DataGridViewTextBoxColumn();
      idColumn.DataPropertyName = "FilmsId";
      FilmsDataGridView.Columns.Add(idColumn);
      FilmsDataGridView.Columns[0].Visible = false;

      DataGridViewColumn nameColumn = new DataGridViewTextBoxColumn();
      nameColumn.HeaderText = "Фільм";
      nameColumn.DataPropertyName = "FilmsName";
      nameColumn.Width = 295;
      FilmsDataGridView.Columns.Add(nameColumn);

      DataGridViewColumn priceColumn = new DataGridViewTextBoxColumn();
      priceColumn.HeaderText = "Ціна";
      priceColumn.DataPropertyName = "Price";
      priceColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      priceColumn.Width = 70;
      FilmsDataGridView.Columns.Add(priceColumn);


      for (int i = 0; i < FilmsDataGridView.Columns.Count; i++) {
        FilmsDataGridView.Columns[i].HeaderCell.Style.BackColor = Color.LightGray;
      }
    }

    private void ClearAllControls() {
      ProgramsNameTBox.Text = String.Empty;
      _allProgramsLTempList.Clear();
      LoadDataProgramsLTemp(_allProgramsLTempList);
    }

    private bool IsDataEnteringCorrect() {
      bool isCorrect = true;
      if (_validation.IsDataEntering(ProgramsNameTBox.Text)) {
        ProgramsNameValiadtionLbl.Text = NamesMy.ProgramButtons.RequiredValidation;
      } else {
        ProgramsNameValiadtionLbl.Text = NamesMy.ProgramButtons.ErrorValidation;
        isCorrect = false;
      }
      if (_validation.IsDataConvertToDouble(PriceTBox.Text)) {
        PriceValiadtionLbl.Text = NamesMy.ProgramButtons.RequiredValidation;
      } else {
        PriceValiadtionLbl.Text = NamesMy.ProgramButtons.ErrorValidation;
        isCorrect = false;
      }
      return isCorrect;
    }


  }
}
