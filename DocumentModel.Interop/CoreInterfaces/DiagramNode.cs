using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[ComImport]
[Guid("000C0370-0000-0000-C000-000000000046")]
[TypeLibType(4304)]
public interface DiagramNode: _IMsoDispObj
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

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(10)]
  [return: MarshalAs(UnmanagedType.Interface)]
  DiagramNode AddNode
  ([In] MsoRelativeNodePosition Pos = MsoRelativeNodePosition.msoAfterNode,
    [In] MsoDiagramNodeType NodeType = MsoDiagramNodeType.msoDiagramNode);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(11)]
  void Delete();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(12)]
  void MoveNode([In] [MarshalAs(UnmanagedType.Interface)] DiagramNode TargetNode, [In] MsoRelativeNodePosition Pos);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(13)]
  void ReplaceNode([In] [MarshalAs(UnmanagedType.Interface)] DiagramNode TargetNode);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(14)]
  void SwapNode([In] [MarshalAs(UnmanagedType.Interface)] DiagramNode TargetNode, [In] bool SwapChildren = true);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(15)]
  [return: MarshalAs(UnmanagedType.Interface)]
  DiagramNode CloneNode
  ([In] bool CopyChildren, [In] [MarshalAs(UnmanagedType.Interface)] DiagramNode TargetNode,
    [In] MsoRelativeNodePosition Pos = MsoRelativeNodePosition.msoAfterNode);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(16)]
  void TransferChildren([In] [MarshalAs(UnmanagedType.Interface)] DiagramNode ReceivingNode);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(17)]
  [return: MarshalAs(UnmanagedType.Interface)]
  DiagramNode NextNode();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(18)]
  [return: MarshalAs(UnmanagedType.Interface)]
  DiagramNode PrevNode();

  [DispId(100)]
  object Parent
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(100)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [DispId(101)]
  DiagramNodeChildren Children
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(101)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(102)]
  Shape Shape
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(102)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(103)]
  DiagramNode Root
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(103)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(104)]
  IMsoDiagram Diagram
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(104)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(105)]
  MsoOrgChartLayoutType Layout
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(105)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(105)]
    [param: In]
    set;
  }

  [DispId(106)]
  Shape TextShape
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(106)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }
}