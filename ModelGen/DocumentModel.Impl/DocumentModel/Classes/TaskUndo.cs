namespace DocumentModel;

/// <summary>
/// Defines the TaskUndo Class.
/// </summary>
public class TaskUndoImpl: ModelElementImpl, TaskUndo
{
  public DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskUndo? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskUndo?)_OpenXmlElement;
    set => _OpenXmlElement = value;
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
