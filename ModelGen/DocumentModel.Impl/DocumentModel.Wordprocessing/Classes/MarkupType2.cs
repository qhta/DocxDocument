namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the MarkupType Class.
/// </summary>
public partial class MarkupType2Impl: ModelElementImpl, MarkupType2
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2010.Word.MarkupType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Word.MarkupType?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public MarkupType2Impl(): base() {}
  
  public MarkupType2Impl(DocumentFormat.OpenXml.Office2010.Word.MarkupType openXmlElement): base(openXmlElement)
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
