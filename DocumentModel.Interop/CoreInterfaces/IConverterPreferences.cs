using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[ComImport]
[TypeLibType(256)]
[InterfaceType(1)]
[Guid("000C03D4-0000-0000-C000-000000000046")]
public interface IConverterPreferences
{
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void HrGetMacroEnabled(out int pfMacroEnabled);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void HrCheckFormat(out int pFormat);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void HrGetLossySave(out int pfLossySave);
}