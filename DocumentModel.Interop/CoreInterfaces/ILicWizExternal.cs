using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[ComImport]
[Guid("4CAC6328-B9B0-11D3-8D59-0050048384E3")]
[TypeLibType(4304)]
public interface ILicWizExternal
{
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1)]
  void PrintHtmlDocument([In] [MarshalAs(UnmanagedType.IUnknown)] object punkHtmlDoc);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2)]
  void InvokeDateTimeApplet();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(3)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string FormatDate([In] DateTime date, [In] [MarshalAs(UnmanagedType.BStr)] string pFormat = "");

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(4)]
  void ShowHelp([Optional] [In] [MarshalAs(UnmanagedType.Struct)] ref object pvarId);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(5)]
  void Terminate();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(6)]
  void DisableVORWReminder([In] int BPC);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(7)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string SaveReceipt([In] [MarshalAs(UnmanagedType.BStr)] string bstrReceipt);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(8)]
  void OpenInDefaultBrowser([In] [MarshalAs(UnmanagedType.BStr)] string bstrUrl);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(9)]
  int MsoAlert
  ([In] [MarshalAs(UnmanagedType.BStr)] string bstrText, [In] [MarshalAs(UnmanagedType.BStr)] string bstrButtons,
    [In] [MarshalAs(UnmanagedType.BStr)] string bstrIcon);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(10)]
  int DepositPidKey([In] [MarshalAs(UnmanagedType.BStr)] string bstrKey, [In] int fMORW);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(11)]
  void WriteLog([In] [MarshalAs(UnmanagedType.BStr)] string bstrMessage);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(12)]
  void ResignDpc([In] [MarshalAs(UnmanagedType.BStr)] string bstrProductCode);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(13)]
  void ResetPID();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(14)]
  void SetDialogSize([In] int dx, [In] int dy);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(15)]
  int VerifyClock([In] int lMode);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(16)]
  void SortSelectOptions([In] [MarshalAs(UnmanagedType.IDispatch)] object pdispSelect);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(17)]
  void InternetDisconnect();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(18)]
  int GetConnectedState();

  [DispId(20)]
  int Context
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(20)]
    get;
  }

  [DispId(21)]
  object Validator
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(21)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [DispId(22)]
  object LicAgent
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(22)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [DispId(23)]
  string CountryInfo
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(23)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
  }

  [DispId(24)]
  int WizardVisible
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(24)]
    [param: In]
    set;
  }

  [DispId(25)]
  string WizardTitle
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(25)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(26)]
  int AnimationEnabled
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(26)]
    get;
  }

  [DispId(27)]
  int CurrentHelpId
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(27)]
    [param: In]
    set;
  }

  [DispId(28)]
  string OfficeOnTheWebUrl
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(28)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
  }
}