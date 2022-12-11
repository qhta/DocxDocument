namespace DocumentModel;

/// <summary>
/// Defines the CommentAnchor Class.
/// </summary>
public class CommentAnchorImpl: ModelElementImpl, CommentAnchor
{
  public DocumentFormat.OpenXml.Office2021.DocumentTasks.CommentAnchor? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2021.DocumentTasks.CommentAnchor?)_OpenXmlElement;
    set => _OpenXmlElement = value;
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
    get => (String?)OpenXmlElement?.Id?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Id = (System.String?)value;
    }
  }
  
}
