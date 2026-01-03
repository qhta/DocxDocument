namespace DocumentModel;

/// <summary>
///   Represents a group of buttons and controls within a ribbon group or menu.
/// </summary>
/// <remarks>
///   This interface extends <see cref="IModelElement"/> and defines a container that groups
///   related buttons and controls together within the Office ribbon UI. Button groups allow
///   multiple controls to be visually clustered, providing better organization and efficient
///   use of ribbon space by displaying controls in a compact arrangement.
///   This functionality is available in Office 2010 and later versions.
/// </remarks>
public interface ButtonGroup : IModelElement
{
  /// <summary>
  ///   Gets or sets the unique identifier for this button group.
  /// </summary>
  /// <value>
  ///   A string containing the identifier, or <c>null</c> if no identifier is specified.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  /// </remarks>
  public string? Id { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier for this button group.
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
  ///   The tag can be used to store application-specific information associated with this button group.
  /// </remarks>
  public string? Tag { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the button group is visible.
  /// </summary>
  /// <value>
  ///   <c>true</c> if the button group is visible; <c>false</c> if hidden; or <c>null</c> to use the default visibility.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  /// </remarks>
  public bool? Visible { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the button group's visibility.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if visibility is not determined dynamically.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  ///   The callback function should return a boolean value indicating whether the button group should be visible.
  /// </remarks>
  public string? GetVisible { get; set; }

  /// <summary>
  ///   Gets or sets the Microsoft Office identifier after which this button group should be inserted.
  /// </summary>
  /// <value>
  ///   A string containing the Microsoft Office identifier, or <c>null</c> if position is not specified.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  ///   Use this to position the button group relative to a built-in control.
  /// </remarks>
  public string? InsertAfterMso { get; set; }

  /// <summary>
  ///   Gets or sets the Microsoft Office identifier before which this button group should be inserted.
  /// </summary>
  /// <value>
  ///   A string containing the Microsoft Office identifier, or <c>null</c> if position is not specified.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  ///   Use this to position the button group relative to a built-in control.
  /// </remarks>
  public string? InsertBeforeMso { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier after which this button group should be inserted.
  /// </summary>
  /// <value>
  ///   A string containing the namespace-qualified identifier, or <c>null</c> if position is not specified.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  ///   Use this to position the button group relative to another custom control.
  /// </remarks>
  public string? InsertAfterQualifiedId { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier before which this button group should be inserted.
  /// </summary>
  /// <value>
  ///   A string containing the namespace-qualified identifier, or <c>null</c> if position is not specified.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  ///   Use this to position the button group relative to another custom control.
  /// </remarks>
  public string? InsertBeforeQualifiedId { get; set; }

  /// <summary>
  ///   Gets or sets a cloned instance of a built-in or custom control.
  /// </summary>
  /// <value>
  ///   A <see cref="ControlCloneRegular"/> object, or <c>null</c> if no control clone is defined.
  /// </value>
  public ControlCloneRegular? ControlCloneRegular { get; set; }

  /// <summary>
  ///   Gets or sets a regular button control within the button group.
  /// </summary>
  /// <value>
  ///   A <see cref="ButtonRegular"/> object, or <c>null</c> if no button is defined.
  /// </value>
  public ButtonRegular? ButtonRegular { get; set; }

  /// <summary>
  ///   Gets or sets a toggle button control that maintains an on/off state.
  /// </summary>
  /// <value>
  ///   A <see cref="ToggleButtonRegular"/> object, or <c>null</c> if no toggle button is defined.
  /// </value>
  public ToggleButtonRegular? ToggleButtonRegular { get; set; }

  /// <summary>
  ///   Gets or sets a gallery control that displays a collection of selectable items.
  /// </summary>
  /// <value>
  ///   A <see cref="GalleryRegular"/> object, or <c>null</c> if no gallery is defined.
  /// </value>
  public GalleryRegular? GalleryRegular { get; set; }

  /// <summary>
  ///   Gets or sets a menu control that displays a dropdown list of options.
  /// </summary>
  /// <value>
  ///   A <see cref="MenuRegular"/> object, or <c>null</c> if no menu is defined.
  /// </value>
  public MenuRegular? MenuRegular { get; set; }

  /// <summary>
  ///   Gets or sets a dynamic menu control that generates menu items at runtime.
  /// </summary>
  /// <value>
  ///   A <see cref="DynamicMenuRegular"/> object, or <c>null</c> if no dynamic menu is defined.
  /// </value>
  public DynamicMenuRegular? DynamicMenuRegular { get; set; }

  /// <summary>
  ///   Gets or sets a split button control that combines a default action with a dropdown menu.
  /// </summary>
  /// <value>
  ///   A <see cref="SplitButtonRegular"/> object, or <c>null</c> if no split button is defined.
  /// </value>
  public SplitButtonRegular? SplitButtonRegular { get; set; }

  /// <summary>
  ///   Gets or sets a separator that provides visual division between controls.
  /// </summary>
  /// <value>
  ///   A <see cref="Separator"/> object, or <c>null</c> if no separator is defined.
  /// </value>
  public Separator? Separator { get; set; }
}