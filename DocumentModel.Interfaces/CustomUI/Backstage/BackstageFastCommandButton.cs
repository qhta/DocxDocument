namespace DocumentModel.CustomUI;

/// <summary>
/// Represents a fast command button for the Office Backstage view, supporting dynamic state, flexible positioning, and advanced callback integration for custom UI scenarios.
/// </summary>
/// <remarks>
/// This interface defines a Backstage fast command button with properties for identification, positioning, state, labeling, images, keytips, and definitive action. It enables dynamic visibility, enabled state, labeling, and image selection, supporting comprehensive customization of the Backstage experience in Office applications.
/// </remarks>
public interface BackstageFastCommandButton: CustomUIControl, BuiltInObject, TaggedObject, 
  EnableControl, VisibleControl,
  LabelledControl,
  ImagedControl,
  KeytipControl,
  ActionControl
{
  /// <summary>
  /// Indicates whether the button performs a definitive action.
  /// </summary>
  public bool? IsDefinitive { get; set; }

}