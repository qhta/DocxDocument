using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

using Microsoft.Office.Core;

namespace DocumentModel.Interop.Excel;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
[Guid("000208AF-0000-0000-C000-000000000046")]
[TypeLibType(TypeLibTypeFlags.FHidden | TypeLibTypeFlags.FDispatchable)]
public interface DialogSheet
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
    [TypeLibFunc(TypeLibFuncFlags.FNonBrowsable)]
    [DispId(-2147418112)]
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
    [DispId(628)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
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
    [DispId(1031)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(1081)]
  string OnSheetDeactivate
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [DispId(1081)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1081)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
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
  [DispId(281)]
  void PrintPreview([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object EnableChanges);

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

  [DispId(293)]
  bool ProtectDrawingObjects
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(293)]
    get;
  }

  [DispId(1159)]
  bool ProtectionMode
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1159)]
    get;
  }

  [DispId(294)]
  bool ProtectScenarios
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(294)]
    get;
  }

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
  [TypeLibFunc(TypeLibFuncFlags.FRestricted | TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  [DispId(65565)]
  void _Dummy29();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [DispId(760)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object Arcs([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Index);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(65567)]
  [TypeLibFunc(TypeLibFuncFlags.FRestricted | TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  void _Dummy31();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(65568)]
  [TypeLibFunc(TypeLibFuncFlags.FRestricted | TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  void _Dummy32();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [DispId(557)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object Buttons([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Index);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FRestricted | TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  [DispId(65570)]
  void _Dummy34();

  [DispId(1424)]
  bool EnableCalculation
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1424)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1424)]
    [param: In]
    set;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FRestricted | TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  [DispId(65572)]
  void _Dummy36();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1060)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object ChartObjects([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Index);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [DispId(824)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object CheckBoxes([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Index);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(505)]
  void CheckSpelling
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object CustomDictionary,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object IgnoreUppercase,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object AlwaysSuggest,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object SpellLang);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(65576)]
  [TypeLibFunc(TypeLibFuncFlags.FRestricted | TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  void _Dummy40();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(65577)]
  [TypeLibFunc(TypeLibFuncFlags.FRestricted | TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  void _Dummy41();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FRestricted | TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  [DispId(65578)]
  void _Dummy42();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FRestricted | TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  [DispId(65579)]
  void _Dummy43();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(65580)]
  [TypeLibFunc(TypeLibFuncFlags.FRestricted | TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  void _Dummy44();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FRestricted | TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  [DispId(65581)]
  void _Dummy45();

  [DispId(643)]
  bool DisplayAutomaticPageBreaks
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [DispId(643)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(643)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [param: In]
    set;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(772)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object Drawings([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Index);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [DispId(88)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object DrawingObjects([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Index);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [DispId(836)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object DropDowns([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Index);

  [DispId(1156)]
  bool EnableAutoFilter
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1156)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1156)]
    [param: In]
    set;
  }

  [DispId(1425)]
  XlEnableSelection EnableSelection
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1425)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1425)]
    [param: In]
    set;
  }

  [DispId(1157)]
  bool EnableOutlining
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1157)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1157)]
    [param: In]
    set;
  }

  [DispId(1158)]
  bool EnablePivotTable
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1158)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1158)]
    [param: In]
    set;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Evaluate([In] [MarshalAs(UnmanagedType.Struct)] object Name);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FNonBrowsable)]
  [DispId(-5)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object _Evaluate([In] [MarshalAs(UnmanagedType.Struct)] object Name);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(65592)]
  [TypeLibFunc(TypeLibFuncFlags.FRestricted | TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  void _Dummy56();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1426)]
  void ResetAllPageBreaks();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [DispId(834)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object GroupBoxes([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Index);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [DispId(1113)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object GroupObjects([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Index);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(841)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object Labels([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Index);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(767)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object Lines([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Index);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [DispId(832)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object ListBoxes([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Index);

  [DispId(442)]
  Names Names
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(442)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(799)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object OLEObjects([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Index);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(65601)]
  [TypeLibFunc(TypeLibFuncFlags.FRestricted | TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  void _Dummy65();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(65602)]
  [TypeLibFunc(TypeLibFuncFlags.FRestricted | TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  void _Dummy66();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(65603)]
  [TypeLibFunc(TypeLibFuncFlags.FRestricted | TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  void _Dummy67();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [DispId(826)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object OptionButtons([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Index);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FRestricted | TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  [DispId(65605)]
  void _Dummy69();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [DispId(801)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object Ovals([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Index);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(211)]
  void Paste
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Destination,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Link);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1027)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  void _PasteSpecial
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Format,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Link,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object DisplayAsIcon,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object IconFileName,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object IconIndex,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object IconLabel);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(771)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object Pictures([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Index);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FRestricted | TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  [DispId(65610)]
  void _Dummy74();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FRestricted | TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  [DispId(65611)]
  void _Dummy75();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(65612)]
  [TypeLibFunc(TypeLibFuncFlags.FRestricted | TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  void _Dummy76();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [DispId(774)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object Rectangles([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Index);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(65614)]
  [TypeLibFunc(TypeLibFuncFlags.FRestricted | TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  void _Dummy78();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(65615)]
  [TypeLibFunc(TypeLibFuncFlags.FRestricted | TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  void _Dummy79();

  [DispId(1433)]
  string ScrollArea
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1433)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1433)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(830)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object ScrollBars([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Index);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(65618)]
  [TypeLibFunc(TypeLibFuncFlags.FRestricted | TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  void _Dummy82();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FRestricted | TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  [DispId(65619)]
  void _Dummy83();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [DispId(838)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object Spinners([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Index);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(65621)]
  [TypeLibFunc(TypeLibFuncFlags.FRestricted | TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  void _Dummy85();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(65622)]
  [TypeLibFunc(TypeLibFuncFlags.FRestricted | TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  void _Dummy86();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(777)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object TextBoxes([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Index);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FRestricted | TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  [DispId(65624)]
  void _Dummy88();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FRestricted | TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  [DispId(65625)]
  void _Dummy89();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(65626)]
  [TypeLibFunc(TypeLibFuncFlags.FRestricted | TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  void _Dummy90();

  [DispId(1418)]
  HPageBreaks HPageBreaks
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1418)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1419)]
  VPageBreaks VPageBreaks
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1419)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1434)]
  QueryTables QueryTables
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1434)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1435)]
  bool DisplayPageBreaks
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1435)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1435)]
    [param: In]
    set;
  }

  [DispId(575)]
  Comments Comments
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(575)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1393)]
  Hyperlinks Hyperlinks
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1393)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1436)]
  void ClearCircles();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1437)]
  void CircleInvalid();

  [DispId(648)]
  int _DisplayRightToLeft
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(648)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
    [DispId(648)]
    [param: In]
    set;
  }

  [DispId(793)]
  AutoFilter _AutoFilter
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(793)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1774)]
  bool DisplayRightToLeft
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1774)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1774)]
    [param: In]
    set;
  }

  [DispId(1816)]
  Scripts Scripts
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1816)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  [DispId(1772)]
  void PrintOut
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object From,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object To,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Copies,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Preview,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ActivePrinter,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object PrintToFile,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Collate,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object PrToFileName);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1817)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  void _CheckSpelling
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object CustomDictionary,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object IgnoreUppercase,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object AlwaysSuggest,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object SpellLang,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object IgnoreFinalYaa,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object SpellScript);

  [DispId(1041)]
  Tab Tab
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1041)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(2021)]
  MsoEnvelope MailEnvelope
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2021)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  [DispId(1925)]
  void SaveAs
  ([In] [MarshalAs(UnmanagedType.BStr)] string Filename,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object FileFormat,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Password,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object WriteResPassword,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ReadOnlyRecommended,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object CreateBackup,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object AddToMru,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object TextCodepage,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object TextVisualLayout,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Local);

  [DispId(2030)]
  CustomProperties CustomProperties
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2030)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(2016)]
  SmartTags SmartTags
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [DispId(2016)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(176)]
  Protection Protection
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(176)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1928)]
  void PasteSpecial
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Format,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Link,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object DisplayAsIcon,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object IconFileName,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object IconIndex,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object IconLabel,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object NoHTMLFormatting);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2029)]
  void Protect
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Password,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object DrawingObjects,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Contents,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Scenarios,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object UserInterfaceOnly,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object AllowFormattingCells,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object AllowFormattingColumns,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object AllowFormattingRows,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object AllowInsertingColumns,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object AllowInsertingRows,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object AllowInsertingHyperlinks,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object AllowDeletingColumns,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object AllowDeletingRows,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object AllowSorting,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object AllowFiltering,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object AllowUsingPivotTables);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(65649)]
  [TypeLibFunc(TypeLibFuncFlags.FRestricted | TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  void _Dummy113();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(65650)]
  [TypeLibFunc(TypeLibFuncFlags.FRestricted | TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  void _Dummy114();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(65651)]
  [TypeLibFunc(TypeLibFuncFlags.FRestricted | TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  void _Dummy115();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2361)]
  void PrintOutEx
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object From,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object To,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Copies,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Preview,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ActivePrinter,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object PrintToFile,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Collate,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object PrToFileName);

  [DispId(2511)]
  bool EnableFormatConditionsCalculation
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2511)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2511)]
    [param: In]
    set;
  }

  [DispId(880)]
  Sort _Sort
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
    [DispId(880)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2493)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  void ExportAsFixedFormat
  ([In] XlFixedFormatType Type, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Filename,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Quality,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object IncludeDocProperties,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object IgnorePrintAreas,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object From,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object To,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object OpenAfterPublish,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object FixedFormatExtClassPtr);

  [DispId(2857)]
  int PrintedCommentPages
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2857)]
    get;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(3175)]
  void ExportAsFixedFormat2
  ([In] XlFixedFormatType Type, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Filename,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Quality,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object IncludeDocProperties,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object IgnorePrintAreas,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object From,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object To,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object OpenAfterPublish,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object FixedFormatExtClassPtr,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object WorkIdentity);

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
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object TextVisualLayout,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Local);

  [DispId(3282)]
  CommentsThreaded CommentsThreaded
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3282)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(3289)]
  AutoFilter AutoFilter
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3289)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(3288)]
  Sort Sort
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3288)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(3309)]
  NamedSheetViewCollection NamedSheetViews
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3309)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(857)]
  object DefaultButton
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(857)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(857)]
    [param: In]
    [param: MarshalAs(UnmanagedType.Struct)]
    set;
  }

  [DispId(839)]
  DialogFrame DialogFrame
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(839)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [DispId(828)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object EditBoxes([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Index);

  [DispId(814)]
  object Focus
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(814)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(814)]
    [param: In]
    [param: MarshalAs(UnmanagedType.Struct)]
    set;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(813)]
  bool Hide([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Cancel);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(496)]
  bool Show();
}