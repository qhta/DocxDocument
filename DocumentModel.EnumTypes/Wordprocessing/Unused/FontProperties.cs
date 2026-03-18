namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the FontProperties enumeration.
/// Used in types such as Find, FontProperties, Fonts.
/// </summary>
[Flags]
[OpenXmlNotMapped]
[JsonConverter(typeof(StringEnumConverter))]
public enum FontProperties
{
  /// <summary>Font name</summary>
  [OpenXmlEnumValue("Name")]
  Name = 1,
  /// <summary>Font size</summary>
  [OpenXmlEnumValue("Size")]
  Size = 2,
  /// <summary>Bold</summary>
  [OpenXmlEnumValue("Bold")]
  Bold = 4,
  /// <summary>Italic</summary>
  [OpenXmlEnumValue("Italic")]
  Italic = 8,
  /// <summary>Underline</summary>
  [OpenXmlEnumValue("Underline")]
  Underline = 16,
  /// <summary>Color</summary>
  [OpenXmlEnumValue("Color")]
  Color = 32,
  /// <summary>All properties</summary>
  [OpenXmlEnumValue("All")]
  All = 0xFFFF
}
