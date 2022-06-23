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
  public partial class ServisesJobsForm : Form {
    private int _selectedRowIndex = 0;
    private ValidationMy _validation = new ValidationMy();
    private FilmsProvider _FilmsProvider = new FilmsProvider();
    private List<Films> _allFilmsList = new List<Films>();
    private ServicesProvider _ServicesProvider = new ServicesProvider();
    private List<Services> _ServicesList = new List<Services>();
    private ServicesLProvider _ServicesLProvider = new ServicesLProvider();
    private List<ServicesL> _allServicesLTempList = new List<ServicesL>();

    public ServisesJobsForm() {
      InitializeComponent();
      LoadAllDate();
      DataLoad();
    }

    private void AddRabotaBtn_Click(object sender, EventArgs e) {
      ServicesL oneSpisokTemp = new ServicesL();
      oneSpisokTemp.FilmsId = Convert.ToInt32(FilmsCBox.SelectedValue.ToString());
      oneSpisokTemp.FilmsName = FilmsCBox.Text;
      oneSpisokTemp.Price = GetPrice(oneSpisokTemp.FilmsId, _allFilmsList);
      _allServicesLTempList.Add(oneSpisokTemp);
      LoadDataSpisokRabotTemp(_allServicesLTempList);

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
        _ServicesProvider.InsertService(ServicesNameTBox.Text, Convert.ToDouble(PriceTBox.Text), DescriptionTBox.Text);
        int lastServicesId = _ServicesProvider.GetLastRecords();
        for (int i = 0; i < _allServicesLTempList.Count(); i++) {
          _allServicesLTempList[i].ServicesId = lastServicesId;
        }
        _ServicesLProvider.InsertBatchService(_allServicesLTempList);
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

    private void ServisesGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
      if (e.ColumnIndex == 4) {
        if (MessageBox.Show("Ви дійсно бажаєте видалити?", "Видалити", MessageBoxButtons.YesNo) == DialogResult.Yes) {
          int selectedServices = Convert.ToInt32(ServicesGridView[0, e.RowIndex].Value.ToString());
          _ServicesProvider.DeleteServiceByServicesId(selectedServices);
          _ServicesLProvider.DeleteServiceLByServicesId(selectedServices);
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
      if (ServicesGridView.FirstDisplayedScrollingRowIndex > 0) {
        firstRowIndex = ServicesGridView.FirstDisplayedScrollingRowIndex;
      }
      try {
        _ServicesList = _ServicesProvider.GetAllService();
        LoadDataInRabotaGridView(_ServicesList);
        if (_selectedRowIndex == ServicesGridView.Rows.Count) {
          _selectedRowIndex = ServicesGridView.Rows.Count - 1;
        }
        if (_selectedRowIndex >= 0) {
          ServicesGridView.FirstDisplayedScrollingRowIndex = firstRowIndex;
          ServicesGridView.Rows[_selectedRowIndex].Selected = true;
        }
      } catch { }
    }

    private void LoadDataInRabotaGridView(List<Services> AllServicesList) {
      ServicesGridView.DataSource = null;
      ServicesGridView.Columns.Clear();
      ServicesGridView.AutoGenerateColumns = false;
      ServicesGridView.RowHeadersVisible = false;

      ServicesGridView.DataSource = AllServicesList;

      if (AllServicesList.Count > 0) {
        if (AllServicesList[0].Message == NamesMy.NoDataNames.NoDataInServices) {
          DataGridViewColumn dataColumn = new DataGridViewTextBoxColumn();
          dataColumn.DataPropertyName = "Message";
          dataColumn.Width = ServicesGridView.Width - NamesMy.SizeOptins.MinusSizePanel;
          ServicesGridView.Columns.Add(dataColumn);
        } else {
          DataGridViewColumn idColumn = new DataGridViewTextBoxColumn();
          idColumn.DataPropertyName = "ServicesId";
          ServicesGridView.Columns.Add(idColumn);
          ServicesGridView.Columns[0].Visible = false;

          DataGridViewColumn numberColumn = new DataGridViewTextBoxColumn();
          numberColumn.HeaderText = "№ з/п";
          numberColumn.DataPropertyName = "Number";
          numberColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
          numberColumn.Width = NamesMy.SizeOptins.NumberSize;
          ServicesGridView.Columns.Add(numberColumn);

          DataGridViewColumn FilmsNameColumn = new DataGridViewTextBoxColumn();
          FilmsNameColumn.HeaderText = "Послуга";
          FilmsNameColumn.DataPropertyName = "ServicesName";
          FilmsNameColumn.Width = NamesMy.SizeOptins.Title;
          ServicesGridView.Columns.Add(FilmsNameColumn);

          DataGridViewColumn PriceColumn = new DataGridViewTextBoxColumn();
          PriceColumn.HeaderText = "Ціна";
          PriceColumn.DataPropertyName = "Price";
          PriceColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
          PriceColumn.Width = 80;
          ServicesGridView.Columns.Add(PriceColumn);

          DataGridViewButtonColumn deleteBtn = new DataGridViewButtonColumn();
          deleteBtn.HeaderText = NamesMy.ProgramButtons.DeleteBtn;
          deleteBtn.Text = NamesMy.ProgramButtons.DeleteBtn;
          deleteBtn.UseColumnTextForButtonValue = true;
          deleteBtn.ToolTipText = NamesMy.ProgramButtons.DeleteBtn;
          deleteBtn.Width = NamesMy.SizeOptins.DeleteBtnSize;
          ServicesGridView.Columns.Add(deleteBtn);

        }
        for (int i = 0; i < ServicesGridView.Columns.Count; i++) {
          ServicesGridView.Columns[i].HeaderCell.Style.BackColor = Color.LightGray;
        }
      }
    }

    private void LoadDataSpisokRabotTemp(List<ServicesL> AllServicesLTempList) {
      FilmsDataGridView.DataSource = null;
      FilmsDataGridView.Columns.Clear();
      FilmsDataGridView.AutoGenerateColumns = false;
      FilmsDataGridView.RowHeadersVisible = false;

      FilmsDataGridView.DataSource = AllServicesLTempList;

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
      ServicesNameTBox.Text = String.Empty;
      _allServicesLTempList.Clear();
      LoadDataSpisokRabotTemp(_allServicesLTempList);
    }

    private bool IsDataEnteringCorrect() {
      bool isCorrect = true;
      if (_validation.IsDataEntering(ServicesNameTBox.Text)) {
        ServicesNameValiadtionLbl.Text = NamesMy.ProgramButtons.RequiredValidation;
      } else {
        ServicesNameValiadtionLbl.Text = NamesMy.ProgramButtons.ErrorValidation;
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
