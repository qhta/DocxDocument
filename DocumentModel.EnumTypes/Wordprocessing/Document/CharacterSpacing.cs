namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the CharacterSpacingValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.CharacterSpacingValues))]
public enum CharacterSpacing
{
  /// <summary>
  ///   Do Not Compress Whitespace.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.CharacterSpacingValues.DoNotCompress))]
  DoNotCompress,
  /// <summary>
  ///   Compress Whitespace From Punctuation Characters.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.CharacterSpacingValues.CompressPunctuation))]
  CompressPunctuation,
  /// <summary>
  ///   Compress Whitespace From Both Japanese Kana And Punctuation Characters.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.CharacterSpacingValues.CompressPunctuationAndJapaneseKana))]
  CompressPunctuationAndJapaneseKana
}