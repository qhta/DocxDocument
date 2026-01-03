namespace DocumentModel;

/// <summary>
///   Represents a separator control that provides visual division between menu items.
/// </summary>
/// <remarks>
///   This interface extends <see cref="IModelElement"/> and defines a visual divider used to organize
///   and separate groups of related items within menus. Menu separators can optionally display a title
///   to label sections of the menu, providing better organization and improving usability by creating
///   logical groupings of commands. Separators support positioning relative to other menu items and
///   can have their title determined statically or dynamically through callbacks.
///   This functionality is available in Office 2010 and later versions.
/// </remarks>
public interface MenuSeparator : IModelElement
{
  /// <summary>
  ///   Gets or sets the unique identifier for this menu separator.
  /// </summary>
  /// <value>
  ///   A string containing the identifier, or <c>null</c> if no identifier is specified.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  /// </remarks>
  public string? Id { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier for this menu separator.
  /// </summary>
  /// <value>
  ///   A string containing the namespace-qualified identifier, or <c>null</c> if not specified.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  ///   Use this when the identifier needs to be unique across multiple namespaces.
  /// </remarks>
  public string? QualifiedId { get; set; }

  /// <summary>
  ///   Gets or sets an arbitrary tag value for custom data storage.
  /// </summary>
  /// <value>
  ///   A string containing custom tag data, or <c>null</c> if no tag is specified.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  ///   The tag can be used to store application-specific information associated with this menu separator.
  /// </remarks>
  public string? Tag { get; set; }

  /// <summary>
  ///   Gets or sets the Microsoft Office identifier after which this menu separator should be inserted.
  /// </summary>
  /// <value>
  ///   A string containing the Microsoft Office identifier, or <c>null</c> if position is not specified.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  ///   Use this to position the separator relative to a built-in menu item.
  /// </remarks>
  public string? InsertAfterMso { get; set; }

  /// <summary>
  ///   Gets or sets the Microsoft Office identifier before which this menu separator should be inserted.
  /// </summary>
  /// <value>
  ///   A string containing the Microsoft Office identifier, or <c>null</c> if position is not specified.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  ///   Use this to position the separator relative to a built-in menu item.
  /// </remarks>
  public string? InsertBeforeMso { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier after which this menu separator should be inserted.
  /// </summary>
  /// <value>
  ///   A string containing the namespace-qualified identifier, or <c>null</c> if position is not specified.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  ///   Use this to position the separator relative to another custom menu item.
  /// </remarks>
  public string? InsertAfterQualifiedId { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier before which this menu separator should be inserted.
  /// </summary>
  /// <value>
  ///   A string containing the namespace-qualified identifier, or <c>null</c> if position is not specified.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  ///   Use this to position the separator relative to another custom menu item.
  /// </remarks>
  public string? InsertBeforeQualifiedId { get; set; }

  /// <summary>
  ///   Gets or sets the title text displayed on the separator to label a section of the menu.
  /// </summary>
  /// <value>
  ///   A string containing the title text, or <c>null</c> if no title is displayed (simple divider line).
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  ///   When specified, the separator becomes a labeled section header rather than just a dividing line.
  /// </remarks>
  public string? Title { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the separator's title.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if the title is not determined dynamically.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  ///   The callback function should return a string value for the title.
  /// </remarks>
  public string? GetTitle { get; set; }
}