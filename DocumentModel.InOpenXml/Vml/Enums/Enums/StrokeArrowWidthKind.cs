namespace DocumentModel.Vml;
/// <summary>
///   Stroke Arrowhead Width
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXV.StrokeArrowWidthValues))]
public enum StrokeArrowWidthKind
{
  /// <summary>
  ///   Narrow Arrowhead.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXV.StrokeArrowWidthValues.Narrow))]
  Narrow,
  /// <summary>
  ///   Medium Arrowhead.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXV.StrokeArrowWidthValues.Medium))]
  Medium,
  /// <summary>
  ///   Wide Arrowhead.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXV.StrokeArrowWidthValues.Wide))]
  Wide
}