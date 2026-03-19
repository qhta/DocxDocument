using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[Guid("E5EAD0BB-3A16-48F3-BECD-5839F6B552CA")]
[TypeLibType(16)]
public enum XlTickMark
{
  xlTickMarkCross = 4,
  xlTickMarkInside = 2,
  xlTickMarkNone = -4142,
  xlTickMarkOutside = 3
}