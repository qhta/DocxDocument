namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the ProofingErrorValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum ProofingErrorKind
{
  /// <summary>
  ///   Start of Region Marked as Spelling Error.
  /// </summary>
  SpellStart,

  /// <summary>
  ///   End of Region Marked as Spelling Error.
  /// </summary>
  SpellEnd,

  /// <summary>
  ///   Start of Region Marked as Grammatical Error.
  /// </summary>
  GrammarStart,

  /// <summary>
  ///   End of Region Marked as Grammatical Error.
  /// </summary>
  GrammarEnd
}