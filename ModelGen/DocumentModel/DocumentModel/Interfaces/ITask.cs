namespace DocumentModel;

/// <summary>
/// Defines the Task Class.
/// </summary>
public interface ITask // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// id, this property is only available in Office 2021 and later.
  /// </summary>
  public String? Id { get ; set; }
  
  /// <summary>
  /// TaskAnchor.
  /// </summary>
  public ITaskAnchor? TaskAnchor { get ; set; }
  
  /// <summary>
  /// TaskHistory.
  /// </summary>
  public ITaskHistory? TaskHistory { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}
