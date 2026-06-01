using System;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicwizexternal?view=office-pia"/>
public partial class ILicWizExternal
{
  /// <summary>
  /// Invokes `PrintHtmlDocument`.
  /// </summary>
  /// <param name="punkHtmlDoc">The `punkHtmlDoc` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicwizexternal.printhtmldocument?view=office-pia"/>
  public void PrintHtmlDocument(object punkHtmlDoc) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `InvokeDateTimeApplet`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicwizexternal.invokedatetimeapplet?view=office-pia"/>
  public void InvokeDateTimeApplet() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `FormatDate`.
  /// </summary>
  /// <param name="date">The `date` parameter.</param>
  /// <param name="pFormat">The `pFormat` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicwizexternal.formatdate?view=office-pia"/>
  public string FormatDate(DateTime date, string pFormat) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `ShowHelp`.
  /// </summary>
  /// <param name="pvarId">The `pvarId` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicwizexternal.showhelp?view=office-pia"/>
  public void ShowHelp(ref object pvarId) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Terminate`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicwizexternal.terminate?view=office-pia"/>
  public void Terminate() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `DisableVORWReminder`.
  /// </summary>
  /// <param name="BPC">The `BPC` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicwizexternal.disablevorwreminder?view=office-pia"/>
  public void DisableVORWReminder(int BPC) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `SaveReceipt`.
  /// </summary>
  /// <param name="bstrReceipt">The `bstrReceipt` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicwizexternal.savereceipt?view=office-pia"/>
  public string SaveReceipt(string bstrReceipt) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `OpenInDefaultBrowser`.
  /// </summary>
  /// <param name="bstrUrl">The `bstrUrl` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicwizexternal.openindefaultbrowser?view=office-pia"/>
  public void OpenInDefaultBrowser(string bstrUrl) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `MsoAlert`.
  /// </summary>
  /// <param name="bstrText">The `bstrText` parameter.</param>
  /// <param name="bstrButtons">The `bstrButtons` parameter.</param>
  /// <param name="bstrIcon">The `bstrIcon` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicwizexternal.msoalert?view=office-pia"/>
  public int MsoAlert(string bstrText, string bstrButtons, string bstrIcon) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `DepositPidKey`.
  /// </summary>
  /// <param name="bstrKey">The `bstrKey` parameter.</param>
  /// <param name="fMORW">The `fMORW` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicwizexternal.depositpidkey?view=office-pia"/>
  public int DepositPidKey(string bstrKey, int fMORW) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `WriteLog`.
  /// </summary>
  /// <param name="bstrMessage">The `bstrMessage` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicwizexternal.writelog?view=office-pia"/>
  public void WriteLog(string bstrMessage) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `ResignDpc`.
  /// </summary>
  /// <param name="bstrProductCode">The `bstrProductCode` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicwizexternal.resigndpc?view=office-pia"/>
  public void ResignDpc(string bstrProductCode) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `ResetPID`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicwizexternal.resetpid?view=office-pia"/>
  public void ResetPID() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `SetDialogSize`.
  /// </summary>
  /// <param name="dx">The `dx` parameter.</param>
  /// <param name="dy">The `dy` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicwizexternal.setdialogsize?view=office-pia"/>
  public void SetDialogSize(int dx, int dy) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `VerifyClock`.
  /// </summary>
  /// <param name="lMode">The `lMode` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicwizexternal.verifyclock?view=office-pia"/>
  public int VerifyClock(int lMode) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `SortSelectOptions`.
  /// </summary>
  /// <param name="pdispSelect">The `pdispSelect` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicwizexternal.sortselectoptions?view=office-pia"/>
  public void SortSelectOptions(object pdispSelect) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `InternetDisconnect`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicwizexternal.internetdisconnect?view=office-pia"/>
  public void InternetDisconnect() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `GetConnectedState`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicwizexternal.getconnectedstate?view=office-pia"/>
  public int GetConnectedState() { throw new NotImplementedException(); }
}

