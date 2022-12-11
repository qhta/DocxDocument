namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the MarkupType Class.
/// </summary>
public class MarkupTypeImpl: ModelElementImpl, MarkupType
{
  public DocumentFormat.OpenXml.Office2010.Word.MarkupType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Word.MarkupType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public MarkupTypeImpl(): base() {}
  
  public MarkupTypeImpl(DocumentFormat.OpenXml.Office2010.Word.MarkupType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  public String? Id
  {
    get => (String?)OpenXmlElement?.Id?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Id = (System.String?)value;
    }
  }
  
}
