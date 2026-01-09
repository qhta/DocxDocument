namespace DocumentModel;

/// <summary>
/// Defines a simplified split button control for use in context menus, Backstage menus, dialogs, and other non-ribbon Office UI contexts. Combines a primary action with a dropdown menu of related options, supporting dynamic state, flexible positioning, and advanced callback integration.
/// </summary>
/// <remarks>
/// <see cref="SplitButtonRegular"/> is a streamlined version of the split button control for use outside the main Office ribbon. It omits ribbon-specific properties and focuses on core split button functionality, supporting context menus, Backstage, dialogs, and task panes. The interface enables dynamic enabled state, visibility, label display, and keytips through callback functions, and supports custom positioning, metadata, and menu content for efficient and discoverable UI design.
/// </remarks>
public interface SplitButtonRegular: CustomUIControl, ContextMenuContent, TaggedObject
{
  /// <summary>
  /// Enable interaction with the split button.
  /// </summary>
  public bool? Enabled { get; set; }

  /// <summary>
  /// Callback for dynamic enabled state.
  /// </summary>
  public string? GetEnabled { get; set; }

  /// <summary>
  /// Arbitrary tag value for application-specific purposes.
  /// </summary>
  public string? Tag { get; set; }

  /// <summary>
  /// Microsoft Office built-in control identifier to customize or reference.
  /// </summary>
  public string? IdMso { get; set; }

  /// <summary>
  /// Show the split button in the menu or interface.
  /// </summary>
  public bool? Visible { get; set; }

  /// <summary>
  /// Callback for dynamic visibility.
  /// </summary>
  public string? GetVisible { get; set; }

  /// <summary>
  /// Keyboard shortcut (keytip) that activates this split button.
  /// </summary>
  public string? Keytip { get; set; }

  /// <summary>
  /// Callback for dynamic keytip value.
  /// </summary>
  public string? GetKeytip { get; set; }

  /// <summary>
  /// Show the text label alongside the icon.
  /// </summary>
  public bool? ShowLabel { get; set; }

  /// <summary>
  /// Callback for dynamic label visibility.
  /// </summary>
  public string? GetShowLabel { get; set; }

  /// <summary>
  /// Primary button component that executes the default action.
  /// </summary>
  public VisibleButton? VisibleButton { get; set; }

  /// <summary>
  /// Primary toggle button component that toggles a feature on/off.
  /// </summary>
  public VisibleToggleButton? VisibleToggleButton { get; set; }

  /// <summary>
  /// Dropdown menu component containing additional options.
  /// </summary>
  public MenuRegular? MenuRegular { get; set; }
}