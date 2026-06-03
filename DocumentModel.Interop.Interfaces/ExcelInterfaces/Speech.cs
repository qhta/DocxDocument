using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Excel;

[ComImport]
[TypeLibType(TypeLibTypeFlags.FDispatchable)]
[Guid("00024466-0000-0000-C000-000000000046")]
[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
public interface Speech
{
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(2017)]
  void Speak
  ([In] [MarshalAs(UnmanagedType.BStr)] string Text,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object SpeakAsync,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object SpeakXML,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Purge);

  [DispId(168)]
  XlSpeakDirection Direction
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(168)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(168)]
    [param: In]
    set;
  }

  [DispId(2235)]
  bool SpeakCellOnEnter
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2235)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(2235)]
    [param: In]
    set;
  }
}