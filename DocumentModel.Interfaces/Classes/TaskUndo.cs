namespace DocumentModel;

/// <summary>
///   Defines the TaskUndo Class.
/// </summary>
public interface TaskUndo: IModelElement
{
  /// <summary>
  ///   id
  /// </summary>
  public string? Id { get; set; }
}