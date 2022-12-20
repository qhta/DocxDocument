namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the MarkupType Class.
/// </summary>
public partial class MarkupTypeImpl: ModelElementImpl, MarkupType
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Wordprocessing.MarkupType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.MarkupType?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public MarkupTypeImpl(): base() {}
  
  public MarkupTypeImpl(DocumentFormat.OpenXml.Wordprocessing.MarkupType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  public String? Id
  {
    get => (System.String?)OpenXmlElement?.Id?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Id = (System.String?)value;
    }
  }
  
}
