namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the CharacterSpacingValues enumeration.
/// </summary>
public enum CharacterSpacing
{
  /// <summary>
  /// Do Not Compress Whitespace.
  /// </summary>
  [XmlEnum("doNotCompress")]
  DoNotCompress,
  
  /// <summary>
  /// Compress Whitespace From Punctuation Characters.
  /// </summary>
  [XmlEnum("compressPunctuation")]
  CompressPunctuation,
  
  /// <summary>
  /// Compress Whitespace From Both Japanese Kana And Punctuation Characters.
  /// </summary>
  [XmlEnum("compressPunctuationAndJapaneseKana")]
  CompressPunctuationAndJapaneseKana,
  
}
