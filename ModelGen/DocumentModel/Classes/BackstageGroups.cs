namespace DocumentModel;


/// <summary>
///   Defines the BackstageGroups Class.
/// </summary>
public partial class BackstageGroups
{
  public DM.TaskFormGroup? TaskFormGroup { get; set; }
  
  public DM.ElementCollection<IModelElement>? Items { get; set; }
  
}
