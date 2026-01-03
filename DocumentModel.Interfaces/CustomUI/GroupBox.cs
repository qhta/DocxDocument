namespace DocumentModel;

/// <summary>
///   Represents a container control that visually groups related controls together in the backstage view.
/// </summary>
/// <remarks>
///   This interface defines a grouping container that organizes
///   related controls within the Office backstage interface. Group boxes provide visual boundaries with
///   optional labels to separate and categorize controls, improving the organization and usability of
///   backstage views. They support various control types including buttons, checkboxes, text inputs,
///   dropdowns, radio groups, hyperlinks, labels, and nested group boxes for hierarchical organization.
/// </remarks>
public interface GroupBox : IModelElement
{
  /// <summary>
  ///   Gets or sets the unique identifier for this group box.
  /// </summary>
  public string? Id { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier for this group box.
  /// </summary>
  /// <remarks>
  ///   Use this when the identifier needs to be unique across multiple namespaces.
  /// </remarks>
  public string? QualifiedId { get; set; }

  /// <summary>
  ///   Gets or sets an arbitrary tag value for custom data storage.
  /// </summary>
  /// <remarks>
  ///   The tag can be used to store application-specific information associated with this group box.
  /// </remarks>
  public string? Tag { get; set; }

  /// <summary>
  ///   Gets or sets the expansion behavior of the group box.
  /// </summary>
  /// <remarks>
  ///   This controls whether the group box expands horizontally, vertically, or both to utilize available layout space.
  /// </remarks>
  public ExpandKind? Expand { get; set; }

  /// <summary>
  ///   Gets or sets the display label for the group box.
  /// </summary>
  /// <remarks>
  ///   The label is typically displayed at the top of the group box as a header.
  /// </remarks>
  public string? Label { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the group box's label.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a string value for the label.
  /// </remarks>
  public string? GetLabel { get; set; }

  /// <summary>
  ///   Gets or sets a backstage group button control.
  /// </summary>
  public BackstageGroupButton? BackstageGroupButton { get; set; }

  /// <summary>
  ///   Gets or sets a backstage checkbox control.
  /// </summary>
  public BackstageCheckBox? BackstageCheckBox { get; set; }

  /// <summary>
  ///   Gets or sets a backstage edit box control for text input.
  /// </summary>
  public BackstageEditBox? BackstageEditBox { get; set; }

  /// <summary>
  ///   Gets or sets a backstage dropdown control for selecting from a list of options.
  /// </summary>
  public BackstageDropDown? BackstageDropDown { get; set; }

  /// <summary>
  ///   Gets or sets a radio group control for mutually exclusive selection options.
  /// </summary>
  public RadioGroup? RadioGroup { get; set; }

  /// <summary>
  ///   Gets or sets a backstage combo box control that combines text input with a dropdown list.
  /// </summary>
  public BackstageComboBox? BackstageComboBox { get; set; }

  /// <summary>
  ///   Gets or sets a hyperlink control for navigation to external resources or locations.
  /// </summary>
  public Hyperlink? Hyperlink { get; set; }

  /// <summary>
  ///   Gets or sets a backstage label control for displaying static text.
  /// </summary>
  public BackstageLabelControl? BackstageLabelControl { get; set; }

  /// <summary>
  ///   Gets or sets a nested group box for hierarchical control organization.
  /// </summary>
  /// <remarks>
  ///   Group boxes can be nested to create multiple levels of visual grouping and organization.
  /// </remarks>
  public GroupBox? ChildGroupBox { get; set; }

  /// <summary>
  ///   Gets or sets a layout container control for organizing child controls with specific layout behavior.
  /// </summary>
  public LayoutContainer? LayoutContainer { get; set; }

  /// <summary>
  ///   Gets or sets an image control for displaying graphical content.
  /// </summary>
  public ImageControl? ImageControl { get; set; }
}