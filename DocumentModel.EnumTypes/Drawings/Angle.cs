namespace DocumentModel.Vml;
/// <summary>
///   Callout Angles
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Vml.Office.AngleValues))]
public enum Angle
{
  /// <summary>
  ///   Any Angle.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Office.AngleValues.Any))]
  Any,
  /// <summary>
  ///   30 degrees.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Office.AngleValues.Degree30))]
  Degree30,
  /// <summary>
  ///   45 degrees.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Office.AngleValues.Degree45))]
  Degree45,
  /// <summary>
  ///   60 degrees.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Office.AngleValues.Degree60))]
  Degree60,
  /// <summary>
  ///   90 degrees.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Office.AngleValues.Degree90))]
  Degree90,
  /// <summary>
  ///   Automatic Angle.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Office.AngleValues.Auto))]
  Auto
}