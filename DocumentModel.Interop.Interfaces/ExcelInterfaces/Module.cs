using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Excel;

[ComImport]
[TypeLibType(TypeLibTypeFlags.FHidden | TypeLibTypeFlags.FDispatchable)]
[Guid("000208AD-0000-0000-C000-000000000046")]
[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
public interface Module
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
  [DispId(304)]
  void Activate();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(551)]
  void Copy
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Before,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object After);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(117)]
  void Delete();

  [DispId(1373)]
  string CodeName
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1373)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
  }

  [DispId(-2147418112)]
  string _CodeName
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FNonBrowsable)]
    [DispId(-2147418112)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(-2147418112)]
    [TypeLibFunc(TypeLibFuncFlags.FNonBrowsable)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(486)]
  int Index
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(486)]
    get;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(637)]
  void Move
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Before,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object After);

  [DispId(110)]
  string Name
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(110)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(110)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(502)]
  object Next
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(502)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [DispId(628)]
  string OnDoubleClick
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [DispId(628)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [DispId(628)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(1031)]
  string OnSheetActivate
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [DispId(1031)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [DispId(1031)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(1081)]
  string OnSheetDeactivate
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1081)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [DispId(1081)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(998)]
  PageSetup PageSetup
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(998)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(503)]
  object Previous
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(503)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(905)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  void _PrintOut
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object From,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object To,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Copies,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Preview,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ActivePrinter,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object PrintToFile,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Collate);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FRestricted | TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  [DispId(65554)]
  void _Dummy18();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(282)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  void _Protect
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Password,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object DrawingObjects,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Contents,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Scenarios,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object UserInterfaceOnly);

  [DispId(292)]
  bool ProtectContents
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(292)]
    get;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(65557)]
  [TypeLibFunc(TypeLibFuncFlags.FRestricted | TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  void _Dummy21();

  [DispId(1159)]
  bool ProtectionMode
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1159)]
    get;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FRestricted | TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  [DispId(65559)]
  void _Dummy23();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(284)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  void _SaveAs
  ([In] [MarshalAs(UnmanagedType.BStr)] string Filename,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object FileFormat,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Password,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object WriteResPassword,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ReadOnlyRecommended,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object CreateBackup,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object AddToMru,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object TextCodepage,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object TextVisualLayout);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(235)]
  void Select([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Replace);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(285)]
  void Unprotect([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Password);

  [DispId(558)]
  XlSheetVisibility Visible
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(558)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(558)]
    [param: In]
    set;
  }

  [DispId(1377)]
  Shapes Shapes
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1377)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(584)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object InsertFile
  ([In] [MarshalAs(UnmanagedType.Struct)] object Filename,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Merge);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1925)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  void SaveAs
  ([In] [MarshalAs(UnmanagedType.BStr)] string Filename,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object FileFormat,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Password,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object WriteResPassword,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ReadOnlyRecommended,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object CreateBackup,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object AddToMru,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object TextCodepage,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object TextVisualLayout);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2029)]
  void Protect
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Password,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object DrawingObjects,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Contents,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Scenarios,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object UserInterfaceOnly);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  [DispId(1772)]
  void _PrintOut_2
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object From,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object To,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Copies,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Preview,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ActivePrinter,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object PrintToFile,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Collate);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2361)]
  void PrintOut
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object From,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object To,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Copies,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Preview,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ActivePrinter,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object PrintToFile,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Collate);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(3174)]
  void SaveAs2
  ([In] [MarshalAs(UnmanagedType.BStr)] string Filename,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object FileFormat,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Password,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object WriteResPassword,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ReadOnlyRecommended,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object CreateBackup,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object AddToMru,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object TextCodepage,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object TextVisualLayout);
}