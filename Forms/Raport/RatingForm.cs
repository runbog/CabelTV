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
  public partial class RatingForm : Form {
    PayBLL _PayBLL = new PayBLL();
    BroadcastPrograms _BroadcastPrograms = new BroadcastPrograms();

    public RatingForm() {
      InitializeComponent();
      _BroadcastPrograms = _PayBLL.GetBroadcastPrograms();
      GetRaport(_BroadcastPrograms);

    }

    public void GetRaport(BroadcastPrograms ALLBroadcastProgram) {
      RaportTBox.Text = "Рейтинг по трансльованих програмах\r\n";
      RaportTBox.Text += "Кількість категорій: " + ALLBroadcastProgram.CategoryCount + "\r\n";
      RaportTBox.Text += "Кількість фільмів: " + ALLBroadcastProgram.FilmsCount + "\r\n";
      RaportTBox.Text += "Сумарна оплата: " + ALLBroadcastProgram.Profit + "\r\n";

    }
  }
}
