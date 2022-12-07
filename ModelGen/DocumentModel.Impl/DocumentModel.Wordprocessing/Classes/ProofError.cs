namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the ProofError Class.
/// </summary>
public class ProofErrorImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.ProofError>, ProofError
{
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
