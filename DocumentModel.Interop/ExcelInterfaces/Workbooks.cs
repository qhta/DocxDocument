using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Excel;

[ComImport]
[TypeLibType(TypeLibTypeFlags.FDual | TypeLibTypeFlags.FNonExtensible | TypeLibTypeFlags.FDispatchable)]
[Guid("000208DB-0000-0000-C000-000000000046")]
public interface Workbooks: IEnumerable
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
  [DispId(181)]
  [LCIDConversion(1)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Workbook Add([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Template);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(277)]
  [LCIDConversion(0)]
  void Close();

  [DispId(118)]
  int Count
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(118)]
    get;
  }

  [DispId(170)]
  Workbook Item
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(170)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(-4)]
  [TypeLibFunc(TypeLibFuncFlags.FNonBrowsable)]
  [return:
    MarshalAs(UnmanagedType.CustomMarshaler,
      MarshalType =
        "System.Runtime.InteropServices.CustomMarshalers.EnumeratorToEnumVariantMarshaler, CustomMarshalers, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  new IEnumerator GetEnumerator();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  [DispId(682)]
  [LCIDConversion(13)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Workbook _Open
  ([In] [MarshalAs(UnmanagedType.BStr)] string Filename,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object UpdateLinks,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ReadOnly,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Format,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Password,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object WriteResPassword,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object IgnoreReadOnlyRecommended,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Origin,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Delimiter,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Editable,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Notify,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Converter,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object AddToMru);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(683)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  [LCIDConversion(14)]
  void __OpenText
  ([In] [MarshalAs(UnmanagedType.BStr)] string Filename,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Origin,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object StartRow,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object DataType,
    [In] XlTextQualifier TextQualifier = XlTextQualifier.xlTextQualifierDoubleQuote,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ConsecutiveDelimiter,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Tab,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Semicolon,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Comma,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Space,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Other,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object OtherChar,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object FieldInfo,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object TextVisualLayout);

  [IndexerName("_Default")]
  [DispId(0)]
  Workbook this[[In] [MarshalAs(UnmanagedType.Struct)] object Index]
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(0)]
    [TypeLibFunc(TypeLibFuncFlags.FNonBrowsable)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1773)]
  [LCIDConversion(16)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  void _OpenText
  ([In] [MarshalAs(UnmanagedType.BStr)] string Filename,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Origin,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object StartRow,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object DataType,
    [In] XlTextQualifier TextQualifier = XlTextQualifier.xlTextQualifierDoubleQuote,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ConsecutiveDelimiter,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Tab,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Semicolon,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Comma,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Space,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Other,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object OtherChar,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object FieldInfo,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object TextVisualLayout,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object DecimalSeparator,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ThousandsSeparator);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1923)]
  [LCIDConversion(15)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Workbook Open
  ([In] [MarshalAs(UnmanagedType.BStr)] string Filename,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object UpdateLinks,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ReadOnly,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Format,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Password,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object WriteResPassword,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object IgnoreReadOnlyRecommended,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Origin,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Delimiter,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Editable,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Notify,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Converter,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object AddToMru,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Local,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object CorruptLoad);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1924)]
  [LCIDConversion(18)]
  void OpenText
  ([In] [MarshalAs(UnmanagedType.BStr)] string Filename,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Origin,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object StartRow,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object DataType,
    [In] XlTextQualifier TextQualifier = XlTextQualifier.xlTextQualifierDoubleQuote,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ConsecutiveDelimiter,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Tab,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Semicolon,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Comma,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Space,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Other,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object OtherChar,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object FieldInfo,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object TextVisualLayout,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object DecimalSeparator,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ThousandsSeparator,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object TrailingMinusNumbers,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Local);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2067)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Workbook OpenDatabase
  ([In] [MarshalAs(UnmanagedType.BStr)] string Filename,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object CommandText,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object CommandType,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object BackgroundQuery,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ImportDataAs);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2069)]
  void CheckOut([In] [MarshalAs(UnmanagedType.BStr)] string Filename);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2070)]
  bool CanCheckOut([In] [MarshalAs(UnmanagedType.BStr)] string Filename);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2071)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Workbook _OpenXML
  ([In] [MarshalAs(UnmanagedType.BStr)] string Filename,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Stylesheets);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2280)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Workbook OpenXML
  ([In] [MarshalAs(UnmanagedType.BStr)] string Filename,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Stylesheets,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object LoadOption);
}