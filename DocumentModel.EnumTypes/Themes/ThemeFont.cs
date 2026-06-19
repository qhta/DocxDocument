namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the ThemeFontValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.ThemeFontValues))]
public enum ThemeFont
{
  /// <summary>
  ///   Major ASCII Theme Font.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.ThemeFontValues.MajorAscii))]
  MajorAscii,
  /// <summary>
  ///   Major High ANSI Theme Font.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.ThemeFontValues.MajorHighAnsi))]
  MajorHighAnsi,
  /// <summary>
  ///   Major East Asian Theme Font.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.ThemeFontValues.MajorEastAsia))]
  MajorEastAsia,
  /// <summary>
  ///   Major Complex Script Theme Font.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.ThemeFontValues.MajorBidi))]
  MajorComplexScript,
  /// <summary>
  ///   Minor ASCII Theme Font.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.ThemeFontValues.MinorAscii))]
  MinorAscii,
  /// <summary>
  ///   Minor High ANSI Theme Font.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.ThemeFontValues.MinorHighAnsi))]
  MinorHighAnsi,
  /// <summary>
  ///   Minor East Asian Theme Font.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.ThemeFontValues.MinorEastAsia))]
  MinorEastAsia,
  /// <summary>
  ///   Minor Complex Script Theme Font.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.ThemeFontValues.MinorBidi))]
  MinorComplexScript,


}