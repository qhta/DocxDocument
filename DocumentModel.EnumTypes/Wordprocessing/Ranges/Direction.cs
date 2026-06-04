namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Defines the Direction enumeration.
/// Used in types such as InnerShadow, LightRig, OuterShadow.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.DirectionValues))]
public enum Direction
{
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
