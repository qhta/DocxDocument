namespace DocumentModel.Vml;
/// <summary>
///   Stroke Line Style
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Vml.StrokeLineStyleValues))]
public enum StrokeLineStyle
{
  /// <summary>
  ///   Single Line.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.StrokeLineStyleValues.Single))]
  Single,
  /// <summary>
  ///   Two Thin Lines.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.StrokeLineStyleValues.ThinThin))]
  ThinThin,
  /// <summary>
  ///   Thin Line Outside Thick Line.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.StrokeLineStyleValues.ThinThick))]
  ThinThick,
  /// <summary>
  ///   Thick Line Outside Thin Line.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.StrokeLineStyleValues.ThickThin))]
  ThickThin,
  /// <summary>
  ///   Thck Line Between Thin Lines.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.StrokeLineStyleValues.ThickBetweenThin))]
  ThickBetweenThin
}