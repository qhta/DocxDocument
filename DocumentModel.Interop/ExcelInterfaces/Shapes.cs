using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

using Microsoft.Office.Core;

namespace DocumentModel.Interop.Excel;

[ComImport]
[TypeLibType(TypeLibTypeFlags.FDispatchable)]
[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
[DefaultMember("_Default")]
[Guid("0002443A-0000-0000-C000-000000000046")]
public interface Shapes: IEnumerable
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

  [DispId(118)]
  int Count
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(118)]
    get;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(170)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Shape Item([In] [MarshalAs(UnmanagedType.Struct)] object Index);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FNonBrowsable)]
  [DispId(0)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Shape _Default([In] [MarshalAs(UnmanagedType.Struct)] object Index);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(-4)]
  [TypeLibFunc(TypeLibFuncFlags.FNonBrowsable)]
  [return:
    MarshalAs(UnmanagedType.CustomMarshaler,
      MarshalType =
        "System.Runtime.InteropServices.CustomMarshalers.EnumeratorToEnumVariantMarshaler, CustomMarshalers, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  new IEnumerator GetEnumerator();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1713)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Shape AddCallout([In] MsoCalloutType Type, [In] float Left, [In] float Top, [In] float Width, [In] float Height);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1714)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Shape AddConnector
    ([In] MsoConnectorType Type, [In] float BeginX, [In] float BeginY, [In] float EndX, [In] float EndY);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1719)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Shape AddCurve([In] [MarshalAs(UnmanagedType.Struct)] object SafeArrayOfPoints);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1721)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Shape AddLabel
    ([In] MsoTextOrientation Orientation, [In] float Left, [In] float Top, [In] float Width, [In] float Height);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1722)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Shape AddLine([In] float BeginX, [In] float BeginY, [In] float EndX, [In] float EndY);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1723)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Shape AddPicture
  ([In] [MarshalAs(UnmanagedType.BStr)] string Filename, [In] MsoTriState LinkToFile, [In] MsoTriState SaveWithDocument,
    [In] float Left, [In] float Top, [In] float Width, [In] float Height);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1726)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Shape AddPolyline([In] [MarshalAs(UnmanagedType.Struct)] object SafeArrayOfPoints);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1727)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Shape AddShape([In] MsoAutoShapeType Type, [In] float Left, [In] float Top, [In] float Width, [In] float Height);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1728)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Shape AddTextEffect
  ([In] MsoPresetTextEffect PresetTextEffect, [In] [MarshalAs(UnmanagedType.BStr)] string Text,
    [In] [MarshalAs(UnmanagedType.BStr)] string FontName, [In] float FontSize, [In] MsoTriState FontBold,
    [In] MsoTriState FontItalic, [In] float Left, [In] float Top);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1734)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Shape AddTextbox
    ([In] MsoTextOrientation Orientation, [In] float Left, [In] float Top, [In] float Width, [In] float Height);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1735)]
  [return: MarshalAs(UnmanagedType.Interface)]
  FreeformBuilder BuildFreeform([In] MsoEditingType EditingType, [In] float X1, [In] float Y1);

  [DispId(197)]
  ShapeRange Range
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(197)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1737)]
  void SelectAll();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1738)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Shape AddFormControl([In] XlFormControl Type, [In] int Left, [In] int Top, [In] int Width, [In] int Height);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1739)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Shape AddOLEObject
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object ClassType,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Filename,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Link,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object DisplayAsIcon,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object IconFileName,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object IconIndex,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object IconLabel,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Left,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Top,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Width,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Height);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [DispId(2176)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Shape AddDiagram([In] MsoDiagramType Type, [In] float Left, [In] float Top, [In] float Width, [In] float Height);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2177)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Shape AddCanvas([In] float Left, [In] float Top, [In] float Width, [In] float Height);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2665)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Shape AddChart
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object XlChartType,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Left,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Top,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Width,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Height);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2920)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Shape AddSmartArt
  ([In] [MarshalAs(UnmanagedType.Interface)] SmartArtLayout Layout,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Left,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Top,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Width,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Height);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(3088)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Shape AddChart2
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Style,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object XlChartType,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Left,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Top,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Width,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Height,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object NewLayout);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(3159)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Shape AddPicture2
  ([In] [MarshalAs(UnmanagedType.BStr)] string Filename, [In] MsoTriState LinkToFile, [In] MsoTriState SaveWithDocument,
    [In] float Left, [In] float Top, [In] float Width, [In] float Height, [In] MsoPictureCompress Compress);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(3359)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Shape Add3DModel
  ([In] [MarshalAs(UnmanagedType.BStr)] string Filename,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object LinkToFile,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object SaveWithDocument,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Left,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Top,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Width,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Height);
}