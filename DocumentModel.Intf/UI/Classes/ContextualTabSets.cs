namespace DocumentModel.UI;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the ContextualTabSets Class.
/// </summary>
public class ContextualTabSets: ModelElement
{
  public Collection<ContextualTabSet>? Items { get; set; }
}