namespace DocumentModel;

/// <summary>
///   Defines the Tasks Class.
/// </summary>
public class Tasks: ModelElement
{
  public Collection<Task>? Items { get; set; }

  public ExtensionList? ExtensionList { get; set; }
}