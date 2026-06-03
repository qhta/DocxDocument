using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Excel;

[ComImport]
[Guid("000208B1-0000-0000-C000-000000000046")]
[TypeLibType(TypeLibTypeFlags.FDispatchable)]
[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
public interface Worksheets: IEnumerable
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
  [DispId(181)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object Add
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Before,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object After,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Count,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Type);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(551)]
  void Copy
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Before,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object After);

  [DispId(118)]
  int Count
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(118)]
    get;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(117)]
  void Delete();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(469)]
  void FillAcrossSheets
    ([In] [MarshalAs(UnmanagedType.Interface)] Range Range, [In] XlFillWith Type = XlFillWith.xlFillWithAll);

  [DispId(170)]
  object Item
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(170)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(637)]
  void Move
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Before,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object After);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FNonBrowsable)]
  [DispId(-4)]
  [return:
    MarshalAs(UnmanagedType.CustomMarshaler,
      MarshalType =
        "System.Runtime.InteropServices.CustomMarshalers.EnumeratorToEnumVariantMarshaler, CustomMarshalers, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  new IEnumerator GetEnumerator();

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
  [DispId(235)]
  void Select([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Replace);

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

  [DispId(558)]
  object Visible
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(558)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(558)]
    [param: In]
    [param: MarshalAs(UnmanagedType.Struct)]
    set;
  }

  [IndexerName("_Default")]
  [DispId(0)]
  object this[[In] [MarshalAs(UnmanagedType.Struct)] object Index]
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(TypeLibFuncFlags.FNonBrowsable)]
    [DispId(0)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
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
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object PrToFileName,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object IgnorePrintAreas);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(3054)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object Add2
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Before,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object After,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Count,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object NewLayout);
}