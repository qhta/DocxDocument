namespace DocumentModel;

/// <summary>
/// Defines the TaskUndo Class.
/// </summary>
public interface ITaskUndo // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// id, this property is only available in Office 2021 and later.
  /// </summary>
  public String? Id { get ; set; }
  
}
