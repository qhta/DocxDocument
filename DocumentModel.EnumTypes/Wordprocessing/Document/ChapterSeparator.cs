namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the ChapterSeparatorValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.ChapterSeparatorValues))]
public enum ChapterSeparator
{
  /// <summary>
  ///   Hyphen Chapter Separator.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.ChapterSeparatorValues.Hyphen))]
  Hyphen,
  /// <summary>
  ///   Period Chapter Separator.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.ChapterSeparatorValues.Period))]
  Period,
  /// <summary>
  ///   Colon Chapter Separator.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.ChapterSeparatorValues.Colon))]
  Colon,
  /// <summary>
  ///   Em Dash Chapter Separator.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.ChapterSeparatorValues.EmDash))]
  EmDash,
  /// <summary>
  ///   En Dash Chapter Separator.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.ChapterSeparatorValues.EnDash))]
  EnDash
}