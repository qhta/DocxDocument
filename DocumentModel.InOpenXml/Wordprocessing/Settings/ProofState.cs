namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the spelling and grammatical checking state for a Wordprocessing document.
/// This class provides properties for tracking the state of spell checking and grammar checking, enabling applications to determine the proofing status of document content.
/// </summary>
[OpenXmlType(typeof(DXW.ProofState))]
[DataContract]
[XmlRoot("ProofState", Namespace = "DocumentModel.Wordprocessing")]
public partial class ProofState: ModelElement<DXW.ProofState>
{
  /// <summary>
  /// Spell checking state, indicating the status of spelling checks in the document.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.ProofState.Spelling))]
  public ProofingState? Spelling
  {
    get => _Spelling ??= GetProperty<ProofingState?>(GetUpdatableElement()?.Spelling);
    set => UpdateField(ref _Spelling, value, nameof(Spelling));
  }

  private ProofingState? _Spelling;

  /// <summary>
  /// Grammatical checking state, indicating the status of grammar checks in the document.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.ProofState.Grammar))]
  public ProofingState? Grammar
  {
    get => _Grammar ??= GetProperty<ProofingState?>(GetUpdatableElement()?.Grammar);
    set => UpdateField(ref _Grammar, value, nameof(Grammar));
  }

  private ProofingState? _Grammar;
}