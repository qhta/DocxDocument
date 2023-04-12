namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Spelling and Grammatical Checking State.
/// </summary>
public class ProofState: ModelElement
{
  /// <summary>
  ///   Spell Checking State
  /// </summary>
  public ProofingStateKind? Spelling { get; set; }

  /// <summary>
  ///   Grammatical Checking State
  /// </summary>
  public ProofingStateKind? Grammar { get; set; }
}