namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TextOrientation enumeration.
/// Used to represent Open XML mapped options.
/// </summary>
[OpenXmlNotMapped]
[JsonConverter(typeof(StringEnumConverter))]
public enum TextOrientation
{
  /// <summary>Horizontal text</summary>
  [OpenXmlEnumValue("Horizontal")]
  Horizontal = 1,
  /// <summary>Text rotated 90 degrees upward</summary>
  [OpenXmlEnumValue("Upward")]
  Upward,
  /// <summary>Text rotated 90 degrees downward</summary>
  [OpenXmlEnumValue("Downward")]
  Downward,
  /// <summary>
  /// Vertical as required for Far East language support.
  /// </summary>
  [OpenXmlEnumValue("VerticalFarEast")]
  VerticalFarEast = 4,
  /// <summary>
  /// Vertical.
  /// </summary>
  [OpenXmlEnumValue("Vertical")]
  Vertical = 5,
  /// <summary>
  /// Horizontal and rotated as required for Far East language support.
  /// </summary>
  [OpenXmlEnumValue("HorizontalRotatedFarEast")]
  HorizontalRotatedFarEast = 6
}
