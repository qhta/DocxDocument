namespace DocumentModel;

/// <summary>
/// Defines the Tasks Class.
/// </summary>
public partial interface Tasks
{
  public Collection<DocumentModel.Task>? Items { get; set; }
  
  public DocumentModel.ExtensionList? ExtensionList { get; set; }
  
}
