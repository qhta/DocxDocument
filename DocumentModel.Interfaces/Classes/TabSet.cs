namespace DocumentModel;

/// <summary>
///   Represents a set of contextual tabs that appear together in the ribbon UI.
/// </summary>
/// <remarks>
///   This interface extends <see cref="IModelElement"/> and defines a group of related tabs
///   that are displayed as a unit in the ribbon interface. Tab sets are typically used for
///   contextual tabs that appear when specific objects or elements are selected.
///   This functionality is available in Office 2010 and later versions.
/// </remarks>
public interface TabSet : IModelElement
{
  /// <summary>
  ///   Gets or sets the identifier for a built-in Microsoft Office tab set.
  /// </summary>
  /// <value>
  ///   A string containing the Microsoft Office identifier, or <c>null</c> if not referencing a built-in tab set.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  /// </remarks>
  public string? IdMso { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the tab set is visible in the ribbon UI.
  /// </summary>
  /// <value>
  ///   <c>true</c> if the tab set is visible; <c>false</c> if hidden; or <c>null</c> to use the default visibility.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  /// </remarks>
  public bool? Visible { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the tab set's visibility.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if visibility is not determined dynamically.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  ///   The callback function should return a boolean value indicating whether the tab set should be visible.
  /// </remarks>
  public string? GetVisible { get; set; }

  /// <summary>
  ///   Gets or sets the collection of tabs contained within this tab set.
  /// </summary>
  /// <value>
  ///   A collection of <see cref="Tab"/> objects, or <c>null</c> if no tabs are defined.
  /// </value>
  public Collection<Tab>? Tabs { get; set; }
}