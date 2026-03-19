using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[Guid("BF78D790-8DCF-4CF1-9CD4-4FCEB78EBE14")]
[TypeLibType(16)]
public enum XlDisplayUnit
{
  xlHundreds = -2,
  xlThousands = -3,
  xlTenThousands = -4,
  xlHundredThousands = -5,
  xlMillions = -6,
  xlTenMillions = -7,
  xlHundredMillions = -8,
  xlThousandMillions = -9,
  xlMillionMillions = -10,
  xlDisplayUnitCustom = -4114,
  xlDisplayUnitNone = -4142
}