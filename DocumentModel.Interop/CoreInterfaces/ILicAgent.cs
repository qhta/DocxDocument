using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[ComImport]
[TypeLibType(4304)]
[Guid("00194002-D9C3-11D3-8D59-0050048384E3")]
public interface ILicAgent
{
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1)]
  uint Initialize([In] uint dwBPC, [In] uint dwMode, [In] [MarshalAs(UnmanagedType.BStr)] string bstrLicSource);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(3)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetFirstName();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(4)]
  void SetFirstName([In] [MarshalAs(UnmanagedType.BStr)] string bstrNewVal);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(5)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetLastName();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(6)]
  void SetLastName([In] [MarshalAs(UnmanagedType.BStr)] string bstrNewVal);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(7)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetOrgName();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(8)]
  void SetOrgName([In] [MarshalAs(UnmanagedType.BStr)] string bstrNewVal);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(9)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetEmail();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(10)]
  void SetEmail([In] [MarshalAs(UnmanagedType.BStr)] string bstrNewVal);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(11)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetPhone();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(12)]
  void SetPhone([In] [MarshalAs(UnmanagedType.BStr)] string bstrNewVal);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(13)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetAddress1();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(14)]
  void SetAddress1([In] [MarshalAs(UnmanagedType.BStr)] string bstrNewVal);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(15)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetCity();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(16)]
  void SetCity([In] [MarshalAs(UnmanagedType.BStr)] string bstrNewVal);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(17)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetState();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(18)]
  void SetState([In] [MarshalAs(UnmanagedType.BStr)] string bstrNewVal);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(19)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetCountryCode();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(20)]
  void SetCountryCode([In] [MarshalAs(UnmanagedType.BStr)] string bstrNewVal);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(21)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetCountryDesc();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(22)]
  void SetCountryDesc([In] [MarshalAs(UnmanagedType.BStr)] string bstrNewVal);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(23)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetZip();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(24)]
  void SetZip([In] [MarshalAs(UnmanagedType.BStr)] string bstrNewVal);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(25)]
  uint GetIsoLanguage();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(26)]
  void SetIsoLanguage([In] uint dwNewVal);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(32)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetMSUpdate();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(33)]
  void SetMSUpdate([In] [MarshalAs(UnmanagedType.BStr)] string bstrNewVal);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(34)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetMSOffer();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(35)]
  void SetMSOffer([In] [MarshalAs(UnmanagedType.BStr)] string bstrNewVal);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(36)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetOtherOffer();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(37)]
  void SetOtherOffer([In] [MarshalAs(UnmanagedType.BStr)] string bstrNewVal);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(38)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetAddress2();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(39)]
  void SetAddress2([In] [MarshalAs(UnmanagedType.BStr)] string bstrNewVal);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(40)]
  uint CheckSystemClock();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(41)]
  DateTime GetExistingExpiryDate();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(42)]
  DateTime GetNewExpiryDate();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(43)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetBillingFirstName();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(44)]
  void SetBillingFirstName([In] [MarshalAs(UnmanagedType.BStr)] string bstrNewVal);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(45)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetBillingLastName();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(46)]
  void SetBillingLastName([In] [MarshalAs(UnmanagedType.BStr)] string bstrNewVal);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(47)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetBillingPhone();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(48)]
  void SetBillingPhone([In] [MarshalAs(UnmanagedType.BStr)] string bstrNewVal);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(49)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetBillingAddress1();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(50)]
  void SetBillingAddress1([In] [MarshalAs(UnmanagedType.BStr)] string bstrNewVal);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(51)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetBillingAddress2();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(52)]
  void SetBillingAddress2([In] [MarshalAs(UnmanagedType.BStr)] string bstrNewVal);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(53)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetBillingCity();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(54)]
  void SetBillingCity([In] [MarshalAs(UnmanagedType.BStr)] string bstrNewVal);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(55)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetBillingState();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(56)]
  void SetBillingState([In] [MarshalAs(UnmanagedType.BStr)] string bstrNewVal);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(57)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetBillingCountryCode();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(58)]
  void SetBillingCountryCode([In] [MarshalAs(UnmanagedType.BStr)] string bstrNewVal);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(59)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetBillingZip();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(60)]
  void SetBillingZip([In] [MarshalAs(UnmanagedType.BStr)] string bstrNewVal);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(61)]
  uint SaveBillingInfo([In] int bSave);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(64)]
  int IsCCRenewalCountry([In] [MarshalAs(UnmanagedType.BStr)] string bstrCountryCode);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(65)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetVATLabel([In] [MarshalAs(UnmanagedType.BStr)] string bstrCountryCode);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(66)]
  DateTime GetCCRenewalExpiryDate();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(67)]
  void SetVATNumber([In] [MarshalAs(UnmanagedType.BStr)] string bstrVATNumber);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(68)]
  void SetCreditCardType([In] [MarshalAs(UnmanagedType.BStr)] string bstrCCCode);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(69)]
  void SetCreditCardNumber([In] [MarshalAs(UnmanagedType.BStr)] string bstrCCNumber);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(70)]
  void SetCreditCardExpiryYear([In] uint dwCCYear);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(71)]
  void SetCreditCardExpiryMonth([In] uint dwCCMonth);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(72)]
  uint GetCreditCardCount();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(73)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetCreditCardCode([In] uint dwIndex);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(74)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetCreditCardName([In] uint dwIndex);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(75)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetVATNumber();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(76)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetCreditCardType();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(77)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetCreditCardNumber();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(78)]
  uint GetCreditCardExpiryYear();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(79)]
  uint GetCreditCardExpiryMonth();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(80)]
  int GetDisconnectOption();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(81)]
  void SetDisconnectOption([In] int bNewVal);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(82)]
  void AsyncProcessHandshakeRequest([In] int bReviseCustInfo);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(83)]
  void AsyncProcessNewLicenseRequest();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(84)]
  void AsyncProcessReissueLicenseRequest();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(85)]
  void AsyncProcessRetailRenewalLicenseRequest();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(86)]
  void AsyncProcessReviseCustInfoRequest();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(87)]
  void AsyncProcessCCRenewalPriceRequest();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(88)]
  void AsyncProcessCCRenewalLicenseRequest();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(90)]
  uint GetAsyncProcessReturnCode();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(91)]
  int IsUpgradeAvailable();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(92)]
  void WantUpgrade([In] int bWantUpgrade);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(93)]
  void AsyncProcessDroppedLicenseRequest();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(94)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GenerateInstallationId();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(95)]
  uint DepositConfirmationId([In] [MarshalAs(UnmanagedType.BStr)] string bstrVal);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(96)]
  int VerifyCheckDigits([In] [MarshalAs(UnmanagedType.BStr)] string bstrCIDIID);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(97)]
  DateTime GetCurrentExpiryDate();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(98)]
  void CancelAsyncProcessRequest([In] int bIsLicenseRequest);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(100)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetCurrencyDescription([In] uint dwCurrencyIndex);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(101)]
  uint GetPriceItemCount();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(102)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetPriceItemLabel([In] uint dwIndex);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(103)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetPriceItemValue([In] uint dwCurrencyIndex, [In] uint dwIndex);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(104)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetInvoiceText();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(105)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetBackendErrorMsg();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(106)]
  uint GetCurrencyOption();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(107)]
  void SetCurrencyOption([In] uint dwCurrencyOption);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(108)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetEndOfLifeHtmlText();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(109)]
  uint DisplaySSLCert();
}