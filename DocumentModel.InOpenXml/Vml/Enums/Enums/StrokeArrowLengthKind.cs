namespace DocumentModel.Vml;
/// <summary>
///   Stroke Arrowhead Length
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXV.StrokeArrowLengthValues))]
public enum StrokeArrowLengthKind
{
  /// <summary>
  ///   Short Arrowhead.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXV.StrokeArrowLengthValues.Short))]
  Short,
  /// <summary>
  ///   Medium Arrowhead.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXV.StrokeArrowLengthValues.Medium))]
  Medium,
  /// <summary>
  ///   Long Arrowhead.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXV.StrokeArrowLengthValues.Long))]
  Long
}