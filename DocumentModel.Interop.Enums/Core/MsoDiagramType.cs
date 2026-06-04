
namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the type of diagram.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodiagramtype?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoDiagramType")]
public enum DiagramType
{
  /// <summary>
  /// Return value only; indicates a combination of the other states.
  /// </summary>
  [OfficeInteropEnumValue("msoDiagramMixed")]
  Mixed = -2,
  /// <summary>
  /// Organization chart diagram.
  /// </summary>
  [OfficeInteropEnumValue("msoDiagramOrgChart")]
  OrgChart = 1,
  /// <summary>
  /// Cycle diagram.
  /// </summary>
  [OfficeInteropEnumValue("msoDiagramCycle")]
  Cycle = 2,
  /// <summary>
  /// Radial diagram.
  /// </summary>
  [OfficeInteropEnumValue("msoDiagramRadial")]
  Radial = 3,
  /// <summary>
  /// Pyramid diagram.
  /// </summary>
  [OfficeInteropEnumValue("msoDiagramPyramid")]
  Pyramid = 4,
  /// <summary>
  /// Venn diagram.
  /// </summary>
  [OfficeInteropEnumValue("msoDiagramVenn")]
  Venn = 5,
  /// <summary>
  /// Target diagram.
  /// </summary>
  [OfficeInteropEnumValue("msoDiagramTarget")]
  Target = 6
}
