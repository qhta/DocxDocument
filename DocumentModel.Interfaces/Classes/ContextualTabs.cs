namespace DocumentModel;

/// <summary>
///   Represents a collection of contextual tab sets that appear in the ribbon UI based on context.
/// </summary>
/// <remarks>
///   This interface extends <see cref="IModelElement"/> and provides access to a collection
///   of <see cref="TabSet"/> objects. Contextual tabs typically appear in the ribbon interface
///   when specific objects or elements are selected, providing context-sensitive commands and tools.
/// </remarks>
public interface ContextualTabs : IModelElement
{
  /// <summary>
  ///   Gets or sets the collection of tab sets that define contextual ribbon tabs.
  /// </summary>
  /// <value>
  ///   A collection of <see cref="TabSet"/> objects, or <c>null</c> if no contextual tabs are defined.
  /// </value>
  public Collection<TabSet>? TabSets { get; set; }
}