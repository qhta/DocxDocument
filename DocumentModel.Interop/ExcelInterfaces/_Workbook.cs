using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

using Microsoft.Office.Core;
using Microsoft.Vbe.Interop;

namespace DocumentModel.Interop.Excel;

[ComImport]
[TypeLibType(TypeLibTypeFlags.FDual | TypeLibTypeFlags.FDispatchable)]
[Guid("000208DA-0000-0000-C000-000000000046")]
public interface _Workbook
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

  [DispId(1441)]
  bool AcceptLabelsInFormulas
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1441)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [DispId(1441)]
    [param: In]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(304)]
  [LCIDConversion(0)]
  void Activate();

  [DispId(183)]
  Chart ActiveChart
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(183)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(307)]
  object ActiveSheet
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(307)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [DispId(574)]
  string Author
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(574)]
    [LCIDConversion(0)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [DispId(574)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(1442)]
  int AutoUpdateFrequency
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1442)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1442)]
    [param: In]
    set;
  }

  [DispId(1443)]
  bool AutoUpdateSaveChanges
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1443)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1443)]
    [param: In]
    set;
  }

  [DispId(1444)]
  int ChangeHistoryDuration
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1444)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1444)]
    [param: In]
    set;
  }

  [DispId(1176)]
  object BuiltinDocumentProperties
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1176)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(989)]
  [LCIDConversion(3)]
  void ChangeFileAccess
  ([In] XlFileAccess Mode, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object WritePassword,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Notify);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(802)]
  [LCIDConversion(3)]
  void ChangeLink
  ([In] [MarshalAs(UnmanagedType.BStr)] string Name, [In] [MarshalAs(UnmanagedType.BStr)] string NewName,
    [In] XlLinkType Type = XlLinkType.xlLinkTypeExcelLinks);

  [DispId(121)]
  Sheets Charts
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(121)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(277)]
  [LCIDConversion(3)]
  void Close
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object SaveChanges,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Filename,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object RouteWorkbook);

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

  [DispId(286)]
  object Colors
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(286)]
    [LCIDConversion(1)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(1)]
    [DispId(286)]
    [param: Optional]
    [param: In]
    [param: MarshalAs(UnmanagedType.Struct)]
    set;
  }

  [DispId(1439)]
  CommandBars CommandBars
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1439)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(575)]
  string Comments
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(575)]
    [LCIDConversion(0)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(575)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [LCIDConversion(0)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(1175)]
  XlSaveConflictResolution ConflictResolution
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1175)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1175)]
    [param: In]
    set;
  }

  [DispId(1190)]
  object Container
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1190)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [DispId(287)]
  bool CreateBackup
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(287)]
    [LCIDConversion(0)]
    get;
  }

  [DispId(1177)]
  object CustomDocumentProperties
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1177)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [DispId(403)]
  bool Date1904
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(403)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(403)]
    [param: In]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(397)]
  [LCIDConversion(1)]
  void DeleteNumberFormat([In] [MarshalAs(UnmanagedType.BStr)] string NumberFormat);

  [DispId(764)]
  Sheets DialogSheets
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [DispId(764)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(404)]
  XlDisplayDrawingObjects DisplayDrawingObjects
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(404)]
    [LCIDConversion(0)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(404)]
    [LCIDConversion(0)]
    [param: In]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1168)]
  [LCIDConversion(0)]
  bool ExclusiveAccess();

  [DispId(288)]
  XlFileFormat FileFormat
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(288)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(973)]
  [LCIDConversion(0)]
  void ForwardMailer();

  [DispId(289)]
  string FullName
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(289)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
  }

  [DispId(976)]
  bool HasMailer
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [LCIDConversion(0)]
    [DispId(976)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [DispId(976)]
    [LCIDConversion(0)]
    [param: In]
    set;
  }

  [DispId(290)]
  bool HasPassword
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(290)]
    [LCIDConversion(0)]
    get;
  }

  [DispId(950)]
  bool HasRoutingSlip
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [DispId(950)]
    [LCIDConversion(0)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [LCIDConversion(0)]
    [DispId(950)]
    [param: In]
    set;
  }

  [DispId(1445)]
  bool IsAddin
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1445)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1445)]
    [param: In]
    set;
  }

  [DispId(577)]
  string Keywords
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [LCIDConversion(0)]
    [DispId(577)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [DispId(577)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(807)]
  [LCIDConversion(4)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object LinkInfo
  ([In] [MarshalAs(UnmanagedType.BStr)] string Name, [In] XlLinkInfo LinkInfo,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Type,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object EditionRef);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [LCIDConversion(1)]
  [DispId(808)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object LinkSources([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Type);

  [DispId(979)]
  Mailer Mailer
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(979)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1446)]
  void MergeWorkbook([In] [MarshalAs(UnmanagedType.Struct)] object Filename);

  [DispId(582)]
  Sheets Modules
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [DispId(582)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1169)]
  bool MultiUserEditing
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(1169)]
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

  [DispId(442)]
  Names Names
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(442)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(280)]
  [LCIDConversion(0)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Window NewWindow();

  [DispId(1178)]
  string OnSave
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(1178)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1178)]
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
    [DispId(1031)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [LCIDConversion(0)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1031)]
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
    [DispId(1081)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(1081)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(803)]
  [LCIDConversion(3)]
  void OpenLinks
  ([In] [MarshalAs(UnmanagedType.BStr)] string Name, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ReadOnly,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Type);

  [DispId(291)]
  string Path
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(291)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
  }

  [DispId(1447)]
  bool PersonalViewListSettings
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1447)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1447)]
    [param: In]
    set;
  }

  [DispId(1448)]
  bool PersonalViewPrintSettings
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1448)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1448)]
    [param: In]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1449)]
  [return: MarshalAs(UnmanagedType.Interface)]
  PivotCaches PivotCaches();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [LCIDConversion(1)]
  [DispId(1166)]
  void Post([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object DestName);

  [DispId(405)]
  bool PrecisionAsDisplayed
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(405)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(405)]
    [param: In]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  [DispId(905)]
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
  [DispId(282)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  void _Protect
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Password,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Structure,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Windows);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  [DispId(1450)]
  void ProtectSharing
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Filename,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Password,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object WriteResPassword,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ReadOnlyRecommended,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object CreateBackup,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object SharingPassword);

  [DispId(588)]
  bool ProtectStructure
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(588)]
    get;
  }

  [DispId(295)]
  bool ProtectWindows
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(295)]
    get;
  }

  [DispId(296)]
  bool ReadOnly
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(296)]
    get;
  }

  [DispId(297)]
  bool _ReadOnlyRecommended
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
    [DispId(297)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1452)]
  void RefreshAll();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(977)]
  [LCIDConversion(0)]
  void Reply();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [LCIDConversion(0)]
  [DispId(978)]
  void ReplyAll();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1453)]
  void RemoveUser([In] int Index);

  [DispId(1172)]
  int RevisionNumber
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(1172)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [DispId(946)]
  [LCIDConversion(0)]
  void Route();

  [DispId(951)]
  bool Routed
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [DispId(951)]
    [LCIDConversion(0)]
    get;
  }

  [DispId(949)]
  RoutingSlip RoutingSlip
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [DispId(949)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [LCIDConversion(1)]
  [DispId(634)]
  void RunAutoMacros([In] XlRunAutoMacro Which);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [LCIDConversion(0)]
  [DispId(283)]
  void Save();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(284)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  [LCIDConversion(11)]
  void _SaveAs
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Filename,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object FileFormat,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Password,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object WriteResPassword,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ReadOnlyRecommended,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object CreateBackup,
    [In] XlSaveAsAccessMode AccessMode = XlSaveAsAccessMode.xlNoChange,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ConflictResolution,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object AddToMru,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object TextCodepage,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object TextVisualLayout);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(175)]
  [LCIDConversion(1)]
  void SaveCopyAs([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Filename);

  [DispId(298)]
  bool Saved
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(298)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(298)]
    [LCIDConversion(0)]
    [param: In]
    set;
  }

  [DispId(406)]
  bool SaveLinkValues
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(406)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(406)]
    [LCIDConversion(0)]
    [param: In]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(947)]
  [LCIDConversion(3)]
  void SendMail
  ([In] [MarshalAs(UnmanagedType.Struct)] object Recipients,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Subject,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ReturnReceipt);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [LCIDConversion(2)]
  [DispId(980)]
  void SendMailer
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object FileFormat,
    [In] XlPriority Priority = XlPriority.xlPriorityNormal);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(809)]
  [LCIDConversion(2)]
  void SetLinkOnData
  ([In] [MarshalAs(UnmanagedType.BStr)] string Name,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Procedure);

  [DispId(485)]
  Sheets Sheets
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(485)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1171)]
  bool ShowConflictHistory
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1171)]
    [LCIDConversion(0)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(1171)]
    [param: In]
    set;
  }

  [DispId(493)]
  Styles Styles
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(493)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(953)]
  string Subject
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [DispId(953)]
    [LCIDConversion(0)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(953)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(199)]
  string Title
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(199)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [LCIDConversion(0)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(199)]
    [LCIDConversion(0)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [LCIDConversion(1)]
  [DispId(285)]
  void Unprotect([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Password);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1455)]
  void UnprotectSharing([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object SharingPassword);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [LCIDConversion(0)]
  [DispId(995)]
  void UpdateFromFile();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(804)]
  [LCIDConversion(2)]
  void UpdateLink
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Name,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Type);

  [DispId(411)]
  bool UpdateRemoteReferences
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(411)]
    [LCIDConversion(0)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(411)]
    [param: In]
    set;
  }

  [DispId(1210)]
  bool UserControl
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [DispId(1210)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1210)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [param: In]
    set;
  }

  [DispId(1173)]
  object UserStatus
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1173)]
    [LCIDConversion(0)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
  }

  [DispId(1456)]
  CustomViews CustomViews
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1456)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(430)]
  Windows Windows
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(430)]
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

  [DispId(299)]
  bool WriteReserved
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [LCIDConversion(0)]
    [DispId(299)]
    get;
  }

  [DispId(300)]
  string WriteReservedBy
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(300)]
    [LCIDConversion(0)]
    [return: MarshalAs(UnmanagedType.BStr)]
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

  [DispId(1457)]
  bool TemplateRemoveExtData
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1457)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1457)]
    [param: In]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1458)]
  void HighlightChangesOptions
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object When,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Who,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Where);

  [DispId(1461)]
  bool HighlightChangesOnScreen
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1461)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1461)]
    [param: In]
    set;
  }

  [DispId(1462)]
  bool KeepChangeHistory
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1462)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1462)]
    [param: In]
    set;
  }

  [DispId(1463)]
  bool ListChangesOnNewSheet
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1463)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1463)]
    [param: In]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1464)]
  void PurgeChangeHistoryNow([In] int Days, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object SharingPassword);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1466)]
  void AcceptAllChanges
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object When,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Who,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Where);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1467)]
  void RejectAllChanges
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object When,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Who,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Where);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(684)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [LCIDConversion(16)]
  void PivotTableWizard
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

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1468)]
  void ResetColors();

  [DispId(1469)]
  VBProject VBProject
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1469)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1470)]
  void FollowHyperlink
  ([In] [MarshalAs(UnmanagedType.BStr)] string Address,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object SubAddress,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object NewWindow,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object AddHistory,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ExtraInfo,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Method,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object HeaderInfo);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1476)]
  void AddToFavorites();

  [DispId(1769)]
  bool IsInplace
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1769)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [LCIDConversion(8)]
  [DispId(1772)]
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
  [DispId(1818)]
  void WebPagePreview();

  [DispId(1819)]
  PublishObjects PublishObjects
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1819)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1820)]
  WebOptions WebOptions
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1820)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1821)]
  void ReloadAs([In] MsoEncoding Encoding);

  [DispId(1823)]
  HTMLProject HTMLProject
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1823)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1824)]
  bool EnvelopeVisible
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1824)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1824)]
    [param: In]
    set;
  }

  [DispId(1806)]
  int CalculationVersion
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1806)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [DispId(2044)]
  void Dummy17([In] int calcid);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [DispId(1826)]
  void sblt([In] [MarshalAs(UnmanagedType.BStr)] string s);

  [DispId(1828)]
  bool VBASigned
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1828)]
    get;
  }

  [DispId(2046)]
  bool ShowPivotTableFieldList
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2046)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2046)]
    [param: In]
    set;
  }

  [DispId(864)]
  XlUpdateLinks UpdateLinks
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(864)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(864)]
    [param: In]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2047)]
  void BreakLink([In] [MarshalAs(UnmanagedType.BStr)] string Name, [In] XlLinkType Type);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [DispId(2048)]
  void Dummy16();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1925)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  [LCIDConversion(12)]
  void SaveAs
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Filename,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object FileFormat,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Password,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object WriteResPassword,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ReadOnlyRecommended,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object CreateBackup,
    [In] XlSaveAsAccessMode AccessMode = XlSaveAsAccessMode.xlNoChange,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ConflictResolution,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object AddToMru,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object TextCodepage,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object TextVisualLayout,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Local);

  [DispId(2049)]
  bool EnableAutoRecover
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2049)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2049)]
    [param: In]
    set;
  }

  [DispId(2050)]
  bool RemovePersonalInformation
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2050)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2050)]
    [param: In]
    set;
  }

  [DispId(1927)]
  string FullNameURLEncoded
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1927)]
    [LCIDConversion(0)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2051)]
  void CheckIn
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object SaveChanges,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Comments,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object MakePublic);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2053)]
  bool CanCheckIn();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2054)]
  void SendForReview
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Recipients,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Subject,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ShowMessage,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object IncludeAttachment);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2057)]
  void ReplyWithChanges([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ShowMessage);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2058)]
  void EndReview();

  [DispId(429)]
  string Password
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(429)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(429)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(1128)]
  string WritePassword
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1128)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1128)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(2059)]
  string PasswordEncryptionProvider
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2059)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
  }

  [DispId(2060)]
  string PasswordEncryptionAlgorithm
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2060)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
  }

  [DispId(2061)]
  int PasswordEncryptionKeyLength
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2061)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2062)]
  void SetPasswordEncryptionOptions
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object PasswordEncryptionProvider,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object PasswordEncryptionAlgorithm,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object PasswordEncryptionKeyLength,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object PasswordEncryptionFileProperties);

  [DispId(2063)]
  bool PasswordEncryptionFileProperties
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2063)]
    get;
  }

  [DispId(2005)]
  bool ReadOnlyRecommended
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2005)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2005)]
    [param: In]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2029)]
  void Protect
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Password,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Structure,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Windows);

  [DispId(2064)]
  SmartTagOptions SmartTagOptions
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FHidden)]
    [DispId(2064)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2065)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  void RecheckSmartTags();

  [DispId(2264)]
  Permission Permission
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2264)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(2265)]
  SharedWorkspace SharedWorkspace
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2265)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(2266)]
  Sync Sync
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2266)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2267)]
  void SendFaxOverInternet
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Recipients,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Subject,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ShowMessage);

  [DispId(2268)]
  XmlNamespaces XmlNamespaces
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2268)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(2269)]
  XmlMaps XmlMaps
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2269)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2270)]
  XlXmlImportResult XmlImport
  ([In] [MarshalAs(UnmanagedType.BStr)] string Url, [MarshalAs(UnmanagedType.Interface)] out XmlMap ImportMap,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Overwrite,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Destination);

  [DispId(2273)]
  SmartDocument SmartDocument
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2273)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(2274)]
  DocumentLibraryVersions DocumentLibraryVersions
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2274)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(2275)]
  bool InactiveListBorderVisible
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2275)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2275)]
    [param: In]
    set;
  }

  [DispId(2276)]
  bool DisplayInkComments
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2276)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2276)]
    [param: In]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2277)]
  XlXmlImportResult XmlImportXml
  ([In] [MarshalAs(UnmanagedType.BStr)] string Data, [MarshalAs(UnmanagedType.Interface)] out XmlMap ImportMap,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Overwrite,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Destination);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2278)]
  void SaveAsXMLData
    ([In] [MarshalAs(UnmanagedType.BStr)] string Filename, [In] [MarshalAs(UnmanagedType.Interface)] XmlMap Map);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2279)]
  void ToggleFormsDesign();

  [DispId(2512)]
  MetaProperties ContentTypeProperties
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2512)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(2513)]
  Connections Connections
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2513)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2514)]
  void RemoveDocumentInformation([In] XlRemoveDocInfoType RemoveDocInfoType);

  [DispId(2516)]
  SignatureSet Signatures
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2516)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2517)]
  void CheckInWithVersion
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object SaveChanges,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Comments,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object MakePublic,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object VersionType);

  [DispId(2519)]
  ServerPolicy ServerPolicy
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2519)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2520)]
  void LockServerFile();

  [DispId(2521)]
  DocumentInspectors DocumentInspectors
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2521)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2522)]
  [return: MarshalAs(UnmanagedType.Interface)]
  WorkflowTasks GetWorkflowTasks();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2523)]
  [return: MarshalAs(UnmanagedType.Interface)]
  WorkflowTemplates GetWorkflowTemplates();

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

  [DispId(2524)]
  ServerViewableItems ServerViewableItems
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2524)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(2525)]
  TableStyles TableStyles
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2525)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(2526)]
  object DefaultTableStyle
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2526)]
    [TypeLibFunc(TypeLibFuncFlags.FNonBrowsable)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2526)]
    [TypeLibFunc(TypeLibFuncFlags.FNonBrowsable)]
    [param: In]
    [param: MarshalAs(UnmanagedType.Struct)]
    set;
  }

  [DispId(2527)]
  object DefaultPivotTableStyle
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FNonBrowsable)]
    [DispId(2527)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2527)]
    [TypeLibFunc(TypeLibFuncFlags.FNonBrowsable)]
    [param: In]
    [param: MarshalAs(UnmanagedType.Struct)]
    set;
  }

  [DispId(2528)]
  bool CheckCompatibility
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2528)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2528)]
    [param: In]
    set;
  }

  [DispId(2529)]
  bool HasVBProject
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2529)]
    get;
  }

  [DispId(2530)]
  CustomXMLParts CustomXMLParts
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2530)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(2531)]
  bool Final
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2531)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2531)]
    [param: In]
    set;
  }

  [DispId(2532)]
  Research Research
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2532)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(2533)]
  OfficeTheme Theme
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2533)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2534)]
  void ApplyTheme([In] [MarshalAs(UnmanagedType.BStr)] string Filename);

  [DispId(2535)]
  bool Excel8CompatibilityMode
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2535)]
    get;
  }

  [DispId(2536)]
  bool ConnectionsDisabled
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2536)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2537)]
  void EnableConnections();

  [DispId(2538)]
  bool ShowPivotChartActiveFields
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2538)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2538)]
    [param: In]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
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

  [DispId(2539)]
  IconSets IconSets
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2539)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(2540)]
  string EncryptionProvider
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2540)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2540)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(2541)]
  bool DoNotPromptForConvert
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2541)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2541)]
    [param: In]
    set;
  }

  [DispId(2542)]
  bool ForceFullCalculation
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2542)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2542)]
    [param: In]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2543)]
  void ProtectSharingEx
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Filename,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Password,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object WriteResPassword,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ReadOnlyRecommended,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object CreateBackup,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object SharingPassword,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object FileFormat);

  [DispId(2866)]
  SlicerCaches SlicerCaches
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2866)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(2867)]
  Slicer ActiveSlicer
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2867)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(2868)]
  object DefaultSlicerStyle
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FNonBrowsable)]
    [DispId(2868)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FNonBrowsable)]
    [DispId(2868)]
    [param: In]
    [param: MarshalAs(UnmanagedType.Struct)]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2869)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  void Dummy26();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2870)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  void Dummy27();

  [DispId(2871)]
  int AccuracyVersion
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2871)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2871)]
    [param: In]
    set;
  }

  [DispId(3056)]
  bool CaseSensitive
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3056)]
    get;
  }

  [DispId(3057)]
  bool UseWholeCellCriteria
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3057)]
    get;
  }

  [DispId(3058)]
  bool UseWildcards
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3058)]
    get;
  }

  [DispId(690)]
  object PivotTables
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(690)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [DispId(3059)]
  Model Model
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3059)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
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

  [DispId(3060)]
  object DefaultTimelineStyle
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3060)]
    [TypeLibFunc(TypeLibFuncFlags.FNonBrowsable)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FNonBrowsable)]
    [DispId(3060)]
    [param: In]
    [param: MarshalAs(UnmanagedType.Struct)]
    set;
  }

  [DispId(3186)]
  Queries Queries
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3186)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(3167)]
  void CreateForecastSheet
  ([In] [MarshalAs(UnmanagedType.Interface)] Range Timeline, [In] [MarshalAs(UnmanagedType.Interface)] Range Values,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ForecastStart,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ForecastEnd,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ConfInt,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Seasonality,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object DataCompletion,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Aggregation,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ChartType,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ShowStatsTable);

  [DispId(3173)]
  string WorkIdentity
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3173)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3173)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [LCIDConversion(13)]
  [DispId(3174)]
  void SaveAs2
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Filename,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object FileFormat,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Password,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object WriteResPassword,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ReadOnlyRecommended,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object CreateBackup,
    [In] XlSaveAsAccessMode AccessMode = XlSaveAsAccessMode.xlNoChange,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ConflictResolution,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object AddToMru,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object TextCodepage,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object TextVisualLayout,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Local,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object WorkIdentity);

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
  [DispId(3334)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string PublishToDocs
  ([In] [MarshalAs(UnmanagedType.BStr)] string Title, [In] XlPublishToDocsDisclosureScope DisclosureScope,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object OverwriteUrl);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [DispId(3335)]
  [return: MarshalAs(UnmanagedType.Interface)]
  PublishedDocs LookUpInDocs([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Filename);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(3257)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string PublishToPBI
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object PublishType,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object nameConflict,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object bstrGroupName);

  [DispId(3232)]
  bool AutoSaveOn
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3232)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3232)]
    [param: In]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(3279)]
  void ConvertComments();

  [DispId(3379)]
  SensitivityLabel SensitivityLabel
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3379)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(3406)]
  int ExternalCodeServiceTimeout
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3406)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3406)]
    [param: In]
    set;
  }

  [DispId(3416)]
  int CompatibilityVersion
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3416)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3416)]
    [param: In]
    set;
  }
}