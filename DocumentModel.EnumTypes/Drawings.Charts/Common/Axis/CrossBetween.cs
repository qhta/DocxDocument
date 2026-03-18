namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the CrossBetween enumeration.
/// Used in types such as ValueAxis, ValueAxisConverter.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXDC.CrossBetweenValues))]
public enum CrossBetween
{
  /// <summary>
  ///   Between.
  /// </summary>
  [OpenXmlEnumValue("Between")]
  Between,
  /// <summary>
  ///   Midpoint of Category.
  /// </summary>
  [OpenXmlEnumValue("MidpointCategory")]
  MidpointCategory
}
