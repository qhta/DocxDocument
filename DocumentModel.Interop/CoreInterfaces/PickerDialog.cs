using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[ComImport]
[Guid("000C03E6-0000-0000-C000-000000000046")]
[TypeLibType(4288)]
public interface PickerDialog: _IMsoDispObj
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
  string DataHandlerId
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(2)]
  string Title
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(3)]
  PickerProperties Properties
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(4)]
  [return: MarshalAs(UnmanagedType.Interface)]
  PickerResults CreatePickerResults();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(5)]
  [return: MarshalAs(UnmanagedType.Interface)]
  PickerResults Show
    ([In] bool IsMultiSelect = true, [In] [MarshalAs(UnmanagedType.Interface)] PickerResults ExistingResults = null);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(6)]
  [return: MarshalAs(UnmanagedType.Interface)]
  PickerResults Resolve([In] [MarshalAs(UnmanagedType.BStr)] string TokenText, [In] int duplicateDlgMode);
}