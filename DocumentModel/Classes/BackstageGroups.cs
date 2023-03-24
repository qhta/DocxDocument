namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the BackstageGroups Class.
/// </summary>
public class BackstageGroups: ModelElement
{
  public TaskFormGroup? TaskFormGroup { get; set; }

  public BackstageGroup? BackstageGroup { get; set; }

  public TaskGroup? TaskGroup { get; set; }
}