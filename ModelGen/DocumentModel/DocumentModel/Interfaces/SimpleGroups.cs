namespace DocumentModel;

/// <summary>
/// Defines the SimpleGroups Class.
/// </summary>
public partial interface SimpleGroups
{
  public DocumentModel.BackstageGroup? BackstageGroup { get; set; }
  
  public DocumentModel.TaskGroup? TaskGroup { get; set; }
  
}
