using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[ComImport]
[TypeLibType(4288)]
[Guid("000C03C4-0000-0000-C000-000000000046")]
public interface IBlogExtensibility
{
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1)]
  void BlogProviderProperties
  ([MarshalAs(UnmanagedType.BStr)] out string BlogProvider, [MarshalAs(UnmanagedType.BStr)] out string FriendlyName,
    out MsoBlogCategorySupport CategorySupport, out bool Padding);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2)]
  void SetupBlogAccount
  ([In] [MarshalAs(UnmanagedType.BStr)] string Account, [In] int ParentWindow,
    [In] [MarshalAs(UnmanagedType.IDispatch)] object Document, [In] bool NewAccount, out bool ShowPictureUI);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(3)]
  void GetUserBlogs
  ([In] [MarshalAs(UnmanagedType.BStr)] string Account, [In] int ParentWindow,
    [In] [MarshalAs(UnmanagedType.IDispatch)] object Document,
    [MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_BSTR)] out Array BlogNames,
    [MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_BSTR)] out Array BlogIDs,
    [MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_BSTR)] out Array BlogURLs);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(4)]
  void GetRecentPosts
  ([In] [MarshalAs(UnmanagedType.BStr)] string Account, [In] int ParentWindow,
    [In] [MarshalAs(UnmanagedType.IDispatch)] object Document,
    [MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_BSTR)] out Array PostTitles,
    [MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_BSTR)] out Array PostDates,
    [MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_BSTR)] out Array PostIDs);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(5)]
  void Open
  ([In] [MarshalAs(UnmanagedType.BStr)] string Account, [In] [MarshalAs(UnmanagedType.BStr)] string PostID,
    [In] int ParentWindow, [MarshalAs(UnmanagedType.BStr)] out string xHTML,
    [MarshalAs(UnmanagedType.BStr)] out string Title, [MarshalAs(UnmanagedType.BStr)] out string DatePosted,
    [MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_BSTR)] out Array Categories);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(6)]
  void PublishPost
  ([In] [MarshalAs(UnmanagedType.BStr)] string Account, [In] int ParentWindow,
    [In] [MarshalAs(UnmanagedType.IDispatch)] object Document, [In] [MarshalAs(UnmanagedType.BStr)] string xHTML,
    [In] [MarshalAs(UnmanagedType.BStr)] string Title, [In] [MarshalAs(UnmanagedType.BStr)] string DateTime,
    [In] [MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_BSTR)] Array Categories, [In] bool Draft,
    [MarshalAs(UnmanagedType.BStr)] out string PostID, [MarshalAs(UnmanagedType.BStr)] out string PublishMessage);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(7)]
  void RepublishPost
  ([In] [MarshalAs(UnmanagedType.BStr)] string Account, [In] int ParentWindow,
    [In] [MarshalAs(UnmanagedType.IDispatch)] object Document, [In] [MarshalAs(UnmanagedType.BStr)] string PostID,
    [In] [MarshalAs(UnmanagedType.BStr)] string xHTML, [In] [MarshalAs(UnmanagedType.BStr)] string Title,
    [In] [MarshalAs(UnmanagedType.BStr)] string DateTime,
    [In] [MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_BSTR)] Array Categories, [In] bool Draft,
    [MarshalAs(UnmanagedType.BStr)] out string PublishMessage);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(8)]
  void GetCategories
  ([In] [MarshalAs(UnmanagedType.BStr)] string Account, [In] int ParentWindow,
    [In] [MarshalAs(UnmanagedType.IDispatch)] object Document,
    [MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_BSTR)] out Array Categories);
}