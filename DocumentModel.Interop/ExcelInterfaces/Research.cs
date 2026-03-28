using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Excel;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
[TypeLibType(TypeLibTypeFlags.FDispatchable)]
[Guid("000244AC-0000-0000-C000-000000000046")]
public interface Research
{
  [DispId(148)]
  Application Application
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(148)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(149)]
  XlCreator Creator
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(149)]
    get;
  }

  [DispId(150)]
  object Parent
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(150)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2751)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Query
  ([In] [MarshalAs(UnmanagedType.BStr)] string ServiceID,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object QueryString,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object QueryLanguage,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object UseSelection,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object LaunchQuery);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2757)]
  bool IsResearchService([In] [MarshalAs(UnmanagedType.BStr)] string ServiceID);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2758)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object SetLanguagePair([In] int LanguageFrom, [In] int LanguageTo);
}