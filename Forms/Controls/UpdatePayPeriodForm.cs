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

namespace CableTVApp.Forms.Controls {
  public partial class UpdatePayPeriodForm : Form {
    private int _selectedRowIndex = 0;
    private ClientPayProvider _ClientPayProvider = new ClientPayProvider();
    private List<ClientPay> _ClientPayList = new List<ClientPay>();
    private int _PayPeriodId = 0;

    public UpdatePayPeriodForm(int PayPeriodId) {
      InitializeComponent();
      _PayPeriodId = PayPeriodId;
      DataLoad();
    }

    private void DataLoad() {
      int firstRowIndex = 0;
      if (ClientPayDGV.FirstDisplayedScrollingRowIndex > 0) {
        firstRowIndex = ClientPayDGV.FirstDisplayedScrollingRowIndex;
      }
      try {
        _ClientPayList = _ClientPayProvider.GetAllClientPay(_PayPeriodId);
        LoadDataInClientPayDGV(_ClientPayList);
        if (_selectedRowIndex == ClientPayDGV.Rows.Count) {
          _selectedRowIndex = ClientPayDGV.Rows.Count - 1;
        }
        if (_selectedRowIndex >= 0) {
          ClientPayDGV.FirstDisplayedScrollingRowIndex = firstRowIndex;
          ClientPayDGV.Rows[_selectedRowIndex].Selected = true;
        }
      } catch { }
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
          messageColumn.Width = ClientPayDGV.Width - NamesMy.SizeOptins.MinusSizePanel;
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

    private void AddBtn_Click(object sender, EventArgs e) {
      for (int i = 0; i < ClientPayDGV.RowCount; i++) {
        _ClientPayList[i].Paid = Convert.ToDouble(ClientPayDGV["Paid", i].Value);
      }
      _ClientPayProvider.UpdateBatchService(_ClientPayList);
      this.Close();
    }

    private void ExitBtn_Click(object sender, EventArgs e) {
      this.Close();
    }
  }
}
