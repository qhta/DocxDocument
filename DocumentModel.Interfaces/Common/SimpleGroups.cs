namespace DocumentModel;

/// <summary>
///   Defines the SimpleGroups Class.
/// </summary>
public interface SimpleGroups: IModelElement
{
  public BackstageGroup? BackstageGroup { get; set; }
  public TaskGroup? TaskGroup { get; set; }
}