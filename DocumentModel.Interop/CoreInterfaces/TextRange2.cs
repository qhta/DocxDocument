using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[ComImport]
[Guid("000C0397-0000-0000-C000-000000000046")]
[DefaultMember("Text")]
[TypeLibType(4288)]
public interface TextRange2: _IMsoDispObj, IEnumerable
{
  [DispId(1610743808)]
  new object Application
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743808)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [DispId(1610743809)]
  new int Creator
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743809)]
    get;
  }

  [DispId(0)]
  string Text
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(0)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(0)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(1)]
  int Count
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2)]
  [return: MarshalAs(UnmanagedType.Interface)]
  TextRange2 Item([In] [MarshalAs(UnmanagedType.Struct)] object Index);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(1024)]
  [DispId(-4)]
  [return:
    MarshalAs(UnmanagedType.CustomMarshaler,
      MarshalType =
        "System.Runtime.InteropServices.CustomMarshalers.EnumeratorToEnumVariantMarshaler, CustomMarshalers, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  new IEnumerator GetEnumerator();

  [DispId(3)]
  object Parent
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [DispId(4)]
  TextRange2 Paragraphs
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(4)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(5)]
  TextRange2 Sentences
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(5)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(6)]
  TextRange2 Words
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(6)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(7)]
  TextRange2 Characters
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(7)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(8)]
  TextRange2 Lines
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(8)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(9)]
  TextRange2 Runs
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(9)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(10)]
  ParagraphFormat2 ParagraphFormat
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(10)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(11)]
  Font2 Font
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(11)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(12)]
  int Length
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(12)]
    get;
  }

  [DispId(13)]
  int Start
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(13)]
    get;
  }

  [DispId(14)]
  float BoundLeft
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(14)]
    get;
  }

  [DispId(15)]
  float BoundTop
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(15)]
    get;
  }

  [DispId(16)]
  float BoundWidth
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(16)]
    get;
  }

  [DispId(17)]
  float BoundHeight
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(17)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(18)]
  [return: MarshalAs(UnmanagedType.Interface)]
  TextRange2 TrimText();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(19)]
  [return: MarshalAs(UnmanagedType.Interface)]
  TextRange2 InsertAfter([In] [MarshalAs(UnmanagedType.BStr)] string NewText = "");

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(20)]
  [return: MarshalAs(UnmanagedType.Interface)]
  TextRange2 InsertBefore([In] [MarshalAs(UnmanagedType.BStr)] string NewText = "");

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(21)]
  [return: MarshalAs(UnmanagedType.Interface)]
  TextRange2 InsertSymbol
  ([In] [MarshalAs(UnmanagedType.BStr)] string FontName, [In] int CharNumber,
    [In] MsoTriState Unicode = MsoTriState.msoFalse);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(22)]
  void Select();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(23)]
  void Cut();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(24)]
  void Copy();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(25)]
  void Delete();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(26)]
  [return: MarshalAs(UnmanagedType.Interface)]
  TextRange2 Paste();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(27)]
  [return: MarshalAs(UnmanagedType.Interface)]
  TextRange2 PasteSpecial([In] MsoClipboardFormat Format);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(28)]
  void ChangeCase([In] MsoTextChangeCase Type);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(29)]
  void AddPeriods();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(30)]
  void RemovePeriods();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(31)]
  [return: MarshalAs(UnmanagedType.Interface)]
  TextRange2 Find
  ([In] [MarshalAs(UnmanagedType.BStr)] string FindWhat, [In] int After = 0,
    [In] MsoTriState MatchCase = MsoTriState.msoFalse, [In] MsoTriState WholeWords = MsoTriState.msoFalse);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(32)]
  [return: MarshalAs(UnmanagedType.Interface)]
  TextRange2 Replace
  ([In] [MarshalAs(UnmanagedType.BStr)] string FindWhat, [In] [MarshalAs(UnmanagedType.BStr)] string ReplaceWhat,
    [In] int After = 0, [In] MsoTriState MatchCase = MsoTriState.msoFalse,
    [In] MsoTriState WholeWords = MsoTriState.msoFalse);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(33)]
  void RotatedBounds
    (out float X1, out float Y1, out float X2, out float Y2, out float X3, out float Y3, out float x4, out float y4);

  [DispId(34)]
  MsoLanguageID LanguageID
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(34)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(34)]
    [param: In]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(35)]
  void RtlRun();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(36)]
  void LtrRun();

  [DispId(37)]
  TextRange2 MathZones
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(37)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(38)]
  [return: MarshalAs(UnmanagedType.Interface)]
  TextRange2 InsertChartField
  ([In] MsoChartFieldType ChartFieldType, [In] [MarshalAs(UnmanagedType.BStr)] string Formula = "",
    [In] int Position = -1);
}