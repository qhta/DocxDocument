using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[ComImport]
[Guid("000C0411-0000-0000-C000-000000000046")]
[TypeLibType(4288)]
public interface Signature: _IMsoDispObj
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

  [DispId(1610809344)]
  string Signer
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809344)]
    [TypeLibFunc(64)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
  }

  [DispId(1610809345)]
  string Issuer
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809345)]
    [TypeLibFunc(64)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
  }

  [DispId(1610809346)]
  object ExpireDate
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809346)]
    [TypeLibFunc(64)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
  }

  [DispId(1610809347)]
  bool IsValid
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809347)]
    [TypeLibFunc(64)]
    get;
  }

  [DispId(1610809348)]
  bool AttachCertificate
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(64)]
    [DispId(1610809348)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809348)]
    [TypeLibFunc(64)]
    [param: In]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610809350)]
  void Delete();

  [DispId(1610809351)]
  object Parent
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809351)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [DispId(1610809352)]
  bool IsCertificateExpired
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809352)]
    [TypeLibFunc(64)]
    get;
  }

  [DispId(1610809353)]
  bool IsCertificateRevoked
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(64)]
    [DispId(1610809353)]
    get;
  }

  [DispId(1610809354)]
  object SignDate
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(64)]
    [DispId(1610809354)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
  }

  [DispId(1610809355)]
  bool IsSigned
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809355)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610809356)]
  void Sign
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object varSigImg,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object varDelSuggSigner,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object varDelSuggSignerLine2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object varDelSuggSignerEmail);

  [DispId(1610809357)]
  SignatureInfo Details
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809357)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610809358)]
  void ShowDetails();

  [DispId(1610809359)]
  bool CanSetup
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809359)]
    get;
  }

  [DispId(1610809360)]
  SignatureSetup Setup
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809360)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1610809361)]
  bool IsSignatureLine
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809361)]
    get;
  }

  [DispId(1610809362)]
  object SignatureLineShape
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809362)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [DispId(1610809363)]
  int SortHint
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809363)]
    get;
  }
}