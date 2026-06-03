using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

using Microsoft.Office.Core;

namespace DocumentModel.Interop.Excel;

[ComImport]
[TypeLibType(TypeLibTypeFlags.FHidden | TypeLibTypeFlags.FDispatchable)]
[Guid("0002443F-0001-0000-C000-000000000046")]
public interface IFreeformBuilder
{
  [DispId(148)]
  Application Application
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(149)]
  XlCreator Creator
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    get;
  }

  [DispId(150)]
  object Parent
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void AddNodes
  ([In] MsoSegmentType SegmentType, [In] MsoEditingType EditingType, [In] float X1, [In] float Y1,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object X2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Y2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object X3,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Y3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Shape ConvertToShape();
}