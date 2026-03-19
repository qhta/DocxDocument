using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[ComImport]
[InterfaceType(1)]
[Guid("000C03D7-0000-0000-C000-000000000046")]
[TypeLibType(256)]
public interface IConverter
{
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void HrInitConverter
  ([In] [MarshalAs(UnmanagedType.Interface)] IConverterApplicationPreferences pcap,
    [MarshalAs(UnmanagedType.Interface)] out IConverterPreferences ppcp,
    [In] [MarshalAs(UnmanagedType.Interface)] IConverterUICallback pcuic);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void HrUninitConverter([In] [MarshalAs(UnmanagedType.Interface)] IConverterUICallback pcuic);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void HrImport
  ([In] [MarshalAs(UnmanagedType.BStr)] string bstrSourcePath, [In] [MarshalAs(UnmanagedType.BStr)] string bstrDestPath,
    [In] [MarshalAs(UnmanagedType.Interface)] IConverterApplicationPreferences pcap,
    [MarshalAs(UnmanagedType.Interface)] out IConverterPreferences ppcp,
    [In] [MarshalAs(UnmanagedType.Interface)] IConverterUICallback pcuic);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void HrExport
  ([In] [MarshalAs(UnmanagedType.BStr)] string bstrSourcePath, [In] [MarshalAs(UnmanagedType.BStr)] string bstrDestPath,
    [In] [MarshalAs(UnmanagedType.BStr)] string bstrClass,
    [In] [MarshalAs(UnmanagedType.Interface)] IConverterApplicationPreferences pcap,
    [MarshalAs(UnmanagedType.Interface)] out IConverterPreferences ppcp,
    [In] [MarshalAs(UnmanagedType.Interface)] IConverterUICallback pcuic);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void HrGetFormat
  ([In] [MarshalAs(UnmanagedType.BStr)] string bstrPath, [MarshalAs(UnmanagedType.BStr)] out string pbstrClass,
    [In] [MarshalAs(UnmanagedType.Interface)] IConverterApplicationPreferences pcap,
    [MarshalAs(UnmanagedType.Interface)] out IConverterPreferences ppcp,
    [In] [MarshalAs(UnmanagedType.Interface)] IConverterUICallback pcuic);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void HrGetErrorString
  ([In] int hrErr, [MarshalAs(UnmanagedType.BStr)] out string pbstrErrorMsg,
    [In] [MarshalAs(UnmanagedType.Interface)] IConverterApplicationPreferences pcap);
}