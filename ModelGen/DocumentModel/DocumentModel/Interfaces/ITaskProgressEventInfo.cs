namespace DocumentModel;

/// <summary>
/// Defines the TaskProgressEventInfo Class.
/// </summary>
public interface ITaskProgressEventInfo // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// percentComplete, this property is only available in Office 2021 and later.
  /// </summary>
  public Int32? PercentComplete { get ; set; }
  
}
