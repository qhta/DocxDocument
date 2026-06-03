using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Excel;

[ComImport]
[TypeLibType(TypeLibTypeFlags.FHidden | TypeLibTypeFlags.FDispatchable)]
[Guid("00020845-0001-0000-C000-000000000046")]
public interface IWorksheetFunction
{
  [DispId(148)]
  Application Application
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(149)]
  XlCreator Creator
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    get;
  }

  [DispId(150)]
  object Parent
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden | TypeLibFuncFlags.FNonBrowsable)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object _WSFunction
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg1,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg6,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg7,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg8,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg9,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg10,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg11,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg12,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg13,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg14,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg15,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg16,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg17,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg18,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg19,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg20,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg21,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg22,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg23,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg24,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg25,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg26,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg27,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg28,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg29,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg30);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Count
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg6,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg7,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg8,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg9,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg10,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg11,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg12,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg13,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg14,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg15,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg16,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg17,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg18,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg19,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg20,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg21,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg22,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg23,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg24,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg25,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg26,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg27,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg28,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg29,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg30);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  bool IsNA([In] [MarshalAs(UnmanagedType.Struct)] object Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  bool IsError([In] [MarshalAs(UnmanagedType.Struct)] object Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Sum
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg6,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg7,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg8,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg9,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg10,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg11,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg12,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg13,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg14,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg15,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg16,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg17,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg18,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg19,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg20,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg21,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg22,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg23,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg24,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg25,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg26,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg27,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg28,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg29,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg30);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Average
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg6,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg7,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg8,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg9,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg10,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg11,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg12,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg13,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg14,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg15,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg16,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg17,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg18,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg19,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg20,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg21,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg22,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg23,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg24,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg25,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg26,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg27,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg28,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg29,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg30);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Min
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg6,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg7,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg8,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg9,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg10,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg11,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg12,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg13,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg14,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg15,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg16,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg17,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg18,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg19,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg20,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg21,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg22,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg23,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg24,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg25,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg26,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg27,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg28,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg29,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg30);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Max
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg6,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg7,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg8,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg9,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg10,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg11,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg12,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg13,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg14,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg15,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg16,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg17,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg18,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg19,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg20,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg21,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg22,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg23,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg24,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg25,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg26,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg27,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg28,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg29,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg30);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Npv
  ([In] double Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg6,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg7,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg8,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg9,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg10,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg11,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg12,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg13,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg14,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg15,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg16,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg17,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg18,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg19,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg20,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg21,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg22,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg23,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg24,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg25,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg26,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg27,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg28,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg29,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg30);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double StDev
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg6,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg7,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg8,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg9,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg10,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg11,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg12,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg13,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg14,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg15,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg16,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg17,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg18,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg19,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg20,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg21,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg22,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg23,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg24,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg25,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg26,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg27,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg28,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg29,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg30);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string Dollar([In] double Arg1, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string Fixed
  ([In] double Arg1, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Pi();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Ln([In] double Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Log10([In] double Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Round([In] double Arg1, [In] double Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Lookup
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Index
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] double Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string Rept([In] [MarshalAs(UnmanagedType.BStr)] string Arg1, [In] double Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  bool And
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg6,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg7,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg8,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg9,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg10,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg11,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg12,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg13,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg14,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg15,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg16,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg17,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg18,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg19,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg20,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg21,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg22,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg23,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg24,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg25,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg26,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg27,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg28,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg29,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg30);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  bool Or
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg6,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg7,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg8,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg9,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg10,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg11,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg12,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg13,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg14,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg15,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg16,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg17,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg18,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg19,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg20,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg21,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg22,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg23,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg24,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg25,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg26,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg27,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg28,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg29,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg30);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double DCount
  ([In] [MarshalAs(UnmanagedType.Interface)] Range Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [In] [MarshalAs(UnmanagedType.Struct)] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double DSum
  ([In] [MarshalAs(UnmanagedType.Interface)] Range Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [In] [MarshalAs(UnmanagedType.Struct)] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double DAverage
  ([In] [MarshalAs(UnmanagedType.Interface)] Range Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [In] [MarshalAs(UnmanagedType.Struct)] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double DMin
  ([In] [MarshalAs(UnmanagedType.Interface)] Range Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [In] [MarshalAs(UnmanagedType.Struct)] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double DMax
  ([In] [MarshalAs(UnmanagedType.Interface)] Range Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [In] [MarshalAs(UnmanagedType.Struct)] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double DStDev
  ([In] [MarshalAs(UnmanagedType.Interface)] Range Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [In] [MarshalAs(UnmanagedType.Struct)] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Var
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg6,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg7,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg8,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg9,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg10,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg11,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg12,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg13,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg14,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg15,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg16,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg17,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg18,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg19,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg20,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg21,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg22,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg23,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg24,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg25,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg26,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg27,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg28,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg29,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg30);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double DVar
  ([In] [MarshalAs(UnmanagedType.Interface)] Range Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [In] [MarshalAs(UnmanagedType.Struct)] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string Text([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.BStr)] string Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object LinEst
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Trend
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object LogEst
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Growth
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Pv
  ([In] double Arg1, [In] double Arg2, [In] double Arg3, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Fv
  ([In] double Arg1, [In] double Arg2, [In] double Arg3, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double NPer
  ([In] double Arg1, [In] double Arg2, [In] double Arg3, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Pmt
  ([In] double Arg1, [In] double Arg2, [In] double Arg3, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Rate
  ([In] double Arg1, [In] double Arg2, [In] double Arg3, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg6);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double MIrr([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] double Arg2, [In] double Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Irr
    ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Match
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Weekday
    ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Search
  ([In] [MarshalAs(UnmanagedType.BStr)] string Arg1, [In] [MarshalAs(UnmanagedType.BStr)] string Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Transpose([In] [MarshalAs(UnmanagedType.Struct)] object Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Atan2([In] double Arg1, [In] double Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Asin([In] double Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Acos([In] double Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Choose
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg6,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg7,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg8,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg9,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg10,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg11,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg12,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg13,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg14,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg15,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg16,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg17,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg18,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg19,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg20,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg21,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg22,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg23,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg24,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg25,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg26,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg27,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg28,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg29,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg30);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object HLookup
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [In] [MarshalAs(UnmanagedType.Struct)] object Arg3, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object VLookup
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [In] [MarshalAs(UnmanagedType.Struct)] object Arg3, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Log([In] double Arg1, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string Proper([In] [MarshalAs(UnmanagedType.BStr)] string Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string Trim([In] [MarshalAs(UnmanagedType.BStr)] string Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string Replace
  ([In] [MarshalAs(UnmanagedType.BStr)] string Arg1, [In] double Arg2, [In] double Arg3,
    [In] [MarshalAs(UnmanagedType.BStr)] string Arg4);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string Substitute
  ([In] [MarshalAs(UnmanagedType.BStr)] string Arg1, [In] [MarshalAs(UnmanagedType.BStr)] string Arg2,
    [In] [MarshalAs(UnmanagedType.BStr)] string Arg3, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Find
  ([In] [MarshalAs(UnmanagedType.BStr)] string Arg1, [In] [MarshalAs(UnmanagedType.BStr)] string Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  bool IsErr([In] [MarshalAs(UnmanagedType.Struct)] object Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  bool IsText([In] [MarshalAs(UnmanagedType.Struct)] object Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  bool IsNumber([In] [MarshalAs(UnmanagedType.Struct)] object Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Sln([In] double Arg1, [In] double Arg2, [In] double Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Syd([In] double Arg1, [In] double Arg2, [In] double Arg3, [In] double Arg4);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Ddb
  ([In] double Arg1, [In] double Arg2, [In] double Arg3, [In] double Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string Clean([In] [MarshalAs(UnmanagedType.BStr)] string Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double MDeterm([In] [MarshalAs(UnmanagedType.Struct)] object Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object MInverse([In] [MarshalAs(UnmanagedType.Struct)] object Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object MMult([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Ipmt
  ([In] double Arg1, [In] double Arg2, [In] double Arg3, [In] double Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg6);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Ppmt
  ([In] double Arg1, [In] double Arg2, [In] double Arg3, [In] double Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg6);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double CountA
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg6,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg7,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg8,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg9,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg10,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg11,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg12,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg13,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg14,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg15,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg16,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg17,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg18,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg19,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg20,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg21,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg22,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg23,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg24,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg25,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg26,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg27,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg28,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg29,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg30);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Product
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg6,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg7,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg8,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg9,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg10,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg11,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg12,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg13,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg14,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg15,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg16,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg17,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg18,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg19,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg20,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg21,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg22,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg23,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg24,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg25,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg26,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg27,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg28,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg29,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg30);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Fact([In] double Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double DProduct
  ([In] [MarshalAs(UnmanagedType.Interface)] Range Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [In] [MarshalAs(UnmanagedType.Struct)] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  bool IsNonText([In] [MarshalAs(UnmanagedType.Struct)] object Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double StDevP
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg6,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg7,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg8,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg9,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg10,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg11,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg12,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg13,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg14,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg15,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg16,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg17,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg18,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg19,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg20,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg21,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg22,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg23,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg24,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg25,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg26,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg27,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg28,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg29,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg30);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double VarP
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg6,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg7,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg8,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg9,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg10,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg11,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg12,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg13,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg14,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg15,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg16,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg17,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg18,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg19,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg20,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg21,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg22,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg23,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg24,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg25,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg26,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg27,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg28,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg29,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg30);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double DStDevP
  ([In] [MarshalAs(UnmanagedType.Interface)] Range Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [In] [MarshalAs(UnmanagedType.Struct)] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double DVarP
  ([In] [MarshalAs(UnmanagedType.Interface)] Range Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [In] [MarshalAs(UnmanagedType.Struct)] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  bool IsLogical([In] [MarshalAs(UnmanagedType.Struct)] object Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double DCountA
  ([In] [MarshalAs(UnmanagedType.Interface)] Range Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [In] [MarshalAs(UnmanagedType.Struct)] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string USDollar([In] double Arg1, [In] double Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double FindB
  ([In] [MarshalAs(UnmanagedType.BStr)] string Arg1, [In] [MarshalAs(UnmanagedType.BStr)] string Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double SearchB
  ([In] [MarshalAs(UnmanagedType.BStr)] string Arg1, [In] [MarshalAs(UnmanagedType.BStr)] string Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string ReplaceB
  ([In] [MarshalAs(UnmanagedType.BStr)] string Arg1, [In] double Arg2, [In] double Arg3,
    [In] [MarshalAs(UnmanagedType.BStr)] string Arg4);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double RoundUp([In] double Arg1, [In] double Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double RoundDown([In] double Arg1, [In] double Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Rank
  ([In] double Arg1, [In] [MarshalAs(UnmanagedType.Interface)] Range Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Days360
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Vdb
  ([In] double Arg1, [In] double Arg2, [In] double Arg3, [In] double Arg4, [In] double Arg5,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg6,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg7);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Median
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg6,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg7,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg8,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg9,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg10,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg11,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg12,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg13,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg14,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg15,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg16,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg17,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg18,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg19,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg20,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg21,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg22,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg23,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg24,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg25,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg26,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg27,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg28,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg29,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg30);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double SumProduct
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg6,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg7,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg8,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg9,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg10,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg11,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg12,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg13,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg14,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg15,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg16,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg17,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg18,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg19,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg20,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg21,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg22,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg23,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg24,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg25,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg26,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg27,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg28,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg29,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg30);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Sinh([In] double Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Cosh([In] double Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Tanh([In] double Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Asinh([In] double Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Acosh([In] double Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Atanh([In] double Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object DGet
  ([In] [MarshalAs(UnmanagedType.Interface)] Range Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [In] [MarshalAs(UnmanagedType.Struct)] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Db
  ([In] double Arg1, [In] double Arg2, [In] double Arg3, [In] double Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Frequency
    ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double AveDev
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg6,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg7,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg8,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg9,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg10,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg11,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg12,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg13,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg14,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg15,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg16,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg17,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg18,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg19,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg20,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg21,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg22,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg23,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg24,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg25,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg26,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg27,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg28,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg29,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg30);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double BetaDist
  ([In] double Arg1, [In] double Arg2, [In] double Arg3, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double GammaLn([In] double Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double BetaInv
  ([In] double Arg1, [In] double Arg2, [In] double Arg3, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double BinomDist([In] double Arg1, [In] double Arg2, [In] double Arg3, [In] bool Arg4);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double ChiDist([In] double Arg1, [In] double Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double ChiInv([In] double Arg1, [In] double Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Combin([In] double Arg1, [In] double Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Confidence([In] double Arg1, [In] double Arg2, [In] double Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double CritBinom([In] double Arg1, [In] double Arg2, [In] double Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Even([In] double Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double ExponDist([In] double Arg1, [In] double Arg2, [In] bool Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double FDist([In] double Arg1, [In] double Arg2, [In] double Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double FInv([In] double Arg1, [In] double Arg2, [In] double Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Fisher([In] double Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double FisherInv([In] double Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Floor([In] double Arg1, [In] double Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double GammaDist([In] double Arg1, [In] double Arg2, [In] double Arg3, [In] bool Arg4);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double GammaInv([In] double Arg1, [In] double Arg2, [In] double Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Ceiling([In] double Arg1, [In] double Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double HypGeomDist([In] double Arg1, [In] double Arg2, [In] double Arg3, [In] double Arg4);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double LogNormDist([In] double Arg1, [In] double Arg2, [In] double Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double LogInv([In] double Arg1, [In] double Arg2, [In] double Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double NegBinomDist([In] double Arg1, [In] double Arg2, [In] double Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double NormDist([In] double Arg1, [In] double Arg2, [In] double Arg3, [In] bool Arg4);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double NormSDist([In] double Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double NormInv([In] double Arg1, [In] double Arg2, [In] double Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double NormSInv([In] double Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Standardize([In] double Arg1, [In] double Arg2, [In] double Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Odd([In] double Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Permut([In] double Arg1, [In] double Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Poisson([In] double Arg1, [In] double Arg2, [In] bool Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double TDist([In] double Arg1, [In] double Arg2, [In] double Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Weibull([In] double Arg1, [In] double Arg2, [In] double Arg3, [In] bool Arg4);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double SumXMY2
    ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double SumX2MY2
    ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double SumX2PY2
    ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double ChiTest
    ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Correl([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Covar([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  double Forecast
  ([In] double Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [In] [MarshalAs(UnmanagedType.Struct)] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double FTest([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Intercept
    ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Pearson
    ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double RSq([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double StEyx([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Slope([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double TTest
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [In] double Arg3, [In] double Arg4);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Prob
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [In] double Arg3, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double DevSq
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg6,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg7,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg8,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg9,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg10,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg11,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg12,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg13,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg14,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg15,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg16,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg17,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg18,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg19,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg20,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg21,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg22,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg23,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg24,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg25,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg26,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg27,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg28,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg29,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg30);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double GeoMean
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg6,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg7,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg8,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg9,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg10,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg11,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg12,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg13,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg14,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg15,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg16,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg17,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg18,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg19,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg20,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg21,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg22,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg23,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg24,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg25,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg26,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg27,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg28,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg29,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg30);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double HarMean
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg6,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg7,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg8,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg9,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg10,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg11,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg12,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg13,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg14,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg15,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg16,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg17,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg18,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg19,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg20,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg21,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg22,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg23,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg24,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg25,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg26,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg27,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg28,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg29,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg30);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double SumSq
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg6,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg7,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg8,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg9,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg10,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg11,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg12,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg13,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg14,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg15,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg16,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg17,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg18,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg19,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg20,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg21,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg22,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg23,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg24,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg25,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg26,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg27,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg28,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg29,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg30);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Kurt
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg6,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg7,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg8,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg9,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg10,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg11,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg12,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg13,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg14,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg15,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg16,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg17,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg18,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg19,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg20,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg21,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg22,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg23,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg24,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg25,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg26,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg27,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg28,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg29,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg30);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Skew
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg6,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg7,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg8,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg9,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg10,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg11,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg12,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg13,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg14,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg15,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg16,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg17,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg18,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg19,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg20,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg21,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg22,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg23,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg24,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg25,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg26,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg27,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg28,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg29,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg30);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double ZTest
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] double Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Large([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] double Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Small([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] double Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Quartile([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] double Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Percentile([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] double Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double PercentRank
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] double Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Mode
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg6,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg7,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg8,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg9,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg10,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg11,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg12,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg13,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg14,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg15,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg16,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg17,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg18,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg19,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg20,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg21,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg22,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg23,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg24,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg25,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg26,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg27,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg28,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg29,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg30);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double TrimMean([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] double Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double TInv([In] double Arg1, [In] double Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Power([In] double Arg1, [In] double Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Radians([In] double Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Degrees([In] double Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Subtotal
  ([In] double Arg1, [In] [MarshalAs(UnmanagedType.Interface)] Range Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg6,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg7,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg8,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg9,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg10,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg11,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg12,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg13,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg14,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg15,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg16,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg17,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg18,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg19,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg20,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg21,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg22,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg23,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg24,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg25,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg26,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg27,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg28,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg29,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg30);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double SumIf
  ([In] [MarshalAs(UnmanagedType.Interface)] Range Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double CountIf
    ([In] [MarshalAs(UnmanagedType.Interface)] Range Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double CountBlank([In] [MarshalAs(UnmanagedType.Interface)] Range Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Ispmt([In] double Arg1, [In] double Arg2, [In] double Arg3, [In] double Arg4);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string Roman([In] double Arg1, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string Asc([In] [MarshalAs(UnmanagedType.BStr)] string Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string Dbcs([In] [MarshalAs(UnmanagedType.BStr)] string Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string Phonetic([In] [MarshalAs(UnmanagedType.Interface)] Range Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string BahtText([In] double Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string ThaiDayOfWeek([In] double Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string ThaiDigit([In] [MarshalAs(UnmanagedType.BStr)] string Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string ThaiMonthOfYear([In] double Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string ThaiNumSound([In] double Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string ThaiNumString([In] double Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  double ThaiStringLength([In] [MarshalAs(UnmanagedType.BStr)] string Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  bool IsThaiDigit([In] [MarshalAs(UnmanagedType.BStr)] string Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  double RoundBahtDown([In] double Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  double RoundBahtUp([In] double Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  double ThaiYear([In] double Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object RTD
  ([In] [MarshalAs(UnmanagedType.Struct)] object progID, [In] [MarshalAs(UnmanagedType.Struct)] object server,
    [In] [MarshalAs(UnmanagedType.Struct)] object topic1,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object topic2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object topic3,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object topic4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object topic5,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object topic6,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object topic7,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object topic8,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object topic9,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object topic10,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object topic11,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object topic12,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object topic13,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object topic14,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object topic15,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object topic16,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object topic17,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object topic18,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object topic19,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object topic20,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object topic21,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object topic22,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object topic23,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object topic24,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object topic25,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object topic26,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object topic27,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object topic28);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string Hex2Bin
    ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string Hex2Dec([In] [MarshalAs(UnmanagedType.Struct)] object Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string Hex2Oct
    ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string Dec2Bin
    ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string Dec2Hex
    ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string Dec2Oct
    ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string Oct2Bin
    ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string Oct2Hex
    ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string Oct2Dec([In] [MarshalAs(UnmanagedType.Struct)] object Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string Bin2Dec([In] [MarshalAs(UnmanagedType.Struct)] object Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string Bin2Oct
    ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string Bin2Hex
    ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string ImSub([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string ImDiv([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string ImPower
    ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string ImAbs([In] [MarshalAs(UnmanagedType.Struct)] object Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string ImSqrt([In] [MarshalAs(UnmanagedType.Struct)] object Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string ImLn([In] [MarshalAs(UnmanagedType.Struct)] object Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string ImLog2([In] [MarshalAs(UnmanagedType.Struct)] object Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string ImLog10([In] [MarshalAs(UnmanagedType.Struct)] object Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string ImSin([In] [MarshalAs(UnmanagedType.Struct)] object Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string ImCos([In] [MarshalAs(UnmanagedType.Struct)] object Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string ImExp([In] [MarshalAs(UnmanagedType.Struct)] object Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string ImArgument([In] [MarshalAs(UnmanagedType.Struct)] object Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string ImConjugate([In] [MarshalAs(UnmanagedType.Struct)] object Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Imaginary([In] [MarshalAs(UnmanagedType.Struct)] object Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double ImReal([In] [MarshalAs(UnmanagedType.Struct)] object Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string Complex
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string ImSum
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg6,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg7,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg8,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg9,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg10,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg11,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg12,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg13,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg14,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg15,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg16,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg17,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg18,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg19,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg20,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg21,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg22,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg23,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg24,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg25,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg26,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg27,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg28,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg29,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg30);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string ImProduct
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg6,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg7,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg8,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg9,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg10,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg11,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg12,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg13,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg14,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg15,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg16,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg17,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg18,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg19,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg20,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg21,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg22,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg23,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg24,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg25,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg26,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg27,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg28,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg29,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg30);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double SeriesSum
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [In] [MarshalAs(UnmanagedType.Struct)] object Arg3, [In] [MarshalAs(UnmanagedType.Struct)] object Arg4);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double FactDouble([In] [MarshalAs(UnmanagedType.Struct)] object Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double SqrtPi([In] [MarshalAs(UnmanagedType.Struct)] object Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Quotient
    ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Delta
    ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double GeStep
    ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  bool IsEven([In] [MarshalAs(UnmanagedType.Struct)] object Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  bool IsOdd([In] [MarshalAs(UnmanagedType.Struct)] object Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double MRound([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Erf
    ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double ErfC([In] [MarshalAs(UnmanagedType.Struct)] object Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double BesselJ
    ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double BesselK
    ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double BesselY
    ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double BesselI
    ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Xirr
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Xnpv([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double PriceMat
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [In] [MarshalAs(UnmanagedType.Struct)] object Arg3, [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [In] [MarshalAs(UnmanagedType.Struct)] object Arg5, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg6);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double YieldMat
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [In] [MarshalAs(UnmanagedType.Struct)] object Arg3, [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [In] [MarshalAs(UnmanagedType.Struct)] object Arg5, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg6);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double IntRate
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [In] [MarshalAs(UnmanagedType.Struct)] object Arg3, [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Received
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [In] [MarshalAs(UnmanagedType.Struct)] object Arg3, [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Disc
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [In] [MarshalAs(UnmanagedType.Struct)] object Arg3, [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double PriceDisc
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [In] [MarshalAs(UnmanagedType.Struct)] object Arg3, [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double YieldDisc
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [In] [MarshalAs(UnmanagedType.Struct)] object Arg3, [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double TBillEq
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double TBillPrice
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double TBillYield
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Price
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [In] [MarshalAs(UnmanagedType.Struct)] object Arg3, [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [In] [MarshalAs(UnmanagedType.Struct)] object Arg5, [In] [MarshalAs(UnmanagedType.Struct)] object Arg6,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg7);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double DollarDe
    ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double DollarFr
    ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Nominal
    ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Effect([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double CumPrinc
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [In] [MarshalAs(UnmanagedType.Struct)] object Arg3, [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [In] [MarshalAs(UnmanagedType.Struct)] object Arg5, [In] [MarshalAs(UnmanagedType.Struct)] object Arg6);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double CumIPmt
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [In] [MarshalAs(UnmanagedType.Struct)] object Arg3, [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [In] [MarshalAs(UnmanagedType.Struct)] object Arg5, [In] [MarshalAs(UnmanagedType.Struct)] object Arg6);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double EDate([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double EoMonth
    ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double YearFrac
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double CoupDayBs
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [In] [MarshalAs(UnmanagedType.Struct)] object Arg3, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double CoupDays
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [In] [MarshalAs(UnmanagedType.Struct)] object Arg3, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double CoupDaysNc
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [In] [MarshalAs(UnmanagedType.Struct)] object Arg3, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double CoupNcd
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [In] [MarshalAs(UnmanagedType.Struct)] object Arg3, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double CoupNum
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [In] [MarshalAs(UnmanagedType.Struct)] object Arg3, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double CoupPcd
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [In] [MarshalAs(UnmanagedType.Struct)] object Arg3, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Duration
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [In] [MarshalAs(UnmanagedType.Struct)] object Arg3, [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [In] [MarshalAs(UnmanagedType.Struct)] object Arg5, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg6);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double MDuration
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [In] [MarshalAs(UnmanagedType.Struct)] object Arg3, [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [In] [MarshalAs(UnmanagedType.Struct)] object Arg5, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg6);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double OddLPrice
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [In] [MarshalAs(UnmanagedType.Struct)] object Arg3, [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [In] [MarshalAs(UnmanagedType.Struct)] object Arg5, [In] [MarshalAs(UnmanagedType.Struct)] object Arg6,
    [In] [MarshalAs(UnmanagedType.Struct)] object Arg7, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg8);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double OddLYield
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [In] [MarshalAs(UnmanagedType.Struct)] object Arg3, [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [In] [MarshalAs(UnmanagedType.Struct)] object Arg5, [In] [MarshalAs(UnmanagedType.Struct)] object Arg6,
    [In] [MarshalAs(UnmanagedType.Struct)] object Arg7, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg8);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double OddFPrice
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [In] [MarshalAs(UnmanagedType.Struct)] object Arg3, [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [In] [MarshalAs(UnmanagedType.Struct)] object Arg5, [In] [MarshalAs(UnmanagedType.Struct)] object Arg6,
    [In] [MarshalAs(UnmanagedType.Struct)] object Arg7, [In] [MarshalAs(UnmanagedType.Struct)] object Arg8,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg9);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double OddFYield
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [In] [MarshalAs(UnmanagedType.Struct)] object Arg3, [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [In] [MarshalAs(UnmanagedType.Struct)] object Arg5, [In] [MarshalAs(UnmanagedType.Struct)] object Arg6,
    [In] [MarshalAs(UnmanagedType.Struct)] object Arg7, [In] [MarshalAs(UnmanagedType.Struct)] object Arg8,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg9);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double RandBetween
    ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double WeekNum
    ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double AmorDegrc
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [In] [MarshalAs(UnmanagedType.Struct)] object Arg3, [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [In] [MarshalAs(UnmanagedType.Struct)] object Arg5, [In] [MarshalAs(UnmanagedType.Struct)] object Arg6,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg7);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double AmorLinc
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [In] [MarshalAs(UnmanagedType.Struct)] object Arg3, [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [In] [MarshalAs(UnmanagedType.Struct)] object Arg5, [In] [MarshalAs(UnmanagedType.Struct)] object Arg6,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg7);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Convert
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [In] [MarshalAs(UnmanagedType.Struct)] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double AccrInt
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [In] [MarshalAs(UnmanagedType.Struct)] object Arg3, [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [In] [MarshalAs(UnmanagedType.Struct)] object Arg5, [In] [MarshalAs(UnmanagedType.Struct)] object Arg6,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg7);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double AccrIntM
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [In] [MarshalAs(UnmanagedType.Struct)] object Arg3, [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double WorkDay
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double NetworkDays
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Gcd
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg6,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg7,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg8,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg9,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg10,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg11,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg12,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg13,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg14,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg15,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg16,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg17,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg18,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg19,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg20,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg21,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg22,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg23,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg24,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg25,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg26,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg27,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg28,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg29,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg30);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double MultiNomial
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg6,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg7,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg8,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg9,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg10,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg11,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg12,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg13,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg14,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg15,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg16,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg17,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg18,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg19,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg20,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg21,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg22,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg23,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg24,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg25,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg26,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg27,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg28,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg29,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg30);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Lcm
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg6,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg7,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg8,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg9,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg10,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg11,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg12,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg13,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg14,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg15,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg16,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg17,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg18,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg19,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg20,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg21,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg22,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg23,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg24,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg25,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg26,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg27,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg28,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg29,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg30);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double FVSchedule
    ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double SumIfs
  ([In] [MarshalAs(UnmanagedType.Interface)] Range Arg1, [In] [MarshalAs(UnmanagedType.Interface)] Range Arg2,
    [In] [MarshalAs(UnmanagedType.Struct)] object Arg3, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg6,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg7,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg8,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg9,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg10,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg11,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg12,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg13,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg14,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg15,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg16,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg17,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg18,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg19,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg20,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg21,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg22,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg23,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg24,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg25,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg26,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg27,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg28,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg29);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double CountIfs
  ([In] [MarshalAs(UnmanagedType.Interface)] Range Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg6,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg7,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg8,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg9,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg10,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg11,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg12,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg13,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg14,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg15,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg16,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg17,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg18,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg19,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg20,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg21,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg22,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg23,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg24,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg25,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg26,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg27,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg28,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg29,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg30);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double AverageIf
  ([In] [MarshalAs(UnmanagedType.Interface)] Range Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double AverageIfs
  ([In] [MarshalAs(UnmanagedType.Interface)] Range Arg1, [In] [MarshalAs(UnmanagedType.Interface)] Range Arg2,
    [In] [MarshalAs(UnmanagedType.Struct)] object Arg3, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg6,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg7,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg8,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg9,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg10,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg11,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg12,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg13,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg14,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg15,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg16,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg17,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg18,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg19,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg20,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg21,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg22,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg23,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg24,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg25,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg26,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg27,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg28,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg29);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object IfError
    ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Aggregate
  ([In] double Arg1, [In] double Arg2, [In] [MarshalAs(UnmanagedType.Interface)] Range Arg3,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg6,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg7,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg8,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg9,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg10,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg11,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg12,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg13,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg14,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg15,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg16,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg17,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg18,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg19,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg20,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg21,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg22,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg23,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg24,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg25,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg26,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg27,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg28,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg29,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg30);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Confidence_Norm([In] double Arg1, [In] double Arg2, [In] double Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Confidence_T([In] double Arg1, [In] double Arg2, [In] double Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double ChiSq_Test
    ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double F_Test([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Covariance_P
    ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Covariance_S
    ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Expon_Dist([In] double Arg1, [In] double Arg2, [In] bool Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Gamma_Dist([In] double Arg1, [In] double Arg2, [In] double Arg3, [In] bool Arg4);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Gamma_Inv([In] double Arg1, [In] double Arg2, [In] double Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Mode_Mult
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg6,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg7,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg8,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg9,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg10,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg11,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg12,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg13,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg14,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg15,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg16,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg17,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg18,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg19,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg20,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg21,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg22,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg23,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg24,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg25,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg26,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg27,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg28,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg29,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg30);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Mode_Sngl
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg6,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg7,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg8,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg9,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg10,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg11,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg12,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg13,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg14,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg15,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg16,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg17,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg18,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg19,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg20,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg21,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg22,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg23,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg24,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg25,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg26,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg27,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg28,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg29,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg30);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Norm_Dist([In] double Arg1, [In] double Arg2, [In] double Arg3, [In] bool Arg4);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Norm_Inv([In] double Arg1, [In] double Arg2, [In] double Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Percentile_Exc([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] double Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Percentile_Inc([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] double Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double PercentRank_Exc
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] double Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double PercentRank_Inc
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] double Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Poisson_Dist([In] double Arg1, [In] double Arg2, [In] bool Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Quartile_Exc([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] double Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Quartile_Inc([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] double Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Rank_Avg
  ([In] double Arg1, [In] [MarshalAs(UnmanagedType.Interface)] Range Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Rank_Eq
  ([In] double Arg1, [In] [MarshalAs(UnmanagedType.Interface)] Range Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double StDev_S
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg6,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg7,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg8,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg9,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg10,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg11,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg12,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg13,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg14,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg15,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg16,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg17,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg18,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg19,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg20,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg21,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg22,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg23,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg24,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg25,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg26,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg27,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg28,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg29,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg30);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double StDev_P
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg6,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg7,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg8,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg9,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg10,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg11,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg12,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg13,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg14,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg15,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg16,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg17,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg18,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg19,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg20,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg21,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg22,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg23,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg24,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg25,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg26,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg27,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg28,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg29,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg30);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double T_Dist([In] double Arg1, [In] double Arg2, [In] bool Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double T_Dist_2T([In] double Arg1, [In] double Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double T_Dist_RT([In] double Arg1, [In] double Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double T_Inv([In] double Arg1, [In] double Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double T_Inv_2T([In] double Arg1, [In] double Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Var_S
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg6,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg7,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg8,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg9,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg10,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg11,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg12,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg13,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg14,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg15,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg16,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg17,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg18,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg19,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg20,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg21,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg22,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg23,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg24,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg25,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg26,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg27,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg28,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg29,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg30);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Var_P
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg6,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg7,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg8,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg9,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg10,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg11,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg12,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg13,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg14,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg15,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg16,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg17,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg18,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg19,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg20,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg21,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg22,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg23,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg24,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg25,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg26,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg27,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg28,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg29,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg30);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Weibull_Dist([In] double Arg1, [In] double Arg2, [In] double Arg3, [In] bool Arg4);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double NetworkDays_Intl
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double WorkDay_Intl
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double ISO_Ceiling([In] double Arg1, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  double Dummy21([In] double Arg1, [In] double Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [TypeLibFunc(TypeLibFuncFlags.FHidden)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Dummy19
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg6,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg7,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg8,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg9,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg10,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg11,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg12,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg13,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg14,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg15,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg16,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg17,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg18,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg19,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg20,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg21,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg22,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg23,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg24,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg25,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg26,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg27,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg28,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg29,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg30);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Beta_Dist
  ([In] double Arg1, [In] double Arg2, [In] double Arg3, [In] bool Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg6);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Beta_Inv
  ([In] double Arg1, [In] double Arg2, [In] double Arg3, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double ChiSq_Dist([In] double Arg1, [In] double Arg2, [In] bool Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double ChiSq_Dist_RT([In] double Arg1, [In] double Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double ChiSq_Inv([In] double Arg1, [In] double Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double ChiSq_Inv_RT([In] double Arg1, [In] double Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double F_Dist([In] double Arg1, [In] double Arg2, [In] double Arg3, [In] bool Arg4);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double F_Dist_RT([In] double Arg1, [In] double Arg2, [In] double Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double F_Inv([In] double Arg1, [In] double Arg2, [In] double Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double F_Inv_RT([In] double Arg1, [In] double Arg2, [In] double Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double HypGeom_Dist([In] double Arg1, [In] double Arg2, [In] double Arg3, [In] double Arg4, [In] bool Arg5);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double LogNorm_Dist([In] double Arg1, [In] double Arg2, [In] double Arg3, [In] bool Arg4);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double LogNorm_Inv([In] double Arg1, [In] double Arg2, [In] double Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double NegBinom_Dist([In] double Arg1, [In] double Arg2, [In] double Arg3, [In] bool Arg4);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Norm_S_Dist([In] double Arg1, [In] bool Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Norm_S_Inv([In] double Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double T_Test
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [In] double Arg3, [In] double Arg4);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Z_Test
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] double Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Binom_Dist([In] double Arg1, [In] double Arg2, [In] double Arg3, [In] bool Arg4);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Binom_Inv([In] double Arg1, [In] double Arg2, [In] double Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Erf_Precise([In] [MarshalAs(UnmanagedType.Struct)] object Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double ErfC_Precise([In] [MarshalAs(UnmanagedType.Struct)] object Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double GammaLn_Precise([In] double Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Ceiling_Precise([In] double Arg1, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Floor_Precise([In] double Arg1, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Acot([In] double Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Acoth([In] double Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Cot([In] double Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Coth([In] double Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Csc([In] double Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Csch([In] double Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Sec([In] double Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Sech([In] double Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string ImCot([In] [MarshalAs(UnmanagedType.Struct)] object Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string ImTan([In] [MarshalAs(UnmanagedType.Struct)] object Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string ImCsc([In] [MarshalAs(UnmanagedType.Struct)] object Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string ImCsch([In] [MarshalAs(UnmanagedType.Struct)] object Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string ImSec([In] [MarshalAs(UnmanagedType.Struct)] object Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string ImSech([In] [MarshalAs(UnmanagedType.Struct)] object Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Bitand([In] double Arg1, [In] double Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Bitor([In] double Arg1, [In] double Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Bitxor([In] double Arg1, [In] double Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Bitlshift([In] double Arg1, [In] double Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Bitrshift([In] double Arg1, [In] double Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  bool Xor
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg6,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg7,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg8,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg9,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg10,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg11,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg12,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg13,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg14,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg15,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg16,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg17,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg18,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg19,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg20,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg21,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg22,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg23,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg24,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg25,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg26,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg27,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg28,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg29,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg30);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Combina([In] double Arg1, [In] double Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Permutationa([In] double Arg1, [In] double Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double PDuration([In] double Arg1, [In] double Arg2, [In] double Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string Base([In] double Arg1, [In] double Arg2, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Decimal([In] [MarshalAs(UnmanagedType.BStr)] string Arg1, [In] double Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Days([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Binom_Dist_Range
  ([In] double Arg1, [In] double Arg2, [In] double Arg3,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Gamma([In] double Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Gauss([In] double Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Phi([In] double Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Skew_p
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg6,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg7,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg8,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg9,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg10,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg11,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg12,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg13,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg14,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg15,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg16,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg17,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg18,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg19,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg20,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg21,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg22,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg23,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg24,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg25,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg26,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg27,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg28,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg29,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg30);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Rri([In] double Arg1, [In] double Arg2, [In] double Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string Unichar([In] double Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Unicode([In] [MarshalAs(UnmanagedType.BStr)] string Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Munit([In] double Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Arabic([In] [MarshalAs(UnmanagedType.BStr)] string Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double IsoWeekNum([In] double Arg1, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double NumberValue
  ([In] [MarshalAs(UnmanagedType.BStr)] string Arg1, [In] [MarshalAs(UnmanagedType.BStr)] string Arg2,
    [In] [MarshalAs(UnmanagedType.BStr)] string Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  bool IsFormula([In] [MarshalAs(UnmanagedType.Interface)] Range Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object IfNa([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Ceiling_Math
  ([In] double Arg1, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Floor_Math
  ([In] double Arg1, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string ImSinh([In] [MarshalAs(UnmanagedType.Struct)] object Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string ImCosh([In] [MarshalAs(UnmanagedType.Struct)] object Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object FilterXML([In] [MarshalAs(UnmanagedType.BStr)] string Arg1, [In] [MarshalAs(UnmanagedType.BStr)] string Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object WebService([In] [MarshalAs(UnmanagedType.BStr)] string Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object EncodeURL([In] [MarshalAs(UnmanagedType.BStr)] string Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Forecast_ETS
  ([In] double Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [In] [MarshalAs(UnmanagedType.Struct)] object Arg3, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg6);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Forecast_ETS_ConfInt
  ([In] double Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [In] [MarshalAs(UnmanagedType.Struct)] object Arg3, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg6,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg7);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Forecast_ETS_Seasonality
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Forecast_Linear
  ([In] double Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [In] [MarshalAs(UnmanagedType.Struct)] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Forecast_ETS_STAT
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [In] double Arg3, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg6);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double MaxIfs
  ([In] [MarshalAs(UnmanagedType.Interface)] Range Arg1, [In] [MarshalAs(UnmanagedType.Interface)] Range Arg2,
    [In] [MarshalAs(UnmanagedType.Struct)] object Arg3, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg6,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg7,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg8,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg9,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg10,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg11,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg12,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg13,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg14,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg15,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg16,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg17,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg18,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg19,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg20,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg21,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg22,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg23,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg24,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg25,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg26,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg27,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg28,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg29);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double MinIfs
  ([In] [MarshalAs(UnmanagedType.Interface)] Range Arg1, [In] [MarshalAs(UnmanagedType.Interface)] Range Arg2,
    [In] [MarshalAs(UnmanagedType.Struct)] object Arg3, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg6,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg7,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg8,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg9,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg10,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg11,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg12,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg13,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg14,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg15,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg16,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg17,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg18,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg19,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg20,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg21,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg22,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg23,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg24,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg25,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg26,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg27,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg28,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg29);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string TextJoin
  ([In] [MarshalAs(UnmanagedType.BStr)] ref string Arg1, [In] bool Arg2,
    [In] [MarshalAs(UnmanagedType.BStr)] ref string Arg3, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg6,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg7,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg8,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg9,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg10,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg11,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg12,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg13,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg14,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg15,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg16,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg17,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg18,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg19,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg20,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg21,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg22,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg23,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg24,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg25,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg26,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg27,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg28,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg29);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string Concat
  ([In] [MarshalAs(UnmanagedType.BStr)] ref string Arg1, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg6,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg7,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg8,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg9,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg10,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg11,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg12,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg13,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg14,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg15,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg16,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg17,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg18,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg19,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg20,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg21,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg22,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg23,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg24,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg25,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg26,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg27,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg28,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg29);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Sort
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Unique
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object FieldValue
    ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.BStr)] string Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Filter
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Sequence
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object RandArray
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg1,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Single([In] [MarshalAs(UnmanagedType.Struct)] object Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object SortBy
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [In] [MarshalAs(UnmanagedType.Struct)] object Arg3, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg6,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg7,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg8,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg9,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg10,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg11,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg12,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg13,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg14,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg15,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg16,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg17,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg18,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg19,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg20,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg21,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg22,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg23,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg24,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg25,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg26,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg27,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg28,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg29,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg30);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double XMatch
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object XLookup
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [In] [MarshalAs(UnmanagedType.Struct)] object Arg3, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg6);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object StockHistory
  ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [In] [MarshalAs(UnmanagedType.Struct)] object Arg2,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg3,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg4,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg5,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg6,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg7,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg8,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg9,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg10,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg11,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg12,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg13,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg14,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg15,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg16,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg17,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg18,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg19,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg20,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg21,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg22,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg23,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg24,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg25,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg26,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg27,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg28,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg29);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string ValueToText
    ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string ArrayToText
    ([In] [MarshalAs(UnmanagedType.Struct)] object Arg1, [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object Arg2);
}