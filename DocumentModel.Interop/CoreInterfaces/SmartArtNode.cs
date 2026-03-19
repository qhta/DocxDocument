using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[ComImport]
[Guid("000C03C8-0000-0000-C000-000000000046")]
[TypeLibType(4288)]
public interface SmartArtNode: _IMsoDispObj
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

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2)]
  [return: MarshalAs(UnmanagedType.Interface)]
  SmartArtNode AddNode
  ([In] MsoSmartArtNodePosition Position = MsoSmartArtNodePosition.msoSmartArtNodeDefault,
    [In] MsoSmartArtNodeType Type = MsoSmartArtNodeType.msoSmartArtNodeTypeDefault);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(3)]
  void Delete();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(4)]
  void Promote();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(5)]
  void Demote();

  [DispId(6)]
  MsoOrgChartLayoutType OrgChartLayout
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(6)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(6)]
    [param: In]
    set;
  }

  [DispId(7)]
  ShapeRange Shapes
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(7)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(8)]
  TextFrame2 TextFrame2
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(8)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(9)]
  void Larger();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(10)]
  void Smaller();

  [DispId(11)]
  int Level
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(11)]
    get;
  }

  [DispId(12)]
  MsoTriState Hidden
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(12)]
    get;
  }

  [DispId(13)]
  SmartArtNodes Nodes
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(13)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(14)]
  SmartArtNode ParentNode
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(14)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(15)]
  MsoSmartArtNodeType Type
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(15)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(16)]
  void ReorderUp();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(17)]
  void ReorderDown();
}