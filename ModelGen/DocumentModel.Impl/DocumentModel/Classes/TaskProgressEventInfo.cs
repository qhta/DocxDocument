namespace DocumentModel;

/// <summary>
/// Defines the TaskProgressEventInfo Class.
/// </summary>
public class TaskProgressEventInfoImpl: ModelElementImpl, TaskProgressEventInfo
{
  public DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskProgressEventInfo? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskProgressEventInfo?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// percentComplete, this property is only available in Office 2021 and later.
  /// </summary>
  public Int32? PercentComplete
  {
    get;
    set;
  }
  
}
