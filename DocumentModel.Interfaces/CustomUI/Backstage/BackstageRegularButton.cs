namespace DocumentModel.CustomUI;

/// <summary>
/// Represents a regular button in the Office Backstage view, supporting dynamic state, customizable appearance, and advanced callback integration for flexible UI scenarios.
/// </summary>
/// <remarks>
/// This interface defines a Backstage button with properties for tooltips, identification, state, labeling, images, keytips, and definitive action. It enables dynamic visibility, enabled state, labeling, and image selection, supporting comprehensive customization of the Backstage experience in Office applications.
/// </remarks>
public interface BackstageRegularButton: QualifiedElement, TaggedObject, 
  EnableControl, VisibleControl,
  LabelledControl, ImagedControl,
  KeytipControl, ScreentipControl, SupertipControl,
  ActionControl,
  PrimaryItem
{

  /// <summary>
  /// Indicates whether the button performs a definitive action.
  /// </summary>
  public bool? IsDefinitive { get; set; }
}