namespace DocumentModel.Vml;
/// <summary>
///   Line Join Type
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Vml.StrokeJoinStyleValues))]
public enum StrokeJoinStyle
{
  /// <summary>
  ///   Round Joint.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.StrokeJoinStyleValues.Round))]
  Round = 1,

  /// <summary>
  ///   Bevel Joint.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.StrokeJoinStyleValues.Bevel))]
  Bevel,
  /// <summary>
  ///   Miter Joint.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.StrokeJoinStyleValues.Miter))]
  Miter
}