namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the type of soft edge effect.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msosoftedgetype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoSoftEdgeType")]
public enum SoftEdgeType
{
  /// <summary>
  /// A mix of soft edge types.
  /// </summary>
  [InteropEnumValue("msoSoftEdgeTypeMixed")]
  Mixed = -2,
  /// <summary>
  /// No soft edge.
  /// </summary>
  [InteropEnumValue("msoSoftEdgeTypeNone")]
  None = 0,
  /// <summary>
  /// Soft Edge
  /// </summary>
  [InteropEnumValue("msoSoftEdgeType1")]
  Type1 = 1,
  /// <summary>
  /// Soft Edge
  /// </summary>
  [InteropEnumValue("msoSoftEdgeType2")]
  Type2 = 2,
  /// <summary>
  /// Soft Edge
  /// </summary>
  [InteropEnumValue("msoSoftEdgeType3")]
  Type3 = 3,
  /// <summary>
  /// Soft Edge
  /// </summary>
  [InteropEnumValue("msoSoftEdgeType4")]
  Type4 = 4,
  /// <summary>
  /// Soft Edge
  /// </summary>
  [InteropEnumValue("msoSoftEdgeType5")]
  Type5 = 5,
  /// <summary>
  /// Soft Edge
  /// </summary>
  [InteropEnumValue("msoSoftEdgeType6")]
  Type6 = 6
}
