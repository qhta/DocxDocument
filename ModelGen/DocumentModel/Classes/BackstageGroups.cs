namespace DocumentModel;


/// <summary>
///   Defines the BackstageGroups Class.
/// </summary>
public partial class BackstageGroups
{
  public TaskFormGroup? TaskFormGroup { get; set; }
  
  public ElementCollection<IModelElement>? Items { get; set; }
  
}
