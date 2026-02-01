namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the CharacterSpacingValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.CharacterSpacingValues))]
public enum CharacterSpacingKind
{
  /// <summary>
  ///   Do Not Compress Whitespace.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.CharacterSpacingValues.DoNotCompress))]
  DoNotCompress,
  /// <summary>
  ///   Compress Whitespace From Punctuation Characters.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.CharacterSpacingValues.CompressPunctuation))]
  CompressPunctuation,
  /// <summary>
  ///   Compress Whitespace From Both Japanese Kana And Punctuation Characters.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.CharacterSpacingValues.CompressPunctuationAndJapaneseKana))]
  CompressPunctuationAndJapaneseKana
}