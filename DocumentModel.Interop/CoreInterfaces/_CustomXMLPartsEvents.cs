using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[ComImport]
[InterfaceType(2)]
[Guid("000CDB0B-0000-0000-C000-000000000046")]
[TypeLibType(4112)]
public interface _CustomXMLPartsEvents
{
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1)]
  void PartAfterAdd([In] [MarshalAs(UnmanagedType.Interface)] CustomXMLPart NewPart);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2)]
  void PartBeforeDelete([In] [MarshalAs(UnmanagedType.Interface)] CustomXMLPart OldPart);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(3)]
  void PartAfterLoad([In] [MarshalAs(UnmanagedType.Interface)] CustomXMLPart Part);
}