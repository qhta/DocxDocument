namespace DocumentModel.Wordprocessing;

/// <summary>
///   Spelling and Grammatical Checking State.
/// </summary>
public class ProofState
{
  /// <summary>
  ///   Spell Checking State
  /// </summary>
  [XmlAttribute] public ProofingStateKind? Spelling { get; set; }

  /// <summary>
  ///   Grammatical Checking State
  /// </summary>
  [XmlAttribute] public ProofingStateKind? Grammar { get; set; }
}