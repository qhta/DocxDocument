using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[ComImport]
[TypeLibType(4288)]
[Guid("000C033E-0000-0000-C000-000000000046")]
public interface ICustomTaskPaneConsumer
{
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1)]
  void CTPFactoryAvailable([In] [MarshalAs(UnmanagedType.Interface)] ICTPFactory CTPFactoryInst);
}