using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[ComImport]
[DefaultMember("Item")]
[Guid("000C031E-0000-0000-C000-000000000046")]
[TypeLibType(4304)]
public interface Shapes: _IMsoDispObj, IEnumerable
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

  [DispId(1)]
  object Parent
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [DispId(2)]
  int Count
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(0)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Shape Item([In] [MarshalAs(UnmanagedType.Struct)] object Index);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(1024)]
  [DispId(-4)]
  [return:
    MarshalAs(UnmanagedType.CustomMarshaler,
      MarshalType =
        "System.Runtime.InteropServices.CustomMarshalers.EnumeratorToEnumVariantMarshaler, CustomMarshalers, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  new IEnumerator GetEnumerator();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(10)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Shape AddCallout([In] MsoCalloutType Type, [In] float Left, [In] float Top, [In] float Width, [In] float Height);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(11)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Shape AddConnector
    ([In] MsoConnectorType Type, [In] float BeginX, [In] float BeginY, [In] float EndX, [In] float EndY);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(12)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Shape AddCurve([In] [MarshalAs(UnmanagedType.Struct)] object SafeArrayOfPoints);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(13)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Shape AddLabel
    ([In] MsoTextOrientation Orientation, [In] float Left, [In] float Top, [In] float Width, [In] float Height);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(14)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Shape AddLine([In] float BeginX, [In] float BeginY, [In] float EndX, [In] float EndY);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(15)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Shape AddPicture
  ([In] [MarshalAs(UnmanagedType.BStr)] string FileName, [In] MsoTriState LinkToFile, [In] MsoTriState SaveWithDocument,
    [In] float Left, [In] float Top, [In] float Width = -1f, [In] float Height = -1f);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(16)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Shape AddPolyline([In] [MarshalAs(UnmanagedType.Struct)] object SafeArrayOfPoints);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(17)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Shape AddShape([In] MsoAutoShapeType Type, [In] float Left, [In] float Top, [In] float Width, [In] float Height);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(18)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Shape AddTextEffect
  ([In] MsoPresetTextEffect PresetTextEffect, [In] [MarshalAs(UnmanagedType.BStr)] string Text,
    [In] [MarshalAs(UnmanagedType.BStr)] string FontName, [In] float FontSize, [In] MsoTriState FontBold,
    [In] MsoTriState FontItalic, [In] float Left, [In] float Top);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(19)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Shape AddTextbox
    ([In] MsoTextOrientation Orientation, [In] float Left, [In] float Top, [In] float Width, [In] float Height);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(20)]
  [return: MarshalAs(UnmanagedType.Interface)]
  FreeformBuilder BuildFreeform([In] MsoEditingType EditingType, [In] float X1, [In] float Y1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(21)]
  [return: MarshalAs(UnmanagedType.Interface)]
  ShapeRange Range([In] [MarshalAs(UnmanagedType.Struct)] object Index);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(22)]
  void SelectAll();

  [DispId(100)]
  Shape Background
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(100)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(101)]
  Shape Default
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(101)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(23)]
  [TypeLibFunc(64)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Shape AddDiagram([In] MsoDiagramType Type, [In] float Left, [In] float Top, [In] float Width, [In] float Height);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(64)]
  [DispId(25)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Shape AddCanvas([In] float Left, [In] float Top, [In] float Width, [In] float Height);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(26)]
  [TypeLibFunc(64)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Shape AddChart
  ([In] XlChartType Type = (XlChartType)(-1), [In] float Left = -1f, [In] float Top = -1f, [In] float Width = -1f,
    [In] float Height = -1f);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(27)]
  [TypeLibFunc(64)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Shape AddTable
    ([In] int NumRows, [In] int NumColumns, [In] float Left, [In] float Top, [In] float Width, [In] float Height);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(28)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Shape AddSmartArt
  ([In] [MarshalAs(UnmanagedType.Interface)] SmartArtLayout Layout, [In] float Left = -1f, [In] float Top = -1f,
    [In] float Width = -1f, [In] float Height = -1f);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(29)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Shape AddChart2
  ([In] int Style = -1, [In] XlChartType Type = (XlChartType)(-1), [In] float Left = -1f, [In] float Top = -1f,
    [In] float Width = -1f, [In] float Height = -1f, [In] bool NewLayout = true);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(30)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Shape AddPicture2
  ([In] [MarshalAs(UnmanagedType.BStr)] string FileName, [In] MsoTriState LinkToFile, [In] MsoTriState SaveWithDocument,
    [In] float Left, [In] float Top, [In] float Width = -1f, [In] float Height = -1f,
    [In] MsoPictureCompress Compress = MsoPictureCompress.msoPictureCompressDocDefault);
}