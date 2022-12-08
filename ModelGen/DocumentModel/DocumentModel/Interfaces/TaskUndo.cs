namespace DocumentModel;

/// <summary>
/// Defines the TaskUndo Class.
/// </summary>
public interface TaskUndo
{
  /// <summary>
  /// id, this property is only available in Office 2021 and later.
  /// </summary>
  public String? Id { get ; set; }
  
}
