using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[TypeLibType(16)]
public enum MsoDiagramType
{
  msoDiagramMixed = -2,
  msoDiagramOrgChart = 1,
  msoDiagramCycle = 2,
  msoDiagramRadial = 3,
  msoDiagramPyramid = 4,
  msoDiagramVenn = 5,
  msoDiagramTarget = 6
}