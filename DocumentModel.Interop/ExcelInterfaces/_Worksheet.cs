using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

using Microsoft.Office.Core;

namespace DocumentModel.Interop.Excel;

[ComImport]
[TypeLibType(TypeLibTypeFlags.FDual | TypeLibTypeFlags.FNonExtensible | TypeLibTypeFlags.FDispatchable)]
[Guid("000208D8-0000-0000-C000-000000000046")]
public interface _Worksheet
{
  [DispId(148)]
  Application Application
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(148)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(149)]
  XlCreator Creator
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(149)]
    get;
  }

  [DispId(150)]
  object Parent
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(150)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(304)]
  [LCIDConversion(0)]
  void Activate();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(551)]
  [LCIDConversion(2)]
  void Copy
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Before,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object After);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(117)]
  [LCIDConversion(0)]
  void Delete();

  [DispId(1373)]
  string CodeName
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1373)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
  }

  [DispId(-2147418112)]
  string _CodeName
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(-2147418112)]
    [TypeLibFunc(TypeLibFuncFlags.FNonBrowsable)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FNonBrowsable)]
    [DispId(-2147418112)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(486)]
  int Index
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(486)]
    [LCIDConversion(0)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [LCIDConversion(2)]
  [DispId(637)]
  void Move
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Before,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object After);

  [DispId(110)]
  string Name
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(110)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(110)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(502)]
  object Next
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(502)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [DispId(628)]
  string OnDoubleClick
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [DispId(628)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(628)]
    [LCIDConversion(0)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(1031)]
  string OnSheetActivate
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [DispId(1031)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [DispId(1031)]
    [LCIDConversion(0)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(1081)]
  string OnSheetDeactivate
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1081)]
    [LCIDConversion(0)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [DispId(1081)]
    [LCIDConversion(0)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(998)]
  PageSetup PageSetup
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(998)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(503)]
  object Previous
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(503)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(905)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  [LCIDConversion(7)]
  void _PrintOut
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object From,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object To,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Copies,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Preview,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ActivePrinter,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object PrintToFile,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Collate);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [LCIDConversion(1)]
  [DispId(281)]
  void PrintPreview([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object EnableChanges);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [LCIDConversion(5)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  [DispId(282)]
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
    [DispId(292)]
    [LCIDConversion(0)]
    get;
  }

  [DispId(293)]
  bool ProtectDrawingObjects
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(293)]
    get;
  }

  [DispId(1159)]
  bool ProtectionMode
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(1159)]
    get;
  }

  [DispId(294)]
  bool ProtectScenarios
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(294)]
    [LCIDConversion(0)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [LCIDConversion(9)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  [DispId(284)]
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
  [DispId(235)]
  void Select([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Replace);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(285)]
  [LCIDConversion(1)]
  void Unprotect([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Password);

  [DispId(558)]
  XlSheetVisibility Visible
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(558)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(558)]
    [param: In]
    set;
  }

  [DispId(1377)]
  Shapes Shapes
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1377)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(401)]
  bool TransitionExpEval
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FNonBrowsable)]
    [DispId(401)]
    [LCIDConversion(0)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(401)]
    [LCIDConversion(0)]
    [TypeLibFunc(TypeLibFuncFlags.FNonBrowsable)]
    [param: In]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [LCIDConversion(1)]
  [DispId(760)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object Arcs([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Index);

  [DispId(792)]
  bool AutoFilterMode
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FNonBrowsable)]
    [DispId(792)]
    [LCIDConversion(0)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(792)]
    [LCIDConversion(0)]
    [TypeLibFunc(TypeLibFuncFlags.FNonBrowsable)]
    [param: In]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1188)]
  void SetBackgroundPicture([In] [MarshalAs(UnmanagedType.BStr)] string Filename);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(557)]
  [LCIDConversion(1)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object Buttons([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Index);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [LCIDConversion(0)]
  [DispId(279)]
  void Calculate();

  [DispId(1424)]
  bool EnableCalculation
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1424)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1424)]
    [param: In]
    set;
  }

  [DispId(238)]
  Range Cells
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(238)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [LCIDConversion(1)]
  [DispId(1060)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object ChartObjects([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Index);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(824)]
  [LCIDConversion(1)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object CheckBoxes([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Index);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(505)]
  [LCIDConversion(4)]
  void CheckSpelling
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object CustomDictionary,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object IgnoreUppercase,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object AlwaysSuggest,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object SpellLang);

  [DispId(1069)]
  Range CircularReference
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1069)]
    [LCIDConversion(0)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [LCIDConversion(0)]
  [DispId(970)]
  void ClearArrows();

  [DispId(241)]
  Range Columns
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(241)]
    [TypeLibFunc(TypeLibFuncFlags.FNonBrowsable)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(789)]
  XlConsolidationFunction ConsolidationFunction
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(789)]
    [LCIDConversion(0)]
    get;
  }

  [DispId(790)]
  object ConsolidationOptions
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(790)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
  }

  [DispId(791)]
  object ConsolidationSources
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(791)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
  }

  [DispId(643)]
  bool DisplayAutomaticPageBreaks
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(643)]
    [LCIDConversion(0)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(643)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [param: In]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [LCIDConversion(1)]
  [DispId(772)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object Drawings([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Index);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [DispId(88)]
  [LCIDConversion(1)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object DrawingObjects([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Index);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(836)]
  [LCIDConversion(1)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object DropDowns([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Index);

  [DispId(1156)]
  bool EnableAutoFilter
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(1156)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1156)]
    [LCIDConversion(0)]
    [param: In]
    set;
  }

  [DispId(1425)]
  XlEnableSelection EnableSelection
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1425)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1425)]
    [param: In]
    set;
  }

  [DispId(1157)]
  bool EnableOutlining
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(1157)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(1157)]
    [param: In]
    set;
  }

  [DispId(1158)]
  bool EnablePivotTable
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1158)]
    [LCIDConversion(0)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(1158)]
    [param: In]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [LCIDConversion(1)]
  [DispId(1)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Evaluate([In] [MarshalAs(UnmanagedType.Struct)] object Name);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [LCIDConversion(1)]
  [TypeLibFunc(TypeLibFuncFlags.FNonBrowsable)]
  [DispId(-5)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object _Evaluate([In] [MarshalAs(UnmanagedType.Struct)] object Name);

  [DispId(800)]
  bool FilterMode
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(800)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1426)]
  void ResetAllPageBreaks();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [DispId(834)]
  [LCIDConversion(1)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object GroupBoxes([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Index);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [DispId(1113)]
  [LCIDConversion(1)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object GroupObjects([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Index);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [DispId(841)]
  [LCIDConversion(1)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object Labels([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Index);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [LCIDConversion(1)]
  [DispId(767)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object Lines([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Index);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [DispId(832)]
  [LCIDConversion(1)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object ListBoxes([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Index);

  [DispId(442)]
  Names Names
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(442)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(799)]
  [LCIDConversion(1)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object OLEObjects([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Index);

  [DispId(625)]
  string OnCalculate
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(625)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(625)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(629)]
  string OnData
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [DispId(629)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(629)]
    [LCIDConversion(0)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(627)]
  string OnEntry
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(627)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [LCIDConversion(0)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [LCIDConversion(0)]
    [DispId(627)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [DispId(826)]
  [LCIDConversion(1)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object OptionButtons([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Index);

  [DispId(102)]
  Outline Outline
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(102)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [LCIDConversion(1)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [DispId(801)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object Ovals([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Index);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [LCIDConversion(2)]
  [DispId(211)]
  void Paste
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Destination,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Link);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [LCIDConversion(6)]
  [DispId(1027)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  void _PasteSpecial
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Format,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Link,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object DisplayAsIcon,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object IconFileName,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object IconIndex,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object IconLabel);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(771)]
  [LCIDConversion(1)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object Pictures([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Index);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [LCIDConversion(1)]
  [DispId(690)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object PivotTables([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Index);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [LCIDConversion(16)]
  [DispId(684)]
  [return: MarshalAs(UnmanagedType.Interface)]
  PivotTable PivotTableWizard
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object SourceType,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object SourceData,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object TableDestination,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object TableName,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object RowGrand,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ColumnGrand,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object SaveData,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object HasAutoFormat,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object AutoPage,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Reserved,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object BackgroundQuery,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object OptimizeCache,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object PageFieldOrder,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object PageFieldWrapCount,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ReadData,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Connection);

  [DispId(197)]
  Range Range
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(197)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [DispId(774)]
  [LCIDConversion(1)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object Rectangles([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Index);

  [DispId(258)]
  Range Rows
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FNonBrowsable)]
    [DispId(258)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [LCIDConversion(1)]
  [DispId(908)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object Scenarios([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Index);

  [DispId(1433)]
  string ScrollArea
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1433)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1433)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [LCIDConversion(1)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [DispId(830)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object ScrollBars([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Index);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(794)]
  [LCIDConversion(0)]
  void ShowAllData();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [LCIDConversion(0)]
  [DispId(409)]
  void ShowDataForm();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [LCIDConversion(1)]
  [DispId(838)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object Spinners([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Index);

  [DispId(407)]
  double StandardHeight
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(407)]
    get;
  }

  [DispId(408)]
  double StandardWidth
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(408)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(408)]
    [LCIDConversion(0)]
    [param: In]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(777)]
  [LCIDConversion(1)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object TextBoxes([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Index);

  [DispId(402)]
  bool TransitionFormEntry
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(402)]
    [TypeLibFunc(TypeLibFuncFlags.FNonBrowsable)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FNonBrowsable)]
    [LCIDConversion(0)]
    [DispId(402)]
    [param: In]
    set;
  }

  [DispId(108)]
  XlSheetType Type
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(108)]
    [LCIDConversion(0)]
    get;
  }

  [DispId(412)]
  Range UsedRange
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(412)]
    [LCIDConversion(0)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1418)]
  HPageBreaks HPageBreaks
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1418)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1419)]
  VPageBreaks VPageBreaks
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1419)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1434)]
  QueryTables QueryTables
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1434)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1435)]
  bool DisplayPageBreaks
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1435)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1435)]
    [param: In]
    set;
  }

  [DispId(575)]
  Comments Comments
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(575)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1393)]
  Hyperlinks Hyperlinks
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1393)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1436)]
  void ClearCircles();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1437)]
  void CircleInvalid();

  [DispId(648)]
  int _DisplayRightToLeft
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(648)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
    [DispId(648)]
    [LCIDConversion(0)]
    [param: In]
    set;
  }

  [DispId(793)]
  AutoFilter _AutoFilter
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
    [DispId(793)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1774)]
  bool DisplayRightToLeft
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(1774)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(1774)]
    [param: In]
    set;
  }

  [DispId(1816)]
  Scripts Scripts
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1816)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1772)]
  [LCIDConversion(8)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  void PrintOut
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object From,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object To,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Copies,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Preview,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ActivePrinter,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object PrintToFile,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Collate,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object PrToFileName);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  [DispId(1817)]
  [LCIDConversion(6)]
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
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1041)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(2021)]
  MsoEnvelope MailEnvelope
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2021)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
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
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object TextVisualLayout,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Local);

  [DispId(2030)]
  CustomProperties CustomProperties
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2030)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(2016)]
  SmartTags SmartTags
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [DispId(2016)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(176)]
  Protection Protection
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(176)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1928)]
  [LCIDConversion(7)]
  void PasteSpecial
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Format,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Link,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object DisplayAsIcon,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object IconFileName,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object IconIndex,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object IconLabel,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object NoHTMLFormatting);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
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

  [DispId(2259)]
  ListObjects ListObjects
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2259)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2260)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Range XmlDataQuery
  ([In] [MarshalAs(UnmanagedType.BStr)] string XPath,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object SelectionNamespaces,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Map);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2263)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Range XmlMapQuery
  ([In] [MarshalAs(UnmanagedType.BStr)] string XPath,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object SelectionNamespaces,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Map);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2361)]
  [LCIDConversion(9)]
  void PrintOutEx
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object From,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object To,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Copies,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Preview,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ActivePrinter,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object PrintToFile,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Collate,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object PrToFileName,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object IgnorePrintAreas);

  [DispId(2511)]
  bool EnableFormatConditionsCalculation
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2511)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2511)]
    [param: In]
    set;
  }

  [DispId(880)]
  Sort _Sort
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(880)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  [DispId(2493)]
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
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2857)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
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

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
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
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3282)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(3289)]
  AutoFilter AutoFilter
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3289)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(3288)]
  Sort Sort
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3288)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(3309)]
  NamedSheetViewCollection NamedSheetViews
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3309)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }
}