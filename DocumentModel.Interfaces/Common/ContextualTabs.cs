namespace DocumentModel;

/// <summary>
///   Defines the ContextualTabs Class.
/// </summary>
public interface ContextualTabs: IModelElement
{
  public Collection<TabSet>? TabSets { get; set; }
}