namespace DocumentModel;

/// <summary>
///   Represents a radio group control that provides mutually exclusive selection options.
/// </summary>
/// <remarks>
///   This interface extends <see cref="IModelElement"/> and defines a control that presents a set
///   of radio button options where only one item can be selected at a time. Radio groups are commonly
///   used in backstage views and other Office UI contexts to allow users to choose from a predefined
///   set of mutually exclusive options. The control supports both static and dynamic content generation,
///   with options for customizable labels, layout expansion, keyboard shortcuts, and enabled/visible states
///   that can be controlled through static properties or dynamic callbacks.
///   This functionality is available in Office 2010 and later versions.
/// </remarks>
public interface RadioGroup : IModelElement
{
  /// <summary>
  ///   Gets or sets the unique identifier for this radio group.
  /// </summary>
  /// <value>
  ///   A string containing the identifier, or <c>null</c> if no identifier is specified.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  /// </remarks>
  public string? Id { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier for this radio group.
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
  ///   The tag can be used to store application-specific information associated with this radio group.
  /// </remarks>
  public string? Tag { get; set; }

  /// <summary>
  ///   Gets or sets the alignment behavior of the radio group label.
  /// </summary>
  /// <value>
  ///   An <see cref="ExpandKind"/> value specifying how the label aligns or expands,
  ///   or <c>null</c> to use the default alignment behavior.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  ///   This controls whether the label expands horizontally, vertically, or both to utilize available layout space.
  /// </remarks>
  public ExpandKind? AlignLabel { get; set; }

  /// <summary>
  ///   Gets or sets the expansion behavior of the radio group.
  /// </summary>
  /// <value>
  ///   An <see cref="ExpandKind"/> value specifying how the radio group expands to fill available space,
  ///   or <c>null</c> to use the default expansion behavior.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  ///   This controls whether the radio group expands horizontally, vertically, or both to utilize available layout space.
  /// </remarks>
  public ExpandKind? Expand { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the radio group is enabled and can be interacted with.
  /// </summary>
  /// <value>
  ///   <c>true</c> if the radio group is enabled; <c>false</c> if disabled; or <c>null</c> to use the default enabled state.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  /// </remarks>
  public bool? Enabled { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines whether the radio group is enabled.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if the enabled state is not determined dynamically.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  ///   The callback function should return a boolean value indicating whether the radio group should be enabled.
  /// </remarks>
  public string? GetEnabled { get; set; }

  /// <summary>
  ///   Gets or sets the display label for the radio group.
  /// </summary>
  /// <value>
  ///   A string containing the label text, or <c>null</c> if no label is specified.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  ///   The label is typically displayed above or beside the radio button options.
  /// </remarks>
  public string? Label { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the radio group's label.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if the label is not determined dynamically.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  ///   The callback function should return a string value for the label.
  /// </remarks>
  public string? GetLabel { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the radio group is visible.
  /// </summary>
  /// <value>
  ///   <c>true</c> if the radio group is visible; <c>false</c> if hidden; or <c>null</c> to use the default visibility.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  /// </remarks>
  public bool? Visible { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the radio group's visibility.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if visibility is not determined dynamically.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  ///   The callback function should return a boolean value indicating whether the radio group should be visible.
  /// </remarks>
  public string? GetVisible { get; set; }

  /// <summary>
  ///   Gets or sets the name of the callback function executed when a radio button selection changes.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if no action is defined.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  ///   The callback function is invoked when the user selects a different radio button within the group.
  /// </remarks>
  public string? OnAction { get; set; }

  /// <summary>
  ///   Gets or sets the keyboard shortcut (keytip) for accessing the radio group.
  /// </summary>
  /// <value>
  ///   A string containing the keytip character(s), or <c>null</c> if no keytip is specified.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  ///   Keytips are displayed when the user presses the Alt key and provide keyboard-based navigation.
  /// </remarks>
  public string? Keytip { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the radio group's keytip.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if the keytip is not determined dynamically.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  ///   The callback function should return a string value for the keytip.
  /// </remarks>
  public string? GetKeytip { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that returns the index of the currently selected radio button.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if not tracking selection by index.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  ///   The callback function should return an integer index of the selected radio button (zero-based).
  /// </remarks>
  public string? GetSelectedItemIndex { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that returns the total number of radio button items in the group.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if using static items.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  ///   The callback function should return an integer representing the item count.
  ///   Use this for dynamically generated radio button content.
  /// </remarks>
  public string? GetItemCount { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that returns the label for a specific radio button item.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if not using dynamic labels.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  ///   The callback function receives an item index and should return a string label for that radio button.
  /// </remarks>
  public string? GetItemLabel { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that returns the unique identifier for a specific radio button item.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if not using dynamic item IDs.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  ///   The callback function receives an item index and should return a string identifier for that radio button.
  /// </remarks>
  public string? GetItemID { get; set; }

  /// <summary>
  ///   Gets or sets the collection of radio button items displayed in the group.
  /// </summary>
  /// <value>
  ///   A collection of <see cref="BackstageItemType"/> objects, or <c>null</c> if using dynamic content generation.
  /// </value>
  public Collection<BackstageItemType>? RadioButtonBackstageItems { get; set; }
}