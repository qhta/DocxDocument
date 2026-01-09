namespace DocumentModel;

/// <summary>
/// Represents a group container for organizing related controls within a ribbon tab, supporting dynamic state, visual customization, and advanced layout for Office UI scenarios.
/// </summary>
/// <remarks>
/// Groups are the main organizational unit in the ribbon, containing collections of related commands, buttons, galleries, and other controls. This interface supports dynamic labeling, images, tooltips, scaling, and dialog box launchers for flexible and adaptive ribbon layouts.
/// </remarks>
public interface Group : CustomUIControl, BuiltInControl
{
  /// <summary>
  /// Arbitrary tag value for custom data storage.
  /// </summary>
  public string? Tag { get; set; }

  /// <summary>
  /// Label displayed at the bottom of the group in the ribbon.
  /// </summary>
  public string? Label { get; set; }

  /// <summary>
  /// Callback for dynamic label text.
  /// </summary>
  public string? GetLabel { get; set; }

  /// <summary>
  /// Custom image identifier for the group icon.
  /// </summary>
  public string? Image { get; set; }

  /// <summary>
  /// Built-in Office image identifier for the group icon.
  /// </summary>
  public string? ImageMso { get; set; }

  /// <summary>
  /// Callback for dynamic group image.
  /// </summary>
  public string? GetImage { get; set; }

  /// <summary>
  /// Screentip text for the group, shown when hovering over the collapsed group button.
  /// </summary>
  public string? Screentip { get; set; }

  /// <summary>
  /// Callback for dynamic screentip text.
  /// </summary>
  public string? GetScreentip { get; set; }

  /// <summary>
  /// Supertip text for the group, shown as extended tooltip.
  /// </summary>
  public string? Supertip { get; set; }

  /// <summary>
  /// Callback for dynamic supertip text.
  /// </summary>
  public string? GetSupertip { get; set; }

  /// <summary>
  /// Show the group in the UI.
  /// </summary>
  public bool? Visible { get; set; }

  /// <summary>
  /// Callback for dynamic visibility.
  /// </summary>
  public string? GetVisible { get; set; }

  /// <summary>
  /// Keyboard shortcut (keytip) for accessing the group.
  /// </summary>
  public string? Keytip { get; set; }

  /// <summary>
  /// Callback for dynamic keytip.
  /// </summary>
  public string? GetKeytip { get; set; }

  /// <summary>
  /// Enable automatic scaling of controls when ribbon space is limited.
  /// </summary>
  public bool? AutoScale { get; set; }

  /// <summary>
  /// Vertically center controls in the group.
  /// </summary>
  public bool? CenterVertically { get; set; }

  /// <summary>
  /// Cloned instance of a built-in or custom control.
  /// </summary>
  public ControlClone? ControlClone { get; set; }

   /// <summary>
  /// Dialog box launcher for accessing additional options or settings.
  /// </summary>
  public DialogBoxLauncher? DialogBoxLauncher { get; set; }

   /// <summary>
   ///List of content items associated with the group.
   /// </summary>
  public GroupContentList? Children { get; set; }
}