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
  Horizontal,
  /// <summary>Text rotated 90 degrees downward</summary>
  [OpenXmlEnumValue("Downward")]
  Downward,
  /// <summary>Text rotated 90 degrees upward</summary>
  [OpenXmlEnumValue("Upward")]
  Upward,
  /// <summary>Vertical text</summary>
  [OpenXmlEnumValue("Vertical")]
  Vertical,
  /// <summary>Horizontal rotated Far East</summary>
  [OpenXmlEnumValue("HorizontalRotatedFarEast")]
  HorizontalRotatedFarEast
}
