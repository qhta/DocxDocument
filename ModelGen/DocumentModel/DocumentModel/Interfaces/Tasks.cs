namespace DocumentModel;

/// <summary>
/// Defines the Tasks Class.
/// </summary>
public interface Tasks // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<Task>? Tasks { get ; set; }
  
  public ExtensionList? ExtensionList { get ; set; }
  
}
