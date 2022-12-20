namespace DocumentModel;

/// <summary>
/// Defines the CommentAnchor Class.
/// </summary>
public partial class CommentAnchorImpl: ModelElementImpl, CommentAnchor
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2021.DocumentTasks.CommentAnchor? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2021.DocumentTasks.CommentAnchor?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public CommentAnchorImpl(): base() {}
  
  public CommentAnchorImpl(DocumentFormat.OpenXml.Office2021.DocumentTasks.CommentAnchor openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// id, this property is only available in Office 2021 and later.
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
