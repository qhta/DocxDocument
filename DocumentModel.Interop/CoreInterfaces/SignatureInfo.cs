using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

using stdole;

namespace DocumentModel.Interop.Core;

[ComImport]
[Guid("000CD6A2-0000-0000-C000-000000000046")]
[TypeLibType(4160)]
public interface SignatureInfo: _IMsoDispObj
{
  [DispId(1610743808)]
  new object Application
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743808)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [DispId(1610743809)]
  new int Creator
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743809)]
    get;
  }

  [DispId(1)]
  bool ReadOnly
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1)]
    get;
  }

  [DispId(2)]
  string SignatureProvider
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
  }

  [DispId(3)]
  string SignatureText
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(4)]
  [ComAliasName("stdole.IPictureDisp")]
  IPictureDisp SignatureImage
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(4)]
    [return: MarshalAs(UnmanagedType.Interface)]
    [return: ComAliasName("stdole.IPictureDisp")]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(4)]
    [param: In]
    [param: ComAliasName("stdole.IPictureDisp")]
    [param: MarshalAs(UnmanagedType.Interface)]
    set;
  }

  [DispId(5)]
  string SignatureComment
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(5)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(5)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(6)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object GetSignatureDetail([In] SignatureDetail sigdet);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(7)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object GetCertificateDetail([In] CertificateDetail certdet);

  [DispId(8)]
  ContentVerificationResults ContentVerificationResults
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(8)]
    get;
  }

  [DispId(9)]
  CertificateVerificationResults CertificateVerificationResults
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(9)]
    get;
  }

  [DispId(10)]
  bool IsValid
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(10)]
    get;
  }

  [DispId(11)]
  bool IsCertificateExpired
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(11)]
    get;
  }

  [DispId(12)]
  bool IsCertificateRevoked
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(12)]
    get;
  }

  [DispId(13)]
  bool IsCertificateUntrusted
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(13)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(14)]
  void ShowSignatureCertificate([In] [MarshalAs(UnmanagedType.IUnknown)] object ParentWindow);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(15)]
  void SelectSignatureCertificate([In] [MarshalAs(UnmanagedType.IUnknown)] object ParentWindow);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(16)]
  void SelectCertificateDetailByThumbprint([In] [MarshalAs(UnmanagedType.BStr)] string bstrThumbprint);
}