namespace DocumentModel;

/// <summary>
/// Represents a container control that visually groups related controls together in the backstage view, supporting hierarchical organization, labeling, and layout customization for Office UI scenarios.
/// </summary>
/// <remarks>
/// This interface defines a grouping container that organizes related controls within the Office backstage interface. Group boxes provide visual boundaries with optional labels to separate and categorize controls, improving the organization and usability of backstage views. They support various control types including buttons, checkboxes, text inputs, dropdowns, radio groups, hyperlinks, labels, and nested group boxes for hierarchical organization.
/// </remarks>
public interface GroupBox : TaggedObject,
  LabelledControl,
  GroupBoxContentCollection,
  GroupBoxContent, LayoutContent, BackstageGroupContent
{
  /// <summary>
  /// Expansion behavior of the group box.
  /// </summary>
  public ExpandKind? Expand { get; set; }

}