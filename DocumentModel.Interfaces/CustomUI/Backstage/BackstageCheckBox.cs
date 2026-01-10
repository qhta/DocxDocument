namespace DocumentModel.CustomUI;

/// <summary>
/// Represents a checkbox control for the Office Backstage view, supporting dynamic state, customizable appearance, and advanced callback integration for flexible UI scenarios.
/// </summary>
/// <remarks>
/// This interface defines a Backstage checkbox with properties for expansion, description, tooltips, identification, state, labeling, keytips, and pressed state. It enables dynamic visibility, enabled state, labeling, and pressed state, supporting comprehensive customization of the Backstage experience in Office applications.
/// </remarks>
public interface BackstageCheckBox: QualifiedElement, TaggedObject, 
  DescriptionControl,
  EnableControl, VisibleControl,
  LabelledControl,  
  KeytipControl,  ScreentipControl, SupertipControl,
  ActionControl, PressedControl, 
  BackstageGroupContent
{
  /// <summary>
  /// Expansion behavior of the checkbox control.
  /// </summary>
  public ExpandKind? Expand { get; set; }
}