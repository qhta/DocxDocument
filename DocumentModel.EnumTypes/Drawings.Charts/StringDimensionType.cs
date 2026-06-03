namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the StringDimensionType enumeration.
/// Used in types such as StringDimension, StringDimensionType, StringDimensionConverter.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum StringDimensionType
{
  /// <summary>
  ///   cat.
  /// </summary>
  [OpenXmlEnumValue("Cat")]
  Cat,
  /// <summary>
  ///   colorStr.
  /// </summary>
  [OpenXmlEnumValue("ColorStr")]
  ColorStr,
  /// <summary>
  ///   entityId.
  /// </summary>
  [OpenXmlEnumValue("EntityId")]
  EntityId
}

