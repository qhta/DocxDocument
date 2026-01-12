namespace DocumentModel.CustomUI;

/// <summary>
/// Represents a regular button control for Office UI, supporting streamlined appearance, dynamic state, and advanced callback integration for use in menus, button groups, and split buttons.
/// </summary>
/// <remarks>
/// Features:
/// <list type="bullet">
/// <item>Represents a simplified button, optimized for use in constrained contexts such as menus, button groups, and split buttons.</item>
/// <item>Designed to maintain consistent, compact dimensions appropriate for these UI containers.</item>
/// <item>Typically used where a streamlined button is needed, without the extra sizing or customization options of the standard button.</item>
/// </list>
/// </remarks>
public interface ButtonRegular : CustomUIControl, BuiltInObject, TaggedObject, 
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