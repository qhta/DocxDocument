namespace DocumentModel.Wordprocessing;

/// <summary>
/// Spelling and Grammatical Checking State.
/// </summary>
public partial class ProofStateImpl: ModelElementImpl, ProofState
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Wordprocessing.ProofState? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.ProofState?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public ProofStateImpl(): base() {}
  
  public ProofStateImpl(DocumentFormat.OpenXml.Wordprocessing.ProofState openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Spell Checking State
  /// </summary>
  public DocumentModel.Wordprocessing.ProofingStateKind? Spelling
  {
    get => (DocumentModel.Wordprocessing.ProofingStateKind?)OpenXmlElement?.Spelling?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Spelling = (DocumentFormat.OpenXml.Wordprocessing.ProofingStateValues?)value;
    }
  }
  
  /// <summary>
  /// Grammatical Checking State
  /// </summary>
  public DocumentModel.Wordprocessing.ProofingStateKind? Grammar
  {
    get => (DocumentModel.Wordprocessing.ProofingStateKind?)OpenXmlElement?.Grammar?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Grammar = (DocumentFormat.OpenXml.Wordprocessing.ProofingStateValues?)value;
    }
  }
  
}
