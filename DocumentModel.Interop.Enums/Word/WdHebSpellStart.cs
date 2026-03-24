namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies which rules the Hebrew spelling checker will follow.
/// </summary>
public enum WdHebSpellStart
{
  /// <summary>
  /// The spelling checker follows rules for the conventional script required by the Hebrew Language Academy for
  /// writing text without diacritics.
  /// </summary>
  FullScript = unchecked((int)0),
  /// <summary>
  /// The spelling checker follows rules for the traditional script used only for text with diacritics.
  /// </summary>
  PartialScript = unchecked((int)1),
  /// <summary>
  /// The spelling checker follows rules for full and partial script and allows non-conventional spelling
  /// variations. Only completely unrecognized words are highlighted as potential mistakes. wdMixedAuthorizedScript3
  /// The spelling checker follows rules for full and partial script, but highlights as potential mistakes any
  /// spelling variations not permitted within either system and any completely unrecognized words.
  /// </summary>
  MixedScript = unchecked((int)2),
  /// <summary>
  /// Specifies which rules the Hebrew spelling checker will follow.
  /// </summary>
  MixedAuthorizedScript = unchecked((int)3)
}
