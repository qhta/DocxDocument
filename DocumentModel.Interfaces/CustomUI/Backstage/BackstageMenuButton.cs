namespace DocumentModel.CustomUI;

/// <summary>
/// Represents a button item in the Office Backstage menu, supporting dynamic state, customizable appearance, and advanced callback integration for flexible UI scenarios.
/// </summary>
/// <remarks>
/// This interface defines a Backstage menu button with properties for description, identification, state, labeling, images, keytips, and definitive action. It enables dynamic visibility, enabled state, labeling, and image selection, supporting comprehensive customization of the Backstage experience in Office applications.
/// </remarks>
public interface BackstageMenuButton: QualifiedElement, TaggedObject,
  DescriptionControl,
  EnableControl, VisibleControl,
  LabelledControl, ImagedControl,
  KeytipControl,
  ActionControl,
  BackstageMenuGroupContent
{

  /// <summary>
  /// Indicates whether the button performs a definitive action.
  /// </summary>
  public bool? IsDefinitive { get; set; }
}