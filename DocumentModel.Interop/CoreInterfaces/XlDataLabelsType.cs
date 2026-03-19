using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[TypeLibType(16)]
public enum XlDataLabelsType
{
  xlDataLabelsShowNone = -4142,
  xlDataLabelsShowValue = 2,
  xlDataLabelsShowPercent = 3,
  xlDataLabelsShowLabel = 4,
  xlDataLabelsShowLabelAndPercent = 5,
  xlDataLabelsShowBubbleSizes = 6
}