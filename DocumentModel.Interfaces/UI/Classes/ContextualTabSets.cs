namespace DocumentModel.UI;

/// <summary>
///   Defines the ContextualTabSets Class.
/// </summary>
public interface ContextualTabSets: IModelElement
{
  public Collection<ContextualTabSet>? Items { get; set; }
}