using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

using stdole;

namespace DocumentModel.Interop.Core;

[ComImport]
[Guid("000CD6A3-0000-0000-C000-000000000046")]
[TypeLibType(4160)]
public interface SignatureProvider
{
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610743808)]
  [return: MarshalAs(UnmanagedType.Interface)]
  [return: ComAliasName("stdole.IPictureDisp")]
  IPictureDisp GenerateSignatureLineImage
  ([In] SignatureLineImage siglnimg, [In] [MarshalAs(UnmanagedType.Interface)] SignatureSetup psigsetup,
    [In] [MarshalAs(UnmanagedType.Interface)] SignatureInfo psiginfo,
    [In] [MarshalAs(UnmanagedType.IUnknown)] object XmlDsigStream);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610743809)]
  void ShowSignatureSetup
  ([In] [MarshalAs(UnmanagedType.IUnknown)] object ParentWindow,
    [In] [MarshalAs(UnmanagedType.Interface)] SignatureSetup psigsetup);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610743810)]
  void ShowSigningCeremony
  ([In] [MarshalAs(UnmanagedType.IUnknown)] object ParentWindow,
    [In] [MarshalAs(UnmanagedType.Interface)] SignatureSetup psigsetup,
    [In] [MarshalAs(UnmanagedType.Interface)] SignatureInfo psiginfo);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610743811)]
  void SignXmlDsig
  ([In] [MarshalAs(UnmanagedType.IUnknown)] object QueryContinue,
    [In] [MarshalAs(UnmanagedType.Interface)] SignatureSetup psigsetup,
    [In] [MarshalAs(UnmanagedType.Interface)] SignatureInfo psiginfo,
    [In] [MarshalAs(UnmanagedType.IUnknown)] object XmlDsigStream);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610743812)]
  void NotifySignatureAdded
  ([In] [MarshalAs(UnmanagedType.IUnknown)] object ParentWindow,
    [In] [MarshalAs(UnmanagedType.Interface)] SignatureSetup psigsetup,
    [In] [MarshalAs(UnmanagedType.Interface)] SignatureInfo psiginfo);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610743813)]
  void VerifyXmlDsig
  ([In] [MarshalAs(UnmanagedType.IUnknown)] object QueryContinue,
    [In] [MarshalAs(UnmanagedType.Interface)] SignatureSetup psigsetup,
    [In] [MarshalAs(UnmanagedType.Interface)] SignatureInfo psiginfo,
    [In] [MarshalAs(UnmanagedType.IUnknown)] object XmlDsigStream,
    [In] [Out] ref ContentVerificationResults pcontverres, [In] [Out] ref CertificateVerificationResults pcertverres);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610743814)]
  void ShowSignatureDetails
  ([In] [MarshalAs(UnmanagedType.IUnknown)] object ParentWindow,
    [In] [MarshalAs(UnmanagedType.Interface)] SignatureSetup psigsetup,
    [In] [MarshalAs(UnmanagedType.Interface)] SignatureInfo psiginfo,
    [In] [MarshalAs(UnmanagedType.IUnknown)] object XmlDsigStream,
    [In] [Out] ref ContentVerificationResults pcontverres, [In] [Out] ref CertificateVerificationResults pcertverres);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610743815)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object GetProviderDetail([In] SignatureProviderDetail sigprovdet);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610743816)]
  [return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_UI1)]
  Array HashStream
  ([In] [MarshalAs(UnmanagedType.IUnknown)] object QueryContinue,
    [In] [MarshalAs(UnmanagedType.IUnknown)] object Stream);
}