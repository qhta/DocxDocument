namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the ProofingErrorValues enumeration.
/// </summary>
public enum ProofingErrorValues
{
  /// <summary>
  /// Start of Region Marked as Spelling Error.
  /// </summary>
  [XmlEnum("spellStart")]
  SpellStart,
  
  /// <summary>
  /// End of Region Marked as Spelling Error.
  /// </summary>
  [XmlEnum("spellEnd")]
  SpellEnd,
  
  /// <summary>
  /// Start of Region Marked as Grammatical Error.
  /// </summary>
  [XmlEnum("gramStart")]
  GrammarStart,
  
  /// <summary>
  /// End of Region Marked as Grammatical Error.
  /// </summary>
  [XmlEnum("gramEnd")]
  GrammarEnd,
  
}
