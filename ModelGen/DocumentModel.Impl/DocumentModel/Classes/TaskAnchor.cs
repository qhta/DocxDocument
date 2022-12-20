namespace DocumentModel;

/// <summary>
/// Defines the TaskAnchor Class.
/// </summary>
public partial class TaskAnchorImpl: ModelElementImpl, TaskAnchor
{
  public DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskAnchor? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskAnchor?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public TaskAnchorImpl(): base() {}
  
  public TaskAnchorImpl(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskAnchor openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// CommentAnchor.
  /// </summary>
  public DocumentModel.CommentAnchor? CommentAnchor
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.CommentAnchor>();
        if (item != null)
          return new DocumentModel.CommentAnchorImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.CommentAnchor>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.CommentAnchorImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.ExtensionList? ExtensionList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.ExtensionList>();
        if (item != null)
          return new DocumentModel.ExtensionListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.ExtensionList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.ExtensionListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
