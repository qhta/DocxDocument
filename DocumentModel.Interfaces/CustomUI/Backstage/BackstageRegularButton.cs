namespace DocumentModel.CustomUI;

/// <summary>
/// Represents a regular button in the Office Backstage view, supporting dynamic state, customizable appearance, and advanced callback integration for flexible UI scenarios.
/// </summary>
/// <remarks>
/// This interface defines a Backstage button with properties for tooltips, identification, state, labeling, images, keytips, and definitive action. It enables dynamic visibility, enabled state, labeling, and image selection, supporting comprehensive customization of the Backstage experience in Office applications.
/// </remarks>
public interface BackstageRegularButton: QualifiedElement, TaggedObject, PrimaryItem
{
  /// <summary>
  /// Screentip text for the Backstage button.
  /// </summary>
  public string? Screentip { get; set; }

  /// <summary>
  /// Callback for dynamic screentip text.
  /// </summary>
  public string? GetScreentip { get; set; }

  /// <summary>
  /// Supertip text for the Backstage button.
  /// </summary>
  public string? Supertip { get; set; }

  /// <summary>
  /// Callback for dynamic supertip text.
  /// </summary>
  public string? GetSupertip { get; set; }

  /// <summary>
  /// Callback executed when the button is clicked.
  /// </summary>
  public string? OnAction { get; set; }

  /// <summary>
  /// Indicates whether the button performs a definitive action.
  /// </summary>
  public bool? IsDefinitive { get; set; }

  /// <summary>
  /// Enable interaction with the Backstage button.
  /// </summary>
  public bool? Enabled { get; set; }

  /// <summary>
  /// Callback for dynamic enabled state.
  /// </summary>
  public string? GetEnabled { get; set; }

  /// <summary>
  /// Label text for the Backstage button.
  /// </summary>
  public string? Label { get; set; }

  /// <summary>
  /// Callback for dynamic label text.
  /// </summary>
  public string? GetLabel { get; set; }

  /// <summary>
  /// Show the Backstage button in the UI.
  /// </summary>
  public bool? Visible { get; set; }

  /// <summary>
  /// Callback for dynamic visibility.
  /// </summary>
  public string? GetVisible { get; set; }

  /// <summary>
  /// Keyboard shortcut (keytip) for accessing the button.
  /// </summary>
  public string? Keytip { get; set; }

  /// <summary>
  /// Callback for dynamic keytip.
  /// </summary>
  public string? GetKeytip { get; set; }

  /// <summary>
  /// Custom image identifier for the button icon.
  /// </summary>
  public string? Image { get; set; }

  /// <summary>
  /// Built-in Office image identifier for the button icon.
  /// </summary>
  public string? ImageMso { get; set; }

  /// <summary>
  /// Callback for dynamic button image.
  /// </summary>
  public string? GetImage { get; set; }
}