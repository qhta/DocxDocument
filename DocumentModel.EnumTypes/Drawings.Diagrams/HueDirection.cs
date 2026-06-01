namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Defines the HueDirection enumeration.
/// Used Iin types such as ColorsType, ColorsTypeConverter.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXDD.HueDirectionValues))]
public enum HueDirection
{
  /// <summary>
  ///   Clockwise Hue Direction.
  /// </summary>
  [OpenXmlEnumValue("Clockwise")]
  Clockwise = 1,

  /// <summary>
  ///   Counterclockwise Hue Direction.
  /// </summary>
  [OpenXmlEnumValue("Counterclockwise")]
  Counterclockwise
}

