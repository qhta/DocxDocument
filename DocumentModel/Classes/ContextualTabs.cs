namespace DocumentModel;

/// <summary>
///   Defines the ContextualTabs Class.
/// </summary>
public record ContextualTabs
{
  public Collection<TabSet>? TabSets { get; set; }
}