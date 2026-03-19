using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

using stdole;

namespace DocumentModel.Interop.Core;

[ComImport]
[Guid("000C0302-0000-0000-C000-000000000046")]
[TypeLibType(4288)]
public interface _CommandBars: _IMsoDispObj, IEnumerable
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

  [DispId(1610809344)]
  CommandBarControl ActionControl
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809344)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1610809345)]
  CommandBar ActiveMenuBar
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809345)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610809346)]
  [return: MarshalAs(UnmanagedType.Interface)]
  CommandBar Add
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Name,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Position,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object MenuBar,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Temporary);

  [DispId(1610809347)]
  int Count
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809347)]
    get;
  }

  [DispId(1610809348)]
  bool DisplayTooltips
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809348)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809348)]
    [param: In]
    set;
  }

  [DispId(1610809350)]
  bool DisplayKeysInTooltips
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809350)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809350)]
    [param: In]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610809352)]
  [return: MarshalAs(UnmanagedType.Interface)]
  CommandBarControl FindControl
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Type,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Id,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Tag,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Visible);

  [DispId(0)]
  CommandBar this[[In] [MarshalAs(UnmanagedType.Struct)] object Index]
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(0)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1610809354)]
  bool LargeButtons
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809354)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809354)]
    [param: In]
    set;
  }

  [DispId(1610809356)]
  MsoMenuAnimation MenuAnimationStyle
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809356)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809356)]
    [param: In]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(1024)]
  [DispId(-4)]
  [return:
    MarshalAs(UnmanagedType.CustomMarshaler,
      MarshalType =
        "System.Runtime.InteropServices.CustomMarshalers.EnumeratorToEnumVariantMarshaler, CustomMarshalers, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  new IEnumerator GetEnumerator();

  [DispId(1610809359)]
  object Parent
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809359)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610809360)]
  void ReleaseFocus();

  [DispId(1610809361)]
  int IdsString
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809361)]
    [TypeLibFunc(64)]
    get;
  }

  [DispId(1610809362)]
  int TmcGetName
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [TypeLibFunc(64)]
    [DispId(1610809362)]
    get;
  }

  [DispId(1610809363)]
  bool AdaptiveMenus
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809363)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809363)]
    [param: In]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610809365)]
  [return: MarshalAs(UnmanagedType.Interface)]
  CommandBarControls FindControls
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Type,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Id,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Tag,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Visible);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610809366)]
  [TypeLibFunc(64)]
  [return: MarshalAs(UnmanagedType.Interface)]
  CommandBar AddEx
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object TbidOrName,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Position,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object MenuBar,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Temporary,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object TbtrProtection);

  [DispId(1610809367)]
  bool DisplayFonts
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809367)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809367)]
    [param: In]
    set;
  }

  [DispId(1610809369)]
  bool DisableCustomize
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809369)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809369)]
    [param: In]
    set;
  }

  [DispId(1610809371)]
  bool DisableAskAQuestionDropdown
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809371)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610809371)]
    [param: In]
    set;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610809373)]
  void ExecuteMso([In] [MarshalAs(UnmanagedType.BStr)] string idMso);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610809374)]
  bool GetEnabledMso([In] [MarshalAs(UnmanagedType.BStr)] string idMso);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610809375)]
  bool GetVisibleMso([In] [MarshalAs(UnmanagedType.BStr)] string idMso);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610809376)]
  bool GetPressedMso([In] [MarshalAs(UnmanagedType.BStr)] string idMso);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610809377)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetLabelMso([In] [MarshalAs(UnmanagedType.BStr)] string idMso);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610809378)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetScreentipMso([In] [MarshalAs(UnmanagedType.BStr)] string idMso);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610809379)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetSupertipMso([In] [MarshalAs(UnmanagedType.BStr)] string idMso);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610809380)]
  [return: MarshalAs(UnmanagedType.Interface)]
  [return: ComAliasName("stdole.IPictureDisp")]
  IPictureDisp GetImageMso([In] [MarshalAs(UnmanagedType.BStr)] string idMso, [In] int Width, [In] int Height);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610809381)]
  void CommitRenderingTransaction([In] int hwnd);
}