namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the FontFamilyValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.FontFamilyValues))]
public enum FontFamily
{
  /// <summary>
  ///   Novelty Font.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.FontFamilyValues.Decorative))]
  Decorative,
  /// <summary>
  ///   Monospace Font.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.FontFamilyValues.Modern))]
  Modern,
  /// <summary>
  ///   Proportional Font With Serifs.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.FontFamilyValues.Roman))]
  Roman,
  /// <summary>
  ///   Script Font.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.FontFamilyValues.Script))]
  Script,
  /// <summary>
  ///   Proportional Font Without Serifs.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.FontFamilyValues.Swiss))]
  Swiss,
  /// <summary>
  ///   No Font Family.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.FontFamilyValues.Auto))]
  Auto
}