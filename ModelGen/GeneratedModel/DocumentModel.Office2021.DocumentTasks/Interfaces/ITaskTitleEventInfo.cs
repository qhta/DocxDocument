namespace DocumentModel.Office2021.DocumentTasks;

/// <summary>
/// Defines the TaskTitleEventInfo Class.
/// </summary>
public interface ITaskTitleEventInfo // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// title, this property is only available in Office 2021 and later.
  /// </summary>
  public string? Title { get ; set; }
  
}
