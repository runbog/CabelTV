using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CableTVApp.AppCode;
using CableTVApp.Provider;

namespace CableTVApp.Forms.Dictionary {
  public partial class ClientForm : Form {
    private int _selectedRowIndex = 0;
    private ValidationMy _validation = new ValidationMy();
    ClientProvider _ClientProvider = new ClientProvider();
    List<Client> _ClientList = new List<Client>();

    public ClientForm() {
      InitializeComponent();
      DataLoad();
    }
    private void AddBtn_Click(object sender, EventArgs e) {
      if (IsDataEnteringCorrect()) {
        _ClientProvider.InsertClient(LastNameTBox.Text, FirstNameTBox.Text, PhoneTBox.Text);
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

    private void ClearAllControls() {
      LastNameTBox.Text = String.Empty;
      FirstNameTBox.Text = String.Empty;
      PhoneTBox.Text = String.Empty;
    }

    private bool IsDataEnteringCorrect() {
      bool isCorrect = true;
      if (_validation.IsDataEntering(LastNameTBox.Text)) {
        LastNameValiadtionLbl.Text = NamesMy.ProgramButtons.RequiredValidation;
      } else {
        LastNameValiadtionLbl.Text = NamesMy.ProgramButtons.ErrorValidation;
        isCorrect = false;
      }
      if (_validation.IsDataEntering(FirstNameTBox.Text)) {
        FirstNameValiadtionLbl.Text = NamesMy.ProgramButtons.RequiredValidation;
      } else {
        FirstNameValiadtionLbl.Text = NamesMy.ProgramButtons.ErrorValidation;
        isCorrect = false;
      }
      if (_validation.IsDataEntering(PhoneTBox.Text)) {
        PhoneValiadtionLbl.Text = NamesMy.ProgramButtons.RequiredValidation;
      } else {
        PhoneValiadtionLbl.Text = NamesMy.ProgramButtons.ErrorValidation;
        isCorrect = false;
      }
      return isCorrect;
    }

    private void ClientGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
      if (e.RowIndex >= 0 && ClientGridView[0, e.RowIndex].Value.ToString() != _ClientList[0].Message) {
        _selectedRowIndex = e.RowIndex;
        UpdateClientForm updateClientForm = new UpdateClientForm(Convert.ToInt32(ClientGridView[0, e.RowIndex].Value.ToString()));
        updateClientForm.ShowDialog();
        DataLoad();
      }
    }
  }
}
