namespace DocumentModel;

/// <summary>
/// Represents a regular button control for Office UI, supporting streamlined appearance, dynamic state, and advanced callback integration for use in menus, button groups, and split buttons.
/// </summary>
/// <remarks>
/// This interface defines a simplified button control optimized for constrained ribbon contexts. It supports customizable images, labels, tooltips, keyboard shortcuts, and dynamic state or behavior through callback functions. The interface enables efficient UI design for Office add-ins and document solutions.
/// </remarks>
public interface ButtonRegular : CustomUIControl, BuiltInControl, TaggedObject, 
  DescriptionControl,  
  EnableControl, VisibleControl,
  LabelledControl, ShowLabelControl,
  ImagedControl, ShowImageControl,
  KeytipControl, ScreentipControl, SupertipControl,
  ActionControl,
  ContextMenuContent, MenuContent, MenuRegularContent, ButtonGroupContent,
  QatItem
{

}