namespace DocumentModel;

/// <summary>
///   Represents a collection of top-level controls that can be displayed within a backstage group.
/// </summary>
/// <remarks>
///   This interface provides access to various control types
///   that can be positioned at the top level of a backstage group. These controls include buttons,
///   checkboxes, text inputs, dropdowns, radio groups, hyperlinks, labels, group boxes, layout containers,
///   and images, providing a comprehensive set of UI elements for backstage customization.
/// </remarks>
public interface TopItemsGroupControls : IModelElement
{
  /// <summary>
  ///   Gets or sets the backstage group button control.
  /// </summary>
  public BackstageGroupButton? BackstageGroupButton { get; set; }

  /// <summary>
  ///   Gets or sets the backstage checkbox control.
  /// </summary>
  public BackstageCheckBox? BackstageCheckBox { get; set; }

  /// <summary>
  ///   Gets or sets the backstage edit box control for text input.
  /// </summary>
  public BackstageEditBox? BackstageEditBox { get; set; }

  /// <summary>
  ///   Gets or sets the backstage dropdown control for selecting from a list of options.
  /// </summary>
  public BackstageDropDown? BackstageDropDown { get; set; }

  /// <summary>
  ///   Gets or sets the radio group control for mutually exclusive selection options.
  /// </summary>
  public RadioGroup? RadioGroup { get; set; }

  /// <summary>
  ///   Gets or sets the backstage combo box control that combines text input with a dropdown list.
  /// </summary>
  public BackstageComboBox? BackstageComboBox { get; set; }

  /// <summary>
  ///   Gets or sets the hyperlink control for navigation to external resources or locations.
  /// </summary>
  public Hyperlink? Hyperlink { get; set; }

  /// <summary>
  ///   Gets or sets the backstage label control for displaying static text.
  /// </summary>
  public BackstageLabelControl? BackstageLabelControl { get; set; }

  /// <summary>
  ///   Gets or sets the group box control that visually groups related controls together.
  /// </summary>
  public GroupBox? GroupBox { get; set; }

  /// <summary>
  ///   Gets or sets the layout container control for organizing child controls with specific layout behavior.
  /// </summary>
  public LayoutContainer? LayoutContainer { get; set; }

  /// <summary>
  ///   Gets or sets the image control for displaying graphical content.
  /// </summary>
  public ImageControl? ImageControl { get; set; }
}