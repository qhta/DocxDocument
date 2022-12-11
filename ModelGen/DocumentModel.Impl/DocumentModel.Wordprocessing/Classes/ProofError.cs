namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the ProofError Class.
/// </summary>
public class ProofErrorImpl: ModelElementImpl, ProofError
{
  public DocumentFormat.OpenXml.Wordprocessing.ProofError? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.ProofError?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ProofErrorImpl(): base() {}
  
  public ProofErrorImpl(DocumentFormat.OpenXml.Wordprocessing.ProofError openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Proofing Error Anchor Type
  /// </summary>
  public ProofingErrorKind? Type
  {
    get => (ProofingErrorKind?)OpenXmlElement?.Type?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Type = (DocumentFormat.OpenXml.Wordprocessing.ProofingErrorValues?)value;
    }
  }
  
}
