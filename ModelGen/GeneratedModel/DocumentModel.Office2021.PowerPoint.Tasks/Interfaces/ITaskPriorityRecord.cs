namespace DocumentModel.Office2021.PowerPoint.Tasks;

/// <summary>
/// Defines the TaskPriorityRecord Class.
/// </summary>
public interface ITaskPriorityRecord // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// val, this property is only available in Office 2021 and later.
  /// </summary>
  public int? Val { get ; set; }
  
}
