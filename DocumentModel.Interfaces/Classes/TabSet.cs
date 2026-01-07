namespace DocumentModel;

/// <summary>
///   Represents a set of contextual tabs that appear together in the ribbon UI.
/// </summary>
/// <remarks>
///   This interface defines a group of related tabs
///   that are displayed as a unit in the ribbon interface. Tab sets are typically used for
///   contextual tabs that appear when specific objects or elements are selected.
/// </remarks>
public interface TabSet : CollectionItem, ElementCollection<Tabs>
{
  /// <summary>
  ///   Gets or sets the identifier for a built-in Microsoft Office tab set.
  /// </summary>
  public string? IdMso { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the tab set is visible in the ribbon UI.
  /// </summary>
  public bool? Visible { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the tab set's visibility.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a boolean value indicating whether the tab set should be visible.
  /// </remarks>
  public string? GetVisible { get; set; }

}