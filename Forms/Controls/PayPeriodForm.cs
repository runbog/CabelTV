using CableTVApp.AppCode;
using CableTVApp.BLL;
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
  public partial class PayPeriodForm : Form {
    private int _selectedRowIndex = 0;
    private ValidationMy _validation = new ValidationMy();
    private PayPeriodProvider _PayPeriodProvider = new PayPeriodProvider();
    private List<PayPeriod> _PayPeriodList = new List<PayPeriod>();
    private ClientProvider _ClientProvider = new ClientProvider();
    private List<Client> _ClientList = new List<Client>();
    private ClientPayProvider _ClientPayProvider = new ClientPayProvider();
    private List<ClientPay> _ClientPayList = new List<ClientPay>();
    private PayBLL _PayBLL = new PayBLL();

    public PayPeriodForm() {
      InitializeComponent();
      DataLoad();
    }

    private void FormingBtn_Click(object sender, EventArgs e) {
      if (IsDataEnteringCorrect()) {
        FormingStatement();
      }
    }

    private void AddBtn_Click(object sender, EventArgs e) {
      if (IsDataEnteringCorrect() && _ClientPayList.Count > 0) {
        _PayPeriodProvider.InsertPayPeriod(PayPeriodNameTBox.Text, DescriptionTBox.Text, PayDateDTP.Value);
        int lastPayPeriod = _PayPeriodProvider.GetLastRecords();
        for (int i = 0; i < _ClientPayList.Count; i++) {
          _ClientPayList[i].PayPeriodId = lastPayPeriod;
        }
        for (int i = 0; i < ClientPayDGV.RowCount; i++) {
          _ClientPayList[i].Paid = Convert.ToDouble(ClientPayDGV["Paid", i].Value);
        }
        _ClientPayProvider.InsertBatchService(_ClientPayList);

        ClearAllControls();
        DataLoad();
      }
    }

    private void ClearBtn_Click(object sender, EventArgs e) {
      ClearAllControls();

    }

    private void ExitBtn_Click(object sender, EventArgs e) {
      this.Close();
    }

    private void PayPeroodGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
      if (e.ColumnIndex == 4) {
        if (MessageBox.Show("Ви дійсно бажаєте видалити цю відомість?", "Видалити", MessageBoxButtons.YesNo) == DialogResult.Yes) {
          int selectedPeriodId = Convert.ToInt32(PayPeriodGridView[0, e.RowIndex].Value.ToString());
          _PayPeriodProvider.DeletePayPeriodByPayPeriodId(selectedPeriodId);
          _ClientPayProvider.DeleteClientPayByPayPeriodId(selectedPeriodId);
          DataLoad();
        }
      } else if (e.RowIndex >= 0 && PayPeriodGridView[0, e.RowIndex].Value.ToString() != _PayPeriodList[0].Message) {
        _selectedRowIndex = e.RowIndex;
        UpdatePayPeriodForm updatePayPeriodForm = new UpdatePayPeriodForm(Convert.ToInt32(PayPeriodGridView[0, e.RowIndex].Value.ToString()));
        updatePayPeriodForm.ShowDialog();
        DataLoad();
      }
    }

    private void DataLoad() {
      int firstRowIndex = 0;
      if (PayPeriodGridView.FirstDisplayedScrollingRowIndex > 0) {
        firstRowIndex = PayPeriodGridView.FirstDisplayedScrollingRowIndex;
      }
      try {
        _PayPeriodList = _PayPeriodProvider.GetAllPayPeriod();
        LoadDataInPayPeriodGridView(_PayPeriodList);
        if (_selectedRowIndex == PayPeriodGridView.Rows.Count) {
          _selectedRowIndex = PayPeriodGridView.Rows.Count - 1;
        }
        if (_selectedRowIndex >= 0) {
          PayPeriodGridView.FirstDisplayedScrollingRowIndex = firstRowIndex;
          PayPeriodGridView.Rows[_selectedRowIndex].Selected = true;
        }
      } catch { }
    }

    private void LoadDataInPayPeriodGridView(List<PayPeriod> PayPeriodList) {
      PayPeriodGridView.DataSource = null;
      PayPeriodGridView.Columns.Clear();
      PayPeriodGridView.AutoGenerateColumns = false;
      PayPeriodGridView.RowHeadersVisible = false;

      PayPeriodGridView.DataSource = PayPeriodList;

      if (PayPeriodList.Count > 0) {
        if (PayPeriodList[0].Message == NamesMy.NoDataNames.NoDataInPayPeriod) {
          DataGridViewColumn messageColumn = new DataGridViewTextBoxColumn();
          messageColumn.DataPropertyName = "Message";
          messageColumn.Width = PayPeriodGridView.Width - NamesMy.SizeOptins.MinusSizePanel;
          PayPeriodGridView.Columns.Add(messageColumn);
        } else {
          DataGridViewColumn DetailIdColumn = new DataGridViewTextBoxColumn();
          DetailIdColumn.DataPropertyName = "PayPeriodId";
          PayPeriodGridView.Columns.Add(DetailIdColumn);
          PayPeriodGridView.Columns[0].Visible = false;

          DataGridViewColumn numberColumn = new DataGridViewTextBoxColumn();
          numberColumn.HeaderText = "№ ";
          numberColumn.DataPropertyName = "Number";
          numberColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
          numberColumn.Width = NamesMy.SizeOptins.NumberSize;
          PayPeriodGridView.Columns.Add(numberColumn);

          DataGridViewColumn PayPeriodNameColumn = new DataGridViewTextBoxColumn();
          PayPeriodNameColumn.HeaderText = "Назва відомості";
          PayPeriodNameColumn.DataPropertyName = "PayPeriodName";
          PayPeriodNameColumn.Width = NamesMy.SizeOptins.NameSize;
          PayPeriodGridView.Columns.Add(PayPeriodNameColumn);

          DataGridViewColumn DateOfCompletionColumn = new DataGridViewTextBoxColumn();
          DateOfCompletionColumn.HeaderText = "Дата оплати";
          DateOfCompletionColumn.DataPropertyName = "PayDate";
          DateOfCompletionColumn.DefaultCellStyle.Format = "dd/MM/yyyy";
          DateOfCompletionColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
          DateOfCompletionColumn.Width = 100;
          PayPeriodGridView.Columns.Add(DateOfCompletionColumn);

          DataGridViewButtonColumn deleteBtn = new DataGridViewButtonColumn();
          deleteBtn.HeaderText = NamesMy.ProgramButtons.DeleteBtn;
          deleteBtn.Text = NamesMy.ProgramButtons.DeleteBtn;
          deleteBtn.UseColumnTextForButtonValue = true;
          deleteBtn.ToolTipText = NamesMy.ProgramButtons.DeleteBtn;
          deleteBtn.Width = NamesMy.SizeOptins.DeleteBtnSize;
          PayPeriodGridView.Columns.Add(deleteBtn);
        }
        for (int i = 0; i < PayPeriodGridView.Columns.Count; i++) {
          PayPeriodGridView.Columns[i].HeaderCell.Style.BackColor = Color.LightGray;
        }
      }
    }

    private void ClearAllControls() {
      PayPeriodNameTBox.Text = String.Empty;
      _ClientPayList.Clear();
      LoadDataInClientPayDGV(_ClientPayList);
    }

    private bool IsDataEnteringCorrect() {
      bool isCorrect = true;
      if (_validation.IsDataEntering(PayPeriodNameTBox.Text)) {
        PayPeriodNameValiadtionLbl.Text = NamesMy.ProgramButtons.RequiredValidation;
      } else {
        PayPeriodNameValiadtionLbl.Text = NamesMy.ProgramButtons.ErrorValidation;
        isCorrect = false;
      }
      return isCorrect;
    }

    private void FormingStatement() {
      _ClientPayList.Clear();
      _ClientPayList = _PayBLL.GetAllClientPayList();
      LoadDataInClientPayDGV(_ClientPayList);
    }

    private void LoadDataInClientPayDGV(List<ClientPay> ClientPayList) {
      ClientPayDGV.DataSource = null;
      ClientPayDGV.Columns.Clear();
      ClientPayDGV.AutoGenerateColumns = false;
      ClientPayDGV.RowHeadersVisible = false;

      ClientPayDGV.DataSource = ClientPayList;

      if (ClientPayList.Count > 0) {
        if (ClientPayList[0].Message == NamesMy.NoDataNames.NoDataInClientPay) {
          DataGridViewColumn messageColumn = new DataGridViewTextBoxColumn();
          messageColumn.DataPropertyName = "Message";
          messageColumn.Width = PayPeriodGridView.Width - NamesMy.SizeOptins.MinusSizePanel;
          ClientPayDGV.Columns.Add(messageColumn);
        } else {

          DataGridViewColumn PayPeriodNameColumn = new DataGridViewTextBoxColumn();
          PayPeriodNameColumn.HeaderText = "П.І.Б.";
          PayPeriodNameColumn.DataPropertyName = "FIO";
          PayPeriodNameColumn.Width = 280;
          ClientPayDGV.Columns.Add(PayPeriodNameColumn);

          DataGridViewColumn PayNecessaryColumn = new DataGridViewTextBoxColumn();
          PayNecessaryColumn.HeaderText = "До сплати";
          PayNecessaryColumn.DataPropertyName = "PayNecessary";
          PayNecessaryColumn.Width = 95;
          PayNecessaryColumn.ReadOnly = true;
          PayNecessaryColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
          ClientPayDGV.Columns.Add(PayNecessaryColumn);

          DataGridViewColumn PaidColumn = new DataGridViewTextBoxColumn();
          PaidColumn.HeaderText = "Оплачено";
          PaidColumn.DataPropertyName = "Paid";
          PaidColumn.Name = "Paid";
          PaidColumn.Width = 95;
          PaidColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
          ClientPayDGV.Columns.Add(PaidColumn);
        }
        for (int i = 0; i < ClientPayDGV.Columns.Count; i++) {
          ClientPayDGV.Columns[i].HeaderCell.Style.BackColor = Color.LightGray;
        }
      }
    }

  }
}
