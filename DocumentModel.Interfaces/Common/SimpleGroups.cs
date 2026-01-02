namespace DocumentModel;

/// <summary>
///   Defines the SimpleGroups Class.
/// </summary>
public class SimpleGroups: ModelElement
{
  public BackstageGroup? BackstageGroup { get; set; }
  public TaskGroup? TaskGroup { get; set; }
}