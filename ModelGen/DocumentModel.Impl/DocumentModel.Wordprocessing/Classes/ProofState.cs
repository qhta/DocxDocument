namespace DocumentModel.Wordprocessing;

/// <summary>
/// Spelling and Grammatical Checking State.
/// </summary>
public class ProofStateImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.ProofState>, ProofState
{
  /// <summary>
  /// Spell Checking State
  /// </summary>
  public ProofingStateKind? Spelling
  {
    get => (ProofingStateKind?)OpenXmlElement?.Spelling?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Spelling = (DocumentFormat.OpenXml.Wordprocessing.ProofingStateValues?)value;
    }
  }
  
  /// <summary>
  /// Grammatical Checking State
  /// </summary>
  public ProofingStateKind? Grammar
  {
    get => (ProofingStateKind?)OpenXmlElement?.Grammar?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Grammar = (DocumentFormat.OpenXml.Wordprocessing.ProofingStateValues?)value;
    }
  }
  
}
