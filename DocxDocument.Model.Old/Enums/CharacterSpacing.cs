namespace DocxDocument.Model;

[JsonConverter(typeof(StringEnumConverter))]
public enum CharacterSpacing
{
  /// <summary>
  /// Do not Compress Whitespaces.
  /// </summary>
  DoNotCompress = 0,

  /// <summary>
  /// Compress Whitespace From Punctuation Characters.
  /// </summary>
  CompressPunctuation = 1,

  /// <summary>
  /// Compress Whitespace From Both Japanese Kana And Punctuation Characters.
  /// </summary>
  CompressPunctuationAndJapaneseKana = 2,
}