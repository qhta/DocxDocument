namespace DocumentModel;

/// <summary>
/// Represents a hyperlink control for the Office Backstage view, supporting navigation to external resources or document locations, dynamic state, customizable appearance, and advanced callback integration for flexible UI scenarios.
/// </summary>
/// <remarks>
/// This interface defines a hyperlink control for use in Office Backstage views (File menu). It supports navigation to external web resources, other documents, or specific document locations, and appears as a clickable text element with optional icon. The control supports static and dynamic target URLs, comprehensive formatting options, tooltips, layout behavior, and state management. The <c>OnAction</c> callback can override default navigation for custom handling. All properties can be set statically or determined dynamically through callback functions for responsive UI.
/// </remarks>
public interface Hyperlink: QualifiedElement
{

  /// <summary>
  /// Arbitrary tag value for custom data storage.
  /// </summary>
  public string? Tag { get; set; }

  /// <summary>
  /// Alignment behavior of the hyperlink label.
  /// </summary>
  public ExpandKind? AlignLabel { get; set; }

  /// <summary>
  /// Expansion behavior of the hyperlink control.
  /// </summary>
  public ExpandKind? Expand { get; set; }

  /// <summary>
  /// Enable interaction with the hyperlink.
  /// </summary>
  public bool? Enabled { get; set; }

  /// <summary>
  /// Callback for dynamic enabled state.
  /// </summary>
  public string? GetEnabled { get; set; }

  /// <summary>
  /// Show the hyperlink in the UI.
  /// </summary>
  public bool? Visible { get; set; }

  /// <summary>
  /// Callback for dynamic visibility.
  /// </summary>
  public string? GetVisible { get; set; }

  /// <summary>
  /// Keyboard shortcut (keytip) for accessing the hyperlink.
  /// </summary>
  public string? Keytip { get; set; }

  /// <summary>
  /// Callback for dynamic keytip.
  /// </summary>
  public string? GetKeytip { get; set; }

  /// <summary>
  /// Label text for the hyperlink.
  /// </summary>
  public string? Label { get; set; }

  /// <summary>
  /// Callback for dynamic label text.
  /// </summary>
  public string? GetLabel { get; set; }

  /// <summary>
  /// Callback executed when the hyperlink is clicked.
  /// </summary>
  public string? OnAction { get; set; }

  /// <summary>
  /// Custom image identifier for the hyperlink icon.
  /// </summary>
  public string? Image { get; set; }

  /// <summary>
  /// Built-in Office image identifier for the hyperlink icon.
  /// </summary>
  public string? ImageMso { get; set; }

  /// <summary>
  /// Callback for dynamic hyperlink image.
  /// </summary>
  public string? GetImage { get; set; }

  /// <summary>
  /// Screentip text for the hyperlink.
  /// </summary>
  public string? Screentip { get; set; }

  /// <summary>
  /// Callback for dynamic screentip text.
  /// </summary>
  public string? GetScreentip { get; set; }

  /// <summary>
  /// Supertip text for the hyperlink.
  /// </summary>
  public string? Supertip { get; set; }

  /// <summary>
  /// Callback for dynamic supertip text.
  /// </summary>
  public string? GetSupertip { get; set; }

  /// <summary>
  /// Target URL or location that the hyperlink navigates to when clicked.
  /// </summary>
  public string? Target { get; set; }

  /// <summary>
  /// Callback for dynamic target URL or location.
  /// </summary>
  public string? GetTarget { get; set; }
}