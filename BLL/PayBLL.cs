using CableTVApp.Provider;
using CableTVApp.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CableTVApp.BLL {
  class PayBLL {
    ClientProgramsProvider _ClientProgramsProvider = new ClientProgramsProvider();
    ClientServicesProvider _ClientServicesProvider = new ClientServicesProvider();
    ClientProvider _ClientProvider = new ClientProvider();
    ClientPayProvider _ClientPayProvider = new ClientPayProvider();
    CategoryProvider _CategoryProvider = new CategoryProvider();
    FilmsProvider _FilmsProvider = new FilmsProvider();
    public List<ClientPay> GetAllClientPayList() {
      List<ClientPay> clientPayList = new List<ClientPay>();
      List<Client> clientList = new List<Client>();
      List<ClientPrograms> clientProgramsList = new List<ClientPrograms>();
      List<ClientServices> clientServicesList = new List<ClientServices>();

      clientList = _ClientProvider.GetAllClient();
      clientProgramsList = _ClientProgramsProvider.GetAllClientPrograms();
      clientServicesList = _ClientServicesProvider.GetAllClientServices();

      for (int i = 0; i < clientList.Count; i++) {
        ClientPay oneClientPay = new ClientPay();
        oneClientPay.ClientId = clientList[i].ClientId;
        oneClientPay.FIO = clientList[i].FIO;
        oneClientPay.PayNecessary = GetPriceForClient(clientList[i].ClientId, clientProgramsList, clientServicesList);
        clientPayList.Add(oneClientPay);
      }
      return clientPayList;
    }

    public List<ClientDebtors> GetDebtors() {
      List<ClientDebtors> clientDebtorsList = new List<ClientDebtors>();
      List<Client> clientList = new List<Client>();
      clientList = _ClientProvider.GetAllClient();

      for (int i = 0; i < clientList.Count; i++) {
        ClientDebtors oneClientDebtors = new ClientDebtors();
        List<ClientPay> clientPayList = new List<ClientPay>();
        clientPayList = _ClientPayProvider.GetAllPayForOneClient(clientList[i].ClientId);
        oneClientDebtors.ClientId = clientList[i].ClientId;
        oneClientDebtors.FIO = clientList[i].FIO;
        oneClientDebtors.AllDebtors = GetDebtorsForOneClient(clientPayList);
        oneClientDebtors.LastMounthDebtors = GetLastDebtorsForOneClient(clientPayList);
        if (oneClientDebtors.AllDebtors < 0) {
          clientDebtorsList.Add(oneClientDebtors);
        }
      }

      for (int i = 0; i < clientDebtorsList.Count; i++) {
        clientDebtorsList[i].Number = i + 1;
      }

      return clientDebtorsList;
    }

    public BroadcastPrograms GetBroadcastPrograms() {
      List<Category> categoryList = new List<Category>();
      categoryList = _CategoryProvider.GetAllCategory();
      BroadcastPrograms oneBroadcastPrograms = new BroadcastPrograms();
      oneBroadcastPrograms.CategoryList = categoryList;
      oneBroadcastPrograms.CategoryCount = categoryList.Count;
      oneBroadcastPrograms.FilmsCount = _FilmsProvider.GetAllFilms().Count;
      oneBroadcastPrograms.Profit = _ClientPayProvider.GetAllPay();
      return oneBroadcastPrograms;
    }

    private double GetDebtorsForOneClient(List<ClientPay> ClientPayList) {
      double debtors = 0.0;
      for (int i = 0; i < ClientPayList.Count; i++) {
        debtors += ClientPayList[i].Paid - ClientPayList[i].PayNecessary;
      }
      return debtors;
    }

    private double GetLastDebtorsForOneClient(List<ClientPay> ClientPayList) {
      int lastRecords = 0;
      double debtors = 0.0;
      for (int i = 0; i < ClientPayList.Count; i++) {
        if (lastRecords > ClientPayList[i].ClientPayId) {
          lastRecords = ClientPayList[i].ClientPayId;
        }
      }

      for (int i = 0; i < ClientPayList.Count; i++) {
        if (lastRecords == ClientPayList[i].ClientPayId) {
          debtors = ClientPayList[i].PayNecessary - ClientPayList[i].Paid;
        }
      }
      return debtors;
    }

    private double GetPriceForClient(int ClientId, List<ClientPrograms> ClientProgramsList, List<ClientServices> ClientServicesList) {
      double sum = 0.0;
      for (int i = 0; i < ClientProgramsList.Count; i++) {
        if (ClientId == ClientProgramsList[i].ClientId) {
          sum += ClientProgramsList[i].Price;
        }
      }

      for (int i = 0; i < ClientServicesList.Count; i++) {
        if (ClientId == ClientServicesList[i].ClientId) {
          sum += ClientServicesList[i].Price;
        }
      }

      return sum;
    }

  }
}


public class ClientDebtors {
  private int _Number;
  private int _ClientPayId;
  private double _AllDebtors;
  private double _LastMounthDebtors;
  private string _FIO;
  private int _ClientId;
  private string _Message;

  public ClientDebtors() {
    _Number = 0;
    _ClientPayId = 0;
    _AllDebtors = 0;
    _ClientId = 0;
    _FIO = String.Empty;
    _LastMounthDebtors = 0;
    _Message = String.Empty;
  }

  public int Number {
    set { _Number = value; }
    get { return _Number; }
  }
  public int ClientPayId {
    set { _ClientPayId = value; }
    get { return _ClientPayId; }
  }
  public double AllDebtors {
    set { _AllDebtors = value; }
    get { return _AllDebtors; }
  }
  public int ClientId {
    set { _ClientId = value; }
    get { return _ClientId; }
  }
  public string FIO {
    set { _FIO = value; }
    get { return _FIO; }
  }
  public double LastMounthDebtors {
    set { _LastMounthDebtors = value; }
    get { return _LastMounthDebtors; }
  }
  public string Message {
    set { _Message = value; }
    get { return _Message; }
  }
}

public class BroadcastPrograms {
  private int _Number;
  private int _CategoryCount;
  private List<Category> _CategoryList;
  private int _FilmsCount;
  private double _Profit;
  private string _Message;

  public BroadcastPrograms() {
    _Number = 0;
    _CategoryCount = 0;
    _CategoryList = new List<Category>();
    _FilmsCount = 0;
    _Profit = 0.0;
    _Message = String.Empty;
  }

  public int Number {
    set { _Number = value; }
    get { return _Number; }
  }
  public int CategoryCount {
    set { _CategoryCount = value; }
    get { return _CategoryCount; }
  }
  public List<Category> CategoryList {
    set { _CategoryList = value; }
    get { return _CategoryList; }
  }
  public int FilmsCount {
    set { _FilmsCount = value; }
    get { return _FilmsCount; }
  }
  public double Profit {
    set { _Profit = value; }
    get { return _Profit; }
  }
  public string Message {
    set { _Message = value; }
    get { return _Message; }
  }
}