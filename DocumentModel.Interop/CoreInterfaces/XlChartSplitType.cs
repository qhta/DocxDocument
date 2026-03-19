using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[TypeLibType(16)]
[Guid("732091CB-0A8D-44BC-B977-418CCB37B552")]
public enum XlChartSplitType
{
  xlSplitByPosition = 1,
  xlSplitByPercentValue = 3,
  xlSplitByCustomSplit = 4,
  xlSplitByValue = 2
}