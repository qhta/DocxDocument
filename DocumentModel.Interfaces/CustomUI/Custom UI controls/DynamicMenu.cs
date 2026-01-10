namespace DocumentModel;

/// <summary>
/// Represents a dynamic menu control that generates menu items at runtime through callback functions, supporting customizable appearance, dynamic content, and advanced integration for flexible UI scenarios.
/// </summary>
/// <remarks>
/// This interface defines a menu control that creates its content dynamically rather than using a predefined static list of items. Unlike standard <see cref="Menu"/> controls with fixed items, dynamic menus use a callback function to generate menu content on-demand when the menu is opened. This is particularly useful for menus that need to reflect current application state, recently used items, or context-sensitive commands. The menu content can be invalidated and regenerated as needed, and the control supports customizable appearance with images, labels, tooltips, sizing options, and can have its state and behavior controlled through static properties or dynamic callbacks.
/// </remarks>
public interface DynamicMenu : CustomUIControl, BuiltInObject, TaggedObject, 
  DescriptionControl,
  EnableControl, VisibleControl,
  LabelledControl, ShowLabelControl,
  ImagedControl, ShowImageControl,
  KeytipControl, ScreentipControl, SupertipControl,
  SizeControl,
  BoxContent, GroupContent
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