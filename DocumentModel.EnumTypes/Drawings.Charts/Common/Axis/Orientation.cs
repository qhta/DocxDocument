namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the Orientation enumeration.
/// Used in types such as PageSetup, Scaling, OrientationKind.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXDC.OrientationValues))]
public enum Orientation
{
  /// <summary>
  ///   Maximum to Minimum.
  /// </summary>
  [OpenXmlEnumValue("MaxMin")]
  MaxMin,
  /// <summary>
  ///   Minimum to Maximum.
  /// </summary>
  [OpenXmlEnumValue("MinMax")]
  MinMax
}
