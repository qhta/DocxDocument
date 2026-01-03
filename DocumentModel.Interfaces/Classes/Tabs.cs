namespace DocumentModel;

/// <summary>
///   Represents a collection of tabs that define the main ribbon interface structure.
/// </summary>
/// <remarks>
///   This interface extends <see cref="IModelElement"/> and provides access to a collection
///   of <see cref="Tab"/> objects. These tabs form the primary navigation structure in the
///   ribbon UI, displaying groups of related commands and controls.
/// </remarks>
public interface Tabs : IModelElement
{
  /// <summary>
  ///   Gets or sets the collection of tab items that make up the ribbon interface.
  /// </summary>
  /// <value>
  ///   A collection of <see cref="Tab"/> objects, or <c>null</c> if no tabs are defined.
  /// </value>
  public Collection<Tab>? Items { get; set; }
}