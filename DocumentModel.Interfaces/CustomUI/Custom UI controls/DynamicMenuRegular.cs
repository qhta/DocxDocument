namespace DocumentModel;

/// <summary>
/// Defines a regular dynamic menu control that generates menu items at runtime, optimized for use in menus, button groups, and other non-ribbon Office UI contexts. Supports dynamic content, flexible appearance, and advanced callback integration.
/// </summary>
/// <remarks>
/// This interface provides a streamlined dynamic menu for context menus, Backstage, and compact UI containers. Menu content is generated on demand via callback, supporting context-sensitive commands, recently used items, and menus that reflect current application state. The interface enables dynamic labeling, images, tooltips, and state, with support for custom metadata and flexible menu regeneration.
/// </remarks>
public interface DynamicMenuRegular : CustomUIControl, BuiltInControl, TaggedObject,
  DescriptionControl, EnableControl, VisibleControl,
  LabelledControl, ShowLabelControl,
  ImagedControl, ShowImageControl,
  KeytipControl, ScreentipControl, SupertipControl,
  ContextMenuContent, MenuContent, MenuRegularContent, ButtonGroupContent
{

  /// <summary>
  /// Callback function that generates the dynamic menu content as XML markup.
  /// </summary>
  public string? GetContent { get; set; }

  /// <summary>
  /// Invalidate menu content when the dropdown is closed.
  /// </summary>
  public bool? InvalidateContentOnDrop { get; set; }
}