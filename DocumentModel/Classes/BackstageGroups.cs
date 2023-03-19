namespace DocumentModel;

/// <summary>
///   Defines the BackstageGroups Class.
/// </summary>
public class BackstageGroups: ModelElement
{
  public TaskFormGroup? TaskFormGroup { get; set; }

  public BackstageGroup? BackstageGroup { get; set; }

  public TaskGroup? TaskGroup { get; set; }
}