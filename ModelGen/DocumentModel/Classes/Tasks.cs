namespace DocumentModel;


/// <summary>
///   Defines the Tasks Class.
/// </summary>
public partial class Tasks
{
  public DocumentModel.ExtensionList? ExtensionList { get; set; }
  
  public DocumentModel.ElementCollection<DocumentModel.Task>? Items { get; set; }
  
}
