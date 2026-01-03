namespace DocumentModel;

/// <summary>
///   Represents a container control that visually groups related controls together in the backstage view.
/// </summary>
/// <remarks>
///   This interface extends <see cref="IModelElement"/> and defines a grouping container that organizes
///   related controls within the Office backstage interface. Group boxes provide visual boundaries with
///   optional labels to separate and categorize controls, improving the organization and usability of
///   backstage views. They support various control types including buttons, checkboxes, text inputs,
///   dropdowns, radio groups, hyperlinks, labels, and nested group boxes for hierarchical organization.
///   This functionality is available in Office 2010 and later versions.
/// </remarks>
public interface GroupBox : IModelElement
{
  /// <summary>
  ///   Gets or sets the unique identifier for this group box.
  /// </summary>
  /// <value>
  ///   A string containing the identifier, or <c>null</c> if no identifier is specified.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  /// </remarks>
  public string? Id { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier for this group box.
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
  ///   The tag can be used to store application-specific information associated with this group box.
  /// </remarks>
  public string? Tag { get; set; }

  /// <summary>
  ///   Gets or sets the expansion behavior of the group box.
  /// </summary>
  /// <value>
  ///   An <see cref="ExpandKind"/> value specifying how the group box expands to fill available space,
  ///   or <c>null</c> to use the default expansion behavior.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  ///   This controls whether the group box expands horizontally, vertically, or both to utilize available layout space.
  /// </remarks>
  public ExpandKind? Expand { get; set; }

  /// <summary>
  ///   Gets or sets the display label for the group box.
  /// </summary>
  /// <value>
  ///   A string containing the label text, or <c>null</c> if no label is specified.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  ///   The label is typically displayed at the top of the group box as a header.
  /// </remarks>
  public string? Label { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the group box's label.
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
  ///   Gets or sets a backstage group button control.
  /// </summary>
  /// <value>
  ///   A <see cref="BackstageGroupButton"/> object, or <c>null</c> if no button is defined.
  /// </value>
  public BackstageGroupButton? BackstageGroupButton { get; set; }

  /// <summary>
  ///   Gets or sets a backstage checkbox control.
  /// </summary>
  /// <value>
  ///   A <see cref="BackstageCheckBox"/> object, or <c>null</c> if no checkbox is defined.
  /// </value>
  public BackstageCheckBox? BackstageCheckBox { get; set; }

  /// <summary>
  ///   Gets or sets a backstage edit box control for text input.
  /// </summary>
  /// <value>
  ///   A <see cref="BackstageEditBox"/> object, or <c>null</c> if no edit box is defined.
  /// </value>
  public BackstageEditBox? BackstageEditBox { get; set; }

  /// <summary>
  ///   Gets or sets a backstage dropdown control for selecting from a list of options.
  /// </summary>
  /// <value>
  ///   A <see cref="BackstageDropDown"/> object, or <c>null</c> if no dropdown is defined.
  /// </value>
  public BackstageDropDown? BackstageDropDown { get; set; }

  /// <summary>
  ///   Gets or sets a radio group control for mutually exclusive selection options.
  /// </summary>
  /// <value>
  ///   A <see cref="RadioGroup"/> object, or <c>null</c> if no radio group is defined.
  /// </value>
  public RadioGroup? RadioGroup { get; set; }

  /// <summary>
  ///   Gets or sets a backstage combo box control that combines text input with a dropdown list.
  /// </summary>
  /// <value>
  ///   A <see cref="BackstageComboBox"/> object, or <c>null</c> if no combo box is defined.
  /// </value>
  public BackstageComboBox? BackstageComboBox { get; set; }

  /// <summary>
  ///   Gets or sets a hyperlink control for navigation to external resources or locations.
  /// </summary>
  /// <value>
  ///   A <see cref="Hyperlink"/> object, or <c>null</c> if no hyperlink is defined.
  /// </value>
  public Hyperlink? Hyperlink { get; set; }

  /// <summary>
  ///   Gets or sets a backstage label control for displaying static text.
  /// </summary>
  /// <value>
  ///   A <see cref="BackstageLabelControl"/> object, or <c>null</c> if no label is defined.
  /// </value>
  public BackstageLabelControl? BackstageLabelControl { get; set; }

  /// <summary>
  ///   Gets or sets a nested group box for hierarchical control organization.
  /// </summary>
  /// <value>
  ///   A <see cref="GroupBox"/> object, or <c>null</c> if no child group box is defined.
  /// </value>
  /// <remarks>
  ///   Group boxes can be nested to create multiple levels of visual grouping and organization.
  /// </remarks>
  public GroupBox? ChildGroupBox { get; set; }

  /// <summary>
  ///   Gets or sets a layout container control for organizing child controls with specific layout behavior.
  /// </summary>
  /// <value>
  ///   A <see cref="LayoutContainer"/> object, or <c>null</c> if no layout container is defined.
  /// </value>
  public LayoutContainer? LayoutContainer { get; set; }

  /// <summary>
  ///   Gets or sets an image control for displaying graphical content.
  /// </summary>
  /// <value>
  ///   An <see cref="ImageControl"/> object, or <c>null</c> if no image control is defined.
  /// </value>
  public ImageControl? ImageControl { get; set; }
}