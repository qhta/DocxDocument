namespace DocumentModel.UI;

/// <summary>
///   Defines the ContextualTabSets Class.
/// </summary>
public record ContextualTabSets
{
  public Collection<ContextualTabSet>? Items { get; set; }
}