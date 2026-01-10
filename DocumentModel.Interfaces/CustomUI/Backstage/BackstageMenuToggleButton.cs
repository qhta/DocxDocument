namespace DocumentModel.CustomUI;

/// <summary>
/// Represents a toggle button for Office Backstage menus, supporting dynamic pressed state, customizable appearance, and advanced callback integration for flexible UI scenarios.
/// </summary>
/// <remarks>
/// This interface defines a Backstage menu toggle button with properties for images, description, identification, state, labeling, keytips, and pressed state. It enables dynamic visibility, enabled state, labeling, and image selection, supporting comprehensive customization of the Backstage experience in Office applications.
/// </remarks>
public interface BackstageMenuToggleButton: QualifiedElement, TaggedObject,
    EnableControl, VisibleControl,
    LabelledControl, ImagedControl,
    KeytipControl, DescriptionControl,
    PressedControl, ActionControl,
    BackstageMenuGroupContent
{
}