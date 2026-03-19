using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[ComImport]
[TypeLibType(4304)]
[Guid("000CDB0A-0000-0000-C000-000000000046")]
public interface ICustomXMLPartsEvents
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