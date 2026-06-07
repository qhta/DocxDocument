using System;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicwizexternal?view=office-pia"/>
public interface ILicWizExternal
{
  /// <summary>
  /// Gets or sets the `Context` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicwizexternal.context?view=office-pia"/>
  public int Context { get; }
  /// <summary>
  /// Gets the `Validator` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicwizexternal.validator?view=office-pia"/>
  public object Validator { get; }
  /// <summary>
  /// Gets the `LicAgent` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicwizexternal.licagent?view=office-pia"/>
  public object LicAgent { get; }
  /// <summary>
  /// Gets the `CountryInfo` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicwizexternal.countryinfo?view=office-pia"/>
  public string CountryInfo { get; }
  /// <summary>
  /// Sets whether the licensing wizard is visible.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicwizexternal.wizardvisible?view=office-pia"/>
  public int WizardVisible { set; }
  /// <summary>
  /// Sets the title of the licensing wizard.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicwizexternal.wizardtitle?view=office-pia"/>
  public string WizardTitle { set; }
  /// <summary>
  /// Gets the `AnimationEnabled` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicwizexternal.animationenabled?view=office-pia"/>
  public int AnimationEnabled { get; }
  /// <summary>
  /// Sets the current Help topic identifier.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicwizexternal.currenthelpid?view=office-pia"/>
  public int CurrentHelpId { set; }
  /// <summary>
  /// Gets the `OfficeOnTheWebUrl` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicwizexternal.officeontheweburl?view=office-pia"/>
  public string OfficeOnTheWebUrl { get; }


  #region methods

/// <summary>
  /// Invokes `PrintHtmlDocument`.
  /// </summary>
  /// <param name="punkHtmlDoc">The `punkHtmlDoc` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicwizexternal.printhtmldocument?view=office-pia"/>
  public void PrintHtmlDocument(object punkHtmlDoc);
  /// <summary>
  /// Invokes `InvokeDateTimeApplet`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicwizexternal.invokedatetimeapplet?view=office-pia"/>
  public void InvokeDateTimeApplet();
  /// <summary>
  /// Invokes `FormatDate`.
  /// </summary>
  /// <param name="date">The `date` parameter.</param>
  /// <param name="pFormat">The `pFormat` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicwizexternal.formatdate?view=office-pia"/>
  public string FormatDate(DateTime date, string pFormat);
  /// <summary>
  /// Invokes `ShowHelp`.
  /// </summary>
  /// <param name="pvarId">The `pvarId` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicwizexternal.showhelp?view=office-pia"/>
  public void ShowHelp(ref object pvarId);
  /// <summary>
  /// Invokes `Terminate`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicwizexternal.terminate?view=office-pia"/>
  public void Terminate();
  /// <summary>
  /// Invokes `DisableVORWReminder`.
  /// </summary>
  /// <param name="bPC">The `BPC` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicwizexternal.disablevorwreminder?view=office-pia"/>
  public void DisableVORWReminder(int bPC);
  /// <summary>
  /// Invokes `SaveReceipt`.
  /// </summary>
  /// <param name="bstrReceipt">The `bstrReceipt` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicwizexternal.savereceipt?view=office-pia"/>
  public string SaveReceipt(string bstrReceipt);
  /// <summary>
  /// Invokes `OpenInDefaultBrowser`.
  /// </summary>
  /// <param name="bstrUrl">The `bstrUrl` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicwizexternal.openindefaultbrowser?view=office-pia"/>
  public void OpenInDefaultBrowser(string bstrUrl);
  /// <summary>
  /// Invokes `MsoAlert`.
  /// </summary>
  /// <param name="bstrText">The `bstrText` parameter.</param>
  /// <param name="bstrButtons">The `bstrButtons` parameter.</param>
  /// <param name="bstrIcon">The `bstrIcon` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicwizexternal.msoalert?view=office-pia"/>
  public int MsoAlert(string bstrText, string bstrButtons, string bstrIcon);
  /// <summary>
  /// Invokes `DepositPidKey`.
  /// </summary>
  /// <param name="bstrKey">The `bstrKey` parameter.</param>
  /// <param name="fMORW">The `fMORW` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicwizexternal.depositpidkey?view=office-pia"/>
  public int DepositPidKey(string bstrKey, int fMORW);
  /// <summary>
  /// Invokes `WriteLog`.
  /// </summary>
  /// <param name="bstrMessage">The `bstrMessage` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicwizexternal.writelog?view=office-pia"/>
  public void WriteLog(string bstrMessage);
  /// <summary>
  /// Invokes `ResignDpc`.
  /// </summary>
  /// <param name="bstrProductCode">The `bstrProductCode` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicwizexternal.resigndpc?view=office-pia"/>
  public void ResignDpc(string bstrProductCode);
  /// <summary>
  /// Invokes `ResetPID`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicwizexternal.resetpid?view=office-pia"/>
  public void ResetPID();
  /// <summary>
  /// Invokes `SetDialogSize`.
  /// </summary>
  /// <param name="dx">The `dx` parameter.</param>
  /// <param name="dy">The `dy` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicwizexternal.setdialogsize?view=office-pia"/>
  public void SetDialogSize(int dx, int dy);
  /// <summary>
  /// Invokes `VerifyClock`.
  /// </summary>
  /// <param name="lMode">The `lMode` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicwizexternal.verifyclock?view=office-pia"/>
  public int VerifyClock(int lMode);
  /// <summary>
  /// Invokes `SortSelectOptions`.
  /// </summary>
  /// <param name="pdispSelect">The `pdispSelect` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicwizexternal.sortselectoptions?view=office-pia"/>
  public void SortSelectOptions(object pdispSelect);
  /// <summary>
  /// Invokes `InternetDisconnect`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicwizexternal.internetdisconnect?view=office-pia"/>
  public void InternetDisconnect();
  /// <summary>
  /// Invokes `GetConnectedState`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicwizexternal.getconnectedstate?view=office-pia"/>
  public int GetConnectedState();

  #endregion methods
}

