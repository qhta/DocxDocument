namespace DocumentModel;


/// <summary>
///   Defines the BackstageGroups Class.
/// </summary>
public partial class BackstageGroups
{
  public DocumentModel.TaskFormGroup? TaskFormGroup { get; set; }
  
  public DocumentModel.ElementCollection<DocumentModel.IModelElement>? Items { get; set; }
  
}
