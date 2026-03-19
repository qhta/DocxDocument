using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[ComImport]
[TypeLibType(4160)]
[Guid("000CD809-0000-0000-C000-000000000046")]
public interface EncryptionProvider
{
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610743808)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object GetProviderDetail([In] EncryptionProviderDetail encprovdet);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610743809)]
  int NewSession([In] [MarshalAs(UnmanagedType.IUnknown)] object ParentWindow);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610743810)]
  int Authenticate
  ([In] [MarshalAs(UnmanagedType.IUnknown)] object ParentWindow,
    [In] [MarshalAs(UnmanagedType.IUnknown)] object EncryptionData, out uint PermissionsMask);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610743811)]
  int CloneSession([In] int SessionHandle);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610743812)]
  void EndSession([In] int SessionHandle);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610743813)]
  int Save([In] int SessionHandle, [In] [MarshalAs(UnmanagedType.IUnknown)] object EncryptionData);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610743814)]
  void EncryptStream
  ([In] int SessionHandle, [In] [MarshalAs(UnmanagedType.BStr)] string StreamName,
    [In] [MarshalAs(UnmanagedType.IUnknown)] object UnencryptedStream,
    [In] [MarshalAs(UnmanagedType.IUnknown)] object EncryptedStream);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610743815)]
  void DecryptStream
  ([In] int SessionHandle, [In] [MarshalAs(UnmanagedType.BStr)] string StreamName,
    [In] [MarshalAs(UnmanagedType.IUnknown)] object EncryptedStream,
    [In] [MarshalAs(UnmanagedType.IUnknown)] object UnencryptedStream);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610743816)]
  void ShowSettings
  ([In] int SessionHandle, [In] [MarshalAs(UnmanagedType.IUnknown)] object ParentWindow, [In] bool ReadOnly,
    out bool Remove);
}