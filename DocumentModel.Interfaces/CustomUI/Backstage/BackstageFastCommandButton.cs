namespace DocumentModel;

/// <summary>
/// Represents a fast command button for the Office Backstage view, supporting dynamic state, flexible positioning, and advanced callback integration for custom UI scenarios.
/// </summary>
/// <remarks>
/// This interface defines a Backstage fast command button with properties for identification, positioning, state, labeling, images, keytips, and definitive action. It enables dynamic visibility, enabled state, labeling, and image selection, supporting comprehensive customization of the Backstage experience in Office applications.
/// </remarks>
public interface BackstageFastCommandButton: CustomUIControl, BuiltInControl
{

  /// <summary>
  /// Arbitrary tag value for custom data storage.
  /// </summary>
  public string? Tag { get; set; }

  /// <summary>
  /// Callback executed when the button is clicked.
  /// </summary>
  public string? OnAction { get; set; }

  /// <summary>
  /// Indicates whether the button performs a definitive action.
  /// </summary>
  public bool? IsDefinitive { get; set; }

  /// <summary>
  /// Enable interaction with the fast command button.
  /// </summary>
  public bool? Enabled { get; set; }

  /// <summary>
  /// Callback for dynamic enabled state.
  /// </summary>
  public string? GetEnabled { get; set; }

  /// <summary>
  /// Label text for the fast command button.
  /// </summary>
  public string? Label { get; set; }

  /// <summary>
  /// Callback for dynamic label text.
  /// </summary>
  public string? GetLabel { get; set; }

  /// <summary>
  /// Show the fast command button in the UI.
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