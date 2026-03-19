using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[ComImport]
[InterfaceType(2)]
[Guid("000C0354-0000-0000-C000-000000000046")]
[TypeLibType(4112)]
public interface _CommandBarComboBoxEvents
{
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1)]
  void Change([In] [MarshalAs(UnmanagedType.Interface)] CommandBarComboBox Ctrl);
}