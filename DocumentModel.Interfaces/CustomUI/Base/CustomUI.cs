namespace DocumentModel.CustomUI;

/// <summary>
/// Represents the root element for Office UI customization, enabling definition of custom ribbons, backstage views, and context menus for comprehensive Office add-in or document integration.
/// </summary>
/// <remarks>
/// This interface serves as the top-level container for all Office user interface customizations in an add-in or document. It provides access to major UI components: the <c>Ribbon</c> for tab and control customization, the <c>Backstage</c> for File menu customization, and <c>ContextMenuCollection</c> for right-click menu modifications. Callback properties for initialization and image loading are included, as well as a collection for custom command handlers. This unified structure ensures consistent customization across all Office UI surfaces and supports both static definitions and dynamic behavior through callback functions.
/// </remarks>
public interface CustomUI
{
  /// <summary>
  /// Callback invoked when the custom UI is loaded.
  /// </summary>
  public string? OnLoad { get; set; }

  /// <summary>
  /// Callback that provides images for custom controls.
  /// </summary>
  public string? LoadImage { get; set; }

  /// <summary>
  /// Collection of custom command definitions.
  /// </summary>
  public Commands? Commands { get; set; }

  /// <summary>
  /// Ribbon customization definition.
  /// </summary>
  public Ribbon? Ribbon { get; set; }

  /// <summary>
  /// Backstage view customization definition.
  /// </summary>
  public Backstage? Backstage { get; set; }

  /// <summary>
  /// Collection of context menu customizations.
  /// </summary>
  public ContextMenuCollection? ContextMenus { get; set; }
}