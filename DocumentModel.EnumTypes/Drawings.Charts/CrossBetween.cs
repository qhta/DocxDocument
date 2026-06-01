namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the CrossBetween enumeration.
/// Used Iin types such as ValueAxis, ValueAxisConverter.
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
  ///   Midpoint of ICategory.
  /// </summary>
  [OpenXmlEnumValue("MidpointCategory")]
  MidpointCategory
}

