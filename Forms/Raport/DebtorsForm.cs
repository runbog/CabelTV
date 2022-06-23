using CableTVApp.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CableTVApp.Forms.Raport {
  public partial class DebtorsForm : Form {
    PayBLL _PayBLL = new PayBLL();
    List<ClientDebtors> _ClientDebtorsList = new List<ClientDebtors>();
    public DebtorsForm() {
      InitializeComponent();
      _ClientDebtorsList = _PayBLL.GetDebtors();
      GetRaport(_ClientDebtorsList);
    }

    public void GetRaport(List<ClientDebtors> ClientDebtorsList) {
      RaportTBox.Text += "Список боржників:\r\n";
      RaportTBox.Text = String.Format("{0,3}|{1, -40}|{2, 20}|{3, 20}|\r\n", "№", "Боржник", "Загальний борг", "Останній місяць");
      for (int i = 0; i < ClientDebtorsList.Count(); i++) {
        string raportString = String.Format("{0,3}|{1, -40}|{2, 20}|{3, 20}|\r\n",
        ClientDebtorsList[i].Number, ClientDebtorsList[i].FIO, ClientDebtorsList[i].AllDebtors, ClientDebtorsList[i].LastMounthDebtors);
        RaportTBox.Text += raportString;
      }
    }

  }
}
