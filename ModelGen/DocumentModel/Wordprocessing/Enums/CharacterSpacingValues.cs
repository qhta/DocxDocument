namespace DXW;


/// <summary>
///   Defines the CharacterSpacingValues enumeration.
/// </summary>
public enum CharacterSpacingValues
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;doNotCompress&quot;.
  /// </summary>
  [EnumString("doNotCompress")]
  DoNotCompress,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;compressPunctuation&quot;.
  /// </summary>
  [EnumString("compressPunctuation")]
  CompressPunctuation,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;compressPunctuationAndJapaneseKana&quot;.
  /// </summary>
  [EnumString("compressPunctuationAndJapaneseKana")]
  CompressPunctuationAndJapaneseKana,
  
}
