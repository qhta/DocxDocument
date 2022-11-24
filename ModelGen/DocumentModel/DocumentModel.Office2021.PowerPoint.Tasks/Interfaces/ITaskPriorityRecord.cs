namespace DocumentModel.Office2021.PowerPoint.Tasks;

/// <summary>
/// Defines the TaskPriorityRecord Class.
/// </summary>
public interface ITaskPriorityRecord // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// val, this property is only available in Office 2021 and later.
  /// </summary>
  public Int32? Val { get ; set; }
  
}
