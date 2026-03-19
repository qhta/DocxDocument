using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[ComImport]
[TypeLibType(4176)]
[Guid("618736E0-3C3D-11CF-810C-00AA00389B71")]
public interface IAccessible
{
  [DispId(-5000)]
  object accParent
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(-5000)]
    [TypeLibFunc(1088)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [DispId(-5001)]
  int accChildCount
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(1088)]
    [DispId(-5001)]
    get;
  }

  [DispId(-5002)]
  object accChild
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(1088)]
    [DispId(-5002)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [DispId(-5003)]
  string accName
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(-5003)]
    [TypeLibFunc(1088)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(-5003)]
    [TypeLibFunc(1088)]
    [param: Optional]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(-5004)]
  string accValue
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(1088)]
    [DispId(-5004)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(1088)]
    [DispId(-5004)]
    [param: Optional]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(-5005)]
  string accDescription
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(-5005)]
    [TypeLibFunc(1088)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
  }

  [DispId(-5006)]
  object accRole
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(-5006)]
    [TypeLibFunc(1088)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
  }

  [DispId(-5007)]
  object accState
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(1088)]
    [DispId(-5007)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
  }

  [DispId(-5008)]
  string accHelp
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(1088)]
    [DispId(-5008)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
  }

  [DispId(-5009)]
  int accHelpTopic
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(-5009)]
    [TypeLibFunc(1088)]
    get;
  }

  [DispId(-5010)]
  string accKeyboardShortcut
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(1088)]
    [DispId(-5010)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
  }

  [DispId(-5011)]
  object accFocus
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(1088)]
    [DispId(-5011)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
  }

  [DispId(-5012)]
  object accSelection
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(-5012)]
    [TypeLibFunc(1088)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
  }

  [DispId(-5013)]
  string accDefaultAction
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(1088)]
    [DispId(-5013)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(-5014)]
  [TypeLibFunc(1088)]
  void accSelect([In] int flagsSelect, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object varChild);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(-5015)]
  [TypeLibFunc(1088)]
  void accLocation
  (out int pxLeft, out int pyTop, out int pcxWidth, out int pcyHeight,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object varChild);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(-5016)]
  [TypeLibFunc(1088)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object accNavigate([In] int navDir, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object varStart);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(-5017)]
  [TypeLibFunc(1088)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object accHitTest([In] int xLeft, [In] int yTop);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(-5018)]
  [TypeLibFunc(1088)]
  void accDoDefaultAction([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object varChild);
}