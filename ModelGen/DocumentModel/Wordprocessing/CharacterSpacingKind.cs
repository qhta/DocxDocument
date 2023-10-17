namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the CharacterSpacingValues enumeration.
/// </summary>
public enum CharacterSpacingKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;doNotCompress&quot;.
  /// </summary>
  DoNotCompress,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;compressPunctuation&quot;.
  /// </summary>
  CompressPunctuation,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;compressPunctuationAndJapaneseKana&quot;.
  /// </summary>
  CompressPunctuationAndJapaneseKana,
  
}
