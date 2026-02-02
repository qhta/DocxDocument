namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the FontFamilyValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.FontFamilyValues))]
public enum FontFamily
{
  /// <summary>
  ///   Novelty Font.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.FontFamilyValues.Decorative))]
  Decorative,
  /// <summary>
  ///   Monospace Font.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.FontFamilyValues.Modern))]
  Modern,
  /// <summary>
  ///   Proportional Font With Serifs.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.FontFamilyValues.Roman))]
  Roman,
  /// <summary>
  ///   Script Font.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.FontFamilyValues.Script))]
  Script,
  /// <summary>
  ///   Proportional Font Without Serifs.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.FontFamilyValues.Swiss))]
  Swiss,
  /// <summary>
  ///   No Font Family.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.FontFamilyValues.Auto))]
  Auto
}