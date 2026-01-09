namespace DocumentModel;

/// <summary>
/// Represents a container control that visually groups related controls together in the backstage view, supporting hierarchical organization, labeling, and layout customization for Office UI scenarios.
/// </summary>
/// <remarks>
/// This interface defines a grouping container that organizes related controls within the Office backstage interface. Group boxes provide visual boundaries with optional labels to separate and categorize controls, improving the organization and usability of backstage views. They support various control types including buttons, checkboxes, text inputs, dropdowns, radio groups, hyperlinks, labels, and nested group boxes for hierarchical organization.
/// </remarks>
public interface GroupBox : TaggedObject
{
  /// <summary>
  /// Expansion behavior of the group box.
  /// </summary>
  public ExpandKind? Expand { get; set; }

  /// <summary>
  /// Label displayed at the top of the group box as a header.
  /// </summary>
  public string? Label { get; set; }

  /// <summary>
  /// Callback for dynamic label text.
  /// </summary>
  public string? GetLabel { get; set; }

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
  /// Nested group box for hierarchical control organization.
  /// </summary>
  public GroupBox? ChildGroupBox { get; set; }

  /// <summary>
  /// Layout container control for organizing child controls with specific layout behavior.
  /// </summary>
  public LayoutContainer? LayoutContainer { get; set; }

  /// <summary>
  /// Image control for displaying graphical content.
  /// </summary>
  public ImageControl? ImageControl { get; set; }
}