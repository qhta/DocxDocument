namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the DocGrid Class.
/// </summary>
public class DocGridImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.DocGrid>, DocGrid
{
  /// <summary>
  /// Document Grid Type
  /// </summary>
  public DocGridKind? Type
  {
    get => (DocGridKind?)OpenXmlElement?.Type?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Type = (DocumentFormat.OpenXml.Wordprocessing.DocGridValues?)value;
    }
  }
  
}
