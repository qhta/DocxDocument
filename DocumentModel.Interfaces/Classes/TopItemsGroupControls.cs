namespace DocumentModel;

/// <summary>
/// Defines a collection of top-level controls for display within a backstage group, supporting a comprehensive set of UI elements for Office customization.
/// </summary>
/// <remarks>
/// This interface provides access to various control types that can be positioned at the top level of a backstage group, including buttons, checkboxes, text inputs, dropdowns, radio groups, hyperlinks, labels, group boxes, layout containers, and images. It enables flexible arrangement and customization of backstage views for advanced Office scenarios.
/// </remarks>
public interface TopItemsGroupControls
{
  /// <summary>
  /// Backstage group button control.
  /// </summary>
  public BackstageGroupButton? BackstageGroupButton { get; set; }

  /// <summary>
  /// Backstage checkbox control.
  /// </summary>
  public BackstageCheckBox? BackstageCheckBox { get; set; }

  /// <summary>
  /// Backstage edit box control for text input.
  /// </summary>
  public BackstageEditBox? BackstageEditBox { get; set; }

  /// <summary>
  /// Backstage dropdown control for selecting from a list of options.
  /// </summary>
  public BackstageDropDown? BackstageDropDown { get; set; }

  /// <summary>
  /// Radio group control for mutually exclusive selection options.
  /// </summary>
  public RadioGroup? RadioGroup { get; set; }

  /// <summary>
  /// Backstage combo box control that combines text input with a dropdown list.
  /// </summary>
  public BackstageComboBox? BackstageComboBox { get; set; }

  /// <summary>
  /// Hyperlink control for navigation to external resources or locations.
  /// </summary>
  public Hyperlink? Hyperlink { get; set; }

  /// <summary>
  /// Backstage label control for displaying static text.
  /// </summary>
  public BackstageLabelControl? BackstageLabelControl { get; set; }

  /// <summary>
  /// Group box control that visually groups related controls together.
  /// </summary>
  public GroupBox? GroupBox { get; set; }

  /// <summary>
  /// Layout container control for organizing child controls with specific layout behavior.
  /// </summary>
  public LayoutContainer? LayoutContainer { get; set; }

  /// <summary>
  /// Image control for displaying graphical content.
  /// </summary>
  public ImageControl? ImageControl { get; set; }
}