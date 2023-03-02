namespace DocumentModel;

/// <summary>
///   Defines the SimpleGroups Class.
/// </summary>
public record SimpleGroups
{
  public BackstageGroup? BackstageGroup { get; set; }

  public TaskGroup? TaskGroup { get; set; }
}