namespace DocumentModel;

/// <summary>
/// Represents a toggle button for Office Backstage menus, supporting dynamic pressed state, customizable appearance, and advanced callback integration for flexible UI scenarios.
/// </summary>
/// <remarks>
/// This interface defines a Backstage menu toggle button with properties for images, description, identification, state, labeling, keytips, and pressed state. It enables dynamic visibility, enabled state, labeling, and image selection, supporting comprehensive customization of the Backstage experience in Office applications.
/// </remarks>
public interface BackstageMenuToggleButton: QualifiedElement, TaggedObject
{
  /// <summary>
  /// Custom image identifier for the toggle button icon.
  /// </summary>
  public string? Image { get; set; }

  /// <summary>
  /// Built-in Office image identifier for the toggle button icon.
  /// </summary>
  public string? ImageMso { get; set; }

  /// <summary>
  /// Callback for dynamic toggle button image.
  /// </summary>
  public string? GetImage { get; set; }

  /// <summary>
  /// Description text for the toggle button.
  /// </summary>
  public string? Description { get; set; }

  /// <summary>
  /// Callback for dynamic description text.
  /// </summary>
  public string? GetDescription { get; set; }

  /// <summary>
  /// Callback executed when the toggle button is clicked.
  /// </summary>
  public string? OnAction { get; set; }

  /// <summary>
  /// Callback for dynamic pressed state of the toggle button.
  /// </summary>
  public string? GetPressed { get; set; }

  /// <summary>
  /// Enable interaction with the toggle button.
  /// </summary>
  public bool? Enabled { get; set; }

  /// <summary>
  /// Callback for dynamic enabled state.
  /// </summary>
  public string? GetEnabled { get; set; }

  /// <summary>
  /// Label text for the toggle button.
  /// </summary>
  public string? Label { get; set; }

  /// <summary>
  /// Callback for dynamic label text.
  /// </summary>
  public string? GetLabel { get; set; }

  /// <summary>
  /// Show the toggle button in the UI.
  /// </summary>
  public bool? Visible { get; set; }

  /// <summary>
  /// Callback for dynamic visibility.
  /// </summary>
  public string? GetVisible { get; set; }

  /// <summary>
  /// Keyboard shortcut (keytip) for accessing the toggle button.
  /// </summary>
  public string? Keytip { get; set; }

  /// <summary>
  /// Callback for dynamic keytip.
  /// </summary>
  public string? GetKeytip { get; set; }
}