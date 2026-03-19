using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[TypeLibType(16)]
[Guid("2B4C8AB7-6E70-422A-B7CC-206452289F16")]
public enum XlPieSliceIndex
{
  xlOuterCounterClockwisePoint = 1,
  xlOuterCenterPoint,
  xlOuterClockwisePoint,
  xlMidClockwiseRadiusPoint,
  xlCenterPoint,
  xlMidCounterClockwiseRadiusPoint,
  xlInnerClockwisePoint,
  xlInnerCenterPoint,
  xlInnerCounterClockwisePoint
}