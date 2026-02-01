namespace DocumentModel.Vml;
/// <summary>
///   Stroke Line Style
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXV.StrokeLineStyleValues))]
public enum StrokeLineStyleKind
{
  /// <summary>
  ///   Single Line.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXV.StrokeLineStyleValues.Single))]
  Single,
  /// <summary>
  ///   Two Thin Lines.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXV.StrokeLineStyleValues.ThinThin))]
  ThinThin,
  /// <summary>
  ///   Thin Line Outside Thick Line.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXV.StrokeLineStyleValues.ThinThick))]
  ThinThick,
  /// <summary>
  ///   Thick Line Outside Thin Line.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXV.StrokeLineStyleValues.ThickThin))]
  ThickThin,
  /// <summary>
  ///   Thck Line Between Thin Lines.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXV.StrokeLineStyleValues.ThickBetweenThin))]
  ThickBetweenThin
}