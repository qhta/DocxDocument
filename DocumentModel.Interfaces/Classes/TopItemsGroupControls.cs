namespace DocumentModel;

/// <summary>
///   Represents a collection of top-level controls that can be displayed within a backstage group.
/// </summary>
/// <remarks>
///   This interface extends <see cref="IModelElement"/> and provides access to various control types
///   that can be positioned at the top level of a backstage group. These controls include buttons,
///   checkboxes, text inputs, dropdowns, radio groups, hyperlinks, labels, group boxes, layout containers,
///   and images, providing a comprehensive set of UI elements for backstage customization.
/// </remarks>
public interface TopItemsGroupControls : IModelElement
{
  /// <summary>
  ///   Gets or sets the backstage group button control.
  /// </summary>
  /// <value>
  ///   A <see cref="BackstageGroupButton"/> object, or <c>null</c> if no button is defined.
  /// </value>
  public BackstageGroupButton? BackstageGroupButton { get; set; }

  /// <summary>
  ///   Gets or sets the backstage checkbox control.
  /// </summary>
  /// <value>
  ///   A <see cref="BackstageCheckBox"/> object, or <c>null</c> if no checkbox is defined.
  /// </value>
  public BackstageCheckBox? BackstageCheckBox { get; set; }

  /// <summary>
  ///   Gets or sets the backstage edit box control for text input.
  /// </summary>
  /// <value>
  ///   A <see cref="BackstageEditBox"/> object, or <c>null</c> if no edit box is defined.
  /// </value>
  public BackstageEditBox? BackstageEditBox { get; set; }

  /// <summary>
  ///   Gets or sets the backstage dropdown control for selecting from a list of options.
  /// </summary>
  /// <value>
  ///   A <see cref="BackstageDropDown"/> object, or <c>null</c> if no dropdown is defined.
  /// </value>
  public BackstageDropDown? BackstageDropDown { get; set; }

  /// <summary>
  ///   Gets or sets the radio group control for mutually exclusive selection options.
  /// </summary>
  /// <value>
  ///   A <see cref="RadioGroup"/> object, or <c>null</c> if no radio group is defined.
  /// </value>
  public RadioGroup? RadioGroup { get; set; }

  /// <summary>
  ///   Gets or sets the backstage combo box control that combines text input with a dropdown list.
  /// </summary>
  /// <value>
  ///   A <see cref="BackstageComboBox"/> object, or <c>null</c> if no combo box is defined.
  /// </value>
  public BackstageComboBox? BackstageComboBox { get; set; }

  /// <summary>
  ///   Gets or sets the hyperlink control for navigation to external resources or locations.
  /// </summary>
  /// <value>
  ///   A <see cref="Hyperlink"/> object, or <c>null</c> if no hyperlink is defined.
  /// </value>
  public Hyperlink? Hyperlink { get; set; }

  /// <summary>
  ///   Gets or sets the backstage label control for displaying static text.
  /// </summary>
  /// <value>
  ///   A <see cref="BackstageLabelControl"/> object, or <c>null</c> if no label is defined.
  /// </value>
  public BackstageLabelControl? BackstageLabelControl { get; set; }

  /// <summary>
  ///   Gets or sets the group box control that visually groups related controls together.
  /// </summary>
  /// <value>
  ///   A <see cref="GroupBox"/> object, or <c>null</c> if no group box is defined.
  /// </value>
  public GroupBox? GroupBox { get; set; }

  /// <summary>
  ///   Gets or sets the layout container control for organizing child controls with specific layout behavior.
  /// </summary>
  /// <value>
  ///   A <see cref="LayoutContainer"/> object, or <c>null</c> if no layout container is defined.
  /// </value>
  public LayoutContainer? LayoutContainer { get; set; }

  /// <summary>
  ///   Gets or sets the image control for displaying graphical content.
  /// </summary>
  /// <value>
  ///   An <see cref="ImageControl"/> object, or <c>null</c> if no image control is defined.
  /// </value>
  public ImageControl? ImageControl { get; set; }
}