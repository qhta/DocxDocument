using System;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent?view=office-pia"/>
public partial class LicAgent
{


  #region methods

/// <summary>
  /// Invokes `Initialize`.
  /// </summary>
  /// <param name="dwBPC">The `dwBPC` parameter.</param>
  /// <param name="dwMode">The `dwMode` parameter.</param>
  /// <param name="bstrLicSource">The `bstrLicSource` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.initialize?view=office-pia"/>
  public uint Initialize(uint dwBPC, uint dwMode, string bstrLicSource) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `GetFirstName`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getfirstname?view=office-pia"/>
  public string GetFirstName() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `SetFirstName`.
  /// </summary>
  /// <param name="bstrNewVal">The `bstrNewVal` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.setfirstname?view=office-pia"/>
  public void SetFirstName(string bstrNewVal) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `GetLastName`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getlastname?view=office-pia"/>
  public string GetLastName() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `SetLastName`.
  /// </summary>
  /// <param name="bstrNewVal">The `bstrNewVal` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.setlastname?view=office-pia"/>
  public void SetLastName(string bstrNewVal) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `GetOrgName`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getorgname?view=office-pia"/>
  public string GetOrgName() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `SetOrgName`.
  /// </summary>
  /// <param name="bstrNewVal">The `bstrNewVal` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.setorgname?view=office-pia"/>
  public void SetOrgName(string bstrNewVal) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `GetEmail`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getemail?view=office-pia"/>
  public string GetEmail() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `SetEmail`.
  /// </summary>
  /// <param name="bstrNewVal">The `bstrNewVal` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.setemail?view=office-pia"/>
  public void SetEmail(string bstrNewVal) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `GetPhone`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getphone?view=office-pia"/>
  public string GetPhone() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `SetPhone`.
  /// </summary>
  /// <param name="bstrNewVal">The `bstrNewVal` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.setphone?view=office-pia"/>
  public void SetPhone(string bstrNewVal) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `GetAddress1`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getaddress1?view=office-pia"/>
  public string GetAddress1() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `SetAddress1`.
  /// </summary>
  /// <param name="bstrNewVal">The `bstrNewVal` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.setaddress1?view=office-pia"/>
  public void SetAddress1(string bstrNewVal) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `GetCity`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getcity?view=office-pia"/>
  public string GetCity() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `SetCity`.
  /// </summary>
  /// <param name="bstrNewVal">The `bstrNewVal` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.setcity?view=office-pia"/>
  public void SetCity(string bstrNewVal) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `GetState`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getstate?view=office-pia"/>
  public string GetState() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `SetState`.
  /// </summary>
  /// <param name="bstrNewVal">The `bstrNewVal` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.setstate?view=office-pia"/>
  public void SetState(string bstrNewVal) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `GetCountryCode`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getcountrycode?view=office-pia"/>
  public string GetCountryCode() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `SetCountryCode`.
  /// </summary>
  /// <param name="bstrNewVal">The `bstrNewVal` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.setcountrycode?view=office-pia"/>
  public void SetCountryCode(string bstrNewVal) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `GetCountryDesc`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getcountrydesc?view=office-pia"/>
  public string GetCountryDesc() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `SetCountryDesc`.
  /// </summary>
  /// <param name="bstrNewVal">The `bstrNewVal` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.setcountrydesc?view=office-pia"/>
  public void SetCountryDesc(string bstrNewVal) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `GetZip`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getzip?view=office-pia"/>
  public string GetZip() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `SetZip`.
  /// </summary>
  /// <param name="bstrNewVal">The `bstrNewVal` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.setzip?view=office-pia"/>
  public void SetZip(string bstrNewVal) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `GetIsoLanguage`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getisolanguage?view=office-pia"/>
  public uint GetIsoLanguage() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `SetIsoLanguage`.
  /// </summary>
  /// <param name="dwNewVal">The `dwNewVal` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.setisolanguage?view=office-pia"/>
  public void SetIsoLanguage(uint dwNewVal) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `GetMSUpdate`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getmsupdate?view=office-pia"/>
  public string GetMSUpdate() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `SetMSUpdate`.
  /// </summary>
  /// <param name="bstrNewVal">The `bstrNewVal` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.setmsupdate?view=office-pia"/>
  public void SetMSUpdate(string bstrNewVal) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `GetMSOffer`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getmsoffer?view=office-pia"/>
  public string GetMSOffer() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `SetMSOffer`.
  /// </summary>
  /// <param name="bstrNewVal">The `bstrNewVal` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.setmsoffer?view=office-pia"/>
  public void SetMSOffer(string bstrNewVal) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `GetOtherOffer`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getotheroffer?view=office-pia"/>
  public string GetOtherOffer() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `SetOtherOffer`.
  /// </summary>
  /// <param name="bstrNewVal">The `bstrNewVal` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.setotheroffer?view=office-pia"/>
  public void SetOtherOffer(string bstrNewVal) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `GetAddress2`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getaddress2?view=office-pia"/>
  public string GetAddress2() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `SetAddress2`.
  /// </summary>
  /// <param name="bstrNewVal">The `bstrNewVal` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.setaddress2?view=office-pia"/>
  public void SetAddress2(string bstrNewVal) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `CheckSystemClock`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.checksystemclock?view=office-pia"/>
  public uint CheckSystemClock() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `GetExistingExpiryDate`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getexistingexpirydate?view=office-pia"/>
  public DateTime GetExistingExpiryDate() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `GetNewExpiryDate`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getnewexpirydate?view=office-pia"/>
  public DateTime GetNewExpiryDate() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `GetBillingFirstName`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getbillingfirstname?view=office-pia"/>
  public string GetBillingFirstName() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `SetBillingFirstName`.
  /// </summary>
  /// <param name="bstrNewVal">The `bstrNewVal` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.setbillingfirstname?view=office-pia"/>
  public void SetBillingFirstName(string bstrNewVal) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `GetBillingLastName`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getbillinglastname?view=office-pia"/>
  public string GetBillingLastName() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `SetBillingLastName`.
  /// </summary>
  /// <param name="bstrNewVal">The `bstrNewVal` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.setbillinglastname?view=office-pia"/>
  public void SetBillingLastName(string bstrNewVal) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `GetBillingPhone`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getbillingphone?view=office-pia"/>
  public string GetBillingPhone() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `SetBillingPhone`.
  /// </summary>
  /// <param name="bstrNewVal">The `bstrNewVal` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.setbillingphone?view=office-pia"/>
  public void SetBillingPhone(string bstrNewVal) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `GetBillingAddress1`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getbillingaddress1?view=office-pia"/>
  public string GetBillingAddress1() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `SetBillingAddress1`.
  /// </summary>
  /// <param name="bstrNewVal">The `bstrNewVal` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.setbillingaddress1?view=office-pia"/>
  public void SetBillingAddress1(string bstrNewVal) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `GetBillingAddress2`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getbillingaddress2?view=office-pia"/>
  public string GetBillingAddress2() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `SetBillingAddress2`.
  /// </summary>
  /// <param name="bstrNewVal">The `bstrNewVal` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.setbillingaddress2?view=office-pia"/>
  public void SetBillingAddress2(string bstrNewVal) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `GetBillingCity`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getbillingcity?view=office-pia"/>
  public string GetBillingCity() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `SetBillingCity`.
  /// </summary>
  /// <param name="bstrNewVal">The `bstrNewVal` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.setbillingcity?view=office-pia"/>
  public void SetBillingCity(string bstrNewVal) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `GetBillingState`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getbillingstate?view=office-pia"/>
  public string GetBillingState() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `SetBillingState`.
  /// </summary>
  /// <param name="bstrNewVal">The `bstrNewVal` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.setbillingstate?view=office-pia"/>
  public void SetBillingState(string bstrNewVal) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `GetBillingCountryCode`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getbillingcountrycode?view=office-pia"/>
  public string GetBillingCountryCode() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `SetBillingCountryCode`.
  /// </summary>
  /// <param name="bstrNewVal">The `bstrNewVal` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.setbillingcountrycode?view=office-pia"/>
  public void SetBillingCountryCode(string bstrNewVal) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `GetBillingZip`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getbillingzip?view=office-pia"/>
  public string GetBillingZip() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `SetBillingZip`.
  /// </summary>
  /// <param name="bstrNewVal">The `bstrNewVal` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.setbillingzip?view=office-pia"/>
  public void SetBillingZip(string bstrNewVal) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `SaveBillingInfo`.
  /// </summary>
  /// <param name="bSave">The `bSave` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.savebillinginfo?view=office-pia"/>
  public uint SaveBillingInfo(int bSave) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `IsCCRenewalCountry`.
  /// </summary>
  /// <param name="bstrCountryCode">The `bstrCountryCode` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.isccrenewalcountry?view=office-pia"/>
  public int IsCCRenewalCountry(string bstrCountryCode) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `GetVATLabel`.
  /// </summary>
  /// <param name="bstrCountryCode">The `bstrCountryCode` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getvatlabel?view=office-pia"/>
  public string GetVATLabel(string bstrCountryCode) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `GetCCRenewalExpiryDate`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getccrenewalexpirydate?view=office-pia"/>
  public DateTime GetCCRenewalExpiryDate() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `SetVATNumber`.
  /// </summary>
  /// <param name="bstrVATNumber">The `bstrVATNumber` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.setvatnumber?view=office-pia"/>
  public void SetVATNumber(string bstrVATNumber) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `SetCreditCardType`.
  /// </summary>
  /// <param name="bstrCCCode">The `bstrCCCode` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.setcreditcardtype?view=office-pia"/>
  public void SetCreditCardType(string bstrCCCode) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `SetCreditCardNumber`.
  /// </summary>
  /// <param name="bstrCCNumber">The `bstrCCNumber` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.setcreditcardnumber?view=office-pia"/>
  public void SetCreditCardNumber(string bstrCCNumber) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `SetCreditCardExpiryYear`.
  /// </summary>
  /// <param name="dwCCYear">The `dwCCYear` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.setcreditcardexpiryyear?view=office-pia"/>
  public void SetCreditCardExpiryYear(uint dwCCYear) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `SetCreditCardExpiryMonth`.
  /// </summary>
  /// <param name="dwCCMonth">The `dwCCMonth` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.setcreditcardexpirymonth?view=office-pia"/>
  public void SetCreditCardExpiryMonth(uint dwCCMonth) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `GetCreditCardCount`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getcreditcardcount?view=office-pia"/>
  public uint GetCreditCardCount() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `GetCreditCardCode`.
  /// </summary>
  /// <param name="dwIndex">The `dwIndex` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getcreditcardcode?view=office-pia"/>
  public string GetCreditCardCode(uint dwIndex) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `GetCreditCardName`.
  /// </summary>
  /// <param name="dwIndex">The `dwIndex` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getcreditcardname?view=office-pia"/>
  public string GetCreditCardName(uint dwIndex) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `GetVATNumber`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getvatnumber?view=office-pia"/>
  public string GetVATNumber() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `GetCreditCardType`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getcreditcardtype?view=office-pia"/>
  public string GetCreditCardType() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `GetCreditCardNumber`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getcreditcardnumber?view=office-pia"/>
  public string GetCreditCardNumber() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `GetCreditCardExpiryYear`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getcreditcardexpiryyear?view=office-pia"/>
  public uint GetCreditCardExpiryYear() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `GetCreditCardExpiryMonth`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getcreditcardexpirymonth?view=office-pia"/>
  public uint GetCreditCardExpiryMonth() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `GetDisconnectOption`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getdisconnectoption?view=office-pia"/>
  public int GetDisconnectOption() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `SetDisconnectOption`.
  /// </summary>
  /// <param name="bNewVal">The `bNewVal` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.setdisconnectoption?view=office-pia"/>
  public void SetDisconnectOption(int bNewVal) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `AsyncProcessHandshakeRequest`.
  /// </summary>
  /// <param name="bReviseCustInfo">The `bReviseCustInfo` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.asyncprocesshandshakerequest?view=office-pia"/>
  public void AsyncProcessHandshakeRequest(int bReviseCustInfo) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `AsyncProcessNewLicenseRequest`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.asyncprocessnewlicenserequest?view=office-pia"/>
  public void AsyncProcessNewLicenseRequest() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `AsyncProcessReissueLicenseRequest`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.asyncprocessreissuelicenserequest?view=office-pia"/>
  public void AsyncProcessReissueLicenseRequest() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `AsyncProcessRetailRenewalLicenseRequest`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.asyncprocessretailrenewallicenserequest?view=office-pia"/>
  public void AsyncProcessRetailRenewalLicenseRequest() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `AsyncProcessReviseCustInfoRequest`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.asyncprocessrevisecustinforequest?view=office-pia"/>
  public void AsyncProcessReviseCustInfoRequest() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `AsyncProcessCCRenewalPriceRequest`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.asyncprocessccrenewalpricerequest?view=office-pia"/>
  public void AsyncProcessCCRenewalPriceRequest() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `AsyncProcessCCRenewalLicenseRequest`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.asyncprocessccrenewallicenserequest?view=office-pia"/>
  public void AsyncProcessCCRenewalLicenseRequest() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `GetAsyncProcessReturnCode`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getasyncprocessreturncode?view=office-pia"/>
  public uint GetAsyncProcessReturnCode() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `IsUpgradeAvailable`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.isupgradeavailable?view=office-pia"/>
  public int IsUpgradeAvailable() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `WantUpgrade`.
  /// </summary>
  /// <param name="bWantUpgrade">The `bWantUpgrade` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.wantupgrade?view=office-pia"/>
  public void WantUpgrade(int bWantUpgrade) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `AsyncProcessDroppedLicenseRequest`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.asyncprocessdroppedlicenserequest?view=office-pia"/>
  public void AsyncProcessDroppedLicenseRequest() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `GenerateInstallationId`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.generateinstallationid?view=office-pia"/>
  public string GenerateInstallationId() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `DepositConfirmationId`.
  /// </summary>
  /// <param name="bstrVal">The `bstrVal` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.depositconfirmationid?view=office-pia"/>
  public uint DepositConfirmationId(string bstrVal) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `VerifyCheckDigits`.
  /// </summary>
  /// <param name="bstrCIDIID">The `bstrCIDIID` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.verifycheckdigits?view=office-pia"/>
  public int VerifyCheckDigits(string bstrCIDIID) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `GetCurrentExpiryDate`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getcurrentexpirydate?view=office-pia"/>
  public DateTime GetCurrentExpiryDate() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `CancelAsyncProcessRequest`.
  /// </summary>
  /// <param name="bIsLicenseRequest">The `bIsLicenseRequest` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.cancelasyncprocessrequest?view=office-pia"/>
  public void CancelAsyncProcessRequest(int bIsLicenseRequest) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `GetCurrencyDescription`.
  /// </summary>
  /// <param name="dwCurrencyIndex">The `dwCurrencyIndex` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getcurrencydescription?view=office-pia"/>
  public string GetCurrencyDescription(uint dwCurrencyIndex) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `GetPriceItemCount`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getpriceitemcount?view=office-pia"/>
  public uint GetPriceItemCount() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `GetPriceItemLabel`.
  /// </summary>
  /// <param name="dwIndex">The `dwIndex` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getpriceitemlabel?view=office-pia"/>
  public string GetPriceItemLabel(uint dwIndex) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `GetPriceItemValue`.
  /// </summary>
  /// <param name="dwCurrencyIndex">The `dwCurrencyIndex` parameter.</param>
  /// <param name="dwIndex">The `dwIndex` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getpriceitemvalue?view=office-pia"/>
  public string GetPriceItemValue(uint dwCurrencyIndex, uint dwIndex) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `GetInvoiceText`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getinvoicetext?view=office-pia"/>
  public string GetInvoiceText() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `GetBackendErrorMsg`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getbackenderrormsg?view=office-pia"/>
  public string GetBackendErrorMsg() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `GetCurrencyOption`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getcurrencyoption?view=office-pia"/>
  public uint GetCurrencyOption() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `SetCurrencyOption`.
  /// </summary>
  /// <param name="dwCurrencyOption">The `dwCurrencyOption` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.setcurrencyoption?view=office-pia"/>
  public void SetCurrencyOption(uint dwCurrencyOption) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `GetEndOfLifeHtmlText`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.getendoflifehtmltext?view=office-pia"/>
  public string GetEndOfLifeHtmlText() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `DisplaySSLCert`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicagent.displaysslcert?view=office-pia"/>
  public uint DisplaySSLCert() { throw new NotImplementedException(); }

  #endregion methods
}


