namespace DocumentModel.Math;
/// <summary>
///   Defines the StyleValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Math.StyleValues))]
public enum RunStyle
{
  /// <summary>
  ///   Plain.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Math.StyleValues.Plain))]
  Plain,
  /// <summary>
  ///   Bold.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Math.StyleValues.Bold))]
  Bold,
  /// <summary>
  ///   Italic.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Math.StyleValues.Italic))]
  Italic,
  /// <summary>
  ///   Bold-Italic.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Math.StyleValues.BoldItalic))]
  BoldItalic
}