namespace DocumentModel.Wordprocessing;

/// <summary>
/// Spelling and Grammatical Checking State.
/// </summary>
public class ProofStateImpl: ModelElementImpl, ProofState
{
  public DocumentFormat.OpenXml.Wordprocessing.ProofState? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.ProofState?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ProofStateImpl(): base() {}
  
  public ProofStateImpl(DocumentFormat.OpenXml.Wordprocessing.ProofState openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
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
