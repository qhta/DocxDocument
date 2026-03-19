using System;

namespace DocumentModel.Interop.Core;

public interface ILicWizExternal
{
  void PrintHtmlDocument(object punkHtmlDoc);
  void InvokeDateTimeApplet();
  string FormatDate(DateTime date, string pFormat = "");
  void ShowHelp(ref object pvarId);
  void Terminate();
  void DisableVORWReminder(int BPC);
  string SaveReceipt(string bstrReceipt);
  void OpenInDefaultBrowser(string bstrUrl);
  int MsoAlert(string bstrText, string bstrButtons, string bstrIcon);
  int DepositPidKey(string bstrKey, int fMORW);
  void WriteLog(string bstrMessage);
  void ResignDpc(string bstrProductCode);
  void ResetPID();
  void SetDialogSize(int dx, int dy);
  int VerifyClock(int lMode);
  void SortSelectOptions(object pdispSelect);
  void InternetDisconnect();
  int GetConnectedState();
  int Context { get; }
  object Validator { get; }
  object LicAgent { get; }
  string CountryInfo { get; }
  int WizardVisible { set; }
  string WizardTitle { set; }
  int AnimationEnabled { get; }
  int CurrentHelpId { set; }
  string OfficeOnTheWebUrl { get; }
}