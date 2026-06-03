using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Excel;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
[Guid("0002085E-0000-0000-C000-000000000046")]
[TypeLibType(TypeLibTypeFlags.FHidden | TypeLibTypeFlags.FDispatchable)]
public interface ToolbarButton
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

  [DispId(553)]
  bool BuiltIn
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(553)]
    get;
  }

  [DispId(554)]
  bool BuiltInFace
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(554)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(554)]
    [param: In]
    set;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(551)]
  void Copy([In] [MarshalAs(UnmanagedType.Interface)] Toolbar Toolbar, [In] int Before);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(966)]
  void CopyFace();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(117)]
  void Delete();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(562)]
  void Edit();

  [DispId(600)]
  bool Enabled
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(600)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(600)]
    [param: In]
    set;
  }

  [DispId(355)]
  int HelpContextID
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(355)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(355)]
    [param: In]
    set;
  }

  [DispId(360)]
  string HelpFile
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(360)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(360)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(570)]
  int ID
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(570)]
    get;
  }

  [DispId(561)]
  bool IsGap
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(561)]
    get;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(637)]
  void Move([In] [MarshalAs(UnmanagedType.Interface)] Toolbar Toolbar, [In] int Before);

  [DispId(110)]
  string Name
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(110)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(110)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(596)]
  string OnAction
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(596)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(596)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(967)]
  void PasteFace();

  [DispId(560)]
  bool Pushed
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(560)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(560)]
    [param: In]
    set;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(555)]
  void Reset();

  [DispId(386)]
  string StatusBar
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(386)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(386)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(122)]
  int Width
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(122)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(122)]
    [param: In]
    set;
  }
}