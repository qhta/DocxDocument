namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the spelling and grammatical checking state for a Wordprocessing document.
/// This interface provides properties for tracking the state of spell checking and grammar checking, enabling applications to determine the proofing status of document content.
/// </summary>
public interface ProofState
{
  /// <summary>
  /// Spell checking state, indicating the status of spelling checks in the document.
  /// </summary>
  public ProofingStateKind? Spelling { get; set; }

  /// <summary>
  /// Grammatical checking state, indicating the status of grammar checks in the document.
  /// </summary>
  public ProofingStateKind? Grammar { get; set; }
}