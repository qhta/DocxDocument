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
  ///   Used only for detection.
  /// </summary>
  Mixed = -2,
  /// <summary>
  ///   Maximum to Minimum.
  /// </summary>
  [OpenXmlEnumValue("MaxMin")]
  MaxMin = 1,

  /// <summary>
  ///   Minimum to Maximum.
  /// </summary>
  [OpenXmlEnumValue("MinMax")]
  MinMax
}
