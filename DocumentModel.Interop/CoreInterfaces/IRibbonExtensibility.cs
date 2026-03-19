using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[ComImport]
[Guid("000C0396-0000-0000-C000-000000000046")]
[TypeLibType(4160)]
public interface IRibbonExtensibility
{
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetCustomUI([In] [MarshalAs(UnmanagedType.BStr)] string RibbonID);
}