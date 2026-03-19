using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[TypeLibType(16)]
public enum XlDataLabelPosition
{
  xlLabelPositionCenter = -4108,
  xlLabelPositionAbove = 0,
  xlLabelPositionBelow = 1,
  xlLabelPositionLeft = -4131,
  xlLabelPositionRight = -4152,
  xlLabelPositionOutsideEnd = 2,
  xlLabelPositionInsideEnd = 3,
  xlLabelPositionInsideBase = 4,
  xlLabelPositionBestFit = 5,
  xlLabelPositionMixed = 6,
  xlLabelPositionCustom = 7
}