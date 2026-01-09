namespace DocumentModel;

/// <summary>
/// Defines a regular dynamic menu control that generates menu items at runtime, optimized for use in menus, button groups, and other non-ribbon Office UI contexts. Supports dynamic content, flexible appearance, and advanced callback integration.
/// </summary>
/// <remarks>
/// This interface provides a streamlined dynamic menu for context menus, Backstage, and compact UI containers. Menu content is generated on demand via callback, supporting context-sensitive commands, recently used items, and menus that reflect current application state. The interface enables dynamic labeling, images, tooltips, and state, with support for custom metadata and flexible menu regeneration.
/// </remarks>
public interface DynamicMenuRegular : CustomUIControl, BuiltInControl, ContextMenuContent, TaggedObject
{
  /// <summary>
  /// Description text for the dynamic menu control.
  /// </summary>
  public string? Description { get; set; }

  /// <summary>
  /// Callback for dynamic description text.
  /// </summary>
  public string? GetDescription { get; set; }

  /// <summary>
  /// Callback function that generates the dynamic menu content as XML markup.
  /// </summary>
  public string? GetContent { get; set; }

  /// <summary>
  /// Invalidate menu content when the dropdown is closed.
  /// </summary>
  public bool? InvalidateContentOnDrop { get; set; }

  /// <summary>
  /// Custom image identifier for the dynamic menu button.
  /// </summary>
  public string? Image { get; set; }

  /// <summary>
  /// Built-in Office image identifier for the dynamic menu button.
  /// </summary>
  public string? ImageMso { get; set; }

  /// <summary>
  /// Callback for dynamic menu image.
  /// </summary>
  public string? GetImage { get; set; }

  /// <summary>
  /// Screentip text for the dynamic menu.
  /// </summary>
  public string? Screentip { get; set; }

  /// <summary>
  /// Callback for dynamic screentip text.
  /// </summary>
  public string? GetScreentip { get; set; }

  /// <summary>
  /// Supertip text for the dynamic menu.
  /// </summary>
  public string? Supertip { get; set; }

  /// <summary>
  /// Callback for dynamic supertip text.
  /// </summary>
  public string? GetSupertip { get; set; }

  /// <summary>
  /// Enable interaction with the dynamic menu.
  /// </summary>
  public bool? Enabled { get; set; }

  /// <summary>
  /// Callback for dynamic enabled state.
  /// </summary>
  public string? GetEnabled { get; set; }

  /// <summary>
  /// Label displayed for the dynamic menu.
  /// </summary>
  public string? Label { get; set; }

  /// <summary>
  /// Callback for dynamic label text.
  /// </summary>
  public string? GetLabel { get; set; }

  /// <summary>
  /// Show the dynamic menu in the UI.
  /// </summary>
  public bool? Visible { get; set; }

  /// <summary>
  /// Callback for dynamic visibility.
  /// </summary>
  public string? GetVisible { get; set; }

  /// <summary>
  /// Keyboard shortcut (keytip) for accessing the dynamic menu.
  /// </summary>
  public string? Keytip { get; set; }

  /// <summary>
  /// Callback for dynamic keytip.
  /// </summary>
  public string? GetKeytip { get; set; }

  /// <summary>
  /// Show the dynamic menu label in the UI.
  /// </summary>
  public bool? ShowLabel { get; set; }

  /// <summary>
  /// Callback for dynamic label visibility.
  /// </summary>
  public string? GetShowLabel { get; set; }

  /// <summary>
  /// Show the dynamic menu image in the UI.
  /// </summary>
  public bool? ShowImage { get; set; }

  /// <summary>
  /// Callback for dynamic image visibility.
  /// </summary>
  public string? GetShowImage { get; set; }
}