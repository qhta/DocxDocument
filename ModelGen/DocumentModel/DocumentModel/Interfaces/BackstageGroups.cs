namespace DocumentModel;

/// <summary>
/// Defines the BackstageGroups Class.
/// </summary>
public partial interface BackstageGroups
{
  public DocumentModel.TaskFormGroup? TaskFormGroup { get; set; }
  
  public DocumentModel.BackstageGroup? BackstageGroup { get; set; }
  
  public DocumentModel.TaskGroup? TaskGroup { get; set; }
  
}
