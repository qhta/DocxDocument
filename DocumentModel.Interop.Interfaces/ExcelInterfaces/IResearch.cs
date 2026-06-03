using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Excel;

[ComImport]
[Guid("000244AC-0001-0000-C000-000000000046")]
[TypeLibType(TypeLibTypeFlags.FHidden | TypeLibTypeFlags.FDispatchable)]
public interface IResearch
{
  [DispId(148)]
  Application Application
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(149)]
  XlCreator Creator
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    get;
  }

  [DispId(150)]
  object Parent
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Query
  ([In] [MarshalAs(UnmanagedType.BStr)] string ServiceID,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object QueryString,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object QueryLanguage,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object UseSelection,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object LaunchQuery);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  bool IsResearchService([In] [MarshalAs(UnmanagedType.BStr)] string ServiceID);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object SetLanguagePair([In] int LanguageFrom, [In] int LanguageTo);
}