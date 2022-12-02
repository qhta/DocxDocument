namespace DocumentModel;

/// <summary>
/// Defines the TaskTitleEventInfo Class.
/// </summary>
public interface ITaskTitleEventInfo // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// title, this property is only available in Office 2021 and later.
  /// </summary>
  public String? Title { get ; set; }
  
}
