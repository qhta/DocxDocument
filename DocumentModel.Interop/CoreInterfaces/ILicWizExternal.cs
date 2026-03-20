using System;

namespace DocumentModel.Interop.Core;

public interface ILicWizExternal
{
  public void PrintHtmlDocument(object punkHtmlDoc);
  public void InvokeDateTimeApplet();
  public string FormatDate(DateTime date, string pFormat);
  public void ShowHelp(ref object pvarId);
  public void Terminate();
  public void DisableVORWReminder(int BPC);
  public string SaveReceipt(string bstrReceipt);
  public void OpenInDefaultBrowser(string bstrUrl);
  public int MsoAlert(string bstrText, string bstrButtons, string bstrIcon);
  public int DepositPidKey(string bstrKey, int fMORW);
  public void WriteLog(string bstrMessage);
  public void ResignDpc(string bstrProductCode);
  public void ResetPID();
  public void SetDialogSize(int dx, int dy);
  public int VerifyClock(int lMode);
  public void SortSelectOptions(object pdispSelect);
  public void InternetDisconnect();
  public int GetConnectedState();
  public int Context { get; }
  public object Validator { get; }
  public object LicAgent { get; }
  public string CountryInfo { get; }
  public int WizardVisible { set; }
  public string WizardTitle { set; }
  public int AnimationEnabled { get; }
  public int CurrentHelpId { set; }
  public string OfficeOnTheWebUrl { get; }
}
