using System;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent?view=office-pia"/>
public partial interface ILicAgent
{


  #region methods

/// <summary>
  /// Invokes `Initialize`.
  /// </summary>
  /// <param name="dwBPC">The `dwBPC` parameter.</param>
  /// <param name="dwMode">The `dwMode` parameter.</param>
  /// <param name="bstrLicSource">The `bstrLicSource` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.initialize?view=office-pia"/>
  public uint Initialize(uint dwBPC, uint dwMode, string bstrLicSource);
  /// <summary>
  /// Invokes `GetFirstName`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getfirstname?view=office-pia"/>
  public string GetFirstName();
  /// <summary>
  /// Invokes `SetFirstName`.
  /// </summary>
  /// <param name="bstrNewVal">The `bstrNewVal` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.setfirstname?view=office-pia"/>
  public void SetFirstName(string bstrNewVal);
  /// <summary>
  /// Invokes `GetLastName`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getlastname?view=office-pia"/>
  public string GetLastName();
  /// <summary>
  /// Invokes `SetLastName`.
  /// </summary>
  /// <param name="bstrNewVal">The `bstrNewVal` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.setlastname?view=office-pia"/>
  public void SetLastName(string bstrNewVal);
  /// <summary>
  /// Invokes `GetOrgName`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getorgname?view=office-pia"/>
  public string GetOrgName();
  /// <summary>
  /// Invokes `SetOrgName`.
  /// </summary>
  /// <param name="bstrNewVal">The `bstrNewVal` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.setorgname?view=office-pia"/>
  public void SetOrgName(string bstrNewVal);
  /// <summary>
  /// Invokes `GetEmail`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getemail?view=office-pia"/>
  public string GetEmail();
  /// <summary>
  /// Invokes `SetEmail`.
  /// </summary>
  /// <param name="bstrNewVal">The `bstrNewVal` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.setemail?view=office-pia"/>
  public void SetEmail(string bstrNewVal);
  /// <summary>
  /// Invokes `GetPhone`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getphone?view=office-pia"/>
  public string GetPhone();
  /// <summary>
  /// Invokes `SetPhone`.
  /// </summary>
  /// <param name="bstrNewVal">The `bstrNewVal` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.setphone?view=office-pia"/>
  public void SetPhone(string bstrNewVal);
  /// <summary>
  /// Invokes `GetAddress1`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getaddress1?view=office-pia"/>
  public string GetAddress1();
  /// <summary>
  /// Invokes `SetAddress1`.
  /// </summary>
  /// <param name="bstrNewVal">The `bstrNewVal` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.setaddress1?view=office-pia"/>
  public void SetAddress1(string bstrNewVal);
  /// <summary>
  /// Invokes `GetCity`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getcity?view=office-pia"/>
  public string GetCity();
  /// <summary>
  /// Invokes `SetCity`.
  /// </summary>
  /// <param name="bstrNewVal">The `bstrNewVal` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.setcity?view=office-pia"/>
  public void SetCity(string bstrNewVal);
  /// <summary>
  /// Invokes `GetState`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getstate?view=office-pia"/>
  public string GetState();
  /// <summary>
  /// Invokes `SetState`.
  /// </summary>
  /// <param name="bstrNewVal">The `bstrNewVal` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.setstate?view=office-pia"/>
  public void SetState(string bstrNewVal);
  /// <summary>
  /// Invokes `GetCountryCode`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getcountrycode?view=office-pia"/>
  public string GetCountryCode();
  /// <summary>
  /// Invokes `SetCountryCode`.
  /// </summary>
  /// <param name="bstrNewVal">The `bstrNewVal` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.setcountrycode?view=office-pia"/>
  public void SetCountryCode(string bstrNewVal);
  /// <summary>
  /// Invokes `GetCountryDesc`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getcountrydesc?view=office-pia"/>
  public string GetCountryDesc();
  /// <summary>
  /// Invokes `SetCountryDesc`.
  /// </summary>
  /// <param name="bstrNewVal">The `bstrNewVal` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.setcountrydesc?view=office-pia"/>
  public void SetCountryDesc(string bstrNewVal);
  /// <summary>
  /// Invokes `GetZip`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getzip?view=office-pia"/>
  public string GetZip();
  /// <summary>
  /// Invokes `SetZip`.
  /// </summary>
  /// <param name="bstrNewVal">The `bstrNewVal` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.setzip?view=office-pia"/>
  public void SetZip(string bstrNewVal);
  /// <summary>
  /// Invokes `GetIsoLanguage`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getisolanguage?view=office-pia"/>
  public uint GetIsoLanguage();
  /// <summary>
  /// Invokes `SetIsoLanguage`.
  /// </summary>
  /// <param name="dwNewVal">The `dwNewVal` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.setisolanguage?view=office-pia"/>
  public void SetIsoLanguage(uint dwNewVal);
  /// <summary>
  /// Invokes `GetMSUpdate`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getmsupdate?view=office-pia"/>
  public string GetMSUpdate();
  /// <summary>
  /// Invokes `SetMSUpdate`.
  /// </summary>
  /// <param name="bstrNewVal">The `bstrNewVal` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.setmsupdate?view=office-pia"/>
  public void SetMSUpdate(string bstrNewVal);
  /// <summary>
  /// Invokes `GetMSOffer`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getmsoffer?view=office-pia"/>
  public string GetMSOffer();
  /// <summary>
  /// Invokes `SetMSOffer`.
  /// </summary>
  /// <param name="bstrNewVal">The `bstrNewVal` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.setmsoffer?view=office-pia"/>
  public void SetMSOffer(string bstrNewVal);
  /// <summary>
  /// Invokes `GetOtherOffer`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getotheroffer?view=office-pia"/>
  public string GetOtherOffer();
  /// <summary>
  /// Invokes `SetOtherOffer`.
  /// </summary>
  /// <param name="bstrNewVal">The `bstrNewVal` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.setotheroffer?view=office-pia"/>
  public void SetOtherOffer(string bstrNewVal);
  /// <summary>
  /// Invokes `GetAddress2`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getaddress2?view=office-pia"/>
  public string GetAddress2();
  /// <summary>
  /// Invokes `SetAddress2`.
  /// </summary>
  /// <param name="bstrNewVal">The `bstrNewVal` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.setaddress2?view=office-pia"/>
  public void SetAddress2(string bstrNewVal);
  /// <summary>
  /// Invokes `CheckSystemClock`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.checksystemclock?view=office-pia"/>
  public uint CheckSystemClock();
  /// <summary>
  /// Invokes `GetExistingExpiryDate`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getexistingexpirydate?view=office-pia"/>
  public DateTime GetExistingExpiryDate();
  /// <summary>
  /// Invokes `GetNewExpiryDate`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getnewexpirydate?view=office-pia"/>
  public DateTime GetNewExpiryDate();
  /// <summary>
  /// Invokes `GetBillingFirstName`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getbillingfirstname?view=office-pia"/>
  public string GetBillingFirstName();
  /// <summary>
  /// Invokes `SetBillingFirstName`.
  /// </summary>
  /// <param name="bstrNewVal">The `bstrNewVal` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.setbillingfirstname?view=office-pia"/>
  public void SetBillingFirstName(string bstrNewVal);
  /// <summary>
  /// Invokes `GetBillingLastName`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getbillinglastname?view=office-pia"/>
  public string GetBillingLastName();
  /// <summary>
  /// Invokes `SetBillingLastName`.
  /// </summary>
  /// <param name="bstrNewVal">The `bstrNewVal` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.setbillinglastname?view=office-pia"/>
  public void SetBillingLastName(string bstrNewVal);
  /// <summary>
  /// Invokes `GetBillingPhone`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getbillingphone?view=office-pia"/>
  public string GetBillingPhone();
  /// <summary>
  /// Invokes `SetBillingPhone`.
  /// </summary>
  /// <param name="bstrNewVal">The `bstrNewVal` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.setbillingphone?view=office-pia"/>
  public void SetBillingPhone(string bstrNewVal);
  /// <summary>
  /// Invokes `GetBillingAddress1`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getbillingaddress1?view=office-pia"/>
  public string GetBillingAddress1();
  /// <summary>
  /// Invokes `SetBillingAddress1`.
  /// </summary>
  /// <param name="bstrNewVal">The `bstrNewVal` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.setbillingaddress1?view=office-pia"/>
  public void SetBillingAddress1(string bstrNewVal);
  /// <summary>
  /// Invokes `GetBillingAddress2`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getbillingaddress2?view=office-pia"/>
  public string GetBillingAddress2();
  /// <summary>
  /// Invokes `SetBillingAddress2`.
  /// </summary>
  /// <param name="bstrNewVal">The `bstrNewVal` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.setbillingaddress2?view=office-pia"/>
  public void SetBillingAddress2(string bstrNewVal);
  /// <summary>
  /// Invokes `GetBillingCity`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getbillingcity?view=office-pia"/>
  public string GetBillingCity();
  /// <summary>
  /// Invokes `SetBillingCity`.
  /// </summary>
  /// <param name="bstrNewVal">The `bstrNewVal` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.setbillingcity?view=office-pia"/>
  public void SetBillingCity(string bstrNewVal);
  /// <summary>
  /// Invokes `GetBillingState`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getbillingstate?view=office-pia"/>
  public string GetBillingState();
  /// <summary>
  /// Invokes `SetBillingState`.
  /// </summary>
  /// <param name="bstrNewVal">The `bstrNewVal` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.setbillingstate?view=office-pia"/>
  public void SetBillingState(string bstrNewVal);
  /// <summary>
  /// Invokes `GetBillingCountryCode`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getbillingcountrycode?view=office-pia"/>
  public string GetBillingCountryCode();
  /// <summary>
  /// Invokes `SetBillingCountryCode`.
  /// </summary>
  /// <param name="bstrNewVal">The `bstrNewVal` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.setbillingcountrycode?view=office-pia"/>
  public void SetBillingCountryCode(string bstrNewVal);
  /// <summary>
  /// Invokes `GetBillingZip`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getbillingzip?view=office-pia"/>
  public string GetBillingZip();
  /// <summary>
  /// Invokes `SetBillingZip`.
  /// </summary>
  /// <param name="bstrNewVal">The `bstrNewVal` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.setbillingzip?view=office-pia"/>
  public void SetBillingZip(string bstrNewVal);
  /// <summary>
  /// Invokes `SaveBillingInfo`.
  /// </summary>
  /// <param name="bSave">The `bSave` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.savebillinginfo?view=office-pia"/>
  public uint SaveBillingInfo(int bSave);
  /// <summary>
  /// Invokes `IsCCRenewalCountry`.
  /// </summary>
  /// <param name="bstrCountryCode">The `bstrCountryCode` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.isccrenewalcountry?view=office-pia"/>
  public int IsCCRenewalCountry(string bstrCountryCode);
  /// <summary>
  /// Invokes `GetVATLabel`.
  /// </summary>
  /// <param name="bstrCountryCode">The `bstrCountryCode` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getvatlabel?view=office-pia"/>
  public string GetVATLabel(string bstrCountryCode);
  /// <summary>
  /// Invokes `GetCCRenewalExpiryDate`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getccrenewalexpirydate?view=office-pia"/>
  public DateTime GetCCRenewalExpiryDate();
  /// <summary>
  /// Invokes `SetVATNumber`.
  /// </summary>
  /// <param name="bstrVATNumber">The `bstrVATNumber` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.setvatnumber?view=office-pia"/>
  public void SetVATNumber(string bstrVATNumber);
  /// <summary>
  /// Invokes `SetCreditCardType`.
  /// </summary>
  /// <param name="bstrCCCode">The `bstrCCCode` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.setcreditcardtype?view=office-pia"/>
  public void SetCreditCardType(string bstrCCCode);
  /// <summary>
  /// Invokes `SetCreditCardNumber`.
  /// </summary>
  /// <param name="bstrCCNumber">The `bstrCCNumber` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.setcreditcardnumber?view=office-pia"/>
  public void SetCreditCardNumber(string bstrCCNumber);
  /// <summary>
  /// Invokes `SetCreditCardExpiryYear`.
  /// </summary>
  /// <param name="dwCCYear">The `dwCCYear` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.setcreditcardexpiryyear?view=office-pia"/>
  public void SetCreditCardExpiryYear(uint dwCCYear);
  /// <summary>
  /// Invokes `SetCreditCardExpiryMonth`.
  /// </summary>
  /// <param name="dwCCMonth">The `dwCCMonth` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.setcreditcardexpirymonth?view=office-pia"/>
  public void SetCreditCardExpiryMonth(uint dwCCMonth);
  /// <summary>
  /// Invokes `GetCreditCardCount`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getcreditcardcount?view=office-pia"/>
  public uint GetCreditCardCount();
  /// <summary>
  /// Invokes `GetCreditCardCode`.
  /// </summary>
  /// <param name="dwIndex">The `dwIndex` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getcreditcardcode?view=office-pia"/>
  public string GetCreditCardCode(uint dwIndex);
  /// <summary>
  /// Invokes `GetCreditCardName`.
  /// </summary>
  /// <param name="dwIndex">The `dwIndex` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getcreditcardname?view=office-pia"/>
  public string GetCreditCardName(uint dwIndex);
  /// <summary>
  /// Invokes `GetVATNumber`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getvatnumber?view=office-pia"/>
  public string GetVATNumber();
  /// <summary>
  /// Invokes `GetCreditCardType`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getcreditcardtype?view=office-pia"/>
  public string GetCreditCardType();
  /// <summary>
  /// Invokes `GetCreditCardNumber`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getcreditcardnumber?view=office-pia"/>
  public string GetCreditCardNumber();
  /// <summary>
  /// Invokes `GetCreditCardExpiryYear`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getcreditcardexpiryyear?view=office-pia"/>
  public uint GetCreditCardExpiryYear();
  /// <summary>
  /// Invokes `GetCreditCardExpiryMonth`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getcreditcardexpirymonth?view=office-pia"/>
  public uint GetCreditCardExpiryMonth();
  /// <summary>
  /// Invokes `GetDisconnectOption`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getdisconnectoption?view=office-pia"/>
  public int GetDisconnectOption();
  /// <summary>
  /// Invokes `SetDisconnectOption`.
  /// </summary>
  /// <param name="bNewVal">The `bNewVal` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.setdisconnectoption?view=office-pia"/>
  public void SetDisconnectOption(int bNewVal);
  /// <summary>
  /// Invokes `AsyncProcessHandshakeRequest`.
  /// </summary>
  /// <param name="bReviseCustInfo">The `bReviseCustInfo` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.asyncprocesshandshakerequest?view=office-pia"/>
  public void AsyncProcessHandshakeRequest(int bReviseCustInfo);
  /// <summary>
  /// Invokes `AsyncProcessNewLicenseRequest`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.asyncprocessnewlicenserequest?view=office-pia"/>
  public void AsyncProcessNewLicenseRequest();
  /// <summary>
  /// Invokes `AsyncProcessReissueLicenseRequest`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.asyncprocessreissuelicenserequest?view=office-pia"/>
  public void AsyncProcessReissueLicenseRequest();
  /// <summary>
  /// Invokes `AsyncProcessRetailRenewalLicenseRequest`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.asyncprocessretailrenewallicenserequest?view=office-pia"/>
  public void AsyncProcessRetailRenewalLicenseRequest();
  /// <summary>
  /// Invokes `AsyncProcessReviseCustInfoRequest`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.asyncprocessrevisecustinforequest?view=office-pia"/>
  public void AsyncProcessReviseCustInfoRequest();
  /// <summary>
  /// Invokes `AsyncProcessCCRenewalPriceRequest`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.asyncprocessccrenewalpricerequest?view=office-pia"/>
  public void AsyncProcessCCRenewalPriceRequest();
  /// <summary>
  /// Invokes `AsyncProcessCCRenewalLicenseRequest`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.asyncprocessccrenewallicenserequest?view=office-pia"/>
  public void AsyncProcessCCRenewalLicenseRequest();
  /// <summary>
  /// Invokes `GetAsyncProcessReturnCode`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getasyncprocessreturncode?view=office-pia"/>
  public uint GetAsyncProcessReturnCode();
  /// <summary>
  /// Invokes `IsUpgradeAvailable`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.isupgradeavailable?view=office-pia"/>
  public int IsUpgradeAvailable();
  /// <summary>
  /// Invokes `WantUpgrade`.
  /// </summary>
  /// <param name="bWantUpgrade">The `bWantUpgrade` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.wantupgrade?view=office-pia"/>
  public void WantUpgrade(int bWantUpgrade);
  /// <summary>
  /// Invokes `AsyncProcessDroppedLicenseRequest`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.asyncprocessdroppedlicenserequest?view=office-pia"/>
  public void AsyncProcessDroppedLicenseRequest();
  /// <summary>
  /// Invokes `GenerateInstallationId`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.generateinstallationid?view=office-pia"/>
  public string GenerateInstallationId();
  /// <summary>
  /// Invokes `DepositConfirmationId`.
  /// </summary>
  /// <param name="bstrVal">The `bstrVal` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.depositconfirmationid?view=office-pia"/>
  public uint DepositConfirmationId(string bstrVal);
  /// <summary>
  /// Invokes `VerifyCheckDigits`.
  /// </summary>
  /// <param name="bstrCIDIID">The `bstrCIDIID` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.verifycheckdigits?view=office-pia"/>
  public int VerifyCheckDigits(string bstrCIDIID);
  /// <summary>
  /// Invokes `GetCurrentExpiryDate`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getcurrentexpirydate?view=office-pia"/>
  public DateTime GetCurrentExpiryDate();
  /// <summary>
  /// Invokes `CancelAsyncProcessRequest`.
  /// </summary>
  /// <param name="bIsLicenseRequest">The `bIsLicenseRequest` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.cancelasyncprocessrequest?view=office-pia"/>
  public void CancelAsyncProcessRequest(int bIsLicenseRequest);
  /// <summary>
  /// Invokes `GetCurrencyDescription`.
  /// </summary>
  /// <param name="dwCurrencyIndex">The `dwCurrencyIndex` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getcurrencydescription?view=office-pia"/>
  public string GetCurrencyDescription(uint dwCurrencyIndex);
  /// <summary>
  /// Invokes `GetPriceItemCount`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getpriceitemcount?view=office-pia"/>
  public uint GetPriceItemCount();
  /// <summary>
  /// Invokes `GetPriceItemLabel`.
  /// </summary>
  /// <param name="dwIndex">The `dwIndex` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getpriceitemlabel?view=office-pia"/>
  public string GetPriceItemLabel(uint dwIndex);
  /// <summary>
  /// Invokes `GetPriceItemValue`.
  /// </summary>
  /// <param name="dwCurrencyIndex">The `dwCurrencyIndex` parameter.</param>
  /// <param name="dwIndex">The `dwIndex` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getpriceitemvalue?view=office-pia"/>
  public string GetPriceItemValue(uint dwCurrencyIndex, uint dwIndex);
  /// <summary>
  /// Invokes `GetInvoiceText`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getinvoicetext?view=office-pia"/>
  public string GetInvoiceText();
  /// <summary>
  /// Invokes `GetBackendErrorMsg`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getbackenderrormsg?view=office-pia"/>
  public string GetBackendErrorMsg();
  /// <summary>
  /// Invokes `GetCurrencyOption`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getcurrencyoption?view=office-pia"/>
  public uint GetCurrencyOption();
  /// <summary>
  /// Invokes `SetCurrencyOption`.
  /// </summary>
  /// <param name="dwCurrencyOption">The `dwCurrencyOption` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.setcurrencyoption?view=office-pia"/>
  public void SetCurrencyOption(uint dwCurrencyOption);
  /// <summary>
  /// Invokes `GetEndOfLifeHtmlText`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getendoflifehtmltext?view=office-pia"/>
  public string GetEndOfLifeHtmlText();
  /// <summary>
  /// Invokes `DisplaySSLCert`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.displaysslcert?view=office-pia"/>
  public uint DisplaySSLCert();

  #endregion methods
}

