using CableTVApp.AppCode;
using CableTVApp.Provider;
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
  public partial class AccountingForServicesAndProgramsForm : Form {
    private int _selectedRowIndex = 0;
    ClientProvider _ClientProvider = new ClientProvider();
    List<Client> _ClientList = new List<Client>();

    public AccountingForServicesAndProgramsForm() {
      InitializeComponent();
      DataLoad();
    }

    private void ClientGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
      if (e.RowIndex >= 0 && ClientGridView[0, e.RowIndex].Value.ToString() != _ClientList[0].Message) {
        _selectedRowIndex = e.RowIndex;
        ServicesAndProgramsForm servicesAndProgramsForm = new ServicesAndProgramsForm(Convert.ToInt32(ClientGridView[0, e.RowIndex].Value.ToString()));
        servicesAndProgramsForm.ShowDialog();
        DataLoad();
      }
    }

    private void DataLoad() {
      int firstRowIndex = 0;
      if (ClientGridView.FirstDisplayedScrollingRowIndex > 0) {
        firstRowIndex = ClientGridView.FirstDisplayedScrollingRowIndex;
      }
      try {
        _ClientList = _ClientProvider.GetAllClient();
        LoadDataInClientGridView(_ClientList);
        if (_selectedRowIndex == ClientGridView.Rows.Count) {
          _selectedRowIndex = ClientGridView.Rows.Count - 1;
        }
        if (_selectedRowIndex >= 0) {
          ClientGridView.FirstDisplayedScrollingRowIndex = firstRowIndex;
          ClientGridView.Rows[_selectedRowIndex].Selected = true;
        }
      } catch { }
    }

    private void LoadDataInClientGridView(List<Client> ClientList) {
      ClientGridView.DataSource = null;
      ClientGridView.Columns.Clear();
      ClientGridView.AutoGenerateColumns = false;
      ClientGridView.RowHeadersVisible = false;

      ClientGridView.DataSource = ClientList;

      if (ClientList.Count > 0) {
        if (ClientList[0].Message == NamesMy.NoDataNames.NoDataInClient) {
          DataGridViewColumn messageColumn = new DataGridViewTextBoxColumn();
          messageColumn.DataPropertyName = "Message";
          messageColumn.Width = ClientGridView.Width - NamesMy.SizeOptins.MinusSizePanel;
          ClientGridView.Columns.Add(messageColumn);
        } else {
          DataGridViewColumn DetailIdColumn = new DataGridViewTextBoxColumn();
          DetailIdColumn.DataPropertyName = "ClientId";
          ClientGridView.Columns.Add(DetailIdColumn);
          ClientGridView.Columns[0].Visible = false;

          DataGridViewColumn numberColumn = new DataGridViewTextBoxColumn();
          numberColumn.HeaderText = "№ ";
          numberColumn.DataPropertyName = "Number";
          numberColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
          numberColumn.Width = NamesMy.SizeOptins.NumberSize;
          ClientGridView.Columns.Add(numberColumn);

          DataGridViewColumn LastNameColumn = new DataGridViewTextBoxColumn();
          LastNameColumn.HeaderText = "Прізвище";
          LastNameColumn.DataPropertyName = "LastName";
          LastNameColumn.Width = NamesMy.SizeOptins.NameSize;
          ClientGridView.Columns.Add(LastNameColumn);

          DataGridViewColumn FirstNameColumn = new DataGridViewTextBoxColumn();
          FirstNameColumn.HeaderText = "Ім'я";
          FirstNameColumn.DataPropertyName = "FirstName";
          FirstNameColumn.Width = NamesMy.SizeOptins.NameSize;
          ClientGridView.Columns.Add(FirstNameColumn);

          DataGridViewColumn PhoneColumn = new DataGridViewTextBoxColumn();
          PhoneColumn.HeaderText = "№ телефону";
          PhoneColumn.DataPropertyName = "Phone";
          PhoneColumn.Width = NamesMy.SizeOptins.NameSize;
          ClientGridView.Columns.Add(PhoneColumn);

        }
        for (int i = 0; i < ClientGridView.Columns.Count; i++) {
          ClientGridView.Columns[i].HeaderCell.Style.BackColor = Color.LightGray;
        }
      }
    }

  }
}
