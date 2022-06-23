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

namespace CableTVApp.Forms.Controls {
  public partial class ServicesAndProgramsForm : Form {
    private int _selectedRowIndex = 0;
    private int _ClientId;
    private ValidationMy _validation = new ValidationMy();
    private ProgramsProvider _ProgramsProvider = new ProgramsProvider();
    private List<Programs> _ProgramsList = new List<Programs>();
    private ServicesProvider _ServicesProvider = new ServicesProvider();
    private List<Services> _ServicesList = new List<Services>();

    private ClientProgramsProvider _ClientProgramsProvider = new ClientProgramsProvider();
    private List<ClientPrograms> _allClientProgramsList = new List<ClientPrograms>();
   
    private ClientServicesProvider _ClientServicesProvider = new ClientServicesProvider();
    private List<ClientServices> _allClientServicesList = new List<ClientServices>();

    public ServicesAndProgramsForm(int ClientId) {
      InitializeComponent();
      _ClientId = ClientId;
      LoadAllDate();
      DataLoad();
      DataLoad2();
    }

    private void AddProgramsBtn_Click(object sender, EventArgs e) {
        _ClientProgramsProvider.InsertClientPrograms(_ClientId, Convert.ToInt32(ProgramsCBox.SelectedValue));
        DataLoad();
    }

    private void AddServiseBtn_Click(object sender, EventArgs e) {
      _ClientServicesProvider.InsertClientServices(_ClientId, Convert.ToInt32(ServicesCBox.SelectedValue));
      DataLoad2();
    }


    private void LoadAllDate() {
      _ProgramsList = _ProgramsProvider.GetAllPrograms();
      ProgramsCBox.DataSource = _ProgramsList;
      ProgramsCBox.ValueMember = "ProgramsId";
      ProgramsCBox.DisplayMember = "ProgramsName";

      _ServicesList = _ServicesProvider.GetAllService();
      ServicesCBox.DataSource = _ServicesList;
      ServicesCBox.ValueMember = "ServicesId";
      ServicesCBox.DisplayMember = "ServicesName";
    }

    private void DataLoad() {
      int firstRowIndex = 0;
      if (ProgramsGridView.FirstDisplayedScrollingRowIndex > 0) {
        firstRowIndex = ProgramsGridView.FirstDisplayedScrollingRowIndex;
      }
      try {
        _allClientProgramsList = _ClientProgramsProvider.GetAllClientProgramsByClientId(_ClientId);
        LoadDataInProgramsGridView(_allClientProgramsList);
        if (_selectedRowIndex == ProgramsGridView.Rows.Count) {
          _selectedRowIndex = ProgramsGridView.Rows.Count - 1;
        }
        if (_selectedRowIndex >= 0) {
          ProgramsGridView.FirstDisplayedScrollingRowIndex = firstRowIndex;
          ProgramsGridView.Rows[_selectedRowIndex].Selected = true;
        }
      } catch (Exception ex) {
        MessageBox.Show(ex.ToString());
      }
    }

    private void DataLoad2() {
      int firstRowIndex = 0;
      if (ServicesGridView.FirstDisplayedScrollingRowIndex > 0) {
        firstRowIndex = ServicesGridView.FirstDisplayedScrollingRowIndex;
      }
      try {
        _allClientServicesList = _ClientServicesProvider.GetAllClientServicesByClientId(_ClientId);
        LoadDataInServicesGridView(_allClientServicesList);
        if (_selectedRowIndex == ServicesGridView.Rows.Count) {
          _selectedRowIndex = ServicesGridView.Rows.Count - 1;
        }
        if (_selectedRowIndex >= 0) {
          ServicesGridView.FirstDisplayedScrollingRowIndex = firstRowIndex;
          ServicesGridView.Rows[_selectedRowIndex].Selected = true;
        }
      } catch (Exception ex) {
        MessageBox.Show(ex.ToString());
      }
    }

    private void LoadDataInProgramsGridView(List<ClientPrograms> AllProgramsList) {
      ProgramsGridView.DataSource = null;
      ProgramsGridView.Columns.Clear();
      ProgramsGridView.AutoGenerateColumns = false;
      ProgramsGridView.RowHeadersVisible = false;

      ProgramsGridView.DataSource = AllProgramsList;

      if (AllProgramsList.Count > 0) {
        if (AllProgramsList[0].Message == NamesMy.NoDataNames.NoDataInClientPrograms) {
          DataGridViewColumn dataColumn = new DataGridViewTextBoxColumn();
          dataColumn.DataPropertyName = "Message";
          dataColumn.Width = ProgramsGridView.Width - NamesMy.SizeOptins.MinusSizePanel;
          ProgramsGridView.Columns.Add(dataColumn);
        } else {
          DataGridViewColumn idColumn = new DataGridViewTextBoxColumn();
          idColumn.DataPropertyName = "ClientProgramsId";
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

    private void LoadDataInServicesGridView(List<ClientServices> AllServicesList) {
      ServicesGridView.DataSource = null;
      ServicesGridView.Columns.Clear();
      ServicesGridView.AutoGenerateColumns = false;
      ServicesGridView.RowHeadersVisible = false;

      ServicesGridView.DataSource = AllServicesList;

      if (AllServicesList.Count > 0) {
        if (AllServicesList[0].Message == NamesMy.NoDataNames.NoDataInClientServices) {
          DataGridViewColumn dataColumn = new DataGridViewTextBoxColumn();
          dataColumn.DataPropertyName = "Message";
          dataColumn.Width = ServicesGridView.Width - NamesMy.SizeOptins.MinusSizePanel;
          ServicesGridView.Columns.Add(dataColumn);
        } else {
          DataGridViewColumn idColumn = new DataGridViewTextBoxColumn();
          idColumn.DataPropertyName = "ClientServicesId";
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

    private void ProgramsGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
      if (e.ColumnIndex == 4) {
        if (MessageBox.Show("Ви дійсно бажаєте видалити?", "Видалити", MessageBoxButtons.YesNo) == DialogResult.Yes) {
          int selectedClientProgramsId = Convert.ToInt32(ProgramsGridView[0, e.RowIndex].Value.ToString());
          _ClientProgramsProvider.DeleteClientProgramsByClientProgramsId(selectedClientProgramsId);
          DataLoad();
        }
      }
    }

    private void ServicesGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
      if (e.ColumnIndex == 4) {
        if (MessageBox.Show("Ви дійсно бажаєте видалити?", "Видалити", MessageBoxButtons.YesNo) == DialogResult.Yes) {
          int selectedClientServicesId = Convert.ToInt32(ServicesGridView[0, e.RowIndex].Value.ToString());
          _ClientServicesProvider.DeleteClientServicesByClientServicesId(selectedClientServicesId);
          DataLoad2();
        }
      }
    }


  }
}
