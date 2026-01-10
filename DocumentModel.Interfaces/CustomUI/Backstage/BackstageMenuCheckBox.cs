namespace DocumentModel.CustomUI;

/// <summary>
/// Represents a checkbox item in the Office Backstage menu, supporting dynamic state, customizable appearance, and advanced callback integration for flexible UI scenarios.
/// </summary>
/// <remarks>
/// This interface defines a Backstage menu checkbox with properties for description, identification, state, labeling, keytips, and pressed state. It enables dynamic visibility, enabled state, labeling, and pressed state, supporting comprehensive customization of the Backstage experience in Office applications.
/// </remarks>
public interface BackstageMenuCheckBox: QualifiedElement, TaggedObject,
  DescriptionControl, EnableControl, VisibleControl,
  LabelledControl,
  KeytipControl,
  PressedControl, ActionControl,
  BackstageMenuGroupContent
{

}