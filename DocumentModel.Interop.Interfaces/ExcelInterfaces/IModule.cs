using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Excel;

[ComImport]
[TypeLibType(TypeLibTypeFlags.FHidden | TypeLibTypeFlags.FDispatchable)]
[Guid("000208AD-0001-0000-C000-000000000046")]
public interface IModule
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
  [LCIDConversion(0)]
  void Activate();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [LCIDConversion(2)]
  void Copy
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Before,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object After);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [LCIDConversion(0)]
  void Delete();

  [DispId(1373)]
  string CodeName
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
  }

  [DispId(-2147418112)]
  string _CodeName
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FNonBrowsable)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FNonBrowsable)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(486)]
  int Index
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [LCIDConversion(2)]
  void Move
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Before,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object After);

  [DispId(110)]
  string Name
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(502)]
  object Next
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [DispId(628)]
  string OnDoubleClick
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [LCIDConversion(0)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(1031)]
  string OnSheetActivate
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [LCIDConversion(0)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(1081)]
  string OnSheetDeactivate
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(998)]
  PageSetup PageSetup
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(503)]
  object Previous
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [LCIDConversion(7)]
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
  void _Dummy18();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  [LCIDConversion(5)]
  void _Protect
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Password,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object DrawingObjects,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Contents,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Scenarios,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object UserInterfaceOnly);

  [DispId(292)]
  bool ProtectContents
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    get;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FRestricted | TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  void _Dummy21();

  [DispId(1159)]
  bool ProtectionMode
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    get;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FRestricted | TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  void _Dummy23();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [LCIDConversion(9)]
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

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [LCIDConversion(1)]
  void Select([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Replace);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [LCIDConversion(1)]
  void Unprotect([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Password);

  [DispId(558)]
  XlSheetVisibility Visible
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [param: In]
    set;
  }

  [DispId(1377)]
  Shapes Shapes
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object InsertFile
  ([In] [MarshalAs(UnmanagedType.Struct)] object Filename,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Merge);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
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

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Protect
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Password,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object DrawingObjects,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Contents,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Scenarios,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object UserInterfaceOnly);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  void _PrintOut_2
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object From,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object To,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Copies,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Preview,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ActivePrinter,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object PrintToFile,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Collate);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void PrintOut
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object From,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object To,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Copies,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Preview,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ActivePrinter,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object PrintToFile,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Collate);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
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