namespace DocumentModel;

/// <summary>
/// Defines the Tasks Class.
/// </summary>
public interface Tasks
{
  public Collection<DocumentModel.Task>? Items { get ; set; }
  
  public DocumentModel.ExtensionList? ExtensionList { get ; set; }
  
}
