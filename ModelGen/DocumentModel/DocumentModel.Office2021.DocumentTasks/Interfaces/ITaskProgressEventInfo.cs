namespace DocumentModel.Office2021.DocumentTasks;

/// <summary>
/// Defines the TaskProgressEventInfo Class.
/// </summary>
public interface ITaskProgressEventInfo // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// percentComplete, this property is only available in Office 2021 and later.
  /// </summary>
  public System.Int32? PercentComplete { get ; set; }
  
}
