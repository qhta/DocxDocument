namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the ThemeFontValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.ThemeFontValues))]
public enum ThemeFontKind
{
  /// <summary>
  ///   Major East Asian Theme Font.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.ThemeFontValues.MajorEastAsia))]
  MajorEastAsia,
  /// <summary>
  ///   Major Complex Script Theme Font.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.ThemeFontValues.MajorBidi))]
  MajorBidi,
  /// <summary>
  ///   Major ASCII Theme Font.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.ThemeFontValues.MajorAscii))]
  MajorAscii,
  /// <summary>
  ///   Major High ANSI Theme Font.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.ThemeFontValues.MajorHighAnsi))]
  MajorHighAnsi,
  /// <summary>
  ///   Minor East Asian Theme Font.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.ThemeFontValues.MinorEastAsia))]
  MinorEastAsia,
  /// <summary>
  ///   Minor Complex Script Theme Font.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.ThemeFontValues.MinorBidi))]
  MinorBidi,
  /// <summary>
  ///   Minor ASCII Theme Font.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.ThemeFontValues.MinorAscii))]
  MinorAscii,
  /// <summary>
  ///   Minor High ANSI Theme Font.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.ThemeFontValues.MinorHighAnsi))]
  MinorHighAnsi
}