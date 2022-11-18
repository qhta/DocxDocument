namespace DocumentModel.Office2021.PowerPoint.Tasks;

/// <summary>
/// Defines the TaskUndo Class.
/// </summary>
public interface ITaskUndo // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// id, this property is only available in Office 2021 and later.
  /// </summary>
  public string? Id { get ; set; }
  
}
