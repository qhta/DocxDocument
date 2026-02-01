namespace DocumentModel.Drawings;
/// <summary>
///   Blend Mode
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXD.BlendModeValues))]
public enum BlendMode
{
  /// <summary>
  ///   Overlay.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.BlendModeValues.Overlay))]
  Overlay,
  /// <summary>
  ///   Multiply.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.BlendModeValues.Multiply))]
  Multiply,
  /// <summary>
  ///   Screen.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.BlendModeValues.Screen))]
  Screen,
  /// <summary>
  ///   Darken.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.BlendModeValues.Darken))]
  Darken,
  /// <summary>
  ///   Lighten.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.BlendModeValues.Lighten))]
  Lighten
}