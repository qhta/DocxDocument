using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Excel;

[ComImport]
[TypeLibType(TypeLibTypeFlags.FDispatchable)]
[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
[Guid("000244A1-0000-0000-C000-000000000046")]
public interface HeaderFooter
{
  [DispId(138)]
  string Text
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(138)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(138)]
    [param: In]
    [param: MarshalAs(UnmanagedType.BStr)]
    set;
  }

  [DispId(479)]
  Graphic Picture
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(479)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }
}