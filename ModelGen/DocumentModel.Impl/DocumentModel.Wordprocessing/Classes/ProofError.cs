namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the ProofError Class.
/// </summary>
public partial class ProofErrorImpl: ModelElementImpl, ProofError
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Wordprocessing.ProofError? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.ProofError?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public ProofErrorImpl(): base() {}
  
  public ProofErrorImpl(DocumentFormat.OpenXml.Wordprocessing.ProofError openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Proofing Error Anchor Type
  /// </summary>
  public DocumentModel.Wordprocessing.ProofingErrorKind? Type
  {
    get => (DocumentModel.Wordprocessing.ProofingErrorKind?)OpenXmlElement?.Type?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Type = (DocumentFormat.OpenXml.Wordprocessing.ProofingErrorValues?)value;
    }
  }
  
}
