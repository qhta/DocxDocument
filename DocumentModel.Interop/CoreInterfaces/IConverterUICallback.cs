using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[ComImport]
[InterfaceType(1)]
[TypeLibType(256)]
[Guid("000C03D6-0000-0000-C000-000000000046")]
public interface IConverterUICallback
{
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void HrReportProgress([In] uint uPercentComplete);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void HrMessageBox
  ([In] [MarshalAs(UnmanagedType.BStr)] string bstrText, [In] [MarshalAs(UnmanagedType.BStr)] string bstrCaption,
    [In] uint uType, out int pidResult);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void HrInputBox
  ([In] [MarshalAs(UnmanagedType.BStr)] string bstrText, [In] [MarshalAs(UnmanagedType.BStr)] string bstrCaption,
    [MarshalAs(UnmanagedType.BStr)] out string pbstrInput, [In] int fPassword);
}