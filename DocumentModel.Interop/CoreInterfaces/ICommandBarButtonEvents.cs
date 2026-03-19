using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[ComImport]
[Guid("55F88890-7708-11D1-ACEB-006008961DA5")]
[TypeLibType(4304)]
public interface ICommandBarButtonEvents
{
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1)]
  void Click([In] [MarshalAs(UnmanagedType.Interface)] CommandBarButton Ctrl, [In] [Out] ref bool CancelDefault);
}