using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Excel;

[ComImport]
[TypeLibType(TypeLibTypeFlags.FHidden | TypeLibTypeFlags.FDispatchable)]
[Guid("00024466-0001-0000-C000-000000000046")]
public interface ISpeech
{
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Speak
  ([In] [MarshalAs(UnmanagedType.BStr)] string Text,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object SpeakAsync,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object SpeakXML,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Purge);

  [DispId(168)]
  XlSpeakDirection Direction
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [param: In]
    set;
  }

  [DispId(2235)]
  bool SpeakCellOnEnter
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [param: In]
    set;
  }
}