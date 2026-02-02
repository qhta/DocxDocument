namespace DocumentModel.Math;
/// <summary>
///   Defines the StyleValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXM.StyleValues))]
public enum RunStyle
{
  /// <summary>
  ///   Plain.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXM.StyleValues.Plain))]
  Plain,
  /// <summary>
  ///   Bold.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXM.StyleValues.Bold))]
  Bold,
  /// <summary>
  ///   Italic.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXM.StyleValues.Italic))]
  Italic,
  /// <summary>
  ///   Bold-Italic.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXM.StyleValues.BoldItalic))]
  BoldItalic
}