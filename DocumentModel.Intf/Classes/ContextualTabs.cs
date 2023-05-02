namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the ContextualTabs Class.
/// </summary>
public class ContextualTabs: ModelElement
{
  public Collection<TabSet>? TabSets { get; set; }
}