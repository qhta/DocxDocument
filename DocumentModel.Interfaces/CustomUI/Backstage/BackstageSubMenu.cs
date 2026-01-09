namespace DocumentModel;

/// <summary>
/// Represents a submenu in the Office Backstage view, supporting dynamic state, customizable appearance, and advanced callback integration for flexible UI scenarios.
/// </summary>
/// <remarks>
/// This interface defines a Backstage submenu with properties for description, identification, state, labeling, images, keytips, and menu group content. It enables dynamic visibility, enabled state, labeling, and menu content generation, supporting comprehensive customization of the Backstage experience in Office applications.
/// </remarks>
public interface BackstageSubMenu: QualifiedElement, TaggedObject
{
  /// <summary>
  /// Description text for the Backstage submenu.
  /// </summary>
  public string? Description { get; set; }

  /// <summary>
  /// Callback for dynamic description text.
  /// </summary>
  public string? GetDescription { get; set; }

  /// <summary>
  /// Enable interaction with the Backstage submenu.
  /// </summary>
  public bool? Enabled { get; set; }

  /// <summary>
  /// Callback for dynamic enabled state.
  /// </summary>
  public string? GetEnabled { get; set; }

  /// <summary>
  /// Label text for the Backstage submenu.
  /// </summary>
  public string? Label { get; set; }

  /// <summary>
  /// Callback for dynamic label text.
  /// </summary>
  public string? GetLabel { get; set; }

  /// <summary>
  /// Show the Backstage submenu in the UI.
  /// </summary>
  public bool? Visible { get; set; }

  /// <summary>
  /// Callback for dynamic visibility.
  /// </summary>
  public string? GetVisible { get; set; }

  /// <summary>
  /// Custom image identifier for the submenu icon.
  /// </summary>
  public string? Image { get; set; }

  /// <summary>
  /// Built-in Office image identifier for the submenu icon.
  /// </summary>
  public string? ImageMso { get; set; }

  /// <summary>
  /// Callback for dynamic submenu image.
  /// </summary>
  public string? GetImage { get; set; }

  /// <summary>
  /// Keyboard shortcut (keytip) for accessing the submenu.
  /// </summary>
  public string? Keytip { get; set; }

  /// <summary>
  /// Callback for dynamic keytip.
  /// </summary>
  public string? GetKeytip { get; set; }

  /// <summary>
  /// Menu group content for the Backstage submenu.
  /// </summary>
  public BackstageMenuGroup? BackstageMenuGroup { get; set; }
}