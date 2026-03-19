using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[ComImport]
[TypeLibType(4288)]
[Guid("4291224C-DEFE-485B-8E69-6CF8AA85CB76")]
public interface IAssistance
{
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610743808)]
  void ShowHelp
    ([In] [MarshalAs(UnmanagedType.BStr)] string HelpId = "", [In] [MarshalAs(UnmanagedType.BStr)] string Scope = "");

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610743809)]
  void SearchHelp
    ([In] [MarshalAs(UnmanagedType.BStr)] string Query, [In] [MarshalAs(UnmanagedType.BStr)] string Scope = "");

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610743810)]
  void SetDefaultContext([In] [MarshalAs(UnmanagedType.BStr)] string HelpId);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610743811)]
  void ClearDefaultContext([In] [MarshalAs(UnmanagedType.BStr)] string HelpId);
}