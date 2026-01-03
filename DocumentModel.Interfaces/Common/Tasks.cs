namespace DocumentModel;

/// <summary>
///   Defines the Tasks Class.
/// </summary>
public interface Tasks: IModelElement
{
  public Collection<Task>? Items { get; set; }
  public ExtensionList? ExtensionList { get; set; }
}