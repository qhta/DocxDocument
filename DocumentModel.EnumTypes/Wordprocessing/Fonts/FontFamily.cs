namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the FontFamilyValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.FontFamilyValues))]
public enum FontFamily
{

  /// <summary>
  ///   No Font Family.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.FontFamilyValues.Auto))]
  Auto = 0,

  /// <summary>
  ///   Proportional Font With Serifs.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.FontFamilyValues.Roman))]
  Roman = 1,

  /// <summary>
  ///   Proportional Font Without Serifs.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.FontFamilyValues.Swiss))]
  Swiss = 2,

  /// <summary>
  ///   Monospace Font.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.FontFamilyValues.Modern))]
  Modern = 3,
  
  /// <summary>
  ///   Script Font.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.FontFamilyValues.Script))]
  Script = 4,

  /// <summary>
  ///   Novelty Font.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.FontFamilyValues.Decorative))] 
  Decorative = 5,
}