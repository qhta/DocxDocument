
namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the type of diagram.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodiagramtype?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoDiagramType))]
public enum DiagramType
{
  /// <summary>
  /// Return value only; indicates a combination of the other states.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoDiagramType.msoDiagramMixed))]
  Mixed = -2,
  /// <summary>
  /// Organization chart diagram.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoDiagramType.msoDiagramOrgChart))]
  OrgChart = 1,
  /// <summary>
  /// Cycle diagram.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoDiagramType.msoDiagramCycle))]
  Cycle = 2,
  /// <summary>
  /// Radial diagram.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoDiagramType.msoDiagramRadial))]
  Radial = 3,
  /// <summary>
  /// Pyramid diagram.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoDiagramType.msoDiagramPyramid))]
  Pyramid = 4,
  /// <summary>
  /// Venn diagram.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoDiagramType.msoDiagramVenn))]
  Venn = 5,
  /// <summary>
  /// Target diagram.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoDiagramType.msoDiagramTarget))]
  Target = 6
}
