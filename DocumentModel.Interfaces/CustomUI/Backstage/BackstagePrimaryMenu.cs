namespace DocumentModel;

/// <summary>
/// Represents a primary menu in the Office Backstage view, supporting dynamic state, customizable appearance, and advanced callback integration for flexible UI scenarios.
/// </summary>
/// <remarks>
/// This interface defines a Backstage primary menu with properties for tooltips, identification, state, labeling, images, keytips, and menu group content. It enables dynamic visibility, enabled state, labeling, and image selection, supporting comprehensive customization of the Backstage experience in Office applications.
/// </remarks>
public interface BackstagePrimaryMenu: QualifiedElement, TaggedObject, 
  EnableControl, VisibleControl,
  LabelledControl, ImagedControl,
  KeytipControl, SupertipControl, ScreentipControl,
  PrimaryItem,
  BackstageMenuGroupCollection
{
}