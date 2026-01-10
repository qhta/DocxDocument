namespace DocumentModel;

/// <summary>
/// Represents a group button for the Office Backstage view, supporting dynamic state, customizable appearance, and advanced callback integration for flexible UI scenarios.
/// </summary>
/// <remarks>
/// This interface defines a Backstage group button with properties for expansion, style, tooltips, identification, state, labeling, images, keytips, and definitive action. It enables dynamic visibility, enabled state, labeling, and image selection, supporting comprehensive customization of the Backstage experience in Office applications.
/// </remarks>
public interface BackstageGroupButton: QualifiedElement, TaggedObject, 
  EnableControl, VisibleControl,
  LabelledControl, ImagedControl,
  KeytipControl, ScreentipControl, SupertipControl,
  ActionControl,
  GroupBoxContent, LayoutContent, BackstageGroupContent
{
  /// <summary>
  /// Expansion behavior of the group button.
  /// </summary>
  public ExpandKind? Expand { get; set; }

  /// <summary>
  /// Style of the group button.
  /// </summary>
  public Style2Kind? Style { get; set; }

  /// <summary>
  /// Indicates whether the button performs a definitive action.
  /// </summary>
  public bool? IsDefinitive { get; set; }
}