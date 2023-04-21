namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the CharacterSpacingValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum CharacterSpacingKind
{
  /// <summary>
  ///   Do Not Compress Whitespace.
  /// </summary>
  DoNotCompress,

  /// <summary>
  ///   Compress Whitespace From Punctuation Characters.
  /// </summary>
  CompressPunctuation,

  /// <summary>
  ///   Compress Whitespace From Both Japanese Kana And Punctuation Characters.
  /// </summary>
  CompressPunctuationAndJapaneseKana
}