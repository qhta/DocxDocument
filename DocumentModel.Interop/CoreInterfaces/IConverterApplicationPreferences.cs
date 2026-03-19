using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[ComImport]
[Guid("000C03D5-0000-0000-C000-000000000046")]
[TypeLibType(256)]
[InterfaceType(1)]
public interface IConverterApplicationPreferences
{
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void HrGetLcid(out uint plcid);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void HrGetHwnd(out int phwnd);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void HrGetApplication([MarshalAs(UnmanagedType.BStr)] out string pbstrApplication);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void HrCheckFormat(out int pFormat);
}