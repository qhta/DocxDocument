namespace DocumentModel;

/// <summary>
///   Represents a separator control that provides visual division between controls in the ribbon interface.
/// </summary>
/// <remarks>
///   This interface defines a visual divider used to organize
///   and separate groups of related controls within ribbon groups, button groups, and other containers.
///   Unlike <see cref="MenuSeparator"/> which is specifically designed for menu contexts, this separator
///   is used in broader ribbon scenarios. Separators improve visual organization and help users distinguish
///   between different functional areas of the ribbon. They support positioning relative to other controls
///   and can have their visibility controlled statically or dynamically through callbacks.
/// </remarks>
public interface Separator: CustomUIControl, TaggedObject, 
  VisibleControl,
  GroupContent, ButtonGroupContent,
  QatItem
{

}