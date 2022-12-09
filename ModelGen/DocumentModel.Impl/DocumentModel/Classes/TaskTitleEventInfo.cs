namespace DocumentModel;

/// <summary>
/// Defines the TaskTitleEventInfo Class.
/// </summary>
public class TaskTitleEventInfoImpl: ModelElementImpl, TaskTitleEventInfo
{
  public DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskTitleEventInfo? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskTitleEventInfo?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// title, this property is only available in Office 2021 and later.
  /// </summary>
  public String? Title
  {
    get => (String?)OpenXmlElement?.Title?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Title = (System.String?)value;
    }
  }
  
}
