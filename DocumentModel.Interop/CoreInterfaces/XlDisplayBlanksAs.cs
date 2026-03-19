using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[TypeLibType(16)]
[Guid("3439EA79-5069-4404-A6E3-8EE3A1B9BD0E")]
public enum XlDisplayBlanksAs
{
  xlInterpolated = 3,
  xlNotPlotted = 1,
  xlZero = 2
}