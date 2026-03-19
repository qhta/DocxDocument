using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[Guid("76D9466C-84C2-4355-81FE-CB1B9CB03C19")]
[TypeLibType(16)]
public enum XlSeriesNameLevel
{
  xlSeriesNameLevelNone = -3,
  xlSeriesNameLevelCustom,
  xlSeriesNameLevelAll
}