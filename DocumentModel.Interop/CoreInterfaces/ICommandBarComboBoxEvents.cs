using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[ComImport]
[Guid("55F88896-7708-11D1-ACEB-006008961DA5")]
[TypeLibType(4304)]
public interface ICommandBarComboBoxEvents
{
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1)]
  void Change([In] [MarshalAs(UnmanagedType.Interface)] CommandBarComboBox Ctrl);
}