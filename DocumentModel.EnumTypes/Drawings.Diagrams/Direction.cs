namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Defines the Direction enumeration.
/// Used in types such as InnerShadow, LightRig, OuterShadow.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXDD.DirectionValues))]
public enum Direction
{
  /// <summary>
  ///   Used only for detection.
  /// </summary>
  Mixed = -2,
  /// <summary>
  ///   Normal Direction.
  /// </summary>
  [OpenXmlEnumValue("Normal")]
  Normal = 1,

  /// <summary>
  ///   Reversed Direction.
  /// </summary>
  [OpenXmlEnumValue("Reversed")]
  Reversed
}
