namespace DocumentModel.CustomUI;

/// <summary>
/// Represents a submenu in the Office Backstage view, supporting dynamic state, customizable appearance, and advanced callback integration for flexible UI scenarios.
/// </summary>
/// <remarks>
/// This interface defines a Backstage submenu with properties for description, identification, state, labeling, images, keytips, and menu group content. It enables dynamic visibility, enabled state, labeling, and menu content generation, supporting comprehensive customization of the Backstage experience in Office applications.
/// </remarks>
public interface BackstageSubMenu : QualifiedElement, TaggedObject,
  DescriptionControl, EnableControl, VisibleControl,
  LabelledControl,
  ImagedControl,
  KeytipControl,
  BackstageMenuGroupContentCollection,
  BackstageMenuGroupContent
{

}