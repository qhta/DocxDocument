namespace DocumentModel.Vml;
/// <summary>
///   Callout Angles
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXVO.AngleValues))]
public enum Angle
{
  /// <summary>
  ///   Any Angle.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVO.AngleValues.Any))]
  Any,
  /// <summary>
  ///   30 degrees.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVO.AngleValues.Degree30))]
  Degree30,
  /// <summary>
  ///   45 degrees.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVO.AngleValues.Degree45))]
  Degree45,
  /// <summary>
  ///   60 degrees.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVO.AngleValues.Degree60))]
  Degree60,
  /// <summary>
  ///   90 degrees.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVO.AngleValues.Degree90))]
  Degree90,
  /// <summary>
  ///   Automatic Angle.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVO.AngleValues.Auto))]
  Auto
}