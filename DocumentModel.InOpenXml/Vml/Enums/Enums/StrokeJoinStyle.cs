namespace DocumentModel.Vml;
/// <summary>
///   Line Join Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXV.StrokeJoinStyleValues))]
public enum StrokeJoinStyle
{
  /// <summary>
  ///   Round Joint.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXV.StrokeJoinStyleValues.Round))]
  Round,
  /// <summary>
  ///   Bevel Joint.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXV.StrokeJoinStyleValues.Bevel))]
  Bevel,
  /// <summary>
  ///   Miter Joint.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXV.StrokeJoinStyleValues.Miter))]
  Miter
}