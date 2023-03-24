namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the SimpleGroups Class.
/// </summary>
public class SimpleGroups: ModelElement
{
  public BackstageGroup? BackstageGroup { get; set; }

  public TaskGroup? TaskGroup { get; set; }
}