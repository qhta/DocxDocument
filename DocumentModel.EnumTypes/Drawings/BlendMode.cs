namespace DocumentModel.Drawings;
/// <summary>
///   Blend Mode
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Drawing.BlendModeValues))]
public enum BlendMode
{
  /// <summary>
  ///   Overlay.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.BlendModeValues.Overlay))]
  Overlay,
  /// <summary>
  ///   Multiply.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.BlendModeValues.Multiply))]
  Multiply,
  /// <summary>
  ///   Screen.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.BlendModeValues.Screen))]
  Screen,
  /// <summary>
  ///   Darken.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.BlendModeValues.Darken))]
  Darken,
  /// <summary>
  ///   Lighten.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.BlendModeValues.Lighten))]
  Lighten
}