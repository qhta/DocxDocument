namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the ChapterSeparatorValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.ChapterSeparatorValues))]
public enum ChapterSeparator
{
  /// <summary>
  ///   Hyphen Chapter Separator.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.ChapterSeparatorValues.Hyphen))]
  Hyphen,
  /// <summary>
  ///   Period Chapter Separator.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.ChapterSeparatorValues.Period))]
  Period,
  /// <summary>
  ///   Colon Chapter Separator.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.ChapterSeparatorValues.Colon))]
  Colon,
  /// <summary>
  ///   Em Dash Chapter Separator.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.ChapterSeparatorValues.EmDash))]
  EmDash,
  /// <summary>
  ///   En Dash Chapter Separator.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.ChapterSeparatorValues.EnDash))]
  EnDash
}