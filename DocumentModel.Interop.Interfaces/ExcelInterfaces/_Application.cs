using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

using Microsoft.Office.Core;
using Microsoft.Vbe.Interop;

namespace DocumentModel.Interop.Excel;

[ComImport]
[TypeLibType(TypeLibTypeFlags.FDual | TypeLibTypeFlags.FDispatchable)]
[Guid("000208D5-0000-0000-C000-000000000046")]
[DefaultMember("_Default")]
public interface _Application
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
  Application Parent
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(150)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(305)]
  Range ActiveCell
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(305)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(183)]
  Chart ActiveChart
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(183)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(815)]
  DialogSheet ActiveDialog
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(815)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(758)]
  MenuBar ActiveMenuBar
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(758)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(306)]
  string ActivePrinter
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(306)]
    [LCIDConversion(0)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(306)]
    [LCIDConversion(0)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(307)]
  object ActiveSheet
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(307)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [DispId(759)]
  Window ActiveWindow
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(759)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(308)]
  Workbook ActiveWorkbook
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(308)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(549)]
  AddIns AddIns
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FNonBrowsable)]
    [DispId(549)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1438)]
  Assistant Assistant
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1438)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [LCIDConversion(0)]
  [DispId(279)]
  void Calculate();

  [DispId(238)]
  Range Cells
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(238)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(121)]
  Sheets Charts
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(121)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(241)]
  Range Columns
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(241)]
    [TypeLibFunc(TypeLibFuncFlags.FNonBrowsable)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1439)]
  CommandBars CommandBars
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1439)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(332)]
  int DDEAppReturnCode
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(332)]
    [LCIDConversion(0)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(333)]
  [LCIDConversion(2)]
  void DDEExecute([In] int Channel, [In] [MarshalAs(UnmanagedType.BStr)] string String);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [LCIDConversion(2)]
  [DispId(334)]
  int DDEInitiate([In] [MarshalAs(UnmanagedType.BStr)] string App, [In] [MarshalAs(UnmanagedType.BStr)] string Topic);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [LCIDConversion(3)]
  [DispId(335)]
  void DDEPoke
  ([In] int Channel, [In] [MarshalAs(UnmanagedType.Struct)] object Item,
    [In] [MarshalAs(UnmanagedType.Struct)] object Data);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(336)]
  [LCIDConversion(2)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object DDERequest([In] int Channel, [In] [MarshalAs(UnmanagedType.BStr)] string Item);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(337)]
  [LCIDConversion(1)]
  void DDETerminate([In] int Channel);

  [DispId(764)]
  Sheets DialogSheets
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(764)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [LCIDConversion(1)]
  [DispId(1)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Evaluate([In] [MarshalAs(UnmanagedType.Struct)] object Name);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FNonBrowsable)]
  [DispId(-5)]
  [LCIDConversion(1)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object _Evaluate([In] [MarshalAs(UnmanagedType.Struct)] object Name);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(350)]
  [LCIDConversion(1)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object ExecuteExcel4Macro([In] [MarshalAs(UnmanagedType.BStr)] string String);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [LCIDConversion(30)]
  [DispId(766)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Range Intersect
  ([In] [MarshalAs(UnmanagedType.Interface)] Range Arg1, [In] [MarshalAs(UnmanagedType.Interface)] Range Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg6,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg7,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg8,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg9,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg10,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg11,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg12,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg13,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg14,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg15,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg16,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg17,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg18,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg19,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg20,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg21,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg22,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg23,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg24,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg25,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg26,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg27,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg28,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg29,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg30);

  [DispId(589)]
  MenuBars MenuBars
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [DispId(589)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(582)]
  Modules Modules
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [DispId(582)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(442)]
  Names Names
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(442)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(197)]
  Range Range
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(197)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

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
  [DispId(259)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Run
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Macro,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg1,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg6,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg7,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg8,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg9,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg10,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg11,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg12,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg13,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg14,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg15,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg16,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg17,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg18,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg19,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg20,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg21,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg22,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg23,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg24,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg25,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg26,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg27,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg28,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg29,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg30);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(806)]
  [LCIDConversion(31)]
  [TypeLibFunc(TypeLibFuncFlags.FNonBrowsable)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object _Run2
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Macro,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg1,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg6,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg7,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg8,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg9,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg10,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg11,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg12,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg13,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg14,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg15,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg16,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg17,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg18,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg19,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg20,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg21,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg22,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg23,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg24,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg25,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg26,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg27,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg28,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg29,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg30);

  [DispId(147)]
  object Selection
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(147)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [LCIDConversion(2)]
  [DispId(383)]
  void SendKeys
    ([In] [MarshalAs(UnmanagedType.Struct)] object Keys, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Wait);

  [DispId(485)]
  Sheets Sheets
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(485)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(776)]
  Menu ShortcutMenus
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(776)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(778)]
  Workbook ThisWorkbook
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(778)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(552)]
  Toolbars Toolbars
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [DispId(552)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(779)]
  [LCIDConversion(30)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Range Union
  ([In] [MarshalAs(UnmanagedType.Interface)] Range Arg1, [In] [MarshalAs(UnmanagedType.Interface)] Range Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg6,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg7,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg8,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg9,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg10,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg11,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg12,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg13,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg14,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg15,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg16,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg17,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg18,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg19,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg20,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg21,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg22,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg23,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg24,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg25,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg26,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg27,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg28,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg29,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg30);

  [DispId(430)]
  Windows Windows
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(430)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(572)]
  Workbooks Workbooks
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(572)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1440)]
  WorksheetFunction WorksheetFunction
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1440)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(494)]
  Sheets Worksheets
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(494)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(581)]
  Sheets Excel4IntlMacroSheets
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(581)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(579)]
  Sheets Excel4MacroSheets
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(579)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1095)]
  [LCIDConversion(1)]
  void ActivateMicrosoftApp([In] XlMSApplication Index);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [DispId(216)]
  [LCIDConversion(3)]
  void AddChartAutoFormat
  ([In] [MarshalAs(UnmanagedType.Struct)] object Chart, [In] [MarshalAs(UnmanagedType.BStr)] string Name,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Description);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(780)]
  [LCIDConversion(2)]
  void AddCustomList
  ([In] [MarshalAs(UnmanagedType.Struct)] object ListArray,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ByRow);

  [DispId(930)]
  bool AlertBeforeOverwriting
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(930)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(930)]
    [LCIDConversion(0)]
    [param: In]
    set;
  }

  [DispId(313)]
  string AltStartupPath
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(313)]
    [LCIDConversion(0)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(313)]
    [LCIDConversion(0)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(992)]
  bool AskToUpdateLinks
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(992)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(992)]
    [param: In]
    set;
  }

  [DispId(1180)]
  bool EnableAnimations
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1180)]
    [LCIDConversion(0)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(1180)]
    [param: In]
    set;
  }

  [DispId(1145)]
  AutoCorrect AutoCorrect
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1145)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(314)]
  int Build
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(314)]
    [LCIDConversion(0)]
    get;
  }

  [DispId(315)]
  bool CalculateBeforeSave
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(315)]
    [LCIDConversion(0)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(315)]
    [param: In]
    set;
  }

  [DispId(316)]
  XlCalculation Calculation
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(316)]
    [LCIDConversion(0)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(316)]
    [LCIDConversion(0)]
    [param: In]
    set;
  }

  [DispId(317)]
  object Caller
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(1)]
    [DispId(317)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
  }

  [DispId(318)]
  bool CanPlaySounds
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(318)]
    [LCIDConversion(0)]
    get;
  }

  [DispId(319)]
  bool CanRecordSounds
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(319)]
    [LCIDConversion(0)]
    get;
  }

  [DispId(139)]
  string Caption
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(139)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(139)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(320)]
  bool CellDragAndDrop
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(320)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(320)]
    [LCIDConversion(0)]
    [param: In]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [LCIDConversion(1)]
  [DispId(1086)]
  double CentimetersToPoints([In] double Centimeters);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [LCIDConversion(3)]
  [DispId(505)]
  bool CheckSpelling
  ([In] [MarshalAs(UnmanagedType.BStr)] string Word,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object CustomDictionary,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object IgnoreUppercase);

  [DispId(321)]
  object ClipboardFormats
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(321)]
    [LCIDConversion(1)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
  }

  [DispId(322)]
  bool DisplayClipboardWindow
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(322)]
    [LCIDConversion(0)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(322)]
    [LCIDConversion(0)]
    [param: In]
    set;
  }

  [DispId(365)]
  bool ColorButtons
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [DispId(365)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [DispId(365)]
    [param: In]
    set;
  }

  [DispId(323)]
  XlCommandUnderlines CommandUnderlines
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(323)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(323)]
    [param: In]
    set;
  }

  [DispId(324)]
  bool ConstrainNumeric
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(324)]
    [LCIDConversion(0)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(324)]
    [param: In]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(325)]
  [LCIDConversion(5)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object ConvertFormula
  ([In] [MarshalAs(UnmanagedType.Struct)] object Formula, [In] XlReferenceStyle FromReferenceStyle,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ToReferenceStyle,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ToAbsolute,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object RelativeTo);

  [DispId(991)]
  bool CopyObjectsWithCells
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(991)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(991)]
    [LCIDConversion(0)]
    [param: In]
    set;
  }

  [DispId(1161)]
  XlMousePointer Cursor
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1161)]
    [LCIDConversion(0)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(1161)]
    [param: In]
    set;
  }

  [DispId(787)]
  int CustomListCount
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(787)]
    get;
  }

  [DispId(330)]
  XlCutCopyMode CutCopyMode
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(330)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(330)]
    [LCIDConversion(0)]
    [param: In]
    set;
  }

  [DispId(331)]
  int DataEntryMode
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(331)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(331)]
    [param: In]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1782)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Dummy1
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg1,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1783)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Dummy2
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg1,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg6,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg7,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg8);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1784)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Dummy3();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1785)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Dummy4
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg1,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg6,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg7,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg8,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg9,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg10,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg11,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg12,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg13,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg14,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg15);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [DispId(1786)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Dummy5
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg1,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg6,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg7,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg8,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg9,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg10,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg11,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg12,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg13);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1787)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Dummy6();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1788)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Dummy7();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1789)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Dummy8([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [DispId(1790)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Dummy9();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1791)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  bool Dummy10([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object arg);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [DispId(1792)]
  void Dummy11();

  [DispId(0)]
  string _Default
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(0)]
    [TypeLibFunc(TypeLibFuncFlags.FNonBrowsable)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
  }

  [DispId(1038)]
  string DefaultFilePath
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1038)]
    [LCIDConversion(0)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1038)]
    [LCIDConversion(0)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [DispId(217)]
  [LCIDConversion(1)]
  void DeleteChartAutoFormat([In] [MarshalAs(UnmanagedType.BStr)] string Name);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(783)]
  [LCIDConversion(1)]
  void DeleteCustomList([In] int ListNum);

  [DispId(761)]
  Dialogs Dialogs
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(761)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(343)]
  bool DisplayAlerts
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(343)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(343)]
    [LCIDConversion(0)]
    [param: In]
    set;
  }

  [DispId(344)]
  bool DisplayFormulaBar
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(344)]
    [LCIDConversion(0)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(344)]
    [param: In]
    set;
  }

  [DispId(1061)]
  bool DisplayFullScreen
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1061)]
    [LCIDConversion(0)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1061)]
    [LCIDConversion(0)]
    [param: In]
    set;
  }

  [DispId(345)]
  bool DisplayNoteIndicator
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(345)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(345)]
    [param: In]
    set;
  }

  [DispId(1196)]
  XlCommentDisplayMode DisplayCommentIndicator
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1196)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1196)]
    [param: In]
    set;
  }

  [DispId(927)]
  bool DisplayExcel4Menus
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(927)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(927)]
    [LCIDConversion(0)]
    [param: In]
    set;
  }

  [DispId(926)]
  bool DisplayRecentFiles
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(926)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(926)]
    [param: In]
    set;
  }

  [DispId(346)]
  bool DisplayScrollBars
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(346)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(346)]
    [param: In]
    set;
  }

  [DispId(347)]
  bool DisplayStatusBar
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(347)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(347)]
    [LCIDConversion(0)]
    [param: In]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(349)]
  [LCIDConversion(0)]
  void DoubleClick();

  [DispId(929)]
  bool EditDirectlyInCell
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(929)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(929)]
    [param: In]
    set;
  }

  [DispId(1179)]
  bool EnableAutoComplete
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1179)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1179)]
    [param: In]
    set;
  }

  [DispId(1096)]
  XlEnableCancelKey EnableCancelKey
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(1096)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1096)]
    [LCIDConversion(0)]
    [param: In]
    set;
  }

  [DispId(1197)]
  bool EnableSound
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1197)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1197)]
    [param: In]
    set;
  }

  [DispId(1064)]
  bool EnableTipWizard
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [DispId(1064)]
    [LCIDConversion(0)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [DispId(1064)]
    [LCIDConversion(0)]
    [param: In]
    set;
  }

  [DispId(931)]
  object FileConverters
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(931)]
    [LCIDConversion(2)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
  }

  [DispId(1200)]
  FileSearch FileSearch
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1200)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1201)]
  IFind FileFind
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [DispId(1201)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [LCIDConversion(0)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  [DispId(1068)]
  void _FindFile();

  [DispId(351)]
  bool FixedDecimal
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(351)]
    [LCIDConversion(0)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(351)]
    [param: In]
    set;
  }

  [DispId(352)]
  int FixedDecimalPlaces
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(352)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(352)]
    [param: In]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(786)]
  [LCIDConversion(1)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object GetCustomListContents([In] int ListNum);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [LCIDConversion(1)]
  [DispId(785)]
  int GetCustomListNum([In] [MarshalAs(UnmanagedType.Struct)] object ListArray);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1075)]
  [LCIDConversion(5)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object GetOpenFilename
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object FileFilter,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object FilterIndex,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Title,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ButtonText,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object MultiSelect);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [LCIDConversion(5)]
  [DispId(1076)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object GetSaveAsFilename
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object InitialFilename,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object FileFilter,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object FilterIndex,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Title,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ButtonText);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [LCIDConversion(2)]
  [DispId(475)]
  void Goto
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Reference,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Scroll);

  [DispId(123)]
  double Height
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(123)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(123)]
    [param: In]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [LCIDConversion(2)]
  [DispId(354)]
  void Help
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object HelpFile,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object HelpContextID);

  [DispId(356)]
  bool IgnoreRemoteRequests
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(356)]
    [LCIDConversion(0)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(356)]
    [LCIDConversion(0)]
    [param: In]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1087)]
  [LCIDConversion(1)]
  double InchesToPoints([In] double Inches);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(357)]
  [LCIDConversion(8)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object InputBox
  ([In] [MarshalAs(UnmanagedType.BStr)] string Prompt, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Title,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Default,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Left,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Top,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object HelpFile,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object HelpContextID,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Type);

  [DispId(361)]
  bool Interactive
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(361)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(361)]
    [param: In]
    set;
  }

  [DispId(362)]
  object International
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(362)]
    [LCIDConversion(1)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
  }

  [DispId(363)]
  bool Iteration
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(363)]
    [LCIDConversion(0)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(363)]
    [LCIDConversion(0)]
    [param: In]
    set;
  }

  [DispId(364)]
  bool LargeButtons
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [DispId(364)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(364)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [param: In]
    set;
  }

  [DispId(127)]
  double Left
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(127)]
    [LCIDConversion(0)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(127)]
    [LCIDConversion(0)]
    [param: In]
    set;
  }

  [DispId(366)]
  string LibraryPath
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(366)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1135)]
  [LCIDConversion(10)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  void MacroOptions
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Macro,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Description,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object HasMenu,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object MenuText,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object HasShortcutKey,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ShortcutKey,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Category,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object StatusBar,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object HelpContextID,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object HelpFile);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(945)]
  [LCIDConversion(0)]
  void MailLogoff();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(943)]
  [LCIDConversion(3)]
  void MailLogon
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Name,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Password,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object DownloadNewMail);

  [DispId(942)]
  object MailSession
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(942)]
    [LCIDConversion(0)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
  }

  [DispId(971)]
  XlMailSystem MailSystem
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(971)]
    get;
  }

  [DispId(367)]
  bool MathCoprocessorAvailable
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(367)]
    get;
  }

  [DispId(368)]
  double MaxChange
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(368)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(368)]
    [param: In]
    set;
  }

  [DispId(369)]
  int MaxIterations
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(369)]
    [LCIDConversion(0)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(369)]
    [LCIDConversion(0)]
    [param: In]
    set;
  }

  [DispId(370)]
  int MemoryFree
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(370)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [LCIDConversion(0)]
    get;
  }

  [DispId(371)]
  int MemoryTotal
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(371)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [LCIDConversion(0)]
    get;
  }

  [DispId(372)]
  int MemoryUsed
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [DispId(372)]
    [LCIDConversion(0)]
    get;
  }

  [DispId(373)]
  bool MouseAvailable
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(373)]
    get;
  }

  [DispId(374)]
  bool MoveAfterReturn
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(374)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(374)]
    [param: In]
    set;
  }

  [DispId(1144)]
  XlDirection MoveAfterReturnDirection
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1144)]
    [LCIDConversion(0)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(1144)]
    [param: In]
    set;
  }

  [DispId(1202)]
  RecentFiles RecentFiles
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1202)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(110)]
  string Name
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(110)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(972)]
  [LCIDConversion(0)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Workbook NextLetter();

  [DispId(388)]
  string NetworkTemplatesPath
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(388)]
    [LCIDConversion(0)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
  }

  [DispId(1203)]
  ODBCErrors ODBCErrors
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1203)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1204)]
  int ODBCTimeout
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1204)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1204)]
    [param: In]
    set;
  }

  [DispId(625)]
  string OnCalculate
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(625)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [LCIDConversion(0)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [DispId(625)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(629)]
  string OnData
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(629)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [DispId(629)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
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
    [LCIDConversion(0)]
    [DispId(628)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(627)]
  string OnEntry
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [DispId(627)]
    [LCIDConversion(0)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(627)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [LCIDConversion(2)]
  [DispId(626)]
  void OnKey
  ([In] [MarshalAs(UnmanagedType.BStr)] string Key,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Procedure);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [LCIDConversion(2)]
  [DispId(769)]
  void OnRepeat
    ([In] [MarshalAs(UnmanagedType.BStr)] string Text, [In] [MarshalAs(UnmanagedType.BStr)] string Procedure);

  [DispId(1031)]
  string OnSheetActivate
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1031)]
    [LCIDConversion(0)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
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
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [LCIDConversion(0)]
    [DispId(1081)]
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

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [LCIDConversion(4)]
  [DispId(624)]
  void OnTime
  ([In] [MarshalAs(UnmanagedType.Struct)] object EarliestTime, [In] [MarshalAs(UnmanagedType.BStr)] string Procedure,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object LatestTime,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Schedule);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(770)]
  [LCIDConversion(2)]
  void OnUndo([In] [MarshalAs(UnmanagedType.BStr)] string Text, [In] [MarshalAs(UnmanagedType.BStr)] string Procedure);

  [DispId(623)]
  string OnWindow
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(623)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(623)]
    [LCIDConversion(0)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(375)]
  string OperatingSystem
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(375)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
  }

  [DispId(376)]
  string OrganizationName
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(376)]
    [LCIDConversion(0)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
  }

  [DispId(291)]
  string Path
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(291)]
    [LCIDConversion(0)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
  }

  [DispId(377)]
  string PathSeparator
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(377)]
    [LCIDConversion(0)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
  }

  [DispId(378)]
  object PreviousSelections
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(1)]
    [DispId(378)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
  }

  [DispId(1205)]
  bool PivotTableSelection
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1205)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1205)]
    [param: In]
    set;
  }

  [DispId(1062)]
  bool PromptForSummaryInfo
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(1062)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(1062)]
    [param: In]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(302)]
  void Quit();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [LCIDConversion(2)]
  [DispId(773)]
  void RecordMacro
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object BasicCode,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object XlmCode);

  [DispId(379)]
  bool RecordRelative
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(379)]
    get;
  }

  [DispId(380)]
  XlReferenceStyle ReferenceStyle
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(380)]
    [LCIDConversion(0)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(380)]
    [param: In]
    set;
  }

  [DispId(775)]
  object RegisteredFunctions
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(775)]
    [LCIDConversion(2)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [LCIDConversion(1)]
  [DispId(30)]
  bool RegisterXLL([In] [MarshalAs(UnmanagedType.BStr)] string Filename);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(301)]
  [LCIDConversion(0)]
  void Repeat();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [LCIDConversion(0)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [DispId(928)]
  void ResetTipWizard();

  [DispId(1206)]
  bool RollZoom
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1206)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1206)]
    [param: In]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [LCIDConversion(1)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [DispId(283)]
  void Save([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Filename);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(212)]
  [LCIDConversion(1)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  void SaveWorkspace([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Filename);

  [DispId(382)]
  bool ScreenUpdating
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(382)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(382)]
    [param: In]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [DispId(219)]
  void SetDefaultChart
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object FormatName,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Gallery);

  [DispId(993)]
  int SheetsInNewWorkbook
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(993)]
    [LCIDConversion(0)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(993)]
    [param: In]
    set;
  }

  [DispId(1207)]
  bool ShowChartTipNames
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1207)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1207)]
    [param: In]
    set;
  }

  [DispId(1208)]
  bool ShowChartTipValues
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1208)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1208)]
    [param: In]
    set;
  }

  [DispId(924)]
  string StandardFont
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(924)]
    [LCIDConversion(0)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(924)]
    [LCIDConversion(0)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(925)]
  double StandardFontSize
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(925)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(925)]
    [LCIDConversion(0)]
    [param: In]
    set;
  }

  [DispId(385)]
  string StartupPath
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(385)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
  }

  [DispId(386)]
  object StatusBar
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(386)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(386)]
    [param: In]
    [param: MarshalAs(UnmanagedType.Struct)]
    set;
  }

  [DispId(381)]
  string TemplatesPath
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(381)]
    [LCIDConversion(0)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
  }

  [DispId(387)]
  bool ShowToolTips
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(387)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(387)]
    [param: In]
    set;
  }

  [DispId(126)]
  double Top
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(126)]
    [LCIDConversion(0)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(126)]
    [param: In]
    set;
  }

  [DispId(1209)]
  XlFileFormat DefaultSaveFormat
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1209)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1209)]
    [param: In]
    set;
  }

  [DispId(310)]
  string TransitionMenuKey
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(310)]
    [LCIDConversion(0)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(310)]
    [LCIDConversion(0)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(311)]
  int TransitionMenuKeyAction
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(311)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(311)]
    [param: In]
    set;
  }

  [DispId(312)]
  bool TransitionNavigKeys
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(312)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(312)]
    [LCIDConversion(0)]
    [param: In]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [LCIDConversion(0)]
  [DispId(303)]
  void Undo();

  [DispId(389)]
  double UsableHeight
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(389)]
    [LCIDConversion(0)]
    get;
  }

  [DispId(390)]
  double UsableWidth
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(390)]
    get;
  }

  [DispId(1210)]
  bool UserControl
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1210)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1210)]
    [param: In]
    set;
  }

  [DispId(391)]
  string UserName
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(391)]
    [LCIDConversion(0)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(391)]
    [LCIDConversion(0)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(6)]
  string Value
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(6)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
  }

  [DispId(1211)]
  VBE VBE
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1211)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(392)]
  string Version
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(392)]
    [LCIDConversion(0)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
  }

  [DispId(558)]
  bool Visible
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(558)]
    [LCIDConversion(0)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(558)]
    [param: In]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [LCIDConversion(1)]
  [DispId(788)]
  void Volatile([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Volatile);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [LCIDConversion(1)]
  [DispId(393)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  void _Wait([In] [MarshalAs(UnmanagedType.Struct)] object Time);

  [DispId(122)]
  double Width
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(122)]
    [LCIDConversion(0)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(122)]
    [LCIDConversion(0)]
    [param: In]
    set;
  }

  [DispId(395)]
  bool WindowsForPens
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(395)]
    get;
  }

  [DispId(396)]
  XlWindowState WindowState
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(396)]
    [LCIDConversion(0)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(396)]
    [param: In]
    set;
  }

  [DispId(2)]
  int UILanguage
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [DispId(2)]
    [LCIDConversion(0)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [LCIDConversion(0)]
    [DispId(2)]
    [param: In]
    set;
  }

  [DispId(229)]
  int DefaultSheetDirection
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(229)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(229)]
    [LCIDConversion(0)]
    [param: In]
    set;
  }

  [DispId(232)]
  int CursorMovement
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(232)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(232)]
    [param: In]
    set;
  }

  [DispId(233)]
  bool ControlCharacters
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(233)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(233)]
    [LCIDConversion(0)]
    [param: In]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(169)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  [LCIDConversion(30)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object _WSFunction
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg1,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg6,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg7,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg8,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg9,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg10,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg11,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg12,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg13,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg14,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg15,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg16,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg17,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg18,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg19,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg20,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg21,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg22,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg23,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg24,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg25,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg26,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg27,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg28,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg29,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg30);

  [DispId(1212)]
  bool EnableEvents
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1212)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1212)]
    [param: In]
    set;
  }

  [DispId(1213)]
  bool DisplayInfoWindow
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1213)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [DispId(1213)]
    [param: In]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [LCIDConversion(1)]
  [DispId(1770)]
  bool Wait([In] [MarshalAs(UnmanagedType.Struct)] object Time);

  [DispId(1793)]
  bool ExtendList
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1793)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1793)]
    [param: In]
    set;
  }

  [DispId(1794)]
  OLEDBErrors OLEDBErrors
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1794)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1795)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetPhonetic([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Text);

  [DispId(1796)]
  COMAddIns COMAddIns
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1796)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1797)]
  DefaultWebOptions DefaultWebOptions
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1797)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1798)]
  string ProductCode
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1798)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
  }

  [DispId(1799)]
  string UserLibraryPath
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1799)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
  }

  [DispId(1800)]
  bool AutoPercentEntry
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1800)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1800)]
    [param: In]
    set;
  }

  [DispId(1801)]
  LanguageSettings LanguageSettings
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1801)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1802)]
  object Dummy101
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1802)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1803)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  void Dummy12
    ([In] [MarshalAs(UnmanagedType.Interface)] PivotTable p1, [In] [MarshalAs(UnmanagedType.Interface)] PivotTable p2);

  [DispId(1804)]
  AnswerWizard AnswerWizard
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1804)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1805)]
  void CalculateFull();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1771)]
  [LCIDConversion(0)]
  bool FindFile();

  [DispId(1806)]
  int CalculationVersion
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1806)]
    get;
  }

  [DispId(1807)]
  bool ShowWindowsInTaskbar
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [DispId(1807)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [DispId(1807)]
    [param: In]
    set;
  }

  [DispId(1808)]
  MsoFeatureInstall FeatureInstall
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1808)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1808)]
    [param: In]
    set;
  }

  [DispId(1932)]
  bool Ready
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1932)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1933)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Dummy13
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg6,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg7,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg8,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg9,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg10,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg11,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg12,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg13,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg14,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg15,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg16,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg17,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg18,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg19,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg20,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg21,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg22,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg23,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg24,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg25,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg26,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg27,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg28,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg29,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg30);

  [DispId(1934)]
  CellFormat FindFormat
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1934)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1934)]
    [param: In]
    [param: MarshalAs(UnmanagedType.Interface)]
    set;
  }

  [DispId(1935)]
  CellFormat ReplaceFormat
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1935)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1935)]
    [param: In]
    [param: MarshalAs(UnmanagedType.Interface)]
    set;
  }

  [DispId(1936)]
  UsedObjects UsedObjects
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1936)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1937)]
  XlCalculationState CalculationState
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1937)]
    get;
  }

  [DispId(1938)]
  XlCalculationInterruptKey CalculationInterruptKey
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1938)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1938)]
    [param: In]
    set;
  }

  [DispId(1939)]
  Watches Watches
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1939)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1940)]
  bool DisplayFunctionToolTips
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1940)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1940)]
    [param: In]
    set;
  }

  [DispId(1941)]
  MsoAutomationSecurity AutomationSecurity
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1941)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1941)]
    [param: In]
    set;
  }

  [DispId(1942)]
  FileDialog FileDialog
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1942)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [DispId(1944)]
  void Dummy14();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1945)]
  void CalculateFullRebuild();

  [DispId(1946)]
  bool DisplayPasteOptions
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1946)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1946)]
    [param: In]
    set;
  }

  [DispId(1947)]
  bool DisplayInsertOptions
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1947)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1947)]
    [param: In]
    set;
  }

  [DispId(1948)]
  bool GenerateGetPivotData
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1948)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1948)]
    [param: In]
    set;
  }

  [DispId(1949)]
  AutoRecover AutoRecover
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1949)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1950)]
  int Hwnd
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1950)]
    get;
  }

  [DispId(1951)]
  int Hinstance
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1951)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1952)]
  void CheckAbort([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object KeepAbort);

  [DispId(1954)]
  ErrorCheckingOptions ErrorCheckingOptions
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1954)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1955)]
  bool AutoFormatAsYouTypeReplaceHyperlinks
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1955)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1955)]
    [param: In]
    set;
  }

  [DispId(1956)]
  SmartTagRecognizers SmartTagRecognizers
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [DispId(1956)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1565)]
  NewFile NewWorkbook
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1565)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1957)]
  SpellingOptions SpellingOptions
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1957)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1958)]
  Speech Speech
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1958)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1959)]
  bool MapPaperSize
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1959)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1959)]
    [param: In]
    set;
  }

  [DispId(1960)]
  bool ShowStartupDialog
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1960)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1960)]
    [param: In]
    set;
  }

  [DispId(1809)]
  string DecimalSeparator
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1809)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1809)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(1810)]
  string ThousandsSeparator
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1810)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1810)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(1961)]
  bool UseSystemSeparators
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1961)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1961)]
    [param: In]
    set;
  }

  [DispId(1962)]
  Range ThisCell
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1962)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1963)]
  RTD RTD
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1963)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(2251)]
  bool DisplayDocumentActionTaskPane
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2251)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2251)]
    [param: In]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2252)]
  void DisplayXMLSourcePane([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object XmlMap);

  [DispId(2254)]
  bool ArbitraryXMLSupportAvailable
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2254)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2255)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Support
  ([In] [MarshalAs(UnmanagedType.IDispatch)] object Object, [In] int ID,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object arg);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2373)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Dummy20([In] int grfCompareFunctions);

  [DispId(2375)]
  int MeasurementUnit
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2375)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2375)]
    [param: In]
    set;
  }

  [DispId(2376)]
  bool ShowSelectionFloaties
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2376)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2376)]
    [param: In]
    set;
  }

  [DispId(2377)]
  bool ShowMenuFloaties
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2377)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2377)]
    [param: In]
    set;
  }

  [DispId(2378)]
  bool ShowDevTools
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2378)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2378)]
    [param: In]
    set;
  }

  [DispId(2379)]
  bool EnableLivePreview
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2379)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2379)]
    [param: In]
    set;
  }

  [DispId(2380)]
  bool DisplayDocumentInformationPanel
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2380)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2380)]
    [param: In]
    set;
  }

  [DispId(2381)]
  bool AlwaysUseClearType
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2381)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2381)]
    [param: In]
    set;
  }

  [DispId(2382)]
  bool WarnOnFunctionNameConflict
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2382)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2382)]
    [param: In]
    set;
  }

  [DispId(2383)]
  int FormulaBarHeight
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2383)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2383)]
    [param: In]
    set;
  }

  [DispId(2384)]
  bool DisplayFormulaAutoComplete
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2384)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2384)]
    [param: In]
    set;
  }

  [DispId(2385)]
  XlGenerateTableRefs GenerateTableRefs
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2385)]
    [LCIDConversion(0)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(2385)]
    [param: In]
    set;
  }

  [DispId(2386)]
  IAssistance Assistance
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2386)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2387)]
  void CalculateUntilAsyncQueriesDone();

  [DispId(2388)]
  bool EnableLargeOperationAlert
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2388)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2388)]
    [param: In]
    set;
  }

  [DispId(2389)]
  int LargeOperationCellThousandCount
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2389)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2389)]
    [param: In]
    set;
  }

  [DispId(2390)]
  bool DeferAsyncQueries
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2390)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2390)]
    [param: In]
    set;
  }

  [DispId(2391)]
  MultiThreadedCalculation MultiThreadedCalculation
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2391)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2392)]
  int SharePointVersion([In] [MarshalAs(UnmanagedType.BStr)] string bstrUrl);

  [DispId(2394)]
  int ActiveEncryptionSession
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2394)]
    get;
  }

  [DispId(2395)]
  bool HighQualityModeForGraphics
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2395)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2395)]
    [param: In]
    set;
  }

  [DispId(2768)]
  FileExportConverters FileExportConverters
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2768)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(2772)]
  SmartArtLayouts SmartArtLayouts
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2772)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(2773)]
  SmartArtQuickStyles SmartArtQuickStyles
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2773)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(2774)]
  SmartArtColors SmartArtColors
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2774)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(2775)]
  AddIns2 AddIns2
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2775)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(2776)]
  bool PrintCommunication
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2776)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2776)]
    [param: In]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2770)]
  [LCIDConversion(11)]
  void MacroOptions2
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Macro,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Description,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object HasMenu,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object MenuText,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object HasShortcutKey,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ShortcutKey,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Category,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object StatusBar,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object HelpContextID,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object HelpFile,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ArgumentDescriptions);

  [DispId(2778)]
  bool UseClusterConnector
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2778)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2778)]
    [param: In]
    set;
  }

  [DispId(2779)]
  string ClusterConnector
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2779)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2779)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(2780)]
  bool Quitting
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [DispId(2780)]
    get;
  }

  [DispId(2781)]
  bool Dummy22
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [DispId(2781)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2781)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [param: In]
    set;
  }

  [DispId(2782)]
  bool Dummy23
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [DispId(2782)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2782)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [param: In]
    set;
  }

  [DispId(2783)]
  ProtectedViewWindows ProtectedViewWindows
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2783)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(2784)]
  ProtectedViewWindow ActiveProtectedViewWindow
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2784)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(2785)]
  bool IsSandboxed
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2785)]
    get;
  }

  [DispId(2786)]
  bool SaveISO8601Dates
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2786)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [DispId(2786)]
    [param: In]
    set;
  }

  [DispId(2787)]
  object HinstancePtr
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2787)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
  }

  [DispId(2788)]
  MsoFileValidationMode FileValidation
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2788)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2788)]
    [param: In]
    set;
  }

  [DispId(2789)]
  XlFileValidationPivotMode FileValidationPivot
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2789)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2789)]
    [param: In]
    set;
  }

  [DispId(2994)]
  bool ShowQuickAnalysis
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2994)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2994)]
    [param: In]
    set;
  }

  [DispId(2995)]
  QuickAnalysis QuickAnalysis
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2995)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(2996)]
  bool FlashFill
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2996)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2996)]
    [param: In]
    set;
  }

  [DispId(2997)]
  bool EnableMacroAnimations
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2997)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2997)]
    [param: In]
    set;
  }

  [DispId(2998)]
  bool ChartDataPointTrack
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2998)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2998)]
    [param: In]
    set;
  }

  [DispId(2999)]
  bool FlashFillMode
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2999)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2999)]
    [param: In]
    set;
  }

  [DispId(3000)]
  bool MergeInstances
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3000)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3000)]
    [param: In]
    set;
  }

  [DispId(3158)]
  bool EnableCheckFileExtensions
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3158)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3158)]
    [param: In]
    set;
  }

  [DispId(3271)]
  DefaultPivotTableLayoutOptions DefaultPivotTableLayoutOptions
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3271)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(3312)]
  bool TruncateLeadingZeros
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3312)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [DispId(3312)]
    [param: In]
    set;
  }

  [DispId(3313)]
  bool TruncateLargeNumbers
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3313)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [DispId(3313)]
    [param: In]
    set;
  }

  [DispId(3314)]
  bool ConvertNumbersWithECharacter
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [DispId(3314)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [DispId(3314)]
    [param: In]
    set;
  }

  [DispId(3315)]
  bool CSVDisplayNumberConversionWarning
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3315)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3315)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [param: In]
    set;
  }

  [DispId(3316)]
  bool CSVKeepColumnAsTextIfMultipleEntriesAreText
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3316)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [DispId(3316)]
    [param: In]
    set;
  }

  [DispId(3317)]
  DataPrivacyOptions DataPrivacyOptions
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [DispId(3317)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(3311)]
  bool ShowConvertToDataType
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3311)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3311)]
    [param: In]
    set;
  }

  [DispId(3365)]
  SensitivityLabelPolicy SensitivityLabelPolicy
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3365)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(3401)]
  bool FormatStaleValues
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3401)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3401)]
    [param: In]
    set;
  }

  [DispId(3417)]
  int MaxSupportedCompatibilityVersion
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3417)]
    get;
  }
}