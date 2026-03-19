using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[ComImport]
[Guid("000C03C5-0000-0000-C000-000000000046")]
[TypeLibType(4288)]
public interface IBlogPictureExtensibility
{
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1)]
  void BlogPictureProviderProperties
  ([MarshalAs(UnmanagedType.BStr)] out string BlogPictureProvider,
    [MarshalAs(UnmanagedType.BStr)] out string FriendlyName);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2)]
  void CreatePictureAccount
  ([In] [MarshalAs(UnmanagedType.BStr)] string Account, [In] [MarshalAs(UnmanagedType.BStr)] string BlogProvider,
    [In] int ParentWindow, [In] [MarshalAs(UnmanagedType.IDispatch)] object Document);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(3)]
  void PublishPicture
  ([In] [MarshalAs(UnmanagedType.BStr)] string Account, [In] int ParentWindow,
    [In] [MarshalAs(UnmanagedType.IDispatch)] object Document, [In] [MarshalAs(UnmanagedType.IUnknown)] object Image,
    [MarshalAs(UnmanagedType.BStr)] out string PictureURI, [In] int ImageType);
}