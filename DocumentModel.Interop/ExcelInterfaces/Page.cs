using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Excel;

[ComImport]
[Guid("000244A2-0000-0000-C000-000000000046")]
[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
[TypeLibType(TypeLibTypeFlags.FDispatchable)]
public interface Page
{
  [DispId(1018)]
  HeaderFooter LeftHeader
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1018)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1011)]
  HeaderFooter CenterHeader
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1011)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1026)]
  HeaderFooter RightHeader
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1026)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1017)]
  HeaderFooter LeftFooter
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1017)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1010)]
  HeaderFooter CenterFooter
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1010)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1025)]
  HeaderFooter RightFooter
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1025)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }
}