
namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the type of diagram.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodiagramtype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoDiagramType")]
public enum DiagramType
{
  /// <summary>
  /// Return value only; indicates a combination of the other states.
  /// </summary>
  [InteropEnumValue("msoDiagramMixed")]
  Mixed = -2,
  /// <summary>
  /// Organization chart diagram.
  /// </summary>
  [InteropEnumValue("msoDiagramOrgChart")]
  OrgChart = 1,
  /// <summary>
  /// Cycle diagram.
  /// </summary>
  [InteropEnumValue("msoDiagramCycle")]
  Cycle = 2,
  /// <summary>
  /// Radial diagram.
  /// </summary>
  [InteropEnumValue("msoDiagramRadial")]
  Radial = 3,
  /// <summary>
  /// Pyramid diagram.
  /// </summary>
  [InteropEnumValue("msoDiagramPyramid")]
  Pyramid = 4,
  /// <summary>
  /// Venn diagram.
  /// </summary>
  [InteropEnumValue("msoDiagramVenn")]
  Venn = 5,
  /// <summary>
  /// Target diagram.
  /// </summary>
  [InteropEnumValue("msoDiagramTarget")]
  Target = 6
}
