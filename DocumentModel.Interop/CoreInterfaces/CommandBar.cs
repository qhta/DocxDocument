using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[ComImport]
[TypeLibType(4288)]
[Guid("000C0304-0000-0000-C000-000000000046")]
public interface CommandBar: _IMsoOleAccDispObj
{
  [DispId(-5000)]
  new object accParent
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(1088)]
    [DispId(-5000)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [DispId(-5001)]
  new int accChildCount
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(1088)]
    [DispId(-5001)]
    get;
  }

  [DispId(-5002)]
  new object accChild
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(1088)]
    [DispId(-5002)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [DispId(-5003)]
  new string accName
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(1088)]
    [DispId(-5003)]
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
  new string accValue
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(-5004)]
    [TypeLibFunc(1088)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(-5004)]
    [TypeLibFunc(1088)]
    [param: Optional]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(-5005)]
  new string accDescription
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(-5005)]
    [TypeLibFunc(1088)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
  }

  [DispId(-5006)]
  new object accRole
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(-5006)]
    [TypeLibFunc(1088)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
  }

  [DispId(-5007)]
  new object accState
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(1088)]
    [DispId(-5007)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
  }

  [DispId(-5008)]
  new string accHelp
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(1088)]
    [DispId(-5008)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
  }

  [DispId(-5009)]
  new int accHelpTopic
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(1088)]
    [DispId(-5009)]
    get;
  }

  [DispId(-5010)]
  new string accKeyboardShortcut
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(-5010)]
    [TypeLibFunc(1088)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
  }

  [DispId(-5011)]
  new object accFocus
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(-5011)]
    [TypeLibFunc(1088)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
  }

  [DispId(-5012)]
  new object accSelection
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(-5012)]
    [TypeLibFunc(1088)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
  }

  [DispId(-5013)]
  new string accDefaultAction
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(1088)]
    [DispId(-5013)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(1088)]
  [DispId(-5014)]
  new void accSelect([In] int flagsSelect, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object varChild);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(1088)]
  [DispId(-5015)]
  new void accLocation
  (out int pxLeft, out int pyTop, out int pcxWidth, out int pcyHeight,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object varChild);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(-5016)]
  [TypeLibFunc(1088)]
  [return: MarshalAs(UnmanagedType.Struct)]
  new object accNavigate([In] int navDir, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object varStart);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(1088)]
  [DispId(-5017)]
  [return: MarshalAs(UnmanagedType.Struct)]
  new object accHitTest([In] int xLeft, [In] int yTop);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(1088)]
  [DispId(-5018)]
  new void accDoDefaultAction([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object varChild);

  [DispId(1610809344)]
  new object Application
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809344)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [DispId(1610809345)]
  new int Creator
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809345)]
    get;
  }

  [DispId(1610874880)]
  bool BuiltIn
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610874880)]
    get;
  }

  [DispId(1610874881)]
  string Context
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610874881)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610874881)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(1610874883)]
  CommandBarControls Controls
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610874883)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610874884)]
  void Delete();

  [DispId(1610874885)]
  bool Enabled
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610874885)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610874885)]
    [param: In]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610874887)]
  [return: MarshalAs(UnmanagedType.Interface)]
  CommandBarControl FindControl
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Type,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Id,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Tag,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Visible,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Recursive);

  [DispId(1610874888)]
  int Height
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610874888)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610874888)]
    [param: In]
    set;
  }

  [DispId(1610874890)]
  int Index
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610874890)]
    get;
  }

  [DispId(1610874891)]
  int InstanceId
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610874891)]
    [TypeLibFunc(64)]
    get;
  }

  [DispId(1610874892)]
  int Left
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610874892)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610874892)]
    [param: In]
    set;
  }

  [DispId(1610874894)]
  string Name
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610874894)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610874894)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(1610874896)]
  string NameLocal
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610874896)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610874896)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(1610874898)]
  object Parent
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610874898)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [DispId(1610874899)]
  MsoBarPosition Position
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610874899)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610874899)]
    [param: In]
    set;
  }

  [DispId(1610874901)]
  int RowIndex
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610874901)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610874901)]
    [param: In]
    set;
  }

  [DispId(1610874903)]
  MsoBarProtection Protection
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610874903)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610874903)]
    [param: In]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610874905)]
  void Reset();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610874906)]
  void ShowPopup
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object x,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object y);

  [DispId(1610874907)]
  int Top
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610874907)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610874907)]
    [param: In]
    set;
  }

  [DispId(1610874909)]
  MsoBarType Type
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610874909)]
    get;
  }

  [DispId(1610874910)]
  bool Visible
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610874910)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610874910)]
    [param: In]
    set;
  }

  [DispId(1610874912)]
  int Width
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610874912)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610874912)]
    [param: In]
    set;
  }

  [DispId(1610874914)]
  bool AdaptiveMenu
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610874914)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610874914)]
    [param: In]
    set;
  }

  [DispId(1610874916)]
  int Id
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(64)]
    [DispId(1610874916)]
    get;
  }

  [DispId(1610874917)]
  object InstanceIdPtr
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610874917)]
    [TypeLibFunc(64)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
  }
}